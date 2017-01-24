namespace Tse.Dal.Backoffice.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Telefon
    {
        //Constructor
        public Telefon()
        {
        }


        //Properties
        public int TelefonId { get; set; }

        [Display(Name ="Kişi")]
        public int? KisiId { get; set; }

        [Display(Name ="Firma")]
        public int? FirmaId { get; set; }

        [Display(Name ="Telefon Tipi")]
        public int TelefonTipiId { get; set; }

        [Display(Name ="Telefon No") MaxLength(25) Required]
        public string TelefonNo { get; set; }

        [Display(Name ="Dahili No") MaxLength(10)]
        public string DahiliNo { get; set; }

        [Display(Name ="Varsayılan Telefon")]
        public bool VarsayilanTelefon { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }

        public virtual Kisi Kisi { get; set; }

        public virtual Firma Firma { get; set; }

        [ForeignKey("TelefonTipiId")]
        public virtual Deger TelefonTipi { get; set; }


        // Methods
    }
}