namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using ViewModels;

    public class SehirController : Controller
    {                       
        public ActionResult Listele()
        {
            var model = new SehirListeleViewModel();
            return View(model);
        }

        public ActionResult Ekle()
        {
            var model = new SehirEkleViewModel();
            TempData["DisplayStatus"] = "display-hide";
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Ekle([Bind(Include = "SehirID,UlkeID,SehirAdi,DurumID")] Sehir sehir)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = new SehirEkleViewModel();

                if (ModelState.IsValid)
                {
                    context.Sehirler.Add(sehir);
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
                    var model = new SehirDuzenleViewModel();
                    model.Sehir = context.Sehirler.Find(id);
                    if (model.Sehir == null)
                        return RedirectToAction("listele", "sehir");
                    else
                        return View(model);
                }
            }
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Duzenle([Bind(Include = "SehirID,SehirAdi,UlkeID,DurumID")] Sehir sehir)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Entry(sehir).State = EntityState.Modified;
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
                            sehir.DurumID = 4;
                            context.Entry(sehir).State = EntityState.Modified;
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