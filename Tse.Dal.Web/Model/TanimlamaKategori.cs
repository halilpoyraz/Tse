namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public partial class TanimlamaKategori
    {
        // Constructor
        public TanimlamaKategori()
        {
            TanimlamaDegerleri = new HashSet<TanimlamaDeger>();
        }

        // Properties
        public int TanimlamaKategoriId { get; set; }

        [Required MaxLength(255) Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }

        [Display (Name = "Kategori")]
        public int DurumId { get; set; }

        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<TanimlamaDeger> TanimlamaDegerleri { get; set; }

        // Methods

    }
}