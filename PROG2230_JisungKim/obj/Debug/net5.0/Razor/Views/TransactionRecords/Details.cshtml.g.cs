#pragma checksum "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b84d587ec96c4fc926fca1bcf24d54df1db6c36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TransactionRecords_Details), @"mvc.1.0.view", @"/Views/TransactionRecords/Details.cshtml")]
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
#line 1 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\_ViewImports.cshtml"
using PROG2230_JisungKim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\_ViewImports.cshtml"
using PROG2230_JisungKim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b84d587ec96c4fc926fca1bcf24d54df1db6c36", @"/Views/TransactionRecords/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c871b2c27e5ec8b1a06680888d1b31c7a1adb2a8", @"/Views/_ViewImports.cshtml")]
    public class Views_TransactionRecords_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROG2230_JisungKim.Models.TransactionRecord>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
  
    ViewData["Title"] = "Transaction Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Transaction Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.TickerSymbol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.TickerSymbol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SharePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayFor(model => model.SharePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Gross Value\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $");
#nullable restore
#line 40 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
        Write(String.Format("{0:#,##0.00;(#,##0.00);Zero}", Model.CalculateGrossValue()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Net Value\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $");
#nullable restore
#line 46 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
        Write(String.Format("{0:#,##0.00;(#,##0.00);Zero}", Model.CalculateNetValue()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b84d587ec96c4fc926fca1bcf24d54df1db6c368946", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 57 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
                           WriteLiteral(Model.TransactionRecordId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b84d587ec96c4fc926fca1bcf24d54df1db6c3611149", async() => {
                WriteLiteral("Back to Transactions");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\PROG2230\Assignment\(A2)PROG2230_JisungKim\PROG2230_JisungKim\PROG2230_JisungKim\Views\TransactionRecords\Details.cshtml"
                                   WriteLiteral(Model.CompanyId);

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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROG2230_JisungKim.Models.TransactionRecord> Html { get; private set; }
    }
}
#pragma warning restore 1591
