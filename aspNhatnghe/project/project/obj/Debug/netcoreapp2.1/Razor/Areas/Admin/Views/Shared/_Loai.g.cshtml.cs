#pragma checksum "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d331b477bc67fc0e6fe5ff24267e5ac0f711e83c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Loai), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Loai.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_Loai.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__Loai))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d331b477bc67fc0e6fe5ff24267e5ac0f711e83c", @"/Areas/Admin/Views/Shared/_Loai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Loai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<project.Models.Datamodels.Loai>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 49, true);
            WriteLiteral("\r\n<select name=\"MaLoai\" class=\"form-control\">\r\n\r\n");
            EndContext();
#line 5 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
      
        var dsLoai = Model;
        var LoaiCha = dsLoai.Where(p => p.MaLoaiCha == 0);
    

#line default
#line hidden
            BeginContext(206, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 9 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
     foreach (var lo in LoaiCha)
    {
        var dsLoaiCon =  dsLoai.Where( p => p.MaLoaiCha == lo.MaLoai);

#line default
#line hidden
            BeginContext(319, 17, true);
            WriteLiteral("        <optgroup");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 336, "\"", 355, 1);
#line 12 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
WriteAttributeValue("", 344, lo.TenLoai, 344, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(356, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 13 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
             foreach (var con in dsLoaiCon)
            {

#line default
#line hidden
            BeginContext(419, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(435, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552b4c2e33f84701842cb045a901c090", async() => {
                BeginContext(464, 11, false);
#line 15 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
                                       Write(con.TenLoai);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
                   WriteLiteral(con.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(484, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
            }

#line default
#line hidden
            BeginContext(501, 21, true);
            WriteLiteral("        </optgroup>\r\n");
            EndContext();
#line 18 "C:\Users\NN\source\repos\aspNhatnghe\aspNhatnghe\project\project\Areas\Admin\Views\Shared\_Loai.cshtml"
    }

#line default
#line hidden
            BeginContext(529, 9, true);
            WriteLiteral("</select>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<project.Models.Datamodels.Loai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
