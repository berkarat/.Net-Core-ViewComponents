#pragma checksum "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6291ca72fba6d09ee3fcbec14b53ce0c1cad951"
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
#line 4 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\_ViewImports.cshtml"
using ViewComponentExample.Models;

#line default
#line hidden
#line 4 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\_ViewImports.cshtml"
using ViewComponentExample.Components;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6291ca72fba6d09ee3fcbec14b53ce0c1cad951", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d167ea8f2c08ecce0d3707dfbd35fb46207fbe50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(71, 93, true);
            WriteLiteral("\r\n<div class=\"widget\">\r\n    <h4>CATEGORIES</h4>\r\n    <ul class=\"list-unstyled link-list\">\r\n\r\n");
            EndContext();
#line 11 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
            BeginContext(224, 88, true);
            WriteLiteral("            <li><i class=\"fa fa-angle-right fa-fw\" aria-hidden=\"true\"></i> <a href=\"#\"> ");
            EndContext();
            BeginContext(313, 17, false);
#line 13 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
                                                                                   Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(330, 13, true);
            WriteLiteral("  </a></li>\r\n");
            EndContext();
#line 14 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(356, 118, true);
            WriteLiteral("\r\n\r\n\r\n    </ul>\r\n</div>\r\n\r\n<div class=\"widget\">\r\n    <h4>CATEGORIES</h4>\r\n    <ul class=\"list-unstyled link-list\">\r\n\r\n");
            EndContext();
#line 26 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
         foreach (var item in Model.Products)
        {

#line default
#line hidden
            BeginContext(532, 88, true);
            WriteLiteral("            <li><i class=\"fa fa-angle-right fa-fw\" aria-hidden=\"true\"></i> <a href=\"#\"> ");
            EndContext();
            BeginContext(621, 9, false);
#line 28 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(630, 27, true);
            WriteLiteral(" <span class=\"pull-right\">(");
            EndContext();
            BeginContext(658, 10, false);
#line 28 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
                                                                                                                        Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(668, 19, true);
            WriteLiteral(")</span></a></li>\r\n");
            EndContext();
#line 29 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(700, 171, true);
            WriteLiteral("\r\n\r\n\r\n    </ul>\r\n</div>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n             \r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n");
            EndContext();
#line 46 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
            BeginContext(937, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(954, 9, false);
#line 48 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(963, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(987, 10, false);
#line 49 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(997, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 50 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(1021, 55, true);
            WriteLiteral("          \r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1077, 43, false);
#line 58 "C:\Users\berka\source\repos\ViewComponentExample\ViewComponentExample\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591
