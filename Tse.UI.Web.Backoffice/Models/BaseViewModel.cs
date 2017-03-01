using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Models
{
    public class BaseViewModel 
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
        public UstMenu UstMenu { get; set; }
    }

    public class UstMenu
    {
        //Constructor
        public UstMenu()
        {
            Title = "";
            BreadCrumb1Text = "";
            BreadCrumb1Link = "";
            BreadCrumb2Text = "";
            BreadCrumb2Link = "";
            HeadText = "";
            SmallText = "";
        }
        
        //Properties
        public string Title { get; set; }
        public string BreadCrumb1Text { get; set; }
        public string BreadCrumb1Link { get; set; }
        public string BreadCrumb2Text { get; set; }
        public string BreadCrumb2Link { get; set; }
        public string BreadCrumb3Text { get; set; }
        public string BreadCrumb3Link { get; set; }
        public string HeadText { get; set; }
        public string SmallText { get; set; }
    }
}