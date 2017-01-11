namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ParaBirimi
    {
        // Constructor
        public ParaBirimi()
        {
            Standartlar = new HashSet<Standart>();
        }



        // Properties
        public int ParaBirimiId { get; set; }

        [Required]
        public string Kodu { get; set; }

        [Required]
        public string Cinsi { get; set; }

        [Display(Name = "Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties        
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }



        // Methots
    }
}
