#pragma checksum "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ffa74ea144e1b9701f46004d1c11f4f87142546"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangHoa_Index), @"mvc.1.0.view", @"/Views/HangHoa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HangHoa/Index.cshtml", typeof(AspNetCore.Views_HangHoa_Index))]
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
#line 1 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\_ViewImports.cshtml"
using project;

#line default
#line hidden
#line 2 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ffa74ea144e1b9701f46004d1c11f4f87142546", @"/Views/HangHoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Views/_ViewImports.cshtml")]
    public class Views_HangHoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<project.Models.HangHoaView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Main.cshtml";

#line default
#line hidden
            BeginContext(136, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(165, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "058964d146a842ecafdde9165950bc47", async() => {
                BeginContext(188, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(202, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(295, 41, false);
#line 17 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(336, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(392, 47, false);
#line 20 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenKhongDau));

#line default
#line hidden
            EndContext();
            BeginContext(439, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 40, false);
#line 23 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(535, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(591, 40, false);
#line 26 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(631, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(687, 42, false);
#line 29 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(729, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(785, 43, false);
#line 32 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(828, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(884, 40, false);
#line 35 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Loai));

#line default
#line hidden
            EndContext();
            BeginContext(924, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1042, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1091, 40, false);
#line 44 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1187, 46, false);
#line 47 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenKhongDau));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1289, 39, false);
#line 50 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1384, 39, false);
#line 53 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1479, 41, false);
#line 56 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1576, 42, false);
#line 59 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1674, 39, false);
#line 62 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Loai));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 65 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
                  
                    string LoaiKhongDau = MyTools.ConvertToUrlFriendly(item.Loai);
                

#line default
#line hidden
            BeginContext(1875, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1891, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf1e667406b84e1ca3d40a50a216a95d", async() => {
                BeginContext(1956, 3, true);
                WriteLiteral("Mua");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
                       WriteLiteral(LoaiKhongDau);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
                                                  WriteLiteral(item.TenKhongDau);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1963, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(2229, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 77 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Views\HangHoa\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2266, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<project.Models.HangHoaView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
