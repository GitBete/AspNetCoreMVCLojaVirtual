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

namespace LojaVirtual.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
       
        private LoginCliente _loginCliente;
        private IClienteRepository _repositoryCliente;

        public HomeController(LoginCliente loginCliente, IClienteRepository repositoryCliente)
        {
            _loginCliente = loginCliente;
            _repositoryCliente = repositoryCliente;
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
                    return new RedirectResult(Url.Action(nameof(Painel)));
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
        [ClienteAutorizacao]
        public IActionResult Painel()
        {
            //if (HttpContext.Session.TryGetValue("ID",out UsuarioID))
            //{
            //    return new ContentResult() { Content = "Usuário " + UsuarioID[0] + ". E-mail: " + HttpContext.Session.GetString("Email")  + " - Idade: " + HttpContext.Session.GetInt32("Idade")  + ". Logado!" };
            //}
            //else
            //{
            //    return new ContentResult() { Content = "Acesso Negado. "};
            //}

            return new ContentResult() { Content = "Esse é o painel do Cliente. " };

        }

        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm]Models.Cliente cliente,string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                //Chama repository
                _repositoryCliente.Cadastrar(cliente);

                _loginCliente.Login(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                //Implementar redirecionamentos diferentes (Painel, carrinho de compras ...)

                if (returnUrl == null)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
                


            }

            return View();
        }
    }
}