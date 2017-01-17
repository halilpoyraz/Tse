namespace Tse.Dal.Web.Model
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
        public int StandartIcerikId { get; set; }

        [Display(Name = "Standart")]
        public int StandartId { get; set; }

        [Display(Name ="İçerik No") MaxLength(255) Required]
        public string BaslikNo { get; set; }

        [Display(Name ="Başlık") MaxLength(255) Required]
        public string Baslik { get; set; }

        [Display(Name ="Detay") Column(TypeName ="text")]
        public string Detay { get; set; }

        [Display(Name ="Üst İçerik")]
        public int UstIcerikId { get; set; }

        [Display(Name ="İçerik Tipi")]
        public int StandartIcerikTipiId { get; set; }

        [Display(Name ="Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual Standart Standart { get; set; } 
               
        public virtual Durum Durum { get; set; }

        [ForeignKey("StandartIcerikTipiId")]
        public virtual Deger StandartIcerikTipi { get; set; }

        public virtual ICollection<StandartAtif> StandartAtiflar { get; set; }



        //Methods


    }
}