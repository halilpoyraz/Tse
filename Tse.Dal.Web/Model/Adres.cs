namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Adres
    {
        //Constructor
        public Adres()
        {
        }


        //Properties
        public int AdresId { get; set; }

        [Display(Name ="Kisi")]
        public int? KisiId { get; set; }      

        [Display(Name ="Firma")]
        public int? FirmaId { get; set; }

        [Display(Name ="Adres Tipi")]
        public int AdresTipiId { get; set; }

        [Display(Name ="Adres Satırı") MaxLength(255) Required]
        public string AdresSatiri { get; set; }

        [Display(Name ="İlçe")]
        public int IlceId { get; set; }

        [Display(Name ="Şehir")]
        public int SehirId { get; set; }

        [Display(Name ="Ülke")]
        public int UlkeId { get; set; }

        [Display(Name ="Varsayılan Adres")]
        public bool VarsayilanAdres { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Ilce Ilce { get; set; }
        public virtual Kisi Kisi { get; set; }
        public virtual Sehir Sehir { get; set; }
        public virtual Ulke Ulke { get; set; }
        public virtual Firma Firma { get; set; }

        [ForeignKey("AdresTipiId")]
        public virtual Deger AdresTipi { get; set; }


        //Methods
    }
}