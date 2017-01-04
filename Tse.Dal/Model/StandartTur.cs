﻿namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Operasyon.StandartTur")]
    public class StandartTur
    {
        // Constructor
        public StandartTur()
        {            
        }


        // Properties
        public int StandartTurId { get; set; }
        public string TurAdi { get; set; }
        public int DurumId { get; set; }


        // Navigation Properties        
        public virtual Durum Durum { get; set; }

        public virtual ICollection<Standart> Standartlar { get; set; }


        // Methods
    }
}
