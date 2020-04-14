using LojaVirtual.Models;
using LojaVirtual.Models.ViewModels;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Components
{
    public class ProdutoListagemViewComponent: ViewComponent
    {
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;

        public ProdutoListagemViewComponent(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        //Logica componente
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int? pagina = 1;
            string pesquisa = "";
            string ordenacao = "A";

            IEnumerable<Categoria> categorias = null;

            if (HttpContext.Request.Query.ContainsKey("pagina"))
            {
                pagina = int.Parse(HttpContext.Request.Query["pagina"]);
            }
            if (HttpContext.Request.Query.ContainsKey("pesquisa"))
            {
                pesquisa = HttpContext.Request.Query["pesquisa"].ToString();
            }
            if (HttpContext.Request.Query.ContainsKey("ordenacao"))
            {
                ordenacao = HttpContext.Request.Query["ordenacao"].ToString();
            }
            if (ViewContext.RouteData.Values.ContainsKey("slug"))
            {
                //foi escolhida uma categoria
                string slug = ViewContext.RouteData.Values["slug"].ToString();
                Categoria CategoriaPrincipal = _categoriaRepository.ObterCategoria(slug);
                //chama algoritmo recursivo que obtem uma lista com todas as categorias que estejam abaixo da escolhida para exibir os produtos
                categorias = _categoriaRepository.ObterCategoriasRecursivas(CategoriaPrincipal).ToList();

            }

            var viewModel = new ProdutoListagemViewModel(){lista = _produtoRepository.ObterTodosProdutos(pagina, pesquisa, ordenacao, categorias) };           
            return View(viewModel);
        }
    }
}
