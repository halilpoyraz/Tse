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
    // GET: Sehir
    public class IlceController : Controller
    {
        TseBackofficeContext context = new TseBackofficeContext();

        public ActionResult Listele()
        {
            var model = context.Ilceler.Include(u => u.Durum).ToList();
            ViewBag.TumCount = context.Ilceler.Count();
            ViewBag.AktifCount = context.Ilceler.Where(u => u.DurumID == 1).Count();
            ViewBag.PasifCount = context.Ilceler.Where(u => u.DurumID == 2).Count();
            ViewBag.TaslakCount = context.Ilceler.Where(u => u.DurumID == 3).Count();
            ViewBag.SilinmisCount = context.Ilceler.Where(u => u.DurumID == 4).Count();
            return View(model);
        }

        public ActionResult Ekle()
        {
            if (Session["Success"] == "1")
                ViewBag.Success = "";
            else
                ViewBag.Success = "display-hide";
            ViewBag.SehirID = new SelectList(context.Sehirler, "SehirID", "SehirAdi");
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi");
            return View();
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle([Bind(Include = "IlceID,SehirID,IlceKodu,IlceAdi,DurumID")] Ilce ilce)
        {
            if (ModelState.IsValid)
            {
                context.Ilceler.Add(ilce);
                context.SaveChanges();
                Session["Success"] = "1";
                return RedirectToAction("ekle");
            }
            ViewBag.SehirID = new SelectList(context.Ulkeler, "SehirID", "SehirAdi", ilce.DurumID);
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", ilce.DurumID);
            return View(ilce);
        }

        public ActionResult Duzenle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ilce ilce = context.Ilceler.Find(id);
            if (ilce == null)
            {
                return HttpNotFound();
            }
            ViewBag.SehirID = new SelectList(context.Sehirler, "SehirID", "SehirAdi", ilce.SehirID);
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", ilce.DurumID);
            return View(ilce);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle([Bind(Include = "IlceID,IlceAdi,SehirID,IlceKodu,DurumID")] Ilce ilce)
        {
            if (ModelState.IsValid)
            {
                context.Entry(ilce).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("listele");
            }
            ViewBag.SehirID = new SelectList(context.Sehirler, "SehirID", "SehirAdi", ilce.SehirID);
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", ilce.DurumID);
            return View(ilce);
        }

        [HttpPost]
        public ActionResult Sil(int? id)
        {
            if (id == null)
            {
                Session["HataId"] = 1;
                return RedirectToAction("index", "hata");
            }

            Ilce ilce = context.Ilceler.SingleOrDefault(u => u.IlceID == id);

            if (ilce != null)
            {
                try
                {
                    context.Ilceler.Remove(ilce);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    try
                    {
                        context.Ilceler.Remove(ilce);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        try
                        {
                            ilce.DurumID = 4;
                            context.Entry(ilce).State = EntityState.Modified;
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