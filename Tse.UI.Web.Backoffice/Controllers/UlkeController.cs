using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;
using Tse.UI.Web.Backoffice.Models;
using System;
using System.Net;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class UlkeController : Controller
    {

        TseBackofficeContext context = new TseBackofficeContext();

        // GET: Ulkeler        
        public ActionResult Listele()
        {
            var model = new UlkeViewModel();                                                        
            return View(model);                      
        }
        
        public ActionResult Ekle()
        {
            if(Session["Success"] == "1")
                ViewBag.Success = "";            
            else
                ViewBag.Success = "display-hide";

            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi");

            var model = new UlkeViewModel();

            return View(model);            
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle([Bind(Include = "UlkeID,UlkeAdi,DurumID")] Ulke ulke)
        {
            if (ModelState.IsValid)
            {
                context.Ulkeler.Add(ulke);
                context.SaveChanges();
                Session["Success"] = "1";
                return RedirectToAction("ekle");
            }
            
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", ulke.DurumID);
            return View(ulke);
        }

        public ActionResult Duzenle(int? id)
        {
            var model = new UlkeViewModel();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            model.Ulke = context.Ulkeler.Find(id);
            if (model.Ulke == null)
            {
                return HttpNotFound();
            }
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", model.Ulke.DurumID);
                     
            return View(model);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle([Bind(Include = "UlkeID,UlkeAdi,DurumID")] Ulke ulke)
        {            
            if (ModelState.IsValid)
            {
                context.Entry(ulke).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("listele");
            }
            ViewBag.DurumID = new SelectList(context.Durumlar, "DurumID", "DurumAdi", ulke.DurumID);
            return View(ulke);
        }

        [HttpPost]
        public ActionResult Sil(int? id)
        {
            if (id == null) {                  
                 return RedirectToAction("index", "hata", new { HataId=2});
            }   
                     
            Ulke ulke = context.Ulkeler.SingleOrDefault(u => u.UlkeID == id);

            if (ulke != null)
            {
                try
                {
                    context.Ulkeler.Remove(ulke);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    try
                    {
                        context.Ulkeler.Remove(ulke);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        try
                        {
                            ulke.DurumID = 4;
                            context.Entry(ulke).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {                            
                            return RedirectToAction("index", "hata", new { HataId=3});
                        }
                    }             
                }
            }
            return RedirectToAction("listele");
        }
    }
}