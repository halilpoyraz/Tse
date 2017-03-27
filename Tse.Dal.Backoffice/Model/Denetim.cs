namespace Tse.Dal.Backoffice.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Denetim
    {
        //Constructor
        public Denetim()
        {
        }


        //Properties
        public int DenetimID { get; set; }

        [Display(Name = "Standart")]
        public int StandartID { get; set; }

        [Display(Name ="Denetim Tipi")]
        public int DenetimTipiID { get; set; }

        [Display(Name = "Firma")]
        public int FirmaID { get; set; }

        [Display(Name = "Denetim Tarihi")]
        public DateTime DenetimTarihi { get; set; }
        
        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties                
        public virtual Standart Standart { get; set; }
        public virtual Firma Firma { get; set; }

        [ForeignKey("DenetimTipiID")]
        public virtual Deger DenetimTipi { get; set; }

        public virtual Durum Durum { get; set; }


        // Methods
    }
}