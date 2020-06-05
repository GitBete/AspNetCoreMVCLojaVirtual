﻿
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories.Contracts
{
    public interface ICategoriaRepository
    {
        //Crud
        void Cadastrar(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(int Id);
        Categoria ObterCategoria(int Id);
        Categoria ObterCategoria(string  slug);
        IEnumerable<Categoria> ObterTodasCategorias();
        IEnumerable<Categoria> ObterCategoriasRecursivas(Categoria categoriaPai);
        /*
        * Paginacao com a biblioteca:X.PagedList.Mvc.Core
        */
        IPagedList<Categoria> ObterTodasCategorias(int? pagina);
    }
}
