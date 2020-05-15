using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LojaVirtual.Controllers.Base;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Cookie;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Libraries.Gerenciador.Pagamento.PagarMe;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Models.ViewModels.Pagamento;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PagarMe;

namespace LojaVirtual.Controllers
{

    public class PagamentoController : BaseController
    {
        private Cookie _cookie;
        private GerenciarPagarMe _gerenciarPagarMe;

        public PagamentoController(
            GerenciarPagarMe gerenciarPagarMe,
            Cookie cookie, 
            LoginCliente loginCliente ,
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
            _cookie = cookie;
            _gerenciarPagarMe = gerenciarPagarMe;
        }

        [HttpGet]
        [ClienteAutorizacao]        
        public IActionResult Index()
        {

            var tipoFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.TipoFrete", false);

            if (tipoFreteSelecionadoPeloUsuario != null)
            {
                var enderecoEntrega = ObterEndereco();
                var carrinhoHash = GerarHash(_cookieCarrinhoCompra.Consultar());
                int cep = int.Parse(Mascara.Remover(enderecoEntrega.CEP));
                List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();
                var frete = ObterFrete(cep.ToString());

                var total = ObterValorTotalCompra(produtoItemComplento, frete);
                var parcelamento = _gerenciarPagarMe.CalcularPagamentoParcelado(total);

                ViewBag.Frete = ObterFrete(cep.ToString());                
                ViewBag.Produtos = produtoItemComplento;
                //exibir modelo: "2x R$ 100,00 s/Juros - TOTAL: R$ 200,00"
                ViewBag.Parcelamentos = parcelamento.Select(a=> new SelectListItem(
                    String.Format("{0}x {1} {2} - TOTAL: {3}", 
                    a.Numero,
                    a.ValorPorParcela.ToString("C"),
                    (a.Juros)?"c/ Juros":"s/ Juros",
                    a.Valor.ToString("C")),
                    a.Numero.ToString()
                    )).ToList();               

                return View("Index");               
            }

            TempData["MSG_E"] = Mensagem.MSG_E009;
            return RedirectToAction("EnderecoEntrega", "CarrinhoCompra");

        }

        [HttpPost]
        [ClienteAutorizacao]        
        public IActionResult Index([FromForm]IndexViewModel indexViewModel)
        {

            if (ModelState.IsValid)
            {
                //integrar com pagar.Me, Salvar Pedido e redirecionar para pagina de pedido concluido
                EnderecoEntrega enderecoEntrega = ObterEndereco();
                ValorPrazoFrete frete = ObterFrete(enderecoEntrega.CEP.ToString());
                List<ProdutoItem> produtos = CarregarProdutoDB();
                              
                var total = ObterValorTotalCompra(produtos, frete);
                var parcela = _gerenciarPagarMe.CalcularPagamentoParcelado(total).Where(a=> a.Numero == indexViewModel.Parcelamento.Numero).First();
                
                try
                {
                    dynamic pagarMeResposta = _gerenciarPagarMe.GerarPagCartaoCredito(indexViewModel.CartaoCredito, parcela, enderecoEntrega, frete, produtos);

                    return new ContentResult() { Content = "Sucesso!" + pagarMeResposta.TransactionId };
                }
                catch(PagarMeException e)
                {
                    //ERROS PAGAR.ME
                    StringBuilder sb = new StringBuilder();
                    if (e.Error.Errors.Count()>0)
                    {
                        sb.Append("Erro no Pagamento: ");

                        foreach (var erro in e.Error.Errors)
                        {
                            sb.Append("-" + erro.Message + "<br />");
                        }
                        
                    }
                    TempData["MSG_E"] = sb.ToString();

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
            ValorPrazoFrete frete = ObterFrete(enderecoEntrega.CEP.ToString());
            List<ProdutoItem> produtos = CarregarProdutoDB();

            var total = ObterValorTotalCompra(produtos, frete);
            //var parcela = _gerenciarPagarMe.CalcularPagamentoParcelado(total).Where(a => a.Numero == indexViewModel.Parcelamento.Numero).First();

            try
            {
                Boleto boleto = _gerenciarPagarMe.GerarBoleto(total);

                return new ContentResult() { Content = "Sucesso!" + boleto.TransactionId };

            }
            catch(PagarMeException e)
            {
                    //ERROS PAGAR.ME
                    StringBuilder sb = new StringBuilder();
                    if (e.Error.Errors.Count()>0)
                    {
                        sb.Append("Erro no Pagamento: ");

                        foreach (var erro in e.Error.Errors)
                        {
                            sb.Append("-" + erro.Message + "<br />");
                        }

                    }
                    TempData["MSG_E"] = sb.ToString();

                    return Index();
            }

            //if (boleto.Erro != null)
            //{
            //    TempData["MSG_E"] = boleto.Erro;
            //    return RedirectToAction(nameof(Index));
            //}
            //else
            //{
            //    return new ContentResult() { Content = "Sucesso!" + boleto.TransactionId };
            //    //return View("PedidoSucesso");
            //}

           
        }


        private EnderecoEntrega ObterEndereco()
        {

            EnderecoEntrega enderecoEntrega = null;           
            var enderecoEntregaId = int.Parse(_cookie.Consultar("Carrinho.Endereco", false).Replace("-end", ""));

            var cep = 0;

            if (enderecoEntregaId == 0)
            {
                Cliente cliente = _loginCliente.GetCliente();
                enderecoEntrega = new EnderecoEntrega();
                enderecoEntrega.Nome = "Endereço do Ciente";
                enderecoEntrega.Id = 0;
                enderecoEntrega.UF = cliente.UF;
                enderecoEntrega.Cidade = cliente.Cidade;
                enderecoEntrega.Bairro = cliente.Bairro;
                enderecoEntrega.Logradouro = cliente.Logradouro;
                enderecoEntrega.Complemento = cliente.Complemento;
                enderecoEntrega.LogradouroNumr = cliente.LogradouroNumr;
                enderecoEntrega.CEP = cliente.CEP;

                return enderecoEntrega;
            }
            else
            {
                var endereco = _enderecoEntregaRepository.ObterEnderecoEntrega(enderecoEntregaId);

                return endereco;
            }

        }

        private ValorPrazoFrete ObterFrete(string CEP)
        {
            var tipoFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.TipoFrete", false);
            var carrinhoHash = GerarHash(_cookieCarrinhoCompra.Consultar());

            int cep = int.Parse(Mascara.Remover(CEP));

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

        private decimal ObterValorTotalCompra(List<ProdutoItem> produtos,ValorPrazoFrete frete)
        {
            decimal total = Convert.ToDecimal(frete.Valor);

            foreach (var produto in produtos)
            {
                total += produto.Valor;
            }


            return total;

        }
    }

}
