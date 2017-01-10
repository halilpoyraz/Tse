namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class Eposta
    {
        // Constructor
        public Eposta()
        {
        }



        // Properties
        public int EpostaId { get; set; }

        public int KisiId { get; set; }

        [Required MaxLength(254) Display(Name = "E-Posta Adresi")]
        public string EpostaAdresi { get; set; }

        [Display(Name = "Varsayılan E-posta")]
        public bool VarsayilanEposta { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kisi Kisi { get; set; }



        // Methods
    }
}