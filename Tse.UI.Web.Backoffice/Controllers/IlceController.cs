using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class IlceController : Controller
    {
        TseBackofficeContext context = new TseBackofficeContext();
        // GET: Ilce
        [ActionName("tum-ilceler")]
        public ActionResult TumIlceler()
        {
            var ilce = context.Ilceler.ToList();
            return View(ilce);
        }

        [ActionName("yeni-ilce")]
        public ActionResult YeniIlce()
        {
            return View();
        }
    }
}