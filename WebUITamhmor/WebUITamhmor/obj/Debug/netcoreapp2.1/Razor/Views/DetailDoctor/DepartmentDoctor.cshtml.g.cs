#pragma checksum "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DepartmentDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c301abcd46d97984c45265fd66c2ef7b5d71db89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetailDoctor_DepartmentDoctor), @"mvc.1.0.view", @"/Views/DetailDoctor/DepartmentDoctor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DetailDoctor/DepartmentDoctor.cshtml", typeof(AspNetCore.Views_DetailDoctor_DepartmentDoctor))]
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
#line 1 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\_ViewImports.cshtml"
using WebUITamhmor;

#line default
#line hidden
#line 2 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\_ViewImports.cshtml"
using WebUITamhmor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c301abcd46d97984c45265fd66c2ef7b5d71db89", @"/Views/DetailDoctor/DepartmentDoctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba44f7ea8dcca69602519ab9f229c2683e108b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_DetailDoctor_DepartmentDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUITamhmor.Models.DoctorModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control border border-1 text-center "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-bottom: 60px; padding-top:20px; margin: 20px; font-size:30px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DepartmentDoctor.cshtml"
  
    ViewData["Title"] = "DepartmentDoctor";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(107, 617, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f42912e3db7e451ba2aa778d87266ecd", async() => {
                BeginContext(113, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 8 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DepartmentDoctor.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
                BeginContext(158, 94, true);
                WriteLiteral("        <div class=\" container row\">\r\n\r\n            <div class=\"col-sm-3\">\r\n\r\n                ");
                EndContext();
                BeginContext(252, 254, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57912e9fc2464ad2ac83dbd0d9d462c7", async() => {
                    BeginContext(410, 24, true);
                    WriteLiteral("\r\n\r\n                    ");
                    EndContext();
                    BeginContext(435, 46, false);
#line 17 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DepartmentDoctor.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ddepartment));

#line default
#line hidden
                    EndContext();
                    BeginContext(481, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(506, 74, true);
                WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-info center-block\">");
                EndContext();
                BeginContext(581, 78, false);
#line 19 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DepartmentDoctor.cshtml"
                                                                   Write(Html.ActionLink("เลือก", "ListDoctor", new { Ddepartment = item.Ddepartment }));

#line default
#line hidden
                EndContext();
                BeginContext(659, 49, true);
                WriteLiteral("</button>\r\n            </div>\r\n\r\n        </div>\r\n");
                EndContext();
#line 23 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DepartmentDoctor.cshtml"

    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(724, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebUITamhmor.Models.DoctorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
