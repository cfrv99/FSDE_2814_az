using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.TagHelpers
{
    [HtmlTargetElement("email")]

    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "contoso.com";

        // Can be passed via <email mail-to="..." />. 
        // PascalCase gets translated into kebab-case.
        [HtmlAttributeName(name:"mail-to")]
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag

            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            
            output.Content.SetContent(address);
        }
    }

}
