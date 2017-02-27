using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Models
{
    public class UlkeViewModel : PageViewModel
    {       
        //Constructor
        public UlkeViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {              
                Durumlar = context.Durumlar.ToList();
                Ulkeler = context.Ulkeler.ToList();
                TumCount = context.Ulkeler.Count();
                AktifCount = context.Ulkeler.Where(u => u.DurumID == 1).Count();
                PasifCount = context.Ulkeler.Where(u => u.DurumID == 2).Count();
                TaslakCount = context.Ulkeler.Where(u => u.DurumID == 3).Count();
                SilinmisCount = context.Ulkeler.Where(u => u.DurumID == 4).Count();
                Ulke = new Ulke { UlkeID = 1, UlkeAdi = "Tsubasa", DurumID = 4 };
            }
        }


        //Properties        
        public Ulke Ulke { get; set; }
        public Durum Durum { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }
        public int TumCount { get; set; }
        public int AktifCount { get; set; }
        public int PasifCount { get; set; }
        public int TaslakCount { get; set; }
        public int SilinmisCount { get; set; }        
    }
}


