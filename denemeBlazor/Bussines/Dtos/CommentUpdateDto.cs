using MSS_NewsWeb.Services.Interfaces;

namespace MSS_NewsWeb.Bussines.Dtos
{
    public class CommentUpdateDto : CommentCreateDto, IUpdateDto
    {
        public int Id { get; set; }


    }
}
