#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3452a31bbe4fe0a455e678fc1d1609ac2d1957ee4d45494875f96abe8def2cff"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3452a31bbe4fe0a455e678fc1d1609ac2d1957ee4d45494875f96abe8def2cff", @"/Views/Solution/UserSolutions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Solution_UserSolutions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrialFreelance.ViewModels.OrderSolutionViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <style>
        .item{
            width:90%;
            justify-content:center;
        background-color: #ebebf0;
        min-height: 60px;
        margin: 10px;
        }
        .name{
            height:50px;
            float:left;
        background-color: #d5d5de;
        border-radius:5px;
        padding:5px;
        }

    .link {
        float: left;
        background-color: #d5d5de;
        border-radius: 5px;
        padding: 5px;
        margin: 5px;
    }

    .mybtn{
        float: left;
        background-color: #d5d5de;
        border-radius: 5px;
        margin: 5px;
    }
    </style>

");
#nullable restore
#line 35 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
     if(@Model!=null)
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
     foreach(var sol in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"item\">\r\n            <div class=\"info name\">");
#nullable restore
#line 39 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                              Write(sol.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"info link\">");
#nullable restore
#line 40 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
                              Write(sol.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 41 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
             if (ViewBag.Role == "Admin")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mybtn\"><a");
            BeginWriteAttribute("href", " href=\"", 1016, "\"", 1053, 2);
            WriteAttributeValue("", 1023, "/Solution/EditSolution/", 1023, 23, true);
#nullable restore
#line 43 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 1046, sol.Id, 1046, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></div>\r\n                <div class=\"mybtn\"><a");
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1147, 2);
            WriteAttributeValue("", 1115, "/Solution/DeleteSolution/", 1115, 25, true);
#nullable restore
#line 44 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
WriteAttributeValue("", 1140, sol.Id, 1140, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></div>\r\n");
#nullable restore
#line 45 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 47 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Solution\UserSolutions.cshtml"
    }

#line default
#line hidden
#nullable disable
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