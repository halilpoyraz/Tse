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
                List<Kisi> kisiler = context.Kisiler.ToList();

                Kisi yeniKisi = new Kisi
                {
                    Ad = "Yeni Bir",
                    Soyad = "Kişioğlu",
                    TcKimlikNo = 44400804181,
                    Unvan = "Yeni Çocuk",
                    DurumId = 1, 
                    Adresler = new List<Adres>
                    {
                        new Adres
                        {
                            AdresTipiId = 158,
                            AdresSatiri = "Hadi Be Caddesi. Kayıt ol Sokak No:125 Kat:5 D:10",
                            IlceId = 1,
                            SehirId=1,
                            UlkeId=1,
                            VarsayilanAdres=true,
                            DurumId = 1,                            
                        }
                    }
                };
                context.Kisiler.Add(yeniKisi);
                context.SaveChanges();

                kisiler = context.Kisiler.ToList();

                Console.WriteLine("Kişiler\n=============================================================================================================");

                foreach (var kisi in kisiler)
                {
                    Console.WriteLine($"{kisi.KisiId} | {kisi.Ad} {kisi.Soyad} |");
                }                

                Console.ReadKey();
            }                                                      
        }
    }
}
