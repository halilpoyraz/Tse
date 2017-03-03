namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class SehirListeleViewModel : BaseViewModel
     {
        //Constructor
        public SehirListeleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Tüm Şehirler",
                    Description = "Bu ekrandan şehir listeleme, filtreleme, düzenleme ve yeni şehir ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Şehirler",
                    Link2 = "/sehir/listele",
                    Text3 = "Tüm Şehirler",
                    HeadText = "Tüm Şehirler"
                };
                
                Filter = new Filter().Create("Sehirler");
                                                
                Sehirler = context.Sehirler.OrderBy(u=>u.Ulke.UlkeAdi).ThenBy(s=>s.SehirAdi).ToList();

                Ulkeler = context.Ulkeler.OrderBy(u=>u.UlkeAdi).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties                
        public List<Sehir> Sehirler { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }
        public Filter Filter { get; set; }
    }

    public partial class SehirEkleViewModel : BaseViewModel
    {
        //Constructor
        public SehirEkleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Yeni Şehir Ekle",
                    Description = "Bu ekrandan yeni şehir ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Şehirler",
                    Link2 = "/sehir/listele",
                    Text3 = "Yeni Şehir Ekle",
                    HeadText = "Yeni Şehir Ekle"
                };
                                
                Ulkeler = context.Ulkeler.OrderBy(u=>u.UlkeAdi).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties         
        public Ulke Ulke { get; set; }
        public Sehir Sehir { get; set; }
        public Durum Durum { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

    public partial class SehirDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public SehirDuzenleViewModel()
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
                    Text2 = "Şehirler",
                    Link2 = "/sehir/listele",
                    Text3 = "Şehir Düzenle",
                    HeadText = "Şehir Düzenle"
                };           
                                
                Ulkeler = context.Ulkeler.OrderBy(u => u.UlkeAdi).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Ulke Ulke { get; set; }
        public Sehir Sehir { get; set; }
        public Durum Durum { get; set; }
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

}