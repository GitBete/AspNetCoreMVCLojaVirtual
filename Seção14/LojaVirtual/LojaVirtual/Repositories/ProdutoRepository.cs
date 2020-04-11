using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private IConfiguration _configuration;       
        private LojaVirtualContext _banco;

        public ProdutoRepository(LojaVirtualContext banco, IConfiguration configuration)
        {
            _banco = banco;
            _configuration = configuration;
        }

      
        public void Cadastrar(Produto produto)
        {
            //Grava no Banco
            _banco.Add(produto);
            _banco.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            _banco.Update(produto);
            _banco.SaveChanges();
        }


        public Produto ObterProduto(int Id)
        {
            //pegar a imagem em outra tabela
            return _banco.Produto.Include(a=>a.Imagens).OrderBy(a=>a.Nome).Where(a=>a.Id == Id).FirstOrDefault();
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa)
        {
            // return _banco.Clientes.ToList();

            ////Acesso ao AppSettinga
            //int RegistroPorPagina = _configuration.GetValue<int>("RegistroPorPagina");

            //int NumeroPagina = pagina ?? 1;

            //var bancoProduto = _banco.Produto.AsQueryable();

            //if (!string.IsNullOrEmpty(pesquisa))
            //{
            //    //informou o parametro e vai pesquisar apenas o que indicou
            //    bancoProduto = bancoProduto.Where(a => a.Nome.Contains(pesquisa.Trim()));
            //}

            ////Include - incluindo caminho na imagem
            //return bancoProduto.Include(a=>a.Imagens).OrderBy(a => a.Nome).ToPagedList<Produto>(NumeroPagina, RegistroPorPagina);

            return ObterTodosProdutos(pagina, pesquisa, "A");

        }


        public void Excluir(int Id)
        {
            Produto produto = ObterProduto(Id);
            _banco.Remove(produto);
            _banco.SaveChanges();
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa, string ordenacao)
        {
            // return _banco.Clientes.ToList();

            //Acesso ao AppSettinga
            int RegistroPorPagina = _configuration.GetValue<int>("RegistroPorPagina");

            int NumeroPagina = pagina ?? 1;

            var bancoProduto = _banco.Produto.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                //informou o parametro e vai pesquisar apenas o que indicou
                bancoProduto = bancoProduto.Where(a => a.Nome.Contains(pesquisa.Trim()));
            }

            if (ordenacao == "A")
            {
                bancoProduto = bancoProduto.OrderBy(a => a.Nome);
            }
            if (ordenacao == "ME")
            {
                bancoProduto = bancoProduto.OrderBy(a => a.Valor);
            }
            if (ordenacao == "MA")
            {
                bancoProduto = bancoProduto.OrderByDescending(a => a.Valor);
            }

            //Include - incluindo caminho na imagem
            return bancoProduto.Include(a => a.Imagens).ToPagedList<Produto>(NumeroPagina, RegistroPorPagina);

        }
    }
}
