using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IGN
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{tagName}",
                defaults: new { controller = "Home", action = "Index", tagName = UrlParameter.Optional }
            );


            routes.MapRoute(
                "Routingfa", // Route name
                "{controller}/{action}/{CategoryName}/{NewsID}/{Title}",  // URL with parameters
                defaults:  new { controller = "fa", action = "category" }
                );  // Parameter defaults);

            routes.MapRoute(
               "Routingen", // Route name
               "{controller}/{action}/{CategoryName}/{NewsID}/{Title}",  // URL with parameters
               defaults: new { controller = "en", action = "category" }
               );  // Parameter defaults);

            routes.MapRoute(
               "Routingen", // Route name
               "{controller}/{action}/{CategoryName}/{NewsID}/{Title}",  // URL with parameters
               defaults: new { controller = "ar", action = "category" }
               );  // Parameter defaults);



        }
    }
}
