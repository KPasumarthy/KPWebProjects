using Microsoft.AspNetCore.Cors;
using System.Web.Http;
using System.Web.Http.Cors;
using EnableCorsAttribute = System.Web.Http.Cors.EnableCorsAttribute;

public static class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        // Configuración y servicios de API web  

        // Configuración para verificar la seguridad del CORS  
        // Fixing the issue by using the correct namespace and ensuring the EnableCors method is available  
        var cors = new EnableCorsAttribute("*", "*", "*");
        config.EnableCors(cors);

        // Rutas de API web  
        config.MapHttpAttributeRoutes();

        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );
    }
}
