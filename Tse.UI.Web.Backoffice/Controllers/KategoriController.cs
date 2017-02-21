using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        [ActionName("dokuman-tipi")]
        public ActionResult DokumanTipi()
        {
            return View();
        }

        [ActionName("hazirlik-grubu")]
        public ActionResult HazirlikGrubu()
        {
            return View();
        }

        [ActionName("yururluk-durumu")]
        public ActionResult YururlukDurumu()
        {
            return View();
        }

        [ActionName("standart-tur")]
        public ActionResult StandartTur()
        {
            return View();
        }

        [ActionName("standart-icerik-tipi")]
        public ActionResult StandartIcerikTipi()
        {
            return View();
        }

        [ActionName("atif-yapilan-standart-tipi")]
        public ActionResult AtifYapilanStandartTipi()
        {
            return View();
        }

        [ActionName("atif-yapilan-dokuman-tipi")]
        public ActionResult AtifYapilanDokumanTipi()
        {
            return View();
        }
    }
}