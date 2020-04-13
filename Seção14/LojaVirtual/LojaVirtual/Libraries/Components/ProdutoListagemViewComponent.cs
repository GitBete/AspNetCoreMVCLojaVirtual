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

        public ProdutoListagemViewComponent(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        //Logica componente
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int? pagina = 1;
            string pesquisa = "";
            string ordenacao = "A";

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

            var viewModel = new ProdutoListagemViewModel(){lista = _produtoRepository.ObterTodosProdutos(pagina, pesquisa, ordenacao)};           
            return View(viewModel);
        }
    }
}
