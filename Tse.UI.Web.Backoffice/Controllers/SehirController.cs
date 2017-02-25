using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;
using Tse.UI.Web.Backoffice.Models;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class SehirController : Controller
    {
        // GET: Sehir
        [ActionName("Tum-sehirler")]
        public ActionResult TumSehirler()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = context.Sehirler.Include(u => u.Ulke)
                                            .Include(u => u.Durum).ToList();
                return View(model);
            }
        }

        [ActionName("yeni-sehir-ekle")]
        public ActionResult YeniSehirEkle()
        {
            SehirViewModel model = new SehirViewModel();
            return View(model);
        }

        [HttpPost ActionName("yeni-sehir-ekle")]
        public ActionResult YeniSehirEkle(Sehir seh)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Sehirler.Add(seh);
                context.SaveChanges();
                return RedirectToAction("yeni-sehir-ekle");
            }
        }
    }
}