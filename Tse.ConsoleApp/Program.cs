namespace Tse.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using Tse.Dal.Model;    
    using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            using (TseContext context = new TseContext())
            {
                List<ParaBirimi> paraBirimleri = context.ParaBirimleri.ToList();

                foreach (var i in paraBirimleri)
                {
                    Console.WriteLine($"{i.ParaBirimiId} | {i.Kodu} | {i.Cinsi}");
                    Console.WriteLine("===========================================================");                    
                }

                Console.ReadKey();
            }                                                      
        }
    }
}
