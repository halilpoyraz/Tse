namespace Tse.Dal.Web.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Ilce
    {
        // Constructor
        public Ilce()
        {
            Adresler = new HashSet<Adres>();
        }



        //Properties
        public int IlceId { get; set; }

        public int SehirId { get; set; }

        public int IlceKodu { get; set; }

        [Required MaxLength(50) Display(Name = "İlçe Adı")]
        public string IlceAdi { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Sehir> Sehir { get; set; }
        public virtual ICollection<Adres> Adresler { get; set; }



        //Methods


    }
}
