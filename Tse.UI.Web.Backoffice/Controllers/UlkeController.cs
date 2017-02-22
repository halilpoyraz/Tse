using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

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

            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                List<Durum> model = context.Durumlar.ToList();
                return View(model);
            }
        }
    }
}