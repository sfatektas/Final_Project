using denemeBlazor.Services.Interfaces;

namespace denemeBlazor.Bussines.Dtos
{
    public class CommentUpdateDto : CommentCreateDto, IUpdateDto
    {
        public int Id { get; set; }


    }
}
