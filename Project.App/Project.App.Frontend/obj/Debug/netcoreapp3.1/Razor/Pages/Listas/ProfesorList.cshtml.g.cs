#pragma checksum "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7720953893a294e31781c04404796730fb899ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.App.Frontend.Pages.Listas.Pages_Listas_ProfesorList), @"mvc.1.0.razor-page", @"/Pages/Listas/ProfesorList.cshtml")]
namespace Project.App.Frontend.Pages.Listas
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
#line 1 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\_ViewImports.cshtml"
using Project.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7720953893a294e31781c04404796730fb899ca2", @"/Pages/Listas/ProfesorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629c7adc170cba55b9ddc5b13d6a7e42fd0f9d9c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_ProfesorList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
  
    ViewData["Title"] = "Lista profesores";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Lista de saludos en varios idiomas</h1>
<table class = ""table"">
    <tr>
            <td>Nombre</td>
            <td>Apellidos</td>
            <td>Id</td>
            <td>Edad</td>
            <td>Diagnostico</td>
            <td>Vacuna</td>
            <td>Departamento</td>
            <td>Materia</td>

    </tr>
    
");
#nullable restore
#line 21 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
     foreach(var profesor in Model.Profesores)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.diagnostico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.vacuna);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
           Write(profesor.materia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Project\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.App.Frontend.Pages.ProfesorList> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.App.Frontend.Pages.ProfesorList> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.App.Frontend.Pages.ProfesorList>)PageContext?.ViewData;
        public Project.App.Frontend.Pages.ProfesorList Model => ViewData.Model;
    }
}
#pragma warning restore 1591