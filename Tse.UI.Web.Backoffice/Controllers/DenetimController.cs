namespace Tse.UI.Web.Backoffice.Controllers
{
    using Dal.Backoffice.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using ViewModels;

    public class DenetimController : Controller
    {        
        public ActionResult Listele()
        {
            var model = new DenetimListeleViewModel();
            return View(model);
        }

        public ActionResult Ekle()
        {
            var model = new DenetimEkleViewModel();
            return View(model);
        }

        [HttpPost ValidateAntiForgeryToken]
        public ActionResult Ekle(Denetim denetim)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (ModelState.IsValid)
                {
                    context.Denetimler.Add(denetim);
                    context.SaveChanges();
                    return RedirectToAction("duzenle", new { denetimID = denetim.DenetimID });
                }
                else
                    return RedirectToAction("index", "hata", new { HataId = 4 });
            }
        }
    }
}