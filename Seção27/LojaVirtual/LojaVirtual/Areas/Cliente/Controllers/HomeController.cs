using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LojaVirtual.Models.ViewModels;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Repositories.Contracts;
using LojaVirtual.Repositories;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LojaVirtual.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
       
        private LoginCliente _loginCliente;
        private IClienteRepository _repositoryCliente;
        private IEnderecoEntregaRepository _enderecoEntregaRepository;

        public HomeController(LoginCliente loginCliente, IClienteRepository repositoryCliente, IEnderecoEntregaRepository enderecoEntregaRepository)
        {
            _loginCliente = loginCliente;
            _repositoryCliente = repositoryCliente;
            _enderecoEntregaRepository = enderecoEntregaRepository;
        }

      
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([FromForm]Models.Cliente cliente,string returnUrl=null)
        {
            //Persistir cliente no banco de dados
            Models.Cliente clienteDB = _repositoryCliente.Login(cliente.Email, cliente.Senha);

            if (clienteDB != null)
            {
                //Logado
                _loginCliente.Login(clienteDB);

                if (returnUrl == null)
                {
                    //return new RedirectResult(Url.Action(nameof(Painel)));
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
                
            }
            else
            {
                //nao logado
                ViewData["MSG_E"] = "Usuário não encontrado, verifique o e-mail e senha digitado!";
                return new ContentResult() { Content = "Não logado!" };
            }

        }

        [HttpGet]
        public IActionResult Sair()
        {
            _loginCliente.Logout();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

       

       
    }
}