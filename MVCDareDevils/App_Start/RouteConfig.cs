using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDareDevils
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("new/MYSimpleDay1");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default1",
                url: "PistaHouse/Bakery",
                defaults: new { controller = "New", action = "helloWorld", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );
        }
    }
}
