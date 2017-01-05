namespace Tse.Dal.Web.Model
{
    using System.Collections.Generic;

    public partial class StandartTur
    {
        // Constructor
        public StandartTur()
        {
            Standartlar = new HashSet<Standart>();
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
