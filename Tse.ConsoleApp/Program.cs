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
                //Firma Listele
                Console.WriteLine("Firma Listesi");
                Console.WriteLine("======================================================");
                List<Firma> firmalar = context.Firmalar.ToList();

                foreach (var firma in firmalar)
                {
                    Console.WriteLine($"{firma.FirmaId} | {firma.TicaretUnvani} | {firma.Durum.DurumAdi}");

                    foreach (var telefon in firma.FirmaTelefonlar)
                    {
                        Console.WriteLine($"{telefon.TelefonId} | {telefon.TelefonTipi.Adi} | {telefon.TelefonNo} | {telefon.DahiliNo}");
                    }

                }

                Console.ReadKey();
            }                                                      
        }
    }
}
