﻿using System.ComponentModel.DataAnnotations;

namespace Tse.Dal.Backoffice.Model
{
    public class StandartIcerikDenetim
    {
        //Constructor
        public StandartIcerikDenetim()
        {
        }

        //Properties
        [Display(Name ="Standart İçerik Denetim")]
        public int StandartIcerikDenetimID { get; set; }

        [Display(Name = "Standart")]
        public int StandartID { get; set; }

        [Display(Name = "Standart İçerik")]
        public int StandartIcerikID { get; set; }

        [Display(Name = "Seçmeli")]
        public bool Secmeli { get; set; }

        [Display(Name = "Zorunlu")]
        public bool Zorunlu { get; set; }

        [Display(Name = "Bilgi Amaçlı")]
        public bool BilgiAmacli { get; set; }

        [Display(Name = "Kurum Yeterlilik Sertifikası")]
        public bool KurumYeterlilikSertifikasi { get; set; }

        [Display(Name = "Ürün Seritifikası")]
        public bool UrunSertifikasi { get; set; }

        [Display(Name = "Durum")]
        public int DurumID { get; set; }


        //Navigation Properties
        public virtual Standart Standart { get; set; }
        public virtual StandartIcerik StandartIcerik { get; set; }
        public virtual Durum Durum { get; set; }


        //Methods
    }
}