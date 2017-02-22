using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class UlkesController : Controller
    {
        

        // GET: Ulkes
        public ActionResult Index()
        {
            using (TseBackofficeContext db = new TseBackofficeContext())
            {
                var ulkeler = db.Ulkeler.Include(u => u.Durum).ToList();
                return View(ulkeler);
            }
        }

       
    }
}
