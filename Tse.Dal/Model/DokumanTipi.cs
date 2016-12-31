namespace Tse.Dal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DokumanTipi
    {
        // Constructor
        public DokumanTipi()
        {

        }


        // Properties
        public int DokumanTipiId { get; set; }

        [StringLength(255), Required]       
        public string DokumanTipiAdi { get; set; }

        public int TseId { get; set; }

        public int Durum { get; set; }


        // Navigation Properties


        // Methods
    }

    public class YururlulukDurumu
    {
        //Constructor
        public YururlulukDurumu()
        {

        }


        //Properties
        public int YururlulukDurumuId { get; set; }

        [StringLength(255)]
        public string YururlulukDurumuAdi { get; set; }

        public int TseId { get; set; }

        public int Durum { get; set; }

        
        // Navigation Properties


        // Methods
    }

    public class Durumu
    {
        //Constructor
        public Durumu()
        {

        }

        //Properties
        public int DurumuId { get; set; }

        [StringLength(50), Required]
        public string DurumAdi { get; set; }


        // Navigation Properties


        // Methods
    }

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

        public int Durum { get; set; }


        // Navigation Properties


        // Methods
    }
}
