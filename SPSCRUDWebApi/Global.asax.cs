using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SPSCRUDWebApi
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'WebApiApplication'
    public class WebApiApplication : System.Web.HttpApplication
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'WebApiApplication'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'WebApiApplication.Application_Start()'
        protected void Application_Start()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'WebApiApplication.Application_Start()'
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
