#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67c5ed58e3d53fdcc8f8985a72c96f34617a5eed907d0676b71573c8f520ed2f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"67c5ed58e3d53fdcc8f8985a72c96f34617a5eed907d0676b71573c8f520ed2f", @"/Views/Message/UserMessages.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67c5ed58e3d53fdcc8f8985a72c96f34617a5eed907d0676b71573c8f520ed2f3967", async() => {
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
 if (@Model != null)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"main_field\">\r\n        <h1 class=\"title\">My messages</h1>\r\n        <div class=\"mail_field\">\r\n            <div class=\"btn-group bar_btn_group\" role=\"group\" aria-label=\"Basic example\">\r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1558, "\"", 1613, 4);
            WriteAttributeValue("", 1568, "setRead(", 1568, 8, true);
#nullable restore
#line 40 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 1576, Model.FirstOrDefault().UserId, 1576, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1606, ",", 1606, 1, true);
            WriteAttributeValue(" ", 1607, "true)", 1608, 6, true);
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
#line 50 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                 foreach (var mes in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""accordion-item unread_message"">
                        <h2 class=""accordion-header"">
                            <button class=""accordion-button collapsed message"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#flush-collapse_");
#nullable restore
#line 55 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                                                                                                                                  Write(mes.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\">\r\n                                <div class=\"form-check\">\r\n");
#nullable restore
#line 57 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                     if (mes.isRead)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input name=\"cb_message\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3060, "\"", 3088, 3);
            WriteAttributeValue("", 3070, "setRead(\'", 3070, 9, true);
#nullable restore
#line 59 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 3079, mes.Id, 3079, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3086, "\')", 3086, 2, true);
            EndWriteAttribute();
            WriteLiteral(" checked disabled class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 3147, "\"", 3155, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3156, "\"", 3179, 2);
            WriteAttributeValue("", 3161, "message_ch_", 3161, 11, true);
#nullable restore
#line 59 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 3172, mes.Id, 3172, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 60 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input name=\"cb_message\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3369, "\"", 3395, 3);
            WriteAttributeValue("", 3379, "setRead(", 3379, 8, true);
#nullable restore
#line 64 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 3387, mes.Id, 3387, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3394, ")", 3394, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 3437, "\"", 3445, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3446, "\"", 3469, 2);
            WriteAttributeValue("", 3451, "message_ch_", 3451, 11, true);
#nullable restore
#line 64 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 3462, mes.Id, 3462, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 65 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <span class=\"message_header\">\r\n                                    ");
#nullable restore
#line 68 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                Write((MessageTypes)mes.MesType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                                <span style=\"font-size: 16px; margin-left: 30px\">\r\n                                    ");
#nullable restore
#line 71 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                               Write(mes.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n");
#nullable restore
#line 73 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                 if (ViewBag.Role == "Admin")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"btn btn-edit_btn\"><a");
            BeginWriteAttribute("href", " href=\"", 4063, "\"", 4098, 2);
            WriteAttributeValue("", 4070, "/Message/EditMessage/", 4070, 21, true);
#nullable restore
#line 75 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 4091, mes.Id, 4091, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></div>\r\n                                    <div class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 4182, "\"", 4219, 2);
            WriteAttributeValue("", 4189, "/Message/DeleteMessage/", 4189, 23, true);
#nullable restore
#line 76 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 4212, mes.Id, 4212, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></div>\r\n");
#nullable restore
#line 77 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </button>\r\n                        </h2>\r\n                        <div");
            BeginWriteAttribute("id", " id=\"", 4372, "\"", 4399, 2);
            WriteAttributeValue("", 4377, "flush-collapse_", 4377, 15, true);
#nullable restore
#line 80 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 4392, mes.Id, 4392, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\"\r\n                             data-bs-parent=\"#accordionFlushExample\">\r\n                            <div class=\"accordion-body\">\r\n                                <div>\r\n                                    ");
#nullable restore
#line 84 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                               Write(mes.MesText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 86 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                 if(mes.MesType==(int)MessageTypes.Solution)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div type=\"button\" class=\"btn btn-primary message_btn\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4944, "\"", 4985, 2);
            WriteAttributeValue("", 4951, "/Solution/Solution/", 4951, 19, true);
#nullable restore
#line 89 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
WriteAttributeValue("", 4970, mes.SolutionId, 4970, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Go to solution</a>\r\n                                    </div>\r\n");
#nullable restore
#line 91 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 96 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 101 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>У вас немає не прочитаних повідомлень</div>\r\n");
#nullable restore
#line 106 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Message\UserMessages.cshtml"
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
    </script>

<script src=""/js/message_script.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-C6RzsynM9kWD");
            WriteLiteral("rMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL\"\r\n        crossorigin=\"anonymous\"></script>\r\n");
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
