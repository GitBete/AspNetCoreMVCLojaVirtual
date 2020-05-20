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
    [ClienteAutorizacao]
    [ValidadeCookiePagamentoController]

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
        public IActionResult Index()
        {           
            List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();
            ValorPrazoFrete frete = ObterFrete();

            ViewBag.Frete = ObterFrete();                       
            ViewBag.Produtos = produtoItemComplento;
            ViewBag.Parcelamentos = CalcularParcelamento(produtoItemComplento,frete);

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
                              
                
                Parcelamento parcelaSelecionada = BuscarPacelamento(produtos,  indexViewModel.Parcelamento.Numero,frete);
                
                try
                {
                    Transaction transaction = _gerenciarPagarMe.GerarPagCartaoCredito(indexViewModel.CartaoCredito, parcelaSelecionada, enderecoEntrega, frete, produtos);

                    return new ContentResult() { Content = "Sucesso!" + transaction.Id };
                }
                catch(PagarMeException e)
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
                Transaction transaction = _gerenciarPagarMe.GerarBoleto(total);

                //redirecionar para pagina de sucesso
                return new ContentResult() { Content = "Sucesso!" + transaction.Id };

            }
            catch(PagarMeException e)
            {               
                TempData["MSG_E"] = MontarMensagemErro(e);

                return Index();
            }

        }

        //Metodos Privados ....

        private Parcelamento BuscarPacelamento(List<ProdutoItem> produtos,int numero,ValorPrazoFrete frete)
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

        private decimal ObterValorTotalCompra(List<ProdutoItem> produtos,ValorPrazoFrete frete)
        {
            decimal total = Convert.ToDecimal(frete.Valor);

            foreach (var produto in produtos)
            {
                total += produto.Valor;
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
    }
}
