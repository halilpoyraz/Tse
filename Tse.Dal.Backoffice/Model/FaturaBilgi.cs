namespace Tse.Dal.Backoffice.Model
{
    using System.ComponentModel.DataAnnotations;    

    public partial class FaturaBilgi
    {
        //Constructor
        public FaturaBilgi()
        {
        }


        //Properties        
        public int FaturaBilgiID { get; set; }
                
        [Display(Name ="Kişi")]
        public int? KisiID { get; set; }

        [Display(Name ="Firma")]
        public int? FirmaID { get; set; }

        [Display(Name ="Vergi Dairesi") MaxLength(255) Required]
        public string VergiDairesi { get; set; }
        
        [Display(Name = "Vergi No") MaxLength(255) Required]
        public string VergiNo { get; set; }

        [Display(Name = "Fatura Adresi")]
        public int? AdresID { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }        
        public virtual Kisi Kisi { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual Adres Adres { get; set; }


        // Methods
    }
}