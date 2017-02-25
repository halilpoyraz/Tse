using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Models
{
    public class SehirViewModel
    {
        public SehirViewModel()
        {
            TseBackofficeContext context = new TseBackofficeContext();
            Durumlar = context.Durumlar.ToList();
            Ulkeler = context.Ulkeler.ToList();
        }
        public Durum Durum { get; set; }
        public Ulke Ulke { get; set; }
        public Sehir Sehir { get; set; }
        public IEnumerable<Durum> Durumlar { get; set; }
        public IEnumerable<Ulke> Ulkeler { get; set; }
    }
}