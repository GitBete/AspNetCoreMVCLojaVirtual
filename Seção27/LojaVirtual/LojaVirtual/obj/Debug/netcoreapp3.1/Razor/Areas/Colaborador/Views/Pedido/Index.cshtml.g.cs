#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c02e953d8eeb2f4d67e25cc9c52d6fa2f11ceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Pedido_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Pedido/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Pedido;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c02e953d8eeb2f4d67e25cc9c52d6fa2f11ceb", @"/Areas/Colaborador/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58470b0c03ee7c343739b0308174bf884a1f01f4", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var codigoPedido = Context.Request.Query["codigoPedido"];
    var cpf = Context.Request.Query["cpf"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<div class=\"container\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c02e953d8eeb2f4d67e25cc9c52d6fa2f11ceb7254", async() => {
                WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <label for=\"numeroPedido\">Número do Pedido</label>\r\n            <input type=\"text\" name=\"codigoPedido\" class=\"form-control\" id=\"numeroPedido\"");
                BeginWriteAttribute("value", " value=\"", 462, "\"", 483, 1);
#nullable restore
#line 17 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 470, codigoPedido, 470, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group mx-sm-3 mb-2\">\r\n            <label for=\"cpf\">CPF do Cliente</label>\r\n            <input type=\"text\" name=\"cpf\" class=\"form-control\" id=\"cpf\"");
                BeginWriteAttribute("value", " value=\"", 674, "\"", 686, 1);
#nullable restore
#line 21 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 682, cpf, 682, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary mb-2\" value=\"Pesquisar\">Pesquisar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
#nullable restore
#line 29 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
       await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">Nº Pedido</th>
                        <th scope=""col"">Cliente</th>
                        <th scope=""col"">Data compra</th>
                        <th scope=""col"">Valor</th>
                        <th scope=""col"">Forma Pagamento</th>
                        <th scope=""col"">Situação</th>
                        <th scope=""col"">NF-e</th>
                        <th scope=""col"">Ações</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 49 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                     foreach (var pedido in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 52 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 52 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                      Write(pedido.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 53 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                                Write(pedido.Cliente.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.DataRegistro.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.FormaPagamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(Html.Raw(pedido.NFe == null ? "-" : "<a href='" + pedido.NFe + "' target='blank'>NF-e</a>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c02e953d8eeb2f4d67e25cc9c52d6fa2f11ceb15027", async() => {
                WriteLiteral("Visualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                                             WriteLiteral(pedido.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 68 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <!-- output a paging control that lets the user navigation to the previous page, next page, etc -->\r\n    ");
#nullable restore
#line 73 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção27\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina, codigoPedido = codigoPedido, cpf = cpf })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
