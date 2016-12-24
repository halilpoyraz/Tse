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
        public virtual DbSet<Baslik> Basliklar { get; set; }
    }   
}