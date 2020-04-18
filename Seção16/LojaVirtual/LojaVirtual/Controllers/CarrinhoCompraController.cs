using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private CarrinhoCompra _carrinhoCompra;
        private IProdutoRepository _produtoRepository;
        private IMapper _mapper;

        public CarrinhoCompraController(CarrinhoCompra carrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper)
        {
            _carrinhoCompra = carrinhoCompra;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //Verificar se tem registro no carrinho de compras, seriealizada com Id e quantidade
            List<ProdutoItem> produtoItemCarrinho = _carrinhoCompra.Consultar();
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
                _carrinhoCompra.Cadastrar(item);

                return RedirectToAction(nameof(Index));
            }

        }

        public IActionResult AlterarQuantidade(int id, int quantidade)
        {

            //Nao deixar alterar se nao tiver quantidade suficiente no estoque


            var  item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = quantidade };
            _carrinhoCompra.Atualizar(item);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoverItem(int id)
        {
            _carrinhoCompra.Remover(new ProdutoItem() { Id = id });
            return RedirectToAction(nameof(Index));
        }

    }
}