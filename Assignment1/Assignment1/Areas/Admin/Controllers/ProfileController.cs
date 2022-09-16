using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
