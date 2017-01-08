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
            Kisiler = new HashSet<Kisi>();
            KisiEpostalar = new HashSet<KisiEposta>();
            KisiTelefonlar = new HashSet<KisiTelefon>();
            TanimlamaKategorileri = new HashSet<TanimlamaKategori>();
            TanimlamaKategoriDegerleri = new HashSet<TanimlamaKategoriDeger>();
            KisiVergiBilgileri = new HashSet<KisiVergiBilgi>();            
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
        public virtual ICollection<Kisi> Kisiler { get; set; }
        public virtual ICollection<KisiEposta> KisiEpostalar { get; set; }
        public virtual ICollection<KisiTelefon> KisiTelefonlar { get; set; }
        public virtual ICollection<TanimlamaKategori> TanimlamaKategorileri { get; set; }
        public virtual ICollection<TanimlamaKategoriDeger> TanimlamaKategoriDegerleri { get; set; }
        public virtual ICollection<KisiVergiBilgi> KisiVergiBilgileri { get; set; }
        // Methods
    }
}
