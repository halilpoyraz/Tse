using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class StandartController : Controller
    {
        // GET: Standart
        [ActionName("tum-standartlar")]
        public ActionResult TumStandartlar()
        {
            return View();
        }

        [ActionName("yeni-standart")]
        public ActionResult YeniStandart()
        {
            return View();
        }
    }
}