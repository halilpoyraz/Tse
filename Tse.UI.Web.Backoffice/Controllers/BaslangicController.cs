namespace Tse.UI.Web.Backoffice.Controllers
{
    using System.Web.Mvc;
    using ViewModels;

    public class BaslangicController : Controller
    {
        [ActionName("gosterge-paneli")]
        public ActionResult GostergePaneli()
        {           
            var model = new GostergePaneliViewModel();
            return View(model);                       
        }
       
        public ActionResult Guncellemeler()
        {            
            var model = new GuncellemelerViewModel();                        
            return View(model);            
        }
    }
}