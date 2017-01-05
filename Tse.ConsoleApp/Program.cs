namespace Tse.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using Dal.Web.Model;    
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            using (TseWebContext context = new TseWebContext())
            {
                int dokumanTipiCount = context.DokumanTipleri.Count();
                int durumCount = context.Durumlar.Count();
                int hazirlikGrubuCount = context.HazirlikGruplari.Count();
                int paraBirimiCount = context.ParaBirimleri.Count();
                int standartCount = context.Standartlar.Count();
                int standartTurlerCount = context.StandartTurler.Count();
                int yururlukDurumuCount = context.YururlukDurumlari.Count();

                Console.WriteLine($"DokumanTipi: {dokumanTipiCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Durum: {durumCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"HazirlikGrubu: {hazirlikGrubuCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"ParaBirimi: {paraBirimiCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Standart: {standartCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"StandartTurler: {standartTurlerCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"YururlukDurumu: {yururlukDurumuCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine("Toplam Kayıt Sayısı = "+ (dokumanTipiCount + durumCount + hazirlikGrubuCount + paraBirimiCount + standartCount + standartTurlerCount + yururlukDurumuCount));
                Console.ReadKey();
            }                                                      
        }
    }
}
