#pragma checksum "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9abe93d54c3f8b6e2fcc1daa76f3075d5e4e8c1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loai_Delete), @"mvc.1.0.view", @"/Views/Loai/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Loai/Delete.cshtml", typeof(AspNetCore.Views_Loai_Delete))]
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
#line 1 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\_ViewImports.cshtml"
using linqCodeFirst;

#line default
#line hidden
#line 2 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\_ViewImports.cshtml"
using linqCodeFirst.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abe93d54c3f8b6e2fcc1daa76f3075d5e4e8c1d", @"/Views/Loai/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ec78b99a6bfe2ed0c44518d18f73ac64b30346", @"/Views/_ViewImports.cshtml")]
    public class Views_Loai_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<linqCodeFirst.Models.Loai>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(42, 1421, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a3366240d5a4cb7ae20bb485d23e444", async() => {
                BeginContext(68, 353, true);
                WriteLiteral(@"
        <div class=""modal-header"">
            <h3>Are you sure you want to delete this?</h3>
            <button type=""button"" class=""close"" data-dismiss=""modal""></button>
            <h4 class=""modal-title""></h4>
        </div>
        <div class=""modal-body"">
            <dl class=""dl-horizontal"">
                <dt>
                    ");
                EndContext();
                BeginContext(422, 42, false);
#line 13 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.MaLoai));

#line default
#line hidden
                EndContext();
                BeginContext(464, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(532, 38, false);
#line 16 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayFor(model => model.MaLoai));

#line default
#line hidden
                EndContext();
                BeginContext(570, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(638, 43, false);
#line 19 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.TenLoai));

#line default
#line hidden
                EndContext();
                BeginContext(681, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(749, 39, false);
#line 22 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayFor(model => model.TenLoai));

#line default
#line hidden
                EndContext();
                BeginContext(788, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(856, 40, false);
#line 25 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
                EndContext();
                BeginContext(896, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(964, 36, false);
#line 28 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
                EndContext();
                BeginContext(1000, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(1068, 40, false);
#line 31 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
                EndContext();
                BeginContext(1108, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(1176, 36, false);
#line 34 "C:\Users\NN\source\repos\linqCodeFirst\linqCodeFirst\Views\Loai\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Hinh));

#line default
#line hidden
                EndContext();
                BeginContext(1212, 184, true);
                WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"modal-footer\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" />\r\n            ");
                EndContext();
                BeginContext(1396, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "208cf8750ea0488c88efa2404f72bfb3", async() => {
                    BeginContext(1418, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1434, 22, true);
                WriteLiteral("\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1463, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<linqCodeFirst.Models.Loai> Html { get; private set; }
    }
}
#pragma warning restore 1591
