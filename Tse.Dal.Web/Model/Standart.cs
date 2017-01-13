namespace Tse.Dal.Web.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Standart
    {
        //Constructor
        public Standart()
        {
        }


        //Properties
        public int StandartId { get; set; }

        [Display(Name = "Tse No") MaxLength(255) Required]
        public string TsNo { get; set; }

        [Display(Name = "Kabul Tarihi")]
        public DateTime KabulTarihi { get; set; }

        [Display(Name = "Hazırlık Grubu")]
        public int HazirlikGrubuId { get; set; }

        [Display(Name = "Döküman Tipi")]
        public int DokumanTipiId { get; set; }

        [Display(Name = "Yürürlük Durumu")]
        public int YururlukDurumuId { get; set; }

        [Display(Name = "Standart Tür")]
        public int StandartTurId { get; set; }

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

        [Display(Name ="Uluslararası Karşılığı")]
        public string UluslararasiKarsiliklar { get; set; }

        [Display(Name ="Tercüme Edildiği Standart")]
        public string TercumeEdildigiStd { get; set; }

        [Display(Name ="Ics Kodu")]
        public string IcsKodu { get; set; }

        [Display(Name ="Atıf Yapılan Standart")]
        public string AtifYapilanStd { get; set; }

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
        public int ParaBirimiId { get; set; }

        [Display(Name ="Durum")]
        public int DurumId { get; set; }


        //Navigation Properties        
        [ForeignKey("HazirlikGrubuId")]
        public virtual Deger HazirlikGrubu { get; set; }

        [ForeignKey("DokumanTipiId")]
        public virtual Deger DokumanTipi { get; set; }

        [ForeignKey("YururlukDurumuId")]
        public virtual Deger YururlukDurumu { get; set; }

        [ForeignKey("StandartTurId")]
        public virtual Deger StandartTur { get; set; }
        
        public virtual ParaBirimi ParaBirimi { get; set; }

        public virtual Durum Durum { get; set; }


        // Methods
    }
}