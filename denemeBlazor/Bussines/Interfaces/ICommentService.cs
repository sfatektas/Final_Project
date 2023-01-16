using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Interfaces
{
    public interface ICommentService : IService<CommentCreateDto,CommentListDto,CommentUpdateDto,Comment> , IQueryable<CommentListDto>
    {
    }
}
