#pragma checksum "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6daa262fd5fd35ad8d72925ab22d955fcb3f2c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
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
#line 3 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6daa262fd5fd35ad8d72925ab22d955fcb3f2c27", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5ba01ddf8e8cddf8344af8dc6f8f1ce771fffe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Produto-> Visualizar</h3>\r\n:)\r\n\r\nRazor:\r\n");
#nullable restore
#line 7 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
  
    string nome = "Elisabete Silvestre";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 11 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<br />\r\n<h3>Produto</h3>\r\n<b>Código:</b> ");
#nullable restore
#line 15 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<b>Nome:</b> ");
#nullable restore
#line 17 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<b>Descrição:</b> ");
#nullable restore
#line 19 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<b>Valor:</b> ");
#nullable restore
#line 21 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\nTodos os direitos reservaods &copy; ");
#nullable restore
#line 25 "C:\CursoProgramacao\ASPNet_Core\AspNetCoreMVCLojaVirtual\Seção14\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.UtcNow);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
