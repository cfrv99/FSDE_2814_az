#pragma checksum "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "371b21b85a864b2a20cf8a2a1950c91e333d7916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_GetAllPost), @"mvc.1.0.view", @"/Views/Blog/GetAllPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/GetAllPost.cshtml", typeof(AspNetCore.Views_Blog_GetAllPost))]
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
#line 1 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\_ViewImports.cshtml"
using MyLittleMedium.Entities;

#line default
#line hidden
#line 2 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\_ViewImports.cshtml"
using MyLittleMedium;

#line default
#line hidden
#line 3 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\_ViewImports.cshtml"
using MyLittleMedium.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"371b21b85a864b2a20cf8a2a1950c91e333d7916", @"/Views/Blog/GetAllPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f9d29afc9262c7f65d7f620220506e938d031cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_GetAllPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"
  
    ViewData["Title"] = "GetAllPost";

#line default
#line hidden
            BeginContext(65, 48, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-8\">\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(162, 142, true);
            WriteLiteral("            <div class=\"card text-center\">\r\n                <div class=\"card-header\">\r\n                    Viewed:<i class=\"far fa-eye\"></i>  ");
            EndContext();
            BeginContext(305, 16, false);
#line 13 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"
                                                  Write(item.ViewedCount);

#line default
#line hidden
            EndContext();
            BeginContext(321, 110, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(432, 9, false);
#line 16 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"
                                      Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(441, 48, true);
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(490, 9, false);
#line 17 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"
                                    Write(item.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(499, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(525, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "371b21b85a864b2a20cf8a2a1950c91e333d79166264", async() => {
                BeginContext(619, 10, true);
                WriteLiteral("Go Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(633, 156, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-footer text-muted\">\r\n                    2 days ago\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 24 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"

        }

#line default
#line hidden
            BeginContext(802, 45, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-4\">\r\n        ");
            EndContext();
            BeginContext(848, 43, false);
#line 28 "C:\Users\Murad\FSDE_2814\MyLittleMedium\MyLittleMedium\Views\Blog\GetAllPost.cshtml"
   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
            EndContext();
            BeginContext(891, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
