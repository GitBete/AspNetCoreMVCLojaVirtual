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
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
                               
                ViewBag.Frete = ObterFrete(cep.ToString());
                List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();
                ViewBag.Produtos = produtoItemComplento;

                return View("Index");               
            }

            TempData["MSG_E"] = Mensagem.MSG_E009;
            return RedirectToAction("EnderecoEntrega", "CarrinhoCompra");

        }

        [HttpPost]
        [ClienteAutorizacao]        
        public IActionResult Index([FromForm]CartaoCredito cartaoCredito)
        {

            if (ModelState.IsValid)
            {
                //integrar com pagar.Me, Salvar Pedido e redirecionar para pagina de pedido concluido
                EnderecoEntrega enderecoEntrega = ObterEndereco();
                ValorPrazoFrete frete = ObterFrete(enderecoEntrega.CEP.ToString());
                List<ProdutoItem> produtos = CarregarProdutoDB();

                try
                {
                    dynamic pagarMeResposta = _gerenciarPagarMe.GerarPagCartaoCredito(cartaoCredito, enderecoEntrega, frete, produtos);

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
    }

}
