#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f4929945b45c9c73bb4c3fa763e849c078d23e0810b61438ddb32e67bbf79292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solution_OrderSolutions), @"mvc.1.0.view", @"/Views/Solution/OrderSolutions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f4929945b45c9c73bb4c3fa763e849c078d23e0810b61438ddb32e67bbf79292", @"/Views/Solution/OrderSolutions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Solution_OrderSolutions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrialFreelance.ViewModels.OrderSolutionViewModel>>
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
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4929945b45c9c73bb4c3fa763e849c078d23e0810b61438ddb32e67bbf792923397", async() => {
                WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/css/solution_style.css\" type=\"text/css\" />\r\n");
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
#line 79 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
     if (@Model.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <nav style=""--bs-breadcrumb-divider: url(&#34;data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='8' height='8'%3E%3Cpath d='M2.5 0L1 1.5 3.5 4 1 6.5 2.5 8l4-4-4-4z' fill='%236c757d'/%3E%3C/svg%3E&#34;);"" aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 2813, "\"", 2864, 2);
            WriteAttributeValue("", 2820, "/Order/Order/", 2820, 13, true);
#nullable restore
#line 83 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
WriteAttributeValue("", 2833, Model.FirstOrDefault().OrderId, 2833, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Order</a></li>\r\n            <li class=\"breadcrumb-item active text-secondary\" aria-current=\"page\">Solution</li>\r\n        </ol>\r\n    </nav>\r\n        <div class=\"accordion\">\r\n\r\n");
#nullable restore
#line 89 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
             foreach (var sol in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"contentBx\">\r\n                    <div class=\"label\">");
#nullable restore
#line 92 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
                                  Write(sol.CreatorUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 3200, "\"", 3222, 1);
#nullable restore
#line 92 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
WriteAttributeValue("", 3207, sol.GitHubLink, 3207, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
                                                                                 Write(sol.GitHubLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                    <div class=\"content\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3320, "\"", 3359, 2);
            WriteAttributeValue("", 3327, "/Account/ShowUser/", 3327, 18, true);
#nullable restore
#line 94 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
WriteAttributeValue("", 3345, sol.CreatorId, 3345, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link link-light nav_user
            link-underline-opacity-0
            link-opacity-75-hover d-flex"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""50"" height=""30"" fill=""currentColor"" class=""bi bi-person-circle"" viewBox=""0 0 16 16"">
                                <path d=""M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0"" />
                                <path fill-rule=""evenodd"" d=""M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8m8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1"" />
                            </svg>

                            <span style=""padding-top:3px;""> Show User</span>
                        </a>
                        <p>");
#nullable restore
#line 104 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
                      Write(sol.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <div class=\"d-flex flex-row-reverse\">\r\n");
#nullable restore
#line 107 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
                             if (ViewBag.Role == "Admin")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 4323, "\"", 4362, 2);
            WriteAttributeValue("", 4330, "/Solution/DeleteSolution/", 4330, 25, true);
#nullable restore
#line 109 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
WriteAttributeValue("", 4355, sol.Id, 4355, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></div>\r\n                                <div class=\"btn btn-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 4445, "\"", 4482, 2);
            WriteAttributeValue("", 4452, "/Solution/EditSolution/", 4452, 23, true);
#nullable restore
#line 110 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
WriteAttributeValue("", 4475, sol.Id, 4475, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></div>\r\n");
#nullable restore
#line 113 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
                                  
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 118 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 120 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin: 50px;color: #FFF;\">\r\n            <h2> Ще не створено рішень </h2>\r\n        </div>\r\n");
#nullable restore
#line 126 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\OrderSolutions.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script src=""/js/solution_script.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"" crossorigin=""anonymous""></script>
</div>");
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
