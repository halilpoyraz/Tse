namespace Tse.Dal.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StandartTurler")]
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

        // Methods
    }
}
