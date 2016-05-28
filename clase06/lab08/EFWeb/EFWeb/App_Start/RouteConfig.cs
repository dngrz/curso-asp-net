using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EFWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ByDescription",
                url: "Busquedas/Directas/{description}",
                defaults: new
                {
                    controller = "Categories",
                    action = "DetailsByDescription"
                }
            );

            routes.MapRoute(
                name: "ByIdentifier",
                url: "Categorias/{id}",
                defaults: new
                {
                    controller = "Categories",
                    action = "Details"
                },
                constraints: new {
                    id = "[0-9]+"
                }
            );

            //Definiendo el Routing por defecto para la aplicacion
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Categories",
                    action = "Index",
                    id = UrlParameter.Optional }
            );
        }
    }
}
