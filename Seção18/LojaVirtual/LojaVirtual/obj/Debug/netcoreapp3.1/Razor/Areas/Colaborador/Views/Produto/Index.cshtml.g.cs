#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7649ad37173ed443819dfe3d5589a0b2e0639df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Produto_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
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
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7649ad37173ed443819dfe3d5589a0b2e0639df", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a373e311ea3484119b04b9c613002227a7ebe2", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.PagedList<LojaVirtual.Models.ProdutoAgregador.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Produto</h1>\r\n\r\n<!-- formulario -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7649ad37173ed443819dfe3d5589a0b2e0639df7310", async() => {
                WriteLiteral("\r\n    <!-----Query string: Colaborador/Cliente/index?pesquisa={palavradigitada}&pagina=3-->\r\n    <div class=\"form-group\">\r\n        <label for=\"Pesquisa\"></label>\r\n        <input type=\"text\" name=\"pesquisa\" id=\"pesquisa\"");
                BeginWriteAttribute("value", " value=\"", 454, "\"", 471, 1);
#nullable restore
#line 15 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
WriteAttributeValue("", 462, pesquisa, 462, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"Digite o nome do produto\">\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Pesquisar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 23 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-info\">");
#nullable restore
#line 25 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                           Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7649ad37173ed443819dfe3d5589a0b2e0639df10471", async() => {
                WriteLiteral("Cadastrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 32 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
#nullable restore
#line 39 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 41 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 42 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 47 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                 foreach (Produto produto in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 50 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(produto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 51 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                   Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                   Write(produto.CategoriaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                   Write(produto.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7649ad37173ed443819dfe3d5589a0b2e0639df15546", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                    WriteLiteral(produto.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7649ad37173ed443819dfe3d5589a0b2e0639df17876", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                  WriteLiteral(produto.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("    <!-- output a paging control that lets the user navigation to the previous page, next page, etc -->\r\n");
#nullable restore
#line 66 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                                                                                        

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Nenhum registro cadastrado!</span>\r\n");
#nullable restore
#line 72 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção18\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.PagedList<LojaVirtual.Models.ProdutoAgregador.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
