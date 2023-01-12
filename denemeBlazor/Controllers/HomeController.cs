using denemeBlazor.Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace denemeBlazor.Controllers
{
    public class HomeController : Controller
    {
        readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            //var response = await _categoryService.GetAllAsync();
            //if (response.ResponseType == Common.ResponseType.Success)
            //{
            //    return View(response.Data);
            //}
            //ViewBag.Message = response.Message;
            return View();
        }
    }
}
