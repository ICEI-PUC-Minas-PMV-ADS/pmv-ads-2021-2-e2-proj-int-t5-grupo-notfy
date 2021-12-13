using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Notfy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Notificador",
                url: "Notificador",
                defaults: new { controller = "NotificadorsController", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Notificando",
               url: "Notificando",
               defaults: new { controller = "NotificadoesController", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Notificacao",
               url: "Notificacao",
               defaults: new { controller = "NotificacaosController", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
