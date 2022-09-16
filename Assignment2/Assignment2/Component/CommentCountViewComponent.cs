using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Assignment2.Component
{
    public class CommentCountViewComponent: ViewComponent
    {
        static int counts = 0;
        public IViewComponentResult Invoke(int ComCount)
        {
            counts++;
            return View("~/views/component/_CommentsCounter.cshtml", counts);
        }

    }
}
