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
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Home", action = "Index", name = UrlParameter.Optional }
            );



          //  routes.MapRoute(
          //    name: "Defausdasdsa",
          //    url: "{controller}/{action}/{name}",
          //    defaults: new { controller = "Page", action = "Page", name = UrlParameter.Optional }
          //);


            //routes.MapRoute(
            //    "Default12313123213",
            //    "{controller}/{action}/{Cname}",
            //   defaults: new { controller = "fa", action = "Cat" , Cname  ="" }
            //);


            routes.MapRoute(
              "Routing01", // Route name
              "{controller}/{action}/{name}/{id1}/{id2}",  // URL with parameters
              defaults: new { controller = "Agahi", action = "جستجو" , name = "" , id1 = UrlParameter.Optional , id2 = UrlParameter.Optional }
              );


      





            //routes.MapRoute(
            //    "Routingads", // Route name
            //    "{controller}/{action}/{CategoryName}/{NewsID}/{Title}",  // URL with parameters
            //    defaults:  new { controller = "Khabar", action = "خبر" }
            //    );  // Parameter defaults);

       


        }
    }
}
