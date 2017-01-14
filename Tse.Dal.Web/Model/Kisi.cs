namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Kisi
    {
        //Constructor
        public Kisi()
        {
        }


        //Properties
        public int KisiId { get; set; }

        [Display(Name ="Adı") MaxLength(255) Required]
        public string Adi { get; set; }

        [Display(Name ="Soyadı") MaxLength(255) Required]
        public string Soyadi { get; set; }

        [Display(Name = "Tc Kimlik No")]
        public long TcKimlikNo { get; set; }

        [Display(Name = "Ünvanı") MaxLength(255)]
        public string Unvan { get; set; }        

        [Display(Name = "Durum")]
        public int DurumId { get; set; }


        // Navigation Properties
        public virtual ICollection<Adres> KisiAdresler { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Eposta> Epostalar { get; set; }             
        public virtual ICollection<Telefon> KisiTelefonlar { get; set; }
        public virtual ICollection<VergiBilgi> KisiVergiBilgileri { get; set; }


        // Methods
    }
}
