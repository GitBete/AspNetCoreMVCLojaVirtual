using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class PedidoController : Controller
    {
       
        private IPedidoRepository _pedidoRepository;   

        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;       
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
    }
}