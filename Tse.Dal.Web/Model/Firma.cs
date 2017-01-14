namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Firma
    {
        //Constructor
        public Firma()
        {
        }


        //Properties
        public int FirmaId { get; set; }

        [Display(Name ="Ticaret Unvanı") MaxLength(255) Required]
        public string TicaretUnvani { get; set; }

        [Display(Name ="Web Adresi") MaxLength(255)]
        public string WebAdresi { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<VergiBilgi> FirmaVergiBilgileri { get; set; }
        public virtual ICollection<Telefon> FirmaTelefonlar { get; set; }
        public virtual ICollection<Eposta> FirmaEpostalar { get; set; }
        public virtual ICollection<Adres> FirmaAdresleri { get; set; }


        // Methods
    }
}