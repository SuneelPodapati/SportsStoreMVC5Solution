using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStoreMVC5WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //http://localhost:4265/Page1or2or3
            routes.MapRoute("page", "Page{page}", new { controller = "Product", action = "List", category = (string)null }, new { page = @"\d+" });
            
            //http://localhost:4265/Basketball/Page1
            routes.MapRoute("categorypage", "{category}/Page{page}", new { controller = "Product", action = "List" }, new { page = @"\d+" });

            //http://localhost:4265/Basketball
            routes.MapRoute("category", "{category}", new { controller = "Product", action = "List", page = 1 });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
            );



            #region First
            //routes.MapRoute("page", "Page{page}", new { controller = "Product", action = "List" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
            //); 
            #endregion

            #region Default
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //); 
            #endregion
        }
    }
}
