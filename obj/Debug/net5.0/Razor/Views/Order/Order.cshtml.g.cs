#pragma checksum "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\Order.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8fc3d28c1750895d05b915de08f81513f824447c958a03f48109aa72b257e685"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8fc3d28c1750895d05b915de08f81513f824447c958a03f48109aa72b257e685", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4069638207df95acf2013375bad3aafab8498f0b9e022ba1e407b8c5f518be52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderSolutions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Solution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSolution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fc3d28c1750895d05b915de08f81513f824447c958a03f48109aa72b257e6854603", async() => {
                WriteLiteral(@"
<style>
    body {
        font-family: 'Montserrat', sans-serif;
        font-size: 15px;
        color: #333;
    }

    *,
    *before,
    *after {
        box-sizing: border-box;
    }

    h1, h2, h3, h4, h5, h6 {
        margin: 0;
    }

    .navbar {
        position: fixed;
        top: 0;
        left: 0;
        width: 100%;
        background-color: #333;
        color: #fff;
        padding: 10px 0;
        text-align: right;
    }

    /* Стилі для замовлень */
    .orders {
        padding: 50px;
    }

    /* Стилі для кнопок в навігаційній панелі */
    .navbar button {
        background-color: #333;
        color: #fff;
        border: none;
        padding: 10px 20px;
        margin: 10px;
        cursor: pointer;
    }

        /* Змінюємо фон кнопок при наведенні курсору */
        .navbar button:hover {
            background-color: #555;
        }

    .order-info {
        border: 1px solid #ccc;
        padding: 20px;
        marg");
                WriteLiteral(@"in: 20px;
        background-color: #f7f7f7;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        width: 50%;
        float: left;
    }

    .order-title {
        font-size: 24px;
        margin: 0;
        color: #333;
    }

    .order-description {
        margin-top: 10px;
    }

    .order-details {
        margin-top: 20px;
    }

        .order-details ul {
            list-style: none;
            padding: 0;
        }

            .order-details ul li {
                margin-bottom: 10px;
                color: #555;
            }

    .gallery {
        float: left;
        width: 40%;
        padding-top: 70px;
    }

    .red {
        background-color: red;
        font-size: 20px;
        font-weight: 600;
    }

    .org {
        background-color: orange;
        font-size: 20px;
        font-weight: 600;
    }

    .grn {
        background-color: lightgreen;
        font-size: 20px;
        font-weight: 600;
    }
</style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fc3d28c1750895d05b915de08f81513f824447c958a03f48109aa72b257e6857667", async() => {
                WriteLiteral(@"
    <div class=""navbar"">
        <button id=""btn1"">Обрати замовлення</button>
        <button id=""btn2"">Створити замовлення</button>
        <button id=""btn3"">Авторизація</button>
    </div>
    <div class=""order-info"">
        <h1 class=""order-title"">Замовник: </h1>
        <p>Рейтинг відгуків фрілансерів: 3.3</p>
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""150"" height=""150"" fill=""currentColor"" class=""bi bi-person-square"" viewBox=""0 0 16 16"">
            <path d=""M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"" />
            <path d=""M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2zm12 1a1 1 0 0 1 1 1v12a1 1 0 0 1-1 1v-1c0-1-1-4-6-4s-6 3-6 4v1a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h12z"" />
        </svg>


        <p style=""width: 200px;"" class=""red"">Складність: ");
#nullable restore
#line 125 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\Order.cshtml"
                                                    Write(Model.Difficulty);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <div class=\"order-description\">\r\n            <h2>Назва замовлення: ");
#nullable restore
#line 128 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\Order.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 129 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\Order.cshtml"
          Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
        </div>

        <div class=""order-details"">
            <h2>Деталі замовлення</h2>
            <ul>
                <li>База даних: Присутня</li>
                <li>Дизайн: Відсутня</li>
                <li>Дедлайн: вчора</li>
                <li>Інше: ");
#nullable restore
#line 138 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\Order.cshtml"
                     Write(Model.SecondaryTasks);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
            </ul>
            <h2>Контакти замовника</h2>
            <ul>
                <li>Телефон: 067-567+68-78=0</li>
                <li>email: tu@sytyla</li>
                <li>Telegram: t/me/Valadij</li>
            </ul>
        </div>
    </div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fc3d28c1750895d05b915de08f81513f824447c958a03f48109aa72b257e68510505", async() => {
                    WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 3721, "\"", 3738, 1);
#nullable restore
#line 149 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 3729, Model.Id, 3729, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n        <button type=\"submit\" style=\"width:80%;\">Переглянути всі рішення цього замовлення </button>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div> <h2>Запропонувати рішення замовлення</h2>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fc3d28c1750895d05b915de08f81513f824447c958a03f48109aa72b257e68512872", async() => {
                    WriteLiteral("\r\n            <input type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 4013, "\"", 4030, 1);
#nullable restore
#line 154 "D:\vodnik\3 курс\Командна розробка\TrialFreelance\TrialFreelance\Views\Order\Order.cshtml"
WriteAttributeValue("", 4021, Model.Id, 4021, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" name=""orderId"" />
            <div class=""mb-3"">
                <input type=""text"" placeholder=""Посилання на github рішення"" name=""githubLink"" class=""form-control"" />
                <span id=""formDescError"" class=""text-danger""></span>
            </div>
            <div class=""mb-3"">
                <input type=""text"" placeholder=""Додайте опис"" name=""description"" class=""form-control"" />
                <span id=""formDescError""class=""text-danger""></span>
            </div>
<button type=""submit"">Подати рішення</button>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>

    <div class=""gallery"">
        <h3>Галерея:</h3>
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""500"" height=""500"" fill=""currentColor"" class=""bi bi-card-image"" viewBox=""0 0 16 16""> <path d=""M6.002 5.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0z"" /> <path d=""M1.5 2A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h13a1.5 1.5 0 0 0 1.5-1.5v-9A1.5 1.5 0 0 0 14.5 2h-13zm13 1a.5.5 0 0 1 .5.5v6l-3.775-1.947a.5.5 0 0 0-.577.093l-3.71 3.71-2.66-1.772a.5.5 0 0 0-.63.062L1.002 12v.54A.505.505 0 0 1 1 12.5v-9a.5.5 0 0 1 .5-.5h13z"" /> </svg>
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""500"" height=""500"" fill=""currentColor"" class=""bi bi-card-image"" viewBox=""0 0 16 16""> <path d=""M6.002 5.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0z"" /> <path d=""M1.5 2A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h13a1.5 1.5 0 0 0 1.5-1.5v-9A1.5 1.5 0 0 0 14.5 2h-13zm13 1a.5.5 0 0 1 .5.5v6l-3.775-1.947a.5.5 0 0 0-.577.093l-3.71 3.71-2.66-1.772a.5.5 0 0 0-.63.062L1.002 12v.54A.505.505 0 0 1 1 12.5v-9a.5.5 0 0 1 .5-.5h13z"" /> ");
                WriteLiteral("</svg>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
