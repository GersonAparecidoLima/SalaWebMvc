#pragma checksum "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d0f0188b60689a8931ec929c3e42b41b1ea972f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "C:\dev\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\dev\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0f0188b60689a8931ec929c3e42b41b1ea972f", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e82a99d0f68a83eb80a8c42eea95417221ff4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";


#line default
#line hidden
            BeginContext(105, 108, true);
            WriteLiteral("\r\n<h2>Simple Search</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(213, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d0f0188b60689a8931ec929c3e42b41b1ea972f4559", async() => {
                BeginContext(265, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 480, "", 507, 1);
#line 16 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 487, ViewData["minDate"], 487, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(507, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 711, "", 738, 1);
#line 20 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 718, ViewData["maxDate"], 718, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(738, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(877, 136, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1014, 43, false);
#line 29 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1273, 38, false);
#line 36 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1391, 40, false);
#line 39 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1511, 42, false);
#line 42 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1633, 53, false);
#line 45 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1766, 42, false);
#line 48 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1888, 42, false);
#line 51 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 56 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2090, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2175, 37, false);
#line 60 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2304, 39, false);
#line 63 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2343, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2435, 46, false);
#line 66 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2573, 57, false);
#line 69 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2630, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2722, 41, false);
#line 72 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2763, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2855, 41, false);
#line 75 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2896, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 78 "C:\dev\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2975, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
