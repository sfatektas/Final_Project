using denemeBlazor.Services.Interfaces;

namespace denemeBlazor.Bussines.Dtos
{
    public class PostCreateDto : ICreateDto
    {
        public string Title { get; set; }

        public string Defination1 { get; set; }

        public string Defination2 { get; set; }

        public string MediaPath { get; set; }

        public int CategoryId { get; set; }

        public int AppUserId { get; set; }
    }
}
