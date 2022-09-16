using Assignment1.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Areas.Admin.Controllers
{
   
    public class LoginController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Login()
        {
            return View();
        }
 
        [HttpPost]
        public IActionResult OnLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard", "Dashboard", new {area = "Admin"});
            }
            return RedirectToAction("Login", "Login", new { area = "Admin" });
        }
    }
}
