#pragma checksum "D:\StepDersleri\GlebITStep-fsde_1812-aspnetcore-dac9e9b456c0\08. Auth\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da107296af10dba9fce5d3b2d55fa72942f197e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\StepDersleri\GlebITStep-fsde_1812-aspnetcore-dac9e9b456c0\08. Auth\Views\_ViewImports.cshtml"
using MVCAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\StepDersleri\GlebITStep-fsde_1812-aspnetcore-dac9e9b456c0\08. Auth\Views\_ViewImports.cshtml"
using MVCAuth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\StepDersleri\GlebITStep-fsde_1812-aspnetcore-dac9e9b456c0\08. Auth\Views\_ViewImports.cshtml"
using MVCAuth.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da107296af10dba9fce5d3b2d55fa72942f197e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e2a2f2c2d0c37aee41504d164b721eda438f7c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\StepDersleri\GlebITStep-fsde_1812-aspnetcore-dac9e9b456c0\08. Auth\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome, ");
#nullable restore
#line 6 "D:\StepDersleri\GlebITStep-fsde_1812-aspnetcore-dac9e9b456c0\08. Auth\Views\Home\Index.cshtml"
                              Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <h2>");
#nullable restore
#line 7 "D:\StepDersleri\GlebITStep-fsde_1812-aspnetcore-dac9e9b456c0\08. Auth\Views\Home\Index.cshtml"
   Write(ViewBag.FilterData);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n");
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
