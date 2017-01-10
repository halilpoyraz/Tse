namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Telefon
    {
        // Constructor
        public Telefon()
        {
        }



        // Properties
        public int TelefonId { get; set; }

        public int KisiId { get; set; }
        
        public int TelefonTipiId { get; set; }

        [Required MaxLength(25) Display(Name = "Telefon Numarası")]
        public string TelefonNo { get; set; }

        [MaxLength(10) Display(Name = "Dahili No")]
        public string DahiliNo { get; set; }

        [Display(Name = "Varsayılan Telefon")]
        public bool VarsayilanTelefon { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kisi Kisi { get; set; }

        [ForeignKey("TelefonTipiId")]
        public virtual Deger TelefonTipi { get; set; }



        // Methods
    }
}