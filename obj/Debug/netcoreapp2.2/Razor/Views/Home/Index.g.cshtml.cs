#pragma checksum "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8928871d4fbd4fb9a1c194e79615fa31804f451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\_ViewImports.cshtml"
using LostInTheWoods;

#line default
#line hidden
#line 2 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\_ViewImports.cshtml"
using LostInTheWoods.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8928871d4fbd4fb9a1c194e79615fa31804f451", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9ba960125634dc0fdf3d0e3fb0f83ed2ab9064", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 236, true);
            WriteLiteral("\r\n<div>\r\n    <h1>Lost in the Woods</h1>\r\n    <h2>Listings of local hiking trails</h2>\r\n    <table>\r\n        <tr>\r\n            <th>Trail Name</th>\r\n            <th>Trail Length</th>\r\n            <th>Elevation Change</th>\r\n        </tr>\r\n");
            EndContext();
#line 14 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml"
         foreach(var trail in ViewBag.allTrails)
        {

#line default
#line hidden
            BeginContext(342, 32, true);
            WriteLiteral("        <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 374, "\"", 398, 2);
            WriteAttributeValue("", 381, "/trails/", 381, 8, true);
#line 17 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml"
WriteAttributeValue("", 389, trail.Id, 389, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(399, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(401, 10, false);
#line 17 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml"
                                       Write(trail.Name);

#line default
#line hidden
            EndContext();
            BeginContext(411, 28, true);
            WriteLiteral("</a> </td>\r\n            <td>");
            EndContext();
            BeginContext(440, 12, false);
#line 18 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml"
           Write(trail.Length);

#line default
#line hidden
            EndContext();
            BeginContext(452, 29, true);
            WriteLiteral(" miles</td>\r\n            <td>");
            EndContext();
            BeginContext(482, 15, false);
#line 19 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml"
           Write(trail.Elevation);

#line default
#line hidden
            EndContext();
            BeginContext(497, 27, true);
            WriteLiteral(" FEET</td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "c:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\LostInTheWoods\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(535, 66, true);
            WriteLiteral("    </table>\r\n    <a href=\"/addtrails\">Add a new Trail</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
