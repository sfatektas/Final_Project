using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Common;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace denemeBlazor.Controllers
{
    public class HomeController : Controller
    {
        readonly ICategoryService _categoryService;
        readonly IPostService _postService;

        public HomeController(ICategoryService categoryService, IPostService postService)
        {
            _categoryService = categoryService;
            _postService = postService;
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
    }
}
