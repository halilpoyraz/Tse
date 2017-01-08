namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class TanimlamaKategoriDeger
    {
        // Constructor
        public TanimlamaKategoriDeger()
        {
        }


        // Properties
        public int TanimlamaKategoriDegerId { get; set; }

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


        // Methods
    }
}