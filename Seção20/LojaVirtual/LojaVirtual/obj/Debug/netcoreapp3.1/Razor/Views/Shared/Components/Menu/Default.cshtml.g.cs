#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3acb09252ec04f5a8c6b2e4a9be3d26d04177228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3acb09252ec04f5a8c6b2e4a9be3d26d04177228", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a17999865a57f7b98c67658c82d8a5f3a32fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Painel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
   
    var @pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark fixed-top bg-dark"">
    <a class=""navbar-brand"" href=""/""> LojaVirtual</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
       

    <ul class=""navbar-nav mr-auto"">
        <li");
            BeginWriteAttribute("class", " class=\"", 618, "\"", 783, 2);
            WriteAttributeValue("", 626, "nav-item", 626, 8, true);
#nullable restore
#line 15 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 634, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Index") ? "active" : "", 635, 148, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"nav-link\" href=\"/\"><i class=\"fas fa-home\"></i> Home <span class=\"sr-only\">(current)</span></a>\r\n        </li>\r\n\r\n");
#nullable restore
#line 19 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
          
            var TodasCategorias = Model.ToList();
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
         if (TodasCategorias != null && TodasCategorias.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"dropdown\">\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("class", " class=\"", 1360, "\"", 1545, 3);
            WriteAttributeValue("", 1368, "nav-link", 1368, 8, true);
            WriteAttributeValue(" ", 1376, "dropdown-toggle", 1377, 16, true);
#nullable restore
#line 29 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 1392, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Categoria") ? "active" : "", 1393, 152, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown""
                   aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-list-ul""></i> Categorias
                </a>
                <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
");
#nullable restore
#line 34 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                      
                        var CategoriasPrincipais = TodasCategorias.Where(a => a.CategoriaPaiId == null).ToList();
                        ViewData["TodasCategorias"] = TodasCategorias;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                     foreach (var categoria in CategoriasPrincipais)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                   Write(await Html.PartialAsync("~/Views/Shared/Components/Menu/_Submenu.cshtml", new ViewDataDictionary(ViewData) { { "CategoriaPai", categoria } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                                                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 2447, "\"", 2614, 2);
            WriteAttributeValue("", 2455, "nav-item", 2455, 8, true);
#nullable restore
#line 46 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 2463, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Contato") ? "active" : "", 2464, 150, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"nav-link\" href=\"/Home/Contato\"><i class=\"far fa-address-book\"></i> Contato </a>\r\n        </li>\r\n    </ul>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acb09252ec04f5a8c6b2e4a9be3d26d0417722813087", async() => {
                WriteLiteral("\r\n        <input class=\"form-control mr-sm-2\" type=\"search\" name=\"pesquisa\"");
                BeginWriteAttribute("value", " value=\"", 2878, "\"", 2895, 1);
#nullable restore
#line 51 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 2886, pesquisa, 2886, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"palavra\" aria-label=\"Search\">\r\n        <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Pesquisa</button>\r\n\r\n");
#nullable restore
#line 54 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
         if (_loginCliente.GetCliente() !=null)
        {
            //colocar o nick do cliente ou primeiro nome

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acb09252ec04f5a8c6b2e4a9be3d26d0417722814385", async() => {
                    WriteLiteral("<i class=\"fas fa-user-alt\"></i> ");
#nullable restore
#line 57 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                        Write(_loginCliente.GetCliente().Nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acb09252ec04f5a8c6b2e4a9be3d26d0417722816814", async() => {
                    WriteLiteral("<i class=\"fas fa-user-alt\"></i> Entrar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acb09252ec04f5a8c6b2e4a9be3d26d0417722818849", async() => {
                    WriteLiteral("<i class=\"fas fa-shopping-cart\"></i> Carrinho");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n</nav>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LojaVirtual.Libraries.Login.LoginCliente _loginCliente { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
