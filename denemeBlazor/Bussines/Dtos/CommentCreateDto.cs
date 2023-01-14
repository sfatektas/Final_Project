using denemeBlazor.Data.Entities;
using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Dtos
{
    public class CommentCreateDto : ICreateDto
    {
        public int AppUserId { get; set; }

        public int PostId { get; set; }

        public string Content_ { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
