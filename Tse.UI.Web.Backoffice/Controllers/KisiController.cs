namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using ViewModels;

    public class KisiController : Controller
    {
        public ActionResult Listele()
        {
            var model = new KisiListeleViewModel();
            return View(model);
        }

        public ActionResult Ekle()
        {
            var model = new KisiEkleViewModel();
            TempData["DisplayStatus"] = "display-hide";
            return View(model);
        }


        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle([Bind(Include = "KisiID,Adi,Soyadi,TcKimlikNo,Unvan,DurumID")] Kisi kisi)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = new KisiEkleViewModel();

                if (ModelState.IsValid)
                {
                    context.Kisiler.Add(kisi);
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


        public ActionResult Duzenle(int? id)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (id == null)
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                else
                {
                    var model = new KisiDuzenleViewModel();
                    model.Kisi = context.Kisiler.Find(id);
                    if (model.Kisi == null)
                        return RedirectToAction("listele", "kisi");
                    else
                        return View(model);
                }
            }
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle([Bind(Include = "KisiID,Adi,Soyadi,TcKimlikNo,Unvan,DurumID")] Kisi kisi)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Entry(kisi).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("listele");
                }
                return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }

        [HttpPost]
        public ActionResult Sil(int? id)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (id == null)
                {
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                }

                Kisi kisi = context.Kisiler.Find(id);

                if (kisi!= null)
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