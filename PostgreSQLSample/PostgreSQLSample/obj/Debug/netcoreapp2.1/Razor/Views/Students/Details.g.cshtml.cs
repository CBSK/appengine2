#pragma checksum "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634aef686ba382402c427b06aa856048408dcdeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
#line 1 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\_ViewImports.cshtml"
using PostgreSQLSample;

#line default
#line hidden
#line 2 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\_ViewImports.cshtml"
using PostgreSQLSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634aef686ba382402c427b06aa856048408dcdeb", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53978808642f75f59ebdb9dbd94fe05d475aee89", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostgreSQLSample.Models.DB.CabDB>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(255, 45, false);
#line 15 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(300, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(344, 41, false);
#line 18 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(385, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(429, 44, false);
#line 21 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(473, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(517, 40, false);
#line 24 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(601, 42, false);
#line 27 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(643, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(687, 38, false);
#line 30 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(725, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(769, 47, false);
#line 33 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(816, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(860, 43, false);
#line 36 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(903, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(947, 54, false);
#line 39 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfRegistration));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1045, 50, false);
#line 42 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfRegistration));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1139, 47, false);
#line 45 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1230, 43, false);
#line 48 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1317, 41, false);
#line 51 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1402, 37, false);
#line 54 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1483, 44, false);
#line 57 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1571, 40, false);
#line 60 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1655, 44, false);
#line 63 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1743, 40, false);
#line 66 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1827, 40, false);
#line 69 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1911, 36, false);
#line 72 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1991, 41, false);
#line 75 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(2032, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2076, 37, false);
#line 78 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2157, 39, false);
#line 81 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2196, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2240, 35, false);
#line 84 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2322, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99259cb927c54152a60e625e9ad5a2c3", async() => {
                BeginContext(2375, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "D:\Bharati\Projects\Visual Studio\ASP.NET Core\PostgreSQLSample\PostgreSQLSample\Views\Students\Details.cshtml"
                           WriteLiteral(Model.StudentId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2383, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2391, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b779ed4a49a5427fb72adccc81fa9bf7", async() => {
                BeginContext(2413, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2429, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostgreSQLSample.Models.DB.CabDB> Html { get; private set; }
    }
}
#pragma warning restore 1591
