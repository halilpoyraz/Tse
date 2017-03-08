using System.Web.Mvc;
namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using System.Web.Mvc;
    using ViewModels;

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
                    return RedirectToAction("duzenle", new { id = standart.StandartID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }

        public ActionResult Duzenle(int? id)
        {
            if (id != null)
            {
                var model = new StandartDuzenleViewModel(id);              
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
                    return RedirectToAction("duzenle", new { id = standart.StandartID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }

        [ActionName("icerik-sil")]
        public ActionResult IcerikSil(int? standartIcerikID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
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
                    return RedirectToAction("duzenle", new { id = standartIcerik.StandartID});
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }
    }
}