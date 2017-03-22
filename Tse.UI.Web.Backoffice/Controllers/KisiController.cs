namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using System.Web.Mvc;
    using ViewModels;

    public class KisiController : Controller
    {
        //Kisi
        public ActionResult Listele()
        {
            var model = new KisiListeleViewModel();
            return View(model);
        }

        [ActionName("kisi-ekle")]
        public ActionResult KisiEkle()
        {
            var model = new KisiEkleViewModel();
            TempData["DisplayStatus"] = "display-hide";
            return View(model);
        }

        [ActionName("kisi-ekle") HttpPost ValidateAntiForgeryToken]
        public ActionResult KisiEkle(Kisi kisi)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = new FirmaEkleViewModel();

                if (ModelState.IsValid)
                {
                    context.Kisiler.Add(kisi);
                    context.SaveChanges();
                    TempData["DisplayStatus"] = "";
                    return RedirectToAction("kisi-duzenle", new { kisiID = kisi.KisiID });
                }
                else
                {
                    TempData["DisplayStatus"] = "display-hide";
                    return View(model);
                }
            }
        }

        [ActionName("kisi-duzenle")]
        public ActionResult KisiDuzenle(int? kisiID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (kisiID != null)
                {
                    var model = new KisiDuzenleViewModel(kisiID);
                    model.Kisi = context.Kisiler.Find(kisiID);
                    if (model.Kisi != null)
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                    else
                        return RedirectToAction("listele", "firma");
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [ActionName("kisi-duzenle") HttpPost ValidateAntiForgeryToken]
        public ActionResult KisiDuzenle(Kisi kisi)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Entry(kisi).State = EntityState.Modified;
                    context.SaveChanges();
                    TempData["DisplayStatus"] = "";
                    KisiDuzenleViewModel model = new KisiDuzenleViewModel(kisi.KisiID);
                    return View(model);
                }
                return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }

        [ActionName("kisi-sil") HttpPost]
        public ActionResult KisiSil(int? id)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (id == null)
                {
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                }

                Kisi kisi = context.Kisiler.Find(id);

                if (kisi != null)
                {
                    try
                    {
                        context.Kisiler.Remove(kisi);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        try
                        {
                            kisi.DurumID = 4;
                            context.Entry(kisi).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            return RedirectToAction("index", "hata", new { HataId = 4 });
                        }
                    }
                }
                return RedirectToAction("listele");
            }
        }
    }
}