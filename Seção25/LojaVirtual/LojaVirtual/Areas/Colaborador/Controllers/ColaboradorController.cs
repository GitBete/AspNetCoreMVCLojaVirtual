using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models.Constants;
using LojaVirtual.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao(ColaboradorTipoConstant.Gerente)]
    public class ColaboradorController : Controller
    {
        private IColaboradorRepository _colaboradorRepositorio;
        private GerenciarEmail _gerenciarEmail;

        public ColaboradorController(IColaboradorRepository colaborador,GerenciarEmail gerenciarEmail)
        {
            _colaboradorRepositorio = colaborador;
            _gerenciarEmail = gerenciarEmail;
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult Index(int? pagina)
        {
            IPagedList<Models.Colaborador> colaboradores =  _colaboradorRepositorio.ObterTodosColaboradores(pagina);
            return View(colaboradores);
        }

       
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Models.Colaborador colaborador)
        {
            ModelState.Remove("Senha");
            if (ModelState.IsValid)
            {
                //Gerar nova senha, salvar e enviar email
                colaborador.Tipo = ColaboradorTipoConstant.Comum;
                //criamos essa classe copiando uma ja pronta da internet
                colaborador.Senha = KeyGenerator.GetUniqueKey(8);
                //Enviar email
                _gerenciarEmail.EnviarSenhaParaColabradorPorEmail(colaborador);

                _colaboradorRepositorio.Cadastrar(colaborador);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult GerarSenha(int id)
        {
            //todo, gerar senha aleatoria, salvar a senha nova, enviar email
            Models.Colaborador colaborador = _colaboradorRepositorio.ObterColaborador(id);
            colaborador.Senha = KeyGenerator.GetUniqueKey(8);
            //_colaboradorRepositorio.Atualizar(colaborador);
            _colaboradorRepositorio.AtualizarSenha(colaborador);

            //Enviar email
            _gerenciarEmail.EnviarSenhaParaColabradorPorEmail(colaborador);

            TempData["MSG_S"] = Mensagem.MSG_S003;

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult Atualizar(int id)
        {
            Models.Colaborador colaborador =_colaboradorRepositorio.ObterColaborador(id);
            return View(colaborador);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Models.Colaborador colaborador,int id)
        {
            ModelState.Remove("Senha");
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
        [ValidateHttpReferer]
        public IActionResult Excluir(int id)
        {
            _colaboradorRepositorio.Excluir(id);

            TempData["MSG_S"] = Mensagem.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
       
    }
}