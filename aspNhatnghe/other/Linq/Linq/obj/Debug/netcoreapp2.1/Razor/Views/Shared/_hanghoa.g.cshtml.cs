#pragma checksum "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\Shared\_hanghoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d1a7ab1d193bfdd0758b85bc2312b9f65f0393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__hanghoa), @"mvc.1.0.view", @"/Views/Shared/_hanghoa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_hanghoa.cshtml", typeof(AspNetCore.Views_Shared__hanghoa))]
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
#line 1 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\_ViewImports.cshtml"
using Linq;

#line default
#line hidden
#line 2 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\_ViewImports.cshtml"
using Linq.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d1a7ab1d193bfdd0758b85bc2312b9f65f0393", @"/Views/Shared/_hanghoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8b82cba3eb567e47c0ebdf89361814a8997e6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__hanghoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HangHoa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 107, true);
            WriteLiteral("\r\n        <div class=\"col-lg-4\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">");
            EndContext();
            BeginContext(124, 11, false);
#line 5 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\Shared\_hanghoa.cshtml"
                                    Write(Model.TenHh);

#line default
#line hidden
            EndContext();
            BeginContext(135, 69, true);
            WriteLiteral("</div>\r\n                <div class=\"card-body\">\r\n                    ");
            EndContext();
            BeginContext(204, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c704aa1acb06464cbbf9720e456e9709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 251, "~/Hinh/HangHoa/", 251, 15, true);
#line 7 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\Shared\_hanghoa.cshtml"
AddHtmlAttributeValue("", 266, Model.Hinh, 266, 11, false);

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
            BeginContext(281, 67, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-footer\">");
            EndContext();
            BeginContext(349, 36, false);
#line 9 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\Shared\_hanghoa.cshtml"
                                    Write(Model.DonGia.Value.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(385, 46, true);
            WriteLiteral(" VND</div>\r\n            </div>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HangHoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
