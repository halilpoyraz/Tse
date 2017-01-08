﻿namespace Tse.Dal.Web.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public partial class TanimlamaKategori
    {
        // Constructor
        public TanimlamaKategori()
        {
            TanimlamaKategoriDegerleri = new HashSet<TanimlamaKategoriDeger>();
        }

        // Properties
        public int TanimlamaKategoriId { get; set; }

        [Required MaxLength(255) Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }

        [Display (Name = "Kategori")]
        public int DurumId { get; set; }

        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<TanimlamaKategoriDeger> TanimlamaKategoriDegerleri { get; set; }

        // Methods

    }
}