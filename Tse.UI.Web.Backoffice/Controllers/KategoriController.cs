using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori

        TseBackofficeContext context = new TseBackofficeContext();

        public ActionResult Listele(int? kategoriID)
        {
            if (kategoriID != null)
            {
                var model = context.Degerler.Where(d => d.KategoriID == kategoriID).ToList();
                return View(model);
            }
            return RedirectToAction("index","hata",new { HataId=1 });
        }
    }
}