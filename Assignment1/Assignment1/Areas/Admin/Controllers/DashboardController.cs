using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[controller]/[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
