namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Durum
    {
        //Constructor
        public Durum()
        {                        
        }


        //Properties
        public int DurumId { get; set; }

        [Display(Name ="Durum Adı") MaxLength(255) Required]
        public string DurumAdi { get; set; }


        // Navigation Properties
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual ICollection<Deger> Degerler { get; set; }
        public virtual ICollection<Eposta> Epostalar { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }
        public virtual ICollection<Kategori> Kategoriler { get; set; }
        public virtual ICollection<Kisi> Kisiler { get; set; }
        public virtual ICollection<ParaBirimi> ParaBirimleri { get; set; }
        public virtual ICollection<Sehir> Sehirler { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }        
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<Ulke> Ulkeler { get; set; }
        public virtual ICollection<VergiBilgi> VergiBilgileri { get; set; }
        public virtual ICollection<Firma> Firmalar { get; set; }


        // Methods
    }
}
