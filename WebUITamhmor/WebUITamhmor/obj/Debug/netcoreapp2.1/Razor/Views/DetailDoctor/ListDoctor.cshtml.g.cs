#pragma checksum "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4ecdf4e07b5bdd4753415bfa08ea6d597fb620"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4ecdf4e07b5bdd4753415bfa08ea6d597fb620", @"/Views/DetailDoctor/ListDoctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba44f7ea8dcca69602519ab9f229c2683e108b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_DetailDoctor_ListDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUITamhmor.Models.DoctorModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
  
    ViewData["Title"] = "ListDoctor";
    var doctors = Model;

#line default
#line hidden
            BeginContext(125, 184, true);
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar-dark bg-primary\">\r\n    <div style=\"margin:30px\">\r\n        <h1>รวมแผนก</h1>\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"container\" style=\"margin-top: 50px; \">\r\n    ");
            EndContext();
            BeginContext(310, 45, false);
#line 15 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
Write(Html.Hidden("doctors", Model.Max(x => x.Did)));

#line default
#line hidden
            EndContext();
            BeginContext(355, 74, true);
            WriteLiteral("\r\n    <input type=\"text\" id=\"txtsearch\" onkeyup=\"searchDoctor(event)\" />\r\n");
            EndContext();
#line 17 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(470, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 482, "\"", 496, 1);
#line 19 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
WriteAttributeValue("", 487, item.Did, 487, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 170, true);
            WriteLiteral(" class=\"row table-bordered border-0 \" style=\"padding: 20px; margin-bottom: 20px;\">\r\n            <div class=\"col\">\r\n                <div class=\"col\">\r\n                    ");
            EndContext();
            BeginContext(668, 41, false);
#line 22 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dimage));

#line default
#line hidden
            EndContext();
            BeginContext(709, 144, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col\" style=\"margin:5px;\">\r\n                    <div class=\"row\">\r\n                        ");
            EndContext();
            BeginContext(854, 41, false);
#line 26 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dfname));

#line default
#line hidden
            EndContext();
            BeginContext(895, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(922, 41, false);
#line 27 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dlname));

#line default
#line hidden
            EndContext();
            BeginContext(963, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                         if (item.Dsex == 0)
                        {

#line default
#line hidden
            BeginContext(1038, 113, true);
            WriteLiteral("                            <div>\r\n                                เพศ: ชาย\r\n                            </div>\r\n");
            EndContext();
#line 33 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1235, 114, true);
            WriteLiteral("                            <div>\r\n                                เพศ: หญิง\r\n                            </div>\r\n");
            EndContext();
#line 39 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                        }

#line default
#line hidden
            BeginContext(1376, 61, true);
            WriteLiteral("\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(1438, 44, false);
#line 42 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Dhospital));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 115, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div>\r\n                            <button class=\"btn\">");
            EndContext();
            BeginContext(1598, 71, false);
#line 46 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"
                                           Write(Html.ActionLink("ดูรายละเอียด", "DetailDoctor", new { Did = item.Did }));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 131, true);
            WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 52 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\DetailDoctor\ListDoctor.cshtml"

    }

#line default
#line hidden
            BeginContext(1809, 653, true);
            WriteLiteral(@"</div>
<script>
    function searchDoctor(e) {
        var search = document.getElementById(""txtsearch"").value
        var maxId = document.getElementById(""doctors"").value
        console.log(e)
        console.log(search)
        for (var i = 1; i <= maxId; i++) {
            var doctor = document.getElementById(i)
            if (doctor) {
                var text = doctor.getElementsByTagName(""*"")[2].children[0].innerText
                if (text.includes(search))
                    doctor.style.display = ""block""
                else
                    doctor.style.display = ""none""
            }
        }
    }
</script>
");
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
