namespace Tse.Dal.Backoffice.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class StandartIcerikTipiSablon
    {
        //Constructor
        public StandartIcerikTipiSablon()
        {
        }


        //Properties
        public int StandartIcerikTipiSablonID { get; set; }

        [Display(Name ="İçerik Tipi")]
        public int StandarIcerikTipiID { get; set; }

        [Display(Name ="Başlık") MaxLength(255) Required]
        public string Baslik { get; set; }

        [Display(Name = "Detay") Column(TypeName = "text")]
        public string Detay { get; set; }

        [Display(Name ="Sıra No")]
        public int SiraNo { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; } 
        
        [ForeignKey("StandarIcerikTipiID")]                       
        public virtual Deger StandartIcerikTipiSablonu { get; set; }
        

        //Methods
    }
}