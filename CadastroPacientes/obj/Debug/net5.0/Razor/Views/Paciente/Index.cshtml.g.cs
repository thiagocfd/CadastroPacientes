#pragma checksum "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7394dbf320c537459cf392de1177c3f0ac497d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paciente_Index), @"mvc.1.0.view", @"/Views/Paciente/Index.cshtml")]
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
#line 1 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\_ViewImports.cshtml"
using CadastroPacientes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\_ViewImports.cshtml"
using CadastroPacientes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7394dbf320c537459cf392de1177c3f0ac497d7", @"/Views/Paciente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846f684eff9a312629e0756589e1abc9fb2f6b9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Paciente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<CadastroPacientes.Models.Paciente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7394dbf320c537459cf392de1177c3f0ac497d74559", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
  
    ViewBag.Title = "Pacientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Pacientes</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
 using (Html.BeginForm("Index", "Paciente", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Find by name: ");
#nullable restore
#line 19 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
                 Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
#nullable restore
#line 22 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
           Write(Html.ActionLink("Nome", "Index", new { sortOrder = ViewBag.NomeParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Telefone\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
           Write(Html.ActionLink("Modalidade", "Index", new { sortOrder = ViewBag.ModalidadeParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
           Write(Html.ActionLink("Diagnostico", "Index", new { sortOrder = ViewBag.DiagnosticoParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Modalidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Diagnostico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.PacienteID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 64 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.PacienteID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 65 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.PacienteID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br />\r\nPage ");
#nullable restore
#line 73 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
 Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 73 "C:\Users\Thiago Dourado\Documents\TI\Projetos\CadastroPacientes\CadastroPacientes\CadastroPacientes\Views\Paciente\Index.cshtml"
                                                                Write(Model.PageCount);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<CadastroPacientes.Models.Paciente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
