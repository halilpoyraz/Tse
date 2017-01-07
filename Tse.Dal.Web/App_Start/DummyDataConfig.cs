namespace Tse.Dal.Web.App_Start
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public partial class DummyDataConfig : DropCreateDatabaseAlways<TseWebContext>
    {
        protected override void Seed(TseWebContext context)
        {
            #region // DokumanTipi
            context.DokumanTipleri.AddRange(new List<DokumanTipi> {
                new DokumanTipi
                 {
                     DokumanTipiId  = 1,
                     DokumanTipiAdi = "Adapte Teklifi",
                     TseId          = 13,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 2,
                     DokumanTipiAdi = "Dc",
                     TseId          = 3,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 3,
                     DokumanTipiAdi = "Kitap",
                     TseId          = 14,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 4,
                     DokumanTipiAdi = "Konu Teklifi",
                     TseId          = 8,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 5,
                     DokumanTipiAdi = "Kriter",
                     TseId          = 9,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 6,
                     DokumanTipiAdi = "Kriter İş Programında",
                     TseId          = 11,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 7,
                     DokumanTipiAdi = "Kriter Tasarısı",
                     TseId          = 12,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 8,
                     DokumanTipiAdi = "Kriter Teklifi",
                     TseId          = 10,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 9,
                     DokumanTipiAdi = "ST",
                     TseId          = 1,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 10,
                     DokumanTipiAdi = "TD*GD",
                     TseId          = 2,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 11,
                     DokumanTipiAdi = "TR*TS",
                     TseId          = 6,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 12,
                     DokumanTipiAdi = "UTO Rehber Doküman",
                     TseId          = 15,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiId  = 13,
                     DokumanTipiAdi = "WI (İş Programında)",
                     TseId          = 5,
                     DurumId        = 1
                 }
           });
            #endregion
           
            #region // Durum
            context.Durumlar.AddRange(new List<Durum> {
                new Durum
                {
                    DurumId     = 1,
                    DurumAdi    = "Aktif"
                },
                 new Durum
                 {
                    DurumId     = 2,
                    DurumAdi    = "Pasif"
                 },
                new Durum
                 {
                    DurumId     = 3,
                    DurumAdi    = "Taslak"
                 },
                new Durum
                 {
                    DurumId     = 4,
                    DurumAdi    = "Silinmiş"
                 }
            });
            #endregion

            #region // HazirlikGrubu
            context.HazirlikGruplari.AddRange(new List<HazirlikGrubu>{
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 1,
                HazirlikGrubuAdi    = "Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                TseId               = 106,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 2,
                HazirlikGrubuAdi    = "Alıcı Ortam Özel Daimi Komitesi",
                TseId               = 135,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 3,
                HazirlikGrubuAdi    = "Ambalaj Özel Daimi Komitesi ÖDK",
                TseId               = 136,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 4,
                HazirlikGrubuAdi    = "Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                TseId               = 107,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 5,
                HazirlikGrubuAdi    = "Atıklar Özel Daimi Komitesi",
                TseId               = 150,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 6,
                HazirlikGrubuAdi    = "Aydınlatma ve İç Tesisat Özel Daimi Komitesi",
                TseId               = 4,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 7,
                HazirlikGrubuAdi    = "Aydınlatma ve Kablo Özel Daimi Komitesi",
                TseId               = 1742,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 8,
                HazirlikGrubuAdi    = "Basınçlı Kaplar Özel Daimi Komitesi",
                TseId               = 152,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 9,
                HazirlikGrubuAdi    = "Bilgi Teknolojileri ve İletişim İhtisas Grubu",
                TseId               = 97,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 10,
                HazirlikGrubuAdi    = "Bilişim Teknolojileri Test Belgelendirme Sektörü",
                TseId               = 2752,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 11,
                HazirlikGrubuAdi    = "Cam Seramik ve Refrakter Malzeme Özel Daimi Komitesi",
                TseId               = 13,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 12,
                HazirlikGrubuAdi    = "Çevre İhtisas Grubu",
                TseId               = 28,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 13,
                HazirlikGrubuAdi    = "Çevre Sağlığı Özel Daimi Komitesi",
                TseId               = 151,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 14,
                HazirlikGrubuAdi    = "Çevre Sağlığı ve Atıklar Özel Daimi Komitesi",
                TseId               = 2,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 15,
                HazirlikGrubuAdi    = "Demiryolu Özel Daimi Komitesi",
                TseId               = 153,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 16,
                HazirlikGrubuAdi    = "Deprem Özel Daimi Komitesi",
                TseId               = 132,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 17,
                HazirlikGrubuAdi    = "Doğal Gaz Özel Daimi Komitesi",
                TseId               = 124,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 18,
                HazirlikGrubuAdi    = "Doküman Tercüme Komitesi",
                TseId               = 101,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 19,
                HazirlikGrubuAdi    = "Ekoloji Tarım Ürünleri Özel Daimi Komitesi",
                TseId               = 154,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 20,
                HazirlikGrubuAdi    = "Elektrik İhtisas Grubu",
                TseId               = 29,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 21,
                HazirlikGrubuAdi    = "Elektronik İhtisas Grubu",
                TseId               = 31,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 22,
                HazirlikGrubuAdi    = "Elektroteknik Güvenlik Özel Daimi Komitesi",
                TseId               = 1738,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 23,
                HazirlikGrubuAdi    = "Elektroteknik Güvenlik ve Aydınlatma  Özel Daimi Komitesi",
                TseId               = 2049,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 24,
                HazirlikGrubuAdi    = "Elektroteknik Sektörü Müdürlüğü",
                TseId               = 2734,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 25,
                HazirlikGrubuAdi    = "EMU ve Radyo-TV Özel Daimi Komitesi",
                TseId               = 7,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 26,
                HazirlikGrubuAdi    = "Endüstriyel Yağlar Özel Daimi Komitesi",
                TseId               = 155,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 27,
                HazirlikGrubuAdi    = "Gıda Sektörü Müdürlüğü",
                TseId               = 2722,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 28,
                HazirlikGrubuAdi    = "Helal Gıda Sektör Müdürlüğü",
                TseId               = 2724,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 29,
                HazirlikGrubuAdi    = "Hizmet Standardları İhtisas Grubu",
                TseId               = 32,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 30,
                HazirlikGrubuAdi    = "Hizmet Yeri Belgelendirme Sektör Müdürlüğü",
                TseId               = 2739,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 31,
                HazirlikGrubuAdi    = "Isı Özel Daimi Komitesi",
                TseId               = 156,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 32,
                HazirlikGrubuAdi    = "İnşaat İhtisas Grubu",
                TseId               = 33,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 33,
                HazirlikGrubuAdi    = "İnşaat Makinaları Özel Daimi Komitesi",
                TseId               = 157,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 34,
                HazirlikGrubuAdi    = "Kablo Özel Daimi Komitesi",
                TseId               = 5,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 35,
                HazirlikGrubuAdi    = "Kapatılan Hazırlık Grupları",
                TseId               = 166,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 36,
                HazirlikGrubuAdi    = "Kapatılan ve Birleştirilen Özel Daimi Komiteler",
                TseId               = 130,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 37,
                HazirlikGrubuAdi    = "Kırtasiye Malzemeleri ve Formlar Özel Daimi Komitesi",
                TseId               = 158,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 38,
                HazirlikGrubuAdi    = "Kimya İhtisas Grubu",
                TseId               = 34,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 39,
                HazirlikGrubuAdi    = "Kimya Sektör Müdürlüğü",
                TseId               = 2719,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 40,
                HazirlikGrubuAdi    = "Laboratuvarlar Hazırlık Grubu",
                TseId               = 143,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 41,
                HazirlikGrubuAdi    = "Maden İhtisas Grubu",
                TseId               = 35,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 42,
                HazirlikGrubuAdi    = "Makina İhtisas Grubu",
                TseId               = 36,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 43,
                HazirlikGrubuAdi    = "Makine Sektörü Müdürlüğü",
                TseId               = 2720,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 44,
                HazirlikGrubuAdi    = "Mamul Gıdalar İhtisas Grubu",
                TseId               = 37,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 45,
                HazirlikGrubuAdi    = "Meslek Standardları İhtisas Grubu",
                TseId               = 126,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 46,
                HazirlikGrubuAdi    = "Metalurji İhtisas Grubu",
                TseId               = 127,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 47,
                HazirlikGrubuAdi    = "Milletlerarası Standardlar Özel Daimi Komitesi",
                TseId               = 159,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 48,
                HazirlikGrubuAdi    = "Milli Savunma Sanayii İhtisas Grubu",
                TseId               = 104,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 49,
                HazirlikGrubuAdi    = "Mühendislik Hizmetleri İhtisas Grubu",
                TseId               = 105,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 50,
                HazirlikGrubuAdi    = "NBC ve KİS Özel Daimi Komitesi",
                TseId               = 217,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 51,
                HazirlikGrubuAdi    = "Nükleer Özel Daimi Komitesi",
                TseId               = 108,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 52,
                HazirlikGrubuAdi    = "Optik ve Optometri Özel Daimi Komitesi",
                TseId               = 160,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 53,
                HazirlikGrubuAdi    = "Orman ve Orman Ürünleri İhtisas Grubu",
                TseId               = 109,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 54,
                HazirlikGrubuAdi    = "Otomotiv Özel Daimi Komitesi",
                TseId               = 161,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 55,
                HazirlikGrubuAdi    = "Otomotiv Sektör Müdürlüğü",
                TseId               = 2783,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 56,
                HazirlikGrubuAdi    = "Otomotiv ve İnşaat Makinaları Özel Daimi Komitesi",
                TseId               = 123,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 57,
                HazirlikGrubuAdi    = "Özel Standardlar Hazırlık Grubu",
                TseId               = 146,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 58,
                HazirlikGrubuAdi    = "Petrokimya İhtisas Grubu",
                TseId               = 110,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 59,
                HazirlikGrubuAdi    = "Petrol İhtisas Grubu",
                TseId               = 112,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 60,
                HazirlikGrubuAdi    = "Plâstik Borular Özel Daimi Komitesi",
                TseId               = 111,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 61,
                HazirlikGrubuAdi    = "Radyo-TV Özel Daimi Komitesi",
                TseId               = 162,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 62,
                HazirlikGrubuAdi    = "Rezerv konular grubu",
                TseId               = 1779,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 63,
                HazirlikGrubuAdi    = "Sağlık İhtisas Grubu",
                TseId               = 114,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 64,
                HazirlikGrubuAdi    = "Standard Özel Daimi Komitesi",
                TseId               = 119,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 65,
                HazirlikGrubuAdi    = "Şehiriçi Yollar Özel Daimi Komitesi",
                TseId               = 163,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 66,
                HazirlikGrubuAdi    = "Tahribatsız Muayene Özel Daimi Komitesi",
                TseId               = 103,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 67,
                HazirlikGrubuAdi    = "Tarım Alet ve Makinaları Özel Daimi Komitesi",
                TseId               = 164,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 68,
                HazirlikGrubuAdi    = "Teknik Kurul",
                TseId               = 167,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 69,
                HazirlikGrubuAdi    = "Tekstil İhtisas Grubu",
                TseId               = 116,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 70,
                HazirlikGrubuAdi    = "Telekomünikasyon Özel Daimi Komitesi",
                TseId               = 102,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 71,
                HazirlikGrubuAdi    = "Tesisat ve Basınçlı Kaplar Özel Daimi Komitesi",
                TseId               = 122,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 72,
                HazirlikGrubuAdi    = "Tıbbi Cihazlar Özel Daimi Komitesi",
                TseId               = 115,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 73,
                HazirlikGrubuAdi    = "TK1: Bilişim Teknolojileri Teknik Komitesi",
                TseId               = 2532,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 74,
                HazirlikGrubuAdi    = "TK10: Yapı Malzemeleri Teknik Komitesi",
                TseId               = 2549,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 75,
                HazirlikGrubuAdi    = "TK11:İzolasyon, Kaplama ve Yardımcı Yapı Malzemeleri Teknik Komitesi",
                TseId               = 2551,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 76,
                HazirlikGrubuAdi    = "TK12: Yapı Güvenliği ve Akustik Teknik Komitesi",
                TseId               = 2553,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 77,
                HazirlikGrubuAdi    = "TK13: Yapı Güvenliği Teknik Komitesi",
                TseId               = 2555,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 78,
                HazirlikGrubuAdi    = "TK14: Kimya Teknik Komitesi",
                TseId               = 2557,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 79,
                HazirlikGrubuAdi    = "TK15: Petrokimya Teknik Komitesi",
                TseId               = 2559,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 80,
                HazirlikGrubuAdi    = "TK16: Petrol ve Petrol Ürünleri Teknik Komitesi",
                TseId               = 2560,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 81,
                HazirlikGrubuAdi    = "TK17: Maden Teknik Komitesi",
                TseId               = 2562,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 82,
                HazirlikGrubuAdi    = "TK18: İmalat Makineleri ve Takımları Teknik Komitesi",
                TseId               = 2564,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 83,
                HazirlikGrubuAdi    = "TK19: Otomotiv Teknik Komitesi",
                TseId               = 2566,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 84,
                HazirlikGrubuAdi    = "TK2: Çevre Teknik Komitesi",
                TseId               = 2533,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 85,
                HazirlikGrubuAdi    = "TK20: Makine Güvenliği Teknik Komitesi",
                TseId               = 2570,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 86,
                HazirlikGrubuAdi    = "TK21: Tesisat, Isıtma, Soğutma ve Havalandırma Teknik Komitesi",
                TseId               = 2568,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 87,
                HazirlikGrubuAdi    = "TK22: Tesisat ve Basınçlı Kaplar Teknik Komitesi",
                TseId               = 2572,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 88,
                HazirlikGrubuAdi    = "TK23: Metalürji Teknik Komitesi",
                TseId               = 2574,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 89,
                HazirlikGrubuAdi    = "TK24: Gıda Teknik Komitesi",
                TseId               = 2576,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 90,
                HazirlikGrubuAdi    = "TK25: Ziraat Teknik Komitesi",
                TseId               = 2578,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 91,
                HazirlikGrubuAdi    = "TK26: Kişisel Koruyucu ve Oyun Alanı Donanım Teknik Komitesi",
                TseId               = 2580,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 92,
                HazirlikGrubuAdi    = "TK27: Yangın Teknik Komitesi",
                TseId               = 2582,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 93,
                HazirlikGrubuAdi    = "TK28: Ambalaj Teknik Komitesi",
                TseId               = 2584,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 94,
                HazirlikGrubuAdi    = "TK29: Yönetim Sistemleri Teknik Komitesi",
                TseId               = 2586,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 95,
                HazirlikGrubuAdi    = "TK3: Elektrik Elektroteknik ve Güvenlik Teknik Komitesi",
                TseId               = 2535,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 96,
                HazirlikGrubuAdi    = "TK30: Enerji ve Enerji Sistemleri Teknik Komitesi",
                TseId               = 2588,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 97,
                HazirlikGrubuAdi    = "TK31: Orman ve Orman Ürünleri Teknik Komitesi",
                TseId               = 2590,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 98,
                HazirlikGrubuAdi    = "TK32: Sağlık Teknik Komitesi",
                TseId               = 2592,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 99,
                HazirlikGrubuAdi    = "TK33: Medikal Teknik Komitesi",
                TseId               = 2594,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 100,
                HazirlikGrubuAdi    = "TK34: Tekstil Teknik Komitesi",
                TseId               = 2596,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 101,
                HazirlikGrubuAdi    = "TK35: Elektrik ve Elektronik Yetkili Servisleri Teknik Komitesi",
                TseId               = 2598,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 102,
                HazirlikGrubuAdi    = "TK36: Milli Savunma Teknik Komitesi",
                TseId               = 2600,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 103,
                HazirlikGrubuAdi    = "TK37: Helal Teknik Komitesi",
                TseId               = 2602,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 104,
                HazirlikGrubuAdi    = "TK38: Sosyal Hizmetler Teknik Komitesi",
                TseId               = 2604,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 105,
                HazirlikGrubuAdi    = "TK39: Mekanik ve Elektromekanik Yetkili Servisleri Teknik Komitesi",
                TseId               = 2606,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 106,
                HazirlikGrubuAdi    = "TK4: Elektrik Üretim,İletim Ve Dağıtım Teknik Komitesi",
                TseId               = 2537,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 107,
                HazirlikGrubuAdi    = "TK40: Demiryolu Teknik Komitesi",
                TseId               = 2625,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 108,
                HazirlikGrubuAdi    = "TK41: Uzay ve Havacılık Teknik Komitesi",
                TseId               = 2671,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 109,
                HazirlikGrubuAdi    = "TK42: Nükleer Teknik Komitesi",
                TseId               = 2742,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 110,
                HazirlikGrubuAdi    = "TK43: Tercüme-1 Teknik Komitesi",
                TseId               = 2748,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 111,
                HazirlikGrubuAdi    = "TK44: Tercüme-2 Teknik Komitesi",
                TseId               = 2750,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 112,
                HazirlikGrubuAdi    = "TK45: İş Sağlığı ve Güvenliği Teknik Komitesi",
                TseId               = 2771,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 113,
                HazirlikGrubuAdi    = "TK46: Süs Bitkileri",
                TseId               = 2797,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 114,
                HazirlikGrubuAdi    = "TK5: Aydınlatma ve Bina İçi Tesisleri İle Yardımcı Donanımları Teknik Komitesi",
                TseId               = 2539,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 115,
                HazirlikGrubuAdi    = "TK6: İletkenler, Kablolar Ve Yalıtım Malzemeleri Teknik Komitesi",
                TseId               = 2541,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 116,
                HazirlikGrubuAdi    = "TK7: Yüksek Gerilim Teknikleri ve Yıldırımdan Korunma Sistemleri Teknik Komitesi",
                TseId               = 2543,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 117,
                HazirlikGrubuAdi    = "TK8: Elektronik Teknik Komitesi",
                TseId               = 2546,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 118,
                HazirlikGrubuAdi    = "TK9: Sanayi Hizmetleri Teknik Komitesi",
                TseId               = 2547,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 119,
                HazirlikGrubuAdi    = "TSEK Özel Daimi Komitesi",
                TseId               = 2507,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 120,
                HazirlikGrubuAdi    = "TSE-Yapılarda Tahribatsız Muayene Özel Daimi Komitesi",
                TseId               = 2508,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 121,
                HazirlikGrubuAdi    = "Ulusal Teknik Onay Esas Belirleme Komisyonu",
                TseId               = 2799,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 122,
                HazirlikGrubuAdi    = "Yangın Özel Daimi Komitesi",
                TseId               = 113,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 123,
                HazirlikGrubuAdi    = "Yapı Malzemeleri ÖDK",
                TseId               = 2503,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 124,
                HazirlikGrubuAdi    = "Yapı malzemeleri sektörü",
                TseId               = 2721,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 125,
                HazirlikGrubuAdi    = "Yetkili Servis Standardları İhtisas Grubu",
                TseId               = 1671,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 126,
                HazirlikGrubuAdi    = "Yönetim Sistemleri Geliştirme Sektörü",
                TseId               = 2803,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuId     = 127,
                HazirlikGrubuAdi    = "Ziraat İhtisas Grubu",
                TseId               = 117,
                DurumId             = 1
                }

                });
            #endregion

            #region // ParaBirimi
            context.ParaBirimleri.AddRange(new List<ParaBirimi>{
                new ParaBirimi
                {
                    ParaBirimiId    = 1,
                    Kodu            = "TL",
                    Cinsi           = "Türk Lirası",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 2,
                    Kodu            = "USD",
                    Cinsi           = "ABD Doları",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 3,
                    Kodu            = "AUD",
                    Cinsi           = "Avusturalya Doları",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 4,
                    Kodu            = "DKK",
                    Cinsi           = "Danimarka Kronu",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 5,
                    Kodu            = "EUR",
                    Cinsi           = "EURO",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 6,
                    Kodu            = "GBP",
                    Cinsi           = "İngiliz Sterlini",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 7,
                    Kodu            = "CHF",
                    Cinsi           = "İsviçre Frangı",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 8,
                    Kodu            = "SEK",
                    Cinsi           = "İsveç Kronu",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 9,
                    Kodu            = "CAD",
                    Cinsi           = "Kanada Doları",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 10,
                    Kodu            = "KWD",
                    Cinsi           = "Kuvet Dinarı",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 11,
                    Kodu            = "NOK",
                    Cinsi           = "Norveç Kronu",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 12,
                    Kodu            = "SAR",
                    Cinsi           = "Suudi Arabistan riyali",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 13,
                    Kodu            = "JPY",
                    Cinsi           = "Japon Yeni",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 14,
                    Kodu            = "BGN",
                    Cinsi           = "Bulgar Levası",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 15,
                    Kodu            = "RON",
                    Cinsi           = "Rumen Leyi",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 16,
                    Kodu            = "RUB",
                    Cinsi           = "Rus Rublesi",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 17,
                    Kodu            = "IRR",
                    Cinsi           = "İran Riyali",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 18,
                    Kodu            = "CYN",
                    Cinsi           = "Çin Yuanı",
                    DurumId         = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId    = 19,
                    Kodu            = "PKR",
                    Cinsi           = "Pakistan Rupisi",
                    DurumId         = 1
                }
            });
            #endregion

            #region // Standart
            context.Standartlar.AddRange(new List<Standart> {
                new Standart
                {
                    StandartId              = 1,
                    TsNo                    = "TS-13298",
                    KabulTarihi             = new DateTime(2015, 10, 23),
                    HazirlikGrubuId         = 6,
                    DokumanTipiId           = 9,
                    YururlukDurumuId        = 5,
                    Baslik                  = "Elektronik Belge ve Arşiv Yönetim Sistemi",
                    BaslikIng               = "Electronic Records and Archives Management System",
                    StandartTurId           = 3,
                    Kapsam                  = "Bu standard, kurumlarda üretilen ve/veya üretilmesi muhtemel elektronik dokümanların belge niteliğinin korunabilmesi için gerekli standardlar ile elektronik belgelerin arşivlenmesi ve yönetimine yönelik konuları kapsar.",
                    KapsamIng               = "This standard, produced in the institution and / or production of electronic documents, electronic documents possible with the necessary standards to preserve the quality archiving and document covers issues related to management.",
                    YeriniAldigi            = "TS 13298 :2009",
                    TadilEden               = "TS 13298/T1 :2016",
                    YararlanilanKaynak      = "-",
                    UluslararasiKarsiliklar = "13298-EQV",
                    TercumeEdildigiStd      = "13298",
                    IcsKodu                 = "01.140.20 Enformasyon Bilimleri; 35.240.20 Büro İşlemlerinde Enformasyon Teknolojisi Uygulamaları; 01.110 Teknik Ürün Dökümantasyonu",
                    AtifYapilanStd          = "TS ISO 15489-1 :2007;  TSE ISO/TR 15489-2 :2007;  TS ISO/IEC 27001 :2014;  TS ISO 8601 :2010;  TS ISO/IEC 15408-1 :2014;  TS ISO/IEC 15408-2 :2009;  TS ISO/IEC 15408-3 :2013;  TS ISO/IEC 25051 :2011;",
                    CenCenelec              = "-",
                    Dili                    = "tr",
                    RenkDurumu              = "Siyah-Beyaz",
                    UygulamaDurumu          = "Yürürlükte",
                    SayfaSayisi             = 81,
                    Fiyati                  = 71.00M,
                    ParaBirimiId            = 1,
                    DurumId                 = 1
                }
            });
            #endregion

            #region // StandartTur
            context.StandartTurler.AddRange(new List<StandartTur>{
                new StandartTur
                {
                    StandartTurId   = 1,
                    TurAdi          = "-",
                    DurumId         = 1
                },
                new StandartTur
                {
                    StandartTurId   = 2,
                    TurAdi          = "Kural",
                    DurumId         = 1
                },
                new StandartTur
                {
                    StandartTurId   = 3,
                    TurAdi          = "Metot",
                    DurumId         = 1
                }
            });
            #endregion

            #region // YururlukDurumu
            context.YururlukDurumlari.AddRange(new List<YururlukDurumu>{
                new YururlukDurumu
                {
                    YururlukDurumuId    = 1,
                    YururlukDurumuAdi   = "-",
                    TseId               = 55,
                    DurumId             = 1
                },
                new YururlukDurumu
                {
                    YururlukDurumuId    = 2,
                    YururlukDurumuAdi   = "A (Tadil Görmüş Standard/Amended standard)",
                    TseId               = 53,
                    DurumId             = 1
                },
                new YururlukDurumu
                {
                    YururlukDurumuId    = 3,
                    YururlukDurumuAdi   = "H (İptal Edilmiş Standard/Withdrawn standard)",
                    TseId               = 51,
                    DurumId             = 1
                },
                new YururlukDurumu
                {
                    YururlukDurumuId    = 4,
                    YururlukDurumuAdi   = "N (Yeni Standard/New standard)",
                    TseId               = 50,
                    DurumId             = 1
                },
                new YururlukDurumu
                {
                    YururlukDurumuId    = 5,
                    YururlukDurumuAdi   = "U (Yürürlükteki Standard/Standard)",
                    TseId               = 52,
                    DurumId             = 1
                },
                new YururlukDurumu
                {
                    YururlukDurumuId    = 6,
                    YururlukDurumuAdi   = "W (Yeni İptal Edilen Standard/Withdrawn standard)",
                    TseId               = 54,
                    DurumId             = 1
                },
                new YururlukDurumu
                {
                    YururlukDurumuId    = 7,
                    YururlukDurumuAdi   = "A veya N veya U",
                    TseId               = 155,
                    DurumId             = 1
                },
                new YururlukDurumu
                {
                    YururlukDurumuId    = 8,
                    YururlukDurumuAdi   = "H veya W",
                    TseId               = 105,
                    DurumId             = 1
                }
            });
            #endregion

            context.SaveChanges();
        }

    }

}