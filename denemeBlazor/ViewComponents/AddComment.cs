using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Data.Interfaces;
using MSS_NewsWeb.Helpers;
using MSS_NewsWeb.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace MSS_NewsWeb.ViewComponents
{
    public class AddComment : ViewComponent
    {
        private readonly ICommentService _commentService;

        private readonly IValidator<CommentCreateDto> _createDtoValidator;

        public AddComment(ICommentService commentService, IValidator<CommentCreateDto> createDtoValidator)
        {
            _commentService = commentService;
            _createDtoValidator = createDtoValidator;
        }

        public async Task<IViewComponentResult> InvokeAsync(Temp Model)
        {

            return View(new CommentCreateDto() { PostId = Model.PostId, AppUserId=Model.UserId});
        }
    }
}
