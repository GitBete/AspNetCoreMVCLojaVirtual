
using LojaVirtual.Libraries.Seguranca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Cookie
{
    public class Cookie
    {
        //incluir o servico: AddHttpContextAccessor
        private IHttpContextAccessor _context;
        private IConfiguration _configuration;

        public Cookie(IHttpContextAccessor context,IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        //CRUD - Cadsatrar/Atualizar/Consultar/Remover - RemoverTodos/Exist

        public void Cadastrar(string key, string valor)
        {
            CookieOptions Options = new CookieOptions();
            //duracao do carrinho de compras guardado no cookie
            //Nao esquecer de verificar a quantidade desejada no estoque
            Options.Expires = DateTime.Now.AddDays(7);
            Options.IsEssential = true;

            //inserir a criptografia
            var ValorCrypt = StringCipher.Encrypt(valor, _configuration.GetValue<string>("KeyCrypt"));

            _context.HttpContext.Response.Cookies.Append(key, ValorCrypt, Options);            
        }

        public void Atualizar(string key, string valor)
        {
            if (Existe(key))
            {
                Remover(key);
            }
            Cadastrar(key, valor);
        }

        public void Remover(string key)
        {
            _context.HttpContext.Response.Cookies.Delete(key);
        }

        public String Consultar(string key)
        {
            //inserir a criptografia
            var ValorCrypt = _context.HttpContext.Request.Cookies[key];

            var ValorDeCrypy = StringCipher.Decrypt(ValorCrypt, _configuration.GetValue<string>("KeyCrypt"));

            return ValorDeCrypy;
        }

        public bool Existe(string key)
        {
            if (_context.HttpContext.Request.Cookies[key] == null)
            {
                return false;
            }

            return true;
        }


        public void RemoverTodos()
        {
            var ListaCookie = _context.HttpContext.Request.Cookies.ToList();
            foreach (var cookie in ListaCookie)
            {
                Remover(cookie.Key);
            }

        }

    }
}

