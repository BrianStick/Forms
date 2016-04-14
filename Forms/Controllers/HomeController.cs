using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Models.Task> tasks = new List<Models.Task>()
                {
                    new Models.Task ("Brian", "finish assignment", false),
                    new Models.Task ("SETH", "finish assignment", true)
                };

            return View();
        }

        private ActionResult View(object task)
        {
            throw new NotImplementedException();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}