namespace Tse.UI.Web.Backoffice.Controllers
{
    using System.Web.Mvc;
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using ViewModels;
    using System.Data.Entity.Migrations;

    public class StandartController : Controller
    {
        public ActionResult Listele()
        {
            var model = new StandartListeleViewModel();
            return View(model);
        }

        public ActionResult Ekle()
        {
            var model = new StandartEkleViewModel();
            return View(model);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle(Standart standart)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Standartlar.Add(standart);
                    context.SaveChanges();
                    return RedirectToAction("duzenle", new { standartID = standart.StandartID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }

        public ActionResult Duzenle(int? standartID, int? standartIcerikID)
        {
            if (standartID != null)
            {
                var model = new StandartDuzenleViewModel(standartID, standartIcerikID);              
                return View(model);
            }
            else
                return RedirectToAction("index", "hata", new { HataId = 2 });
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle(Standart standart)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {

                if (ModelState.IsValid)
                {
                    context.Entry(standart).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("duzenle", new { standartID = standart.StandartID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }

        [HttpPost]
        public ActionResult Sil(int? standartID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (standartID != null)
                {
                    Standart standart = context.Standartlar.Find(standartID);
                    if (standart != null)
                    {
                        try
                        {
                            context.Standartlar.Remove(standart);
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            try
                            {
                                standart.DurumID = 4;
                                context.Entry(standart).State = EntityState.Modified;
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                                return RedirectToAction("index", "hata", new { HataId = 4 });
                            }
                        }
                    }
                    return RedirectToAction("listele", new { standartID =standart.StandartID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ValidateAntiForgeryToken ValidateInput(false) ActionName("icerik-ekle")]
        public ActionResult IcerikEkle(StandartIcerik standartIcerik)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.StandartIcerikler.Add(standartIcerik);
                    context.SaveChanges();
                    return RedirectToAction("duzenle", new { standartID = standartIcerik.StandartID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 4 });
            }            
        }

        [HttpPost ValidateAntiForgeryToken ValidateInput(false) ActionName("icerik-duzenle")]
        public ActionResult IcerikDuzenle(StandartIcerik standartIcerik)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.StandartIcerikler.AddOrUpdate(standartIcerik);
                if (standartIcerik.StandartIcerikDenetim.StandartIcerikID != 0)
                {
                    context.StandartIcerikDenetimler.AddOrUpdate(standartIcerik.StandartIcerikDenetim);
                }                
                context.SaveChanges();
                return RedirectToAction("duzenle", new { standartID = standartIcerik.StandartID });             
            }
        }

        [ActionName("icerik-sil")]
        public ActionResult IcerikSil(int? standartID, int? standartIcerikID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (standartID != null)
                {
                    if (standartIcerikID != null)
                    {
                        StandartIcerik standartIcerik = context.StandartIcerikler.Find(standartIcerikID);
                        if (standartIcerik != null)
                        {
                            try
                            {
                                context.StandartIcerikler.Remove(standartIcerik);
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    standartIcerik.DurumID = 4;
                                    context.Entry(standartIcerik).State = EntityState.Modified;
                                    context.SaveChanges();
                                }
                                catch (Exception)
                                {
                                    return RedirectToAction("index", "hata", new { HataId = 4 });
                                }
                            }
                        }
                        return RedirectToAction("duzenle", new { standartID = standartID });
                    }                    
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                }
                return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }
    }
}