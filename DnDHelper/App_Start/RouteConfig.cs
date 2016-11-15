using System.Web.Mvc;
using System.Web.Routing;

namespace DnDHelper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Home",
               url: "Home/{action}/{id}",
               defaults: new { controller = "Character", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Character", action = "Index", id = UrlParameter.Optional }
            );            
        }
    }
}
