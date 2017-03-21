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
                    Description = "Bu ekrandan firma listeleme, filtreleme, düzenleme ve yeni standart ekleme işlemleri yapılmaktadır."
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
                    Text3 = "Firma Düzenle",
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
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Firma Firma { get; set; }
        public Filter FilterAdres { get; set; }
        public Durum Durum { get; set; }        
        public List<Durum> Durumlar { get; set; }
        public List<Adres> Adresler { get; set; }
    }
}