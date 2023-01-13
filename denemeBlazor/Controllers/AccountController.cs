using Microsoft.AspNetCore.Mvc;

namespace denemeBlazor.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
