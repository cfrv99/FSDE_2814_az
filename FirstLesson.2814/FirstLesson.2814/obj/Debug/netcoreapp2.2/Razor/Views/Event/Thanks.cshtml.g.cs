#pragma checksum "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d07b32901b457900867192b78d4229c97be98bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Thanks), @"mvc.1.0.view", @"/Views/Event/Thanks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Thanks.cshtml", typeof(AspNetCore.Views_Event_Thanks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07b32901b457900867192b78d4229c97be98bd0", @"/Views/Event/Thanks.cshtml")]
    public class Views_Event_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(29, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d07b32901b457900867192b78d4229c97be98bd02914", async() => {
                BeginContext(35, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Thanks</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(132, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d07b32901b457900867192b78d4229c97be98bd04189", async() => {
                BeginContext(138, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 10 "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml"
      
        bool isTrue = (bool)ViewBag.IsComming;

        string Name = (string)ViewBag.Name;
        string Surname = (string)ViewBag.Surname;
    

#line default
#line hidden
                BeginContext(301, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 17 "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml"
     if (isTrue)
    {

#line default
#line hidden
                BeginContext(328, 22, true);
                WriteLiteral("        <p>Geldiyiniz ");
                EndContext();
                BeginContext(351, 4, false);
#line 19 "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml"
                 Write(Name);

#line default
#line hidden
                EndContext();
                BeginContext(355, 24, true);
                WriteLiteral(" ucun teshekkurler</p>\r\n");
                EndContext();
#line 20 "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(403, 18, true);
                WriteLiteral("        <p>Qaqash ");
                EndContext();
                BeginContext(422, 4, false);
#line 23 "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml"
             Write(Name);

#line default
#line hidden
                EndContext();
                BeginContext(426, 24, true);
                WriteLiteral(" nosh gemirsen?!!!</p>\r\n");
                EndContext();
#line 24 "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml"

    }

#line default
#line hidden
                BeginContext(459, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\Murad\FSDE_2814\FirstLesson.2814\FirstLesson.2814\Views\Event\Thanks.cshtml"
     for (int i = 0; i < 10; i++) { }

#line default
#line hidden
                BeginContext(500, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(509, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
