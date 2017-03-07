namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class UlkeListeleViewModel : BaseViewModel
     {
        //Constructor
        public UlkeListeleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Tüm Ülkeler",
                    Description = "Bu ekrandan ülke listeleme, filtreleme, düzenleme ve yeni ülke ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Ülkeler",
                    Link2 = "/ulke/listele",
                    Text3 = "Tüm Ülkeler",
                    HeadText = "Tüm Ülkeler"
                };

                Filter = new Filter().Create("Ulkeler");
                
                Ulkeler = context.Ulkeler.OrderBy(u=>u.UlkeAdi).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties                
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }
        public Filter Filter { get; set; }
    }

    public partial class UlkeEkleViewModel : BaseViewModel
    {
        //Constructor
        public UlkeEkleViewModel()
        {
            using (TseBackofficeContext context =  new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Yeni Ülke Ekle",
                    Description = "Bu ekrandan yeni ülke ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Ülkeler",
                    Link2 = "/ulke/listele",
                    Text3 = "Yeni Ülke Ekle",
                    HeadText = "Yeni Ülke Ekle"
                };
                                           
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties 
        public Ulke Ulke { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

    public partial class UlkeDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public UlkeDuzenleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {                
                Meta = new Meta()
                {
                    Title = "Ülke Düzenle",
                    Description = "Bu ekrandan ülke düzenleme işlemleri yapılmaktadır."
                };
                                
                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Ülkeler",
                    Link2 = "/ulke/listele",
                    Text3 = "Ülke Düzenle",
                    HeadText = "Ülke Düzenle"
                };
                                
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Ulke Ulke { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }
}