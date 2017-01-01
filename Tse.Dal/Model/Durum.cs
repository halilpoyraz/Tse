namespace Tse.Dal.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Durumlar")]
    public class Durum
    {
        //Constructor
        public Durum()
        {

        }

        //Properties
        public int DurumId { get; set; }

        [StringLength(50), Required]
        public string DurumAdi { get; set; }


        // Navigation Properties


        // Methods
    }

}
