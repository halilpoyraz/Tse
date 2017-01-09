namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TanimlamaDeger
    {
        // Constructor
        public TanimlamaDeger()
        {
            KisiTelefonlar = new HashSet<KisiTelefon>();
        }


        // Properties
        public int TanimlamaDegerId { get; set; }

        [Display(Name = "Kategori")]
        public int TanimlamaKategoriId { get; set; }

        [Required MaxLength(255) Display(Name = "Değer Adı")]
        public string DegerAdi { get; set; }

        public int SıraNo { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual TanimlamaKategori TanimlamaKategori { get; set; }
        public virtual ICollection<KisiTelefon> KisiTelefonlar { get; set; }

        // Methods
    }
}