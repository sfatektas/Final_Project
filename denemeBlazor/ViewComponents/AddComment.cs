using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Data.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace denemeBlazor.ViewComponents
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

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new CommentCreateDto());
        }
    }
}
