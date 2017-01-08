namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Durum
    {
        // Constructor
        public Durum()
        {
            DokumanTipleri = new HashSet<DokumanTipi>();
            HazirlikGruplari = new HashSet<HazirlikGrubu>();
            ParaBirimleri = new HashSet<ParaBirimi>();
            Standartlar = new HashSet<Standart>();
            StandartTurleri = new HashSet<StandartTur>();
            YururlukDurumlari = new HashSet<YururlukDurumu>();
            Ulkeler = new HashSet<Ulke>();
            Sehirler = new HashSet<Sehir>();
            Ilceler = new HashSet<Ilce>();
        }


        // Properties
        public int DurumId { get; set; }

        [MaxLength(255), Required()]
        public string DurumAdi { get; set; }


        // Navigation Properties        
        public virtual ICollection<DokumanTipi> DokumanTipleri { get; set; }
        public virtual ICollection<HazirlikGrubu> HazirlikGruplari { get; set; }
        public virtual ICollection<ParaBirimi> ParaBirimleri { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }
        public virtual ICollection<StandartTur> StandartTurleri { get; set; }
        public virtual ICollection<YururlukDurumu> YururlukDurumlari { get; set; }
        public virtual ICollection<Ulke> Ulkeler { get; set; }
        public virtual ICollection<Sehir> Sehirler { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }

        // Methods
    }
}
