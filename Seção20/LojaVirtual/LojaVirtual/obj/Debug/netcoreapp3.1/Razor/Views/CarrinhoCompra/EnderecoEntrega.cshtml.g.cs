#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d323203d7f106ae004827ff650933f00e3a24e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarrinhoCompra_EnderecoEntrega), @"mvc.1.0.view", @"/Views/CarrinhoCompra/EnderecoEntrega.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d323203d7f106ae004827ff650933f00e3a24e7c", @"/Views/CarrinhoCompra/EnderecoEntrega.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b46e2aa1bd6a2749e2ff871bf879768657b1eafe", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_EnderecoEntrega : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnderecoEntregaExcluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastroEnderecoEntrega", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-continuar disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
  
    ViewData["Title"] = "EnderecoEntrega";

    var produtos = (List<ProdutoItem>)ViewBag.Produtos;
    decimal total = 0;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
     foreach (ProdutoItem produto in produtos)
    {
        decimal resultado = produto.Valor * produto.QuantidadeProdutoCarrinho;
        total += resultado;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n");
#nullable restore
#line 21 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
               await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
            <table class=""table table-hover"">

                <tbody>
                    <tr>
                        <th scope=""row"">
                            <input type=""radio"" name=""endereco"" value=""0"" id=""0-end"" />
                            <input type=""hidden"" name=""cep""");
            BeginWriteAttribute("value", " value=\"", 954, "\"", 982, 1);
#nullable restore
#line 34 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 962, ViewBag.Cliente.CEP, 962, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                        </th>
                        <td>
                            <label for=""0-end"">
                                <strong>Nome: </strong>Endereço Principal.
                                <p>
                                    ");
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                               Write(ViewBag.Cliente.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral("   | ");
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                        Write(ViewBag.Cliente.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                              Write(ViewBag.Cliente.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                        Write(ViewBag.Cliente.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                                                  Write(ViewBag.Cliente.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                                </p>\r\n                            </label>\r\n                        </td>\r\n                        <td>\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n\r\n");
#nullable restore
#line 52 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                     foreach (EnderecoEntrega enderecoEntrega in ViewBag.Enderecos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">\r\n                                <input type=\"radio\" name=\"endereco\"");
            BeginWriteAttribute("value", " value=\"", 2170, "\"", 2197, 1);
#nullable restore
#line 56 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 2178, enderecoEntrega.Id, 2178, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2198, "\"", 2226, 2);
#nullable restore
#line 56 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 2203, enderecoEntrega.Id, 2203, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2222, "-end", 2222, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"cep\"");
            BeginWriteAttribute("value", " value=\"", 2295, "\"", 2323, 1);
#nullable restore
#line 57 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 2303, enderecoEntrega.CEP, 2303, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </th>\r\n                            <td>\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 2436, "\"", 2465, 2);
#nullable restore
#line 60 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
WriteAttributeValue("", 2442, enderecoEntrega.Id, 2442, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2461, "-end", 2461, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <strong>Nome: </strong>");
#nullable restore
#line 61 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                      Write(enderecoEntrega.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 63 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                   Write(enderecoEntrega.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 63 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                          Write(enderecoEntrega.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 63 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                Write(enderecoEntrega.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 63 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                          Write(enderecoEntrega.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 63 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                                                    Write(enderecoEntrega.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                                    </p>\r\n                                </label>\r\n                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d323203d7f106ae004827ff650933f00e3a24e7c16284", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                         WriteLiteral(enderecoEntrega.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 74 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n\r\n            <div class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d323203d7f106ae004827ff650933f00e3a24e7c19073", async() => {
                WriteLiteral("Cadastra novo endereço");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                                                                          WriteLiteral(Url.Action("EnderecoEntrega","CarrinhoCompra",new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <br />\r\n\r\n");
            WriteLiteral("            <div class=\"card-group\">\r\n                <div class=\"card\">\r\n");
            WriteLiteral(@"                    <div class=""card-body"">
                        <h5 class=""card-title"">-</h5>
                        <p class=""card-text"">-</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            -
                        </small>
                    </div>
                </div>
                <div class=""card"">
");
            WriteLiteral(@"                    <div class=""card-body"">
                        <h5 class=""card-title"">-</h5>
                        <p class=""card-text"">-</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            -
                        </small>
                    </div>
                </div>
                <div class=""card"">
");
            WriteLiteral(@"                    <div class=""card-body"">
                        <h5 class=""card-title"">-</h5>
                        <p class=""card-text"">-</p>
                    </div>
                    <div class=""card-footer"">
                        <small class=""text-muted"">
                            -
                        </small>
                    </div>
                </div>
            </div>

            <br />

            <div class=""card-group"">
                <div class=""card"">

                    <div class=""card-body"">
                        <h5 class=""card-title"">Produtos</h5>
                        <p class=""card-text texto-produto"">");
#nullable restore
#line 132 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção20\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\EnderecoEntrega.cshtml"
                                                      Write(total.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"">

                    <div class=""card-body"">
                        <h5 class=""card-title"">Frete</h5>
                        <p class=""card-text texto-frete"">-</p>
                    </div>
                </div>
                <div class=""card"">

                    <div class=""card-body"">
                        <h5 class=""card-title"">Total</h5>
                        <p class=""card-text texto-total"">-</p>
                    </div>
                </div>
            </div>

            <br />

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d323203d7f106ae004827ff650933f00e3a24e7c24760", async() => {
                WriteLiteral("Continuar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
