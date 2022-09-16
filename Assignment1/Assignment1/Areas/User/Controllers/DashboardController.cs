using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Areas.User.Controllers
{
    public class DashboardController : Controller
    {
        [Area("User")]
        [Route("User/[controller]/[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
