#pragma checksum "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\SalonList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "926d5425e2c7cff035bb5a8f1b02a7f0b7f4cb05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.App.Frontend.Pages.Listas.Pages_Listas_SalonList), @"mvc.1.0.razor-page", @"/Pages/Listas/SalonList.cshtml")]
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
#line 1 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\_ViewImports.cshtml"
using Project.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926d5425e2c7cff035bb5a8f1b02a7f0b7f4cb05", @"/Pages/Listas/SalonList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629c7adc170cba55b9ddc5b13d6a7e42fd0f9d9c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_SalonList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Lista salones</h1>\r\n<table class = \"table\">\r\n    <tr>\r\n        <td>Id</td>\r\n        <td>Aforo</td>\r\n        <td>Hora</td>\r\n    </tr>\r\n    \r\n");
#nullable restore
#line 14 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\SalonList.cshtml"
     foreach(var salon in Model.Salones)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\SalonList.cshtml"
           Write(salon.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\SalonList.cshtml"
           Write(salon.aforo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\SalonList.cshtml"
           Write(salon.hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\SalonList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.App.Frontend.Pages.SalonList> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.App.Frontend.Pages.SalonList> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.App.Frontend.Pages.SalonList>)PageContext?.ViewData;
        public Project.App.Frontend.Pages.SalonList Model => ViewData.Model;
    }
}
#pragma warning restore 1591
