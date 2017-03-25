namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class StandartIcerik
    {
        //Constructor
        public StandartIcerik()
        {
        }


        //Properties
        public int StandartIcerikID { get; set; }

        [Display(Name = "Standart")]
        public int StandartID { get; set; }

        [Display(Name ="Başlık No") MaxLength(255)]
        public string BaslikNo { get; set; }

        [Display(Name ="Başlık") MaxLength(255)]
        public string Baslik { get; set; }

        [Display(Name ="Detay") Column(TypeName ="text")]
        public string Detay { get; set; }

        [Display(Name ="Ebeveyn")]
        public int UstIcerikID { get; set; }

        [Display(Name ="İçerik Tipi")]
        public int StandartIcerikTipiID { get; set; }

        [Display(Name ="Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Standart Standart { get; set; } 
               
        public virtual Durum Durum { get; set; }

        [ForeignKey("StandartIcerikTipiID")]
        public virtual Deger StandartIcerikTipi { get; set; }

        public virtual ICollection<StandartAtif> StandartAtiflar { get; set; }

        public virtual StandartIcerikDenetim StandartIcerikDenetim { get; set; }


        //Methods


    }
}