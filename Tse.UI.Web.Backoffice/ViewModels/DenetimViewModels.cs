﻿namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class DenetimListeleViewModel : BaseViewModel
     {
        //Constructor
        public DenetimListeleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Tüm Denetimler",
                    Description = "Bu ekrandan denetim listeleme, filtreleme, düzenleme ve yeni denetim ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Denetimler",
                    Link2 = "/denetim/listele",
                    Text3 = "Tüm Denetimler",
                    HeadText = "Tüm Denetimler"
                };

                Filter = new Filter().Create("Denetimler");

                Denetimler = context.Denetimler.Include("Standart").Include("DenetimTipi").Include("Firma").OrderBy(s=>s.DenetimID).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties                
        public List<Denetim> Denetimler { get; set; }
        public List<Durum> Durumlar { get; set; }
        public Filter Filter { get; set; }
    }
        
    public partial class DenetimEkleViewModel : BaseViewModel
    {
        //Constructor
        public DenetimEkleViewModel()
        {
            using (TseBackofficeContext context =  new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Yeni Denetim Ekle",
                    Description = "Bu ekrandan yeni denetim ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Denetimler",
                    Link2 = "/denetim/listele",
                    Text3 = "Yeni Denetim Ekle",
                    HeadText = "Yeni Denetim Ekle"
                };                
                Standartlar = context.Standartlar.Where(s => s.DurumID == 1).ToList();
                DenetimTipleri = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 10).OrderBy(m => m.DegerAdiTr).ToList();
                Firmalar = context.Firmalar.Where(f => f.DurumID == 1).OrderBy(f => f.TicaretUnvani).ToList();
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Denetim Denetim { get; set; }
        public Standart Standart { get; set; }
        public Firma Firma { get; set; }
        public List<Deger> DenetimTipleri { get; set; }
        public List<Firma> Firmalar { get; set; }
        public List<Standart> Standartlar { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

    /*
    public partial class StandartDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public StandartDuzenleViewModel(int? standartID, int? standartIcerikID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {                
                Meta = new Meta()
                {
                    Title = "Standart Düzenle",
                    Description = "Bu ekrandan standart düzenleme işlemleri yapılmaktadır."
                };
                                
                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Standartlart",
                    Link2 = "/standart/listele",
                    Text3 = "Standart Düzenle",
                    HeadText = "Standart Düzenle"
                };

                Filter = new Filter().Create("StandartIcerikler", standartID);

                Standart = context.Standartlar.Find(standartID);

                if (standartIcerikID != null) {
                    StandartIcerik = context.StandartIcerikler.Include("StandartIcerikDenetim").SingleOrDefault(s=>s.StandartIcerikID == standartIcerikID); }

                DokumanTipleri = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 1).OrderBy(m => m.DegerAdiTr).ToList();
                HazirlikGruplari = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 2).OrderBy(m => m.DegerAdiTr).ToList();
                YururlukDurumlari = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 3).OrderBy(m => m.DegerAdiTr).ToList();
                StandartTurler = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 4).OrderBy(m => m.DegerAdiTr).ToList();
                ParaBirimleri = context.ParaBirimleri.Where(m => m.DurumID == 1).OrderBy(m => m.Kodu).ToList();
                StandartIcerikler = context.StandartIcerikler.Where(m=>m.StandartID== standartID).OrderBy(m => m.SiraNo).ToList();
                StandartIcerikTipleri = context.Degerler.Where(m => m.KategoriID == 7).OrderBy(m=>m.DegerAdiTr).ToList();
                SablonTipleri = context.Kategoriler.Where(m=> m.KategoriID == 8 || m.KategoriID == 9).ToList();
                StandartAtifTipiSablonlar = context.StandartAtifTipiSablonlar.Where(s => s.DurumID == 1).ToList();
                StandartAtiflar = context.StandartAtiflar.Where(s => s.StandartID == standartID && s.DurumID==1).OrderBy(s=>s.SiraNo).ToList();
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Standart Standart { get; set; }
        public StandartIcerik StandartIcerik { get; set; }
        public Filter Filter { get; set; }
        public Durum Durum { get; set; }
        public List<Deger> DokumanTipleri { get; set; }
        public List<Deger> HazirlikGruplari { get; set; }
        public List<Deger> YururlukDurumlari { get; set; }
        public List<Deger> StandartTurler { get; set; }
        public List<ParaBirimi> ParaBirimleri { get; set; }
        public List<StandartIcerik> StandartIcerikler { get; set; }
        public List<Deger> StandartIcerikTipleri { get; set; }
        public List<Durum> Durumlar { get; set; }
        public List<Kategori> SablonTipleri { get; set; }
        public List<StandartAtifTipiSablon> StandartAtifTipiSablonlar { get; set; }
        public List<StandartAtif> StandartAtiflar { get; set; }
    }    
    */
}