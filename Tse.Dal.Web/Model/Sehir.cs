namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Sehir
    {
        // Constructor
        public Sehir()
        {
            Adresler = new HashSet<Adres>();
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
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }
        public virtual Ulke Ulke { get; set; }



        // Methods


    }
}
