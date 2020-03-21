using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        const int _registroPorPagina = 7;

        private LojaVirtualContext _banco;
        public CategoriaRepository( LojaVirtualContext banco)
        {
             _banco = banco;
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
            int NumeroPagina = pagina ?? 1;
            return _banco.Categoria.Include(a=>a.CategoriaPai).ToPagedList<Categoria>(NumeroPagina, _registroPorPagina);

        }

        public IEnumerable<Categoria> ObterTodasCategorias()
        {
            return _banco.Categoria;
        }
    }
}
