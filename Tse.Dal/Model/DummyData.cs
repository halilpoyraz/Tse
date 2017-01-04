namespace Tse.Dal.Model
{
    using System.Collections.Generic;
    using System.Data.Entity;

    public class DummyData : DropCreateDatabaseAlways<TseContext>
    {
        protected override void Seed(TseContext context)
        {
            #region // Durum
            context.Durumlar.AddRange(
             new List<Durum> {
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
                DurumAdi    = "Taslak"
             },
            new Durum()
             {
                DurumId     = 4,
                DurumAdi    = "Silinmiş"
             }
           });
            #endregion

            #region // DokumanTipi
            context.DokumanTipleri.AddRange(
             new List<DokumanTipi> {
             new DokumanTipi()
             {
                 DokumanTipiId  = 1,
                 DokumanTipiAdi = "Adapte Teklifi",
                 TseId          = 13,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 2,
                 DokumanTipiAdi = "Dc",
                 TseId          = 3,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 3,
                 DokumanTipiAdi = "Kitap",
                 TseId          = 14,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 4,
                 DokumanTipiAdi = "Konu Teklifi",
                 TseId          = 8,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 5,
                 DokumanTipiAdi = "Kriter",
                 TseId          = 9,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 6,
                 DokumanTipiAdi = "Kriter İş Programında",
                 TseId          = 11,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 7,
                 DokumanTipiAdi = "Kriter Tasarısı",
                 TseId          = 12,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 8,
                 DokumanTipiAdi = "Kriter Teklifi",
                 TseId          = 10,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 9,
                 DokumanTipiAdi = "ST",
                 TseId          = 1,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 10,
                 DokumanTipiAdi = "TD*GD",
                 TseId          = 2,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 11,
                 DokumanTipiAdi = "TR*TS",
                 TseId          = 6,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 12,
                 DokumanTipiAdi = "UTO Rehber Doküman",
                 TseId          = 15,
                 DurumId        = 1
             },
             new DokumanTipi()
             {
                 DokumanTipiId  = 13,
                 DokumanTipiAdi = "WI (İş Programında)",
                 TseId          = 5,
                 DurumId        = 1
             }            
           });
            #endregion
            
            #region // YururlukDurumu
            context.YururlukDurumlari.AddRange(
                new List<YururlukDurumu>{
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 1,
                        YururlukDurumuAdi   = "-",
                        TseId               = 55,
                        DurumId             = 1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 2,
                        YururlukDurumuAdi   = "A (Tadil Görmüş Standard/Amended standard)",
                        TseId               = 53,
                        DurumId             = 1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 3,
                        YururlukDurumuAdi   = "H (İptal Edilmiş Standard/Withdrawn standard)",
                        TseId               = 51,
                        DurumId             = 1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 4,
                        YururlukDurumuAdi   = "N (Yeni Standard/New standard)",
                        TseId               = 50,
                        DurumId             = 1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 5,
                        YururlukDurumuAdi   = "U (Yürürlükteki Standard/Standard)",
                        TseId               = 52,
                        DurumId             = 1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 6,
                        YururlukDurumuAdi   = "W (Yeni İptal Edilen Standard/Withdrawn standard)",
                        TseId               = 54,
                        DurumId             = 1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 7,
                        YururlukDurumuAdi   = "A veya N veya U",
                        TseId               = 155,
                        DurumId             = 1
                    },
                    new YururlukDurumu()
                    {
                        YururlukDurumuId    = 8,
                        YururlukDurumuAdi   = "H veya W",
                        TseId               = 105,
                        DurumId             = 1
                    }
                });
            #endregion            
            
            #region // HazirlikGrubu
            context.HazirlikGruplari.AddRange(
                new List<HazirlikGrubu>{
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId     = 1,
                        HazirlikGrubuAdi    = "Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                        TseId               = 106,
                        DurumId             = 1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId     = 2,
                        HazirlikGrubuAdi    = "Alıcı Ortam Özel Daimi Komitesi",
                        TseId               = 135,
                        DurumId             = 1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId     = 3,
                        HazirlikGrubuAdi    = "Ambalaj Özel Daimi KomitesiÖDK",
                        TseId               = 136,
                        DurumId             = 1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId     = 4,
                        HazirlikGrubuAdi    = "Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                        TseId               = 107,
                        DurumId             = 1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId     = 5,
                        HazirlikGrubuAdi    = "Atıklar Özel Daimi Komitesi",
                        TseId               = 150,
                        DurumId             = 1
                    }
                });
            #endregion
            
            #region // StandartTur
            context.StandartTurler.AddRange(
            new List<StandartTur>
            {
                new StandartTur()
                {
                    StandartTurId   = 1,
                    TurAdi          = "-",
                    DurumId         = 1
                },
                new StandartTur()
                {
                    StandartTurId   = 2,
                    TurAdi          = "Kural",
                    DurumId         = 1
                },
                new StandartTur()
                {
                    StandartTurId   = 3,
                    TurAdi          = "Metot",
                    DurumId         = 1
                }
            });
            #endregion
            
            #region // ParaBirimi
            context.ParaBirimleri.AddRange(
            new List<ParaBirimi>
            {
                new ParaBirimi()
                {
                    ParaBirimiId    = 1,
                    Kodu            = "TL",
                    Cinsi           = "Türk Lirası",
                    DurumId         = 1  
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 2,
                    Kodu            = "USD",
                    Cinsi           = "ABD Doları",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 3,
                    Kodu            = "AUD",
                    Cinsi           = "Avusturalya Doları",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 4,
                    Kodu            = "DKK",
                    Cinsi           = "Danimarka Kronu",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 5,
                    Kodu            = "EUR",
                    Cinsi           = "EURO",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 6,
                    Kodu            = "GBP",
                    Cinsi           = "İngiliz Sterlini",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 7,
                    Kodu            = "CHF",
                    Cinsi           = "İsviçre Frangı",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 8,
                    Kodu            = "SEK",
                    Cinsi           = "İsveç Kronu",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 9,
                    Kodu            = "CAD",
                    Cinsi           = "Kanada Doları",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 10,
                    Kodu            = "KWD",
                    Cinsi           = "Kuvet Dinarı",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 11,
                    Kodu            = "NOK",
                    Cinsi           = "Norveç Kronu",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 12,
                    Kodu            = "SAR",
                    Cinsi           = "Suudi Arabistan riyali",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 13,
                    Kodu            = "JPY",
                    Cinsi           = "Japon Yeni",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 14,
                    Kodu            = "BGN",
                    Cinsi           = "Bulgar Levası",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 15,
                    Kodu            = "RON",
                    Cinsi           = "Rumen Leyi",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 16,
                    Kodu            = "RUB",
                    Cinsi           = "Rus Rublesi",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 17,
                    Kodu            = "IRR",
                    Cinsi           = "İran Riyali",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 18,
                    Kodu            = "CYN",
                    Cinsi           = "Çin Yuanı",
                    DurumId         = 1
                },
                new ParaBirimi()
                {
                    ParaBirimiId    = 19,
                    Kodu            = "PKR",
                    Cinsi           = "Pakistan Rupisi",
                    DurumId         = 1
                }
            });
            #endregion

            context.SaveChanges();
        }

    }

}