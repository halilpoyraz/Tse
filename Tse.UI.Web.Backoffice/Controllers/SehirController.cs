using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;
using Tse.UI.Web.Backoffice.Models;
using System.Net;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class SehirController : Controller
    {
        // GET: Sehir
        TseBackofficeContext context = new TseBackofficeContext();
                 
        public ActionResult Listele()
        {
            var model = context.Sehirler.Include(u => u.Durum).ToList();
            ViewBag.TumCount = context.Sehirler.Count();
            ViewBag.AktifCount = context.Sehirler.Where(u => u.DurumID == 1).Count();
            ViewBag.PasifCount = context.Sehirler.Where(u => u.DurumID == 2).Count();
            ViewBag.TaslakCount = context.Sehirler.Where(u => u.DurumID == 3).Count();
            ViewBag.SilinmisCount = context.Sehirler.Where(u => u.DurumID == 4).Count();
            return View(model);
        }

        public ActionResult Ekle()
        {
            if (Session["Success"] == "1")
                ViewBag.Success = "";
            else
                ViewBag.Success = "display-hide";
            ViewBag.UlkeID = new SelectList(context.Ulkeler, "UlkeID", "UlkeAdi");
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi");
            return View();
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle([Bind(Include = "SehirID,UlkeID,SehirAdi,DurumID")] Sehir sehir)
        {
            if (ModelState.IsValid)
            {
                context.Sehirler.Add(sehir);
                context.SaveChanges();
                Session["Success"] = "1";
                return RedirectToAction("ekle");
            }
            ViewBag.DurumID = new SelectList(context.Ulkeler, "UlkeID", "UlkeAdi", sehir.DurumID);
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", sehir.DurumID);
            return View(sehir);
        }

        public ActionResult Duzenle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sehir sehir = context.Sehirler.Find(id);
            if (sehir == null)
            {
                return HttpNotFound();
            }
            ViewBag.UlkeID = new SelectList(context.Ulkeler, "UlkeID", "UlkeAdi", sehir.UlkeID);
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", sehir.DurumID);
            return View(sehir);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle([Bind(Include = "SehirID,SehirAdi,UlkeID,DurumID")] Sehir sehir)
        {
            if (ModelState.IsValid)
            {
                context.Entry(sehir).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("listele");
            }
            ViewBag.UlkeID = new SelectList(context.Ulkeler, "UlkeID", "UlkeAdi", sehir.UlkeID);
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", sehir.DurumID);
            return View(sehir);
        }

        [HttpPost]
        public ActionResult Sil(int? id)
        {
            if (id == null)
            {
                Session["HataId"] = 1;
                return RedirectToAction("index", "hata");
            }

            Sehir sehir = context.Sehirler.SingleOrDefault(u => u.SehirID == id);

            if (sehir != null)
            {
                try
                {
                    context.Sehirler.Remove(sehir);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    try
                    {
                        context.Sehirler.Remove(sehir);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        try
                        {
                            sehir.DurumID = 4;
                            context.Entry(sehir).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            Session["HataId"] = 2;
                            return RedirectToAction("index", "hata");
                        }
                    }
                }
            }
            return RedirectToAction("listele");
        }
    }
}