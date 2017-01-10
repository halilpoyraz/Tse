﻿namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Deger
    {
        // Constructor
        public Deger()
        {
        }



        // Properties
        public int DegerId { get; set; }

        [Display(Name = "Kategori")]
        public int KategoriId { get; set; }

        [Required MaxLength(255) Display(Name = "Değer Adı")]
        public string Adi { get; set; }

        public int SiraNo { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }



        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<Standart> DokumanTipleri { get; set; }
        public virtual ICollection<Standart> HazirlikGruplari { get; set; }
        public virtual ICollection<Standart> YururlukDurumlari { get; set; }
        public virtual ICollection<Standart> StandartTurleri { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<Adres> AdresTipleri { get; set; }



        // Methods
    }
}