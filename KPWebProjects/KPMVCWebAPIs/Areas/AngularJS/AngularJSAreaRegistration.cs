using System.Web.Mvc;

namespace KPMVCWebAPIs.Areas.AngularJS
{
    public class AngularJS4AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AngularJS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AngularJS4_Index",
                "AngularJS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
                    "AngularJS4_default",
                    "AngularJS/{controller}/{action}/{id}",
                    new { action = "AngularJS", id = UrlParameter.Optional }
                );
            context.MapRoute(
                    "AngularJS4_HelloWorld",
                    "AngularJS/{controller}/{action}/{id}",
                    new { action = "HelloWorld", id = UrlParameter.Optional }
                );
            context.MapRoute(
                    "AngularJS4_HelloAngular",
                    "AngularJS/{controller}/{action}/{id}",
                    new { action = "HelloAngular", id = UrlParameter.Optional }
                );
        }
    }
}