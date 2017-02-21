using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class SehirController : Controller
    {
        TseBackofficeContext context = new TseBackofficeContext();
        // GET: Sehir
        [ActionName("Tum-sehirler")]
        public ActionResult TumSehirler()
        {
            var sehir = context.Sehirler.ToList();
            return View(sehir);
        }

        [ActionName("yeni-sehir")]
        public ActionResult YeniSehir()
        {
            return View();
        }
    }
}