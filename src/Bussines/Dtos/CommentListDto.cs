using MSS_NewsWeb.Data.Entities;
using MSS_NewsWeb.Services.Interfaces;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Dtos
{
    public class CommentListDto : IListDto
    {
        public int Id { get ; set; }

        public AppUserListDto AppUser { get; set; }

        public int AppUserId { get; set; }

        public PostListDto Post { get; set; }

        public int PostId { get; set; }

        public string Content_ { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
