namespace Tse.UI.Web.Backoffice.Controllers
{
    using System.Web.Mvc;
    using ViewModels;

    public class BaslangicController : Controller
    {        
        [ActionName("gosterge-paneli")]
        public ActionResult GostergePaneli()
        {           
            var model = new BaseViewModel();
            return View(model);                       
        }

        [ActionName("guncellemeler")]
        public ActionResult Guncellemeler()
        {            
            var model = new BaseViewModel();                        
            return View(model);            
        }
    }
}