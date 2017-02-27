using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Models
{
    public class PageViewModel 
    {
        

        //Constructor
        public PageViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Kategoriler = context.Kategoriler.Where(k => k.DurumID == 1).ToList();
            }
            
        }


        //Properties
        public List<Kategori> Kategoriler { get; set; }
    }
}