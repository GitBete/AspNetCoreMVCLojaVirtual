using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Filtro
{
    public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        /*
         *  Tipos de filtro:
         *  - Autorizacao ... IAuthorizationFilter
         *  - Recurso ....... IResourceFilter 
         *  - Ação .......... IActionFilter
         *  - Exceção ....... IExceptionFilter
         *  - Resultado ..... IResultFilter
         */

        //injecao de dependencia em atributo nao é legal
        LoginCliente _loginCliente;

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            _loginCliente = (LoginCliente)context.HttpContext.RequestServices.GetService(typeof(LoginCliente));
            
            Cliente cliente = _loginCliente.GetCliente();

            if (cliente == null)
            {

                //tratar melhor os erros ... redirecionando para pagina tratada
                context.Result = new ContentResult() { Content = "Acesso Negado !" };
            }
           
        }

    }
}
