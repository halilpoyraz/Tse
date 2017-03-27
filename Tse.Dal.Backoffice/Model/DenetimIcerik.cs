namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class DenetimIcerik
    {
        //Constructor
        public DenetimIcerik()
        {
        }


        //Properties
        public int DenetimIcerikID { get; set; }

        [Display(Name ="DenetimID")]
        public int DenetimID { get; set; }

        [Display(Name = "Standart")]
        public int StandartID { get; set; }

        [Display(Name = "Standart İçerik")]
        public int StandartIcerikID { get; set; }
        

        //Navigation Properties
        public virtual Denetim Denetim { get; set; }
        public virtual Standart Standart { get; set; }
        public virtual StandartIcerik StandartIcerik { get; set; }
                

        //Methods


    }
}