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
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 2,
                 DokumanTipiAdi = "Dc",
                 TseId = 3,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 3,
                 DokumanTipiAdi = "Kitap",
                 TseId = 14,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 4,
                 DokumanTipiAdi = "Konu Teklifi",
                 TseId = 8,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 5,
                 DokumanTipiAdi = "Kriter",
                 TseId = 9,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 6,
                 DokumanTipiAdi = "Kriter İş Programında",
                 TseId = 11,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 7,
                 DokumanTipiAdi = "Kriter Tasarısı",
                 TseId = 12,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 8,
                 DokumanTipiAdi = "Kriter Teklifi",
                 TseId = 10,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 9,
                 DokumanTipiAdi = "ST",
                 TseId = 1,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 10,
                 DokumanTipiAdi = "TD*GD",
                 TseId = 2,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 11,
                 DokumanTipiAdi = "TR*TS",
                 TseId = 6,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 12,
                 DokumanTipiAdi = "UTO Rehber Doküman",
                 TseId = 15,
                 Durum =1
             },
             new DokumanTipi()
             {
                 DokumanTipiId = 13,
                 DokumanTipiAdi = "WI (İş Programında)",
                 TseId = 5,
                 Durum = 1
             },

           });
            #endregion
            #region // YururlulukDurumu
            context.YururlulukDurumlari.AddRange(
                new List<YururlulukDurumu>{
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=1,
                        YururlulukDurumuAdi="-",
                        TseId=55,
                        Durum=1
                    },
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=2,
                        YururlulukDurumuAdi="A (Tadil Görmüş Standard/Amended standard)",
                        TseId=53,
                        Durum=1
                    },
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=3,
                        YururlulukDurumuAdi="H (İptal Edilmiş Standard/Withdrawn standard)",
                        TseId=51,
                        Durum=1
                    },
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=4,
                        YururlulukDurumuAdi="N (Yeni Standard/New standard)",
                        TseId=50,
                        Durum=1
                    },
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=5,
                        YururlulukDurumuAdi="U (Yürürlükteki Standard/Standard)",
                        TseId=52,
                        Durum=1
                    },
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=6,
                        YururlulukDurumuAdi="W (Yeni İptal Edilen Standard/Withdrawn standard)",
                        TseId=54,
                        Durum=1
                    },
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=7,
                        YururlulukDurumuAdi="A veya N veya U",
                        TseId=155,
                        Durum=1
                    },
                    new YururlulukDurumu()
                    {
                        YururlulukDurumuId=8,
                        YururlulukDurumuAdi="H veya W",
                        TseId=105,
                        Durum=1
                    }
                });
            #endregion
            #region // Durum
            context.Durumlari.AddRange(
                new List<Durumu>{
                    new Durumu()
                    {
                        DurumuId=0,
                        DurumAdi="Pasif"
                    },
                    new Durumu()
                    {
                        DurumuId=1,
                        DurumAdi="Aktif"
                    }
                });
            #endregion
            #region // HazirlikGrubu
            context.HazirlikGruplari.AddRange(
                new List<HazirlikGrubu>{
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=1,
                        HazirlikGrubuAdi="Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                        TseId=106,
                        Durum=1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=2,
                        HazirlikGrubuAdi="Alıcı Ortam Özel Daimi Komitesi",
                        TseId=135,
                        Durum=1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=3,
                        HazirlikGrubuAdi="Ambalaj Özel Daimi KomitesiÖDK",
                        TseId=136,
                        Durum=1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=4,
                        HazirlikGrubuAdi="Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                        TseId=107,
                        Durum=1
                    },
                    new HazirlikGrubu()
                    {
                        HazirlikGrubuId=5,
                        HazirlikGrubuAdi="Atıklar Özel Daimi Komitesi",
                        TseId=150,
                        Durum=1
                    }
                });
            #endregion
            context.SaveChanges();
        }

    }

}