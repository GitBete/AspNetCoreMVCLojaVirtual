#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea8ac7b6e6f028d10ae48d12a99378f34bddbbb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Pedido_Visualizar), @"mvc.1.0.view", @"/Areas/Cliente/Views/Pedido/Visualizar.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8ac7b6e6f028d10ae48d12a99378f34bddbbb8", @"/Areas/Cliente/Views/Pedido/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1455026fa10b292a2f92419fa5613c5828b2c2f8", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Pedido_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
    {
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
        private global::AspNetCore.Areas_Cliente_Views_Pedido_Visualizar.__Generated__PedidoSituacaoViewComponentTagHelper __PedidoSituacaoViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
  
        ViewData["Title"] = "Visualizar";

        TransacaoPagarMe transacao = JsonConvert.DeserializeObject<TransacaoPagarMe>(Model.DadosTransaction);
        List<ProdutoItem> produtos = JsonConvert.DeserializeObject<List<ProdutoItem>>(Model.DadosProdutos, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() });
        var aniversario =  DateTime.Parse (transacao.Customer.Birthday);
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\" text-center>\r\n        \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pedido-situacao", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea8ac7b6e6f028d10ae48d12a99378f34bddbbb86136", async() => {
            }
            );
            __PedidoSituacaoViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Cliente_Views_Pedido_Visualizar.__Generated__PedidoSituacaoViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PedidoSituacaoViewComponentTagHelper);
#nullable restore
#line 17 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
__PedidoSituacaoViewComponentTagHelper.pedido = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("pedido", __PedidoSituacaoViewComponentTagHelper.pedido, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br />\r\n\r\n");
            WriteLiteral(@"
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">

            <h3>Dados pedido</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""2""><strong>Situação do pedido:</strong> ");
#nullable restore
#line 37 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                                    Write(Model.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Cliente:</strong> ");
#nullable restore
#line 40 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                             Write(transacao.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td><strong>Nascimento:</strong> ");
#nullable restore
#line 41 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                Write(aniversario.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Forma Pagamento:</strong> ");
#nullable restore
#line 44 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                     Write(Model.FormaPagamento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td><strong>Nota fiscal eletrônica:</strong> ");
#nullable restore
#line 45 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                            Write(Model.NFe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </table>

            <h3>Entrega</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""4"">
                        <strong>Endereço de entrega:</strong> ");
#nullable restore
#line 53 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                         Write(transacao.Shipping.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>CEP:</strong> ");
#nullable restore
#line 57 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                         Write(transacao.Shipping.Address.Zipcode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td><strong>UF:</strong> ");
#nullable restore
#line 58 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                        Write(transacao.Shipping.Address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Cidade:</strong> ");
#nullable restore
#line 59 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Bairro:</strong> ");
#nullable restore
#line 60 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.Neighborhood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\">\r\n                        <strong>Logradouro:</strong> ");
#nullable restore
#line 64 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                Write(transacao.Shipping.Address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td><strong>Complemento:</strong> ");
#nullable restore
#line 66 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                 Write(transacao.Shipping.Address.Complementary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Número:</strong> ");
#nullable restore
#line 67 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.StreetNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\">\r\n                        <strong>Transportadora:</strong> ");
#nullable restore
#line 71 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                    Write(Model.FreteEmpresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td><strong>Valor do frete:</strong> ");
#nullable restore
#line 73 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                    Write(Mascara.ConverterPagarMeIntDecimal(@transacao.Shipping.Fee).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Rastreamento:</strong> -");
#nullable restore
#line 74 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                   Write(Model.FreteCodRastreamento);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </table>


            <h3>Lista de produto</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td><strong>Quantidade</strong></td>
                    <td><strong>Nome</strong></td>
                    <td><strong>Valor</strong></td>
                    <td><strong>TOTAL</strong></td>
                </tr>
");
#nullable restore
#line 87 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                 foreach (var produto in produtos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 90 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.QuantidadeProdutoCarrinho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 91 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 92 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 93 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                        Write((produto.Valor * produto.QuantidadeProdutoCarrinho).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 95 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>FRETE</strong></td>\r\n                    <td>");
#nullable restore
#line 99 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                   Write(Mascara.ConverterPagarMeIntDecimal(@transacao.Shipping.Fee).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>TOTAL</strong></td>\r\n                    <td>");
#nullable restore
#line 103 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção24\LojaVirtual\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                   Write(Model.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n            <br />\r\n            <br />\r\n\r\n            <button class=\"btn btn-outline-primary btn-lg btn-imprimir\">Imprimir</button>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pedido-situacao")]
        public class __Generated__PedidoSituacaoViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__PedidoSituacaoViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public LojaVirtual.Models.Pedido pedido { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("PedidoSituacao", new { pedido });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
