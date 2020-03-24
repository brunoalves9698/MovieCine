using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Models;
using MovieWebApp.Services;

namespace MovieWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(User user, [FromServices] UserService service)
        {
            var result = service.Signup("v1/users", user);
            if (!result.Success)
            {
                ModelState.AddModelError("", result.Message);
                return View(user);
            }

            return RedirectToAction("Login", "Account");
        }
    }
}