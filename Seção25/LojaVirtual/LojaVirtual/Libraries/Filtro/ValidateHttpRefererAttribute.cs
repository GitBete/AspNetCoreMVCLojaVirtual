using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Filtro
{
    public class ValidateHttpRefererAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Executando antes passar pelo controlador  
            string referer = context.HttpContext.Request.Headers["Referer"].ToString();
            if (String.IsNullOrEmpty(referer))
            {
                //todo - criar tela de acesso negado
                context.Result = new ContentResult() { Content = "Acesso Negado!" };
            }
            else
            {
                Uri uri = new Uri(referer);
                string hostReferer = uri.Host;
                string hostServidor = context.HttpContext.Request.Host.Host;

                if (hostReferer != hostServidor)
                {
                    //todo - criar tela de acesso negado
                    context.Result = new ContentResult() { Content = "Acesso Negado!" };
                }
            }
                  
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Executando depois passar pelo controlador
            // Do something after the action executes.
            //context.Result = new ContentResult() { Content = context.HttpContext.Request.Path };
        }


    }
}
