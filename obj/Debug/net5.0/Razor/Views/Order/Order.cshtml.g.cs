#pragma checksum "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02ae20d0ed3e2151089c97ba9bc224db0dffda6d391e6785fd3646cdd8268cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
#line 1 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\_ViewImports.cshtml"
using TrialFreelance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\_ViewImports.cshtml"
using TrialFreelance.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
using TrialFreelance.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"02ae20d0ed3e2151089c97ba9bc224db0dffda6d391e6785fd3646cdd8268cf6", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ae20d0ed3e2151089c97ba9bc224db0dffda6d391e6785fd3646cdd8268cf63383", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/order_page_style.css\" />\r\n");
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
            WriteLiteral("\r\n    <div class=\"main_field\">\r\n        <div style=\"display: flex; flex-direction: row;\">\r\n            <div class=\"order_left\">\r\n                <p class=\"data\">11-12-2023</p>\r\n            <div style=\"color:#fff\">");
#nullable restore
#line 181 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
                                Write((Statuses)Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <h1 class=\"title\">");
#nullable restore
#line 182 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h2 class=\"user\">\r\n                <span class=\"user_help\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 6142, "\"", 6183, 2);
            WriteAttributeValue("", 6149, "/Account/ShowUser/", 6149, 18, true);
#nullable restore
#line 185 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 6167, Model.CreatorId, 6167, 16, false);

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

                        <span style=""padding-top:3px;""> Show Owner</span>
                    </a>
                </span>
            </h2>
            </div>
            <div class=""order_right"">
            <div");
            BeginWriteAttribute("class", " class=\"", 6977, "\"", 7033, 2);
            WriteAttributeValue("", 6985, "text_difficalty_", 6985, 16, true);
#nullable restore
#line 199 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 7001, (Difficuties)Model.Difficulty, 7001, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 199 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
                                                                      Write((Difficuties)Model.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        <div class=\"divider\"></div>\r\n        <div class=\"description\">\r\n            <span class=\"description_header\">Description:</span>\r\n        ");
#nullable restore
#line 205 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n        </div>\r\n        <div class=\"main_task\">\r\n            <div class=\"main_task_header\">\r\n                Main tasks:\r\n            </div>\r\n            <div class=\"main_task_content\">\r\n                ");
#nullable restore
#line 212 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
           Write(Model.MainTask);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"secondary_task\">\r\n            <div class=\"secondary_task_header\">\r\n                Secondary tasks:\r\n            </div>\r\n            <div class=\"secondary_task_content\">\r\n            ");
#nullable restore
#line 220 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
       Write(Model.SecondaryTasks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""divider"" style=""margin-top:30px""></div>
        <div class=""link_block"">
            <h1 class=""link_header"">
                Links:
            </h1>
            <div class=""link_content"">
                <div class=""link"">
                    <span class=""link_type"">Git Hub: </span>
                <a");
            BeginWriteAttribute("href", " href=\"", 8130, "\"", 8154, 1);
#nullable restore
#line 231 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 8137, Model.GitHubLink, 8137, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 231 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
                                       Write(Model.GitHubLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"link\">\r\n                    <span class=\"link_type\">Reference: </span>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 8321, "\"", 8346, 1);
#nullable restore
#line 235 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 8328, Model.ExampleLink, 8328, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 235 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
                                        Write(Model.ExampleLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"link\">\r\n                    <span class=\"link_type\">Data Base: </span>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 8514, "\"", 8534, 1);
#nullable restore
#line 239 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 8521, Model.DbLink, 8521, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 240 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
               Write(Model.DbLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n            </div>\r\n            <div class=\"divider\" style=\"margin-top:30px\"></div>\r\n            <div class=\"btn_group\">\r\n                <a type=\"button\" class=\"btn btn-success btn_add\"");
            BeginWriteAttribute("href", " href=\'", 8809, "\'", 8850, 2);
            WriteAttributeValue("", 8816, "/Solution/CreateSolution/", 8816, 25, true);
#nullable restore
#line 246 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 8841, Model.Id, 8841, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add solution</a>\r\n            <a type=\"button\" class=\"btn btn-outline-primary btn_view\"");
            BeginWriteAttribute("href", " href=\'", 8939, "\'", 8980, 2);
            WriteAttributeValue("", 8946, "/Solution/OrderSolutions/", 8946, 25, true);
#nullable restore
#line 247 "C:\Users\dariy\Documents\GitHub\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 8971, Model.Id, 8971, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View existed solution</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
