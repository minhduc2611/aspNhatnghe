#pragma checksum "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a0cfb05ecd9cf4e7ab35c849f93a5acc678124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangHoa_TimKiem), @"mvc.1.0.view", @"/Views/HangHoa/TimKiem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HangHoa/TimKiem.cshtml", typeof(AspNetCore.Views_HangHoa_TimKiem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85a0cfb05ecd9cf4e7ab35c849f93a5acc678124", @"/Views/HangHoa/TimKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8b82cba3eb567e47c0ebdf89361814a8997e6d", @"/Views/_ViewImports.cshtml")]
    public class Views_HangHoa_TimKiem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Linq.Models.HangHoaView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TimKiem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
  
    ViewData["Title"] = "TimKiem";

#line default
#line hidden
            BeginContext(88, 22, true);
            WriteLiteral("\r\n<h2>TimKiem</h2>\r\n\r\n");
            EndContext();
            BeginContext(110, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc5cbe84b1714ace85018ed572fb4ea6", async() => {
                BeginContext(151, 215, true);
                WriteLiteral("\r\n\r\n    Ten Hang Hoa <input type=\"text\" name=\"TenHH\" value=\"\" />\r\n    Gia Tu <input type=\"number\" name=\"GiaTu\" value=\"\" />\r\n    Gia Den <input type=\"number\" name=\"GiaDen\" value=\"\" />\r\n    <button>Tim Kiem</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(373, 185, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-condensed\">\r\n    <tr>\r\n        <td>Tên</td>\r\n        <td>Giá</td>\r\n        <td>Hình</td>\r\n        <td>Loại</td>\r\n        <td>Nhà cung cấp</td>\r\n    </tr>\r\n");
            EndContext();
#line 24 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
     foreach (HangHoaView hh in Model)
    {

#line default
#line hidden
            BeginContext(605, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(636, 8, false);
#line 27 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
           Write(hh.TenHH);

#line default
#line hidden
            EndContext();
            BeginContext(644, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(668, 9, false);
#line 28 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
           Write(hh.DonGia);

#line default
#line hidden
            EndContext();
            BeginContext(677, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(700, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e92aa0c1e214a0cbd2bc0ba71a35701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 710, "~/Hinh/HangHoa/", 710, 15, true);
#line 29 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
AddHtmlAttributeValue("", 725, hh.Hinh, 725, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(750, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(774, 7, false);
#line 30 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
           Write(hh.Loai);

#line default
#line hidden
            EndContext();
            BeginContext(781, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(805, 8, false);
#line 31 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
           Write(hh.NhaCC);

#line default
#line hidden
            EndContext();
            BeginContext(813, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\HangHoa\TimKiem.cshtml"
    }

#line default
#line hidden
            BeginContext(842, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Linq.Models.HangHoaView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
