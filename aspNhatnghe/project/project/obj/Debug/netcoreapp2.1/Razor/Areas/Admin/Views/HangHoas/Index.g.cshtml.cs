#pragma checksum "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a1d4c9a4870a8233e88dec24ac208b905dcaf93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HangHoas_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HangHoas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HangHoas/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_HangHoas_Index))]
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
#line 1 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\_ViewImports.cshtml"
using project;

#line default
#line hidden
#line 2 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1d4c9a4870a8233e88dec24ac208b905dcaf93", @"/Areas/Admin/Views/HangHoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HangHoas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<project.Models.DataModels.HangHoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HangHoas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-resposive img-thumbnails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_BackEnd.cshtml";

#line default
#line hidden
            BeginContext(146, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(175, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d3b42500c44d3ba62b27493ae8f39a", async() => {
                BeginContext(241, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(255, 121, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr class=\"d-flex\">\r\n            <th class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(377, 41, false);
#line 17 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(418, 69, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\">\r\n                ");
            EndContext();
            BeginContext(488, 40, false);
#line 20 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(528, 69, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-4\">\r\n                ");
            EndContext();
            BeginContext(598, 40, false);
#line 23 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(638, 69, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\">\r\n                ");
            EndContext();
            BeginContext(708, 42, false);
#line 26 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(750, 69, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(820, 43, false);
#line 29 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(863, 69, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\">\r\n                ");
            EndContext();
            BeginContext(933, 40, false);
#line 32 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Loai));

#line default
#line hidden
            EndContext();
            BeginContext(973, 100, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-1\"></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1105, 77, true);
            WriteLiteral("        <tr class=\"d-flex\">\r\n            <td class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(1183, 40, false);
#line 41 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 71, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-1\">  \r\n                ");
            EndContext();
            BeginContext(1294, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a05971e135d43109f73ce30a3765f9c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1366, "~/Hinh/HangHoa/", 1366, 15, true);
#line 44 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
AddHtmlAttributeValue("", 1381, item.Hinh, 1381, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1395, 69, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-4\">\r\n                ");
            EndContext();
            BeginContext(1465, 39, false);
#line 47 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 69, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-1\">\r\n                ");
            EndContext();
            BeginContext(1574, 41, false);
#line 50 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 69, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(1685, 42, false);
#line 53 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 69, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-1\">\r\n                ");
            EndContext();
            BeginContext(1797, 46, false);
#line 56 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Loai.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 69, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-1\">\r\n                ");
            EndContext();
            BeginContext(1912, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db9208af3974d14b8a1f8b451dd3d2e", async() => {
                BeginContext(1959, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
                                       WriteLiteral(item.MaHh);

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
            BeginContext(1967, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1987, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d42a4e6485c46eaa9b0d85412a1a82c", async() => {
                BeginContext(2037, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
                                          WriteLiteral(item.MaHh);

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
            BeginContext(2048, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2068, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817f817a620644ab9ffdf45c1e64ee37", async() => {
                BeginContext(2117, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
                                         WriteLiteral(item.MaHh);

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
            BeginContext(2127, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\HangHoas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2166, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<project.Models.DataModels.HangHoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
