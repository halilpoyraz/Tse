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
                Meta = new Meta();

                BreadCrumb = new BreadCrumb();

                SolMenuKategoriler = context.Kategoriler.Where(k => k.DurumID == 1).ToList();
            }            
        }


        //Properties
        public Meta Meta { get; set; }
        public BreadCrumb BreadCrumb { get; set; }
        public List<Kategori> SolMenuKategoriler { get; set; }
    }    
}