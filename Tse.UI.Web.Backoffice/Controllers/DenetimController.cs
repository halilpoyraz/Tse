namespace Tse.UI.Web.Backoffice.Controllers
{
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
    }
}