using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private CookieCarrinhoCompra _cookieCarrinhoCompra;
        private IProdutoRepository _produtoRepository;
        private IMapper _mapper;

        //para calculo do frete
        private WSCorreiosCalcularFrete _wscorreios;
        private CalcularPacote _calcularPacote;
        private CookieValorPrazoFrete _cookieValorPrazoFrete;

        public CarrinhoCompraController(CookieCarrinhoCompra cookiecarrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper, WSCorreiosCalcularFrete wscorreios, CalcularPacote calcularPacote, CookieValorPrazoFrete cookieValorPrazoFrete)
        {
            _cookieCarrinhoCompra = cookiecarrinhoCompra;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
            _wscorreios = wscorreios;
            _calcularPacote = calcularPacote;
            _cookieValorPrazoFrete = cookieValorPrazoFrete;
        }

        public IActionResult Index()
        {
            List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();

            //enviar para tela
            return View(produtoItemComplento);
        }

       

        public IActionResult AdicionarItem(int id)
        {
            Produto produto = _produtoRepository.ObterProduto(id);

            if (produto ==null)
            {
                //Produto nao existe
                return View("NaoExisteItem");
            }
            else
            {
                //caso o produto já exista adicionar a quantidade ao ja existente no lugar de adicionar mais um objeto a lista
                var item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = 1 };
                _cookieCarrinhoCompra.Cadastrar(item);

                return RedirectToAction(nameof(Index));
            }

        }

        public IActionResult AlterarQuantidade(int id, int quantidade)
        {

            //Nao deixar alterar se nao tiver quantidade suficiente no estoque
            Produto produto = _produtoRepository.ObterProduto(id);
            if (quantidade < 1)
            {
                return BadRequest(new { mensagem = Mensagem.MSG_E007 });
            }else if (quantidade > produto.Quantidade)
            {
                return BadRequest(new { mensagem = Mensagem.MSG_E008 });
            }
            else
            {
                //Tudo certo
                var item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = quantidade };
                _cookieCarrinhoCompra.Atualizar(item);

                return RedirectToAction(nameof(Index));
            }

           
        }

        public IActionResult RemoverItem(int id)
        {
            _cookieCarrinhoCompra.Remover(new ProdutoItem() { Id = id });
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CalcularFrete(int cepDestino)
        {
            //Vai ser acionada apenas pelo AJAX ............................................

            try
            {
           
                //Captura cokkie carrinho e pesquisa os produtos no banco de dados
                List<ProdutoItem> produtoItemComplento = CarregarProdutoDB();

                //Calcula os pacotes
                List<Pacote> pacotes = _calcularPacote.CalcularPacotesProdutos(produtoItemComplento);

                //TipoFreteConstant
                ValorPrazoFrete valorPAC = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.PAC,  pacotes);
                ValorPrazoFrete valorSEDEX = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX, pacotes);
                //so existe em algumas regioes - ou ate regioees proximas
                ValorPrazoFrete valorSEDEX10 = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX10, pacotes);


                //se deu tudo certo, tem que entregar esses dados para javascript - JSON
                List<ValorPrazoFrete> lista = new List<ValorPrazoFrete>();

                if (valorPAC != null) lista.Add(valorPAC);                
                if (valorSEDEX != null) lista.Add(valorSEDEX);                 
                if (valorSEDEX10 != null) lista.Add(valorSEDEX10);

                //guardar cookie, criar nova class
                _cookieValorPrazoFrete.Cadastrar(lista);

                return Ok(lista);
            }
                catch (Exception e)
            {
                _cookieValorPrazoFrete.Remover();

                return BadRequest(e);
            }
        }


        //Metodos privados ... geralmente fatorados

        private List<ProdutoItem> CarregarProdutoDB()
        {
            //Verificar se tem registro no carrinho de compras, seriealizada com Id e quantidade
            List<ProdutoItem> produtoItemCarrinho = _cookieCarrinhoCompra.Consultar();
            List<ProdutoItem> produtoItemComplento = new List<ProdutoItem>();

            //para cada item escolhido consultar na tabela produto
            foreach (var item in produtoItemCarrinho)
            {
                //Implementar AutoMapper
                Produto produto = _produtoRepository.ObterProduto(item.Id);

                //usando agora o AutoMapper ...
                ProdutoItem produtoItem = _mapper.Map<ProdutoItem>(produto);

                //ProdutoItem produtoItem = new ProdutoItem();
                //produtoItem.Id = produto.Id;
                //produtoItem.Nome = produto.Nome;
                //produtoItem.Imagens = produto.Imagens;
                //produtoItem.Valor = produto.Valor;

                produtoItem.QuantidadeProdutoCarrinho = item.QuantidadeProdutoCarrinho;

                produtoItemComplento.Add(produtoItem);
            }

            return produtoItemComplento;
        }

    }
}