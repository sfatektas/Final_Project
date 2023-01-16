using Microsoft.AspNetCore.Razor.TagHelpers;

namespace denemeBlazor.TagHelpers
{
    [HtmlTargetElement("bolderTagHelper")]
    public class StrongTagHelper : TagHelper
    {
        public string kullaniciAdi { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent($"<b>{kullaniciAdi}<b>"); 
        }
    }

}

