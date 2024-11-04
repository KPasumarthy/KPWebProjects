using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KPMVCWebAPIs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult AngularJS()
        {
            ViewBag.Message = "Your AngularJS.0 page.";

            return View();
        }

        public ActionResult Demo()
        {
            ViewBag.Message = "Your AngularJS.0 page.";

            return View();
        }


    }
}
