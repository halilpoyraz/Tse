namespace Tse.Dal.Web.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Sehir
    {
        // Constructor
        public Sehir()
        {
            Kisiler = new HashSet<Kisi>();
            Ilceler = new HashSet<Ilce>();
        }


        // Properties
        public int SehirId { get; set; }
        
        public int UlkeId { get; set; }

        [Required MaxLength(50) Display(Name = "Şehir Adı")]
        public string SehirAdi { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }


        // Navigation Propertis
        public virtual Durum Durum { get; set; }
        public virtual Ulke Ulke { get; set; }
        public virtual ICollection<Kisi> Kisiler { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }


        // Methods


    }
}
