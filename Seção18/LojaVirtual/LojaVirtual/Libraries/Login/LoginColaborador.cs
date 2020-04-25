using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Login
{
    public class LoginColaborador
    {

        private string Key = "Login.Colaborador";

        private Sessao.Sessao _sessao;

        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        [ValidateHttpReferer]
        public void Login(Colaborador colaborador)
        {
            //Serializar
            string ColaboradorJSONString = JsonConvert.SerializeObject(colaborador);
            _sessao.Cadastrar(Key, ColaboradorJSONString);
        }

        [ValidateHttpReferer]
        public Colaborador GetColaborador()
        {
            if (_sessao.Existe(Key))
            {
                //Deserializar
                string ColaboradorJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Colaborador>(ColaboradorJSONString);
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
