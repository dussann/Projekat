using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebBookStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes.MapRoute(
            //    name: "Contact",
            //    url: "UserAccountModels",
            //    defaults: new { controller = "UserAccountModels", action = "Index" }
            //);

            //routes.MapRoute(
            //    name: "Default",
            //    url: "UserAccountModels/Test",
            //    defaults: new { controller = "UserAccountModels", action = "Test"}
            //);

            //routes.MapRoute(
            //    name: "Test1",
            //    url: "UserAccountModels/Test1/{pera}/{mika}",
            //    defaults: new { controller = "UserAccountModels", action = "Test1", pera = UrlParameter.Optional, mika = UrlParameter.Optional }
            //);

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Edit",
                url: "UserAccountModels/Edit/{idNumber}",
                defaults: new { controller = "UserAccountModels", action = "Edit", idNumber = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "UserAccountModels", action = "Index", id = UrlParameter.Optional }
            );           
        }
    }
}
