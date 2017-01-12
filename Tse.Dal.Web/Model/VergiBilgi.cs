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
        public int VergiBilgiId { get; set; }
                
        public int? KisiId { get; set; }
        
        public int? FirmaId { get; set; }

        [Required MaxLength(255) Display(Name = "Vergi Dairesi")]
        public string VergiDairesi { get; set; }
        
        [Required MaxLength(25) Display(Name = "Vergi Numarası")]
        public string VergiNo { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }        
        public virtual Kisi Kisi { get; set; }
        public virtual Firma Firma { get; set; }



        // Methods

    }
}