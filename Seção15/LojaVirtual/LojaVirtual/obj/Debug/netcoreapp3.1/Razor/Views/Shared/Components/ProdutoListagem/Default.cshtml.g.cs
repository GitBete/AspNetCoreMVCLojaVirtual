#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "476c7bb6a61165c16d3f8bd92590ab8c3b3ac986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProdutoListagem_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProdutoListagem/Default.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"476c7bb6a61165c16d3f8bd92590ab8c3b3ac986", @"/Views/Shared/Components/ProdutoListagem/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5ba01ddf8e8cddf8344af8dc6f8f1ce771fffe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProdutoListagem_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoListagemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ordenacao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];
    var ordenacao = Context.Request.Query["ordenacao"].ToString();
    var action = ViewContext.RouteData.Values["action"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
 if (Model.lista.Count > 0)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" id=\"code_prod_complex\">\r\n        <div class=\"row\">\r\n            <div class=\"offset-md-10\" col-md-2>\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "476c7bb6a61165c16d3f8bd92590ab8c3b3ac9866174", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ordenacao);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ordenacao;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 22 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
             foreach (var produto in Model.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "476c7bb6a61165c16d3f8bd92590ab8c3b3ac9868776", async() => {
                WriteLiteral("\r\n                    <div class=\"col-md-3\">\r\n                        <figure class=\"card card-product\">\r\n                            <div class=\"img-wrap\">\r\n");
#nullable restore
#line 28 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                 if (produto.Imagens != null && produto.Imagens.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <img");
                BeginWriteAttribute("src", " src=\"", 1255, "\"", 1298, 1);
#nullable restore
#line 30 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
WriteAttributeValue("", 1261, produto.Imagens.ElementAt(0).Caminho, 1261, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 31 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <img src=\"~\\img\\imagem-padrao.png\" />\r\n");
#nullable restore
#line 35 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <figcaption class=\"info-wrap\">\r\n                                <h4 class=\"title\">");
#nullable restore
#line 39 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                             Write(produto.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                                <div class=""rating-wrap"">
                                    <ul class=""rating-stars"">
                                        <li style=""width:80%"" class=""stars-active"">
                                            <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                        </li>
                                        <li>
                                            <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                        </li>
                                    </ul>
                                    <div class=""label-rating"">132 reviews</div>
                                    <div class=""label-rating"">154 orders </div>
                                </div> <!-- rating-wrap.// -->
                            </figcaption>
      ");
                WriteLiteral("                      <div class=\"bottom-wrap\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2790, "\"", 2797, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-primary float-right\">Adicionar Carrinho</a>\r\n                                <div class=\"price-wrap h5\">\r\n                                    <span class=\"price-new\">");
#nullable restore
#line 56 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                                       Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> <del class=\"price-old\">");
#nullable restore
#line 56 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                                                                                                  Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</del>
                                </div> <!-- price-wrap.// -->
                            </div> <!-- bottom-wrap.// -->
                        </figure>
                    </div> <!-- col // -->
                    <!-- fim loop.// -->
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
                                                                      WriteLiteral(produto.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div> <!-- row.// -->\r\n        <!-- output a paging control that lets the user navigation to the previous page, next page, etc -->\r\n        ");
#nullable restore
#line 66 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
   Write(Html.PagedListPager((IPagedList)Model.lista, pagina => Url.Action(action, new { pagina = pagina, pesquisa = pesquisa, ordenacao = ordenacao })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 68 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" id=\"code_prod_complex\">\r\n        <br />\r\n        <div class=\"alert alert-info\" role=\"alert\">\r\n            <strong>Opsss!</strong>Não temos produtos para esta categoria!\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção15\LojaVirtual\LojaVirtual\Views\Shared\Components\ProdutoListagem\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoListagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
