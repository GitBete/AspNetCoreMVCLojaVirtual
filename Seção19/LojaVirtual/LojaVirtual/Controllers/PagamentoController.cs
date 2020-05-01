﻿using System;
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
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{

    public class PagamentoController : BaseController
    {
        private Cookie _cookie;

        public PagamentoController(Cookie cookie,CookieCarrinhoCompra cookiecarrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper, WSCorreiosCalcularFrete wscorreios, CalcularPacote calcularPacote, CookieValorPrazoFrete cookieValorPrazoFrete) : base(cookiecarrinhoCompra, produtoRepository, mapper, wscorreios, calcularPacote, cookieValorPrazoFrete)
        {
            _cookie = cookie;
        }

        [ClienteAutorizacao]
        public IActionResult Index()
        {
            var tipoFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.TipoFrete", false);

            var frete = _cookieValorPrazoFrete.Consultar().Where(a => a.TipoFrete == tipoFreteSelecionadoPeloUsuario).FirstOrDefault();

            if (frete != null)
            {
                ViewBag.Frete = frete;
                List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();
                return View(produtoItemComplento);

            }

            TempData["MSG_E"] = Mensagem.MSG_E009;
            return RedirectToAction("Index", "CarrinhoCompra");

        }

    }

}
