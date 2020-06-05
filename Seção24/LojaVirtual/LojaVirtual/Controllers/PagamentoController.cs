using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LojaVirtual.Controllers.Base;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Cookie;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Libraries.Gerenciador.Pagamento.PagarMe;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Models.ViewModels.Pagamento;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using PagarMe;

namespace LojaVirtual.Controllers
{
    [ClienteAutorizacao]
    [ValidadeCookiePagamentoController]

    public class PagamentoController : BaseController
    {
        private Cookie _cookie;
        private GerenciarPagarMe _gerenciarPagarMe;
        private IPedidoRepository _PedidoRepository;
        private IPedidoSituacoesRepository _pedidoSituacoesRepository;
        private GerenciarEmail _gerenciarEmail;

        public PagamentoController(
            GerenciarEmail gerenciarEmail,
            IPedidoRepository PedidoRepository,
            IPedidoSituacoesRepository pedidoSituacoesRepository,
            GerenciarPagarMe gerenciarPagarMe,
            Cookie cookie,
            LoginCliente loginCliente,
            CookieCarrinhoCompra cookiecarrinhoCompra,
            IEnderecoEntregaRepository enderecoEntregaRepository,
            IProdutoRepository produtoRepository,
            IMapper mapper,
            WSCorreiosCalcularFrete wscorreios,
            CalcularPacote calcularPacote,
            CookieFrete cookieValorPrazoFrete)
            : base(
                  loginCliente,
                  cookiecarrinhoCompra,
                  enderecoEntregaRepository,
                  produtoRepository,
                  mapper,
                  wscorreios,
                  calcularPacote,
                  cookieValorPrazoFrete
                  )
        {
            _PedidoRepository = PedidoRepository;
            _pedidoSituacoesRepository = pedidoSituacoesRepository;
            _gerenciarPagarMe = gerenciarPagarMe;
            _cookie = cookie;
            _gerenciarEmail = gerenciarEmail;
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();
            ValorPrazoFrete frete = ObterFrete();

            ViewBag.Frete = ObterFrete();
            ViewBag.Produtos = produtoItemComplento;
            ViewBag.Parcelamentos = CalcularParcelamento(produtoItemComplento, frete);

            return View("Index");

            TempData["MSG_E"] = Mensagem.MSG_E009;
            return RedirectToAction("EnderecoEntrega", "CarrinhoCompra");

        }


        [HttpPost]
        public IActionResult Index([FromForm]IndexViewModel indexViewModel)
        {
            if (ModelState.IsValid)
            {
                //integrar com pagar.Me, Salvar Pedido e redirecionar para pagina de pedido concluido
                EnderecoEntrega enderecoEntrega = ObterEndereco();
                ValorPrazoFrete frete = ObterFrete();
                List<ProdutoItem> produtos = CarregarProdutoDB();

                Parcelamento parcelaSelecionada = BuscarPacelamento(produtos, indexViewModel.Parcelamento.Numero, frete);

                try
                {
                    Transaction transaction = _gerenciarPagarMe.GerarPagCartaoCredito(indexViewModel.CartaoCredito, parcelaSelecionada, enderecoEntrega, frete, produtos);
                    Pedido pedido = ProcessarPedido(frete, produtos, transaction);

                    return new RedirectToActionResult("Index", "Pedido", new { id = pedido.Id });

                    //return new ContentResult() { Content = "Sucesso!" + pedido.Id };

                    //redirecionar para tela de pedido realizado com sucesso
                }
                catch (PagarMeException e)
                {
                    TempData["MSG_E"] = MontarMensagemErro(e);

                    return Index();
                }


                //return new ContentResult() { Content = "Sucesso!" };
            }

            //precher dados da tela inicial
            return Index();

        }



        public IActionResult BoletoBancario()
        {
            EnderecoEntrega enderecoEntrega = ObterEndereco();
            ValorPrazoFrete frete = ObterFrete();
            List<ProdutoItem> produtos = CarregarProdutoDB();

            var total = ObterValorTotalCompra(produtos, frete);
            //var parcela = _gerenciarPagarMe.CalcularPagamentoParcelado(total).Where(a => a.Numero == indexViewModel.Parcelamento.Numero).First();

            try
            {
                Transaction transaction = _gerenciarPagarMe.GerarBoleto(total, enderecoEntrega, frete, produtos); 
                Pedido pedido = ProcessarPedido(frete, produtos, transaction);

                return new RedirectToActionResult("Index", "Pedido", new { id = pedido.Id });

                //redirecionar para pagina de sucesso
                //return new ContentResult() { Content = "Sucesso!" + pedido.Id };

            }
            catch (PagarMeException e)
            {
                TempData["MSG_E"] = MontarMensagemErro(e);

                return Index();
            }

        }

        //Metodos Privados ....

        private Parcelamento BuscarPacelamento(List<ProdutoItem> produtos, int numero, ValorPrazoFrete frete)
        {
            var total = ObterValorTotalCompra(produtos, frete);

            var parcela = _gerenciarPagarMe.CalcularPagamentoParcelado(total).Where(a => a.Numero == numero).First();

            return parcela;
        }

        private EnderecoEntrega ObterEndereco()
        {

            EnderecoEntrega enderecoEntrega = null;
            var enderecoEntregaId = int.Parse(_cookie.Consultar("Carrinho.Endereco", false).Replace("-end", ""));

            var cep = 0;

            if (enderecoEntregaId == 0)
            {
                Cliente cliente = _loginCliente.GetCliente();
                enderecoEntrega = _mapper.Map<EnderecoEntrega>(cliente);

                return enderecoEntrega;
            }
            else
            {
                var endereco = _enderecoEntregaRepository.ObterEnderecoEntrega(enderecoEntregaId);

                return endereco;
            }

        }

        private ValorPrazoFrete ObterFrete()
        {
            var enderecoEntrega = ObterEndereco();
            int cep = int.Parse(Mascara.Remover(enderecoEntrega.CEP));
            var tipoFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.TipoFrete", false);

            var carrinhoHash = GerarHash(_cookieCarrinhoCompra.Consultar());

            Frete frete = _cookieFrete.Consultar().Where(a => a.CEP == cep && a.CodCarrinho == carrinhoHash).FirstOrDefault();

            if (frete != null)
            {
                return frete.ListaValores.Where(a => a.TipoFrete == tipoFreteSelecionadoPeloUsuario).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        private decimal ObterValorTotalCompra(List<ProdutoItem> produtos, ValorPrazoFrete frete)
        {
            decimal total = Convert.ToDecimal(frete.Valor);

            foreach (var produto in produtos)
            {
                total += (produto.Valor * produto.QuantidadeProdutoCarrinho);
            }

            return total;

        }

        private List<SelectListItem> CalcularParcelamento(List<ProdutoItem> produtos, ValorPrazoFrete frete)
        {
            var total = ObterValorTotalCompra(produtos, frete);
            var parcelamento = _gerenciarPagarMe.CalcularPagamentoParcelado(total);

            //exibir modelo: "2x R$ 100,00 s/Juros - TOTAL: R$ 200,00"
            return parcelamento.Select(a => new SelectListItem(
                String.Format("{0}x {1} {2} - TOTAL: {3}",
                a.Numero,
                a.ValorPorParcela.ToString("C"),
                (a.Juros) ? "c/ Juros" : "s/ Juros",
                a.Valor.ToString("C")),
                a.Numero.ToString()
                )).ToList();
        }


        private string MontarMensagemErro(PagarMeException e)
        {
            //ERROS PAGAR.ME
            StringBuilder sb = new StringBuilder();
            if (e.Error.Errors.Count() > 0)
            {
                sb.Append("Erro no Pagamento: ");

                foreach (var erro in e.Error.Errors)
                {
                    sb.Append("-" + erro.Message + "<br />");
                }

            }
            return sb.ToString();
        }

        private Pedido ProcessarPedido(ValorPrazoFrete frete, List<ProdutoItem> produtos, Transaction transaction)
        {
            TransacaoPagarMe transacaoPagarMe;
            Pedido pedido;
            SalvarPedido(produtos, transaction, out transacaoPagarMe, out pedido);

            SalvarPedidoSituacao(produtos, transacaoPagarMe, pedido);

            BaixaEstoque(produtos);

            //remover os itens do carrinho de compras finalizado
            _cookieCarrinhoCompra.RemoverTodos();

            _gerenciarEmail.EnviarDadosDoPedidoPorEmail(_loginCliente.GetCliente(),pedido);

            return pedido;
        }

       


        private void SalvarPedido(List<ProdutoItem> produtos, Transaction transaction, out TransacaoPagarMe transacaoPagarMe, out Pedido pedido)
        {
            transacaoPagarMe = _mapper.Map<TransacaoPagarMe>(transaction);

            //1.Pedido
            pedido = _mapper.Map<Pedido>(new Tuple<TransacaoPagarMe, List<ProdutoItem>>(transacaoPagarMe, produtos));
            pedido.Situacao = PedidoSituacaoConstant.PEDIDO_REALIZADO;
            //Grava Pedido no Banco de Dados
            _PedidoRepository.Cadastrar(pedido);
        }

        private void SalvarPedidoSituacao(List<ProdutoItem> produtos, TransacaoPagarMe transacaoPagarMe, Pedido pedido)
        {
            //2.Pedido situacao
            TransactionProduto tp = new TransactionProduto { TransacaoPagarMe = transacaoPagarMe, Produtos = produtos };
            PedidoSituacao pedidosituacao = _mapper.Map<PedidoSituacao>(new Tuple<Pedido, TransactionProduto>(pedido, tp));
            pedidosituacao.Situacao = PedidoSituacaoConstant.PEDIDO_REALIZADO;
            //Grava PedidoSituacao no Banco de Dados
            _pedidoSituacoesRepository.Cadastrar(pedidosituacao);
        }

        private void BaixaEstoque(List<ProdutoItem> produtos)
        {
            //3.Atualizar estoque
            foreach (var produto in produtos)
            {
                Produto produtoDB = _produtoRepository.ObterProduto(produto.Id);

                produtoDB.Quantidade -= produto.QuantidadeProdutoCarrinho;
                _produtoRepository.Atualizar(produtoDB);
            }
        }

        private Pedido SalvarPedidoProfessor(ValorPrazoFrete frete, List<ProdutoItem> produtos, Transaction transaction)
        {
            //Nao to utilizando ... guardei codigo do professor
            TransacaoPagarMe transacaoPagarMe = _mapper.Map<TransacaoPagarMe>(transaction);

            //Pedido pedido = _mapper.Map< TransacaoPagarMe ,Pedido >(transacaoPagarMe);
            //pedido = _mapper.Map<List<ProdutoItem>, Pedido>(produtos, pedido);

            Pedido pedido = _mapper.Map<Pedido>(new Tuple<TransacaoPagarMe, List<ProdutoItem>>(transacaoPagarMe, produtos));
            pedido.Situacao = PedidoSituacaoConstant.PEDIDO_REALIZADO;

            //TODO - Salvar pedido - colocou isso no automaper
            //Pedido pedido = new Pedido();
            //pedido.ClienteId = int.Parse(transaction.Customer.Id);
            //pedido.TransactionId = transaction.Id;
            //pedido.FreteEmpresa = "ECT - Correios";
            //pedido.FormaPagamento = (transaction.PaymentMethod == 0) ? "Cartao de Credito" : "Boleto";
            //pedido.ValorTotal = ObterValorTotalCompra(produtos, frete);
            //pedido.DadosTransaction = JsonConvert.SerializeObject(transaction); //serializar
            //pedido.DadosProdutos = JsonConvert.SerializeObject(produtos); //seriealizar
            //pedido.DataRegistro = DateTime.Now;
            //pedido.Situacao = PedidoSituacaoConstant.AGUARDANDO_PAGAMENTO; //criar constantes

            _PedidoRepository.Cadastrar(pedido);

            //pedido situacao

            TransactionProduto tp = new TransactionProduto { TransacaoPagarMe = transacaoPagarMe, Produtos = produtos };
            //PedidoSituacao pedidosituacao = _mapper.Map<Pedido, PedidoSituacao>(pedido);
            //pedidoSituacao = _mapper.Map<TransactionProduto, PedidoSituacao>(tp, pedidosituacao);

            PedidoSituacao pedidosituacao = _mapper.Map<PedidoSituacao>(new Tuple<Pedido, TransactionProduto>(pedido, tp));

            pedidosituacao.Situacao = PedidoSituacaoConstant.PEDIDO_REALIZADO;

            //PedidoSituacao pedidosituacao = new PedidoSituacao();
            //pedidosituacao.PedidoId = pedido.Id;
            //pedidosituacao.Data = DateTime.Now;
            //pedidosituacao.Dados = JsonConvert.SerializeObject(new TransactionProduto { TransacaoPagarMe = transacaoPagarMe, Produtos = produtos });
            //pedidosituacao.Situacao = PedidoSituacaoConstant.AGUARDANDO_PAGAMENTO;

            _pedidoSituacoesRepository.Cadastrar(pedidosituacao);

            //TODO - Atualizar estoque

            return pedido;
        }
    }
}
