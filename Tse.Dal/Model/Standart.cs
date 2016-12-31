namespace Tse.Dal.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Standartlar")]
    public class Standart
    {
        // Constructor
        public Standart()
        {

        }

        // Properties
        public int StandartId { get; set; }
        public int TsNo { get; set; }
        public DateTime KabulTarihi { get; set; }
        public string HazirlikGrubu { get; set; }
        public string DokumanTipi { get; set; }
        public string YururlukDurumu { get; set; }
        public string Baslik { get; set; }
        public string BaslikIng { get; set; }
        public string Turu { get; set; }
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
        public int SayfaSayisi { get; set; }
        public int Fiyati { get; set; }

    
        // Navigation Properties


        // Methods
    }
}


