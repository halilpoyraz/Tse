namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public partial class Kategori
    {
        // Constructor
        public Kategori()
        {
        }



        // Properties
        public int KategoriId { get; set; }

        [Required MaxLength(255) Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }

        [Display (Name = "Kategori")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Deger> Degerler { get; set; }



        // Methods

    }
}