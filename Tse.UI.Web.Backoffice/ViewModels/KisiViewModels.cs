namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class KisiListeleViewModel : BaseViewModel
    {
        //Constructor
        public KisiListeleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Tüm Kişiler",
                    Description = "Bu ekrandan kişi listeleme, filtreleme, düzenleme ve yeni kişi ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Kişiler",
                    Link2 = "/kisi/listele",
                    Text3 = "Tüm Kişiler",
                    HeadText = "Tüm Kişiler"
                };

                Filter = new Filter().Create("Kisiler");

                Kisiler = context.Kisiler.OrderBy(s => s.KisiID).ToList();

                Durumlar = context.Durumlar.ToList();

            }
        }

        //Properties                
        public List<Kisi> Kisiler { get; set; }
        public List<Durum> Durumlar { get; set; }
        public Filter Filter { get; set; }
    }

    public partial class KisiEkleViewModel : BaseViewModel
    {
        //Constructor
        public KisiEkleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Yeni Kişi Ekle",
                    Description = "Bu ekrandan yeni kişi ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Kişiler",
                    Link2 = "/kisi/listele",
                    Text3 = "Yeni Kişi Ekle",
                    HeadText = "Yeni Kişi Ekle"
                };

                Durumlar = context.Durumlar.ToList();
                Firmalar = context.Firmalar.Where(f => f.DurumID == 1).ToList();
            }
        }

        //Properties 
        public Kisi Kisi { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
        public List<Firma> Firmalar { get; set; }
    }

    public partial class KisiDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public KisiDuzenleViewModel(int? kisiID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Kişi Düzenle",
                    Description = "Bu ekrandan kişi düzenleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Kişi",
                    Link2 = "/kisi/listele",
                    Text3 = "Kişi Düzenle",
                    HeadText = "Kişi Düzenle"
                };

                FilterAdres = new Filter().Create("KisiAdres", kisiID);
                Kisi = context.Kisiler.Find(kisiID);
                Adresler = context.Adresler.Include("Ulke").Include("Sehir").Include("Ilce").Include("AdresTipi").Where(a => a.FirmaID == kisiID).ToList();
                AdresTipleri = context.Degerler.Where(d => d.KategoriID == 6).ToList();
                Ilceler = context.Ilceler.Where(i => i.DurumID == 1).OrderBy(i => i.IlceAdi).ToList();
                Sehirler = context.Sehirler.Where(i => i.DurumID == 1).OrderBy(i => i.SehirAdi).ToList();
                Ulkeler = context.Ulkeler.Where(i => i.DurumID == 1).OrderBy(i => i.UlkeAdi).ToList();
                Durumlar = context.Durumlar.ToList();

                FilterTelefon = new Filter().Create("FirmaTelefon", kisiID);
                TelefonTipleri = context.Degerler.Where(d => d.KategoriID == 5).ToList();
                Telefonlar = context.Telefonlar.Include("TelefonTipi").Where(a => a.KisiID == kisiID).ToList();

                FilterEposta = new Filter().Create("KisiEposta", kisiID);
                Epostalar = context.Epostalar.Where(e => e.KisiID == kisiID).ToList();

                FilterFaturaBilgi = new Filter().Create("KisiFaturaBilgi", kisiID);
                FaturaBilgileri = context.FaturaBilgileri.Include("Adres").Where(f => f.KisiID == kisiID).ToList();
                Adresler = context.Adresler.Where(f => f.KisiID == kisiID).ToList();
                Firmalar = context.Firmalar.Where(f => f.DurumID == 1).OrderBy(f => f.TicaretUnvani).ToList();
            }
        }

        //Properties
        public Kisi Kisi { get; set; }
        public Adres Adres { get; set; }
        public Filter FilterAdres { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
        public List<Adres> Adresler { get; set; }
        public List<Ilce> Ilceler { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public List<Deger> AdresTipleri { get; set; }
        public List<Firma> Firmalar { get; set; }

        public Filter FilterTelefon { get; set; }
        public List<Telefon> Telefonlar { get; set; }
        public Telefon Telefon { get; set; }
        public List<Deger> TelefonTipleri { get; set; }

        public Filter FilterEposta { get; set; }
        public List<Eposta> Epostalar { get; set; }
        public Eposta Eposta { get; set; }

        public Filter FilterFaturaBilgi { get; set; }
        public FaturaBilgi FaturaBilgi { get; set; }
        public List<FaturaBilgi> FaturaBilgileri { get; set; }
    }
}