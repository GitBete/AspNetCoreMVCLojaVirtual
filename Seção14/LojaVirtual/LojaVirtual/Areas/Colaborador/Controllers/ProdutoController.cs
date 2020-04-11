using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Arquivos;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;
        private IImagenRepository _imagenRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository, IImagenRepository imagenRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
            _imagenRepository = imagenRepository;
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

                //posso pegar qualquer campo do formulario pelo Request.Form   
                //pegar imagem no caminho temp e mover para cainho real
                List<Imagem> ListaImagensDef = GerenciadorArquivo.MoverImagensProduto(new List<string>(Request.Form["imagem"]), produto.Id);
                //Gravar o caminho das imagens no banco de dados
                _imagenRepository.CadastrarImagens(ListaImagensDef, produto.Id);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
                produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a=> a.Trim().Length >0).Select(a=>new Imagem() { Caminho = a }).ToList();                
                return View(produto);
            }
                       
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

                //Nao mover imagens d pasta definitiva
                List<Imagem> ListaImagensDef = GerenciadorArquivo.MoverImagensProduto(new List<string>(Request.Form["imagem"]), produto.Id);
                //Gravar o caminho das imagens no banco de dados
                _imagenRepository.ExcluirImagensDoProduto(Id);
                _imagenRepository.CadastrarImagens(ListaImagensDef, produto.Id);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
                produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a => a.Length > 0).Select(a => new Imagem() { Caminho = a }).ToList();
                return View(produto);
            }
        }

        [HttpGet]
        [ValidateHttpReferer]
        public ActionResult Excluir(int Id)
        {
            Produto produto = _produtoRepository.ObterProduto(Id);
            GerenciadorArquivo.ExcluirImagensImagensProduto(produto.Imagens.ToList());
            _imagenRepository.Excluir(Id);
            _produtoRepository.Excluir(Id);

            TempData["MSG_S"] = Mensagem.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
    }
}