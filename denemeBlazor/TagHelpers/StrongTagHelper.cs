using Microsoft.AspNetCore.Razor.TagHelpers;

namespace denemeBlazor.TagHelpers
{
    [HtmlTargetElement("bolderTagHelper")]
    public class StrongTagHelper : TagHelper
    {
        public string boldData { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent($"<b class='font-semibold'> {boldData} </b>"); 
        }
    }

}

