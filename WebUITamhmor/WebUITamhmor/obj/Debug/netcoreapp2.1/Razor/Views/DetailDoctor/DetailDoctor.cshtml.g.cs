#pragma checksum "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5683895a4a249dbc691a063cd7351c80e54e2a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetailDoctor_DetailDoctor), @"mvc.1.0.view", @"/Views/DetailDoctor/DetailDoctor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DetailDoctor/DetailDoctor.cshtml", typeof(AspNetCore.Views_DetailDoctor_DetailDoctor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5683895a4a249dbc691a063cd7351c80e54e2a5f", @"/Views/DetailDoctor/DetailDoctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba44f7ea8dcca69602519ab9f229c2683e108b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_DetailDoctor_DetailDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUITamhmor.Models.DoctorModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
  
    ViewData["Title"] = "DetailDoctor";

#line default
#line hidden
            BeginContext(101, 810, true);
            WriteLiteral(@"<style>
    img {
        border-radius: 8px;
    }

    table, th, td {
        border: 1px solid #ddd;
        border-collapse: collapse;
        border-radius: 5px;
    }

    th, td {
        padding: 15px;
        text-align: center;
    }

    th {
        background-color: #76b5df;
        color: white;
        font-family: 'Courier New', Courier, monospace;
        font-size: 23px;
    }

    td {
        color: black;
        font-family: 'K2D', sans-serif;
        font-size: 15px;
    }

    /*ul {
        list-style-type: none;
        margin: 1;
        padding: 30px;
        overflow: hidden;
        background-color: #A8DEE0;
    }*/

    li {
        font-size: 30px;
        float: left;
        font-family: 'K2D', sans-serif;
    }
</style>
");
            EndContext();
            BeginContext(911, 1819, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84790ae26f254d5da6d694ce87441ab1", async() => {
                BeginContext(917, 68, true);
                WriteLiteral("\r\n\r\n    <div class=\"container mypanel\" style=\"margin-top:20px;\">\r\n\r\n");
                EndContext();
#line 52 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(1034, 208, true);
                WriteLiteral("            <div class=\"col\" style=\"margin-right: 300px; font-family: \'Courier New\', Courier, monospace;\">\r\n                <p class=\"row\" style=\"font-size: 30px;\">\r\n                    \r\n                    ");
                EndContext();
                BeginContext(1243, 37, false);
#line 57 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
               Write(Html.DisplayFor(model => item.Dfname));

#line default
#line hidden
                EndContext();
                BeginContext(1280, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1303, 37, false);
#line 58 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
               Write(Html.DisplayFor(model => item.Dlname));

#line default
#line hidden
                EndContext();
                BeginContext(1340, 89, true);
                WriteLiteral("\r\n                </p>\r\n\r\n                <p class=\"row\" style=\"font-size: 22px;\">แผนก : ");
                EndContext();
                BeginContext(1430, 42, false);
#line 61 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                                                          Write(Html.DisplayFor(model => item.Ddepartment));

#line default
#line hidden
                EndContext();
                BeginContext(1472, 40, true);
                WriteLiteral("</p>\r\n                <p class=\"row\" >\r\n");
                EndContext();
#line 63 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                     if (item.Dsex == 0)
                    {

#line default
#line hidden
                BeginContext(1577, 127, true);
                WriteLiteral("                        <div style=\"font-size: 22px;\">\r\n                            เพศ : ชาย\r\n                        </div>\r\n");
                EndContext();
#line 68 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1776, 128, true);
                WriteLiteral("                        <div style=\"font-size: 22px;\">\r\n                            เพศ : หญิง\r\n                        </div>\r\n");
                EndContext();
#line 74 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                    }

#line default
#line hidden
                BeginContext(1927, 85, true);
                WriteLiteral("                </p>\r\n                <p class=\"row\" style=\"font-size: 22px;\">อายุ : ");
                EndContext();
                BeginContext(2013, 35, false);
#line 76 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                                                          Write(Html.DisplayFor(model => item.Dage));

#line default
#line hidden
                EndContext();
                BeginContext(2048, 85, true);
                WriteLiteral("</p>\r\n                <p class=\"row\" style=\"font-size: 22px;\">เเพทย์ประจำโรงพยาบาล : ");
                EndContext();
                BeginContext(2134, 40, false);
#line 77 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                                                                          Write(Html.DisplayFor(model => item.Dhospital));

#line default
#line hidden
                EndContext();
                BeginContext(2174, 82, true);
                WriteLiteral("</p>\r\n                <p class=\"row\" style=\"font-size: 22px;\">ความชำนาญเฉพาะทาง : ");
                EndContext();
                BeginContext(2257, 41, false);
#line 78 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                                                                       Write(Html.DisplayFor(model => item.Dexpertise));

#line default
#line hidden
                EndContext();
                BeginContext(2298, 74, true);
                WriteLiteral("</p>\r\n                <p class=\"row\" style=\"font-size: 22px;\">ค่าปรึกษา : ");
                EndContext();
                BeginContext(2373, 37, false);
#line 79 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                                                               Write(Html.DisplayFor(model => item.Dprice));

#line default
#line hidden
                EndContext();
                BeginContext(2410, 31, true);
                WriteLiteral(" Bath</p>\r\n            </div>\r\n");
                EndContext();
                BeginContext(2443, 159, true);
                WriteLiteral("            <div style=\"text-align: right;\">\r\n                <button type=\"button\" class=\"btn btn-info\" style=\"width: 100px; color: white; font-size: 16px;\"> ");
                EndContext();
                BeginContext(2603, 63, false);
#line 83 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
                                                                                                            Write(Html.ActionLink("แชท", "Payment", new { Dprice = item.Dprice }));

#line default
#line hidden
                EndContext();
                BeginContext(2666, 32, true);
                WriteLiteral(" </button>\r\n            </div>\r\n");
                EndContext();
#line 85 "C:\Users\acer\OneDrive\เดสก์ท็อป\Project\Tamhmor1\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\DetailDoctor.cshtml"
        }

#line default
#line hidden
                BeginContext(2709, 14, true);
                WriteLiteral("    </div>\r\n\r\n");
                EndContext();
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
            BeginContext(2730, 14, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
