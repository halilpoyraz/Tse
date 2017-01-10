namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class VergiBilgi
    {
        // Constructor
        public VergiBilgi()
        {
        }



        // Properties
        [Key ForeignKey("Kisi")]
        public int KisiId { get; set; }

        [Required MaxLength(255) Display(Name = "Vergi Dairesi")]
        public string VergiDairesi { get; set; }
        
        [Required MaxLength(10) Display(Name = "Vergi Numarası")]
        public string VergiNo { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kisi Kisi { get; set; }



        // Methods

    }
}