namespace Tse.Dal.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HazirlikGruplari")]
    public class HazirlikGrubu
    {
        //Constructor
        public HazirlikGrubu()
        {

        }

        //Properties        
        public int HazirlikGrubuId { get; set; }

        [StringLength(500), Required]
        public string HazirlikGrubuAdi { get; set; }

        public int TseId { get; set; }

        public int DurumId { get; set; }


        // Navigation Properties
        public virtual Durum Durum { get; set; }        


        // Methods
    }
}
