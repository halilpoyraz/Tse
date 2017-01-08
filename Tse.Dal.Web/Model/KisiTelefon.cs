namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class KisiTelefon
    {
        // Constructor
        public KisiTelefon()
        {
        }

        // Properties
        public int KisiTelefonId { get; set; }

        public int KisiId { get; set; }

        public int TelefonTipiId { get; set; }

        [Required MaxLength(25) Display(Name = "Telefon Numarası")]
        public string TelefonNo { get; set; }

        public bool VarsiyalanTelefon { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kisi Kisi { get; set; } 
               

        // Methods
    }
}