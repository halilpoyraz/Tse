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
                var model = new KisiEkleViewModel();

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
                        return RedirectToAction("listele", "kisi");
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


        //KisiAdres
        [ActionName("kisi-adres-listele")]
        public ActionResult KisiAdresListele(int? kisiID)
        {
            TempData["activeTab"] = "kisi-adres";
            return RedirectToAction("kisi-duzenle", new { kisiID = kisiID });
        }

        [ActionName("kisi-adres-ekle")]
        public ActionResult KisiAdresEkle(int? kisiID)
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
                        return RedirectToAction("listele", "kisi");
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("kisi-adres-ekle") ValidateAntiForgeryToken]
        public ActionResult KisiAdresEkle(Adres adres)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Adresler.Add(adres);
                context.SaveChanges();
                TempData["activeTab"] = "kisi-adres";
                return RedirectToAction("kisi-duzenle", new { kisiID = adres.KisiID });
            }
        }

        [ActionName("kisi-adres-duzenle")]
        public ActionResult KisiAdresDuzenle(int? kisiID, int? adresID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (kisiID != null && adresID != null)
                {
                    var model = new KisiDuzenleViewModel(kisiID);
                    model.Kisi = context.Kisiler.Find(kisiID);
                    model.Adres = context.Adresler.Find(adresID);
                    if (model.Kisi != null && model.Adres != null)
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                    else
                        return RedirectToAction("kisi-adres-listele", "kisi", new { kisiID = kisiID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("kisi-adres-duzenle") ValidateAntiForgeryToken]
        public ActionResult KisiAdresDuzenle(Adres adres)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Entry(adres).State = EntityState.Modified;
                context.SaveChanges();
                TempData["DisplayStatus"] = "";
                return RedirectToAction("kisi-adres-listele", new { kisiID = adres.KisiID });
            }
        }

        [HttpPost ActionName("kisi-adres-sil")]
        public ActionResult KisiAdresSil(int? kisiID, int? adresID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (kisiID != null && adresID != null)
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
                    TempData["activeTab"] = "kisi-adres";
                    return RedirectToAction("kisi-duzenle", new { kisiID = kisiID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }


        //KisiTelefon
        [ActionName("kisi-telefon-listele")]
        public ActionResult KisiTelfonListele(int? kisiID)
        {
            TempData["activeTab"] = "kisi-telefon";
            return RedirectToAction("kisi-duzenle", new { kisiID = kisiID });
        }

        [ActionName("kisi-telefon-ekle")]
        public ActionResult KisiTelefonEkle(int? kisiID)
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
                        return RedirectToAction("listele", "kisi");
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("kisi-telefon-ekle") ValidateAntiForgeryToken]
        public ActionResult KisiTelefonEkle(Telefon telefon)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Telefonlar.Add(telefon);
                context.SaveChanges();
                TempData["activeTab"] = "kisi-telefon";
                return RedirectToAction("kisi-duzenle", new { kisiID = telefon.KisiID });
            }
        }

        [ActionName("kisi-telefon-duzenle")]
        public ActionResult KisiTelefonDuzenle(int? kisiID, int? telefonID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (kisiID != null && telefonID != null)
                {
                    var model = new KisiDuzenleViewModel(kisiID);
                    model.Kisi = context.Kisiler.Find(kisiID);
                    model.Telefon = context.Telefonlar.Find(telefonID);
                    if (model.Kisi != null && model.Telefon != null)
                    {
                        TempData["DisplayStatus"] = "display-hide";
                        return View(model);
                    }
                    else
                        return RedirectToAction("kisi-telefon-listele", "kisi", new { kisiID = kisiID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }

        [HttpPost ActionName("kisi-telefon-duzenle") ValidateAntiForgeryToken]
        public ActionResult KisiTelefonDuzenle(Telefon telefon)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                context.Entry(telefon).State = EntityState.Modified;
                context.SaveChanges();
                TempData["DisplayStatus"] = "";
                return RedirectToAction("kisi-telefon-listele", new { kisiID = telefon.KisiID });
            }
        }

        [HttpPost ActionName("kisi-telefon-sil")]
        public ActionResult KisiTelefonSil(int? kisiID, int? telefonID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (kisiID != null && telefonID != null)
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
                    TempData["activeTab"] = "kisi-telefon";
                    return RedirectToAction("kisi-duzenle", new { kisiID = kisiID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 2 });
            }
        }
    }
}