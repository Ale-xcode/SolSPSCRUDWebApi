using System;
using System.Web.Http;
using System.Web.Mvc;
using SPSCRUDWebApi.Areas.HelpPage.ModelDescriptions;
using SPSCRUDWebApi.Areas.HelpPage.Models;

namespace SPSCRUDWebApi.Areas.HelpPage.Controllers
{
    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class HelpController : Controller
    {
        private const string ErrorViewName = "Error";

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible públicamente
        public HelpController()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible públicamente
            : this(GlobalConfiguration.Configuration)
        {
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.HelpController(HttpConfiguration)'
        public HelpController(HttpConfiguration config)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.HelpController(HttpConfiguration)'
        {
            Configuration = config;
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.Configuration'
        public HttpConfiguration Configuration { get; private set; }
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.Configuration'

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.Index()'
        public ActionResult Index()
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.Index()'
        {
            ViewBag.DocumentationProvider = Configuration.Services.GetDocumentationProvider();
            return View(Configuration.Services.GetApiExplorer().ApiDescriptions);
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.Api(string)'
        public ActionResult Api(string apiId)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.Api(string)'
        {
            if (!String.IsNullOrEmpty(apiId))
            {
                HelpPageApiModel apiModel = Configuration.GetHelpPageApiModel(apiId);
                if (apiModel != null)
                {
                    return View(apiModel);
                }
            }

            return View(ErrorViewName);
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.ResourceModel(string)'
        public ActionResult ResourceModel(string modelName)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpController.ResourceModel(string)'
        {
            if (!String.IsNullOrEmpty(modelName))
            {
                ModelDescriptionGenerator modelDescriptionGenerator = Configuration.GetModelDescriptionGenerator();
                ModelDescription modelDescription;
                if (modelDescriptionGenerator.GeneratedModels.TryGetValue(modelName, out modelDescription))
                {
                    return View(modelDescription);
                }
            }

            return View(ErrorViewName);
        }
    }
}