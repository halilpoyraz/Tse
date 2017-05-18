namespace Tse.Dal.Backoffice.Model
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
        public int IlceID { get; set; }

        [Display(Name ="Şehir")]
        public int SehirID { get; set; }

        [Display(Name ="İlçe Kodu")]
        public int IlceKodu { get; set; }

        [Display(Name ="İlçe Adı"), MaxLength(255), Required]
        public string IlceAdi { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }        
        public virtual Sehir Sehir { get; set; }
        public virtual ICollection<Adres> Adresler { get; set; }


        //Methods
    }
}
