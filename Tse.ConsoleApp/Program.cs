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
                //Standart.pdf                
                List<StandartIcerik> icerikler = context.StandartIcerikler.ToList();

                foreach (var icerik in icerikler)
                {
                    Console.WriteLine($"{icerik.BaslikNo} {icerik.Baslik}");
                    Console.WriteLine($"{icerik.Detay}");
                    Console.WriteLine($"");

                    //AtifYapilanStandartTipi - AtifYapilanDokumanTipi
                    if (icerik.StandartIcerikTipiId== 160)
                    {
                        int atifYapilanStandartSayisi = icerik.StandartAtiflar.Where(x => x.KategoriId==8).Count();
                        if (atifYapilanStandartSayisi > 0)
                        {
                            Console.WriteLine($" EN, ISO, IEC | Adı (EN) | TS No | Adı (TR)");
                            foreach (var standart in icerik.StandartAtiflar.Where(x => x.KategoriId == 8).ToList())
                            {
                                Console.WriteLine($"{standart.Deger.Deger1} | {standart.Deger.Deger2} | {standart.Deger.Deger3} | {standart.Deger.Deger4}");
                            }
                        }

                        int atifYapilanDokumanSayisi = icerik.StandartAtiflar.Where(x => x.KategoriId == 9).Count();
                        if (atifYapilanDokumanSayisi > 0)
                        {
                            Console.WriteLine($" Doküman Adı | Yayımlayan Kurum | Hukuki Dayanak ");
                            foreach (var dokuman in icerik.StandartAtiflar.Where(x => x.KategoriId == 9).ToList())
                            {
                                Console.WriteLine($"{dokuman.Deger.Deger1} | {dokuman.Deger.Deger2} | {dokuman.Deger.Deger3}");
                            }
                        }
                    }
                }

                Console.ReadKey();
            }                                                      
        }
    }
}
