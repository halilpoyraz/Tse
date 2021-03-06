﻿namespace Tse.Dal.Backoffice.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class Eposta
    {
        //Constructor
        public Eposta()
        {
        }


        //Properties
        public int EpostaID { get; set; }

        [Display(Name = "Kişi")]
        public int? KisiID { get; set; }

        [Display(Name = "Firma")]
        public int? FirmaID { get; set; }

        [Display(Name = "E-Posta Adresi"), MaxLength(255), Required]
        public string EpostaAdresi { get; set; }

        [Display(Name = "Varsayılan E-posta")]
        public bool VarsayilanEposta { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Durum Durum { get; set; }

        public virtual Kisi Kisi { get; set; }

        public virtual Firma Firma { get; set; }



        //Methods
    }
}