namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class YururlukDurumu
    {
        // Constructor
        public YururlukDurumu()
        {
            Standartlar = new HashSet<Standart>();
        }


        // Properties
        public int YururlukDurumuId { get; set; }

        [Required MaxLength(255) Display(Name = "Yürürlük Durumu")]
        public string YururlukDurumuAdi { get; set; }

        public int TseId { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }

        // Methods
    }
}
