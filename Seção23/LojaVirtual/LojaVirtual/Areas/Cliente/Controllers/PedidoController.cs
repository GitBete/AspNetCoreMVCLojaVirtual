using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class PedidoController : Controller
    {
        private LoginCliente _loginCliente;
        private IPedidoRepository _pedidoRepository;

        public PedidoController(LoginCliente loginCliente, IPedidoRepository pedidoRepository)
        {
            _loginCliente = loginCliente;
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index(int?pagina)
        {

            Models.Cliente cliente = _loginCliente.GetCliente();
            var pedidos = _pedidoRepository.ObterTodosPedidosCliente(pagina, cliente.Id);

            return View(pedidos);
        }

        public IActionResult Visualizar(int Id)
        {
            Models.Cliente cliente = _loginCliente.GetCliente();
            var pedido = _pedidoRepository.ObterPedido(Id);

            if (cliente.Id != pedido.ClienteId)
            {
                return new ContentResult() { Content = "Acesso negado." };
            }

            return View(pedido);

        }
    }
}