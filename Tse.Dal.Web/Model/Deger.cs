namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Deger
    {
        // Constructor
        public Deger()
        {
            Telefonlar = new HashSet<Telefon>();
            DokumanTipleri = new HashSet<Standart>();
            HazirlikGruplari = new HashSet<Standart>();
            YururlukDurumlari = new HashSet<Standart>();
            StandartTurleri = new HashSet<Standart>();
        }



        // Properties
        public int DegerId { get; set; }

        [Display(Name = "Kategori")]
        public int KategoriId { get; set; }

        [Required MaxLength(255) Display(Name = "Değer Adı")]
        public string Adi { get; set; }

        public int SiraNo { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<Standart> DokumanTipleri { get; set; }
        public virtual ICollection<Standart> HazirlikGruplari { get; set; }
        public virtual ICollection<Standart> YururlukDurumlari { get; set; }
        public virtual ICollection<Standart> StandartTurleri { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }        



        // Methods
    }
}