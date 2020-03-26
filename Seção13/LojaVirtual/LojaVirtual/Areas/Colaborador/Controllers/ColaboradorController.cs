using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace LojaVirtual.Controllers
{    
    [Area("Colaborador")]
    public class ColaboradorController : Controller
    {
        private IColaboradorRepository _colaboradorRepositorio;
        private GerenciarEmail _gerenciarEmail;

        public ColaboradorController(IColaboradorRepository colaborador,GerenciarEmail gerenciarEmail)
        {
            _colaboradorRepositorio = colaborador;
            _gerenciarEmail = gerenciarEmail;
        }

        public IActionResult Index(int? pagina)
        {
            IPagedList<Models.Colaborador> colaboradores =  _colaboradorRepositorio.ObterTodosColaboradores(pagina);
            return View(colaboradores);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Models.Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                //Gerar nova senha, salvar e enviar email
                colaborador.Tipo = "C";
                _colaboradorRepositorio.Cadastrar(colaborador);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult GerarSenha(int id)
        {
            //todo, gerar senha aleatoria, salvar a senha nova, enviar email
            Models.Colaborador colaborador = _colaboradorRepositorio.ObterColaborador(id);
            colaborador.Senha = KeyGenerator.GetUniqueKey(8);
            _colaboradorRepositorio.Atualizar(colaborador);

            //Enviar email
            _gerenciarEmail.EnviarSenhaParaColabradorPorEmail(colaborador);

            TempData["MSG_S"] = Mensagem.MSG_S003;

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Models.Colaborador colaborador =_colaboradorRepositorio.ObterColaborador(id);
            return View(colaborador);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Models.Colaborador colaborador,int id)
        {
            if (ModelState.IsValid)
            {
                _colaboradorRepositorio.Atualizar(colaborador);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
           // ViewBag.Colaborador = _colaboradorRepositorio.ObterTodosColaboradores().Where(a => a.Id != id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _colaboradorRepositorio.Excluir(id);

            TempData["MSG_S"] = Mensagem.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
       
    }
}