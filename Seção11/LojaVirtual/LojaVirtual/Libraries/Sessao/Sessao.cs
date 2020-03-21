﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Sessao
{
    public class Sessao
    {
        //incluir o servico: AddHttpContextAccessor
        private IHttpContextAccessor _context;

        public Sessao(IHttpContextAccessor context)
        {
            _context = context;
        }
        //CRUD - Cadsatrar/Atualizar/Consultar/Remover - RemoverTodos/Exist

        public void Cadastrar(string key,string valor)
        {
            _context.HttpContext.Session.SetString(key, valor);
        }

        public void Atualizar(string key,string valor)
        {
            if (Existe(key))
            {
                _context.HttpContext.Session.Remove(key);
            }
            _context.HttpContext.Session.SetString(key, valor);
        }

        public void Remover(string key)
        {
            _context.HttpContext.Session.Remove(key);
        }

        public void RemoverTodos()
        {
            _context.HttpContext.Session.Clear();
        }

        public String Consultar(string key)
        {
           return  _context.HttpContext.Session.GetString(key);
        }

        public bool Existe(string key)
        {
           if ( _context.HttpContext.Session.GetString(key) ==null)
            {
                return false;
            }

            return true;
        }
    }
}
