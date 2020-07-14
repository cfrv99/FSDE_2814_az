using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.TagHelpers
{

    // <buttonclass="" bs-button=""></button>

    [HtmlTargetElement("button", Attributes = "bs-button")]
    public class ButtonTagHelper : TagHelper
    {
        [HtmlAttributeName(name: "bs-button")]
        public string BsButton { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButton}");
            output.Content.SetContent(BsButton == "success" ? "Add" : "Delete");
            base.Process(context, output);
        }
    }
}
