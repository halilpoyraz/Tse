namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;    

    public partial class VergiBilgi
    {
        //Constructor
        public VergiBilgi()
        {
        }


        //Properties        
        public int VergiBilgiId { get; set; }
                
        [Display(Name ="Kişi")]
        public int? KisiId { get; set; }

        [Display(Name ="Firma")]
        public int? FirmaId { get; set; }

        [Display(Name ="Vergi Dairesi") MaxLength(255) Required]
        public string VergiDairesi { get; set; }
        
        [Display(Name = "Vergi No") MaxLength(255) Required]
        public string VergiNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }        
        public virtual Kisi Kisi { get; set; }
        public virtual Firma Firma { get; set; }


        // Methods
    }
}