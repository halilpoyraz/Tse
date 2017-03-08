namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class StandartListeleViewModel : BaseViewModel
     {
        //Constructor
        public StandartListeleViewModel()
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Tüm Standartlar",
                    Description = "Bu ekrandan standart listeleme, filtreleme, düzenleme ve yeni standart ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Standartlar",
                    Link2 = "/standart/listele",
                    Text3 = "Tüm Standartlar",
                    HeadText = "Tüm Standartlar"
                };

                Filter = new Filter().Create("Standartlar");

                Standartlar = context.Standartlar.OrderBy(s=>s.TsNo).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties                
        public List<Standart> Standartlar { get; set; }
        public List<Durum> Durumlar { get; set; }
        public Filter Filter { get; set; }
    }
    
    public partial class StandartEkleViewModel : BaseViewModel
    {
        //Constructor
        public StandartEkleViewModel()
        {
            using (TseBackofficeContext context =  new TseBackofficeContext())
            {
                Meta = new Meta()
                {
                    Title = "Yeni Standart Ekle",
                    Description = "Bu ekrandan yeni standart ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text1 = "Başlangıç",
                    Link1 = "/baslangic/gosterge-paneli",
                    Text2 = "Standartlar",
                    Link2 = "/standart/listele",
                    Text3 = "Yeni Standart Ekle",
                    HeadText = "Yeni Standart Ekle"
                };

                DokumanTipleri = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 1).OrderBy(m => m.DegerAdiTr).ToList();
                HazirlikGruplari = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 2).OrderBy(m => m.DegerAdiTr).ToList();
                YururlukDurumlari = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 3).OrderBy(m => m.DegerAdiTr).ToList();
                StandartTurler = context.Degerler.Where(m => m.DurumID == 1 && m.KategoriID == 4).OrderBy(m => m.DegerAdiTr).ToList();
                ParaBirimleri = context.ParaBirimleri.Where(m => m.DurumID == 1).OrderBy(m=>m.Kodu).ToList();
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties 
        public Standart Standart { get; set; }        
        public Durum Durum { get; set; }
        public List<Deger> DokumanTipleri { get; set; }
        public List<Deger> HazirlikGruplari { get; set; }
        public List<Deger> YururlukDurumlari{ get; set; }
        public List<Deger> StandartTurler { get; set; }
        public List<ParaBirimi> ParaBirimleri { get; set; }
        public List<Durum> Durumlar { get; set; }
    }
    
    public partial class StandartDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public StandartDuzenleViewModel(int? id)
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

                Standart = context.Standartlar.Find(id);
                                
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties
        public Standart Standart { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }    
}