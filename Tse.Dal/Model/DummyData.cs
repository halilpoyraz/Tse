namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.Data.Entity;

    public class DummyData : DropCreateDatabaseAlways<TseContext>
    {
        protected override void Seed(TseContext context)
        {
            #region // DokumanTipleri
            context.DokumanTipleri.AddRange(
             new List<DokumanTipi> {
             new DokumanTipi()
             {
                 DokumanTipiId = 1,
                 DokumanTipiAdi = "Adapte Teklifi",
                 TseId = 13,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 2,
                 DokumanTipiAdi = "Dc",
                 TseId = 3,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 3,
                 DokumanTipiAdi = "Kitap",
                 TseId = 14,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 4,
                 DokumanTipiAdi = "Konu Teklifi",
                 TseId = 8,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 5,
                 DokumanTipiAdi = "Kriter",
                 TseId = 9,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 6,
                 DokumanTipiAdi = "Kriter İş Programında",
                 TseId = 11,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 7,
                 DokumanTipiAdi = "Kriter Tasarısı",
                 TseId = 12,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 8,
                 DokumanTipiAdi = "Kriter Teklifi",
                 TseId = 10,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 9,
                 DokumanTipiAdi = "ST",
                 TseId = 1,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 10,
                 DokumanTipiAdi = "TD*GD",
                 TseId = 2,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 11,
                 DokumanTipiAdi = "TR*TS",
                 TseId = 6,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 12,
                 DokumanTipiAdi = "UTO Rehber Doküman",
                 TseId = 15,
                 DurumId = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 13,
                 DokumanTipiAdi = "WI (İş Programında)",
                 TseId = 5,
                 DurumId = 1
             }            
           });
            #endregion
            #region // YururlukDurumlari
            context.YururlukDurumlari.AddRange(
                new List<YururlukDurumu>{
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=1,
                        YururlukDurumuAdi="-",
                        TseId=55,
                        DurumId=1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=2,
                        YururlukDurumuAdi="A (Tadil Görmüş Standard/Amended standard)",
                        TseId=53,
                        DurumId =1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=3,
                        YururlukDurumuAdi="H (İptal Edilmiş Standard/Withdrawn standard)",
                        TseId=51,
                        DurumId =1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=4,
                        YururlukDurumuAdi="N (Yeni Standard/New standard)",
                        TseId=50,
                        DurumId =1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=5,
                        YururlukDurumuAdi="U (Yürürlükteki Standard/Standard)",
                        TseId=52,
                        DurumId =1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=6,
                        YururlukDurumuAdi="W (Yeni İptal Edilen Standard/Withdrawn standard)",
                        TseId=54,
                        DurumId =1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=7,
                        YururlukDurumuAdi="A veya N veya U",
                        TseId=155,
                        DurumId =1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId=8,
                        YururlukDurumuAdi="H veya W",
                        TseId=105,
                        DurumId =1
                    }
                });
            #endregion
            #region // Durumlar
            context.Durumlar.AddRange(
                new List<Durum>{
                    new Durum()
                    {
                        DurumId     = 1,
                        DurumAdi    = "Aktif"
                    },
                    new Durum()
                    {
                        DurumId     = 2,
                        DurumAdi    = "Pasif"
                    },
                    new Durum()
                    {
                        DurumId     = 3,
                        DurumAdi    = "Silinmiş"
                    }
                });
            #endregion
            #region // HazirlikGruplari
            context.HazirlikGruplari.AddRange(
                new List<HazirlikGrubu>{
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId =1,
                        HazirlikGrubuAdi="Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                        TseId=106,
                        DurumId =1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=2,
                        HazirlikGrubuAdi="Alıcı Ortam Özel Daimi Komitesi",
                        TseId=135,
                        DurumId =1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=3,
                        HazirlikGrubuAdi="Ambalaj Özel Daimi KomitesiÖDK",
                        TseId=136,
                        DurumId =1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=4,
                        HazirlikGrubuAdi="Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                        TseId=107,
                        DurumId =1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=5,
                        HazirlikGrubuAdi="Atıklar Özel Daimi Komitesi",
                        TseId=150,
                        DurumId =1
                    }
                });
            #endregion
            #region // StandartTurler
            context.StandartTurler.AddRange(
            new List<StandartTur>
            {
                new StandartTur()
                {
                    StandartTurId = 1,
                    TurAdi = "-",
                    DurumId= 1
                },
                new StandartTur()
                {
                    StandartTurId = 2,
                    TurAdi = "Kural",
                    DurumId = 1
                },
                new StandartTur()
                {
                    StandartTurId = 3,
                    TurAdi = "Metot",
                    DurumId= 1
                }
            });
            #endregion
            context.SaveChanges();
        }

    }

}