namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class KisiTelefon
    {
        // Constructor
        public KisiTelefon()
        {
        }

        // Properties
        public int KisiTelefonId { get; set; }

        public int KisiId { get; set; }

        [ForeignKey("TanimlamaDeger")]
        public int TelefonTipiId { get; set; }

        [Required MaxLength(25) Display(Name = "Telefon Numarası")]
        public string TelefonNo { get; set; }

        public bool VarsiyalanTelefon { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kisi Kisi { get; set; }
        public virtual TanimlamaDeger TanimlamaDeger { get; set; }

        // Methods
    }
}