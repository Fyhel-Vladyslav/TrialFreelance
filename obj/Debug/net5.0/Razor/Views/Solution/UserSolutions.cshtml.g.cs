#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50e20f14c607202ed54056630d4eff0c065ff23eb26e93fdf8f0ed3865819361"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"50e20f14c607202ed54056630d4eff0c065ff23eb26e93fdf8f0ed3865819361", @"/Views/Solution/UserSolutions.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50e20f14c607202ed54056630d4eff0c065ff23eb26e93fdf8f0ed38658193613395", async() => {
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
#line 61 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
     if (@Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"accordion\">\r\n\r\n");
#nullable restore
#line 65 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
             foreach (var sol in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"contentBx\">\r\n                    <div class=\"label\">Order #");
#nullable restore
#line 68 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                                         Write(sol.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 1658, "\"", 1680, 1);
#nullable restore
#line 68 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 1665, sol.GitHubLink, 1665, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                                                                          Write(sol.GitHubLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                    <div class=\"content\">\r\n                        <p>");
#nullable restore
#line 70 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                      Write(sol.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <div class=\"d-flex flex-row-reverse\">\r\n");
#nullable restore
#line 73 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                             if (ViewBag.Role == "Admin")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 2018, "\"", 2057, 2);
            WriteAttributeValue("", 2025, "/Solution/DeleteSolution/", 2025, 25, true);
#nullable restore
#line 75 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 2050, sol.Id, 2050, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></div>\r\n                                <div class=\"btn btn-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 2140, "\"", 2177, 2);
            WriteAttributeValue("", 2147, "/Solution/EditSolution/", 2147, 23, true);
#nullable restore
#line 76 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 2170, sol.Id, 2170, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></div>\r\n");
#nullable restore
#line 79 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                      
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 84 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 86 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
    }
    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"contentBx\">\r\n            <h2> Ще не створено рішень </h2>\r\n        </div>\r\n");
#nullable restore
#line 93 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
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
