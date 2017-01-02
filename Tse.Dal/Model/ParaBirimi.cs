namespace Tse.Dal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("Standart.ParaBirimi")]
    public class ParaBirimi
    {
        //Constructur
        public ParaBirimi()
        {

        }


        //Properties
        public int ParaBirimiId { get; set; }

        [Required]
        public string Kodu { get; set; }

        [Required]
        public string Cinsi { get; set; }

        public int DurumId { get; set; }


        //Navigation Properties        


        //Methots

    }
}
