#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c75aa2c0a8d0a1f2d823737501caa3d0c71fddc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75aa2c0a8d0a1f2d823737501caa3d0c71fddc9", @"/Views/Home/Contato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a17999865a57f7b98c67658c82d8a5f3a32fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/ContatoAcao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
  

    ViewData["Title"] = "Contato";
    LojaVirtual.Models.Contato contato = (LojaVirtual.Models.Contato) ViewData["CONTATO"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    # Outros contatos
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Devolução/Garantia: </dt>
                            <dd>devolucao@lojavirtual.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Televendas: </dt>
                            <dd>(61) 4000-2000</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@lojavirtual.com.br</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->");
            WriteLiteral(@"
            </aside>
            <aside class=""col-sm-6"">

                <h4 class=""subtitle-doc"">
                    Contato                    
                </h4>
                <div id=""contato"">

                    <article class=""card"">
                        <div class=""card-body p-5"">
");
#nullable restore
#line 44 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_S"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"alert alert-success\">");
#nullable restore
#line 46 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                          Write(ViewData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_E"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"alert alert-danger\">");
#nullable restore
#line 50 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                         Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c75aa2c0a8d0a1f2d823737501caa3d0c71fddc98714", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" id=""nome"" class=""form-control"" name=""nome""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2520, "\"", 2534, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", "\r\n                                               required=\"", 2535, "\"", 2594, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2595, "\"", 2641, 1);
#nullable restore
#line 61 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
WriteAttributeValue("", 2603, contato != null ? contato.Nome : "", 2603, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" id=""email"" class=""form-control"" name=""email""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3304, "\"", 3318, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3319, "\"", 3366, 1);
#nullable restore
#line 71 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
WriteAttributeValue("", 3327, contato != null ? contato.Email : "", 3327, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div> <!-- input-group.// -->
                                </div> <!-- form-group.// -->

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%"">");
#nullable restore
#line 80 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção17\LojaVirtual\LojaVirtual\Views\Home\Contato.cshtml"
                                                                                                                      Write(contato != null ? contato.Texto : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div> <!-- row.// -->
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div> <!-- card-body.// -->\r\n                    </article> <!-- card.// -->\r\n\r\n                </div> <!-- code-wrap.// -->\r\n\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n");
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
