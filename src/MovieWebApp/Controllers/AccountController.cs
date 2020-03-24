using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Models;
using MovieWebApp.Services;

namespace MovieWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Account account, [FromServices] AccountService service)
        {
            if (!ModelState.IsValid)
                return View(account);

            var result = service.Login("v1/account/login", account);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(account);
            }

            return RedirectToAction("Index", "Movie");
        }
    }
}