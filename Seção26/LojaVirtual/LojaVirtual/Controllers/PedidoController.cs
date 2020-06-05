﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Json.Resolver;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LojaVirtual.Controllers
{
    [ClienteAutorizacao]
    public class PedidoController : Controller
    {
        private IPedidoRepository _pedidoRepository;
        private LoginCliente _loginCliente;

        public PedidoController(IPedidoRepository pedidoRepository, LoginCliente loginCliente)
        {
            _pedidoRepository = pedidoRepository;
            _loginCliente = loginCliente;
        }

        public IActionResult Index(int id)
        {
            Pedido pedido = _pedidoRepository.ObterPedido(id);

            if (pedido.ClienteId != _loginCliente.GetCliente().Id)
            {
                //retorno quando o usuario nao tem permissao para acessar uma pagina
                //Neste caso o pedido nao for do cliente logado
                //return new ForbidResult();
               return  new ContentResult() { Content = "Acesso Negado ! Cliente não autorizado para esse pedido." };
            }

            ViewBag.Produtos = JsonConvert.DeserializeObject<List<ProdutoItem>>(
                pedido.DadosProdutos,
                new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() }
                );

            var transacao = JsonConvert.DeserializeObject<TransacaoPagarMe>(pedido.DadosTransaction);
            ViewBag.Transacao = transacao;

            return View(pedido);
        }
    }
}