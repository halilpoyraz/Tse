﻿namespace Tse.Dal.Backoffice.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Sehir
    {
        //Constructor
        public Sehir()
        {
        }


        //Properties
        public int SehirID { get; set; }
        
        [Display(Name ="Ulke")]
        public int UlkeID { get; set; }

        [Display(Name = "Şehir Adı"), MaxLength(255), Required]
        public string SehirAdi { get; set; }

        [Display(Name = "Durum")]
        public int DurumID { get; set; }


        //Navigation Propertis
        public virtual ICollection<Adres> Adresler { get; set; }        
        public virtual ICollection<Ilce> Ilceler { get; set; }
        public virtual Durum Durum { get; set; }        
        public virtual Ulke Ulke { get; set; }
        


        //Methods
    }
}
