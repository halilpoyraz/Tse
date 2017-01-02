namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Standart.YururlukDurumlari")]
    public class YururlukDurumu
    {
        //Constructor
        public YururlukDurumu()
        {

        }


        //Properties
        public int YururlukDurumuId { get; set; }

        [StringLength(255)]
        public string YururlukDurumuAdi { get; set; }

        public int TseId { get; set; }

        public int DurumId { get; set; }


        // Navigation Properties        
        public virtual ICollection<Standart> Standartlar { get; set; }

        // Methods
    }
}
