using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class BaslangicController : Controller
    {


        [ActionName("gosterge-paneli")]
        public ActionResult GostergePaneli()
        {           
            return View();
        }

        [ActionName("guncellemeler")]
        public ActionResult Guncellemeler()
        {
            return View();
        }
    }
}