using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LojaVirtual.Controllers.Base;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Cookie;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{

    public class PagamentoController : BaseController
    {
        private Cookie _cookie;

        public PagamentoController(
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
                  cookieValorPrazoFrete)
        {
            _cookie = cookie;
        }

        [ClienteAutorizacao]
        [HttpGet]
        public IActionResult Index()
        {

            var tipoFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.TipoFrete", false);

            if (tipoFreteSelecionadoPeloUsuario != null)
            {
                var enderecoEntregaId = int.Parse(_cookie.Consultar("Carrinho.Endereco", false).Replace("-end", ""));

                var cep = 0;

                if (enderecoEntregaId == 0)
                {
                    cep = int.Parse(Mascara.Remover(_loginCliente.GetCliente().CEP));
                }
                else
                {
                    var endereco = _enderecoEntregaRepository.ObterEnderecoEntrega(enderecoEntregaId);
                    //enderecoEntrega = endereco;
                    cep = int.Parse(Mascara.Remover(endereco.CEP));
                };

                var carrinhoHash = GerarHash(_cookieCarrinhoCompra.Consultar());

                Frete frete = _cookieFrete.Consultar().Where(a => a.CEP == cep && a.CodCarrinho == carrinhoHash).FirstOrDefault();

                if (frete != null)
                {
                    ViewBag.Frete = frete.ListaValores.Where(a => a.TipoFrete == tipoFreteSelecionadoPeloUsuario).FirstOrDefault();
                    List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();
                    ViewBag.Produtos = produtoItemComplento;

                    return View("index");

                }
                else
                {
                    return RedirectToAction("EnderecoEntrega", "CarrinhoCompra");
                }
            }

            TempData["MSG_E"] = Mensagem.MSG_E009;
            return RedirectToAction("EnderecoEntrega", "CarrinhoCompra");

        }

        [ClienteAutorizacao]
        [HttpGet]
        public IActionResult Index([FromForm]CartaoCredito cartaoCredito)
        {

            if (ModelState.IsValid)
            {
                //integrar com pagar.Me, Salvar Pedido e redirecionar para pagina de pedido concluido
                return View();
            }
            else
            {
                //precher dados da tela inicial
                return Index();
            }

            
        }


    }

}
