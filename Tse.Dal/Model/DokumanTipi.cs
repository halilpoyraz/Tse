namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Standart.DokumanTipleri")]
    public class DokumanTipi
    {
        // Constructor
        public DokumanTipi()
        {

        }

        // Properties
        public int DokumanTipiId { get; set; }

        [StringLength(255), Required]       
        public string DokumanTipiAdi { get; set; }

        public int TseId { get; set; }

        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual List<Standart> Standartlar { get; set; }
       

        // Methods
    }
}
