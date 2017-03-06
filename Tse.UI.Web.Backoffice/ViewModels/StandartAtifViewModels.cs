namespace Tse.UI.Web.Backoffice.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using Dal.Backoffice.Model;
    using Models;

    public partial class StandartAtifListeleViewModel : BaseViewModel
     {
        //Constructor
        public StandartAtifListeleViewModel(int? kategoriID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Kategori = context.Kategoriler.Find(kategoriID);
                                
                Meta = new Meta()
                {
                    Title = Kategori.Adi,
                    Description = $"Bu ekrandan {Kategori.Adi} ile ilgili listeleme, filtreleme, düzenleme ve yeni kayıt ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {                    
                    Text2 = Kategori.Adi,
                    Link2 = $"/kategori/listele?kategoriID={Kategori.KategoriID}",
                    Text3 = $"Tüm {Kategori.Adi}",
                    HeadText = $"Tüm {Kategori.Adi}"
                };

                Filter = new Filter().Create(Kategori.KategoriID);

                StandartAtiflar = context.StandartAtifTipiSablonlar.Where(d=>d.KategoriID==kategoriID).OrderBy(d=>d.Deger1).ToList();

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties                       
        public Kategori Kategori { get; set; }
        public Filter Filter { get; set; }
        public List<StandartAtifTipiSablon> StandartAtiflar { get; set; }        
        public List<Durum> Durumlar { get; set; }
    }
    /*
    public partial class KategoriEkleViewModel : BaseViewModel
    {
        //Constructor
        public KategoriEkleViewModel(int? kategoriID)
        {
            using (TseBackofficeContext context =  new TseBackofficeContext())
            {
                Kategori = context.Kategoriler.Find(kategoriID);

                Meta = new Meta()
                {
                    Title = Kategori.Adi,
                    Description = "Bu ekrandan yeni kayıt ekleme işlemleri yapılmaktadır."
                };

                BreadCrumb = new BreadCrumb()
                {
                    Text2 = Kategori.Adi,
                    Link2 = $"/kategori/listele?kategoriID={Kategori.KategoriID}",
                    Text3 = "Yeni Kayıt Ekle",
                    HeadText = "Yeni Kayıt Ekle"
                };

                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties         
        public Kategori Kategori{ get; set; }
        public Deger Deger { get; set; }
        public Durum Durum { get; set; }
        public List<Durum> Durumlar { get; set; }
    }

    
    public partial class KategoriDuzenleViewModel : BaseViewModel
    {
        //Constructor
        public KategoriDuzenleViewModel(int? kategoriID, int? degerID)
        {            
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                Kategori = context.Kategoriler.Find(kategoriID);

                Deger = context.Degerler.Find(degerID);
                                
                Meta = new Meta()
                {
                    Title = Kategori.Adi,
                    Description = "Bu ekrandan yeni kayıt ekleme işlemleri yapılmaktadır."
                };
                                
                BreadCrumb = new BreadCrumb()
                {                    
                    Text2 = Kategori.Adi,
                    Link2 = $"/kategori/listele?kategoriID={Kategori.KategoriID}",
                    Text3 = "Kayıt Düzenle",
                    HeadText = "Kayıt Düzenle"                  
                };

                Kategoriler = context.Kategoriler.ToList();          
                                      
                Durumlar = context.Durumlar.ToList();
            }
        }

        //Properties

        //Tarrak
        public Kategori Kategori { get; set; }
        public Deger Deger { get; set; }
        public Durum Durum { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Durum> Durumlar { get; set; }
    }
    */
}