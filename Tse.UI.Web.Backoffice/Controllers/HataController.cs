using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class HataController : Controller
    {
        // GET: Hata
        public ActionResult Index(int? hataId)
        {
            if (hataId!=null)
            {
                using (TseBackofficeContext context = new TseBackofficeContext())
                {
                    var model = context.Hatalar.SingleOrDefault(h => h.HataID == hataId);
                    return View(model);
                }                                
            }
            return RedirectToAction("index", "hata", new { hataId = 1 });
        }
    }
}