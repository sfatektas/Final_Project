using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Common;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace MSS_NewsWeb.Controllers
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
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CommentAdd(CommentCreateDto commentCreateDto)
        {
            
            var result = _validator.Validate(commentCreateDto);
            
            if (result.IsValid)
            {
                var response = await _commentService.CreateAsync(commentCreateDto);
                if(response.ResponseType == ResponseType.Error)
                {
                    foreach (var error in response.ValidationErrors)
                    {
                        ModelState.AddModelError(error.ErrorCode, error.ErrorMessage);
                    }
                }
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.ErrorCode, error.ErrorMessage);
            }
            return Redirect($"/Home/Pages/{commentCreateDto.PostId}");
        }
    }
}
