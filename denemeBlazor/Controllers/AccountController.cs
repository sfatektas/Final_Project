using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MSS_NewsWeb.Common;

namespace MSS_NewsWeb.Controllers
{
    public class AccountController : Controller
    {
        readonly IAppUserService _appUserService;

        public AccountController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _appUserService.GetAllQueryable();
                var data = response.Data.Where(x => x.Username == model.Username && x.Password == model.Password).SingleOrDefault();
                if (data != null)
                {

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, data.Id.ToString()),
                        new Claim(ClaimTypes.Name, data.FirstName),
                        new Claim(ClaimTypes.Role, data.AppRole.Defination),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        // Refreshing the authentication session should be allowed.

                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(20),

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);
                    if (data.AppRole.Id == (int)RoleType.Admin)
                    {
                        return Redirect("/admin/posts");
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Yanlış");
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(
    CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
        public IActionResult Denied()
        {
            return View();
        }
    }
}
