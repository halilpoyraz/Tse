using System.Web.Mvc;
namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using ViewModels;

    public class FirmaController : Controller
    {
        //Firma
        public ActionResult Listele()
        {
            var model = new FirmaListeleViewModel();
            return View(model);
        }

        [ActionName("firma-ekle")]
        public ActionResult FirmaEkle()
        {
            var model = new FirmaEkleViewModel();
            TempData["DisplayStatus"] = "display-hide";
            return View(model);
        }

        [ActionName("firma-ekle") HttpPost ValidateAntiForgeryToken]
        public ActionResult FirmaEkle(Firma firma)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = new FirmaEkleViewModel();

                if (ModelState.IsValid)
                {
                    context.Firmalar.Add(firma);
                    context.SaveChanges();
                    TempData["DisplayStatus"] = "";
                    return RedirectToAction("firma-duzenle", new { firmaID = firma.FirmaID });
                }
                else
                {
                    TempData["DisplayStatus"] = "display-hide";
                    return View(model);
                }
            }
        }

        [ActionName("firma-duzenle")]
        public ActionResult FirmaDuzenle(int? firmaID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null)
                {
                    var model = new FirmaDuzenleViewModel(firmaID);
                    model.Firma = context.Firmalar.Find(firmaID);
                    if (model.Firma != null)
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

        [ActionName("firma-duzenle") HttpPost ValidateAntiForgeryToken]
        public ActionResult FirmaDuzenle(Firma firma)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {                
                if (ModelState.IsValid)
                {
                    context.Entry(firma).State = EntityState.Modified;
                    context.SaveChanges();
                    TempData["DisplayStatus"] = "";
                    FirmaDuzenleViewModel model = new FirmaDuzenleViewModel(firma.FirmaID);
                    return View(model);
                }
                return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }

        [ActionName("firma-sil") HttpPost]
        public ActionResult FirmaSil(int? id)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (id == null)
                {
                    return RedirectToAction("index", "hata", new { HataId = 2 });
                }

                Firma firma = context.Firmalar.Find(id);

                if (firma != null)
                {
                    try
                    {
                        context.Firmalar.Remove(firma);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        try
                        {
                            firma.DurumID = 4;
                            context.Entry(firma).State = EntityState.Modified;
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

        //FirmaAdres
        [ActionName("firma-adres-listele")]
        public ActionResult FirmaAdresListele(int? firmaID)
        {
            TempData["activeTab"] = "firma-adres";
            return RedirectToAction("firma-duzenle", new { firmaID = firmaID });          
        }

        [ActionName("firma-adres-ekle")]
        public ActionResult FirmaAdresEkle(int? firmaID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null)
                {
                    var model = new FirmaDuzenleViewModel(firmaID);
                    model.Firma = context.Firmalar.Find(firmaID);
                    if (model.Firma != null)
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

        [ActionName("firma-adres-duzenle")]
        public ActionResult FirmaAdresDuzenle(int? firmaID, int? adresID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && adresID != null)
                {
                    var model = new FirmaDuzenleViewModel(firmaID);
                    model.Firma = context.Firmalar.Find(firmaID);
                    model.Adres = context.Adresler.Find(adresID);
                    if (model.Firma != null && model.Adres !=null)
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                    else
                        return RedirectToAction("firma-adres-listele", "firma", new { firmaID = firmaID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("firma-adres-duzenle") ValidateAntiForgeryToken]
        public ActionResult FirmaAdresDuzenle(Adres adres)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Entry(adres).State = EntityState.Modified;
                context.SaveChanges();
                TempData["DisplayStatus"] = "";
                return RedirectToAction("firma-adres-listele", new { firmaID = adres.FirmaID });
            }
        }

        [HttpPost ActionName("firma-adres-ekle") ValidateAntiForgeryToken]
        public ActionResult FirmaAdresEkle(Adres adres)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {               

               
                    context.Adresler.Add(adres);
                    context.SaveChanges();                    
                    TempData["activeTab"] = "firma-adres";
                    return RedirectToAction("firma-duzenle", new { firmaID = adres.FirmaID });
              
                
            }
        }

        [ActionName("firma-adres-sil") HttpPost]
        public ActionResult FirmaAdresSil(int? firmaID, int? adresID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && adresID !=null)
                {
                    Adres adres = context.Adresler.Find(adresID);

                    if (adres != null)
                    {
                        try
                        {
                            context.Adresler.Remove(adres);
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            try
                            {
                                adres.DurumID = 4;
                                context.Entry(adres).State = EntityState.Modified;
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                                return RedirectToAction("index", "hata", new { HataId = 4 });
                            }
                        }
                    }
                    TempData["activeTab"] = "firma-adres";
                    return RedirectToAction("firma-duzenle", new { firmaID = firmaID});
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });               
            }
        }
    }
}