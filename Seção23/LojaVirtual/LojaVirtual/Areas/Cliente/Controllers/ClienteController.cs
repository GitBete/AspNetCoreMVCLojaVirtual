
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class ClienteController : Controller
    {
        private LoginCliente _loginCliente;
        private IClienteRepository _clienteRepository;

        public ClienteController(LoginCliente loginCliente,IClienteRepository clienteRepository)
        {
            _loginCliente = loginCliente;
            _clienteRepository = clienteRepository;
        }

        [ClienteAutorizacao]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Models.Cliente cliente, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                //Chama repository
                _clienteRepository.Cadastrar(cliente);

                _loginCliente.Login(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                //Implementar redirecionamentos diferentes (Painel, carrinho de compras ...)

                if (returnUrl == null)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }

            }

            return View();
        }

        [ClienteAutorizacao]
        [HttpGet]
        public IActionResult Atualizar()
        {
            Models.Cliente cliente = _clienteRepository.ObterCliente(_loginCliente.GetCliente().Id);

            return View(cliente);
        }

        [ClienteAutorizacao]
        [HttpPost]
        public IActionResult Atualizar(Models.Cliente cliente)
        {
            ModelState.Remove("Senha");
            ModelState.Remove("ConfirmacaoSenha");

            if (ModelState.IsValid)
            {
                cliente.Senha = _loginCliente.GetCliente().Senha;

                //Chama repository
                _clienteRepository.Atualizar(cliente);

                _loginCliente.Login(cliente);

                TempData["MSG_S"] = Mensagem.MSG_E001;

                //Implementar redirecionamentos diferentes (Painel, carrinho de compras ...)
                return RedirectToAction(nameof(Index));               

            }

            return View();
        }

        [ClienteAutorizacao]
        [HttpGet]
        public IActionResult AtualizarSenha()
        {
            return View();
        }

        [ClienteAutorizacao]
        [HttpPost]
        public IActionResult AtualizarSenha(Models.Cliente cliente)
        {
            //Ignorando os demais dados do cliente que nao seram utilizados
            ModelState.Remove("Nome");
            ModelState.Remove("Nascimento");
            ModelState.Remove("Sexo");
            ModelState.Remove("CPF");
            ModelState.Remove("Telefone");
            ModelState.Remove("Email");
            ModelState.Remove("CEP");
            ModelState.Remove("UF");
            ModelState.Remove("Cidade");
            ModelState.Remove("Bairro");
            ModelState.Remove("Logradouro");
            ModelState.Remove("Complemento");
            ModelState.Remove("LogradouroNumr");

            if (ModelState.IsValid)
            {
                Models.Cliente clienteDB = _clienteRepository.ObterCliente(_loginCliente.GetCliente().Id) ;
                clienteDB.Senha = cliente.Senha;

                //Chama repository
                _clienteRepository.Atualizar(clienteDB);

                _loginCliente.Login(cliente);

                TempData["MSG_S"] = Mensagem.MSG_E001;

                //Implementar redirecionamentos diferentes (Painel, carrinho de compras ...)
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

    }
}