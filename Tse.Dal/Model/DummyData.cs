using System.Data.Entity;

namespace Tse.Dal.Model
{
    public class DummyData : CreateDatabaseIfNotExists<TseContext>
    {
        protected override void Seed(TseContext context)
        {
            context.Basliklar.AddRange(
               new Baslik[] {
             new Baslik()
             {
                 Id = 2,
                 BaslikNo= 2,
                 BaslikAd= "halil"
             },
             new Baslik()
             {
                 Id = 3,
                 BaslikNo= 3,
                 BaslikAd= "Ali"
             },
             new Baslik()
             {
                 Id = 4,
                 BaslikNo= 4,
                 BaslikAd= "Osman"
             }
           });
            context.SaveChanges();
        }
    }
}