#pragma checksum "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37258cb8d1944ea3ba9444160f5926b5f912bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_GetAllUsers), @"mvc.1.0.view", @"/Views/Users/GetAllUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/GetAllUsers.cshtml", typeof(AspNetCore.Views_Users_GetAllUsers))]
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
#line 1 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\_ViewImports.cshtml"
using SlugTestApp;

#line default
#line hidden
#line 2 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\_ViewImports.cshtml"
using SlugTestApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37258cb8d1944ea3ba9444160f5926b5f912bb9", @"/Views/Users/GetAllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93dd96899ddcaf48212201e99f0016458573c9ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_GetAllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SlugTestApp.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
  
    ViewData["Title"] = "GetAllUsers";

#line default
#line hidden
            BeginContext(94, 35, true);
            WriteLiteral("\r\n<h1>GetAllUsers</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c37258cb8d1944ea3ba9444160f5926b5f912bb93853", async() => {
                BeginContext(152, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 38, false);
#line 16 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 40, false);
#line 19 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 40, false);
#line 22 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Desc));

#line default
#line hidden
            EndContext();
            BeginContext(489, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(607, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(656, 37, false);
#line 31 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(693, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(749, 39, false);
#line 34 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(788, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(844, 39, false);
#line 37 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Desc));

#line default
#line hidden
            EndContext();
            BeginContext(883, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 940, "\"", 1008, 6);
            WriteAttributeValue("", 947, "/userhaqqinda/", 947, 14, true);
#line 40 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
WriteAttributeValue("", 961, Url.FriendlyUrl(item.Desc), 961, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 988, "/", 988, 1, true);
#line 40 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
WriteAttributeValue("", 989, item.Name, 989, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 999, "/", 999, 1, true);
#line 40 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
WriteAttributeValue("", 1000, item.Id, 1000, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1009, 52, true);
            WriteLiteral(">Get Details</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Murad\source\repos\SlugTestApp\SlugTestApp\Views\Users\GetAllUsers.cshtml"
}

#line default
#line hidden
            BeginContext(1064, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SlugTestApp.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
