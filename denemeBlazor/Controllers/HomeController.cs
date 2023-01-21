using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Common;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace denemeBlazor.Controllers
{
    public class HomeController : Controller
    {
        readonly IPostService _postService;
        readonly ICommentService _commentService;
        readonly IValidator<CommentCreateDto> _validator;

        public HomeController( IPostService postService, IValidator<CommentCreateDto> createDtoValidator, ICommentService commentService)
        {
            _postService = postService;
            _validator = createDtoValidator;
            _commentService = commentService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _postService.GetAllAsync();
            if (response.ResponseType == ResponseType.Success)
            {
                return View(response.Data);
            }
            return View(response.Message) ;
        }
        [HttpGet("[controller]/Pages/{id}")] //Restful Api syntaxı ile ana ekrana ilgili post geliyor.

        public async Task<IActionResult> Page(int id)
        {
            var response =await _postService.GetQueryable(id);
            if(response.ResponseType == ResponseType.Success)
            {
                return View(response.Data);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CommentAdd(CommentCreateDto commentCreateDto)
        {
            
            var result = _validator.Validate(commentCreateDto);
            
            if (result.IsValid)
            {
                var response = await _commentService.CreateAsync(commentCreateDto);
                if(response.ResponseType == ResponseType.Success)
                {
                    return Redirect($"/Home/Page/{commentCreateDto.PostId}");
                }
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.ErrorCode, error.ErrorMessage);
            }
            return RedirectToAction("Page", "Home");
        }
    }
}
