using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class ClienteController : Controller
    {
        private IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
             _clienteRepository = clienteRepository;
        }

        public IActionResult Index(int? pagina,string pesquisa)
        {
            IPagedList<Models.Cliente> cliente = _clienteRepository.ObterTodosClientes(pagina,pesquisa);
            return View(cliente);
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult AtivarDesativar(int Id)
        {
            Models.Cliente cliente = _clienteRepository.ObterCliente(Id);
            cliente.Situacao = (cliente.Situacao == SituacaoConstant.Ativo) ? cliente.Situacao = SituacaoConstant.Inativo : cliente.Situacao = SituacaoConstant.Ativo;

            _clienteRepository.Atualizar(cliente);

            TempData["MSG_S"] = Mensagem.MSG_S001;

            return RedirectToAction(nameof(Index));
        }
    }
}