namespace Tse.Dal.Backoffice.Model
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
        public int DegerID { get; set; }

        [Display(Name ="Kategori")]
        public int KategoriID { get; set; }

        [Display(Name ="Değer Adı (Tr)")]
        public string DegerAdiTr { get; set; }

        [Display(Name = "Değer Adı (En)")]
        public string DegerAdiEn { get; set; }

        [Display(Name ="Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual ICollection<Adres> AdresTipleri { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<Standart> DokumanTipleri { get; set; }
        public virtual ICollection<Standart> HazirlikGruplari { get; set; }
        public virtual ICollection<Standart> YururlukDurumlari { get; set; }
        public virtual ICollection<Standart> StandartTurleri { get; set; }        
        public virtual ICollection<StandartIcerik> StandartIcerikTipleri { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<StandartIcerikTipiSablon> StandartIcerikTipiSablonlar { get; set; }
        public virtual ICollection<Denetim> DenetimTipleri { get; set; }


        //Methods
    }
}