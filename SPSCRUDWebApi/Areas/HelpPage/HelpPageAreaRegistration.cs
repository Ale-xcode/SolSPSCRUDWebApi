using System.Web.Http;
using System.Web.Mvc;

namespace SPSCRUDWebApi.Areas.HelpPage
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible públicamente
    public class HelpPageAreaRegistration : AreaRegistration
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible públicamente
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible públicamente
        public override string AreaName
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible públicamente
        {
            get
            {
                return "HelpPage";
            }
        }

#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpPageAreaRegistration.RegisterArea(AreaRegistrationContext)'
        public override void RegisterArea(AreaRegistrationContext context)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'HelpPageAreaRegistration.RegisterArea(AreaRegistrationContext)'
        {
            context.MapRoute(
                "HelpPage_Default",
                "Help/{action}/{apiId}",
                new { controller = "Help", action = "Index", apiId = UrlParameter.Optional });

            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}