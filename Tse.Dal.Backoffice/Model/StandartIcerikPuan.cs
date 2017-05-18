namespace Tse.Dal.Backoffice.Model
{
    using System.ComponentModel.DataAnnotations;

    public class StandartIcerikPuan
    {
        //Constructor
        public StandartIcerikPuan()
        {
        }


        //Properties        
        public int StandartIcerikPuanID { get; set; }        

        [Display(Name = "Tip Adı"), Required]
        public string TipAdi { get; set; }

        [Display(Name = "Puan")]
        public int Puan { get; set; }

        [Display(Name = "Durum")]
        public int DurumID { get; set; }


        //Navigation Properties 
        public virtual Durum Durum { get; set; }
        

        //Methods
    }
}