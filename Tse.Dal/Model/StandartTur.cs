namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Standart.StandartTurler")]
    public class StandartTur
    {
        // Contructor
        public StandartTur()
        {
            
        }


        // Properties
        public int StandartTurId { get; set; }
        public string TurAdi { get; set; }
        public int DurumId { get; set; }

        
        // Navigation Properties
        public virtual Durum Durum { get; set; }
        public virtual List<Standart> Standartlar { get; set; }

        // Methods
    }
}
