using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;
using Tse.UI.Web.Backoffice.Models;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class UlkeController : Controller
    {            
        // GET: Ulkeler
        [ActionName("tum-ulkeler")]
        public ActionResult TumUlkeler()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                var model = context.Ulkeler.Include(u =>u.Durum).ToList();
                return View(model);
            }            
        }

        [ActionName("yeni-ulke-ekle")]
        public ActionResult YeniUlkeEkle()
        {            
            UlkeViewModel model = new UlkeViewModel();                              
            return View(model);            
        }

        [HttpPost ActionName("yeni-ulke-ekle")]
        public ActionResult YeniUlkeEkle(UlkeViewModel model)
        {
            //Kaydetme işlemi bu arada olacak.
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Ulke yeniUlke = new Ulke();
                yeniUlke.UlkeAdi = model.Ulke.UlkeAdi;
                yeniUlke.DurumID = model.Ulke.DurumID;

                context.Ulkeler.Add(yeniUlke);
                context.SaveChanges();
                return RedirectToAction("yeni-ulke-ekle");
            }
                
        }
    }
}