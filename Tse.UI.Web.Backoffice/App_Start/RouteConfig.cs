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
                name: "AtifYapilanDokumanTipi",
                url: "kategoriler/{action}",
                defaults: new
                {
                    controller = "Kategori",
                    action = "atif-yapilan-dokuman-tipi"
                }
            );

            routes.MapRoute(
                name: "StandartIcerikTipi",
                url: "kategoriler/{action}",
                defaults: new
                {
                    controller = "Kategori",
                    action = "standart-icerik-tipi"
                }
            );

            routes.MapRoute(
                 name: "StandartTur",
                 url: "kategoriler/{action}",
                 defaults: new
                 {
                     controller = "Kategori",
                     action = "standart-tur"
                 }
            );

            routes.MapRoute(
                 name: "YururlukDurumu",
                 url: "kategoriler/{action}",
                 defaults: new
                 {
                     controller = "Kategori",
                     action = "yururluk-durumu"
                 }
            );

            routes.MapRoute(
                 name: "HazirlikGrubu",
                 url: "kategoriler/{action}",
                 defaults: new
                 {
                     controller = "Kategori",
                     action = "hazirlik-grubu"
                 }
            );

            routes.MapRoute(
                  name: "DokumanTipi",
                  url: "kategoriler/{action}",
                  defaults: new
                  {
                      controller = "Kategori",
                      action = "dokuman-tipi"
                  }
            );

            routes.MapRoute(
                  name: "StandartController",
                  url: "standartlar/{action}",
                  defaults: new
                  {
                      controller = "Standart",
                      action = "tum-standartlar"
                  }
            );

            routes.MapRoute(
                  name: "KisiController",
                  url: "kisiler/{action}",
                  defaults: new
                  {
                      controller = "Kisi",
                      action = "tum-kisiler"
                  }
            );

            routes.MapRoute(
                  name: "IlceController",
                  url: "ilceler/{action}",
                  defaults: new
                  {
                      controller = "Ilce",
                      action = "tum-ilceler"
                  }
            );

            routes.MapRoute(
                  name: "SehirController",
                  url: "sehirler/{action}",
                  defaults: new
                  {
                      controller = "Sehir",
                      action = "tum-sehirler"
                  }
            );

            routes.MapRoute(
                  name: "UlkeController",
                  url: "ulkeler/{action}",
                  defaults: new
                  {
                      controller = "Ulke",
                      action = "tum-ulkeler"
                  }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "baslangic", action = "gosterge-paneli", id = UrlParameter.Optional }
            );
        }
    }
}
