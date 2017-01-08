namespace Tse.Dal.Web.Model
{
    using App_Start;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class TseWebContext : DbContext
    {
        // Contructor
        public TseWebContext()
            : base("name=TseWebContext")
        {
            Database.SetInitializer(new DummyDataConfig());
        }


        // Properties
        public virtual DbSet<DokumanTipi> DokumanTipleri { get; set; }        
        public virtual DbSet<Durum> Durumlar { get; set; }
        public virtual DbSet<HazirlikGrubu> HazirlikGruplari { get; set; }
        public virtual DbSet<ParaBirimi> ParaBirimleri { get; set; }
        public virtual DbSet<StandartTur> StandartTurler { get; set; }
        public virtual DbSet<YururlukDurumu> YururlukDurumlari { get; set; }
        public virtual DbSet<Standart> Standartlar { get; set; }
        public virtual DbSet<Ulke> Ulkeler { get; set; }
        public virtual DbSet<Sehir> Sehirler { get; set; }
        public virtual DbSet<Ilce> Ilceler { get; set; }


        // Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.DokumanTipleri)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.HazirlikGruplari)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.ParaBirimleri)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.Sehirler)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.Standartlar)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.StandartTurleri)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.Ulkeler)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.YururlukDurumlari)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParaBirimi>()
                .HasMany(e => e.Standartlar)
                .WithRequired(e => e.ParaBirimi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StandartTur>()
                .HasMany(e => e.Standartlar)
                .WithRequired(e => e.StandartTur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YururlukDurumu>()
                .HasMany(e => e.Standartlar)
                .WithRequired(e => e.YururlukDurumu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DokumanTipi>()
                .HasMany(e => e.Standartlar)
                .WithRequired(e => e.DokumanTipi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HazirlikGrubu>()
                .HasMany(e => e.Standartlar)
                .WithRequired(e => e.HazirlikGrubu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ulke>()
                .HasMany(e => e.Sehirler)
                .WithRequired(e => e.Ulke)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ulke>()
                .HasMany(e => e.Kisiler)
                .WithRequired(e => e.Ulke)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sehir>()
                .HasMany(e => e.Kisiler)
                .WithRequired(e => e.Sehir)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sehir>()
                .HasMany(e => e.Ilceler)
                .WithRequired(e => e.Sehir)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Durum>()
                .HasMany(e => e.Ilceler)
                .WithRequired(e => e.Durum)
                .WillCascadeOnDelete(false);
        }

    }   
}
