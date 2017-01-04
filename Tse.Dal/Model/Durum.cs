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
        public virtual ICollection<DokumanTipi> DokumanTipleri { get; set; }

        public virtual ICollection<HazirlikGrubu> HazirlikGruplari { get; set; }

        public virtual ICollection<ParaBirimi> ParaBirimleri { get; set; }

        public virtual ICollection<Standart> Standartlar { get; set; }

        public virtual ICollection<StandartTur> StandartTurleri { get; set; }

        public virtual ICollection<YururlukDurumu> YururlukDurumlari { get; set; }

        // Methods
    }
}
