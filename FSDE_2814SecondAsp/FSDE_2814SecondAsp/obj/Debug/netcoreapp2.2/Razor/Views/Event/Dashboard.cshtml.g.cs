#pragma checksum "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02b6fdb7b4130ad1690da9f225488d90d5447594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Dashboard), @"mvc.1.0.view", @"/Views/Event/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Dashboard.cshtml", typeof(AspNetCore.Views_Event_Dashboard))]
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
#line 1 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\_ViewImports.cshtml"
using FSDE_2814SecondAsp;

#line default
#line hidden
#line 2 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\_ViewImports.cshtml"
using FSDE_2814SecondAsp.Models;

#line default
#line hidden
#line 3 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\_ViewImports.cshtml"
using FSDE_2814SecondAsp.Middlewares;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02b6fdb7b4130ad1690da9f225488d90d5447594", @"/Views/Event/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce32d082e63c841f0face066c60fddb677c543a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(100, 24, true);
            WriteLiteral("\r\n<h1>Dashboard</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\Dashboard.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
            BeginContext(162, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(171, 19, false);
#line 11 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\Dashboard.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(190, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 12 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\Dashboard.cshtml"
}

#line default
#line hidden
            BeginContext(200, 36, true);
            WriteLiteral("\r\n<h1 class=\"container-fluid\">\r\n    ");
            EndContext();
            BeginContext(237, 61, false);
#line 15 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\Dashboard.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_PartialRest.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(298, 12, true);
            WriteLiteral(";\r\n</h1>\r\n\r\n");
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
