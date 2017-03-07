namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using System.Web.Mvc;
    using ViewModels;

    public class KategoriController : Controller
    {             
        public ActionResult Listele(int? kategoriID)
        {
            if (kategoriID != null)
            {               
                var model = new KategoriListeleViewModel(kategoriID);
                if (model.Kategori == null)
                    return RedirectToAction("index", "hata", new { hataId = 2 });
                else
                    return View(model);                
            }
            else
                return RedirectToAction("index", "hata", new { hataId = 2 });                        
        }

        public ActionResult Ekle(int? kategoriID)
        {
            if (kategoriID != null)
            {
                var model = new KategoriEkleViewModel(kategoriID);

                if (model.Kategori == null)
                    return RedirectToAction("index", "hata", new { hataID = 3 });
                else
                {
                    TempData["DisplayStatus"] = "display-hide";
                    return View(model);
                }
            }
            else
                return RedirectToAction("index", "hata", new { hataID = 2 });
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle([Bind(Include = "DegerID,KategoriID,DegerAdiTr,DegerAdiEn,SiraNo,DurumID")] Deger deger)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {                
                var model = new KategoriEkleViewModel(deger.KategoriID);

                if (model.Kategori == null)
                {
                    return RedirectToAction("index", "hata", new { hataID = 3 });
                }
                else
                { 
                    if (ModelState.IsValid)
                    {
                        context.Degerler.Add(deger);
                        context.SaveChanges();
                        TempData["DisplayStatus"] = "";
                        return View(model);
                    }
                    else
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                }
            }
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle2([Bind(Include = "StandartAtifTipiSablonID,KategoriID,Deger1,Deger2,Deger3,Deger4,DurumID")] StandartAtifTipiSablon StandartAtifTipiSablon)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = new KategoriEkleViewModel(StandartAtifTipiSablon.KategoriID);

                if (model.Kategori == null)
                {
                    return RedirectToAction("index", "hata", new { hataID = 3 });
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        context.StandartAtifTipiSablonlar.Add(StandartAtifTipiSablon);
                        context.SaveChanges();
                        TempData["DisplayStatus"] = "";
                        return View("ekle",model);
                    }
                    else
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View("ekle",model);
                    }
                }
            }
        }

        public ActionResult Duzenle(int? kategoriID, int? degerID)
        {
            if (kategoriID != null && degerID != null)
            {
                var model = new KategoriDuzenleViewModel(kategoriID, degerID);
                if (model.Kategori == null && model.Deger == null)
                    return RedirectToAction("index", "hata", new { hataID = 3 });
                else
                    TempData["DisplayStatus"] = "display-hide";
                    return View(model);
            }
            else
                return RedirectToAction("index", "hata", new { hataID = 2 });            
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle([Bind(Include = "DegerID,KategoriID,DegerAdiTr,DegerAdiEn,SiraNo,DurumID")] Deger deger)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Entry(deger).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("listele", new { kategoriID = deger.KategoriID});
                }
                return RedirectToAction("index", "hata", new { HataId = 3 });
            }
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle2([Bind(Include = "StandartAtifTipiSablonID,KategoriID,Deger1,Deger2,Deger3,Deger4,DurumID")] StandartAtifTipiSablon StandartAtifTipiSablon)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Entry(StandartAtifTipiSablon).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("listele", new { kategoriID = StandartAtifTipiSablon.KategoriID });
                }
                return RedirectToAction("index", "hata", new { HataId = 3 });
            }
        }

        [HttpPost]
        public ActionResult Sil(int? id, int? kategoriID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (kategoriID==null)
                {
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                }

                if (id == null)
                {
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                }
                else
                {
                    if (kategoriID==8 || kategoriID==9) //atıf silme
                    {
                        StandartAtifTipiSablon atif = context.StandartAtifTipiSablonlar.Find(id);
                        if (atif != null)
                        {
                            try
                            {
                                context.StandartAtifTipiSablonlar.Remove(atif);
                                context.SaveChanges();
                                return RedirectToAction("listele", new { kategoriID });
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    atif.DurumID = 4;
                                    context.Entry(atif).State = EntityState.Modified;
                                    context.SaveChanges();
                                    return RedirectToAction("listele", new { kategoriID });
                                }
                                catch (Exception)
                                {
                                    return RedirectToAction("index", "hata", new { HataId = 4 });
                                }
                            }
                        }

                        return RedirectToAction("listele", new { kategoriID });
                    }

                    else // Değer silme
                    {         
                        Deger deger = context.Degerler.Find(id);
                        if (deger != null)
                        {
                            try
                            {
                                context.Degerler.Remove(deger);
                                context.SaveChanges();
                                return RedirectToAction("listele", new { deger.KategoriID });
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    deger.DurumID = 4;
                                    context.Entry(deger).State = EntityState.Modified;
                                    context.SaveChanges();
                                    return RedirectToAction("listele", new { deger.KategoriID });
                                }
                                catch (Exception)
                                {
                                    return RedirectToAction("index", "hata", new { HataId = 4 });
                                }
                            }
                        }
                        return RedirectToAction("index", "hata", new { HataId = 2 });
                    }
                }                            
            }
        }
    }
}