#pragma checksum "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c63d8c29cae43084cf9efa3e522c15dbc095ac8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\_ViewImports.cshtml"
using CLAMP_Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\_ViewImports.cshtml"
using CLAMP_Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63d8c29cae43084cf9efa3e522c15dbc095ac8b", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b980ff71ce4bbecd12d5893e965548ff72810ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CLAMP_Assignment1.Models.Clamp>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Clamp Products</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Material</th>
            <th>Size</th>
            <th>Type</th>
            <th>Maximum Opening Width</th>
            <th>Load Capacity</th>
            <th>Price</th>
            <th>Customer Review</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
         foreach (var clamp in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
               Write(clamp.Material);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
               Write(clamp.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
               Write(clamp.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
               Write(clamp.MaximumOpeningWidth);

#line default
#line hidden
#nullable disable
            WriteLiteral(" inches</td>\r\n                <td>");
#nullable restore
#line 25 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
               Write(clamp.LoadCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lbs</td>\r\n                <td>");
#nullable restore
#line 26 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
               Write(String.Format("{0:C}", clamp.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
               Write(clamp.CustomerReview);

#line default
#line hidden
#nullable disable
            WriteLiteral(" stars</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\WEB452_Assignment1\CLAMP_Assignment1\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CLAMP_Assignment1.Models.Clamp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
