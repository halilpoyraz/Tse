namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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

        [Display(Name ="Değer Adı") MaxLength(255) Required]
        public string Adi { get; set; }

        [Display(Name ="Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<Adres> AdresTipleri { get; set; }
        public virtual ICollection<Standart> DokumanTipleri { get; set; }
        public virtual ICollection<Standart> HazirlikGruplari { get; set; }
        public virtual ICollection<Standart> YururlukDurumlari { get; set; }
        public virtual ICollection<Standart> StandartTurleri { get; set; }
        public virtual ICollection<StandartIcerik> StandartIcerikTipleri { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }


        //Methods
    }
}