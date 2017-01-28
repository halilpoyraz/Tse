namespace Tse.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using Dal.Backoffice.Model;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                DateTime startTime = DateTime.Now;
                Console.WriteLine($"Start Time : {startTime}");
                Console.WriteLine($"=======================================================================================================================");
                Console.WriteLine($"Ulke ({context.Ulkeler.Count()})");
                Console.WriteLine($"Adres ({context.Adresler.Count()})");
                Console.WriteLine($"Deger ({context.Degerler.Count()})");
                Console.WriteLine($"Durum ({context.Durumlar.Count()})");
                Console.WriteLine($"Eposta ({context.Epostalar.Count()})");
                Console.WriteLine($"FaturaBilgi ({context.FaturaBilgileri.Count()})");
                Console.WriteLine($"Firma ({context.Firmalar.Count()})");
                Console.WriteLine($"Ilce ({context.Ilceler.Count()})");
                Console.WriteLine($"Kategori ({context.Kategoriler.Count()})");
                Console.WriteLine($"Kisi ({context.Kisiler.Count()})");
                Console.WriteLine($"ParaBirimi ({context.ParaBirimleri.Count()})");
                Console.WriteLine($"Sehir ({context.Sehirler.Count()})");
                Console.WriteLine($"Standart ({context.Standartlar.Count()})");
                Console.WriteLine($"StandartAtif ({context.StandartAtiflar.Count()})");
                Console.WriteLine($"StandartIcerik ({context.StandartIcerikler.Count()})");
                Console.WriteLine($"StandartIcerikDenetim ({context.StandartIcerikDenetimler.Count()})");
                Console.WriteLine($"StandartIcerikTipiSablon ({context.StandartIcerikTipiSablonlar.Count()})");
                Console.WriteLine($"Telefon ({context.Telefonlar.Count()})");
                Console.WriteLine($"StandartAtifTipiSablon ({context.StandartAtifTipiSablonlar.Count()})");

                Console.WriteLine($"=======================================================================================================================");
                DateTime finishTime = DateTime.Now;
                Console.WriteLine($"Finish Time: {finishTime} And Load Completion Time  : {finishTime - startTime} second");

                Console.ReadKey();
            }
        }
    }
}