using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tse.UI.Web.Backoffice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");           

            routes.MapRoute(
                  name: "StandartController",
                  url: "standart/{action}",
                  defaults: new
                  {
                      controller = "standart",
                      action = "listele"
                  }
            );

            routes.MapRoute(
                  name: "KisiController",
                  url: "kisi/{action}",
                  defaults: new
                  {
                      controller = "kisi",
                      action = "listele"
                  }
            );

            routes.MapRoute(
                  name: "IlceController",
                  url: "ilce/{action}",
                  defaults: new
                  {
                      controller = "ilce",
                      action = "listele"
                  }
            );

            routes.MapRoute(
                  name: "SehirController",
                  url: "sehir/{action}",
                  defaults: new
                  {
                      controller = "sehir",
                      action = "listele"
                  }
            );

            routes.MapRoute(
                  name: "UlkeController",
                  url: "ulke/{action}",
                  defaults: new
                  {
                      controller = "ulke",
                      action = "listele"
                  }
            );

            routes.MapRoute(
              name: "Hata",
              url: "hata/{action}/{id}",
              defaults: new { controller = "hata", action = "index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "baslangic", action = "gosterge-paneli", id = UrlParameter.Optional }
            );
        }
    }
}
