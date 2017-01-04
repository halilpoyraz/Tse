namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Operasyon.Durum")]
    public class Durum
    {
        // Constructor
        public Durum()
        {            
        }


        // Properties
        public int DurumId { get; set; }

        [StringLength(255), Required]       
        public string DurumAdi { get; set; }
      

        // Navigation Properties        
       

        // Methods
    }
}
