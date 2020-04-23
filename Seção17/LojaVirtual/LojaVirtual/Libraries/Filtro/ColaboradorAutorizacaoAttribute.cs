using LojaVirtual.Areas.Colaborador.Controllers;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Filtro
{
    public class ColaboradorAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        public String _tipoColaboradorAutorizado;
           
        public ColaboradorAutorizacaoAttribute (string TipoColaboradorAutorizado = ColaboradorTipoConstant.Comum)
        {
                _tipoColaboradorAutorizado = TipoColaboradorAutorizado;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            /*
            *  Tipos de filtro:
            *  - Autorizacao ... IAuthorizationFilter
            *  - Recurso ....... IResourceFilter 
            *  - Ação .......... IActionFilter
            *  - Exceção ....... IExceptionFilter
            *  - Resultado ..... IResultFilter
            */
            LoginColaborador _loginColaborador;

            _loginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador));

            Colaborador colaborador = _loginColaborador.GetColaborador();

            if (colaborador == null)
            {
                //context.Result = new ContentResult() { Content = "Colaborador com acesso Negado!" };
                context.Result = new RedirectToActionResult("Login","Home",null);
            }
            else
            {
                //Verificar se  tipo do colaborador podera acessar
                if (colaborador.Tipo == ColaboradorTipoConstant.Comum && _tipoColaboradorAutorizado == ColaboradorTipoConstant.Gerente)
                {
                    //Negado
                    context.Result = new ForbidResult();
                }
            }

        }

    }
}

