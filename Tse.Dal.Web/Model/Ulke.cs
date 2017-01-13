namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Ulke
    {
        //Constructor
        public Ulke()
        {          
        }


        //Properties
        public int UlkeId { get; set; }

        [Display(Name ="Ülke Adı") MaxLength(255) Required]
        public string UlkeAdi { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual Durum Durum { get; set; }        
        public virtual ICollection<Sehir> Sehirler { get; set; }
    

        // Methods
    }
}
