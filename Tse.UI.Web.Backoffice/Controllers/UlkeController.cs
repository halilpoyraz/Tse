namespace Tse.UI.Web.Backoffice.Controllers
{
    using System.Data.Entity;
    using System.Web.Mvc;    
    using System;
    using System.Net;
    using Dal.Backoffice.Model;
    using ViewModels;

    public class UlkeController : Controller
    {

        // GET: Ulke     
        public ActionResult Listele()
        {            
            var model = new UlkeListeleViewModel();
            return View(model);            
        }

        public ActionResult Ekle()
        {
            var model = new UlkeEkleViewModel();
            TempData["DisplayStatus"] = "display-hide";
            return View(model);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle([Bind(Include = "UlkeID,UlkeAdi,DurumID")] Ulke ulke)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = new UlkeEkleViewModel();

                if (ModelState.IsValid)
                {
                    context.Ulkeler.Add(ulke);
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
                {
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                }
                else
                {
                    var model = new UlkeDuzenleViewModel();
                    model.Ulke = context.Ulkeler.Find(id);
                    if (model.Ulke == null)
                        return RedirectToAction("index", "hata", new { HataId = 3 });
                    else                    
                        return View(model);                    
                }
            }
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Duzenle([Bind(Include = "UlkeID,UlkeAdi,DurumID")] Ulke ulke)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Entry(ulke).State = EntityState.Modified;
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

                Ulke ulke = context.Ulkeler.Find(id);

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
                            ulke.DurumID = 4;
                            context.Entry(ulke).State = EntityState.Modified;
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