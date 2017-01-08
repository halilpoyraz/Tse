namespace Tse.Dal.Web.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Standart
    {
        // Constructor
        public Standart()
        {
        }


        // Properties
        public int StandartId { get; set; }

        public string TsNo { get; set; }

        public DateTime KabulTarihi { get; set; }

        public int HazirlikGrubuId { get; set; }

        public int DokumanTipiId { get; set; }

        public int YururlukDurumuId { get; set; }

        [Required]
        public string Baslik { get; set; }

        [Required]
        public string BaslikIng { get; set; }

        public int StandartTurId { get; set; }

        public string Kapsam { get; set; }

        public string KapsamIng { get; set; }

        public string YeriniAldigi { get; set; }

        public string TadilEden { get; set; }

        public string YararlanilanKaynak { get; set; }

        public string UluslararasiKarsiliklar { get; set; }

        public string TercumeEdildigiStd { get; set; }

        public string IcsKodu { get; set; }

        public string AtifYapilanStd { get; set; }

        public string CenCenelec { get; set; }

        public string Dili { get; set; }

        public string RenkDurumu { get; set; }

        public string UygulamaDurumu { get; set; }

        public int? SayfaSayisi { get; set; }

        public decimal? Fiyati { get; set; }

        public int ParaBirimiId { get; set; }

        [Display(Name = "Durum")]
        public int DurumId { get; set; }


        // Navigation Properties        
        public virtual HazirlikGrubu HazirlikGrubu { get; set; }
        public virtual DokumanTipi DokumanTipi { get; set; }
        public virtual YururlukDurumu YururlukDurumu { get; set; }
        public virtual StandartTur StandartTur { get; set; }
        public virtual ParaBirimi ParaBirimi { get; set; }
        public virtual Durum Durum { get; set; }



        // Methods
    }
}