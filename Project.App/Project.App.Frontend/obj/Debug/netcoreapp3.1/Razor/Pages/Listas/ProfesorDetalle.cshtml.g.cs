#pragma checksum "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dad41fe9252cacab58ba6aee863a8ffd915b94ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.App.Frontend.Pages.Listas.Pages_Listas_ProfesorDetalle), @"mvc.1.0.razor-page", @"/Pages/Listas/ProfesorDetalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad41fe9252cacab58ba6aee863a8ffd915b94ea", @"/Pages/Listas/ProfesorDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629c7adc170cba55b9ddc5b13d6a7e42fd0f9d9c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_ProfesorDetalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Listas/ProfesorList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Detalle profesor</h1>\r\n<table class = \"table\">\r\n \r\n    <tr>\r\n        <td>");
#nullable restore
#line 10 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 11 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.diagnostico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.vacuna);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\ProyectoCompu\CompuMundoHiperMegaRed\Project.App\Project.App.Frontend\Pages\Listas\ProfesorDetalle.cshtml"
       Write(Model.profesor.materia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n   \r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dad41fe9252cacab58ba6aee863a8ffd915b94ea6358", async() => {
                WriteLiteral("Profesores");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.App.Frontend.Pages.ProfesorDetalle> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.App.Frontend.Pages.ProfesorDetalle> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.App.Frontend.Pages.ProfesorDetalle>)PageContext?.ViewData;
        public Project.App.Frontend.Pages.ProfesorDetalle Model => ViewData.Model;
    }
}
#pragma warning restore 1591
