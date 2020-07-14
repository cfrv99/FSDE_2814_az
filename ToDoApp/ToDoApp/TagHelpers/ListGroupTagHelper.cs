using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.TagHelpers
{
    [HtmlTargetElement("ul",Attributes ="items")]
    public class ListGroupTagHelper:TagHelper
    {
        [HtmlAttributeName(name:"items")]
        public List<string> Items { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "list-group");
            foreach (var item in Items)
            {
                TagBuilder li = new TagBuilder("li");
                li.Attributes["class"] = "list-group-item";
                li.InnerHtml.AppendHtml(item);
                output.PreContent.AppendHtml(li);
            }
            base.Process(context, output);
        }

    }
}
