using MSS_NewsWeb.Data.Entities;
using MSS_NewsWeb.Services.Interfaces;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Dtos
{
    public class CommentCreateDto : ICreateDto
    {
        public int AppUserId { get; set; }

        public int PostId { get; set; }

        public string Content_ { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
