namespace Tse.Dal.Backoffice.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Standart
    {
        //Constructor
        public Standart()
        {
        }


        //Properties
        public int StandartID { get; set; }

        [Display(Name = "Tse No") MaxLength(255) Required]
        public string TsNo { get; set; }

        [Display(Name = "Kabul Tarihi")]
        public DateTime KabulTarihi { get; set; }

        [Display(Name = "Hazırlık Grubu")]
        public int HazirlikGrubuID { get; set; }

        [Display(Name = "Döküman Tipi")]
        public int DokumanTipiID { get; set; }

        [Display(Name = "Yürürlük Durumu")]
        public int YururlukDurumuID { get; set; }

        [Display(Name = "Standart Tür")]
        public int StandartTurID { get; set; }

        [Display(Name = "Başlık (Tr)") Required]
        public string BaslikTr { get; set; }

        [Display(Name = "Başlık (En)") Required]
        public string BaslikEn { get; set; }

        [Display(Name = "Kapsam (Tr)")]
        public string KapsamTr { get; set; }

        [Display(Name = "Kapsam (En)")]
        public string KapsamEn { get; set; }

        [Display(Name = "Yerini Aldığı")]
        public string YeriniAldigi { get; set; }

        [Display(Name = "Tadil Eden")]
        public string TadilEden { get; set; }

        [Display(Name ="Yararlanılan Kaynak")]
        public string YararlanilanKaynak { get; set; }

        [Display(Name ="Tercüme Edildiği Std.")]
        public string TercumeEdildigiStd { get; set; }

        [Display(Name ="Ics Kodu")]
        public string IcsKodu { get; set; }

        [Display(Name ="Cen Cenelec")]
        public string CenCenelec { get; set; }

        [Display(Name ="Dili")]
        public string Dili { get; set; }

        [Display(Name ="Renk Durumu")]
        public string RenkDurumu { get; set; }

        [Display(Name ="Uygulama Durumu")]
        public string UygulamaDurumu { get; set; }

        [Display(Name ="Sayfa Sayısı")]
        public int? SayfaSayisi { get; set; }

        [Display(Name ="Fiyati")]
        public decimal? Fiyati { get; set; }

        [Display(Name ="Para Birimi")]
        public int ParaBirimiID { get; set; }

        [Display(Name ="Durum")]
        public int DurumID { get; set; }


        //Navigation Properties        
        [ForeignKey("HazirlikGrubuID")]
        public virtual Deger HazirlikGrubu { get; set; }

        [ForeignKey("DokumanTipiID")]
        public virtual Deger DokumanTipi { get; set; }

        [ForeignKey("YururlukDurumuID")]
        public virtual Deger YururlukDurumu { get; set; }

        [ForeignKey("StandartTurID")]
        public virtual Deger StandartTur { get; set; }
        
        public virtual ParaBirimi ParaBirimi { get; set; }

        public virtual Durum Durum { get; set; }

        public virtual ICollection<StandartIcerik> StandartIcerikler { get; set; }

        public virtual ICollection<StandartAtif> StandartAtiflar { get; set; }

        public virtual ICollection<StandartIcerikDenetim> StandartIcerikDenetimler { get; set; }
                
        public virtual ICollection<StandartIcerikPuan> StandartIcerikPuanlar { get; set; }


        // Methods
    }
}