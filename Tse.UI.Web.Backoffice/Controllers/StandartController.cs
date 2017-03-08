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
    }
}