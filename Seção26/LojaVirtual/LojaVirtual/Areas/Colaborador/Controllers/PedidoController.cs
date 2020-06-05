using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class PedidoController : Controller
    {
       
        private IPedidoRepository _pedidoRepository;
        private IPedidoSituacoesRepository _pedidoSituacaoRepository;

        public PedidoController(IPedidoRepository pedidoRepository, IPedidoSituacoesRepository pedidoSituacaoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _pedidoSituacaoRepository = pedidoSituacaoRepository;
        }

        public IActionResult Index(int?pagina,string codigoPedido,string cpf)
        {
            var pedidos = _pedidoRepository.ObterTodosPedidos(pagina, codigoPedido, cpf);

            return View(pedidos);
        }

        public IActionResult Visualizar(int Id)
        {
            Pedido pedido = _pedidoRepository.ObterPedido(Id);

            return View(pedido);
        }

        public IActionResult NFE(int id)
        {
            string url = HttpContext.Request.Form["nfe_url"];

            Pedido pedido = _pedidoRepository.ObterPedido(id);
            pedido.NFe = url;
            pedido.Situacao = PedidoSituacaoConstant.NF_EMITIDA;

            var pedidoSituacao = new PedidoSituacao();
            pedidoSituacao.Data = DateTime.Now;
            pedidoSituacao.Dados = url;
            pedidoSituacao.PedidoId = pedido.Id;
            pedidoSituacao.Situacao = PedidoSituacaoConstant.NF_EMITIDA;

            _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
            _pedidoRepository.Atualizar(pedido);

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }

        public IActionResult RegistrarRastreamento(int id)
        {
            string codRastreamento = HttpContext.Request.Form["cod_rastreamento"];

            Pedido pedido = _pedidoRepository.ObterPedido(id);
            pedido.FreteCodRastreamento = codRastreamento;
            pedido.Situacao = PedidoSituacaoConstant.EM_TRANSPORTE;

            var pedidoSituacao = new PedidoSituacao();
            pedidoSituacao.Data = DateTime.Now;
            pedidoSituacao.Dados = codRastreamento;
            pedidoSituacao.PedidoId = pedido.Id;
            pedidoSituacao.Situacao = PedidoSituacaoConstant.EM_TRANSPORTE;

            _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
            _pedidoRepository.Atualizar(pedido);

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }
    }
}