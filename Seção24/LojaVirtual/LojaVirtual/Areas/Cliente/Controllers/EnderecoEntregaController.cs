using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    [ClienteAutorizacao]
    public class EnderecoEntregaController : Controller
    {
        private LoginCliente _loginCliente;
        private IEnderecoEntregaRepository _enderecoEntregaRepository;


        public EnderecoEntregaController(LoginCliente loginCliente, IEnderecoEntregaRepository enderecoEntregaRepository)
        {
            _loginCliente = loginCliente;
            _enderecoEntregaRepository = enderecoEntregaRepository;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var cliente = _loginCliente.GetCliente();
            ViewBag.Cliente = cliente;
            ViewBag.Enderecos = _enderecoEntregaRepository.ObterTodosEnderecoEntregaCliente(cliente.Id);

            return View();
        }

        //CRUD - Cadastro, Listagem, Atualizacao e Remocao

        [HttpGet]
        public IActionResult Cadastrar()
        {
            //essa tela deve iniciar com a opcao de cep selecionada na tela anterior
            //desenvolver a opcao de excluir
            //retirar a opcao de sex selecionada que ja esta exibindo na pagina
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] EnderecoEntrega enderecoEntrega, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                enderecoEntrega.ClienteId = _loginCliente.GetCliente().Id;

                _enderecoEntregaRepository.Cadastrar(enderecoEntrega);

                if (returnUrl == null)
                {
                    //listagem de endereco
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Models.Cliente cliente = _loginCliente.GetCliente();
            EnderecoEntrega enderecoEntrega = _enderecoEntregaRepository.ObterEnderecoEntrega(Id);

            if (cliente.Id != enderecoEntrega.ClienteId) 
            {
                return new ContentResult() { Content = "Acesso negado." };
            }

            return View(enderecoEntrega);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] EnderecoEntrega enderecoEntrega, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                enderecoEntrega.ClienteId = _loginCliente.GetCliente().Id;

                _enderecoEntregaRepository.Atualizar(enderecoEntrega);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
               
            }
            return View();
        }

        [HttpGet]       
        public ActionResult Excluir(int Id)
        {
            Models.Cliente cliente = _loginCliente.GetCliente();
            EnderecoEntrega endereco = _enderecoEntregaRepository.ObterEnderecoEntrega(Id);

            if (cliente.Id == endereco.ClienteId)
            {
                _enderecoEntregaRepository.Excluir(Id);

                TempData["MSG_S"] = Mensagem.MSG_S002;

                return RedirectToAction(nameof(Index));

            }
            else
            {
                return new ContentResult() { Content = "Acesso negado." };

            }

        }
    }
}