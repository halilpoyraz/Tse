namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class GostergePaneliViewModel : BaseViewModel
    {
        //Constructor
        public GostergePaneliViewModel()
        {
            //BreadCrumb                
            BreadCrumb.Text1 = "Başlangıç";
            BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
            BreadCrumb.Text2 = "Gösterge Paneli";

            //Meta
            Meta.Title = "Gösterge Paneli";
        }                           
    }


    public partial class GuncellemelerViewModel : BaseViewModel
    {
        //Constructor
        public GuncellemelerViewModel()
        {            
            //BreadCrumb                
            BreadCrumb.Text1 = "Başlangıç";
            BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
            BreadCrumb.Text2 = "Güncellemeler";

            //Meta
            Meta.Title = "Güncellemeler";            
        }
    }

}