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

        public ActionResult Duzenle(int? id)
        {
            if (id == null)            
                return RedirectToAction("index", "hata", new { HataId = 2 });
            else
            { 
                var model = new StandartDuzenleViewModel(id);
                return View(model);
            }
        }      
    }
}