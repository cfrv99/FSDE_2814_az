#pragma checksum "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c7241c050a6246425d6551c3d4768039095b51a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Posts_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Posts/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Posts_Details))]
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
#line 1 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\_ViewImports.cshtml"
using MyFirstBlogApp;

#line default
#line hidden
#line 2 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\_ViewImports.cshtml"
using MyFirstBlogApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c7241c050a6246425d6551c3d4768039095b51a", @"/Areas/Admin/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1bfffdf9dd7bebf33c0cbf980a432c65bc61a8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFirstBlogApp.DTOs.Response.PostDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(163, 139, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>PostDetailsModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(303, 40, false);
#line 15 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(343, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(407, 36, false);
#line 18 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(443, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(506, 40, false);
#line 21 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desc));

#line default
#line hidden
            EndContext();
            BeginContext(546, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(610, 36, false);
#line 24 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desc));

#line default
#line hidden
            EndContext();
            BeginContext(646, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(709, 44, false);
#line 27 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(753, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(817, 40, false);
#line 30 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(857, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(920, 47, false);
#line 33 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ViewedCount));

#line default
#line hidden
            EndContext();
            BeginContext(967, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1031, 43, false);
#line 36 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ViewedCount));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1137, 42, false);
#line 39 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1243, 38, false);
#line 42 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1344, 46, false);
#line 45 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1454, 42, false);
#line 48 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1559, 48, false);
#line 51 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1671, 44, false);
#line 54 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1763, 68, false);
#line 59 "C:\Users\Murad\FSDE_2814\MyFirstBlogApp\MyFirstBlogApp\Areas\Admin\Views\Posts\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1839, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c7241c050a6246425d6551c3d4768039095b51a10664", async() => {
                BeginContext(1861, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1877, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFirstBlogApp.DTOs.Response.PostDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
