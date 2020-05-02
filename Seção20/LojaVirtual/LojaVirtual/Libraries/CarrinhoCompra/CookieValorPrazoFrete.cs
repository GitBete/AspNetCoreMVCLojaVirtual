using LojaVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.CarrinhoCompra
{
    public class CookieValorPrazoFrete
    {

        private string key = "Carrinho.ValorPrazoFrete";
        private Cookie.Cookie _cookie;


        public CookieValorPrazoFrete(Cookie.Cookie cookie)
        {
            _cookie = cookie;
        }

        // CRUD - Carrinho compras - FRETE
        public void Cadastrar(List<ValorPrazoFrete> lista)
        {
            var jsonString = JsonConvert.SerializeObject(lista);
            _cookie.Cadastrar(key, jsonString);

        }

        public List<ValorPrazoFrete> Consultar()
        {
            if (_cookie.Existe(key))
            {
                string valor = _cookie.Consultar(key);
                return JsonConvert.DeserializeObject<List<ValorPrazoFrete>>(valor);
            }
            else
            {
                //return new List<ValorPrazoFrete>();
                return null;
            }
        }

        public void Remover()
        {
            _cookie.Remover(key);
        }

    }
}
