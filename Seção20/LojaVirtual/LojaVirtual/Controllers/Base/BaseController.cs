using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Seguranca;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LojaVirtual.Controllers.Base
{
   
    public class BaseController : Controller 
    {

        protected LoginCliente _loginCliente;
        protected CookieCarrinhoCompra _cookieCarrinhoCompra;
        protected IProdutoRepository _produtoRepository;
        protected IMapper _mapper;
        protected WSCorreiosCalcularFrete _wscorreios;
        protected CalcularPacote _calcularPacote;
        protected CookieFrete _cookieFrete;
        protected IEnderecoEntregaRepository _enderecoEntregaRepository;

        public BaseController(LoginCliente loginCliente, CookieCarrinhoCompra cookiecarrinhoCompra, IEnderecoEntregaRepository enderecoEntregaRepository, IProdutoRepository produtoRepository, IMapper mapper, WSCorreiosCalcularFrete wscorreios, CalcularPacote calcularPacote, CookieFrete cookieFrete)
        {
            _loginCliente = loginCliente;
            _cookieCarrinhoCompra = cookiecarrinhoCompra;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
            _wscorreios = wscorreios;
            _calcularPacote = calcularPacote;
            _cookieFrete = cookieFrete;
            _enderecoEntregaRepository = enderecoEntregaRepository;
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

      protected string GerarHash(object obj)
        {
           return  StringMD5.MD5Hash(JsonConvert.SerializeObject(obj));
        }
    }
}