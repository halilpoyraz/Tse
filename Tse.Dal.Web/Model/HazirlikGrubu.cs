namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class HazirlikGrubu
    {
        // Constructor
        public HazirlikGrubu()
        {
            Standartlar = new HashSet<Standart>();
        }


        // Properties        
        public int HazirlikGrubuId { get; set; }

        [StringLength(500), Required]
        public string HazirlikGrubuAdi { get; set; }

        public int TseId { get; set; }

        public int DurumId { get; set; }        

        // Navigation Properties      
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }

        // Methods
    }
}
