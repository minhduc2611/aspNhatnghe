#pragma checksum "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00fda37c9ce144fe6bf521406ee79027d04bdd29"
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
#line 1 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/_ViewImports.cshtml"
using project;

#line default
#line hidden
#line 2 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00fda37c9ce144fe6bf521406ee79027d04bdd29", @"/Areas/Admin/Views/HangHoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229d22977632e367b33876458aad14c78337e6d5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
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
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_BackEnd.cshtml";

#line default
#line hidden
            BeginContext(140, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(165, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff834a95daa4c8fba56e0a3de7b9277", async() => {
                BeginContext(231, 10, true);
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
            BeginContext(245, 115, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr class=\"d-flex\">\n            <th class=\"col-2\">\n                ");
            EndContext();
            BeginContext(361, 41, false);
#line 17 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(402, 66, true);
            WriteLiteral("\n            </th>\n            <th class=\"col-1\">\n                ");
            EndContext();
            BeginContext(469, 40, false);
#line 20 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(509, 66, true);
            WriteLiteral("\n            </th>\n            <th class=\"col-4\">\n                ");
            EndContext();
            BeginContext(576, 40, false);
#line 23 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(616, 66, true);
            WriteLiteral("\n            </th>\n            <th class=\"col-1\">\n                ");
            EndContext();
            BeginContext(683, 42, false);
#line 26 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(725, 66, true);
            WriteLiteral("\n            </th>\n            <th class=\"col-2\">\n                ");
            EndContext();
            BeginContext(792, 43, false);
#line 29 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(835, 66, true);
            WriteLiteral("\n            </th>\n            <th class=\"col-1\">\n                ");
            EndContext();
            BeginContext(902, 40, false);
#line 32 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Loai));

#line default
#line hidden
            EndContext();
            BeginContext(942, 94, true);
            WriteLiteral("\n            </th>\n            <th class=\"col-1\"></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 38 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1067, 75, true);
            WriteLiteral("        <tr class=\"d-flex\">\n            <td class=\"col-2\">\n                ");
            EndContext();
            BeginContext(1143, 40, false);
#line 41 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 70, true);
            WriteLiteral("\n            </td>\n            <td class=\"col-1\">\n                    ");
            EndContext();
            BeginContext(1253, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d43413b6dc54e8e8b50b8bfd34f1bbf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1325, "~/Hinh/HangHoa/", 1325, 15, true);
#line 44 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
AddHtmlAttributeValue("", 1340, item.Hinh, 1340, 10, false);

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
            BeginContext(1354, 66, true);
            WriteLiteral("\n            </td>\n            <td class=\"col-4\">\n                ");
            EndContext();
            BeginContext(1421, 39, false);
#line 47 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 66, true);
            WriteLiteral("\n            </td>\n            <td class=\"col-1\">\n                ");
            EndContext();
            BeginContext(1527, 41, false);
#line 50 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 66, true);
            WriteLiteral("\n            </td>\n            <td class=\"col-2\">\n                ");
            EndContext();
            BeginContext(1635, 42, false);
#line 53 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 66, true);
            WriteLiteral("\n            </td>\n            <td class=\"col-1\">\n                ");
            EndContext();
            BeginContext(1744, 46, false);
#line 56 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Loai.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 66, true);
            WriteLiteral("\n            </td>\n            <td class=\"col-1\">\n                ");
            EndContext();
            BeginContext(1856, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16060be209f4225b3e7e7761e31fbf7", async() => {
                BeginContext(1903, 4, true);
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
#line 59 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
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
            BeginContext(1911, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1930, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f0baa6c68d04d8aa2b37db8f8b09ea8", async() => {
                BeginContext(1980, 7, true);
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
#line 60 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
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
            BeginContext(1991, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2010, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c091b4c712b47e7b0d58897138354dd", async() => {
                BeginContext(2059, 6, true);
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
#line 61 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
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
            BeginContext(2069, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 64 "/Users/minhduc/Desktop/MINHDUC/code/github/aspNhatnghe/aspNhatnghe/project/project/Areas/Admin/Views/HangHoas/Index.cshtml"
}

#line default
#line hidden
            BeginContext(2104, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
