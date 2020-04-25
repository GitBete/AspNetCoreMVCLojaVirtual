using LojaVirtual.Models.ProdutoAgregador;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.CarrinhoCompra
{
    public class CarrinhoCompra
    {
        private string key = "Carrinho.Compras";
        private Cookie.Cookie _cookie;

        public CarrinhoCompra(Cookie.Cookie cookie)
        {
            _cookie = cookie;
        }

        // CRUD - Carrinho compras

        public void Cadastrar(ProdutoItem item)
        {
            List<ProdutoItem> Lista;

            if (_cookie.Existe(key))
            {
                Lista = Consultar();

                //Carrinho ja existe 
                var ItemLocalizado = Lista.SingleOrDefault(a => a.Id == item.Id);
                if (ItemLocalizado == null)
                {
                    //Item nao existe ... adicionar novo
                    Lista.Add(item);
                }
                else
                {
                    //item ja existe ... adicionar mais 1 a quantidade
                    ItemLocalizado.QuantidadeProdutoCarrinho = ItemLocalizado.QuantidadeProdutoCarrinho + 1;
                }
            }
            else
            {
                //Carrinho de compras nao existe criar o carrinho de compras - COOKIE
                Lista = new List<ProdutoItem>();
                Lista.Add(item);
            }

            Salvar(Lista);
        }

        public void Atualizar(ProdutoItem item)
        {
            var Lista = Consultar();
            var ItemLocalizado = Lista.SingleOrDefault(a => a.Id == item.Id);

            if (ItemLocalizado != null)
            {
                ItemLocalizado.QuantidadeProdutoCarrinho = item.QuantidadeProdutoCarrinho;
                Salvar(Lista);
            }

        }

        public List<ProdutoItem> Consultar()
        {
           
            if (_cookie.Existe(key))
            {
                string valor = _cookie.Consultar(key);
                return JsonConvert.DeserializeObject<List<ProdutoItem>>(valor);
            }
            else
            {
                return new List<ProdutoItem>();
            }
                
        }

        public void Remover(ProdutoItem item)
        {
            var Lista = Consultar();
            var ItemLocalizado = Lista.SingleOrDefault(a => a.Id == item.Id);

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

        public void Salvar(List<ProdutoItem> Lista)
        {
            string valor = JsonConvert.SerializeObject(Lista);
            _cookie.Cadastrar(key, valor);
        }
    }

    
}
