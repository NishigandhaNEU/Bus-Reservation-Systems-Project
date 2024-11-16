#pragma checksum "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a81f10547cf55edca8c64f4d551b112ac3ff7541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetByName), @"mvc.1.0.view", @"/Views/Customer/GetByName.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\_ViewImports.cshtml"
using BusReservationSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\_ViewImports.cshtml"
using BusReservationSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81f10547cf55edca8c64f4d551b112ac3ff7541", @"/Views/Customer/GetByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2923367cda10cd6b7a4f6ff87767cdb3d65446ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bus.DomainModels.Trip>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;margin-right:20px;margin-top:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
  
    ViewBag.Title = "GetByName";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center\"> Journey Details</h2>\r\n\r\n    <div class=\"container table-bordered\" style=\" border-color: black; margin-top: 30px;\">\r\n\r\n        <table class=\"table\">\r\n\r\n            <tr style=\"text-align:center\">\r\n");
            WriteLiteral("                <th> Bus Name </th>\r\n                <th> Available Seats </th>\r\n                <th> To Location </th>\r\n                <th> Journey Date </th>\r\n                <th> Price </th>\r\n\r\n            </tr>\r\n\r\n");
#nullable restore
#line 22 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("\r\n                    <td style=\"text-align:center\">\r\n                        <h4 style=\"color:darkblue\"> ");
#nullable restore
#line 28 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
                                               Write(Html.DisplayFor(m => item.Bus.BusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        ");
#nullable restore
#line 29 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
                   Write(Html.DisplayFor(m => item.Bus.BusCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td style=\"text-align:center\"> ");
#nullable restore
#line 32 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
                                              Write(Html.DisplayFor(m => item.AvailableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td style=\"text-align:center\"> ");
#nullable restore
#line 34 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
                                              Write(Html.DisplayFor(m => item.Route.ToLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td style=\"text-align:center\">");
#nullable restore
#line 36 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
                                             Write(Html.DisplayFor(m => item.JourneyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td style=\"text-align:center\">\r\n                        <h4 style=\"color:darkred\">");
#nullable restore
#line 39 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
                                             Write(string.Format("{0:C}", item.Route.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        ");
#nullable restore
#line 40 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"
                   Write(Html.ActionLink("View Seats", "ViewSeats", "Customer", new { id = item.RouteId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 44 "E:\DotNetBatchJan2021\BusReservationSystem\BusReservationSystem\Views\Customer\GetByName.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </table>\r\n\r\n    </div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a81f10547cf55edca8c64f4d551b112ac3ff75418580", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bus.DomainModels.Trip>> Html { get; private set; }
    }
}
#pragma warning restore 1591