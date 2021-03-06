﻿using LojaVirtual.Database;
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

        public Categoria ObterCategoria(string slug)
        {
            return _banco.Categoria.Where(a => a.Slug == slug).FirstOrDefault();
        }

        private List<Categoria> Categorias;
        private List<Categoria> ListaCategoriaRecursiva = new List<Categoria>();
        public IEnumerable<Categoria> ObterCategoriasRecursivas(Categoria categoriaPai)
        {
            //Rotina Recursiva ............................................................. COVIT-19 domingo de pascoa
            if (Categorias == null)
            {
                Categorias = ObterTodasCategorias().ToList();
            }           

            //verificar se o elemento ja existe na lista
            if (!ListaCategoriaRecursiva.Exists(a => a.Id == categoriaPai.Id))
            {
                ListaCategoriaRecursiva.Add(categoriaPai);
            }
           
            if (categoriaPai != null)
            {
                var ListaCategoriaFilho = Categorias.Where(a => a.CategoriaPaiId == categoriaPai.Id);
                //receber uma lista de todas as categorias
                if (Categorias.Where(a => a.CategoriaPaiId == categoriaPai.Id).Count() > 0)
                {
                    ListaCategoriaRecursiva.AddRange(ListaCategoriaFilho.ToList());
                    foreach (var categoria in ListaCategoriaFilho)
                    {
                        ObterCategoriasRecursivas(categoria);
                    }

                }
            }

            return ListaCategoriaRecursiva;           
    }
    }

    
}
