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
        public int TelefonID { get; set; }

        [Display(Name ="Kişi")]
        public int? KisiID { get; set; }

        [Display(Name ="Firma")]
        public int? FirmaID { get; set; }

        [Display(Name ="Telefon Tipi")]
        public int TelefonTipiID { get; set; }

        [Display(Name ="Telefon No") MaxLength(25) Required]
        public string TelefonNo { get; set; }

        [Display(Name ="Dahili No") MaxLength(10)]
        public string DahiliNo { get; set; }

        [Display(Name ="Varsayılan Telefon")]
        public bool VarsayilanTelefon { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }

        public virtual Kisi Kisi { get; set; }

        public virtual Firma Firma { get; set; }

        [ForeignKey("TelefonTipiID")]
        public virtual Deger TelefonTipi { get; set; }
        


        // Methods
    }
}