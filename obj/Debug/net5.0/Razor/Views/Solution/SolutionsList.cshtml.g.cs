#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3247d42b00f288780e3a2d2fc6455b7b61afc1c33f7c998220eb1468127c02d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solution_SolutionsList), @"mvc.1.0.view", @"/Views/Solution/SolutionsList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3247d42b00f288780e3a2d2fc6455b7b61afc1c33f7c998220eb1468127c02d0", @"/Views/Solution/SolutionsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Solution_SolutionsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrialFreelance.ViewModels.OrderSolutionViewModel>>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3247d42b00f288780e3a2d2fc6455b7b61afc1c33f7c998220eb1468127c02d03430", async() => {
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
#line 64 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
     if (@Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"accordion\">\r\n\r\n");
#nullable restore
#line 68 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
             foreach (var sol in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"contentBx\">\r\n                    <div class=\"label\">Order #");
#nullable restore
#line 71 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
                                         Write(sol.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 1681, "\"", 1703, 1);
#nullable restore
#line 71 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
WriteAttributeValue("", 1688, sol.GitHubLink, 1688, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:20px;\">");
#nullable restore
#line 71 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
                                                                                                    Write(sol.GitHubLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                    <div class=\"content\">\r\n                        <p>");
#nullable restore
#line 73 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
                      Write(sol.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <div class=\"d-flex flex-row-reverse\">\r\n");
#nullable restore
#line 76 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
                             if (ViewBag.Role == "Admin")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 2067, "\"", 2106, 2);
            WriteAttributeValue("", 2074, "/Solution/DeleteSolution/", 2074, 25, true);
#nullable restore
#line 78 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
WriteAttributeValue("", 2099, sol.Id, 2099, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></div>\r\n                                <div class=\"btn btn-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 2189, "\"", 2226, 2);
            WriteAttributeValue("", 2196, "/Solution/EditSolution/", 2196, 23, true);
#nullable restore
#line 79 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
WriteAttributeValue("", 2219, sol.Id, 2219, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></div>\r\n");
#nullable restore
#line 80 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 84 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 86 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
    }
    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin: 50px;color: #FFF;\">\r\n            <h2> Ще не створено рішень </h2>\r\n        </div>\r\n");
#nullable restore
#line 93 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\SolutionsList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script src=\"/js/solution_script.js\"></script>\r\n   </div>");
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
