using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Common.Interfaces;
using MSS_NewsWeb.Services.Interfaces;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Interfaces
{
    public interface ICommentService : IService<CommentCreateDto, CommentListDto, CommentUpdateDto, Comment>, IQueryable<CommentListDto>
    {
        Task<IResponse<List<CommentListDto>>> GetNewsAllCommantsWithPostId(int id);
        
    }
}
