namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class IlceListeleViewModel : BaseViewModel
    {
        //Constructor
        public IlceListeleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Tüm İlçeler",
                    Description = "Bu ekrandan ilçe listeleme, filtreleme, düzenleme ve yeni ilçe ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "İlçeler",
                    Link2 = "/ilce/listele",
                    Text3 = "Tüm İlçeler",
                    HeadText = "Tüm İlçeler",
                };
                
                Filter = new Filter().Create("Ilceler");
                
                Ilceler = context.Ilceler.OrderBy(u => u.Sehir.SehirAdi).ThenBy(i => i.IlceAdi).ToList();

                Sehirler = context.Sehirler.OrderBy(u => u.Ulke.UlkeAdi).ThenBy(s => s.SehirAdi).ToList();

                Ulkeler = context.Ulkeler.OrderBy(u => u.UlkeAdi).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties                
        public List<Ilce> Ilceler { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }
        public Filter Filter { get; set; }
    }

    public partial class IlceEkleViewModel : BaseViewModel
    {
        //Constructor
        public IlceEkleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Yeni İlçe Ekle",
                    Description = "Bu ekrandan yeni ilçe ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "İlçeler",
                    Link2 = "/ilce/listele",
                    Text3 = "Yeni İlçe Ekle",
                    HeadText = "Yeni İlçe Ekle"
                };
                
                Sehirler = context.Sehirler.OrderBy(u => u.SehirAdi).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties         
        public Ilce Ilce { get; set; }
        public Sehir Sehir { get; set; }
        public Durum Durum { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

    public partial class IlceDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public IlceDuzenleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Şehir Düzenle",
                    Description = "Bu ekrandan şehir düzenleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "İlçeler",
                    Link2 = "/ilce/listele",
                    Text3 = "İlçe Düzenle",
                    HeadText = "İlçe Düzenle"
                };
                                
                Sehirler = context.Sehirler.OrderBy(u => u.SehirAdi).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Ilce Ilce { get; set; }
        public Sehir Sehir { get; set; }
        public Durum Durum { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public List<Durum> Durumlar { get; set; }
    }
}