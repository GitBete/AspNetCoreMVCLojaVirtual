#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25bf92e2339a12f17ca93419f1d08305abf6d8dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarrinhoCompra_Index), @"mvc.1.0.view", @"/Views/CarrinhoCompra/Index.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25bf92e2339a12f17ca93419f1d08305abf6d8dd", @"/Views/CarrinhoCompra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c94bc73b40f578d3062ac4f1b538bd4934d215", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LojaVirtual.Models.ProdutoAgregador.ProdutoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-padrao.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-continuar disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnderecoEntrega", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-continuar-comprando"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal Subtotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
 if (Model.Count > 0)
{
    //Existe produtos


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">

        <section class=""container"" id=""order"" style=""margin-top: 50px"">

            <h2 class=""title-doc"">Carrinho de compras </h2>

            <div class=""alert alert-danger"" style=""display:none"" role=""alert"">
                A simple danger alert-check it ut!
            </div>


            <div id=""code_cart"">
                <div class=""card"">
                    <table class=""table table-hover shopping-cart-wrap"">
                        <thead class=""text-muted"">
                            <tr>
                                <th scope=""col"">Produto</th>
                                <th scope=""col"" width=""140"">Quantidade</th>
                                <th scope=""col"" width=""140"">Preço</th>
                                <th scope=""col"" width=""160"" class=""text-right"">Ação</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 37 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <figure class=\"media\">\r\n");
            WriteLiteral("                                            <div class=\"img-wrap\">\r\n");
#nullable restore
#line 44 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                 if (item.Imagens.Count > 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <img");
            BeginWriteAttribute("src", " src=", 1837, "", 1876, 1);
#nullable restore
#line 46 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 1842, item.Imagens.ElementAt(0).Caminho, 1842, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail img-sm\">\r\n");
#nullable restore
#line 47 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25bf92e2339a12f17ca93419f1d08305abf6d8dd12258", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                            <figcaption class=\"media-body\">\r\n                                                <h6 class=\"title text-truncate\">");
#nullable restore
#line 54 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                                                <dl class=\"dlist-inline small\">\r\n                                                    <dt>Desrição: </dt>\r\n                                                    <dd>");
#nullable restore
#line 57 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                   Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                                                </dl>
                                                <dl class=""dlist-inline small"">
                                                    <dt>Estoque: </dt>
                                                    <dd>");
#nullable restore
#line 61 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                   Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                                                </dl>
                                            </figcaption>
                                        </figure>
                                    </td>
                                    <td>
                                        <div class=""col-auto-listaprodutos"">
                                            <div class=""input-group mb-2 control-inline"">
                                                <input type=""hidden"" class=""inputProdutoId""");
            BeginWriteAttribute("value", " value=\"", 3489, "\"", 3505, 1);
#nullable restore
#line 69 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 3497, item.Id, 3497, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <input type=\"hidden\" class=\"inputProdutoQuantidadeEstoque\"");
            BeginWriteAttribute("value", " value=\"", 3617, "\"", 3641, 1);
#nullable restore
#line 70 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 3625, item.Quantidade, 3625, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <input type=\"hidden\" class=\"inputProdutoValorUnit\"");
            BeginWriteAttribute("value", " value=\"", 3745, "\"", 3764, 1);
#nullable restore
#line 71 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 3753, item.Valor, 3753, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

                                                <div class=""input-group-prepend"">
                                                    <a href=""#"" class=""btn btn-primary diminuir"">-</a>
                                                </div>
                                                <input type=""text"" readonly=""readonly"" class=""form-control inputProdutoQuantidadeCarrinho text-center""");
            BeginWriteAttribute("value", " value=\"", 4165, "\"", 4204, 1);
#nullable restore
#line 76 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 4173, item.QuantidadeProdutoCarrinho, 4173, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                <div class=""input-group-append"">
                                                    <a href=""#"" class=""btn btn-primary aumentar"">+</a>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
");
#nullable restore
#line 83 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                      
                                        var ResultadoSubTotalItem = item.Valor * item.QuantidadeProdutoCarrinho;
                                        Subtotal += ResultadoSubTotalItem;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <div class=\"price-wrap\">\r\n                                            <var class=\"price\">");
#nullable restore
#line 89 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                           Write((item.Valor * item.QuantidadeProdutoCarrinho).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</var>\r\n                                            <small class=\"text-muted\">(");
#nullable restore
#line 90 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                  Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" cada)</small>\r\n                                        </div> <!-- price-wrap .// -->\r\n                                    </td>\r\n                                    <td class=\"text-right\">\r\n");
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bf92e2339a12f17ca93419f1d08305abf6d8dd20271", async() => {
                WriteLiteral(" × Remove");
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
#line 96 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 99 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div> <!-- card.// -->
            </div> <!-- code-wrap.// -->
        </section>

        <br />

        <br />
        <br />
        <section id=""parameters"">

            <div class=""row"">
                <aside class=""col-md-4"">

                    <div id=""code_desc_align"">

                        <div class=""box"">
                            <h4 class=""subtitle-doc"">
                                Frete
                            </h4>


                            <dl class=""dlist-align"">
                                <dt>CEP:</dt>
                                <dd>
                                    <div class=""input-group"">
                                        <input type=""text"" name=""cep"" class=""form-control cep"" />
                                        <div class=""input-group-append"">
                                            <a href=""#"" class=""btn btn-outline-primary btn-c");
            WriteLiteral("alcular-frete\">OK</a>\r\n                                        </div>\r\n                                    </div>\r\n                                </dd>\r\n                            </dl>\r\n\r\n                            <div class=\"container-frete\">\r\n");
            WriteLiteral(@"                            </div>

                        </div>
                    </div>
                </aside>

                <aside class=""col-md-4"">

                    <div id=""code_desc_align"">

                        <div class=""box"">
                            <h4 class=""subtitle-doc"">
                                Resumo
                            </h4>

                            <dl class=""dlist-align"">
                                <dt>Sub-Total:</dt>
                                <dd class=""text-right subtotal"">");
#nullable restore
#line 154 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                           Write(Subtotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Frete:</dt>
                                <dd class=""text-right frete"">R$ 0,00</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Total:</dt>
                                <dd class=""text-right total"">R$ 0,00</dd>
                            </dl>
                        </div>
                    </div>
                </aside>

                <aside class=""col-md-4"">

                    <div id=""code_desc_align"">

                        <div class=""box"">
                            <h4 class=""subtitle-doc"">
                                Informar Pagamento
                            </h4>
");
#nullable restore
#line 177 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                             if (_loginCliente.GetCliente() == null)
                            {
                                //Tela de login

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dl class=\"dlist-align\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bf92e2339a12f17ca93419f1d08305abf6d8dd26794", async() => {
                WriteLiteral(" Continuar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 181 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                                                            WriteLiteral(Url.Action("EnderecoEntrega","CarrinhoCompra",new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </dl>\r\n");
#nullable restore
#line 183 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                            }
                            else
                            {
                                //Tela de endereco

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dl class=\"dlist-align\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bf92e2339a12f17ca93419f1d08305abf6d8dd30158", async() => {
                WriteLiteral(" Continuar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </dl>\r\n");
#nullable restore
#line 190 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </aside>\r\n\r\n            </div>\r\n        </section>\r\n\r\n\r\n    </div>\r\n");
#nullable restore
#line 201 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"


}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <br />
    <br />

    <div class=""row"">
        <div class=""col-md-12"">
            <h1 class=""title-doc"">Carrinho de compras </h1>
            <br />
            <h3 class=""title-doc"">Seu carrinho está vazio! </h3>

            Para continuar comprando, navegue pelas categorias do site ou faça uma busca pelo seu produto.
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bf92e2339a12f17ca93419f1d08305abf6d8dd32722", async() => {
                WriteLiteral("Click aqui");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" e comece a comprar.\r\n\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25bf92e2339a12f17ca93419f1d08305abf6d8dd34253", async() => {
                WriteLiteral("Escolher Produtos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("as-", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
#nullable restore
#line 234 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LojaVirtual.Models.ProdutoAgregador.ProdutoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
