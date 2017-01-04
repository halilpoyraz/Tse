namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Operasyon.ParaBirimi")]
    public class ParaBirimi
    {
        // Constructor
        public ParaBirimi()
        {
        }


        // Properties
        public int ParaBirimiId { get; set; }

        [Required]
        public string Kodu { get; set; }

        [Required]
        public string Cinsi { get; set; }

        public int DurumId { get; set; }


        // Navigation Properties        
        public virtual Durum Durum { get; set; }

        public virtual ICollection<Standart> Standartlar { get; set; }


        // Methots
    }
}
