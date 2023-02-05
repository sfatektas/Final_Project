using Microsoft.AspNetCore.Mvc.Rendering;

namespace MSS_NewsWeb.Models
{
    public class PostAddModel
    {
        public string Title { get; set; }

        public string Defination1 { get; set; }

        public string Defination2 { get; set; }

        public IFormFile MediaPathFile { get; set; }

        public SelectList CategorySelectList { get; set; }

        public int CategoryId { get; set; }

        public int AppUserId { get; set; }
    }
}
