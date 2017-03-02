namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public class BaseViewModel 
    {       
        //Constructor
        public BaseViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                SolMenuKategoriler = context.Kategoriler.Where(k => k.DurumID == 1).ToList();
                BreadCrumb = new BreadCrumb();
                Meta = new Meta();
            }            
        }


        //Properties
        public List<Kategori> SolMenuKategoriler { get; set; }
        public BreadCrumb BreadCrumb { get; set; }
        public Meta Meta { get; set; }
    }    
}