using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tse.Dal.Backoffice.Model;
using Tse.UI.Web.Backoffice.Models;

namespace Tse.UI.Web.Backoffice.Controllers
{
    public class BaslangicController : Controller
    {        
        [ActionName("gosterge-paneli")]
        public ActionResult GostergePaneli()
        {           
            var model = new PageViewModel();
            return View(model);                       
        }

        [ActionName("guncellemeler")]
        public ActionResult Guncellemeler()
        {            
            var model = new PageViewModel();            
            return View(model);            
        }
    }
}