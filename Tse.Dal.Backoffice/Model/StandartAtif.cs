namespace Tse.Dal.Backoffice.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class StandartAtif
    {
        //Constructor
        public StandartAtif()
        {
        }

        //Properties
        public int StandartAtifID { get; set; }

        [Display(Name ="Standart")]
        public int StandartID { get; set; }

        [Display(Name ="Stadart İçerik")]
        public int StandartIcerikID { get; set; }

        [Display(Name ="Kategori")]
        public int KategoriID { get; set; }

        [Display(Name ="Değer")]
        public int DegerID { get; set; }

        [Display(Name ="Sıra")]
        public int SiraNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Deger Deger { get; set; }
        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Standart Standart { get; set; }
        public virtual StandartIcerik StandartIcerik { get; set; }



        //Methods
    }
}