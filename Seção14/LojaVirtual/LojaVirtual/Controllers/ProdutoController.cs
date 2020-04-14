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

        public ActionResult visualizar()
        {
            //return "Metodo Visualizar Ativado";

            // return new ContentResult() { Content = "<h3>Produto -> Visualizar</h3>", ContentType = "text/html" };
            //return View();

            Produto produto = GetProduto();

            return View(produto);
            
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "xbox One x",
                Descricao = "Jogue em 4k",
                Valor = 2000
            };
        }
    }
}