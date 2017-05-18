namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ParaBirimi
    {
        //Constructor
        public ParaBirimi()
        {
        }


        //Properties        
        public int ParaBirimiID { get; set; }

        [Display(Name ="Kodu"), MaxLength(255), Required]
        public string Kodu { get; set; }

        [Display(Name ="Cinsi"), MaxLength(255), Required]
        public string Cinsi { get; set; }

        [Display(Name = "Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name = "Durum")]
        public int DurumID { get; set; }


        //Navigation Properties        
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }
        


        //Methots
    }
}
