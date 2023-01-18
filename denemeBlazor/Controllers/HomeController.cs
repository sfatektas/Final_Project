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
        readonly ICategoryService _categoryService;
        readonly IPostService _postService;
        readonly ICommentService _commentService;
        readonly IValidator<CommentCreateDto> _validator;

        public HomeController(ICategoryService categoryService, IPostService postService, IValidator<CommentCreateDto> createDtoValidator, ICommentService commentService)
        {
            _categoryService = categoryService;
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
            //var response = await _categoryService.GetAllAsync();
            //if (response.ResponseType == Common.ResponseType.Success)
            //{
            //    return View(response.Data);
            //}
            //ViewBag.Message = response.Message;
            return View(response.Message) ;
        }
        public IActionResult Page()
        {
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
                    ViewBag.message = "İşlem Başarılı";
                    return RedirectToAction("Page", "Home");
                }
            }
            return RedirectToAction("Page", "Home");
        }
    }
}
