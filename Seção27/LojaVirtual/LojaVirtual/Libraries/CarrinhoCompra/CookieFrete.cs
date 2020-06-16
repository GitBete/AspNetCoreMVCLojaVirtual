using LojaVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.CarrinhoCompra
{
    public class CookieFrete
    {

        private string key = "Carrinho.ValorFrete";
        private Cookie.Cookie _cookie;

        public CookieFrete(Cookie.Cookie cookie)
        {
            _cookie = cookie;
        }

        // CRUD - Carrinho compras

        public void Cadastrar(Frete item)
        {
            List<Frete> Lista;

            if (_cookie.Existe(key))
            {
                Lista = Consultar();

                //Carrinho ja existe 
                var ItemLocalizado = Lista.SingleOrDefault(a => a.CEP == item.CEP);
                if (ItemLocalizado == null)
                {
                    //Item nao existe ... adicionar novo
                    Lista.Add(item);
                }
                else
                {
                    //item ja existe ... adicionar mais 1 a quantidade
                    ItemLocalizado.CodCarrinho = item.CodCarrinho;
                    ItemLocalizado.ListaValores = item.ListaValores ;
                }
            }
            else
            {
                //Carrinho de compras nao existe criar o carrinho de compras - COOKIE
                Lista = new List<Frete>();
                Lista.Add(item);
            }

            Salvar(Lista);
        }

        public void Atualizar(Frete item)
        {
            var Lista = Consultar();
            var ItemLocalizado = Lista.SingleOrDefault(a => a.CEP == item.CEP);

            if (ItemLocalizado != null)
            {
                ItemLocalizado.CodCarrinho = item.CodCarrinho;
                ItemLocalizado.ListaValores = item.ListaValores;
                Salvar(Lista);
            }

        }

        public List<Frete> Consultar()
        {

            if (_cookie.Existe(key))
            {
                string valor = _cookie.Consultar(key);
                return JsonConvert.DeserializeObject<List<Frete>>(valor);
            }
            else
            {
                return new List<Frete>();
            }

        }

        public void Remover(Frete item)
        {
            var Lista = Consultar();
            var ItemLocalizado = Lista.SingleOrDefault(a => a.CEP == item.CEP);

            if (ItemLocalizado != null)
            {
                Lista.Remove(ItemLocalizado);
                Salvar(Lista);
            }
        }

        public bool Existe()
        {
            if (_cookie.Existe(key))
            {
                return true;
            }

            return false;
        }

        public void RemoverTodos()
        {
            _cookie.Remover(key);
        }

        public void Salvar(List<Frete> Lista)
        {
            string valor = JsonConvert.SerializeObject(Lista);
            _cookie.Cadastrar(key, valor);
        }
    }


}
