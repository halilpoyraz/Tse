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
                //Meta
                Meta.Title = "Tüm Ülkeler";
                Meta.Description = "Bu ekrandan ülke listeleme, filtreleme, düzenleme ve yeni ülke ekleme işlemleri yapılmaktadır.";                

                //BreadCrumb
                BreadCrumb.Title = "Ülkeler";
                BreadCrumb.Text1 = "Başlangıç";
                BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
                BreadCrumb.Text2 = "Ülkeler";
                BreadCrumb.Link2 = "/ulke/listele";
                BreadCrumb.Text3 = "Tüm Ülkeler";
                BreadCrumb.HeadText = "Tüm Ülkeler";

                //Filter
                new Filter().Create("Ulkeler");              

                //Context
                Ulkeler = context.Ulkeler.ToList();
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties                
        public List<Ulke> Ulkeler { get; set; }
        public List<Durum> Durumlar { get; set; }

        public int TumCount { get; set; }
        public int AktifCount { get; set; }
        public int PasifCount { get; set; }
        public int TaslakCount { get; set; }
        public int SilinmisCount { get; set; }
        
    }

    public partial class UlkeEkleViewModel : BaseViewModel
    {
        //Constructor
        public UlkeEkleViewModel()
        {
            using (TseBackofficeContext context =  new TseBackofficeContext())
            {
                //Meta
                Meta.Title = "Yeni Ülke Ekle";
                Meta.Description = "Bu ekrandan yeni ülke ekleme işlemleri yapılmaktadır.";

                //BreadCrumb
                BreadCrumb.Title = "Ülkeler";
                BreadCrumb.Text1 = "Başlangıç";
                BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
                BreadCrumb.Text2 = "Ülkeler";
                BreadCrumb.Link2 = "/ulke/listele";
                BreadCrumb.Text3 = "Yeni Ülke Ekle";
                BreadCrumb.HeadText = "Yeni Ülke Ekle";

                //Context             
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
                //Meta
                Meta.Title = "Ülke Düzenle";
                Meta.Description = "Bu ekrandan ülke düzenleme işlemleri yapılmaktadır.";

                //BreadCrumb
                BreadCrumb.Title = "Ülkeler";
                BreadCrumb.Text1 = "Başlangıç";
                BreadCrumb.Link1 = "/baslangic/gosterge-paneli";
                BreadCrumb.Text2 = "Ülkeler";
                BreadCrumb.Link2 = "/ulke/listele";
                BreadCrumb.Text3 = "Ülke Düzenle";
                BreadCrumb.HeadText = "Ülke Düzenle";

                //Context
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Ulke Ulke { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

}