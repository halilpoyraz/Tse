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

                Console.WriteLine("Kişiler\n=============================================================================================================");

                foreach (var kisi in kisiler)
                {
                    Console.WriteLine($"{kisi.KisiId} | {kisi.Adi} {kisi.Soyadi} |");
                }                

                Console.ReadKey();
            }                                                      
        }
    }
}
