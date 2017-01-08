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
        }

        //Properties
        public int IlceId { get; set; }

        public int SehirId { get; set; }

        public int IlceKodu { get; set; }

        [Required MaxLength(50) Display(Name = "İlçe Adı")]
        public string IlceAdi { get; set; }

        public int DurumId { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Sehir Sehir { get; set; }

        //Methods


    }
}
