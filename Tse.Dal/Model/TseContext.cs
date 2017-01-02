namespace Tse.Dal.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TseContext : DbContext
    {
        public TseContext()
            : base("name=TseContext")
        {
            Database.SetInitializer(new DummyData());
        }
        
        // Properties
        public virtual DbSet<DokumanTipi> DokumanTipleri { get; set; }
        public virtual DbSet<Durum> Durumlar { get;set;}
        public virtual DbSet<HazirlikGrubu> HazirlikGruplari { get; set; }
        public virtual DbSet<Standart> Standartlar { get; set; }
        public virtual DbSet<YururlukDurumu> YururlukDurumlari { get; set; }
        public virtual DbSet<StandartTur> StandartTurler { get; set; }


        // Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DokumanTipi>()
                .HasMany(e => e.Standartlar)
                .WithRequired(e => e.DokumanTipi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HazirlikGrubu>()
               .HasMany(e => e.Standartlar)
               .WithRequired(e => e.HazirlikGrubu)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<YururlukDurumu>()
              .HasMany(e => e.Standartlar)
              .WithRequired(e => e.YururlukDurumu)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<StandartTur>()
              .HasMany(e => e.Standartlar)
              .WithRequired(e => e.StandartTur)
              .WillCascadeOnDelete(false);                           
        }
    }   
}