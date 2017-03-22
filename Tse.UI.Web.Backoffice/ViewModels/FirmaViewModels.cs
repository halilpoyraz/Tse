namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class FirmaListeleViewModel : BaseViewModel
    {
        //Constructor
        public FirmaListeleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Tüm Firmalar",
                    Description = "Bu ekrandan firma listeleme, filtreleme, düzenleme ve yeni firma ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Firmalar",
                    Link2 = "/firma/listele",
                    Text3 = "Tüm Firmalar",
                    HeadText = "Tüm Firmalar"
                };

                Filter = new Filter().Create("Firmalar");

                Firmalar = context.Firmalar.OrderBy(s => s.FirmaID).ToList();

                Durumlar = context.Durumlar.ToList();

            }
        }

        //Properties                
        public List<Firma> Firmalar { get; set; }
        public List<Durum> Durumlar { get; set; }
        public Filter Filter { get; set; }
    }

    public partial class FirmaEkleViewModel : BaseViewModel
    {
        //Constructor
        public FirmaEkleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Yeni Firma Ekle",
                    Description = "Bu ekrandan yeni firma ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Firmalar",
                    Link2 = "/firma/listele",
                    Text3 = "Yeni Firma Ekle",
                    HeadText = ""
                };

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties 
        public Firma Firma { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

    public partial class FirmaDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public FirmaDuzenleViewModel(int? firmaID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Firma Düzenle",
                    Description = "Bu ekrandan firma düzenleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Firma",
                    Link2 = "/firma/listele",
                    Text3 = "Firma Düzenle",
                    HeadText = "Firma Düzenle"
                };

                FilterAdres = new Filter().Create("FirmaAdres", firmaID);                 
                Firma = context.Firmalar.Find(firmaID);
                Adresler = context.Adresler.Include("Ulke").Include("Sehir").Include("Ilce").Include("AdresTipi").Where(a => a.FirmaID == firmaID).ToList();
                AdresTipleri = context.Degerler.Where(d=>d.KategoriID==6).ToList();
                Ilceler = context.Ilceler.Where(i => i.DurumID == 1).OrderBy(i=>i.IlceAdi).ToList();
                Sehirler = context.Sehirler.Where(i => i.DurumID == 1).OrderBy(i => i.SehirAdi).ToList();
                Ulkeler = context.Ulkeler.Where(i => i.DurumID == 1).OrderBy(i => i.UlkeAdi).ToList();
                Durumlar = context.Durumlar.ToList();

                FilterTelefon = new Filter().Create("FirmaTelefon", firmaID);
                TelefonTipleri = context.Degerler.Where(d => d.KategoriID == 5).ToList();
                Telefonlar = context.Telefonlar.Include("TelefonTipi").Where(a => a.FirmaID == firmaID).ToList();

                FilterEposta = new Filter().Create("FirmaEposta", firmaID);
                Epostalar = context.Epostalar.Where(e=>e.FirmaID==firmaID).ToList();

                FilterFaturaBilgi = new Filter().Create("FirmaFaturaBilgi", firmaID);
                FaturaBilgileri = context.FaturaBilgileri.Include("Adres").Where(f => f.FirmaID == firmaID).ToList();
                Adresler = context.Adresler.Where(f=>f.FirmaID==firmaID).ToList();
            }
        }

        //Properties
        public Firma Firma { get; set; }
        public Adres Adres { get; set; }
        public Filter FilterAdres { get; set; }
        public Durum Durum { get; set; }        
        public List<Durum> Durumlar { get; set; }
        public List<Adres> Adresler { get; set; }
        public List<Ilce> Ilceler { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public List<Deger> AdresTipleri { get; set; }

        public Filter FilterTelefon { get; set; }
        public List<Telefon> Telefonlar{ get; set; }
        public Telefon Telefon{ get; set; }
        public List<Deger> TelefonTipleri { get; set; }

        public Filter FilterEposta { get; set; }
        public List<Eposta> Epostalar { get; set; }
        public Eposta Eposta { get; set; }

        public Filter FilterFaturaBilgi { get; set; }
        public FaturaBilgi FaturaBilgi { get; set; }
        public List<FaturaBilgi> FaturaBilgileri { get; set; }
    }
}