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
                    Description = "Bu ekrandan kişi listeleme, filtreleme, düzenleme ve yeni standart ekleme işlemleri yapılmaktadır."
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

                Kisiler = context.Kisiler.OrderBy(s=>s.KisiID).ToList();

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
            }
        }

        //Properties 
        public Kisi Kisi { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

    public partial class KisiDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public KisiDuzenleViewModel()
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
                    Text2 = "Kişiler",
                    Link2 = "/kisi/listele",
                    Text3 = "Kişi Düzenle",
                    HeadText = "Kişi Düzenle"
                };

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties 
        public Kisi Kisi { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }
}