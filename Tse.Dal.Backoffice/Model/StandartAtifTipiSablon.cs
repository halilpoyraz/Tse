namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class StandartAtifTipiSablon
    {
        //Contructor
        public StandartAtifTipiSablon()
        {
        }

        //Properties
        [Display(Name ="Standart Atıf Tipi Şablon")]
        public int StandartAtifTipiSablonID { get; set; }

        [Display(Name = "Kategori")]
        public int KategoriID { get; set; }

        [Display(Name = "Değer 1")]
        public string Deger1 { get; set; }

        [Display(Name = "Değer 2")]
        public string Deger2 { get; set; }


        [Display(Name = "Değer 3")]
        public string Deger3 { get; set; }

        [Display(Name = "Değer 4")]
        public string Deger4 { get; set; }

        [Display(Name = "Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<StandartAtif> StandartAtiflar{ get; set; }


        //Methods
    }
}