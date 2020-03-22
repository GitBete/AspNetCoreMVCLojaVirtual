
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class CategoriaController : Controller
    {
        private ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public IActionResult Index(int? pagina)
        {
            //IEnumerable<Categoria> categorias = _categoriaRepository.ObterTodasCategorias();
            //return View(categorias);

            /*
             * Paginacao com a biblioteca:X.PagedList.Mvc.Core
             * codigo no repositorio para ocorrer desde a captura dos dados
             */

            var categorias = _categoriaRepository.ObterTodasCategorias(pagina);
            return View(categorias);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Categoria = _categoriaRepository.ObterTodasCategorias().Select(a=>new SelectListItem(a.Nome,a.Id.ToString()));
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar([FromForm]Categoria categoria)
        {
            //TODO - Implementar
            if (ModelState.IsValid)
            {
                _categoriaRepository.Cadastrar(categoria);

                TempData["MSG_S"] = "Registro salvo com sucesso!";

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categoria = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            //captura categoria selecioanda
            var categoria = _categoriaRepository.ObterCategoria(id);
           
            //Exibe todas as categorias pai, menos a que ja esta
            ViewBag.Categoria = _categoriaRepository.ObterTodasCategorias().Where(a=>a.Id != id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View(categoria);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Categoria categoria,int id)
        {
            if (ModelState.IsValid)
            {
                _categoriaRepository.Atualizar(categoria);

                TempData["MSG_S"] = "Registro salvo com sucesso!";

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categoria = _categoriaRepository.ObterTodasCategorias().Where(a => a.Id != id).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _categoriaRepository.Excluir(id);

            TempData["MSG_S"] = "Registro excluido com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    }
   
}