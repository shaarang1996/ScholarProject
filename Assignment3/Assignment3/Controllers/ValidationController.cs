using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnRegister(ValidationModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }
            else
            {
               return  RedirectToAction("Register");
            }
        }

        public IActionResult Message()
        {
            return View();
        }
    }
}
