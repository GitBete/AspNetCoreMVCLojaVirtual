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
    public class CategoriaRepository : ICategoriaRepository
    {
        private IConfiguration _configuration;
        //const int _registroPorPagina = 7;
        private LojaVirtualContext _banco;

        public CategoriaRepository( LojaVirtualContext banco, IConfiguration configuration)
        {
            _banco = banco;
            _configuration = configuration;
        }
              
        public void Cadastrar(Categoria categoria)
        {
            //Grava no Banco
            _banco.Add(categoria);
            _banco.SaveChanges();
        }

        public void Atualizar(Categoria categoria)
        {
            _banco.Update(categoria);
            _banco.SaveChanges();
        }


        public void Excluir(int Id)
        {
            Categoria categoria = ObterCategoria(Id);
            _banco.Remove(categoria);
            _banco.SaveChanges();
        }

        public Categoria ObterCategoria(int Id)
        {
            return _banco.Categoria.Find(Id);
        }
          
        public IPagedList<Categoria> ObterTodasCategorias(int? pagina)
        {

            /*
             * Paginacao com a biblioteca:X.PagedList.Mvc.Core
             * vantagem de colocar o codigo aqui é que ja vai pegar menos dados 
             * no banco do cliente
             */
            //Acesso ao AppSettinga
            int RegistroPorPagina = _configuration.GetValue<int>("RegistroPorPagina");

            int NumeroPagina = pagina ?? 1;
            return _banco.Categoria.Include(a=>a.CategoriaPai).ToPagedList<Categoria>(NumeroPagina, RegistroPorPagina);

        }

        public IEnumerable<Categoria> ObterTodasCategorias()
        {
            return _banco.Categoria;
        }
    }
}
