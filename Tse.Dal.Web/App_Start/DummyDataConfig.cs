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
           
            #region // Durum
            context.Durumlar.AddRange(new List<Durum> {
                new Durum
                {   
                    DurumId = 1,                    
                    DurumAdi = "Aktif"
                },
                 new Durum
                 {                  
                    DurumId = 2,  
                    DurumAdi = "Pasif"
                 },
                new Durum
                 {
                    DurumId = 3,
                    DurumAdi = "Taslak"
                 },
                new Durum
                 {
                    DurumId = 4,
                    DurumAdi = "Silinmiş"
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

            #region // Sehir
            context.Sehirler.AddRange(new List<Sehir>
            {
                new Sehir
                {
                    SehirId     = 1,
                    UlkeId      = 1,
                    SehirAdi    = "Adana",
                    DurumId     = 1
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
            });
            #endregion

            #region // Ilce
            context.Ilceler.AddRange(new List<Ilce>
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
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1105,
                IlceAdi  = "Adıyaman Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1182,
                IlceAdi  = "Besni",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1246,
                IlceAdi  = "Çelikhan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1347,
                IlceAdi  = "Gerger",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1354,
                IlceAdi  = "Gölbaşı / Adıyaman",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1425,
                IlceAdi  = "Kahta",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1592,
                IlceAdi  = "Samsat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1985,
                IlceAdi  = "Sincik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 2,
                IlceKodu = 1989,
                IlceAdi  = "Tut",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1108,
                IlceAdi  = "Afyonkarahisar Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1200,
                IlceAdi  = "Bolvadin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1239,
                IlceAdi  = "Çay",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1267,
                IlceAdi  = "Dazkırı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1281,
                IlceAdi  = "Dinar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1306,
                IlceAdi  = "Emirdağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1404,
                IlceAdi  = "İhsaniye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1594,
                IlceAdi  = "Sandıklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1626,
                IlceAdi  = "Sinanpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1639,
                IlceAdi  = "Sultandağı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1664,
                IlceAdi  = "Şuhut",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1771,
                IlceAdi  = "Başmakçı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1773,
                IlceAdi  = "Bayat / Afyonkarahisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1809,
                IlceAdi  = "İscehisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1906,
                IlceAdi  = "Çobanlar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1923,
                IlceAdi  = "Evciler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1944,
                IlceAdi  = "Hocalar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 3,
                IlceKodu = 1961,
                IlceAdi  = "Kızılören",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1111,
                IlceAdi  = "Ağrı Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1283,
                IlceAdi  = "Diyadin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1287,
                IlceAdi  = "Doğubayazıt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1301,
                IlceAdi  = "Eleşkirt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1379,
                IlceAdi  = "Hamur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1568,
                IlceAdi  = "Patnos",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1667,
                IlceAdi  = "Taşlıçay",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 4,
                IlceKodu = 1691,
                IlceAdi  = "Tutak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 5,
                IlceKodu = 1134,
                IlceAdi  = "Amasya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 5,
                IlceKodu = 1363,
                IlceAdi  = "Göynücek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 5,
                IlceKodu = 1368,
                IlceAdi  = "Gümüşhacıköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 5,
                IlceKodu = 1524,
                IlceAdi  = "Merzifon",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 5,
                IlceKodu = 1641,
                IlceAdi  = "Suluova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 5,
                IlceKodu = 1668,
                IlceAdi  = "Taşova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 5,
                IlceKodu = 1938,
                IlceAdi  = "Hamamözü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1130,
                IlceAdi  = "Altındağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1157,
                IlceAdi  = "Ayaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1167,
                IlceAdi  = "Bala",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1187,
                IlceAdi  = "Beypazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1227,
                IlceAdi  = "Çamlıdere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1231,
                IlceAdi  = "Çankaya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1260,
                IlceAdi  = "Çubuk",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1302,
                IlceAdi  = "Elmadağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1365,
                IlceAdi  = "Güdül",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1387,
                IlceAdi  = "Haymana",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1427,
                IlceAdi  = "Kalecik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1473,
                IlceAdi  = "Kızılcahamam",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1539,
                IlceAdi  = "Nallıhan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1578,
                IlceAdi  = "Polatlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1658,
                IlceAdi  = "Şereflikoçhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1723,
                IlceAdi  = "Yenimahalle",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1744,
                IlceAdi  = "Gölbaşı / Ankara",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1745,
                IlceAdi  = "Keçiören",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1746,
                IlceAdi  = "Mamak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1747,
                IlceAdi  = "Sincan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1815,
                IlceAdi  = "Kazan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1872,
                IlceAdi  = "Akyurt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1922,
                IlceAdi  = "Etimesgut",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 1924,
                IlceAdi  = "Evren",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 6,
                IlceKodu = 2034,
                IlceAdi  = "Pursaklar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1121,
                IlceAdi  = "Akseki",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1126,
                IlceAdi  = "Alanya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1138,
                IlceAdi  = "Antalya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1303,
                IlceAdi  = "Elmalı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1333,
                IlceAdi  = "Finike",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1337,
                IlceAdi  = "Gazipaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1370,
                IlceAdi  = "Gündoğmuş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1451,
                IlceAdi  = "Kaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1483,
                IlceAdi  = "Korkuteli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1492,
                IlceAdi  = "Kumluca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1512,
                IlceAdi  = "Manavgat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1616,
                IlceAdi  = "Serik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1811,
                IlceAdi  = "Demre",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1946,
                IlceAdi  = "İbradı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 1959,
                IlceAdi  = "Kemer / Antalya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 2035,
                IlceAdi  = "Aksu / Antalya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 2036,
                IlceAdi  = "Döşemealtı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 2037,
                IlceAdi  = "Kepez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 2038,
                IlceAdi  = "Konyaaltı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 7,
                IlceKodu = 2039,
                IlceAdi  = "Muratpaşa",
                DurumId  = 1
                },                    
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1145,
                IlceAdi  = "Ardanuç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1147,
                IlceAdi  = "Arhavi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1152,
                IlceAdi  = "Artvin Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1202,
                IlceAdi  = "Borçka",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1395,
                IlceAdi  = "Hopa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1653,
                IlceAdi  = "Şavşat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1736,
                IlceAdi  = "Yusufeli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 8,
                IlceKodu = 1828,
                IlceAdi  = "Murgul",
                DurumId  = 1
                },                    
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1159,
                IlceAdi  = "Aydın Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1206,
                IlceAdi  = "Bozdoğan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1256,
                IlceAdi  = "Çine",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1348,
                IlceAdi  = "Germencik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1435,
                IlceAdi  = "Karacasu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1479,
                IlceAdi  = "Koçarlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1497,
                IlceAdi  = "Kuşadası",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1498,
                IlceAdi  = "Kuyucak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1542,
                IlceAdi  = "Nazilli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1637,
                IlceAdi  = "Söke",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1640,
                IlceAdi  = "Sultanhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1724,
                IlceAdi  = "Yenipazar / Aydın",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1781,
                IlceAdi  = "Buharkent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1807,
                IlceAdi  = "İncirliova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1957,
                IlceAdi  = "Karpuzlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 1968,
                IlceAdi  = "Köşk",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 2000,
                IlceAdi  = "Didim",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 9,
                IlceKodu = 2076,
                IlceAdi  = "Efeler",
                DurumId  = 1
                },                    
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1161,
                IlceAdi  = "Ayvalık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1168,
                IlceAdi  = "Balıkesir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1169,
                IlceAdi  = "Balya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1171,
                IlceAdi  = "Bandırma",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1191,
                IlceAdi  = "Bigadiç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1216,
                IlceAdi  = "Burhaniye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1291,
                IlceAdi  = "Dursunbey",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1294,
                IlceAdi  = "Edremit / Balıkesir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1310,
                IlceAdi  = "Erdek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1360,
                IlceAdi  = "Gönen / Balıkesir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1384,
                IlceAdi  = "Havran",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1418,
                IlceAdi  = "İvrindi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1462,
                IlceAdi  = "Kepsut",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1514,
                IlceAdi  = "Manyas",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1608,
                IlceAdi  = "Savaştepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1619,
                IlceAdi  = "Sındırgı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1644,
                IlceAdi  = "Susurluk",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1824,
                IlceAdi  = "Marmara",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 1928,
                IlceAdi  = "Gömeç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 2077,
                IlceAdi  = "Altıeylül",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 10,
                IlceKodu = 2078,
                IlceAdi  = "Karesi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1192,
                IlceAdi  = "Bilecik Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1210,
                IlceAdi  = "Bozüyük",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1359,
                IlceAdi  = "Gölpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1559,
                IlceAdi  = "Osmaneli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1571,
                IlceAdi  = "Pazaryeri",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1636,
                IlceAdi  = "Söğüt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1857,
                IlceAdi  = "Yenipazar / Bilecik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 11,
                IlceKodu = 1948,
                IlceAdi  = "İnhisar",
                DurumId  = 1
                },                    
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1193,
                IlceAdi  = "Bingöl Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1344,
                IlceAdi  = "Genç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1446,
                IlceAdi  = "Karlıova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1475,
                IlceAdi  = "Kiğı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1633,
                IlceAdi  = "Solhan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1750,
                IlceAdi  = "Adaklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1855,
                IlceAdi  = "Yayladere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 12,
                IlceKodu = 1996,
                IlceAdi  = "Yedisu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 13,
                IlceKodu = 1106,
                IlceAdi  = "Adilcevaz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 13,
                IlceKodu = 1112,
                IlceAdi  = "Ahlat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 13,
                IlceKodu = 1196,
                IlceAdi  = "Bitlis Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 13,
                IlceKodu = 1394,
                IlceAdi  = "Hizan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 13,
                IlceKodu = 1537,
                IlceAdi  = "Mutki",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 13,
                IlceKodu = 1669,
                IlceAdi  = "Tatvan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 13,
                IlceKodu = 1798,
                IlceAdi  = "Güroymak",
                DurumId  = 1
                },                    
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1199,
                IlceAdi  = "Bolu Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1346,
                IlceAdi  = "Gerede",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1364,
                IlceAdi  = "Göynük",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1466,
                IlceAdi  = "Kıbrıscık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1522,
                IlceAdi  = "Mengen",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1531,
                IlceAdi  = "Mudurnu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1610,
                IlceAdi  = "Seben",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1916,
                IlceAdi  = "Dörtdivan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 14,
                IlceKodu = 1997,
                IlceAdi  = "Yeniçağa",
                DurumId  = 1
                },                                    
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1109,
                IlceAdi  = "Ağlasun",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1211,
                IlceAdi  = "Bucak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1215,
                IlceAdi  = "Burdur Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1357,
                IlceAdi  = "Gölhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1672,
                IlceAdi  = "Tefenni",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1728,
                IlceAdi  = "Yeşilova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1813,
                IlceAdi  = "Karamanlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1816,
                IlceAdi  = "Kemer / Burdur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1874,
                IlceAdi  = "Altınyayla / Burdur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1899,
                IlceAdi  = "Çavdır",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 15,
                IlceKodu = 1903,
                IlceAdi  = "Çeltikçi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1343,
                IlceAdi  = "Gemlik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1411,
                IlceAdi  = "İnegöl",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1420,
                IlceAdi  = "İznik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1434,
                IlceAdi  = "Karacabey",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1457,
                IlceAdi  = "Keles",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1530,
                IlceAdi  = "Mudanya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1535,
                IlceAdi  = "Mustafakemalpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1553,
                IlceAdi  = "Orhaneli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1554,
                IlceAdi  = "Orhangazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1725,
                IlceAdi  = "Yenişehir / Bursa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1783,
                IlceAdi  = "Büyükorhan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1799,
                IlceAdi  = "Harmancık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1829,
                IlceAdi  = "Nilüfer",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1832,
                IlceAdi  = "Osmangazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1859,
                IlceAdi  = "Yıldırım",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1935,
                IlceAdi  = "Gürsu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 16,
                IlceKodu = 1960,
                IlceAdi  = "Kestel",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1160,
                IlceAdi  = "Ayvacık / Çanakkale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1180,
                IlceAdi  = "Bayramiç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1190,
                IlceAdi  = "Biga",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1205,
                IlceAdi  = "Bozcaada",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1229,
                IlceAdi  = "Çan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1230,
                IlceAdi  = "Çanakkale Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1293,
                IlceAdi  = "Eceabat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1326,
                IlceAdi  = "Ezine",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1340,
                IlceAdi  = "Gelibolu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1408,
                IlceAdi  = "Gökçeada",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1503,
                IlceAdi  = "Lapseki",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 17,
                IlceKodu = 1722,
                IlceAdi  = "Yenice / Çanakkale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1232,
                IlceAdi  = "Çankırı Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1248,
                IlceAdi  = "Çerkeş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1300,
                IlceAdi  = "Eldivan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1399,
                IlceAdi  = "Ilgaz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1494,
                IlceAdi  = "Kurşunlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1555,
                IlceAdi  = "Orta",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1649,
                IlceAdi  = "Şabanözü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1718,
                IlceAdi  = "Yapraklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1765,
                IlceAdi  = "Atkaracalar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1817,
                IlceAdi  = "Kızılırmak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1885,
                IlceAdi  = "Bayramören",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 18,
                IlceKodu = 1963,
                IlceAdi  = "Korgun",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1124,
                IlceAdi  = "Alaca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1177,
                IlceAdi  = "Bayat / Çorum",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1259,
                IlceAdi  = "Çorum Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1414,
                IlceAdi  = "İskilip",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1445,
                IlceAdi  = "Kargı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1520,
                IlceAdi  = "Mecitözü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1556,
                IlceAdi  = "Ortaköy / Çorum",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1558,
                IlceAdi  = "Osmancık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1642,
                IlceAdi  = "Sungurlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1778,
                IlceAdi  = "Boğazkale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1850,
                IlceAdi  = "Uğurludağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1911,
                IlceAdi  = "Dodurga",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1972,
                IlceAdi  = "Laçin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 19,
                IlceKodu = 1976,
                IlceAdi  = "Oğuzlar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1102,
                IlceAdi  = "Acıpayam",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1214,
                IlceAdi  = "Buldan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1224,
                IlceAdi  = "Çal",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1226,
                IlceAdi  = "Çameli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1233,
                IlceAdi  = "Çardak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1257,
                IlceAdi  = "Çivril",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1271,
                IlceAdi  = "Denizli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1371,
                IlceAdi  = "Güney",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1426,
                IlceAdi  = "Kale / Denizli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1597,
                IlceAdi  = "Sarayköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1670,
                IlceAdi  = "Tavas",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1769,
                IlceAdi  = "Babadağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1774,
                IlceAdi  = "Bekilli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1803,
                IlceAdi  = "Honaz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1840,
                IlceAdi  = "Serinhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1871,
                IlceAdi  = "Pamukkale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1881,
                IlceAdi  = "Baklan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1888,
                IlceAdi  = "Beyağaç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 1889,
                IlceAdi  = "Bozkurt / Denizli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 20,
                IlceKodu = 2079,
                IlceAdi  = "Merkezefendi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1195,
                IlceAdi  = "Bismil",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1249,
                IlceAdi  = "Çermik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1253,
                IlceAdi  = "Çınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1263,
                IlceAdi  = "Çüngüş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1278,
                IlceAdi  = "Dicle",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1284,
                IlceAdi  = "Diyarbakır Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1315,
                IlceAdi  = "Ergani",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1381,
                IlceAdi  = "Hani",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1389,
                IlceAdi  = "Hazro",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1490,
                IlceAdi  = "Kulp",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1504,
                IlceAdi  = "Lice",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1624,
                IlceAdi  = "Silvan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1791,
                IlceAdi  = "Eğil",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 1962,
                IlceAdi  = "Kocaköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 2040,
                IlceAdi  = "Bağlar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 2041,
                IlceAdi  = "Kayapınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 2042,
                IlceAdi  = "Sur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 21,
                IlceKodu = 2043,
                IlceAdi  = "Yenişehir / Diyarbakır",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1295,
                IlceAdi  = "Edirne Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1307,
                IlceAdi  = "Enez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1385,
                IlceAdi  = "Havsa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1412,
                IlceAdi  = "İpsala",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1464,
                IlceAdi  = "Keşan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1502,
                IlceAdi  = "Lalapaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1523,
                IlceAdi  = "Meriç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1705,
                IlceAdi  = "Uzunköprü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 22,
                IlceKodu = 1988,
                IlceAdi  = "Süloğlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1110,
                IlceAdi  = "Ağın",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1173,
                IlceAdi  = "Baskil",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1298,
                IlceAdi  = "Elazığ Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1438,
                IlceAdi  = "Karakoçan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1455,
                IlceAdi  = "Keban",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1506,
                IlceAdi  = "Maden",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1566,
                IlceAdi  = "Palu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1631,
                IlceAdi  = "Sivrice",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1762,
                IlceAdi  = "Arıcak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1820,
                IlceAdi  = "Kovancılar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 23,
                IlceKodu = 1873,
                IlceAdi  = "Alacakaya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1243,
                IlceAdi  = "Çayırlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1318,
                IlceAdi  = "Erzincan Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1406,
                IlceAdi  = "İliç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1459,
                IlceAdi  = "Kemah",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1460,
                IlceAdi  = "Kemaliye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1583,
                IlceAdi  = "Refahiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1675,
                IlceAdi  = "Tercan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1853,
                IlceAdi  = "Üzümlü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 24,
                IlceKodu = 1977,
                IlceAdi  = "Otlukbeli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1153,
                IlceAdi  = "Aşkale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1235,
                IlceAdi  = "Çat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1319,
                IlceAdi  = "Erzurum Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1392,
                IlceAdi  = "Hınıs",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1396,
                IlceAdi  = "Horasan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1416,
                IlceAdi  = "İspir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1444,
                IlceAdi  = "Karayazı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1540,
                IlceAdi  = "Narman",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1550,
                IlceAdi  = "Oltu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1551,
                IlceAdi  = "Olur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1567,
                IlceAdi  = "Pasinler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1657,
                IlceAdi  = "Şenkaya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1674,
                IlceAdi  = "Tekman",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1683,
                IlceAdi  = "Tortum",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1812,
                IlceAdi  = "Karaçoban",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1851,
                IlceAdi  = "Uzundere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1865,
                IlceAdi  = "Pazaryolu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1945,
                IlceAdi  = "Aziziye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 1967,
                IlceAdi  = "Köprüköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 2044,
                IlceAdi  = "Palandöken",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 25,
                IlceKodu = 2045,
                IlceAdi  = "Yakutiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1255,
                IlceAdi  = "Çifteler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1322,
                IlceAdi  = "Eskişehir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1508,
                IlceAdi  = "Mahmudiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1527,
                IlceAdi  = "Mihalıççık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1599,
                IlceAdi  = "Sarıcakaya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1618,
                IlceAdi  = "Seyitgazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1632,
                IlceAdi  = "Sivrihisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1759,
                IlceAdi  = "Alpu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1777,
                IlceAdi  = "Beylikova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1808,
                IlceAdi  = "İnönü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1934,
                IlceAdi  = "Günyüzü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1939,
                IlceAdi  = "Han",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 1973,
                IlceAdi  = "Mihalgazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 2046,
                IlceAdi  = "Odunpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 26,
                IlceKodu = 2047,
                IlceAdi  = "Tepebaşı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1139,
                IlceAdi  = "Araban",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1415,
                IlceAdi  = "İslahiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1546,
                IlceAdi  = "Nizip",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1549,
                IlceAdi  = "Oğuzeli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1720,
                IlceAdi  = "Yavuzeli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1841,
                IlceAdi  = "Şahinbey",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1844,
                IlceAdi  = "Şehitkamil",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1956,
                IlceAdi  = "Karkamış",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 27,
                IlceKodu = 1974,
                IlceAdi  = "Nurdağı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1133,
                IlceAdi  = "Alucra",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1212,
                IlceAdi  = "Bulancak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1272,
                IlceAdi  = "Dereli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1320,
                IlceAdi  = "Espiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1324,
                IlceAdi  = "Eynesil",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1352,
                IlceAdi  = "Giresun Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1361,
                IlceAdi  = "Görele",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1465,
                IlceAdi  = "Keşap",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1654,
                IlceAdi  = "Şebinkarahisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1678,
                IlceAdi  = "Tirebolu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1837,
                IlceAdi  = "Piraziz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1854,
                IlceAdi  = "Yağlıdere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1893,
                IlceAdi  = "Çamoluk",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1894,
                IlceAdi  = "Çanakçı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1912,
                IlceAdi  = "Doğankent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 28,
                IlceKodu = 1930,
                IlceAdi  = "Güce",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 29,
                IlceKodu = 1369,
                IlceAdi  = "Gümüşhane Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 29,
                IlceKodu = 1458,
                IlceAdi  = "Kelkit",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 29,
                IlceKodu = 1660,
                IlceAdi  = "Şiran",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 29,
                IlceKodu = 1684,
                IlceAdi  = "Torul",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 29,
                IlceKodu = 1822,
                IlceAdi  = "Köse",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 29,
                IlceKodu = 1971,
                IlceAdi  = "Kürtün",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 30,
                IlceKodu = 1261,
                IlceAdi  = "Çukurca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 30,
                IlceKodu = 1377,
                IlceAdi  = "Hakkari Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 30,
                IlceKodu = 1656,
                IlceAdi  = "Şemdinli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 30,
                IlceKodu = 1737,
                IlceAdi  = "Yüksekova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1131,
                IlceAdi  = "Altınözü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1289,
                IlceAdi  = "Dörtyol",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1382,
                IlceAdi  = "Hassa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1383,
                IlceAdi  = "Hatay Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1413,
                IlceAdi  = "İskenderun",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1468,
                IlceAdi  = "Kırıkhan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1585,
                IlceAdi  = "Reyhanlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1591,
                IlceAdi  = "Samandağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1721,
                IlceAdi  = "Yayladağı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1792,
                IlceAdi  = "Erzin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1887,
                IlceAdi  = "Belen",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 1970,
                IlceAdi  = "Kumlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 2080,
                IlceAdi  = "Antakya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 2081,
                IlceAdi  = "Arsuz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 2082,
                IlceAdi  = "Defne",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 31,
                IlceKodu = 2083,
                IlceAdi  = "Payas",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1154,
                IlceAdi  = "Atabey",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1297,
                IlceAdi  = "Eğirdir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1341,
                IlceAdi  = "Gelendost",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1401,
                IlceAdi  = "Isparta Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1456,
                IlceAdi  = "Keçiborlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1615,
                IlceAdi  = "Senirkent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1648,
                IlceAdi  = "Sütçüler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1651,
                IlceAdi  = "Şarkikaraağaç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1699,
                IlceAdi  = "Uluborlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1717,
                IlceAdi  = "Yalvaç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1755,
                IlceAdi  = "Aksu / Isparta",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 1929,
                IlceAdi  = "Gönen / Isparta",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 32,
                IlceKodu = 2001,
                IlceAdi  = "Yenişarbademli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1135,
                IlceAdi  = "Anamur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1311,
                IlceAdi  = "Erdemli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1366,
                IlceAdi  = "Gülnar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1402,
                IlceAdi  = "Mersin Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1536,
                IlceAdi  = "Mut",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1621,
                IlceAdi  = "Silifke",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1665,
                IlceAdi  = "Tarsus",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1766,
                IlceAdi  = "Aydıncık / Mersin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1779,
                IlceAdi  = "Bozyazı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 1892,
                IlceAdi  = "Çamlıyayla",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 2064,
                IlceAdi  = "Akdeniz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 2065,
                IlceAdi  = "Mezitli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 2066,
                IlceAdi  = "Toroslar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 33,
                IlceKodu = 2067,
                IlceAdi  = "Yenişehir / Mersin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1103,
                IlceAdi  = "Adalar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1166,
                IlceAdi  = "Bakırköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1183,
                IlceAdi  = "Beşiktaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1185,
                IlceAdi  = "Beykoz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1186,
                IlceAdi  = "Beyoğlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1237,
                IlceAdi  = "Çatalca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1305,
                IlceAdi  = "Eminönü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1325,
                IlceAdi  = "Eyüp",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1327,
                IlceAdi  = "Fatih",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1336,
                IlceAdi  = "Gaziosmanpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1421,
                IlceAdi  = "Kadıköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1449,
                IlceAdi  = "Kartal",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1604,
                IlceAdi  = "Sarıyer",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1622,
                IlceAdi  = "Silivri",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1659,
                IlceAdi  = "Şile",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1663,
                IlceAdi  = "Şişli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1708,
                IlceAdi  = "Üsküdar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1739,
                IlceAdi  = "Zeytinburnu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1782,
                IlceAdi  = "Büyükçekmece",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1810,
                IlceAdi  = "Kağıthane",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1823,
                IlceAdi  = "Küçükçekmece",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1835,
                IlceAdi  = "Pendik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1852,
                IlceAdi  = "Ümraniye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 1886,
                IlceAdi  = "Bayrampaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2003,
                IlceAdi  = "Avcılar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2004,
                IlceAdi  = "Bağcılar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2005,
                IlceAdi  = "Bahçelievler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2010,
                IlceAdi  = "Güngören",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2012,
                IlceAdi  = "Maltepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2014,
                IlceAdi  = "Sultanbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2015,
                IlceAdi  = "Tuzla",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2016,
                IlceAdi  = "Esenler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2048,
                IlceAdi  = "Arnavutköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2049,
                IlceAdi  = "Ataşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2050,
                IlceAdi  = "Başakşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2051,
                IlceAdi  = "Beylikdüzü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2052,
                IlceAdi  = "Çekmeköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2053,
                IlceAdi  = "Esenyurt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2054,
                IlceAdi  = "Sancaktepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 34,
                IlceKodu = 2055,
                IlceAdi  = "Sultangazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1128,
                IlceAdi  = "Aliağa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1178,
                IlceAdi  = "Bayındır",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1181,
                IlceAdi  = "Bergama",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1203,
                IlceAdi  = "Bornova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1251,
                IlceAdi  = "Çeşme",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1280,
                IlceAdi  = "Dikili",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1334,
                IlceAdi  = "Foça",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1432,
                IlceAdi  = "Karaburun",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1448,
                IlceAdi  = "Karşıyaka",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1461,
                IlceAdi  = "Kemalpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1467,
                IlceAdi  = "Kınık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1477,
                IlceAdi  = "Kiraz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1521,
                IlceAdi  = "Menemen",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1563,
                IlceAdi  = "Ödemiş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1611,
                IlceAdi  = "Seferihisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1612,
                IlceAdi  = "Selçuk",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1677,
                IlceAdi  = "Tire",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1682,
                IlceAdi  = "Torbalı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1703,
                IlceAdi  = "Urla",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1776,
                IlceAdi  = "Beydağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1780,
                IlceAdi  = "Buca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1819,
                IlceAdi  = "Konak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 1826,
                IlceAdi  = "Menderes",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 2006,
                IlceAdi  = "Balçova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 2007,
                IlceAdi  = "Çiğli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 2009,
                IlceAdi  = "Gaziemir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 2013,
                IlceAdi  = "Narlıdere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 2018,
                IlceAdi  = "Güzelbahçe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 2056,
                IlceAdi  = "Bayraklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 35,
                IlceKodu = 2057,
                IlceAdi  = "Karabağlar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1149,
                IlceAdi  = "Arpaçay",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1279,
                IlceAdi  = "Digor",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1424,
                IlceAdi  = "Kağızman",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1447,
                IlceAdi  = "Kars Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1601,
                IlceAdi  = "Sarıkamış",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1614,
                IlceAdi  = "Selim",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1645,
                IlceAdi  = "Susuz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 36,
                IlceKodu = 1756,
                IlceAdi  = "Akyaka",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1101,
                IlceAdi  = "Abana",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1140,
                IlceAdi  = "Araç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1162,
                IlceAdi  = "Azdavay",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1208,
                IlceAdi  = "Bozkurt / Kastamonu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1221,
                IlceAdi  = "Cide",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1238,
                IlceAdi  = "Çatalzeytin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1264,
                IlceAdi  = "Daday",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1277,
                IlceAdi  = "Devrekani",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1410,
                IlceAdi  = "İnebolu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1450,
                IlceAdi  = "Kastamonu Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1499,
                IlceAdi  = "Küre",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1666,
                IlceAdi  = "Taşköprü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1685,
                IlceAdi  = "Tosya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1805,
                IlceAdi  = "İhsangazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1836,
                IlceAdi  = "Pınarbaşı / Kastamonu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1845,
                IlceAdi  = "Şenpazar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1867,
                IlceAdi  = "Ağlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1915,
                IlceAdi  = "Doğanyurt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1940,
                IlceAdi  = "Hanönü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 37,
                IlceKodu = 1984,
                IlceAdi  = "Seydiler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1218,
                IlceAdi  = "Bünyan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1275,
                IlceAdi  = "Develi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1330,
                IlceAdi  = "Felahiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1409,
                IlceAdi  = "İncesu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1576,
                IlceAdi  = "Pınarbaşı / Kayseri",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1603,
                IlceAdi  = "Sarıoğlan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1605,
                IlceAdi  = "Sarız",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1680,
                IlceAdi  = "Tomarza",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1715,
                IlceAdi  = "Yahyalı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1727,
                IlceAdi  = "Yeşilhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1752,
                IlceAdi  = "Akkışla",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1846,
                IlceAdi  = "Talas",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1863,
                IlceAdi  = "Kocasinan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1864,
                IlceAdi  = "Melikgazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1936,
                IlceAdi  = "Hacılar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 38,
                IlceKodu = 1978,
                IlceAdi  = "Özvatan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1163,
                IlceAdi  = "Babaeski",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1270,
                IlceAdi  = "Demirköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1471,
                IlceAdi  = "Kırklareli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1480,
                IlceAdi  = "Kofçaz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1505,
                IlceAdi  = "Lüleburgaz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1572,
                IlceAdi  = "Pehlivanköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1577,
                IlceAdi  = "Pınarhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 39,
                IlceKodu = 1714,
                IlceAdi  = "Vize",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 40,
                IlceKodu = 1254,
                IlceAdi  = "Çiçekdağı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 40,
                IlceKodu = 1429,
                IlceAdi  = "Kaman",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 40,
                IlceKodu = 1472,
                IlceAdi  = "Kırşehir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 40,
                IlceKodu = 1529,
                IlceAdi  = "Mucur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 40,
                IlceKodu = 1754,
                IlceAdi  = "Akpınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 40,
                IlceKodu = 1869,
                IlceAdi  = "Akçakent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 40,
                IlceKodu = 1890,
                IlceAdi  = "Boztepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 1338,
                IlceAdi  = "Gebze",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 1355,
                IlceAdi  = "Gölcük",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 1430,
                IlceAdi  = "Kandıra",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 1440,
                IlceAdi  = "Karamürsel",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 1478,
                IlceAdi  = "Kocaeli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 1821,
                IlceAdi  = "Körfez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 2030,
                IlceAdi  = "Derince",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 2058,
                IlceAdi  = "Başiskele",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 2059,
                IlceAdi  = "Çayırova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 2060,
                IlceAdi  = "Darıca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 2061,
                IlceAdi  = "Dilovası",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 2062,
                IlceAdi  = "İzmit",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 41,
                IlceKodu = 2063,
                IlceAdi  = "Kartepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1122,
                IlceAdi  = "Akşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1188,
                IlceAdi  = "Beyşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1207,
                IlceAdi  = "Bozkır",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1222,
                IlceAdi  = "Cihanbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1262,
                IlceAdi  = "Çumra",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1285,
                IlceAdi  = "Doğanhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1312,
                IlceAdi  = "Ereğli / Konya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1375,
                IlceAdi  = "Hadim",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1400,
                IlceAdi  = "Ilgın",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1422,
                IlceAdi  = "Kadınhanı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1441,
                IlceAdi  = "Karapınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1491,
                IlceAdi  = "Kulu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1598,
                IlceAdi  = "Sarayönü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1617,
                IlceAdi  = "Seydişehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1735,
                IlceAdi  = "Yunak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1753,
                IlceAdi  = "Akören",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1760,
                IlceAdi  = "Altınekin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1789,
                IlceAdi  = "Derebucak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1804,
                IlceAdi  = "Hüyük",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1814,
                IlceAdi  = "Karatay",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1827,
                IlceAdi  = "Meram",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1839,
                IlceAdi  = "Selçuklu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1848,
                IlceAdi  = "Taşkent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1868,
                IlceAdi  = "Ahırlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1902,
                IlceAdi  = "Çeltik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1907,
                IlceAdi  = "Derbent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1920,
                IlceAdi  = "Emirgazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1933,
                IlceAdi  = "Güneysınır",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1937,
                IlceAdi  = "Halkapınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1990,
                IlceAdi  = "Tuzlukçu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 42,
                IlceKodu = 1994,
                IlceAdi  = "Yalıhüyük",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1132,
                IlceAdi  = "Altıntaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1288,
                IlceAdi  = "Domaniç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1304,
                IlceAdi  = "Emet",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1339,
                IlceAdi  = "Gediz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1500,
                IlceAdi  = "Kütahya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1625,
                IlceAdi  = "Simav",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1671,
                IlceAdi  = "Tavşanlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1764,
                IlceAdi  = "Aslanapa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1790,
                IlceAdi  = "Dumlupınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1802,
                IlceAdi  = "Hisarcık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1843,
                IlceAdi  = "Şaphane",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1898,
                IlceAdi  = "Çavdarhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 43,
                IlceKodu = 1979,
                IlceAdi  = "Pazarlar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1114,
                IlceAdi  = "Akçadağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1143,
                IlceAdi  = "Arapgir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1148,
                IlceAdi  = "Arguvan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1265,
                IlceAdi  = "Darende",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1286,
                IlceAdi  = "Doğanşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1390,
                IlceAdi  = "Hekimhan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1509,
                IlceAdi  = "Malatya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1582,
                IlceAdi  = "Pütürge",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1729,
                IlceAdi  = "Yeşilyurt / Malatya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1772,
                IlceAdi  = "Battalgazi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1914,
                IlceAdi  = "Doğanyol",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1953,
                IlceAdi  = "Kale / Malatya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1969,
                IlceAdi  = "Kuluncak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 44,
                IlceKodu = 1995,
                IlceAdi  = "Yazıhan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1118,
                IlceAdi  = "Akhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1127,
                IlceAdi  = "Alaşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1269,
                IlceAdi  = "Demirci",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1362,
                IlceAdi  = "Gördes",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1470,
                IlceAdi  = "Kırkağaç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1489,
                IlceAdi  = "Kula",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1513,
                IlceAdi  = "Manisa Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1590,
                IlceAdi  = "Salihli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1600,
                IlceAdi  = "Sarıgöl",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1606,
                IlceAdi  = "Saruhanlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1613,
                IlceAdi  = "Selendi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1634,
                IlceAdi  = "Soma",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1689,
                IlceAdi  = "Turgutlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1751,
                IlceAdi  = "Ahmetli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1793,
                IlceAdi  = "Gölmarmara",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 1965,
                IlceAdi  = "Köprübaşı / Manisa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 2086,
                IlceAdi  = "Şehzadeler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 45,
                IlceKodu = 2087,
                IlceAdi  = "Yunusemre",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1107,
                IlceAdi  = "Afşin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1136,
                IlceAdi  = "Andırın",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1299,
                IlceAdi  = "Elbistan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1353,
                IlceAdi  = "Göksun",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1515,
                IlceAdi  = "Kahramanmaraş Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1570,
                IlceAdi  = "Pazarcık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1694,
                IlceAdi  = "Türkoğlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1785,
                IlceAdi  = "Çağlayancerit",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1919,
                IlceAdi  = "Ekinözü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 1975,
                IlceAdi  = "Nurhak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 2084,
                IlceAdi  = "Dulkadiroğlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 46,
                IlceKodu = 2085,
                IlceAdi  = "Onikişubat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1273,
                IlceAdi  = "Derik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1474,
                IlceAdi  = "Kızıltepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1516,
                IlceAdi  = "Mardin Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1519,
                IlceAdi  = "Mazıdağı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1526,
                IlceAdi  = "Midyat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1547,
                IlceAdi  = "Nusaybin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1564,
                IlceAdi  = "Ömerli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1609,
                IlceAdi  = "Savur",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 1787,
                IlceAdi  = "Dargeçit",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 2002,
                IlceAdi  = "Yeşilli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 47,
                IlceKodu = 2088,
                IlceAdi  = "Artuklu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1197,
                IlceAdi  = "Bodrum",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1266,
                IlceAdi  = "Datça",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1331,
                IlceAdi  = "Fethiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1488,
                IlceAdi  = "Köyceğiz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1517,
                IlceAdi  = "Marmaris",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1528,
                IlceAdi  = "Milas",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1532,
                IlceAdi  = "Muğla Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1695,
                IlceAdi  = "Ula",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1719,
                IlceAdi  = "Yatağan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1742,
                IlceAdi  = "Dalaman",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1831,
                IlceAdi  = "Ortaca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 1958,
                IlceAdi  = "Kavaklıdere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 2089,
                IlceAdi  = "Menteşe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 48,
                IlceKodu = 2090,
                IlceAdi  = "Seydikemer",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 49,
                IlceKodu = 1213,
                IlceAdi  = "Bulanık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 49,
                IlceKodu = 1510,
                IlceAdi  = "Malazgirt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 49,
                IlceKodu = 1534,
                IlceAdi  = "Muş Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 49,
                IlceKodu = 1711,
                IlceAdi  = "Varto",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 49,
                IlceKodu = 1801,
                IlceAdi  = "Hasköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 49,
                IlceKodu = 1964,
                IlceAdi  = "Korkut",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1155,
                IlceAdi  = "Avanos",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1274,
                IlceAdi  = "Derinkuyu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1367,
                IlceAdi  = "Gülşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1374,
                IlceAdi  = "Hacıbektaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1485,
                IlceAdi  = "Kozaklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1543,
                IlceAdi  = "Nevşehir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1707,
                IlceAdi  = "Ürgüp",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 50,
                IlceKodu = 1749,
                IlceAdi  = "Acıgöl",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 51,
                IlceKodu = 1201,
                IlceAdi  = "Bor",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 51,
                IlceKodu = 1225,
                IlceAdi  = "Çamardı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 51,
                IlceKodu = 1544,
                IlceAdi  = "Niğde Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 51,
                IlceKodu = 1700,
                IlceAdi  = "Ulukışla",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 51,
                IlceKodu = 1876,
                IlceAdi  = "Altunhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 51,
                IlceKodu = 1904,
                IlceAdi  = "Çiftlik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1119,
                IlceAdi  = "Akkuş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1158,
                IlceAdi  = "Aybastı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1328,
                IlceAdi  = "Fatsa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1358,
                IlceAdi  = "Gölköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1482,
                IlceAdi  = "Korgan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1493,
                IlceAdi  = "Kumru",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1525,
                IlceAdi  = "Mesudiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1552,
                IlceAdi  = "Ordu Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1573,
                IlceAdi  = "Perşembe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1696,
                IlceAdi  = "Ulubey / Ordu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1706,
                IlceAdi  = "Ünye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1795,
                IlceAdi  = "Gülyalı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1797,
                IlceAdi  = "Gürgentepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1891,
                IlceAdi  = "Çamaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1897,
                IlceAdi  = "Çatalpınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1900,
                IlceAdi  = "Çaybaşı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1947,
                IlceAdi  = "İkizce",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1950,
                IlceAdi  = "Kabadüz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 1951,
                IlceAdi  = "Kabataş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 52,
                IlceKodu = 2103,
                IlceAdi  = "Altınordu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1146,
                IlceAdi  = "Ardeşen",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1228,
                IlceAdi  = "Çamlıhemşin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1241,
                IlceAdi  = "Çayeli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1332,
                IlceAdi  = "Fındıklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1405,
                IlceAdi  = "İkizdere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1428,
                IlceAdi  = "Kalkandere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1569,
                IlceAdi  = "Pazar / Rize",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1586,
                IlceAdi  = "Rize Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1796,
                IlceAdi  = "Güneysu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1908,
                IlceAdi  = "Derepazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1943,
                IlceAdi  = "Hemşin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 53,
                IlceKodu = 1949,
                IlceAdi  = "İyidere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1123,
                IlceAdi  = "Akyazı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1351,
                IlceAdi  = "Geyve",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1391,
                IlceAdi  = "Hendek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1442,
                IlceAdi  = "Karasu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1453,
                IlceAdi  = "Kaynarca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1589,
                IlceAdi  = "Sakarya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1595,
                IlceAdi  = "Sapanca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1818,
                IlceAdi  = "Kocaali",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1833,
                IlceAdi  = "Pamukova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1847,
                IlceAdi  = "Taraklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1925,
                IlceAdi  = "Ferizli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1955,
                IlceAdi  = "Karapürçek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 1986,
                IlceAdi  = "Söğütlü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 2068,
                IlceAdi  = "Adapazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 2069,
                IlceAdi  = "Arifiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 2070,
                IlceAdi  = "Erenler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 54,
                IlceKodu = 2071,
                IlceAdi  = "Serdivan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1125,
                IlceAdi  = "Alaçam",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1164,
                IlceAdi  = "Bafra",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1234,
                IlceAdi  = "Çarşamba",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1386,
                IlceAdi  = "Havza",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1452,
                IlceAdi  = "Kavak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1501,
                IlceAdi  = "Ladik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1593,
                IlceAdi  = "Samsun Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1676,
                IlceAdi  = "Terme",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1712,
                IlceAdi  = "Vezirköprü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1763,
                IlceAdi  = "Asarcık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1830,
                IlceAdi  = "19 Mayıs",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1838,
                IlceAdi  = "Salıpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1849,
                IlceAdi  = "Tekkeköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1879,
                IlceAdi  = "Ayvacık / Samsun",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 1993,
                IlceAdi  = "Yakakent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 2072,
                IlceAdi  = "Atakum",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 2073,
                IlceAdi  = "Canik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 55,
                IlceKodu = 2074,
                IlceAdi  = "İlkadım",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 56,
                IlceKodu = 1179,
                IlceAdi  = "Baykan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 56,
                IlceKodu = 1317,
                IlceAdi  = "Eruh",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 56,
                IlceKodu = 1495,
                IlceAdi  = "Kurtalan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 56,
                IlceKodu = 1575,
                IlceAdi  = "Pervari",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 56,
                IlceKodu = 1620,
                IlceAdi  = "Siirt Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 56,
                IlceKodu = 1662,
                IlceAdi  = "Şirvan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 56,
                IlceKodu = 1878,
                IlceAdi  = "Tillo",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1156,
                IlceAdi  = "Ayancık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1204,
                IlceAdi  = "Boyabat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1290,
                IlceAdi  = "Durağan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1314,
                IlceAdi  = "Erfelek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1349,
                IlceAdi  = "Gerze",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1627,
                IlceAdi  = "Sinop Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1693,
                IlceAdi  = "Türkeli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1910,
                IlceAdi  = "Dikmen",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 57,
                IlceKodu = 1981,
                IlceAdi  = "Saraydüzü",
                DurumId  = 1
                },                                
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1282,
                IlceAdi  = "Divriği",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1342,
                IlceAdi  = "Gemerek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1373,
                IlceAdi  = "Gürün",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1376,
                IlceAdi  = "Hafik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1407,
                IlceAdi  = "İmranlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1431,
                IlceAdi  = "Kangal",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1484,
                IlceAdi  = "Koyulhisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1628,
                IlceAdi  = "Sivas Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1646,
                IlceAdi  = "Suşehri",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1650,
                IlceAdi  = "Şarkışla",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1731,
                IlceAdi  = "Yıldızeli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1738,
                IlceAdi  = "Zara",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1870,
                IlceAdi  = "Akıncılar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1875,
                IlceAdi  = "Altınyayla / Sivas",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1913,
                IlceAdi  = "Doğanşar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1927,
                IlceAdi  = "Gölova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 58,
                IlceKodu = 1991,
                IlceAdi  = "Ulaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1250,
                IlceAdi  = "Çerkezköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1258,
                IlceAdi  = "Çorlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1388,
                IlceAdi  = "Hayrabolu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1511,
                IlceAdi  = "Malkara",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1538,
                IlceAdi  = "Muratlı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1596,
                IlceAdi  = "Saray / Tekirdağ",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1652,
                IlceAdi  = "Şarköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1673,
                IlceAdi  = "Tekirdağ Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 1825,
                IlceAdi  = "Marmaraereğlisi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 2094,
                IlceAdi  = "Ergene",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 2095,
                IlceAdi  = "Kapaklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 59,
                IlceKodu = 2096,
                IlceAdi  = "Süleymanpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1129,
                IlceAdi  = "Almus",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1151,
                IlceAdi  = "Artova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1308,
                IlceAdi  = "Erbaa",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1545,
                IlceAdi  = "Niksar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1584,
                IlceAdi  = "Reşadiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1679,
                IlceAdi  = "Tokat Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1690,
                IlceAdi  = "Turhal",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1740,
                IlceAdi  = "Zile",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1834,
                IlceAdi  = "Pazar / Tokat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1858,
                IlceAdi  = "Yeşilyurt / Tokat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1883,
                IlceAdi  = "Başçiftlik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 60,
                IlceKodu = 1987,
                IlceAdi  = "Sulusaray",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1113,
                IlceAdi  = "Akçaabat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1141,
                IlceAdi  = "Araklı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1150,
                IlceAdi  = "Arsin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1244,
                IlceAdi  = "Çaykara",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1507,
                IlceAdi  = "Maçka",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1548,
                IlceAdi  = "Of",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1647,
                IlceAdi  = "Sürmene",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1681,
                IlceAdi  = "Tonya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1686,
                IlceAdi  = "Trabzon Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1709,
                IlceAdi  = "Vakfıkebir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1732,
                IlceAdi  = "Yomra",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1775,
                IlceAdi  = "Beşikdüzü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1842,
                IlceAdi  = "Şalpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1896,
                IlceAdi  = "Çarşıbaşı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1909,
                IlceAdi  = "Dernekpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1917,
                IlceAdi  = "Düzköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1942,
                IlceAdi  = "Hayrat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 1966,
                IlceAdi  = "Köprübaşı / Trabzon",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 61,
                IlceKodu = 2097,
                IlceAdi  = "Ortahisar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1247,
                IlceAdi  = "Çemişgezek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1397,
                IlceAdi  = "Hozat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1518,
                IlceAdi  = "Mazgirt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1541,
                IlceAdi  = "Nazımiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1562,
                IlceAdi  = "Ovacık / Tunceli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1574,
                IlceAdi  = "Pertek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1581,
                IlceAdi  = "Pülümür",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 62,
                IlceKodu = 1688,
                IlceAdi  = "Tunceli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1115,
                IlceAdi  = "Akçakale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1194,
                IlceAdi  = "Birecik",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1209,
                IlceAdi  = "Bozova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1220,
                IlceAdi  = "Ceylanpınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1378,
                IlceAdi  = "Halfeti",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1393,
                IlceAdi  = "Hilvan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1630,
                IlceAdi  = "Siverek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1643,
                IlceAdi  = "Suruç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1702,
                IlceAdi  = "Şanlıurfa Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1713,
                IlceAdi  = "Viranşehir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 1800,
                IlceAdi  = "Harran",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 2091,
                IlceAdi  = "Eyyübiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 2092,
                IlceAdi  = "Haliliye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 63,
                IlceKodu = 2093,
                IlceAdi  = "Karaköprü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 64,
                IlceKodu = 1170,
                IlceAdi  = "Banaz",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 64,
                IlceKodu = 1323,
                IlceAdi  = "Eşme",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 64,
                IlceKodu = 1436,
                IlceAdi  = "Karahallı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 64,
                IlceKodu = 1629,
                IlceAdi  = "Sivaslı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 64,
                IlceKodu = 1697,
                IlceAdi  = "Ulubey / Uşak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 64,
                IlceKodu = 1704,
                IlceAdi  = "Uşak Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1175,
                IlceAdi  = "Başkale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1236,
                IlceAdi  = "Çatak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1309,
                IlceAdi  = "Erciş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1350,
                IlceAdi  = "Gevaş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1372,
                IlceAdi  = "Gürpınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1533,
                IlceAdi  = "Muradiye",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1565,
                IlceAdi  = "Ceylanpınar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1710,
                IlceAdi  = "Van Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1770,
                IlceAdi  = "Bahçesaray",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1786,
                IlceAdi  = "Çaldıran",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1918,
                IlceAdi  = "Edremit / Van",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 1980,
                IlceAdi  = "Saray / Van",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 2098,
                IlceAdi  = "İpekyolu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 65,
                IlceKodu = 2099,
                IlceAdi  = "Tuşba",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1117,
                IlceAdi  = "Akdağmadeni",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1198,
                IlceAdi  = "Boğazlıyan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1242,
                IlceAdi  = "Çayıralan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1245,
                IlceAdi  = "Çekerek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1602,
                IlceAdi  = "Sarıkaya",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1635,
                IlceAdi  = "Sorgun",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1655,
                IlceAdi  = "Şefaatli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1726,
                IlceAdi  = "Yerköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1733,
                IlceAdi  = "Yozgat Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1877,
                IlceAdi  = "Aydıncık / Yozgat",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1895,
                IlceAdi  = "Çandır",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1952,
                IlceAdi  = "Kadışehri",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1982,
                IlceAdi  = "Saraykent",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 66,
                IlceKodu = 1998,
                IlceAdi  = "Yenifakılı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 1240,
                IlceAdi  = "Çaycuma",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 1276,
                IlceAdi  = "Devrek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 1313,
                IlceAdi  = "Ereğli / Zonguldak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 1741,
                IlceAdi  = "Zonguldak Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 1758,
                IlceAdi  = "Alaplı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 1926,
                IlceAdi  = "Gökçebey",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 2100,
                IlceAdi  = "Kilimli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 67,
                IlceKodu = 2101,
                IlceAdi  = "Kozlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 68,
                IlceKodu = 1120,
                IlceAdi  = "Aksaray Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 68,
                IlceKodu = 1557,
                IlceAdi  = "Ortaköy / Aksaray",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 68,
                IlceKodu = 1860,
                IlceAdi  = "Ağaçören",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 68,
                IlceKodu = 1861,
                IlceAdi  = "Güzelyurt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 68,
                IlceKodu = 1866,
                IlceAdi  = "Sarıyahşi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 68,
                IlceKodu = 1921,
                IlceAdi  = "Eskil",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 68,
                IlceKodu = 1932,
                IlceAdi  = "Gülağaç",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 69,
                IlceKodu = 1176,
                IlceAdi  = "Bayburt Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 69,
                IlceKodu = 1767,
                IlceAdi  = "Aydıntepe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 69,
                IlceKodu = 1788,
                IlceAdi  = "Demirözü",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 70,
                IlceKodu = 1316,
                IlceAdi  = "Ermenek",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 70,
                IlceKodu = 1439,
                IlceAdi  = "Karaman Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 70,
                IlceKodu = 1768,
                IlceAdi  = "Ayrancı",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 70,
                IlceKodu = 1862,
                IlceAdi  = "Kazımkarabekir",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 70,
                IlceKodu = 1884,
                IlceAdi  = "Başyayla",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 70,
                IlceKodu = 1983,
                IlceAdi  = "Sarıveliler",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1268,
                IlceAdi  = "Delice",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1463,
                IlceAdi  = "Keskin",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1469,
                IlceAdi  = "Kırıkkale Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1638,
                IlceAdi  = "Sulakyurt",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1880,
                IlceAdi  = "Bahşili",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1882,
                IlceAdi  = "Balışeyh",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1901,
                IlceAdi  = "Çelebi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1954,
                IlceAdi  = "Karakeçili",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 71,
                IlceKodu = 1992,
                IlceAdi  = "Yahşihan",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 72,
                IlceKodu = 1174,
                IlceAdi  = "Batman Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 72,
                IlceKodu = 1184,
                IlceAdi  = "Beşiri",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 72,
                IlceKodu = 1345,
                IlceAdi  = "Gercüş",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 72,
                IlceKodu = 1487,
                IlceAdi  = "Kozluk",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 72,
                IlceKodu = 1607,
                IlceAdi  = "Sason",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 72,
                IlceKodu = 1941,
                IlceAdi  = "Hasankeyf",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 73,
                IlceKodu = 1189,
                IlceAdi  = "Beytüşşebap",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 73,
                IlceKodu = 1223,
                IlceAdi  = "Cizre",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 73,
                IlceKodu = 1403,
                IlceAdi  = "İdil",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 73,
                IlceKodu = 1623,
                IlceAdi  = "Silopi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 73,
                IlceKodu = 1661,
                IlceAdi  = "Şırnak Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 73,
                IlceKodu = 1698,
                IlceAdi  = "Uludere",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 73,
                IlceKodu = 1931,
                IlceAdi  = "Güçlükonak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 74,
                IlceKodu = 1172,
                IlceAdi  = "Bartın Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 74,
                IlceKodu = 1496,
                IlceAdi  = "Kurucaşile",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 74,
                IlceKodu = 1701,
                IlceAdi  = "Ulus",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 74,
                IlceKodu = 1761,
                IlceAdi  = "Amasra",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 75,
                IlceKodu = 1144,
                IlceAdi  = "Ardahan Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 75,
                IlceKodu = 1252,
                IlceAdi  = "Çıldır",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 75,
                IlceKodu = 1356,
                IlceAdi  = "Göle",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 75,
                IlceKodu = 1380,
                IlceAdi  = "Hanak",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 75,
                IlceKodu = 1579,
                IlceAdi  = "Posof",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 75,
                IlceKodu = 2008,
                IlceAdi  = "Damal",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 76,
                IlceKodu = 1142,
                IlceAdi  = "Aralık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 76,
                IlceKodu = 1398,
                IlceAdi  = "Iğdır Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 76,
                IlceKodu = 1692,
                IlceAdi  = "Tuzluca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 76,
                IlceKodu = 2011,
                IlceAdi  = "Karakoyunlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 77,
                IlceKodu = 1716,
                IlceAdi  = "Yalova Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 77,
                IlceKodu = 2019,
                IlceAdi  = "Altınova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 77,
                IlceKodu = 2020,
                IlceAdi  = "Armutlu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 77,
                IlceKodu = 2021,
                IlceAdi  = "Çınarcık",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 77,
                IlceKodu = 2022,
                IlceAdi  = "Çiftlikköy",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 77,
                IlceKodu = 2026,
                IlceAdi  = "Termal",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 78,
                IlceKodu = 1296,
                IlceAdi  = "Eflani",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 78,
                IlceKodu = 1321,
                IlceAdi  = "Eskipazar",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 78,
                IlceKodu = 1433,
                IlceAdi  = "Karabük Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 78,
                IlceKodu = 1561,
                IlceAdi  = "Ovacık / Karabük",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 78,
                IlceKodu = 1587,
                IlceAdi  = "Safranbolu",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 78,
                IlceKodu = 1856,
                IlceAdi  = "Yenice / Karabük",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 79,
                IlceKodu = 1476,
                IlceAdi  = "Kilis Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 79,
                IlceKodu = 2023,
                IlceAdi  = "Elbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 79,
                IlceKodu = 2024,
                IlceAdi  = "Musabeyli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 79,
                IlceKodu = 2025,
                IlceAdi  = "Polateli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 80,
                IlceKodu = 1165,
                IlceAdi  = "Bahçe",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 80,
                IlceKodu = 1423,
                IlceAdi  = "Kadirli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 80,
                IlceKodu = 1560,
                IlceAdi  = "Osmaniye Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 80,
                IlceKodu = 1743,
                IlceAdi  = "Düziçi",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 80,
                IlceKodu = 2027,
                IlceAdi  = "Hasanbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 80,
                IlceKodu = 2028,
                IlceAdi  = "Sumbas",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 80,
                IlceKodu = 2029,
                IlceAdi  = "Toprakkale",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 1116,
                IlceAdi  = "Akçakoca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 1292,
                IlceAdi  = "Düzce Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 1730,
                IlceAdi  = "Yığılca",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 1784,
                IlceAdi  = "Cumayeri",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 1794,
                IlceAdi  = "Gölyaka",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 1905,
                IlceAdi  = "Çilimli",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 2017,
                IlceAdi  = "Gümüşova",
                DurumId  = 1
                },
                new Ilce
                {
                SehirId  = 81,
                IlceKodu = 2031,
                IlceAdi  = "Kaynaşlı",
                DurumId  = 1
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

            #region // Kategori
            context.Kategoriler.AddRange(new List<Kategori>{
                #region // DokumanTipi
                new Kategori
                {
                    Adi         = "DokumanTipi",
                    DurumId             = 1,
                    Degerler            = new List<Deger>
                    {
                        new Deger
                        {
                            Adi    = "Tanımsız",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Adapte Teklifi",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Dc",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Kitap",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Konu Teklifi",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Kriter",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Kriter İş Programında",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Kriter Tasarısı",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Kriter Teklifi",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "ST",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "TD*GD",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "TR*TS",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "UTO Rehber Doküman",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "WI (İş Programında)",
                            SiraNo      = 0,
                            DurumId     = 1
                        },                        
                    }
                },
                #endregion

                #region // HazirlikGrubu
                new Kategori
                {
                    Adi         = "HazirlikGrubu",
                    DurumId             = 1,
                    Degerler            = new List<Deger>
                    {
                        new Deger
                        {
                            Adi         = "Tanımsız",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                        Adi             = "Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Alıcı Ortam Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Ambalaj Özel Daimi Komitesi ÖDK",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Atıklar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Aydınlatma ve İç Tesisat Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Aydınlatma ve Kablo Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Basınçlı Kaplar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Bilgi Teknolojileri ve İletişim İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Bilişim Teknolojileri Test Belgelendirme Sektörü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Cam Seramik ve Refrakter Malzeme Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Çevre İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Çevre Sağlığı Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Çevre Sağlığı ve Atıklar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Demiryolu Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Deprem Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Doğal Gaz Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Doküman Tercüme Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Ekoloji Tarım Ürünleri Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Elektrik İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Elektronik İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Elektroteknik Güvenlik Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Elektroteknik Güvenlik ve Aydınlatma  Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Elektroteknik Sektörü Müdürlüğü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "EMU ve Radyo-TV Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Endüstriyel Yağlar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Gıda Sektörü Müdürlüğü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Helal Gıda Sektör Müdürlüğü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Hizmet Standardları İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Hizmet Yeri Belgelendirme Sektör Müdürlüğü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Isı Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "İnşaat İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "İnşaat Makinaları Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Kablo Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Kapatılan Hazırlık Grupları",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Kapatılan ve Birleştirilen Özel Daimi Komiteler",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Kırtasiye Malzemeleri ve Formlar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Kimya İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Kimya Sektör Müdürlüğü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Laboratuvarlar Hazırlık Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Maden İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Makina İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Makine Sektörü Müdürlüğü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Mamul Gıdalar İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Meslek Standardları İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Metalurji İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Milletlerarası Standardlar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Milli Savunma Sanayii İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Mühendislik Hizmetleri İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "NBC ve KİS Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Nükleer Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Optik ve Optometri Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Orman ve Orman Ürünleri İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Otomotiv Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Otomotiv Sektör Müdürlüğü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Otomotiv ve İnşaat Makinaları Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Özel Standardlar Hazırlık Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Petrokimya İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Petrol İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Plâstik Borular Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Radyo-TV Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Rezerv konular grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Sağlık İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Standard Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Şehiriçi Yollar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Tahribatsız Muayene Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Tarım Alet ve Makinaları Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Teknik Kurul",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Tekstil İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Telekomünikasyon Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Tesisat ve Basınçlı Kaplar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Tıbbi Cihazlar Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK1: Bilişim Teknolojileri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK10: Yapı Malzemeleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK11:İzolasyon, Kaplama ve Yardımcı Yapı Malzemeleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK12: Yapı Güvenliği ve Akustik Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK13: Yapı Güvenliği Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK14: Kimya Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK15: Petrokimya Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK16: Petrol ve Petrol Ürünleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK17: Maden Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK18: İmalat Makineleri ve Takımları Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK19: Otomotiv Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK2: Çevre Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK20: Makine Güvenliği Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK21: Tesisat, Isıtma, Soğutma ve Havalandırma Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK22: Tesisat ve Basınçlı Kaplar Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK23: Metalürji Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK24: Gıda Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK25: Ziraat Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK26: Kişisel Koruyucu ve Oyun Alanı Donanım Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK27: Yangın Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK28: Ambalaj Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK29: Yönetim Sistemleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK3: Elektrik Elektroteknik ve Güvenlik Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK30: Enerji ve Enerji Sistemleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK31: Orman ve Orman Ürünleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK32: Sağlık Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK33: Medikal Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK34: Tekstil Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK35: Elektrik ve Elektronik Yetkili Servisleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK36: Milli Savunma Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK37: Helal Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK38: Sosyal Hizmetler Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK39: Mekanik ve Elektromekanik Yetkili Servisleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK4: Elektrik Üretim,İletim Ve Dağıtım Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK40: Demiryolu Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK41: Uzay ve Havacılık Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK42: Nükleer Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK43: Tercüme-1 Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK44: Tercüme-2 Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK45: İş Sağlığı ve Güvenliği Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK46: Süs Bitkileri",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK5: Aydınlatma ve Bina İçi Tesisleri İle Yardımcı Donanımları Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK6: İletkenler, Kablolar Ve Yalıtım Malzemeleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK7: Yüksek Gerilim Teknikleri ve Yıldırımdan Korunma Sistemleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK8: Elektronik Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TK9: Sanayi Hizmetleri Teknik Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TSEK Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "TSE-Yapılarda Tahribatsız Muayene Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Ulusal Teknik Onay Esas Belirleme Komisyonu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Yangın Özel Daimi Komitesi",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Yapı Malzemeleri ÖDK",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Yapı malzemeleri sektörü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Yetkili Servis Standardları İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Yönetim Sistemleri Geliştirme Sektörü",
                        SiraNo          = 0,
                        DurumId         = 1
                        },
                        new Deger
                        {
                        Adi             = "Ziraat İhtisas Grubu",
                        SiraNo          = 0,
                        DurumId         = 1
                        }

                    }
                },
                #endregion

                #region // YururlukDurumu
                new Kategori
                {
                    Adi         = "YururlukDurumu",
                    DurumId             = 1,
                    Degerler            = new List<Deger>
                    {
                        new Deger
                        {
                            Adi    = "Tanımsız",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "A (Tadil Görmüş Standard/Amended standard)",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "H (İptal Edilmiş Standard/Withdrawn standard)",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "N (Yeni Standard/New standard)",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "U (Yürürlükteki Standard/Standard)",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "W (Yeni İptal Edilen Standard/Withdrawn standard)",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "A veya N veya U",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "H veya W",
                            SiraNo      = 0,
                            DurumId     = 1
                        }
                    }
                },
                #endregion

                #region // StandartTur
                new Kategori
                {
                    Adi         = "StandartTur",
                    DurumId             = 1,
                    Degerler            = new List<Deger>
                    {
                        new Deger
                        {
                            Adi    = "Tanımsız",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Kural",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Metot",
                            SiraNo      = 0,
                            DurumId     = 1
                        }                        
                    }
                },
                #endregion

                #region // TelefonTipi
                new Kategori
                {                    
                    Adi         = "TelefonTipi",
                    DurumId             = 1,
                    Degerler            = new List<Deger>
                    {
                        new Deger
                        {
                            Adi    = "Cep Telefonu",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Ev Telefonu",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "İş Telefonu",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "Fax",
                            SiraNo      = 0,
                            DurumId     = 1
                        }
                    }                    
                },
                #endregion

                #region // AdresTipi
                new Kategori
                {
                    Adi         = "AdresTipi",
                    DurumId             = 1,
                    Degerler            = new List<Deger>
                    {
                        new Deger
                        {
                            Adi         = "Ev Adresi",
                            SiraNo      = 0,
                            DurumId     = 1
                        },
                        new Deger
                        {
                            Adi    = "İş Adresi",
                            SiraNo      = 0,
                            DurumId     = 1
                        }
                    }
                }
                #endregion
            });
            #endregion            

            #region // Standart
            context.Standartlar.AddRange(new List<Standart> {
                new Standart
                {                    
                    TsNo                    = "TS-13298",
                    KabulTarihi             = new DateTime(2015, 10, 23),
                    HazirlikGrubuId         = 6,
                    DokumanTipiId           = 9,
                    YururlukDurumuId        = 5,
                    BaslikTr                  = "Elektronik Belge ve Arşiv Yönetim Sistemi",
                    BaslikEn              = "Electronic Records and Archives Management System",
                    StandartTurId           = 3,
                    KapsamTr                  = "Bu standard, kurumlarda üretilen ve/veya üretilmesi muhtemel elektronik dokümanların belge niteliğinin korunabilmesi için gerekli standardlar ile elektronik belgelerin arşivlenmesi ve yönetimine yönelik konuları kapsar.",
                    KapsamEn               = "This standard, produced in the institution and / or production of electronic documents, electronic documents possible with the necessary standards to preserve the quality archiving and document covers issues related to management.",
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

            context.SaveChanges();

            #region // Kisi
            context.Kisiler.AddRange(new List<Kisi> {
                new Kisi
                {                                        
                    TcKimlikNo                  = 28661334272,
                    Adi                          = "Halil İbrahim",
                    Soyadi                       = "Poyraz",                    
                    DurumId                     = 1,
                    Epostalar                   = new List<Eposta>
                    {
                        new Eposta
                        {                                                                                 
                            EpostaAdresi        = "h.ibrahimpoyraz@gmail.com",
                            VarsayilanEposta    = true,
                            DurumId             = 1
                        },
                        new Eposta
                        {                                                       
                            EpostaAdresi        = "hll_pyrz@hotmail.com",
                            VarsayilanEposta    = false,
                            DurumId             = 1
                        }
                    },
                    KisiTelefonlar              = new List<Telefon>
                    {
                        new Telefon
                        {                            
                            TelefonTipiId       = 154,
                            TelefonNo           = "05345950053",
                            VarsayilanTelefon   = true,
                            DurumId             = 1
                        }
                    },                    
                    KisiAdresler                = new List<Adres>
                    {
                        new Adres
                        {                                                     
                            AdresTipiId         = 158,
                            AdresSatiri         = "Çubuklu Mahallesi Nazım Tur Caddesi Mola Çıkmazı Sokak No:4/1",
                            IlceId              = 432,
                            SehirId             = 34,
                            UlkeId              = 1,
                            VarsayilanAdres     = true,
                            DurumId             = 1
                        }
                    },                    
                    KisiVergiBilgileri = new List<VergiBilgi>
                    {
                        new VergiBilgi
                        {
                        VergiDairesi = "Üsküdar",
                        VergiNo = "9876543210",
                        DurumId = 1
                        }
                    }
                },
                new Kisi
                {                          
                    TcKimlikNo                  = 44080828284,
                    Adi                         = "Ali",
                    Soyadi                      = "Atabey",                    
                    DurumId                     = 1,
                    Epostalar                   = new List<Eposta>
                    {
                        new Eposta
                        {                            
                            EpostaAdresi        = "ali@trendax.com.tr",
                            VarsayilanEposta    = true,
                            DurumId             = 1
                        }
                    },
                    KisiTelefonlar              = new List<Telefon>
                    {
                        new Telefon
                        {
                            TelefonTipiId       = 154,
                            TelefonNo           = "05332713638",
                            VarsayilanTelefon   = true,
                            DurumId             = 1
                        },
                        new Telefon
                        {
                            TelefonTipiId       = 155,
                            TelefonNo           = "02122605262",
                            DahiliNo            = "122",
                            VarsayilanTelefon   = false,
                            DurumId             = 1
                        },
                        new Telefon
                        {
                            TelefonTipiId       = 156,
                            TelefonNo           = "4447084",
                            VarsayilanTelefon   = false,
                            DurumId             = 1
                        },
                        new Telefon
                        {
                            TelefonTipiId       = 157,
                            TelefonNo           = "02124496227",
                            VarsayilanTelefon   = false,
                            DurumId             = 1
                        },
                    },
                    KisiAdresler                = new List<Adres>
                    {
                        new Adres
                        {
                            AdresTipiId         = 158,
                            AdresSatiri         = "Asariye Caddesi Şeferliveli Sokak No:19 Kat:2 Daire:2",
                            IlceId              = 431,
                            SehirId             = 34,
                            UlkeId              = 1,
                            VarsayilanAdres     = true,
                            DurumId             = 1

                        }
                    },                    
                    KisiVergiBilgileri = new List<VergiBilgi>
                    {
                        new VergiBilgi
                        {
                        VergiDairesi = "Beyoğlu",
                        VergiNo = "9879876541",
                        DurumId = 1
                        }
                    }

                },
            });
            #endregion

            #region // Firma
            context.Firmalar.AddRange(new List<Firma>
            {
                new Firma
                {
                    TicaretUnvani = "Beyaz Yazılım Ltd. Şti.",
                    DurumId = 1,
                    FirmaTelefonlar = new List<Telefon>
                    {
                        new Telefon
                        {
                            TelefonTipiId = 156,
                            TelefonNo = "02164257262",
                            VarsayilanTelefon = true,
                            DurumId = 1
                        },
                        new Telefon
                        {
                            TelefonTipiId = 156,
                            TelefonNo = "021632151651",
                            VarsayilanTelefon = true,
                            DurumId = 1
                        },
                    },
                    FirmaVergiBilgileri = new List<VergiBilgi>
                    {
                        new VergiBilgi
                        {
                            VergiDairesi = "Beykoz",
                            VergiNo = "0123456789",
                            DurumId = 1
                        }
                    },
                    FirmaEpostalar = new List<Eposta>
                    {
                        new Eposta
                        {
                            EpostaAdresi = "yazilim@beyazyazilim.com",
                            VarsayilanEposta = true,
                            DurumId = 1
                        },
                        new Eposta
                        {
                            EpostaAdresi = "destek@beyazyazilim.com",
                            VarsayilanEposta = false,
                            DurumId = 1
                        }
                    },

                    FirmaAdresleri = new List<Adres>
                    {
                        new Adres
                        {
                            AdresTipiId         = 159,
                            AdresSatiri         = "Fetih Mahallesi Tahralı Sokak Esin Sitesi B Blok 10/5",
                            IlceId              = 432,
                            SehirId             = 34,
                            UlkeId              = 1,
                            VarsayilanAdres     = true,
                            DurumId             = 1
                        },
                        new Adres
                        {
                            AdresTipiId         = 159,
                            AdresSatiri         = "Gebze Teknopark Beyaz Yazılım",
                            IlceId              = 432,
                            SehirId             = 34,
                            UlkeId              = 1,
                            VarsayilanAdres     = false,
                            DurumId             = 1
                        }
                    }
                },
                new Firma
                {
                    TicaretUnvani = "Yeditepe Turizm Gıda Reklam Yayın Bilgisayar Hiz. San. Ve Tic. Ltd. Şti.",
                    DurumId = 1,
                    FirmaTelefonlar = new List<Telefon>
                    {
                        new Telefon
                        {
                            TelefonTipiId = 156,
                            TelefonNo = "4447084",
                            VarsayilanTelefon = true,
                            DurumId = 1
                        }
                    },
                    FirmaVergiBilgileri = new List<VergiBilgi>
                    {
                        new VergiBilgi
                        {
                            VergiDairesi = "Ümraniye",
                            VergiNo = "9440131245",
                            DurumId = 1
                        }
                    },
                    FirmaEpostalar = new List<Eposta>
                    {
                        new Eposta
                        {
                            EpostaAdresi = "info@yeditepeturizm.com.tr",
                            VarsayilanEposta = true,
                            DurumId = 1
                        }
                    },
                    FirmaAdresleri = new List<Adres>
                    {
                        new Adres
                        {
                            AdresTipiId         = 159,
                            AdresSatiri         = "İnkılap Mahallesi Küçüksu Caddesi No:101 K:5 D:10",
                            IlceId              = 431,
                            SehirId             = 34,
                            UlkeId              = 1,
                            VarsayilanAdres     = true,
                            DurumId             = 1
                        }
                    }
                }
            });
            #endregion

            context.SaveChanges();
        }

    }

}