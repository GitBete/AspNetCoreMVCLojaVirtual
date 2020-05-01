using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers.Base
{
   
    public class BaseController : Controller 
    {

        public CookieCarrinhoCompra _cookieCarrinhoCompra;
        public IProdutoRepository _produtoRepository;
        public IMapper _mapper;
        public WSCorreiosCalcularFrete _wscorreios;
        public CalcularPacote _calcularPacote;
        public CookieValorPrazoFrete _cookieValorPrazoFrete;

        public BaseController(CookieCarrinhoCompra cookiecarrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper, WSCorreiosCalcularFrete wscorreios, CalcularPacote calcularPacote, CookieValorPrazoFrete cookieValorPrazoFrete)
        {
            _cookieCarrinhoCompra = cookiecarrinhoCompra;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
            _wscorreios = wscorreios;
            _calcularPacote = calcularPacote;
            _cookieValorPrazoFrete = cookieValorPrazoFrete;
        }

        public List<ProdutoItem> CarregarProdutoDB()
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