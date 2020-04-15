using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Middleware
{
    public class ValidateAntiForgeryTokenMiddleware
    {
        private RequestDelegate _next;
        private IAntiforgery _antiforgery;

        public ValidateAntiForgeryTokenMiddleware(RequestDelegate next, IAntiforgery antiforgery)
        {
            _next = next;
            _antiforgery = antiforgery;
        }

        public async Task Invoke(HttpContext context)
        {
            var Cabecalho = context.Request.Headers["x-requested-with"];
            bool AJAX = (Cabecalho == "XMLHttpRequest") ? true : false;

            if (HttpMethods.IsPost(context.Request.Method) )
            {
                if ( AJAX)
                {
                    if (context.Request.Form.Files.Count == 0)
                    {
                        await _antiforgery.ValidateRequestAsync(context);
                    }
                }
                else
                {   //Se nao for ajax fazer a critica
                    await _antiforgery.ValidateRequestAsync(context);
                }
                           
            }
            await _next(context);
        }
    }
}
