#pragma checksum "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e1b2932e91a13f82a8228673592f2fd494e694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Index), @"mvc.1.0.view", @"/Views/Venda/Index.cshtml")]
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
#line 1 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\_ViewImports.cshtml"
using SistemaVenda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\_ViewImports.cshtml"
using SistemaVenda.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e1b2932e91a13f82a8228673592f2fd494e694", @"/Views/Venda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9542d2a040dc74eba97c4a394c73aefd7909e77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVenda.Models.VendaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
  
    ViewData["Title"] = "Vendas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Vendas</h2>
<hr />

<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:#f6f6f6"">
            <th>Código</th>
            <th>Data</th>
            <th>Cliente</th>
            <th>Total</th>
        </tr>
    </thead>

    <thead>
");
#nullable restore
#line 21 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 466, "\"", 496, 3);
            WriteAttributeValue("", 476, "Editar(", 476, 7, true);
#nullable restore
#line 24 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
WriteAttributeValue("", 483, item.Codigo, 483, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 495, ")", 495, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\">\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
                   Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
                   Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
                   Write(item.CodigoCliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Cristhian\Desktop\ProjetoTeste\SistemaVenda\Aplicacao\Aplicacao\Views\Venda\Index.cshtml"
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </thead>
</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Registrar Venda</button>

<script>

    function Editar(Codigo) {
        window.location = window.origin + ""/Venda/Cadastro/"" + Codigo;
    }

    function Cadastrar() {
        window.location = window.origin + ""/Venda/Cadastro"";
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVenda.Models.VendaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
