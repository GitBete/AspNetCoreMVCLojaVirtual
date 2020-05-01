using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Repositories;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        //interface precisa ser publica
        private INewsletterRepository _repositoryNewsLettler;        
        private GerenciarEmail _gerenciarEmail;
        private IProdutoRepository _produtoRepository;

        //Injecao de dependencias 
        public HomeController(IClienteRepository repositoryCliente, INewsletterRepository repositoryNewsLettler, GerenciarEmail gerenciarEmail, IProdutoRepository produtoRepository)
        {           
            _repositoryNewsLettler = repositoryNewsLettler;            
            _gerenciarEmail = gerenciarEmail;
            _produtoRepository = produtoRepository;
        }
        
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //mostra no editor esse conteudo
            //var news = new NewsletterEmail() { Email = "bete@terra.com.br" };

            return View();
        }

        [HttpPost]
        public IActionResult Index(int? pagina, string pesquisa,string ordenacao,[FromForm] NewsletterEmail newsletter)
        {
            //TODO - validacoes - incluidas no modelo pela data anotations
            if (ModelState.IsValid)
            {
                //TODO - Adicao no banco de dados
                _repositoryNewsLettler.Cadastrar(newsletter);

                //Mensagem ao usuario
                TempData["MSG_S"] = "E-mail cadastrado! Agora você você vai receber promoções especiais no seu email. Fique Atento às novidades.";

                //redirecionamento é feito pelo metodo GET
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult Categoria()
        {
            //cada acao esta focada em apenas chamar uma tela
            return View();
        }

        [HttpGet]
        public IActionResult Contato()
        {
            //cada acao esta focada em apenas chamar uma tela
            return View();
        }

        [HttpPost]
        public IActionResult ContatoAcao()
        {

            //propriedade de retorno, solicitacao dos dados
            //string nome = HttpContext.Request.Form["nome"];
            //string email = HttpContext.Request.Form["email"];
            //string texto = HttpContext.Request.Form["texto"];

            ////metodo par receber as informacoes
            //return new ContentResult() { Content = string.Format("Dados recebidos com sucesso! <br> Nome: {0} <br> Email: {1} <br> Texto: {2}",nome,email,texto),ContentType ="text/html" };

            //pega query string
            //HttpContext.Request.QueryString["nome"];
            
            try
            {
                //pegar dados informados no formulario
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                //validacao com dataanotation
                var listaMensagem = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isvalid = Validator.TryValidateObject(contato, contexto, listaMensagem,true);

                if (isvalid)
                {
                    ////enviar email
                    _gerenciarEmail.EnviarContatoPorEmail(contato);

                    ////enviar mensagem para ser exibida no html (tela)
                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in listaMensagem)
                    {
                        sb.Append(texto.ErrorMessage + "<br />");
                    }

                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }
                               
                //return new ContentResult() { Content = string.Format("Dados recebidos com sucesso! <br> Nome: {0} <br> Email: {1} <br> Texto: {2}",contato.Nome,contato.Email,contato.Texto),ContentType ="text/html" };

            }
            catch (Exception e)
            {
                //enviar mensagem para ser exibida no html (tela)
                ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde.";
            }

           
            //exibir a tela de contato novamente
            return View("Contato");
        }

       

    }
}
