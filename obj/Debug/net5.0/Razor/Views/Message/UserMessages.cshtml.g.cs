#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a1ad43442915353b66b63d62be2f37e447fecd587a0d20f02ace0e8bf96b6274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_UserMessages), @"mvc.1.0.view", @"/Views/Message/UserMessages.cshtml")]
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
#line 1 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
using TrialFreelance.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
using TrialFreelance.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a1ad43442915353b66b63d62be2f37e447fecd587a0d20f02ace0e8bf96b6274", @"/Views/Message/UserMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_UserMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessageViewModel>>
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
#nullable restore
#line 4 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ad43442915353b66b63d62be2f37e447fecd587a0d20f02ace0e8bf96b62743967", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/message_style.css\" />\r\n");
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
 if (@Model.Any())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"main_field\">\r\n        <h1 class=\"title\">My messages</h1>\r\n        <div class=\"mail_field\">\r\n            <div class=\"btn-group bar_btn_group\" role=\"group\" aria-label=\"Basic example\">\r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 489, "\"", 544, 4);
            WriteAttributeValue("", 499, "setRead(", 499, 8, true);
#nullable restore
#line 18 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 507, Model.FirstOrDefault().UserId, 507, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 537, ",", 537, 1, true);
            WriteAttributeValue(" ", 538, "true)", 539, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary bar_btn"">Set Read All
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor""
                         class=""bi bi-envelope-open"" viewBox=""0 0 16 16"">
                        <path d=""M8.47 1.318a1 1 0 0 0-.94 0l-6 3.2A1 1 0 0 0 1 5.4v.817l5.75 3.45L8 8.917l1.25.75L15 6.217V5.4a1 1 0 0 0-.53-.882l-6-3.2ZM15 7.383l-4.778 2.867L15 13.117zm-.035 6.88L8 10.082l-6.965 4.18A1 1 0 0 0 2 15h12a1 1 0 0 0 .965-.738ZM1 13.116l4.778-2.867L1 7.383v5.734ZM7.059.435a2 2 0 0 1 1.882 0l6 3.2A2 2 0 0 1 16 5.4V14a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V5.4a2 2 0 0 1 1.059-1.765l6-3.2"" />
                    </svg>
                </button>
            </div>
            <div class=""divider""></div>
            <div class=""accordion accordion-flush"" data-bs-theme=""dark"" id=""accordionFlushExample"">

");
#nullable restore
#line 28 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                 foreach (var mes in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""accordion-item unread_message"">
                        <h2 class=""accordion-header"">
                            <button class=""accordion-button collapsed message"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#flush-collapse_");
#nullable restore
#line 33 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                                                                                                                                  Write(mes.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\">\r\n                                <div class=\"form-check\">\r\n");
#nullable restore
#line 35 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                     if (mes.isRead)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input name=\"cb_message\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1991, "\"", 2019, 3);
            WriteAttributeValue("", 2001, "setRead(\'", 2001, 9, true);
#nullable restore
#line 37 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 2010, mes.Id, 2010, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2017, "\')", 2017, 2, true);
            EndWriteAttribute();
            WriteLiteral(" checked disabled class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2078, "\"", 2086, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2087, "\"", 2110, 2);
            WriteAttributeValue("", 2092, "message_ch_", 2092, 11, true);
#nullable restore
#line 37 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 2103, mes.Id, 2103, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 38 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input name=\"cb_message\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2300, "\"", 2326, 3);
            WriteAttributeValue("", 2310, "setRead(", 2310, 8, true);
#nullable restore
#line 42 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 2318, mes.Id, 2318, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2325, ")", 2325, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2368, "\"", 2376, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2377, "\"", 2400, 2);
            WriteAttributeValue("", 2382, "message_ch_", 2382, 11, true);
#nullable restore
#line 42 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 2393, mes.Id, 2393, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 43 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <span class=\"message_header\">\r\n                                    ");
#nullable restore
#line 46 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                Write((MessageTypes)mes.MesType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                                <span style=\"font-size: 16px; margin-left: 30px\">\r\n                                    ");
#nullable restore
#line 49 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                               Write(mes.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </button>\r\n                        </h2>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 2926, "\"", 2953, 2);
            WriteAttributeValue("", 2931, "flush-collapse_", 2931, 15, true);
#nullable restore
#line 53 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 2946, mes.Id, 2946, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\"\r\n                             data-bs-parent=\"#accordionFlushExample\">\r\n                            <div class=\"accordion-body\">\r\n                                <div>\r\n                                    ");
#nullable restore
#line 57 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                               Write(mes.MesText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 59 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                 if(mes.MesType==(int)MessageTypes.Solution)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div type=\"button\" class=\"btn btn-primary message_btn\" style=\"font-weight: 900;\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3524, "\"", 3565, 2);
            WriteAttributeValue("", 3531, "/Solution/Solution/", 3531, 19, true);
#nullable restore
#line 62 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 3550, mes.SolutionId, 3550, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Go to solution</a>\r\n                                    </div>\r\n");
#nullable restore
#line 64 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                 if (ViewBag.Role == "Admin")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div type=\"button\" class=\"btn btn-edit_btn\"><a");
            BeginWriteAttribute("href", " href=\"", 3846, "\"", 3881, 2);
            WriteAttributeValue("", 3853, "/Message/EditMessage/", 3853, 21, true);
#nullable restore
#line 67 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 3874, mes.Id, 3874, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></div>\r\n                                    <div type=\"button\" class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 3979, "\"", 4016, 2);
            WriteAttributeValue("", 3986, "/Message/DeleteMessage/", 3986, 23, true);
#nullable restore
#line 68 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 4009, mes.Id, 4009, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> </div>\r\n");
#nullable restore
#line 69 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 74 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 79 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"margin: 50px;color: #FFF;\">\r\n        <h2> У вас немає не прочитаних повідомлень</h2>\r\n    </div>\r\n");
#nullable restore
#line 86 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function setRead(Id, SetAllRead=false) {
        
        if (!SetAllRead)
            document.getElementById('message_ch_' + Id).disabled = true;
        fetch('/Message/SetMessageRead', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                id: Id,
                setAllRead: SetAllRead,
            }),
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                // Handle success, if needed
            })
            .catch(error => {
                console.error('There was a problem with the fetch operation:', error);
            });
    }
    function redirect(id) {
        window.location.href = (""/Solution/Order/"" + id);
    }
    </script>

<script src=""/js/message_script.js""></script>
<script src=""https://cdn.jsdelivr.n");
            WriteLiteral("et/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL\"\r\n        crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessageViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
