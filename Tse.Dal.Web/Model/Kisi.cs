namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Kisi
    {
        // Constructor
        public Kisi()
        {
            Adresler = new HashSet<Adres>();
            Epostalar = new HashSet<Eposta>();
            Telefonlar = new HashSet<Telefon>();
            VergiBilgi = new VergiBilgi();
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

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Eposta> Epostalar { get; set; }             
        public virtual ICollection<Telefon> Telefonlar { get; set; }        
        public virtual VergiBilgi VergiBilgi { get; set; }



        // Methods
    }
}
