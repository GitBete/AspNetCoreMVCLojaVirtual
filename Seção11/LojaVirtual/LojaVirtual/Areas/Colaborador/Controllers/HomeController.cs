using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class HomeController : Controller
    {
        private IColaboradorRepository _repositoryColaborador;
        private LoginColaborador _loginColaborador;

        public HomeController(IColaboradorRepository repositoryColaborador, LoginColaborador loginColaborador)
        {
            _repositoryColaborador = repositoryColaborador;
            _loginColaborador = loginColaborador;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Models.Colaborador colaborador)
        {
            //Persistir cliente no banco de dados
            Models.Colaborador colaboradorDB = _repositoryColaborador.Login(colaborador.Email, colaborador.Senha);

            if (colaboradorDB != null)
            {
                //Logado
                _loginColaborador.Login(colaboradorDB);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                //nao logado
                ViewData["MSG_E"] = "Colaborador não encontrado, verifique o e-mail e senha digitado!";
                return View();
            }
        }
                

        [ColaboradorAutorizacao]
        public IActionResult Logout()
        {
            _loginColaborador.Logout();
            return RedirectToActionPermanent("Login", "Home");
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }

        public IActionResult CadastrarNovaSenha()
        {
            return View();
        }

        [HttpGet]
        [ColaboradorAutorizacao]
        public IActionResult Painel()
        {
            //return new ContentResult() { Content = "Esse é o painel do Colaborador. " };
            return View();
        }

    }
}