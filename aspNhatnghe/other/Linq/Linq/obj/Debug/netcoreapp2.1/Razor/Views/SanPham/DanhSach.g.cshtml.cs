#pragma checksum "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\SanPham\DanhSach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455d62abb987a3c6b20e339a3a2a6dbbe9b90039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_DanhSach), @"mvc.1.0.view", @"/Views/SanPham/DanhSach.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPham/DanhSach.cshtml", typeof(AspNetCore.Views_SanPham_DanhSach))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"455d62abb987a3c6b20e339a3a2a6dbbe9b90039", @"/Views/SanPham/DanhSach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8b82cba3eb567e47c0ebdf89361814a8997e6d", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_DanhSach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HangHoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\SanPham\DanhSach.cshtml"
  
    ViewData["Title"] = "DanhSach";

#line default
#line hidden
            BeginContext(73, 42, true);
            WriteLiteral("\r\n<h2>DanhSach</h2>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 9 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\SanPham\DanhSach.cshtml"
     foreach (var sanpham in Model)
    {
        
            await Html.RenderPartialAsync("_hanghoa", sanpham);

        

        

#line default
#line hidden
#line 24 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\other\Linq\Linq\Views\SanPham\DanhSach.cshtml"
                
    }

#line default
#line hidden
            BeginContext(680, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HangHoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
