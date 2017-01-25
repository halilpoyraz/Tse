namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class StandartAciklama
    {
        //Constructor
        public StandartAciklama()
        {
        }


        //Properties
        public int StandartAciklamaID { get; set; }

        [Display(Name ="Başlık") MaxLength(255) Required]
        public string Baslik { get; set; }

        [Display(Name = "Detay") Column(TypeName = "text")]
        public string Detay { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }               


        //Methods
    }
}