//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.ViewEngines;
//using System.Xml.Linq;
//using Assignment1.Models;
//using AspNetCore;

namespace Assignment2.Component
{

    public class CommentViewComponent : ViewComponent
    {
        static List<string> comments = new List<string> {"First Comment" };
        public IViewComponentResult Invoke(string CommentNew)
        {
            if (CommentNew != null)
                comments.Add(new string(CommentNew));
            return View("~/views/component/_Comments.cshtml", comments);

        }
    }
}



