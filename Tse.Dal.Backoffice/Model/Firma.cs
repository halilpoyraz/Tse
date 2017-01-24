namespace Tse.Dal.Backoffice.Model
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
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Eposta> Epostalar { get; set; }
        public virtual ICollection<FaturaBilgi> FaturaBilgileri { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }


        // Methods
    }
}