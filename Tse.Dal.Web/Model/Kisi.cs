namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Kisi
    {
        // Constructor
        public Kisi()
        {
            KisiEpostalar = new HashSet<KisiEposta>();
            KisiTelefonlar = new HashSet<KisiTelefon>();            
        }


        // Properties
        public int KisiId { get; set; }

        [Required MaxLength(50) Display(Name = "Adı")]
        public string Ad { get; set; }

        [Required MaxLength(50) Display(Name = "Soyadı")]
        public string Soyad { get; set; }

        [Display(Name = "Tc Kimlik No")]
        public long TcKimlikNo { get; set; }

        [MaxLength(50) Display(Name = "Ünvanı")]
        public string Unvan { get; set; }

        [Display(Name = "Ülke")]
        public int UlkeId { get; set; }

        [Display(Name = "Şehir")]
        public int SehirId { get; set; }

        [Display(Name = "İlçe")]
        public int IlceId { get; set; }        

        [Display(Name = "Durum")]
        public int DurumId { get; set; }
        

        // Navigation Properties
        public virtual Ulke Ulke { get; set; }
        public virtual Sehir Sehir { get; set; }
        public virtual Ilce Ilce { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual ICollection<KisiEposta> KisiEpostalar { get; set; }
        public virtual ICollection<KisiTelefon> KisiTelefonlar { get; set; }
        public virtual KisiVergiBilgi KisiVergiBilgileri { get; set; }


        // Methods
    }
}
