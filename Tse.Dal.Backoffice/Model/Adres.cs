namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Adres
    {
        //Constructor
        public Adres()
        {
        }


        //Properties
        public int AdresID { get; set; }

        [Display(Name ="Kisi")]
        public int? KisiID { get; set; }      

        [Display(Name ="Firma")]
        public int? FirmaID { get; set; }

        [Display(Name ="Adres Tipi")]
        public int AdresTipiID { get; set; }

        [Display(Name ="Adres Satırı") MaxLength(255) Required]
        public string AdresSatiri { get; set; }

        [Display(Name ="İlçe")]
        public int IlceID { get; set; }

        [Display(Name ="Şehir")]
        public int SehirID { get; set; }

        [Display(Name ="Ülke")]
        public int UlkeID { get; set; }

        [Display(Name ="Varsayılan Adres")]
        public bool VarsayilanAdres { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Ilce Ilce { get; set; }
        public virtual Kisi Kisi { get; set; }
        public virtual Sehir Sehir { get; set; }
        public virtual Ulke Ulke { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual ICollection<FaturaBilgi> FaturaBilgileri { get; set; }

        [ForeignKey("AdresTipiID")]
        public virtual Deger AdresTipi { get; set; }


        //Methods
    }
}