namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Ilce
    {
        //Constructor
        public Ilce()
        {
        }


        //Properties
        public int IlceId { get; set; }

        [Display(Name ="Şehir")]
        public int SehirId { get; set; }

        [Display(Name ="İlçe Kodu")]
        public int IlceKodu { get; set; }

        [Display(Name ="İlçe Adı") MaxLength(255) Required]
        public string IlceAdi { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }        
        public virtual Sehir Sehir { get; set; }
        public virtual ICollection<Adres> Adresler { get; set; }


        //Methods
    }
}
