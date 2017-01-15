namespace Tse.Dal.Web.Model
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
        public int StandartAciklamaId { get; set; }

        [Display(Name ="Başlık") MaxLength(255) Required]
        public string Baslik { get; set; }

        [Display(Name = "Detay") Column(TypeName = "text")]
        public string Detay { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual ICollection<Standart> Standartlar { get; set; }


        //Methods
    }
}