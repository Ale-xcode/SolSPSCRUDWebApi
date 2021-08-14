using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPSCRUDWebApi.Controllers
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HomeController'
    public class HomeController : Controller
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HomeController'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HomeController.Index()'
        public ActionResult Index()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HomeController.Index()'
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
