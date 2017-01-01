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
    }   
}