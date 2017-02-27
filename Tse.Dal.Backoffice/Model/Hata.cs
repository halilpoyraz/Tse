namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Hata
    {
        //Constructor
        public Hata()
        {
        }


        //Properties
        public int HataID { get; set; }

        [Display(Name = "Başlık") MaxLength(255) Required]
        public string Baslik { get; set; }

        [Display(Name = "Detay") MaxLength(4000) Required]
        public string Detay { get; set; }        


        // Navigation Properties        

    
        // Methods
    }
}