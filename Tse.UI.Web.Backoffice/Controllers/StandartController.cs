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
    }
}