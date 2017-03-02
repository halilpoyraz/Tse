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
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                //BreadCrumb
                BreadCrumb.Title = "Ülkeler";
                BreadCrumb.Text1 = "Başlangıç";
                BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
                BreadCrumb.Text2 = "Ülkeler";
                BreadCrumb.Link2 = "/ulke/listele";
                BreadCrumb.Text3 = "Tüm Ülkeler";
                BreadCrumb.HeadText = "Tüm Ülkeler";                    
               
                //Data
                Ulkeler = context.Ulkeler.ToList();
                Durumlar = context.Durumlar.ToList();


                //Filter
                TumCount = context.Ulkeler.Count();
                AktifCount = context.Ulkeler.Where(u => u.DurumID == 1).Count();
                PasifCount = context.Ulkeler.Where(u => u.DurumID == 2).Count();
                TaslakCount = context.Ulkeler.Where(u => u.DurumID == 3).Count();
                SilinmisCount = context.Ulkeler.Where(u => u.DurumID == 4).Count();                                                         
            }
        }

        //Properties                
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }

        public int TumCount { get; set; }
        public int AktifCount { get; set; }
        public int PasifCount { get; set; }
        public int TaslakCount { get; set; }
        public int SilinmisCount { get; set; }
        
    }

}