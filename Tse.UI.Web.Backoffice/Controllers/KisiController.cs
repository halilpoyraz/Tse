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

        //public ActionResult Ekle()
        //{
        //    var model = new IlceEkleViewModel();
        //    TempData["DisplayStatus"] = "display-hide";
        //    return View(model);
        //}


        //[HttpPost ValidateAntiForgeryToken]
        //public ActionResult Ekle([Bind(Include = "IlceID,SehirID,IlceKodu,IlceAdi,DurumID")] Ilce ilce)
        //{
        //    using (TseBackofficeContext context = new TseBackofficeContext())
        //    {
        //        var model = new IlceEkleViewModel();

        //        if (ModelState.IsValid)
        //        {
        //            context.Ilceler.Add(ilce);
        //            context.SaveChanges();
        //            TempData["DisplayStatus"] = "";
        //            return View(model);
        //        }
        //        else
        //        {
        //            TempData["DisplayStatus"] = "display-hide";
        //            return View(model);
        //        }
        //    }
        //}


        //public ActionResult Duzenle(int? id)
        //{
        //    using (TseBackofficeContext context = new TseBackofficeContext())
        //    {
        //        if (id == null)
        //            return RedirectToAction("index", "hata", new { HataId = 2 });
        //        else
        //        {
        //            var model = new IlceDuzenleViewModel();
        //            model.Ilce = context.Ilceler.Find(id);
        //            if (model.Ilce == null)
        //                return RedirectToAction("listele", "ilce");
        //            else
        //                return View(model);
        //        }
        //    }
        //}

        //[HttpPost ValidateAntiForgeryToken]
        //public ActionResult Duzenle([Bind(Include = "IlceID,IlceAdi,SehirID,IlceKodu,DurumID")] Ilce ilce)
        //{
        //    using (TseBackofficeContext context = new TseBackofficeContext())
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            context.Entry(ilce).State = EntityState.Modified;
        //            context.SaveChanges();
        //            return RedirectToAction("listele");
        //        }
        //        return RedirectToAction("index", "hata", new { HataId = 4 });
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

        //        Ilce ilce = context.Ilceler.SingleOrDefault(i => i.IlceID == id);

        //        if (ilce != null)
        //        {
        //            try
        //            {
        //                context.Ilceler.Remove(ilce);
        //                context.SaveChanges();
        //            }
        //            catch (Exception)
        //            {
        //                try
        //                {
        //                    ilce.DurumID = 4;
        //                    context.Entry(ilce).State = EntityState.Modified;
        //                    context.SaveChanges();
        //                }
        //                catch (Exception)
        //                {
        //                    return RedirectToAction("index", "hata", new { HataId = 4 });
        //                }
        //            }
        //        }
        //        return RedirectToAction("listele");
        //    }
        //}
    }
}