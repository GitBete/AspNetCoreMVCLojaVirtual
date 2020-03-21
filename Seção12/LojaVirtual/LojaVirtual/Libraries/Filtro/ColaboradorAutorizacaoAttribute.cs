﻿using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
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
        /*
        *  Tipos de filtro:
        *  - Autorizacao ... IAuthorizationFilter
        *  - Recurso ....... IResourceFilter 
        *  - Ação .......... IActionFilter
        *  - Exceção ....... IExceptionFilter
        *  - Resultado ..... IResultFilter
        */
        LoginColaborador _loginColaborador;

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            _loginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador));

            Colaborador colaborador = _loginColaborador.GetColaborador();

            if (colaborador == null)
            {
                context.Result = new ContentResult() { Content = "Colaborador com acesso Negado!" };
            }

        }

    }
}

