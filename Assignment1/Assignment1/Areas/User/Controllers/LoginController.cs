using Assignment1.Areas.User.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Areas.User.Controllers
{
   
    public class LoginController : Controller
    {
        [Area("User")]
        [Route("User/[controller]/[action]")]
        public IActionResult Login()
        {
            return View();
        }
 
        [HttpPost]
        public IActionResult OnUserLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard", "Dashboard", new {area = "User"});
            }
            return RedirectToAction("Login", "Login", new { area = "User" });
        }
    }
}
