using denemeBlazor.Data.Entities;
using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Dtos
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
