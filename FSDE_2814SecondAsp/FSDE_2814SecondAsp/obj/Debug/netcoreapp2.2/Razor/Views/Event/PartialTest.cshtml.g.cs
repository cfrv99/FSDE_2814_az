#pragma checksum "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\PartialTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721b1c15ce991d25c99305460977d8bfa812299e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_PartialTest), @"mvc.1.0.view", @"/Views/Event/PartialTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/PartialTest.cshtml", typeof(AspNetCore.Views_Event_PartialTest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721b1c15ce991d25c99305460977d8bfa812299e", @"/Views/Event/PartialTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce32d082e63c841f0face066c60fddb677c543a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_PartialTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\PartialTest.cshtml"
  
    ViewData["Title"] = "PartialTest";
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(102, 32, true);
            WriteLiteral("\r\n<h1>PartialTest</h1>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(135, 114, false);
#line 12 "C:\Users\Murad\FSDE_2814\FSDE_2814SecondAsp\FSDE_2814SecondAsp\Views\Event\PartialTest.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_PartialTest.cshtml", new ViewDataDictionary(ViewData) { { "index", 4 } }));

#line default
#line hidden
            EndContext();
            BeginContext(249, 1, true);
            WriteLiteral(";");
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