#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea47b21acd2715712a8e6349a65b50aa59d7c462"
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea47b21acd2715712a8e6349a65b50aa59d7c462", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313179fbb221093f34d6c5773b1d9b49e630972f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ordenacao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];
    var ordenacao = Context.Request.Query["ordenacao"].ToString();

#line default
#line hidden
#nullable disable
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
                                g");
            WriteLiteral(@"ravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
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
            WriteLiteral(@"  <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
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
            WriteLiteral(@"       </div>
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
#nullable restore
#line 76 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
         if (Model.lista.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\" id=\"code_prod_complex\">\r\n                <div class=\"row\">\r\n                    <div class=\"offset-md-10\" col-md-2>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea47b21acd2715712a8e6349a65b50aa59d7c4629045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 85 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => ordenacao);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 85 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 89 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                     foreach (var produto in Model.lista)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-3\">\r\n                            <figure class=\"card card-product\">\r\n                                <div class=\"img-wrap\">\r\n");
#nullable restore
#line 94 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                     if (produto.Imagens != null && produto.Imagens.Count() > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 5102, "\"", 5145, 1);
#nullable restore
#line 96 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
WriteAttributeValue("", 5108, produto.Imagens.ElementAt(0).Caminho, 5108, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 97 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img src=\"~\\img\\imagem-padrao.png\" />\r\n");
#nullable restore
#line 101 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <figcaption class=\"info-wrap\">\r\n                                    <h4 class=\"title\">");
#nullable restore
#line 105 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
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
 ");
            WriteLiteral("                               </figcaption>\r\n                                <div class=\"bottom-wrap\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 6729, "\"", 6736, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary float-right\">Adicionar Carrinho</a>\r\n                                    <div class=\"price-wrap h5\">\r\n                                        <span class=\"price-new\">");
#nullable restore
#line 122 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                                           Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <del class=\"price-old\">");
#nullable restore
#line 122 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
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
#nullable restore
#line 128 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div> <!-- row.// -->\r\n                <!-- output a paging control that lets the user navigation to the previous page, next page, etc -->\r\n                ");
#nullable restore
#line 131 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
           Write(Html.PagedListPager((IPagedList)Model.lista, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa, ordenacao = ordenacao })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 133 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </main>\r\n");
#nullable restore
#line 135 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
   
    /*
     * Razor - Motor de template do APS.NET
     * Html Helper - Interface para gerar codigo html por meio do #C
     * ajuda na manipulacao das informações html
     * exemplo chamando um link = @Html.ActionLink("Texto","Index")
     */

    /*
    * URL: #Fragmento ... link do tipo ancora
    */

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 148 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
 using (Html.BeginForm(null, null, null, FormMethod.Post, true, new { @action = Url.Action("index", "home") + "#formulario" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" id=\"formulario\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8\" offset-sm-2>\r\n");
#nullable restore
#line 153 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
             if (TempData["MSG_S"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"alert alert-info\">");
#nullable restore
#line 155 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                       Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 156 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
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
#line 168 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
               Write(Html.EditorFor(m => m.newsletter.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div> <!-- input-group.// -->\r\n                <span style=\"color: red;\">");
#nullable restore
#line 170 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"
                                     Write(Html.ValidationMessageFor(m => m.newsletter.Email));

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
#line 179 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção13\LojaVirtual\LojaVirtual\Views\Home\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
