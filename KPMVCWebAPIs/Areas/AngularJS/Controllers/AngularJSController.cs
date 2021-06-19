using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KPMVCWebAPIs.Areas.AngularJS.Controllers
{
    public class AngularJSController : Controller
    {
        //// GET: AngularJS/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: AngularJS/AngularJS
        public ActionResult AngularJS()
        {
            ViewBag.Message = "Your AngularJS.0 page.";

            return View();
        }

        // GET: AngularJS/HelloWorld
        public ActionResult HelloWorld()
        {
            ViewBag.Message = "Your AngularJS.0 Hello World page.";

            return View();
        }

        // GET: AngularJS/HelloAngular
        public ActionResult HelloAngular()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular page.";
            return View();
        }



        // GET: AngularJS/AngularServices
        public ActionResult AngularDOM()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular DOM.";
            return View();
        }

        // GET: AngularJS/AngularEvents
        public ActionResult AngularEvents()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular Events.";
            return View();
        }

        // GET: AngularJS/AngularForms
        public ActionResult AngularForms()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular Forms.";
            return View();
        }


        // GET: AngularJS/AngularForms
        public ActionResult AngularJQuerySpin()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular JQuery Spin.";
            return View();
        }


        // GET: AngularJS/AngularModules
        public ActionResult AngularModules()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular Modules.";
            return View();
        }

        // GET: AngularJS/AngularScopes
        public ActionResult AngularScopes()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular Scopes & Controllers.";
            return View();
        }

        // GET: AngularJS/AngularServices
        public ActionResult AngularServices()
        {
            ViewBag.Message = "Your AngularJS.0 Hello Angular Services.";
            return View();
        }
    }
}