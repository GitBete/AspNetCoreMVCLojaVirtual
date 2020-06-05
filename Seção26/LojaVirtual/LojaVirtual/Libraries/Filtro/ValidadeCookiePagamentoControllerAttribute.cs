using LojaVirtual.Libraries.Lang;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Filtro
{
    public class ValidadeCookiePagamentoControllerAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
           var _cookie = (Cookie.Cookie)context.HttpContext.RequestServices.GetService(typeof(Cookie.Cookie));

            var tipoFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.TipoFrete", false);
            var valorFreteSelecionadoPeloUsuario = _cookie.Consultar("Carrinho.ValorFrete", false);
            var carrinhoCompras = _cookie.Consultar("Carrinho.Compras", false);

            if (carrinhoCompras == null)
            {
                
               ((Controller)context.Controller).TempData["MSG_E"] = Mensagem.MSG_E010;
                context.Result = new RedirectToActionResult("Index","CarrinhoCompra",null);
            }
            if (tipoFreteSelecionadoPeloUsuario == null || valorFreteSelecionadoPeloUsuario == null )
            {
                ((Controller)context.Controller).TempData["MSG_E"] = Mensagem.MSG_E009;
                context.Result = new RedirectToActionResult("EnderecoEntrega", "CarrinhoCompra", null);
            }

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
      
        }
    }
}
