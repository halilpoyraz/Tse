namespace Tse.Dal.Backoffice.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public partial class Kategori
    {
        //Constructor
        public Kategori()
        {
        }


        //Properties
        public int KategoriID { get; set; }

        [Display(Name ="Kategori Adı") MaxLength(255) Required]
        public string Adi { get; set; }

        [Display (Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual ICollection<Deger> Degerler { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual ICollection<StandartAtif> StandartAtiflar { get; set; }
        public virtual ICollection<StandartAtifTipiSablon> StandartAtifTipiSablonlar { get; set; }

        //Methods


    }
}