#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b2f4d96b607f49845c57993428745cdb6117be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b2f4d96b607f49845c57993428745cdb6117be", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c94bc73b40f578d3062ac4f1b538bd4934d215", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";

    decimal valorTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 text-center\" >\r\n            <h1>Pedido nº ");
#nullable restore
#line 15 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                                 Write(Model.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Quantidade</th>
                        <th>Valor</th>
                    </tr>
                </thead>

");
#nullable restore
#line 26 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                 foreach (ProdutoItem produto in ViewBag.Produtos)
                {
                    valorTotal += (produto.QuantidadeProdutoCarrinho * produto.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 30 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                       Write(produto.QuantidadeProdutoCarrinho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                             ");
#nullable restore
#line 33 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                         Write((produto.QuantidadeProdutoCarrinho * produto.Valor).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            (");
#nullable restore
#line 34 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                        Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" unid)\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <tr>\r\n                    <td colspan=\"2\">Frete</td>\r\n                        <td>\r\n");
#nullable restore
#line 42 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                              
                                var frete = @Mascara.ConverterPagarMeIntDecimal(ViewBag.Transacao.Shipping.Fee);
                                valorTotal += frete;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
#nullable restore
#line 46 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                       Write(frete.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                <tr>\r\n                    <td colspan=\"2\">TOTAL</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
                   Write(valorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n\r\n");
#nullable restore
#line 55 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
             if (Model.FormaPagamento == MetodoPagamentoConstant.Boleto)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>Boleto</h3>\r\n                <iframe");
            BeginWriteAttribute("src", " src=\"", 1917, "\"", 1951, 1);
#nullable restore
#line 58 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1923, ViewBag.Transacao.BoletoUrl, 1923, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%; min-height: 400px; border: 1px solid #CCC;\"></iframe>\r\n                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 2062, "\"", 2097, 1);
#nullable restore
#line 59 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 2069, ViewBag.Transacao.BoletoUrl, 2069, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\">Imprimir</a>\r\n");
#nullable restore
#line 60 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção22\LojaVirtual\LojaVirtual\Views\Pedido\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b2f4d96b607f49845c57993428745cdb6117be11994", async() => {
                WriteLiteral("Voltar a comprar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
