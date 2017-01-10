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
        }



        // Properties
        public int UlkeId { get; set; }

        [Required MaxLength(55) Display(Name = "Ülke Adı")]
        public string UlkeAdi { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual Durum Durum { get; set; }        
        public virtual ICollection<Sehir> Sehirler { get; set; }
    


        // Methods
    }
}
