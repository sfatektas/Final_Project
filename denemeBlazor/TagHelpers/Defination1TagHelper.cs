using Microsoft.AspNetCore.Razor.TagHelpers;

namespace denemeBlazor.TagHelpers
{
    [HtmlTargetElement("Definitaion1")]
    public class Defination1TagHelper : TagHelper
    {
        public string defData { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent($"<h5 class='font-normal'>{defData}</h5>");
        }
    }
}
