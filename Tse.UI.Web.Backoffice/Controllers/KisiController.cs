using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class KisiController : Controller
    {
        // GET: KisilikBilgileri
        [ActionName("tum-kisiler")]
        public ActionResult TumKisiler()
        {
            return View();
        }

        [ActionName("yeni-kisi")]
        public ActionResult YeniKisi()
        {
            return View();
        }
    }
}