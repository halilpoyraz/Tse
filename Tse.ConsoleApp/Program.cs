namespace Tse.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using Tse.Dal.Model;


    class Program
    {
        static void Main(string[] args)
        {
            using (TseContext context = new TseContext())
            {
                DokumanTipi dokumanTipi = new DokumanTipi() {DokumanTipiId=14, DokumanTipiAdi= "Test", DurumId=1, TseId=151};
                context.DokumanTipleri.Add(dokumanTipi);
                context.SaveChanges();
            }                               
            Console.WriteLine("İşlem Tamam");
        }
    }
}
