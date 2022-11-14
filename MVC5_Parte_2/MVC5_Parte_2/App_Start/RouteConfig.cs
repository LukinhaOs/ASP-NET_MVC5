using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5_Parte_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Noticías",
                url: "noticias/",
                defaults: new { controller = "Home", action = "TodasAsNoticias" }
                );

            routes.MapRoute(
                name: "Categoria",
                url: "noticias/{categoria}",
                defaults: new { controller = "Home", action = "MostraCategoria" }
                );

            routes.MapRoute(
                name: "Mostra Titutlo",
                url: "noticias/{categoria}/{titulo}-{noticiaId}",
                defaults: new { controller = "Home", action = "MostraNoticia" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
