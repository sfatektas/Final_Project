using denemeBlazor.Data.Entities;
using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Dtos
{
    public class PostListDto : IListDto
    {
        public int Id { get; set ; }

        public string Title { get; set; }

        public string Defination1 { get; set; }

        public string Defination2 { get; set; }

        public string MediaPath { get; set; }

        public CategoryListDto Category { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedTime { get; set; }

        public AppUserListDto AppUser { get; set; }

        public int AppUserId { get; set; }

        //

        public List<CommentListDto> Comments { get; set; }
    }
}
