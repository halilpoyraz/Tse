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
                int ulkeCount = context.Ulkeler.Count();
                int sehirCount = context.Sehirler.Count();
                int ilceCount = context.Ilceler.Count();
                int kisiCount = context.Kisiler.Count();
                int epostaCount = context.Epostalar.Count();
                int telefonCount = context.KisiTelefonlar.Count();
                int vergiBilgileriCount = context.KisiVergiBilgileri.Count();

                Console.WriteLine($"DokumanTipi: {dokumanTipiCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Durum: {durumCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"HazirlikGrubu: {hazirlikGrubuCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Ilce: {ilceCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"ParaBirimi: {paraBirimiCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Sehir: {sehirCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Standart: {standartCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"StandartTurler: {standartTurlerCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Ulkeler: {ulkeCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"YururlukDurumu: {yururlukDurumuCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Kisi: {kisiCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Eposta: {epostaCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"Telefon: {telefonCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine($"VergiBilgisi: {vergiBilgileriCount}");
                Console.WriteLine("=================================================");
                Console.WriteLine("Toplam Kayıt Sayısı = "+ (dokumanTipiCount + durumCount + hazirlikGrubuCount + paraBirimiCount + standartCount + standartTurlerCount + yururlukDurumuCount + ulkeCount + sehirCount + ilceCount + kisiCount + epostaCount + telefonCount + vergiBilgileriCount));
                Console.ReadKey();
            }                                                      
        }
    }
}
