#pragma checksum "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Admin\ViewSupermarkets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d11f3ffef93555fd4de303bf00c301a854ec495c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewSupermarkets), @"mvc.1.0.view", @"/Views/Admin/ViewSupermarkets.cshtml")]
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
#line 1 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\_ViewImports.cshtml"
using GreenShopperWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\_ViewImports.cshtml"
using GreenShopperWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11f3ffef93555fd4de303bf00c301a854ec495c", @"/Views/Admin/ViewSupermarkets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b30ef304e4ac52abc8c1537b40882daf4ada93", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewSupermarkets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GreenShopperWebsite.Models.APIModels.Supermarket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row row-cols-3\">\r\n");
#nullable restore
#line 6 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Admin\ViewSupermarkets.cshtml"
         foreach (var item in Model) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col p-2\">\r\n                <div class=\"card\" style=\"height:300px\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 299, "\"", 346, 1);
#nullable restore
#line 10 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Admin\ViewSupermarkets.cshtml"
WriteAttributeValue("", 305, Html.DisplayFor(modelItem => item.Image), 305, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                    <div class=\"card-body p-2\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Admin\ViewSupermarkets.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        ");
#nullable restore
#line 13 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Admin\ViewSupermarkets.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new {  id=item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 17 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Admin\ViewSupermarkets.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GreenShopperWebsite.Models.APIModels.Supermarket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
