#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47c945a56047844e521077957f253e6f40750430600b7401de9579b7115048cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solution_UserSolutions), @"mvc.1.0.view", @"/Views/Solution/UserSolutions.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\_ViewImports.cshtml"
using TrialFreelance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\_ViewImports.cshtml"
using TrialFreelance.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"47c945a56047844e521077957f253e6f40750430600b7401de9579b7115048cd", @"/Views/Solution/UserSolutions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Solution_UserSolutions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrialFreelance.ViewModels.OrderSolutionViewModel>>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47c945a56047844e521077957f253e6f40750430600b7401de9579b7115048cd3395", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/solution_style.css\" type=\"text/css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"main_field\">\r\n");
#nullable restore
#line 7 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
     if (@Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <nav style=""--bs-breadcrumb-divider: url(&#34;data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='8' height='8'%3E%3Cpath d='M2.5 0L1 1.5 3.5 4 1 6.5 2.5 8l4-4-4-4z' fill='%236c757d'/%3E%3C/svg%3E&#34;);"" aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 613, 2);
            WriteAttributeValue("", 562, "/Account/ShowUser/", 562, 18, true);
#nullable restore
#line 11 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 580, Model.FirstOrDefault().CreatorId, 580, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">User</a></li>\r\n                <li class=\"breadcrumb-item active text-secondary\" aria-current=\"page\">Solution</li>\r\n            </ol>\r\n        </nav>\r\n        <div class=\"accordion\">\r\n\r\n");
#nullable restore
#line 17 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
             foreach (var sol in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"contentBx\">\r\n                    <div class=\"label\">");
#nullable restore
#line 20 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                                  Write(sol.CreatorUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 960, "\"", 982, 1);
#nullable restore
#line 20 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 967, sol.GitHubLink, 967, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                                                                                 Write(sol.GitHubLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                    <div class=\"content\">\r\n                        \r\n                        <p>");
#nullable restore
#line 23 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                      Write(sol.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <div class=\"d-flex flex-row-reverse\">\r\n");
#nullable restore
#line 26 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                             if (ViewBag.Role == "Admin")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 1346, "\"", 1385, 2);
            WriteAttributeValue("", 1353, "/Solution/DeleteSolution/", 1353, 25, true);
#nullable restore
#line 28 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 1378, sol.Id, 1378, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></div>\r\n                                <div class=\"btn btn-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 1468, "\"", 1505, 2);
            WriteAttributeValue("", 1475, "/Solution/EditSolution/", 1475, 23, true);
#nullable restore
#line 29 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 1498, sol.Id, 1498, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></div>\r\n");
#nullable restore
#line 32 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                      
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 37 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 39 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin: 50px;color: #FFF;\">\r\n            <h2> Ще не створено рішень </h2>\r\n        </div>\r\n");
#nullable restore
#line 45 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script src=\"/js/solution_script.js\"></script>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrialFreelance.ViewModels.OrderSolutionViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
