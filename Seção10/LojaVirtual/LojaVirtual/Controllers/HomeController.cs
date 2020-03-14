using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using LojaVirtual.Libraries.Email;
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
        private IClienteRepository _repositoryCliente ;
        private INewsletterRepository _repositoryNewsLettler;
        private LoginCliente _loginCliente;

        //Injecao de dependencias 
        public HomeController(IClienteRepository repositoryCliente, INewsletterRepository repositoryNewsLettler,LoginCliente logincliente)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryNewsLettler = repositoryNewsLettler;
            _loginCliente = logincliente;
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
        public IActionResult Index([FromForm] NewsletterEmail newsletter)
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

        [HttpPost]
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
                    ContatoEmail.EnviarContatoPorEmail(contato);

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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Cliente cliente)
        {
            //Persistir cliente no banco de dados
            Cliente clienteDB = _repositoryCliente.Login(cliente.Email, cliente.Senha);

            if (clienteDB != null)
            {
                //Logado
                _loginCliente.Login(clienteDB);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                //nao logado
                ViewData["MSG_E"] = "Usuário não encontrado, verifique o e-mail e senha digitado!";
                return new ContentResult() { Content = "Não logado!" };
            }
            
        }

        [HttpGet]
        public IActionResult Painel()
        {
            Cliente cliente = _loginCliente.GetCliente();

            if (cliente!= null)
            {
                return new ContentResult() { Content = "Usuário " + cliente.Id + ". E-mail: " + cliente.Email + " . Idade: " + DateTime.Now.AddYears(-cliente.Nascimento.Year).ToString("yyyy") + ". Logado!" };
            }
            else
            {
                return new ContentResult() { Content = "Acesso Negado. " };
            }

            //if (HttpContext.Session.TryGetValue("ID",out UsuarioID))
            //{
            //    return new ContentResult() { Content = "Usuário " + UsuarioID[0] + ". E-mail: " + HttpContext.Session.GetString("Email")  + " - Idade: " + HttpContext.Session.GetInt32("Idade")  + ". Logado!" };
            //}
            //else
            //{
            //    return new ContentResult() { Content = "Acesso Negado. "};
            //}

        }

        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm]Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //Chama repository
                _repositoryCliente.Cadastrar(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                //Implementar redirecionamentos diferentes (Painel, carrinho de compras ...)

                return RedirectToAction(nameof(CadastroCliente));
            }
            
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}
