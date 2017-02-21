using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class UlkeController : Controller
    {
        TseBackofficeContext context = new TseBackofficeContext();
        // GET: Ulkeler
        [ActionName("tum-ulkeler")]
        public ActionResult TumUlkeler()
        {
           List<Ulke> ulke = context.Ulkeler.ToList();
           return View(ulke);
        }

        [ActionName("yeni-ulke")]
        public ActionResult YeniUlke()
        {
            return View();
        }
    }
}