namespace Tse.Dal.Web.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Ulke
    {
        // Constructor
        public Ulke()
        {
            Sehirler = new HashSet<Sehir>();
            Kisiler = new HashSet<Kisi>();
        }

        // Properties
        public int UlkeId { get; set; }

        [Required MaxLength(55) Display(Name = "Ülke Adı")]
        public string UlkeAdi { get; set; }

        public int DurumId { get; set; }


        // Navigation Properties
        public virtual  Durum Durum { get; set; }
        public virtual ICollection<Sehir> Sehirler { get; set; }
        public virtual ICollection<Kisi> Kisiler { get; set; }
    

        // Methods
    }
}
