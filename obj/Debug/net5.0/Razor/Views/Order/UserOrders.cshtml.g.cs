#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ee2ee03444053115e3363453c0a6d97526eb83ee1cabd0cb2b78bdf326ea69c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_UserOrders), @"mvc.1.0.view", @"/Views/Order/UserOrders.cshtml")]
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
#nullable restore
#line 1 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
using TrialFreelance.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
using TrialFreelance.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ee2ee03444053115e3363453c0a6d97526eb83ee1cabd0cb2b78bdf326ea69c0", @"/Views/Order/UserOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_UserOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PreOrderViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/css/order_style.css\" type=\"text/css\" />\r\n\r\n<div class=\"orders\" style=\"margin-top:75px\" id=\"orderCards\">\r\n");
#nullable restore
#line 8 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
     if(Model!= null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
         foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"order_card\">\r\n        <div class=\"card_left\">\r\n                <h1 class=\"card_header\">");
#nullable restore
#line 14 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                \r\n            <div class=\"card_description\">\r\n            ");
#nullable restore
#line 17 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
       Write(item.MainTask);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            </div>\r\n                <div class=\"card_helper\">\r\n                    <p>Posted ");
#nullable restore
#line 20 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                         Write(item.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div style=\"display: flex; flex-direction: row; margin-left: 50px;\">\r\n");
#nullable restore
#line 22 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                         if (string.IsNullOrEmpty(item.DbLink))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <svg xmlns=""http://www.w3.org/2000/svg"" style=""margin-top: 3px"" width=""18"" height=""18"" fill=""darkred"" class=""bi bi-plus-square-fill"" viewBox=""0 0 16 16"">

                                <path d=""M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm2.5 7.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1 0-1"" />}
                            </svg>
");
#nullable restore
#line 28 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <svg xmlns=""http://www.w3.org/2000/svg"" style=""margin-top: 3px"" width=""18"" height=""18"" fill=""forestgreen"" class=""bi bi-plus-square-fill"" viewBox=""0 0 16 16"">
                                <path d=""M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm6.5 4.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3a.5.5 0 0 1 1 0"" />}
                            </svg>
");
#nullable restore
#line 34 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-weight: bold; margin-left: 5px;\">Data Base</p>\r\n                    </div>\r\n                    <div style=\"display: flex; flex-direction: row; margin-left: 20px;\">\r\n");
#nullable restore
#line 38 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                         if (string.IsNullOrEmpty(item.ExampleLink))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <svg xmlns=""http://www.w3.org/2000/svg"" style=""margin-top: 3px"" width=""18"" height=""18"" fill=""darkred"" class=""bi bi-plus-square-fill"" viewBox=""0 0 16 16"">

                                <path d=""M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm2.5 7.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1 0-1"" />}
                            </svg>
");
#nullable restore
#line 44 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <svg xmlns=""http://www.w3.org/2000/svg"" style=""margin-top: 3px"" width=""18"" height=""18"" fill=""forestgreen"" class=""bi bi-plus-square-fill"" viewBox=""0 0 16 16"">
                                <path d=""M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zm6.5 4.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3a.5.5 0 0 1 1 0"" />}
                            </svg>
");
#nullable restore
#line 50 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-weight: bold; margin-left: 5px;\">Reference</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 54 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                 if (ViewBag.Role == "Admin")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee2ee03444053115e3363453c0a6d97526eb83ee1cabd0cb2b78bdf326ea69c010842", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee2ee03444053115e3363453c0a6d97526eb83ee1cabd0cb2b78bdf326ea69c013165", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"card_right\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 3479, "\"", 3534, 2);
            WriteAttributeValue("", 3487, "text_difficalty_", 3487, 16, true);
#nullable restore
#line 61 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
WriteAttributeValue("", 3503, (Difficuties)item.Difficulty, 3503, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
                                                                         Write((Difficuties)item.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3612, "\"", 3640, 3);
            WriteAttributeValue("", 3622, "redirect(", 3622, 9, true);
#nullable restore
#line 62 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
WriteAttributeValue("", 3631, item.Id, 3631, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3639, ")", 3639, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary card_btn\">View</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 65 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
     

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"order_card \">\r\n        <div class=\"card-header\"> Ще не створено замовлень </div>\r\n    </div>\r\n");
#nullable restore
#line 73 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\UserOrders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>
    function redirect(id) {
        console.log(id);
        window.location.href = (""/Order/Order/"" + id);
    }
</script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL""
        crossorigin=""anonymous""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PreOrderViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591