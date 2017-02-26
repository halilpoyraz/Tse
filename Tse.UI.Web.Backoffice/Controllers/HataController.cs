using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class HataController : Controller
    {
        // GET: Hata
        public ActionResult Index()
        {
            int hataId = Convert.ToInt32(Session["HataId"]);
            ViewBag.HataId = hataId;
            return View();
        }
    }
}