namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class KisiEposta
    {
        // Constructor
        public KisiEposta()
        {
        }

        // Properties
        public int KisiEpostaId { get; set; }

        public int KisiId { get; set; }

        [Required MaxLength(254) Display(Name = "E-Posta Adresi")]
        public string EpostaAdresi { get; set; }
        
        public bool VarsayilanEposta { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }

        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kisi Kisi { get; set; }

        // Methods
    }
}