using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Models
{
    public partial class BaseViewModel 
    {       
        //Constructor
        public BaseViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
               SolMenuKategoriler = context.Kategoriler.Where(k => k.DurumID == 1).ToList();
            }            
        }


        //Properties
        public List<Kategori> SolMenuKategoriler { get; set; }
    }
}