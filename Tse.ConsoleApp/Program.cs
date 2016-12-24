namespace Tse.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using Tse.Dal.Model;   
    

    class Program
    {
        static void Main(string[] args)
        {
            //Tek bir  değişken tanımlama, tek bir kayıt ekledik

            //Baslik baslik = new Baslik()
            //{
            //    Id =1 ,
            //    BaslikNo = 140,
            //    BaslikAd ="Kamil"
            //};

            //Console.WriteLine($"Id: {baslik.Id} ");
            //Console.WriteLine($"BaslikNo: {baslik.BaslikNo} ");
            //Console.WriteLine($"BaslikAd: {baslik.BaslikAd} ");

            // Kayıt Listesi olarak yapmak isteseydik.




            TseContext context = new TseContext();
            Baslik yeniKayit = new Baslik() {Id=1, BaslikNo=1, BaslikAd="YeniBaslik"};

            context.Basliklar.Add(yeniKayit);
            context.SaveChanges();
           

            Console.ReadLine();
        }

        
    }
}
