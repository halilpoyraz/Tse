namespace Tse.Dal.Web.Model
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
        public int KategoriId { get; set; }

        [Display(Name ="Kategori Adı") MaxLength(255) Required]
        public string Adi { get; set; }

        [Display (Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual ICollection<Deger> Degerler { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual ICollection<StandartAtif> StandartAtiflar { get; set; }


        //Methods


    }
}