namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Firma
    {
        // Constructor
        public Firma()
        {
            FirmaVergiBilgileri = new HashSet<VergiBilgi>();
            FirmaTelefonlar = new HashSet<Telefon>();
        }



        // Properties
        public int FirmaId { get; set; }

        [Required MaxLength(255) Display(Name ="Ticaret Unvanı") ]
        public string TicaretUnvani { get; set; }

        [MaxLength(255) Display(Name = "Web Adresi")]
        public string WebAdresi { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<VergiBilgi> FirmaVergiBilgileri { get; set; }
        public virtual ICollection<Telefon> FirmaTelefonlar { get; set; }

        // Methods
    }
}