using Microsoft.AspNetCore.Razor.TagHelpers;
using static System.Net.Mime.MediaTypeNames;

namespace MSS_NewsWeb.TagHelpers
{
    [HtmlTargetElement("Definitaion1")]
    public class Defination1TagHelper : TagHelper
    {
        public string defData { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent("<p class= "+ "text-lg font-bold" + $">{defData}</p>");

        }
    }
}
