﻿
namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using System.Web.Mvc;
    using ViewModels;

    public class StandartAtifController : Controller
    {             
        public ActionResult Listele(int? kategoriID)
        {
            if (kategoriID != null)
            {
                var model = new StandartAtifListeleViewModel(kategoriID);
                if (model.Kategori == null)
                    return RedirectToAction("index", "hata", new { hataId = 2 });
                else
                    return View(model);
            }
            else
                return RedirectToAction("index", "hata", new { hataId = 2 });                        
        }

        //public ActionResult Ekle(int? kategoriID)
        //{
        //    if (kategoriID != null)
        //    {
        //        var model = new KategoriEkleViewModel(kategoriID);

        //        if (model.Kategori == null)
        //            return RedirectToAction("index", "hata", new { hataID = 3 });
        //        else
        //        {
        //            TempData["DisplayStatus"] = "display-hide";
        //            return View(model);
        //        }
        //    }
        //    else
        //        return RedirectToAction("index", "hata", new { hataID = 2 });
        //}

        //[HttpPost ValidateAntiForgeryToken]
        //public ActionResult Ekle([Bind(Include = "DegerID,KategoriID,DegerAdiTr,DegerAdiEn,SiraNo,DurumID")] Deger deger)
        //{
        //    using (TseBackofficeContext context = new TseBackofficeContext())
        //    {                
        //        var model = new KategoriEkleViewModel(deger.KategoriID);

        //        if (model.Kategori == null)
        //        {
        //            return RedirectToAction("index", "hata", new { hataID = 3 });
        //        }
        //        else
        //        { 
        //            if (ModelState.IsValid)
        //            {
        //                context.Degerler.Add(deger);
        //                context.SaveChanges();
        //                TempData["DisplayStatus"] = "";
        //                return View(model);
        //            }
        //            else
        //            {
        //                TempData["DisplayStatus"] = "display-hide";
        //                return View(model);
        //            }
        //        }
        //    }
        //}

        //public ActionResult Duzenle(int? kategoriID, int? degerID)
        //{
        //    if (kategoriID != null && degerID != null)
        //    {
        //        var model = new KategoriDuzenleViewModel(kategoriID, degerID);
        //        if (model.Kategori == null && model.Deger == null)
        //            return RedirectToAction("index", "hata", new { hataID = 3 });
        //        else
        //            TempData["DisplayStatus"] = "display-hide";
        //            return View(model);
        //    }
        //    else
        //        return RedirectToAction("index", "hata", new { hataID = 2 });            
        //}

        //[HttpPost ValidateAntiForgeryToken]
        //public ActionResult Duzenle([Bind(Include = "DegerID,KategoriID,DegerAdiTr,DegerAdiEn,SiraNo,DurumID")] Deger deger)
        //{
        //    using (TseBackofficeContext context = new TseBackofficeContext())
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            context.Entry(deger).State = EntityState.Modified;
        //            context.SaveChanges();
        //            return RedirectToAction("listele", new { kategoriID = deger.KategoriID});
        //        }
        //        return RedirectToAction("index", "hata", new { HataId = 3 });
        //    }
        //}

        //[HttpPost]
        //public ActionResult Sil(int? id)
        //{
        //    using (TseBackofficeContext context = new TseBackofficeContext())
        //    {
        //        if (id == null)
        //        {
        //            return RedirectToAction("index", "hata", new { HataId = 2 });
        //        }
        //        else
        //        {
        //            Deger deger = context.Degerler.Find(id);

        //            if (deger != null)
        //            {
        //                try
        //                {
        //                    context.Degerler.Remove(deger);
        //                    context.SaveChanges();
        //                    return RedirectToAction("listele", new { deger.KategoriID });
        //                }
        //                catch (Exception)
        //                {
        //                    try
        //                    {
        //                        deger.DurumID = 4;
        //                        context.Entry(deger).State = EntityState.Modified;
        //                        context.SaveChanges();
        //                        return RedirectToAction("listele", new { deger.KategoriID });
        //                    }
        //                    catch (Exception)
        //                    {
        //                        return RedirectToAction("index", "hata", new { HataId = 4 });
        //                    }
        //                }
        //            }
        //            return RedirectToAction("index", "hata", new { HataId = 2 });
        //        }                            
        //    }
        //}
    }
}