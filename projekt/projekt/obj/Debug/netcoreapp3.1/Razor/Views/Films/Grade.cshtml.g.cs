#pragma checksum "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bce8879b61edbf960c8f362d3f02b680d4f74faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Grade), @"mvc.1.0.view", @"/Views/Films/Grade.cshtml")]
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
#line 1 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\_ViewImports.cshtml"
using projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\_ViewImports.cshtml"
using projekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bce8879b61edbf960c8f362d3f02b680d4f74faf", @"/Views/Films/Grade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85914c407437a76cfa0277c702fd3232aa39db82", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Grade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projekt.Models.Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Grade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h3>Ocena z filmu: ");
#nullable restore
#line 2 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
              Write(ViewBag.group.Tytul);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce8879b61edbf960c8f362d3f02b680d4f74faf3767", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"cid\"");
                BeginWriteAttribute("value", " value=\"", 136, "\"", 162, 1);
#nullable restore
#line 4 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
WriteAttributeValue("", 144, ViewBag.course.Id, 144, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"gid\"");
                BeginWriteAttribute("value", " value=\"", 203, "\"", 228, 1);
#nullable restore
#line 5 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
WriteAttributeValue("", 211, ViewBag.group.Id, 211, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <table class=\"table\">\r\n");
#nullable restore
#line 7 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
         foreach (var s in ViewBag.grades)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>  ");
#nullable restore
#line 10 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
                 Write(s.ImieNazwisko);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><input");
                BeginWriteAttribute("name", " name=\"", 404, "\"", 421, 1);
#nullable restore
#line 11 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
WriteAttributeValue("", 411, s.AktorId, 411, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 443, "\"", 459, 1);
#nullable restore
#line 11 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
WriteAttributeValue("", 451, s.Ocena, 451, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            </tr>\r\n");
#nullable restore
#line 13 "C:\Users\Arek Wojtyna\source\repos\projekt\projekt\Views\Films\Grade.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <input type=\"submit\" value=\"Zapisz\" class=\"btn btn-dark\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projekt.Models.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
