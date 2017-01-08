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
                     DokumanTipiAdi = "Adapte Teklifi",
                     TseId          = 13,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {                     
                     DokumanTipiAdi = "Dc",
                     TseId          = 3,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {                     
                     DokumanTipiAdi = "Kitap",
                     TseId          = 14,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "Konu Teklifi",
                     TseId          = 8,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "Kriter",
                     TseId          = 9,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "Kriter İş Programında",
                     TseId          = 11,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "Kriter Tasarısı",
                     TseId          = 12,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "Kriter Teklifi",
                     TseId          = 10,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "ST",
                     TseId          = 1,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "TD*GD",
                     TseId          = 2,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "TR*TS",
                     TseId          = 6,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
                     DokumanTipiAdi = "UTO Rehber Doküman",
                     TseId          = 15,
                     DurumId        = 1
                 },
                 new DokumanTipi
                 {
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
                HazirlikGrubuAdi    = "Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                TseId               = 106,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Alıcı Ortam Özel Daimi Komitesi",
                TseId               = 135,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Ambalaj Özel Daimi Komitesi ÖDK",
                TseId               = 136,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                TseId               = 107,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Atıklar Özel Daimi Komitesi",
                TseId               = 150,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Aydınlatma ve İç Tesisat Özel Daimi Komitesi",
                TseId               = 4,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Aydınlatma ve Kablo Özel Daimi Komitesi",
                TseId               = 1742,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Basınçlı Kaplar Özel Daimi Komitesi",
                TseId               = 152,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Bilgi Teknolojileri ve İletişim İhtisas Grubu",
                TseId               = 97,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Bilişim Teknolojileri Test Belgelendirme Sektörü",
                TseId               = 2752,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Cam Seramik ve Refrakter Malzeme Özel Daimi Komitesi",
                TseId               = 13,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Çevre İhtisas Grubu",
                TseId               = 28,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Çevre Sağlığı Özel Daimi Komitesi",
                TseId               = 151,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Çevre Sağlığı ve Atıklar Özel Daimi Komitesi",
                TseId               = 2,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Demiryolu Özel Daimi Komitesi",
                TseId               = 153,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Deprem Özel Daimi Komitesi",
                TseId               = 132,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Doğal Gaz Özel Daimi Komitesi",
                TseId               = 124,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Doküman Tercüme Komitesi",
                TseId               = 101,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Ekoloji Tarım Ürünleri Özel Daimi Komitesi",
                TseId               = 154,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Elektrik İhtisas Grubu",
                TseId               = 29,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Elektronik İhtisas Grubu",
                TseId               = 31,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Elektroteknik Güvenlik Özel Daimi Komitesi",
                TseId               = 1738,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Elektroteknik Güvenlik ve Aydınlatma  Özel Daimi Komitesi",
                TseId               = 2049,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Elektroteknik Sektörü Müdürlüğü",
                TseId               = 2734,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "EMU ve Radyo-TV Özel Daimi Komitesi",
                TseId               = 7,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Endüstriyel Yağlar Özel Daimi Komitesi",
                TseId               = 155,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Gıda Sektörü Müdürlüğü",
                TseId               = 2722,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Helal Gıda Sektör Müdürlüğü",
                TseId               = 2724,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Hizmet Standardları İhtisas Grubu",
                TseId               = 32,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Hizmet Yeri Belgelendirme Sektör Müdürlüğü",
                TseId               = 2739,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Isı Özel Daimi Komitesi",
                TseId               = 156,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "İnşaat İhtisas Grubu",
                TseId               = 33,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "İnşaat Makinaları Özel Daimi Komitesi",
                TseId               = 157,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Kablo Özel Daimi Komitesi",
                TseId               = 5,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Kapatılan Hazırlık Grupları",
                TseId               = 166,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Kapatılan ve Birleştirilen Özel Daimi Komiteler",
                TseId               = 130,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Kırtasiye Malzemeleri ve Formlar Özel Daimi Komitesi",
                TseId               = 158,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Kimya İhtisas Grubu",
                TseId               = 34,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Kimya Sektör Müdürlüğü",
                TseId               = 2719,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Laboratuvarlar Hazırlık Grubu",
                TseId               = 143,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Maden İhtisas Grubu",
                TseId               = 35,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Makina İhtisas Grubu",
                TseId               = 36,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Makine Sektörü Müdürlüğü",
                TseId               = 2720,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Mamul Gıdalar İhtisas Grubu",
                TseId               = 37,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Meslek Standardları İhtisas Grubu",
                TseId               = 126,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Metalurji İhtisas Grubu",
                TseId               = 127,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Milletlerarası Standardlar Özel Daimi Komitesi",
                TseId               = 159,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Milli Savunma Sanayii İhtisas Grubu",
                TseId               = 104,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Mühendislik Hizmetleri İhtisas Grubu",
                TseId               = 105,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "NBC ve KİS Özel Daimi Komitesi",
                TseId               = 217,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Nükleer Özel Daimi Komitesi",
                TseId               = 108,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Optik ve Optometri Özel Daimi Komitesi",
                TseId               = 160,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Orman ve Orman Ürünleri İhtisas Grubu",
                TseId               = 109,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Otomotiv Özel Daimi Komitesi",
                TseId               = 161,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Otomotiv Sektör Müdürlüğü",
                TseId               = 2783,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Otomotiv ve İnşaat Makinaları Özel Daimi Komitesi",
                TseId               = 123,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Özel Standardlar Hazırlık Grubu",
                TseId               = 146,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Petrokimya İhtisas Grubu",
                TseId               = 110,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Petrol İhtisas Grubu",
                TseId               = 112,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Plâstik Borular Özel Daimi Komitesi",
                TseId               = 111,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Radyo-TV Özel Daimi Komitesi",
                TseId               = 162,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Rezerv konular grubu",
                TseId               = 1779,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Sağlık İhtisas Grubu",
                TseId               = 114,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Standard Özel Daimi Komitesi",
                TseId               = 119,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Şehiriçi Yollar Özel Daimi Komitesi",
                TseId               = 163,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Tahribatsız Muayene Özel Daimi Komitesi",
                TseId               = 103,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Tarım Alet ve Makinaları Özel Daimi Komitesi",
                TseId               = 164,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Teknik Kurul",
                TseId               = 167,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Tekstil İhtisas Grubu",
                TseId               = 116,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Telekomünikasyon Özel Daimi Komitesi",
                TseId               = 102,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Tesisat ve Basınçlı Kaplar Özel Daimi Komitesi",
                TseId               = 122,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Tıbbi Cihazlar Özel Daimi Komitesi",
                TseId               = 115,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK1: Bilişim Teknolojileri Teknik Komitesi",
                TseId               = 2532,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK10: Yapı Malzemeleri Teknik Komitesi",
                TseId               = 2549,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK11:İzolasyon, Kaplama ve Yardımcı Yapı Malzemeleri Teknik Komitesi",
                TseId               = 2551,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK12: Yapı Güvenliği ve Akustik Teknik Komitesi",
                TseId               = 2553,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK13: Yapı Güvenliği Teknik Komitesi",
                TseId               = 2555,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK14: Kimya Teknik Komitesi",
                TseId               = 2557,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK15: Petrokimya Teknik Komitesi",
                TseId               = 2559,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK16: Petrol ve Petrol Ürünleri Teknik Komitesi",
                TseId               = 2560,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK17: Maden Teknik Komitesi",
                TseId               = 2562,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK18: İmalat Makineleri ve Takımları Teknik Komitesi",
                TseId               = 2564,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK19: Otomotiv Teknik Komitesi",
                TseId               = 2566,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK2: Çevre Teknik Komitesi",
                TseId               = 2533,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK20: Makine Güvenliği Teknik Komitesi",
                TseId               = 2570,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK21: Tesisat, Isıtma, Soğutma ve Havalandırma Teknik Komitesi",
                TseId               = 2568,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK22: Tesisat ve Basınçlı Kaplar Teknik Komitesi",
                TseId               = 2572,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK23: Metalürji Teknik Komitesi",
                TseId               = 2574,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK24: Gıda Teknik Komitesi",
                TseId               = 2576,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK25: Ziraat Teknik Komitesi",
                TseId               = 2578,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK26: Kişisel Koruyucu ve Oyun Alanı Donanım Teknik Komitesi",
                TseId               = 2580,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK27: Yangın Teknik Komitesi",
                TseId               = 2582,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK28: Ambalaj Teknik Komitesi",
                TseId               = 2584,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK29: Yönetim Sistemleri Teknik Komitesi",
                TseId               = 2586,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK3: Elektrik Elektroteknik ve Güvenlik Teknik Komitesi",
                TseId               = 2535,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK30: Enerji ve Enerji Sistemleri Teknik Komitesi",
                TseId               = 2588,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK31: Orman ve Orman Ürünleri Teknik Komitesi",
                TseId               = 2590,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK32: Sağlık Teknik Komitesi",
                TseId               = 2592,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK33: Medikal Teknik Komitesi",
                TseId               = 2594,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK34: Tekstil Teknik Komitesi",
                TseId               = 2596,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK35: Elektrik ve Elektronik Yetkili Servisleri Teknik Komitesi",
                TseId               = 2598,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK36: Milli Savunma Teknik Komitesi",
                TseId               = 2600,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK37: Helal Teknik Komitesi",
                TseId               = 2602,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK38: Sosyal Hizmetler Teknik Komitesi",
                TseId               = 2604,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK39: Mekanik ve Elektromekanik Yetkili Servisleri Teknik Komitesi",
                TseId               = 2606,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK4: Elektrik Üretim,İletim Ve Dağıtım Teknik Komitesi",
                TseId               = 2537,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK40: Demiryolu Teknik Komitesi",
                TseId               = 2625,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK41: Uzay ve Havacılık Teknik Komitesi",
                TseId               = 2671,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK42: Nükleer Teknik Komitesi",
                TseId               = 2742,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK43: Tercüme-1 Teknik Komitesi",
                TseId               = 2748,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK44: Tercüme-2 Teknik Komitesi",
                TseId               = 2750,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK45: İş Sağlığı ve Güvenliği Teknik Komitesi",
                TseId               = 2771,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK46: Süs Bitkileri",
                TseId               = 2797,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK5: Aydınlatma ve Bina İçi Tesisleri İle Yardımcı Donanımları Teknik Komitesi",
                TseId               = 2539,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK6: İletkenler, Kablolar Ve Yalıtım Malzemeleri Teknik Komitesi",
                TseId               = 2541,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK7: Yüksek Gerilim Teknikleri ve Yıldırımdan Korunma Sistemleri Teknik Komitesi",
                TseId               = 2543,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK8: Elektronik Teknik Komitesi",
                TseId               = 2546,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TK9: Sanayi Hizmetleri Teknik Komitesi",
                TseId               = 2547,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TSEK Özel Daimi Komitesi",
                TseId               = 2507,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "TSE-Yapılarda Tahribatsız Muayene Özel Daimi Komitesi",
                TseId               = 2508,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Ulusal Teknik Onay Esas Belirleme Komisyonu",
                TseId               = 2799,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Yangın Özel Daimi Komitesi",
                TseId               = 113,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Yapı Malzemeleri ÖDK",
                TseId               = 2503,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Yapı malzemeleri sektörü",
                TseId               = 2721,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Yetkili Servis Standardları İhtisas Grubu",
                TseId               = 1671,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Yönetim Sistemleri Geliştirme Sektörü",
                TseId               = 2803,
                DurumId             = 1
                },
                new HazirlikGrubu
                {
                HazirlikGrubuAdi    = "Ziraat İhtisas Grubu",
                TseId               = 117,
                DurumId             = 1
                }

                });
            #endregion           

            #region // Kisi
            context.Kisiler.AddRange(new List<Kisi> {
                new Kisi
                {
                    KisiId      = 1,
                    TcKimlikNo  = 28661334272,
                    Ad          = "Halil İbrahim",
                    Soyad       = "Poyraz",
                    UlkeId      = 1,
                    SehirId     = 34,
                    IlceId      = 432,
                    DurumId     = 1,
                    KisiEpostalar   = new List<KisiEposta>
                    {
                        new KisiEposta
                        {
                            KisiEpostaId         = 1,                            
                            EpostaAdresi     = "h.ibrahimpoyraz@gmail.com",
                            VarsayilanEposta = true,
                            DurumId          = 1
                        },
                        new KisiEposta
                        {
                            KisiEpostaId         = 2,                            
                            EpostaAdresi     = "hll_pyrz@hotmail.com",
                            VarsayilanEposta = false,
                            DurumId          = 1
                        }
                    },
                    KisiTelefonlar  = new List<KisiTelefon>
                    {
                        new KisiTelefon
                        {
                            TelefonTipiId     = 1,
                            TelefonNo         = "05345950053",
                            VarsiyalanTelefon = true,
                            DurumId           = 1
                        }
                    },
                    KisiVergiBilgileri = new KisiVergiBilgi
                    {
                        VergiDairesi = "Ümraniye",
                        VergiNo      = "2866133427",
                        DurumId      = 1
                    }
                    
                },
                new Kisi
                {
                    KisiId      = 2,
                    TcKimlikNo  = 44080828284,
                    Ad          = "Ali",
                    Soyad       = "Atabey",
                    UlkeId      = 1,
                    SehirId     = 34,
                    IlceId      = 431,
                    DurumId     = 1,
                    KisiEpostalar   = new List<KisiEposta> {
                        new KisiEposta
                        {
                            KisiEpostaId         = 1,
                            EpostaAdresi     = "ali@trendax.com.tr",
                            VarsayilanEposta = true,
                            DurumId          = 1
                        }
                    },
                    KisiVergiBilgileri = new KisiVergiBilgi
                    {
                        VergiDairesi = "Beyoğlu",
                        VergiNo      = "1234567890",
                        DurumId      = 1
                    }
                },
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

            #region // TanimlamaKategori
            context.TanimlamaKategorileri.AddRange(new List<TanimlamaKategori>{
                new TanimlamaKategori
                {                    
                    KategoriAdi         = "Telefon",
                    DurumId             = 1,
                    TanimlamaKategoriDegerleri = new List<TanimlamaKategoriDeger>{
                        new TanimlamaKategoriDeger
                        {
                            DegerAdi = "Cep Telefonu",
                            SıraNo   = 0,
                            DurumId  = 1
                        },
                        new TanimlamaKategoriDeger
                        {
                            DegerAdi = "Ev Telefonu",
                            SıraNo   = 0,
                            DurumId  = 1
                        },
                        new TanimlamaKategoriDeger
                        {
                            DegerAdi = "İş Telefonu",
                            SıraNo   = 0,
                            DurumId  = 1
                        },
                        new TanimlamaKategoriDeger
                        {
                            DegerAdi = "Fax",
                            SıraNo   = 0,
                            DurumId  = 1
                        }
                    },                      
                }
            });
            #endregion

            #region // Ulke
            context.Ulkeler.AddRange(new List<Ulke> {
                new Ulke
                {
                    UlkeId  = 1,
                    UlkeAdi = "Türkiye",
                    DurumId = 1,

                    Sehirler= new List<Sehir>
                    {
                        new Sehir
                        {
                            SehirId     = 1,
                            UlkeId      = 1,
                            SehirAdi    = "Adana",
                            DurumId     = 1,
                            Ilceler     = new List<Ilce>
                            {
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1104,
                                IlceAdi  = "Seyhan",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1219,
                                IlceAdi  = "Ceyhan",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1329,
                                IlceAdi  = "Feke",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1437,
                                IlceAdi  = "Karaisalı",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1443,
                                IlceAdi  = "Karataş",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1486,
                                IlceAdi  = "Kozan",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1580,
                                IlceAdi  = "Pozantı",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1588,
                                IlceAdi  = "Saimbeyli",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1687,
                                IlceAdi  = "Tufanbeyli",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1734,
                                IlceAdi  = "Yumurtalık",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1748,
                                IlceAdi  = "Yüreğir",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1757,
                                IlceAdi  = "Aladağ",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 1806,
                                IlceAdi  = "İmamoğlu",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 2032,
                                IlceAdi  = "Sarıçam",
                                DurumId  = 1
                                },
                                new Ilce
                                {
                                SehirId  = 1,
                                IlceKodu = 2033,
                                IlceAdi  = "Çukurova",
                                DurumId  = 1
                                },                                
                                }
                        },
                        new Sehir
                        {
                            SehirId     = 2,
                            UlkeId      = 1,
                            SehirAdi    = "Adıyaman",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 3,
                            UlkeId      = 1,
                            SehirAdi    = "Afyonkarahisar",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 4,
                            UlkeId      = 1,
                            SehirAdi    = "Ağrı",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 5,
                            UlkeId      = 1,
                            SehirAdi    = "Amasya",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 6,
                            UlkeId      = 1,
                            SehirAdi    = "Ankara",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 7,
                            UlkeId      = 1,
                            SehirAdi    = "Antalya",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 8,
                            UlkeId      = 1,
                            SehirAdi    = "Artvin",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 9,
                            UlkeId      = 1,
                            SehirAdi    = "Aydın",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 10,
                            UlkeId      = 1,
                            SehirAdi    = "Balıkesir",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 11,
                            UlkeId      = 1,
                            SehirAdi    = "Bilecik",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 12,
                            UlkeId      = 1,
                            SehirAdi    = "Bingöl",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 13,
                            UlkeId      = 1,
                            SehirAdi    = "Bitlis",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 14,
                            UlkeId      = 1,
                            SehirAdi    = "Bolu",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 15,
                            UlkeId      = 1,
                            SehirAdi    = "Burdur",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 16,
                            UlkeId      = 1,
                            SehirAdi    = "Bursa",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 17,
                            UlkeId      = 1,
                            SehirAdi    = "Çanakkale",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 18,
                            UlkeId      = 1,
                            SehirAdi    = "Çankırı",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 19,
                            UlkeId      = 1,
                            SehirAdi    = "Çorum",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 20,
                            UlkeId      = 1,
                            SehirAdi    = "Denizli",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 21,
                            UlkeId      = 1,
                            SehirAdi    = "Diyarbakır",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 22,
                            UlkeId      = 1,
                            SehirAdi    = "Edirne",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 23,
                            UlkeId      = 1,
                            SehirAdi    = "Elazığ",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 24,
                            UlkeId      = 1,
                            SehirAdi    = "Erzincan",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 25,
                            UlkeId      = 1,
                            SehirAdi    = "Erzurum",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 26,
                            UlkeId      = 1,
                            SehirAdi    = "Eskişehir",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 27,
                            UlkeId      = 1,
                            SehirAdi    = "Gaziantep",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 28,
                            UlkeId      = 1,
                            SehirAdi    = "Giresun",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 29,
                            UlkeId      = 1,
                            SehirAdi    = "Gümüşhane",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 30,
                            UlkeId      = 1,
                            SehirAdi    = "Hakkari",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 31,
                            UlkeId      = 1,
                            SehirAdi    = "Hatay",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 32,
                            UlkeId      = 1,
                            SehirAdi    = "Isparta",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 33,
                            UlkeId      = 1,
                            SehirAdi    = "Mersin",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 34,
                            UlkeId      = 1,
                            SehirAdi    = "İstanbul",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 35,
                            UlkeId      = 1,
                            SehirAdi    = "İzmir",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 36,
                            UlkeId      = 1,
                            SehirAdi    = "Kars",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 37,
                            UlkeId      = 1,
                            SehirAdi    = "Kastamonu",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 38,
                            UlkeId      = 1,
                            SehirAdi    = "Kayseri",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 39,
                            UlkeId      = 1,
                            SehirAdi    = "Kırklareli",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 40,
                            UlkeId      = 1,
                            SehirAdi    = "Kırşehir",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 41,
                            UlkeId      = 1,
                            SehirAdi    = "Kocaeli",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 42,
                            UlkeId      = 1,
                            SehirAdi    = "Konya",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 43,
                            UlkeId      = 1,
                            SehirAdi    = "Kütahya",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 44,
                            UlkeId      = 1,
                            SehirAdi    = "Malatya",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 45,
                            UlkeId      = 1,
                            SehirAdi    = "Manisa",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 46,
                            UlkeId      = 1,
                            SehirAdi    = "Kahramanmaraş",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 47,
                            UlkeId      = 1,
                            SehirAdi    = "Mardin",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 48,
                            UlkeId      = 1,
                            SehirAdi    = "Muğla",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 49,
                            UlkeId      = 1,
                            SehirAdi    = "Muş",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 50,
                            UlkeId      = 1,
                            SehirAdi    = "Nevşehir",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 51,
                            UlkeId      = 1,
                            SehirAdi    = "Niğde",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 52,
                            UlkeId      = 1,
                            SehirAdi    = "Ordu",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 53,
                            UlkeId      = 1,
                            SehirAdi    = "Rize",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 54,
                            UlkeId      = 1,
                            SehirAdi    = "Sakarya",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 55,
                            UlkeId      = 1,
                            SehirAdi    = "Samsun",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 56,
                            UlkeId      = 1,
                            SehirAdi    = "Siirt",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 57,
                            UlkeId      = 1,
                            SehirAdi    = "Sinop",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 58,
                            UlkeId      = 1,
                            SehirAdi    = "Sivas",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 59,
                            UlkeId      = 1,
                            SehirAdi    = "Tekirdağ",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 60,
                            UlkeId      = 1,
                            SehirAdi    = "Tokat",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 61,
                            UlkeId      = 1,
                            SehirAdi    = "Trabzon",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 62,
                            UlkeId      = 1,
                            SehirAdi    = "Tunceli",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 63,
                            UlkeId      = 1,
                            SehirAdi    = "Şanlıurfa",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 64,
                            UlkeId      = 1,
                            SehirAdi    = "Uşak",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 65,
                            UlkeId      = 1,
                            SehirAdi    = "Van",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 66,
                            UlkeId      = 1,
                            SehirAdi    = "Yozgat",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 67,
                            UlkeId      = 1,
                            SehirAdi    = "Zonguldak",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 68,
                            UlkeId      = 1,
                            SehirAdi    = "Aksaray",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 69,
                            UlkeId      = 1,
                            SehirAdi    = "Bayburt",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 70,
                            UlkeId      = 1,
                            SehirAdi    = "Karaman",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 71,
                            UlkeId      = 1,
                            SehirAdi    = "Kırıkkale",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 72,
                            UlkeId      = 1,
                            SehirAdi    = "Batman",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 73,
                            UlkeId      = 1,
                            SehirAdi    = "Şırnak",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 74,
                            UlkeId      = 1,
                            SehirAdi    = "Bartın",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 75,
                            UlkeId      = 1,
                            SehirAdi    = "Ardahan",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 76,
                            UlkeId      = 1,
                            SehirAdi    = "Iğdır",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 77,
                            UlkeId      = 1,
                            SehirAdi    = "Yalova",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 78,
                            UlkeId      = 1,
                            SehirAdi    = "Karabük",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 79,
                            UlkeId      = 1,
                            SehirAdi    = "Kilis",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 80,
                            UlkeId      = 1,
                            SehirAdi    = "Osmaniye",
                            DurumId     = 1
                        },
                        new Sehir
                        {
                            SehirId     = 81,
                            UlkeId      = 1,
                            SehirAdi    = "Düzce",
                            DurumId     = 1
                        }
                    }
                },
                new Ulke
                {
                    UlkeId  = 2,
                    UlkeAdi = "Almanya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 3,
                    UlkeAdi = "Amerika Birleşik Devletleri",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 4,
                    UlkeAdi = "Andora",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 5,
                    UlkeAdi = "Antigua ve Barbuda",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 6,
                    UlkeAdi = "Arjantin",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 7,
                    UlkeAdi = "Arnavutluk",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 8,
                    UlkeAdi = "Avusturalya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 9,
                    UlkeAdi = "Avusturya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 10,
                    UlkeAdi = "Azerbeycan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 11,
                    UlkeAdi = "Bahama",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 12,
                    UlkeAdi = "Bahreyn",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 13,
                    UlkeAdi = "Bangladeş",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 14,
                    UlkeAdi = "Bask Ülkesi",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 15,
                    UlkeAdi = "Batı Sahra",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 16,
                    UlkeAdi = "Belçika",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 17,
                    UlkeAdi = "Belize",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 18,
                    UlkeAdi = "Beyaz Rusya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 19,
                    UlkeAdi = "Bhutan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 20,
                    UlkeAdi = "Birleşik Arap Emirlikleri",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 21,
                    UlkeAdi = "Birleşik Devletler (ABD)",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 22,
                    UlkeAdi = "Birleşik Krallık",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 23,
                    UlkeAdi = "Bolivya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 24,
                    UlkeAdi = "Bosna-Hersek",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 25,
                    UlkeAdi = "Botsvana",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 26,
                    UlkeAdi = "Brezilya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 27,
                    UlkeAdi = "Bulgaristan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 28,
                    UlkeAdi = "Burma",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 29,
                    UlkeAdi = "Büyük Britanya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 30,
                    UlkeAdi = "Büyük Britanya ve Kuzey İrlanda Birleşik Krallığı",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 31,
                    UlkeAdi = "Cezayir",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 32,
                    UlkeAdi = "Cibuti",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 33,
                    UlkeAdi = "Çad",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 34,
                    UlkeAdi = "Çek Cumhuriyeti",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 35,
                    UlkeAdi = "Çin",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 36,
                    UlkeAdi = "Danimarka",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 37,
                    UlkeAdi = "Doğu Timor",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 38,
                    UlkeAdi = "Dominik Cumhuriyeti",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 39,
                    UlkeAdi = "Ekvator Ginesi",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 40,
                    UlkeAdi = "Eritre",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 41,
                    UlkeAdi = "Ermenistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 42,
                    UlkeAdi = "Estonya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 43,
                    UlkeAdi = "Etiyopya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 44,
                    UlkeAdi = "Faroe Adaları",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 45,
                    UlkeAdi = "Fas",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 46,
                    UlkeAdi = "Fiji",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 47,
                    UlkeAdi = "Fildişi Sahilleri",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 48,
                    UlkeAdi = "Filipinler",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 49,
                    UlkeAdi = "Finlandiya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 50,
                    UlkeAdi = "Fransa",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 51,
                    UlkeAdi = "Galler",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 52,
                    UlkeAdi = "Grönland",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 53,
                    UlkeAdi = "Güney Afrika",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 54,
                    UlkeAdi = "Gürcistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 55,
                    UlkeAdi = "Hırvatistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 56,
                    UlkeAdi = "Hindistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 57,
                    UlkeAdi = "Hollanda",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 58,
                    UlkeAdi = "Irak",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 59,
                    UlkeAdi = "İngiltere",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 60,
                    UlkeAdi = "İran",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 61,
                    UlkeAdi = "İrlanda",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 62,
                    UlkeAdi = "İrlanda Cumhuriyeti",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 63,
                    UlkeAdi = "İskoçya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 64,
                    UlkeAdi = "İspanya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 65,
                    UlkeAdi = "İsrail",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 66,
                    UlkeAdi = "İsveç",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 67,
                    UlkeAdi = "İsviçre",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 68,
                    UlkeAdi = "İtalya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 69,
                    UlkeAdi = "İzlanda",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 70,
                    UlkeAdi = "Jameika",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 71,
                    UlkeAdi = "Japonya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 72,
                    UlkeAdi = "Kamboçya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 73,
                    UlkeAdi = "Kamerun",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 74,
                    UlkeAdi = "Kanada",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 75,
                    UlkeAdi = "Karadağ",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 76,
                    UlkeAdi = "Kazakistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 77,
                    UlkeAdi = "Kıbrıs",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 78,
                    UlkeAdi = "Kırgızistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 79,
                    UlkeAdi = "Kolombiya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 80,
                    UlkeAdi = "Komoros",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 81,
                    UlkeAdi = "Kuzey İrlanda",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 82,
                    UlkeAdi = "Küba",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 83,
                    UlkeAdi = "Letonya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 84,
                    UlkeAdi = "Libya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 85,
                    UlkeAdi = "Lihtenştayn",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 86,
                    UlkeAdi = "litvanya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 87,
                    UlkeAdi = "Lübnan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 88,
                    UlkeAdi = "Lüksemburg",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 89,
                    UlkeAdi = "Macaristan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 90,
                    UlkeAdi = "Madagaskar",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 91,
                    UlkeAdi = "Makedonya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 92,
                    UlkeAdi = "Maldivler",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 93,
                    UlkeAdi = "Malezya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 94,
                    UlkeAdi = "Malta",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 95,
                    UlkeAdi = "Marshall Adaları",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 96,
                    UlkeAdi = "Meksika",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 97,
                    UlkeAdi = "Mısır",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 98,
                    UlkeAdi = "Moğolistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 99,
                    UlkeAdi = "Moldovya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 100,
                    UlkeAdi = "Monako",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 101,
                    UlkeAdi = "Mozambik",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 102,
                    UlkeAdi = "Myanmar",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 103,
                    UlkeAdi = "Norveç",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 104,
                    UlkeAdi = "Orta Afrika Cumhuriyeti",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 105,
                    UlkeAdi = "Özbekistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 106,
                    UlkeAdi = "Papua Yeni Gine",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 107,
                    UlkeAdi = "Polonya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 108,
                    UlkeAdi = "Portekiz",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 109,
                    UlkeAdi = "Romanya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 110,
                    UlkeAdi = "Rusya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 111,
                    UlkeAdi = "San Marino",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 112,
                    UlkeAdi = "Sırbistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 113,
                    UlkeAdi = "Sırbistan-Karadağ",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 114,
                    UlkeAdi = "Slovakya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 115,
                    UlkeAdi = "Slovenya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 116,
                    UlkeAdi = "Suriye",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 117,
                    UlkeAdi = "Suudi Arabistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 118,
                    UlkeAdi = "Şili",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 119,
                    UlkeAdi = "Tacikistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 120,
                    UlkeAdi = "Tayland",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 121,
                    UlkeAdi = "Tunus",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 122,
                    UlkeAdi = "Türkmenistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 123,
                    UlkeAdi = "Ukrayna",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 124,
                    UlkeAdi = "Ürdün",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 125,
                    UlkeAdi = "Vatikan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 126,
                    UlkeAdi = "Vietnam",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 127,
                    UlkeAdi = "Yemen",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 128,
                    UlkeAdi = "Yeni Zelanda",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 129,
                    UlkeAdi = "Yeşil Burun",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 130,
                    UlkeAdi = "Yunanistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 131,
                    UlkeAdi = "Zambiye",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 132,
                    UlkeAdi = "Zimbabve",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 133,
                    UlkeAdi = "Kuveyt",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 134,
                    UlkeAdi = "Pakistan",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 135,
                    UlkeAdi = "Güney Kore",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 136,
                    UlkeAdi = "Kuzey Kore",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 137,
                    UlkeAdi = "Singapur",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 138,
                    UlkeAdi = "Katar",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 139,
                    UlkeAdi = "Umman",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 140,
                    UlkeAdi = "Gana",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 141,
                    UlkeAdi = "Sri Lanka",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 142,
                    UlkeAdi = "Rusya",
                    DurumId = 1
                },
                new Ulke
                {
                    UlkeId  = 143,
                    UlkeAdi = "Afganistan",
                    DurumId = 1
                },
                 new Ulke
                {
                    UlkeId  = 144,
                    UlkeAdi = "Hong Kong",
                    DurumId = 1
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