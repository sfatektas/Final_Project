using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Bussines.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace denemeBlazor.ViewComponents
{
    public class GetCommands : ViewComponent
    {
        private readonly ICommentService _commentService;
        public GetCommands(ICommentService commentService)
        {
            _commentService = commentService;
        }
        
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var response =await _commentService.GetNewsAllCommantsWithPostId(id);
            return View(response.Data);
        }
    }
}
