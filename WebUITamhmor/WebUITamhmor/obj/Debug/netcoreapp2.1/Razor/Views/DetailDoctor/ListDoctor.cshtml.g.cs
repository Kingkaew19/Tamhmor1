#pragma checksum "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7200677c28706963e51c8832b1f8f9340e201cb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetailDoctor_ListDoctor), @"mvc.1.0.view", @"/Views/DetailDoctor/ListDoctor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DetailDoctor/ListDoctor.cshtml", typeof(AspNetCore.Views_DetailDoctor_ListDoctor))]
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
#line 1 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\_ViewImports.cshtml"
using WebUITamhmor;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\_ViewImports.cshtml"
using WebUITamhmor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7200677c28706963e51c8832b1f8f9340e201cb1", @"/Views/DetailDoctor/ListDoctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba44f7ea8dcca69602519ab9f229c2683e108b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_DetailDoctor_ListDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUITamhmor.Models.DoctorModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
  
    ViewData["Title"] = "ListDoctor";

#line default
#line hidden
            BeginContext(99, 126, true);
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar-dark bg-primary\">\r\n    <div style=\"margin:30px\">\r\n        <h1>รวมแผนก</h1>\r\n    </div>\r\n</nav>\r\n");
            EndContext();
            BeginContext(1240, 53, true);
            WriteLiteral("<div class=\"container\" style=\"margin-top: 50px; \" >\r\n");
            EndContext();
#line 50 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(1334, 173, true);
            WriteLiteral("        <div class=\"row table-bordered border-0\" style=\"padding: 20px; margin-bottom: 20px;\">\r\n            <div class=\"col\">\r\n            <div class=\"col\">\r\n                ");
            EndContext();
            BeginContext(1508, 41, false);
#line 55 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dimage));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 128, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col\" style=\"margin:5px;\">\r\n                <div class=\"row\">\r\n                    ");
            EndContext();
            BeginContext(1678, 41, false);
#line 59 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dfname));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1742, 41, false);
#line 60 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dlname));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1837, 39, false);
#line 62 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dsex));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 81, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1958, 44, false);
#line 65 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dhospital));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 81, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2084, 70, false);
#line 68 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                   Write(Html.ActionLink("ดูรายละเอียด", "DetailDoctor", new { id = item.Did }));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 102, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 74 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
        
    }

#line default
#line hidden
            BeginContext(2273, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebUITamhmor.Models.DoctorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591