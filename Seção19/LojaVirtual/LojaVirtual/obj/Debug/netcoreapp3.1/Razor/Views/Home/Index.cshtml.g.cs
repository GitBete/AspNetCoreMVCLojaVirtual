#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7059c2fde109be676d7979897272ac8076372a86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7059c2fde109be676d7979897272ac8076372a86", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a17999865a57f7b98c67658c82d8a5f3a32fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.NewsletterEmail>
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
        private global::AspNetCore.Views_Home_Index.__Generated__ProdutoListagemViewComponentTagHelper __ProdutoListagemViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <main role=""main"">

        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                <li data-target=""#myCarousel"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""first-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                         alt=""First slide"">
                    <div class=""container"">
                        <div class=""carousel-caption text-left"">
                            <h1>Example headline.</h1>
                            <p>
                                Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                               ");
            WriteLiteral(@" gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                            </p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""second-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                         alt=""Second slide"">
                    <div class=""container"">
                        <div class=""carousel-caption"">
                            <h1>Another example headline.</h1>
                            <p>
                                Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                                gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                            </p>
                        ");
            WriteLiteral(@"    <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""third-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                         alt=""Third slide"">
                    <div class=""container"">
                        <div class=""carousel-caption text-right"">
                            <h1>One more for good measure.</h1>
                            <p>
                                Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                                gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                            </p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
                        </div>
           ");
            WriteLiteral(@"         </div>
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>


        <!-- Lista de Produtos
        ================================================== -->
        <!-- Wrap the rest of the page in another container to center all the content. -->
");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:produto-listagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7059c2fde109be676d7979897272ac8076372a867993", async() => {
            }
            );
            __ProdutoListagemViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Home_Index.__Generated__ProdutoListagemViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__ProdutoListagemViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </main>\r\n");
#nullable restore
#line 76 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
   
    /*
     * Razor - Motor de template do APS.NET
     * Html Helper - Interface para gerar codigo html por meio do #C
     * ajuda na manipulacao das informações html
     * exemplo chamando um link = @Html.ActionLink("Texto","Index")
     */

   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
 using (Html.BeginForm(null, null, null, FormMethod.Post, true, new { @action = Url.Action("index", "home") + "#formulario" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" id=\"formulario\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8\" offset-sm-2>\r\n");
#nullable restore
#line 92 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
             if (TempData["MSG_S"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"alert alert-info\">");
#nullable restore
#line 94 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                       Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 95 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>

    <div class=""row"">
        <div class=""col-sm-6"" offset-sm-2>
            <div class=""form-group"">
                <label for=""email"">Cadastre seu E-mail para receber promoções!</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text""><i class=""fa fa-envelope""></i></span>
                    </div>
                    ");
#nullable restore
#line 107 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
               Write(Html.EditorFor(m => m.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div> <!-- input-group.// -->\r\n                <span style=\"color: red;\">");
#nullable restore
#line 109 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                     Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div> <!-- form-group.// -->
        </div>
        <div class=""col-sm-2"">
            <br />
            <button class=""subscribe btn btn-primary btn-block"" type=""submit"" style=""margin-top:7px ""> Cadastrar </button>
        </div>
    </div>
</div>
");
#nullable restore
#line 118 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção19\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.NewsletterEmail> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:produto-listagem")]
        public class __Generated__ProdutoListagemViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__ProdutoListagemViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("ProdutoListagem", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
