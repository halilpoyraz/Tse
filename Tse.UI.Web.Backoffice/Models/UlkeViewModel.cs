using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tse.Dal.Backoffice.Model;

namespace Tse.UI.Web.Backoffice.Models
{
    public class UlkeViewModel
    {
        public UlkeViewModel()
        {
            TseBackofficeContext context = new TseBackofficeContext();
            Durumlar = context.Durumlar.ToList();
        }

        // Properties
        public Ulke Ulke { get; set; }
        public ICollection<Durum> Durumlar { get; set; }
    }
}