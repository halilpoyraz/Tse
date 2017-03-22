namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Data.Entity;
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
        
        [HttpPost ActionName("firma-adres-sil")]
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


        //FirmaTelefon
        [ActionName("firma-telefon-listele")]
        public ActionResult FirmaTelfonListele(int? firmaID)
        {
            TempData["activeTab"] = "firma-telefon";
            return RedirectToAction("firma-duzenle", new { firmaID = firmaID });
        }

        [ActionName("firma-telefon-ekle")]
        public ActionResult FirmaTelefonEkle(int? firmaID)
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

        [HttpPost ActionName("firma-telefon-ekle") ValidateAntiForgeryToken]
        public ActionResult FirmaTelefonEkle(Telefon telefon)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Telefonlar.Add(telefon);
                context.SaveChanges();
                TempData["activeTab"] = "firma-telefon";
                return RedirectToAction("firma-duzenle", new { firmaID = telefon.FirmaID });
            }
        }

        [ActionName("firma-telefon-duzenle")]
        public ActionResult FirmaTelefonDuzenle(int? firmaID, int? telefonID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && telefonID != null)
                {
                    var model = new FirmaDuzenleViewModel(firmaID);
                    model.Firma = context.Firmalar.Find(firmaID);
                    model.Telefon = context.Telefonlar.Find(telefonID);
                    if (model.Firma != null && model.Telefon != null)
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                    else
                        return RedirectToAction("firma-telefon-listele", "firma", new { firmaID = firmaID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("firma-telefon-duzenle") ValidateAntiForgeryToken]
        public ActionResult FirmaTelefonDuzenle(Telefon telefon)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Entry(telefon).State = EntityState.Modified;
                context.SaveChanges();
                TempData["DisplayStatus"] = "";
                return RedirectToAction("firma-telefon-listele", new { firmaID = telefon.FirmaID });
            }
        }

        [HttpPost ActionName("firma-telefon-sil")]
        public ActionResult FirmaTelefonSil(int? firmaID, int? telefonID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && telefonID != null)
                {
                    Telefon telefon = context.Telefonlar.Find(telefonID);

                    if (telefon != null)
                    {
                        try
                        {
                            context.Telefonlar.Remove(telefon);
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            try
                            {
                                telefon.DurumID = 4;
                                context.Entry(telefon).State = EntityState.Modified;
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                                return RedirectToAction("index", "hata", new { HataId = 4 });
                            }
                        }
                    }
                    TempData["activeTab"] = "firma-telefon";
                    return RedirectToAction("firma-duzenle", new { firmaID = firmaID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }


        //FirmaEposta
        [ActionName("firma-eposta-listele")]
        public ActionResult FirmaEpostaListele(int? firmaID)
        {
            TempData["activeTab"] = "firma-eposta";
            return RedirectToAction("firma-duzenle", new { firmaID = firmaID });
        }

        [ActionName("firma-eposta-ekle")]
        public ActionResult FirmaEpostaEkle(int? firmaID)
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

        [HttpPost ActionName("firma-eposta-ekle") ValidateAntiForgeryToken]
        public ActionResult FirmaEpostaEkle(Eposta eposta)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Epostalar.Add(eposta);
                context.SaveChanges();
                TempData["activeTab"] = "firma-eposta";
                return RedirectToAction("firma-duzenle", new { firmaID = eposta.FirmaID });
            }
        }

        [ActionName("firma-eposta-duzenle")]
        public ActionResult FirmaEpostaDuzenle(int? firmaID, int? epostaID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && epostaID != null)
                {
                    var model = new FirmaDuzenleViewModel(firmaID);
                    model.Firma = context.Firmalar.Find(firmaID);
                    model.Eposta = context.Epostalar.Find(epostaID);
                    if (model.Firma != null && model.Eposta != null)
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                    else
                        return RedirectToAction("firma-eposta-listele", "firma", new { firmaID = firmaID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("firma-eposta-duzenle") ValidateAntiForgeryToken]
        public ActionResult FirmaEpostaDuzenle(Eposta eposta)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Entry(eposta).State = EntityState.Modified;
                context.SaveChanges();
                TempData["DisplayStatus"] = "";
                return RedirectToAction("firma-eposta-listele", new { firmaID = eposta.FirmaID });
            }
        }

        [HttpPost ActionName("firma-eposta-sil")]
        public ActionResult FirmaEpostaSil(int? firmaID, int? epostaID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && epostaID != null)
                {
                    Eposta eposta = context.Epostalar.Find(epostaID);

                    if (eposta != null)
                    {
                        try
                        {
                            context.Epostalar.Remove(eposta);
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            try
                            {
                                eposta.DurumID = 4;
                                context.Entry(eposta).State = EntityState.Modified;
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                                return RedirectToAction("index", "hata", new { HataId = 4 });
                            }
                        }
                    }
                    TempData["activeTab"] = "firma-eposta";
                    return RedirectToAction("firma-duzenle", new { firmaID = firmaID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }


        //FirmaFaturaBilgi
        [ActionName("firma-faturabilgi-listele")]
        public ActionResult FirmafaturaBilgiListele(int? firmaID)
        {
            TempData["activeTab"] = "firma-faturabilgi";
            return RedirectToAction("firma-duzenle", new { firmaID = firmaID });
        }

        [ActionName("firma-faturabilgi-ekle")]
        public ActionResult FirmaFaturaBilgiEkle(int? firmaID)
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

        [HttpPost ActionName("firma-faturabilgi-ekle") ValidateAntiForgeryToken]
        public ActionResult FirmaFaturaBilgiEkle(FaturaBilgi faturabilgi)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.FaturaBilgileri.Add(faturabilgi);
                context.SaveChanges();
                TempData["activeTab"] = "firma-faturabilgi";
                return RedirectToAction("firma-duzenle", new { firmaID = faturabilgi.FirmaID });
            }
        }

        [ActionName("firma-faturabilgi-duzenle")]
        public ActionResult FirmaFaturaBilgiDuzenle(int? firmaID, int? faturabilgiID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && faturabilgiID != null)
                {
                    var model = new FirmaDuzenleViewModel(firmaID);
                    model.Firma = context.Firmalar.Find(firmaID);
                    model.FaturaBilgi = context.FaturaBilgileri.Find(faturabilgiID);
                    if (model.Firma != null && model.FaturaBilgi != null)
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                    else
                        return RedirectToAction("firma-faturabilgi-listele", "firma", new { firmaID = firmaID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("firma-faturabilgi-duzenle") ValidateAntiForgeryToken]
        public ActionResult FirmaFaturaBilgiDuzenle(FaturaBilgi faturabilgi)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Entry(faturabilgi).State = EntityState.Modified;
                context.SaveChanges();
                TempData["DisplayStatus"] = "";
                return RedirectToAction("firma-faturabilgi-listele", new { firmaID = faturabilgi.FirmaID });
            }
        }

        [HttpPost ActionName("firma-faturabilgi-sil")]
        public ActionResult FirmaFaturaBilgiSil(int? firmaID, int? faturabilgiID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (firmaID != null && faturabilgiID != null)
                {
                    FaturaBilgi faturabilgi = context.FaturaBilgileri.Find(faturabilgiID);

                    if (faturabilgi != null)
                    {
                        try
                        {
                            context.FaturaBilgileri.Remove(faturabilgi);
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            try
                            {
                                faturabilgi.DurumID = 4;
                                context.Entry(faturabilgi).State = EntityState.Modified;
                                context.SaveChanges();
                            }
                            catch (Exception)
                            {
                                return RedirectToAction("index", "hata", new { HataId = 4 });
                            }
                        }
                    }
                    TempData["activeTab"] = "firma-faturabilgi";
                    return RedirectToAction("firma-duzenle", new { firmaID = firmaID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }
    }
}