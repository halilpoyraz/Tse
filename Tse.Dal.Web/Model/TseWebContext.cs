namespace Tse.Dal.Web.Model
{
    using App_Start;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class TseWebContext : DbContext
    {
        //Contructor
        public TseWebContext()
            : base("name=TseWebContext")
        {
            Database.SetInitializer(new DummyDataConfig());
        }


        //Properties        
        public virtual DbSet<Adres> Adresler { get; set; }
        public virtual DbSet<Deger> Degerler{ get; set; }
        public virtual DbSet<Durum> Durumlar { get; set; }        
        public virtual DbSet<Ilce> Ilceler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Kisi> Kisiler { get; set; }
        public virtual DbSet<Eposta> Epostalar { get; set; }
        public virtual DbSet<Firma> Firmalar { get; set; }
        public virtual DbSet<Telefon> Telefonlar { get; set; }
        public virtual DbSet<VergiBilgi> KisiVergiBilgileri { get; set; }
        public virtual DbSet<ParaBirimi> ParaBirimleri { get; set; }
        public virtual DbSet<Sehir> Sehirler { get; set; }
        public virtual DbSet<Standart> Standartlar { get; set; }        
        public virtual DbSet<StandartAciklama> StandartAciklamalar { get; set; }
        public virtual DbSet<StandartAtif> StandartAtiflar { get; set; }
        public virtual DbSet<StandartIcerik> StandartIcerikler { get; set; }
        public virtual DbSet<Ulke> Ulkeler { get; set; }



        //Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Singularize
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           
            //Table Names
            modelBuilder.Entity<Adres>().ToTable("Kisi.Adres");
            modelBuilder.Entity<Deger>().ToTable("Tanimlama.Deger");
            modelBuilder.Entity<Durum>().ToTable("Tanimlama.Durum");
            modelBuilder.Entity<Eposta>().ToTable("Kisi.Eposta");
            modelBuilder.Entity<Firma>().ToTable("Kisi.Firma");
            modelBuilder.Entity<Ilce>().ToTable("Tanimlama.Ilce");
            modelBuilder.Entity<Kategori>().ToTable("Tanimlama.Kategori");                       
            modelBuilder.Entity<Kisi>().ToTable("Kisi.Kisi");
            modelBuilder.Entity<ParaBirimi>().ToTable("Tanimlama.ParaBirimi");
            modelBuilder.Entity<Sehir>().ToTable("Tanimlama.Sehir");
            modelBuilder.Entity<Standart>().ToTable("Standart.Standart");
            modelBuilder.Entity<StandartAciklama>().ToTable("Standart.StandartAciklama");
            modelBuilder.Entity<StandartAtif>().ToTable("Standart.StandartAtif");
            modelBuilder.Entity<StandartIcerik>().ToTable("Standart.StandartIcerik");
            modelBuilder.Entity<Telefon>().ToTable("Kisi.Telefon");
            modelBuilder.Entity<Ulke>().ToTable("Tanimlama.Ulke");
            modelBuilder.Entity<VergiBilgi>().ToTable("Kisi.VergiBilgi");

            //Relationship Rules
            modelBuilder.Entity<Deger>().HasMany(e => e.AdresTipleri).WithRequired(e => e.AdresTipi).WillCascadeOnDelete(false);
            modelBuilder.Entity<Deger>().HasMany(e => e.DokumanTipleri).WithRequired(e => e.DokumanTipi).WillCascadeOnDelete(false);
            modelBuilder.Entity<Deger>().HasMany(e => e.HazirlikGruplari).WithRequired(e => e.HazirlikGrubu).WillCascadeOnDelete(false);
            modelBuilder.Entity<Deger>().HasMany(e => e.StandartTurleri).WithRequired(e => e.StandartTur).WillCascadeOnDelete(false);
            modelBuilder.Entity<Deger>().HasMany(e => e.Telefonlar).WithRequired(e => e.TelefonTipi).WillCascadeOnDelete(false);
            modelBuilder.Entity<Deger>().HasMany(e => e.YururlukDurumlari).WithRequired(e => e.YururlukDurumu).WillCascadeOnDelete(false);
            modelBuilder.Entity<Deger>().HasMany(e => e.StandartIcerikTipleri).WithRequired(e => e.StandartIcerikTipi).WillCascadeOnDelete(false);
            modelBuilder.Entity<Deger>().HasMany(e => e.StandartAtiflar).WithRequired(e => e.Deger).WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>().HasMany(e => e.Adresler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Degerler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Epostalar).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Firmalar).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Ilceler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Kategoriler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Kisiler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.ParaBirimleri).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Sehirler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Standartlar).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.StandartAciklamalar).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.StandartIcerikler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Telefonlar).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.Ulkeler).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.VergiBilgileri).WithRequired(e => e.Durum).WillCascadeOnDelete(false);
            modelBuilder.Entity<Durum>().HasMany(e => e.StandartAtiflar).WithRequired(e => e.Durum).WillCascadeOnDelete(false);

            modelBuilder.Entity<Firma>().HasMany(e => e.FirmaTelefonlar).WithOptional(e => e.Firma).WillCascadeOnDelete(false);
            modelBuilder.Entity<Firma>().HasMany(e => e.FirmaVergiBilgileri).WithOptional(e => e.Firma).WillCascadeOnDelete(false);
            modelBuilder.Entity<Firma>().HasMany(e => e.FirmaEpostalar).WithOptional(e => e.Firma).WillCascadeOnDelete(false);
            modelBuilder.Entity<Firma>().HasMany(e => e.FirmaAdresleri).WithOptional(e => e.Firma).WillCascadeOnDelete(false);

            modelBuilder.Entity<Ilce>().HasMany(e => e.Adresler).WithRequired(e => e.Ilce).WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>().HasMany(e => e.Degerler).WithRequired(e => e.Kategori).WillCascadeOnDelete(false);
            modelBuilder.Entity<Kategori>().HasMany(e => e.StandartAtiflar).WithRequired(e => e.Kategori).WillCascadeOnDelete(false);

            modelBuilder.Entity<Kisi>().HasMany(e => e.KisiAdresler).WithOptional(e => e.Kisi).WillCascadeOnDelete(false);
            modelBuilder.Entity<Kisi>().HasMany(e => e.Epostalar).WithOptional(e => e.Kisi).WillCascadeOnDelete(false);
            modelBuilder.Entity<Kisi>().HasMany(e => e.KisiTelefonlar).WithOptional(e => e.Kisi).WillCascadeOnDelete(false);
            modelBuilder.Entity<Kisi>().HasMany(e => e.KisiVergiBilgileri).WithOptional(e => e.Kisi).WillCascadeOnDelete(false);

            modelBuilder.Entity<ParaBirimi>().HasMany(e => e.Standartlar).WithRequired(e => e.ParaBirimi).WillCascadeOnDelete(false);

            modelBuilder.Entity<Sehir>().HasMany(e => e.Adresler).WithRequired(e => e.Sehir).WillCascadeOnDelete(false);
            modelBuilder.Entity<Sehir>().HasMany(e => e.Ilceler).WithRequired(e => e.Sehir).WillCascadeOnDelete(false);

            modelBuilder.Entity<Ulke>().HasMany(e => e.Adresler).WithRequired(e => e.Ulke).WillCascadeOnDelete(false);
            modelBuilder.Entity<Ulke>().HasMany(e => e.Sehirler).WithRequired(e => e.Ulke).WillCascadeOnDelete(false);

            modelBuilder.Entity<Standart>().HasMany(e => e.StandartIcerikler).WithRequired(e => e.Standart).WillCascadeOnDelete(false);
            modelBuilder.Entity<Standart>().HasMany(e => e.StandartAtiflar).WithRequired(e => e.Standart).WillCascadeOnDelete(false);

            modelBuilder.Entity<StandartIcerik>().HasMany(e => e.StandartAtiflar).WithRequired(e => e.StandartIcerik).WillCascadeOnDelete(false);
        }

    }   
}
