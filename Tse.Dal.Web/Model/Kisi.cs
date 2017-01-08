namespace Tse.Dal.Web.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Kisi
    {
        // Constructor
        public Kisi()
        {                
        }


        // Properties
        public int KisiId { get; set; }

        [Required MaxLength(50) Display(Name = "Adı")]
        public string Ad { get; set; }

        [Required MaxLength(50) Display(Name = "Soyadı")]
        public string Soyad { get; set; }

        [Display(Name = "Tc Kimlik No")]
        public long TcKimlikNo { get; set; }

        public int UlkeId { get; set; }

        public int SehirId { get; set; }


        // Navigation Properties
        public virtual Ulke Ulke { get; set; }
        public virtual Sehir Sehir { get; set; }

        // Methods
    }
}
