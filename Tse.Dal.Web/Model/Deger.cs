namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Deger
    {
        //Constructor
        public Deger()
        {
        }


        //Properties
        public int DegerId { get; set; }

        [Display(Name ="Kategori")]
        public int KategoriId { get; set; }

        [Display(Name ="Değer 1")]
        public string Deger1 { get; set; }

        [Display(Name = "Değer 2")]
        public string Deger2 { get; set; }

        [Display(Name = "Değer 3")]
        public string Deger3 { get; set; }

        [Display(Name = "Değer 4")]
        public string Deger4 { get; set; }

        [Display(Name = "Değer 5")]
        public string Deger5 { get; set; }

        [Display(Name ="Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual ICollection<Adres> AdresTipleri { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<Standart> DokumanTipleri { get; set; }
        public virtual ICollection<Standart> HazirlikGruplari { get; set; }
        public virtual ICollection<Standart> YururlukDurumlari { get; set; }
        public virtual ICollection<Standart> StandartTurleri { get; set; }
        public virtual ICollection<StandartAtif> StandartAtiflar { get; set; }
        public virtual ICollection<StandartIcerik> StandartIcerikTipleri { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }

        //Methods
    }
}