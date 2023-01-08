using Microsoft.AspNetCore.Mvc;

namespace denemeBlazor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
