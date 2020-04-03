using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        } 

        public IActionResult Index(int? pagina, string pesquisa)
        {
            var produto = _produtoRepository.ObterTodosProdutos(pagina, pesquisa);
            return View(produto);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //joga a propriedade la para tela Cadastrar.cshtml - SelectListItem usado para ser compativel
            ViewBag.Categorias =  _categoriaRepository.ObterTodasCategorias().Select(a=>new SelectListItem(a.Nome,a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
           if (ModelState.IsValid)
            {
                _produtoRepository.Cadastrar(produto);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categoria = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpGet]
        public ActionResult Atualizar(int Id)
        {
            //Tela responsavel por exibir o produto escolhido

            //joga a propriedade la para tela Cadastrar.cshtml - SelectListItem usado para ser compativel
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));

            //Consulta produto
            Produto produto = _produtoRepository.ObterProduto(Id);

            return View(produto);
        }

        [HttpPost]
        public ActionResult Atualizar(Produto produto, int Id)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Atualizar(produto);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categoria = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }
    }
}