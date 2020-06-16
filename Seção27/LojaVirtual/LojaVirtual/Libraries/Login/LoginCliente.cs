using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Login
{
    public class LoginCliente
    {
        //classe referente a sessao do cliente
        //nao esquecer de colocar a injecao no Startup

        private string Key = "Login.Cliente";

        private Sessao.Sessao _sessao;

        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
               
       
        public void Login(Cliente cliente)
        {
            //Serializar
            string ClienteJSONString = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(Key,ClienteJSONString);
        }

     
        public Cliente GetCliente()
        {
            if (_sessao.Existe(Key))
            {
                //Deserializar
                string ClienteJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(ClienteJSONString); 
            }
            else
            {
                return null;
            }
            
        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }

    }
}
