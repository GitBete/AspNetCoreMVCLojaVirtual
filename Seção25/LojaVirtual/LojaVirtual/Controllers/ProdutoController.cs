using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        private ICategoriaRepository _categoriaRepository;
        private IProdutoRepository _produtoRepository;

        public ProdutoController(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }

        //Produto listagem categoria
        //Criando rota propria
        [HttpGet]
        [Route("/Produto/Categoria/{slug}")]       
        public IActionResult ListagemCategoria(string slug)
        {            
            return View(_categoriaRepository.ObterCategoria(slug));
        }


        /*--------------------------------------------------------------*/

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Visualizar(int Id)
        {
            return View(_produtoRepository.ObterProduto(Id));            
        }

      
    }
}