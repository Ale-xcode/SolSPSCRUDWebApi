using System.Web;
using System.Web.Mvc;

namespace SPSCRUDWebApi
{
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'FilterConfig'
    public class FilterConfig
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'FilterConfig'
    {
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'FilterConfig.RegisterGlobalFilters(GlobalFilterCollection)'
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
#pragma warning restore CS1591 // Falta el comentario XML para el tipo o miembro visible de forma pública 'FilterConfig.RegisterGlobalFilters(GlobalFilterCollection)'
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
