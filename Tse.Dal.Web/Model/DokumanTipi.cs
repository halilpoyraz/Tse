namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class DokumanTipi
    {
        // Constructor
        public DokumanTipi()
        {
            Standartlar = new HashSet<Standart>();
        }


        // Properties
        public int DokumanTipiId { get; set; }

        [MaxLength(255), Required]
        public string DokumanTipiAdi { get; set; }

        public int TseId { get; set; }

        public int DurumId { get; set; }


        // Navigation Properties      
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }

        // Methods
    }
}
