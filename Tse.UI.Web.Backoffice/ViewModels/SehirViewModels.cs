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
                //Meta
                Meta.Title = "Tüm Şehirler";
                Meta.Description = "Bu ekrandan şehir listeleme, filtreleme, düzenleme ve yeni şehir ekleme işlemleri yapılmaktadır.";                

                //BreadCrumb                
                BreadCrumb.Text1 = "Başlangıç";
                BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
                BreadCrumb.Text2 = "Şehirler";
                BreadCrumb.Link2 = "/sehir/listele";
                BreadCrumb.Text3 = "Tüm Şehirler";
                BreadCrumb.HeadText = "Tüm Şehirler";

                //Filter
                Filter = new Filter().Create("Sehirler");
                                
                //Context
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
                //Meta
                Meta.Title = "Yeni Şehir Ekle";
                Meta.Description = "Bu ekrandan yeni şehir ekleme işlemleri yapılmaktadır.";

                //BreadCrumb                
                BreadCrumb.Text1 = "Başlangıç";
                BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
                BreadCrumb.Text2 = "Ülkeler";
                BreadCrumb.Link2 = "/ulke/listele";
                BreadCrumb.Text3 = "Yeni Şehir Ekle";
                BreadCrumb.HeadText = "Yeni Şehir Ekle";

                //Context             
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
                //Meta
                Meta.Title = "Şehir Düzenle";
                Meta.Description = "Bu ekrandan şehir düzenleme işlemleri yapılmaktadır.";

                //BreadCrumb                
                BreadCrumb.Text1 = "Başlangıç";
                BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
                BreadCrumb.Text2 = "Ülkeler";
                BreadCrumb.Link2 = "/ulke/listele";
                BreadCrumb.Text3 = "Şehir Düzenle";
                BreadCrumb.HeadText = "Şehir Düzenle";

                //Context
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