using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Assignment1.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(ArticleModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.comment != null)
                {
                    ViewBag.AddedComment = model.comment;
                }
                
                return View("Article");
            }
            else
                return View("Article");
        }
    }
}
