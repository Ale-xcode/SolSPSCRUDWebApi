using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SPSCRUDWebApi
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'RouteConfig'
    public class RouteConfig
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'RouteConfig'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'RouteConfig.RegisterRoutes(RouteCollection)'
        public static void RegisterRoutes(RouteCollection routes)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'RouteConfig.RegisterRoutes(RouteCollection)'
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Emp", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
