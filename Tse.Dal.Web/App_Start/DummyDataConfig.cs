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
           
            #region //Durum
            context.Durumlar.AddRange(new List<Durum>
            {
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

            #region //Ulke
            context.Ulkeler.AddRange(new List<Ulke>
            {
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

            #region //Sehir
            context.Sehirler.AddRange(new List<Sehir>
            {
                new Sehir
                {
                    SehirId = 1,
                    UlkeId = 1,
                    SehirAdi = "Adana",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 2,
                    UlkeId = 1,
                    SehirAdi = "Adıyaman",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 3,
                    UlkeId = 1,
                    SehirAdi = "Afyonkarahisar",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 4,
                    UlkeId = 1,
                    SehirAdi = "Ağrı",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 5,
                    UlkeId = 1,
                    SehirAdi = "Amasya",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 6,
                    UlkeId = 1,
                    SehirAdi = "Ankara",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 7,
                    UlkeId = 1,
                    SehirAdi = "Antalya",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 8,
                    UlkeId = 1,
                    SehirAdi = "Artvin",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 9,
                    UlkeId = 1,
                    SehirAdi = "Aydın",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 10,
                    UlkeId = 1,
                    SehirAdi = "Balıkesir",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 11,
                    UlkeId = 1,
                    SehirAdi = "Bilecik",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 12,
                    UlkeId = 1,
                    SehirAdi = "Bingöl",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 13,
                    UlkeId = 1,
                    SehirAdi = "Bitlis",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 14,
                    UlkeId = 1,
                    SehirAdi = "Bolu",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 15,
                    UlkeId = 1,
                    SehirAdi = "Burdur",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 16,
                    UlkeId = 1,
                    SehirAdi = "Bursa",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 17,
                    UlkeId = 1,
                    SehirAdi = "Çanakkale",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 18,
                    UlkeId = 1,
                    SehirAdi = "Çankırı",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 19,
                    UlkeId = 1,
                    SehirAdi = "Çorum",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 20,
                    UlkeId = 1,
                    SehirAdi = "Denizli",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 21,
                    UlkeId = 1,
                    SehirAdi = "Diyarbakır",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 22,
                    UlkeId = 1,
                    SehirAdi = "Edirne",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 23,
                    UlkeId = 1,
                    SehirAdi = "Elazığ",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 24,
                    UlkeId = 1,
                    SehirAdi = "Erzincan",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 25,
                    UlkeId = 1,
                    SehirAdi = "Erzurum",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 26,
                    UlkeId = 1,
                    SehirAdi = "Eskişehir",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 27,
                    UlkeId = 1,
                    SehirAdi = "Gaziantep",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 28,
                    UlkeId = 1,
                    SehirAdi = "Giresun",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 29,
                    UlkeId = 1,
                    SehirAdi = "Gümüşhane",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 30,
                    UlkeId = 1,
                    SehirAdi = "Hakkari",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 31,
                    UlkeId = 1,
                    SehirAdi = "Hatay",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 32,
                    UlkeId = 1,
                    SehirAdi = "Isparta",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 33,
                    UlkeId = 1,
                    SehirAdi = "Mersin",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 34,
                    UlkeId = 1,
                    SehirAdi = "İstanbul",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 35,
                    UlkeId = 1,
                    SehirAdi = "İzmir",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 36,
                    UlkeId = 1,
                    SehirAdi = "Kars",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 37,
                    UlkeId = 1,
                    SehirAdi = "Kastamonu",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 38,
                    UlkeId = 1,
                    SehirAdi = "Kayseri",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 39,
                    UlkeId = 1,
                    SehirAdi = "Kırklareli",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 40,
                    UlkeId = 1,
                    SehirAdi = "Kırşehir",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 41,
                    UlkeId = 1,
                    SehirAdi = "Kocaeli",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 42,
                    UlkeId = 1,
                    SehirAdi = "Konya",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 43,
                    UlkeId = 1,
                    SehirAdi = "Kütahya",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 44,
                    UlkeId = 1,
                    SehirAdi = "Malatya",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 45,
                    UlkeId = 1,
                    SehirAdi = "Manisa",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 46,
                    UlkeId = 1,
                    SehirAdi = "Kahramanmaraş",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 47,
                    UlkeId = 1,
                    SehirAdi = "Mardin",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 48,
                    UlkeId = 1,
                    SehirAdi = "Muğla",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 49,
                    UlkeId = 1,
                    SehirAdi = "Muş",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 50,
                    UlkeId = 1,
                    SehirAdi = "Nevşehir",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 51,
                    UlkeId = 1,
                    SehirAdi = "Niğde",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 52,
                    UlkeId = 1,
                    SehirAdi = "Ordu",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 53,
                    UlkeId = 1,
                    SehirAdi = "Rize",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 54,
                    UlkeId = 1,
                    SehirAdi = "Sakarya",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 55,
                    UlkeId = 1,
                    SehirAdi = "Samsun",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 56,
                    UlkeId = 1,
                    SehirAdi = "Siirt",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 57,
                    UlkeId = 1,
                    SehirAdi = "Sinop",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 58,
                    UlkeId = 1,
                    SehirAdi = "Sivas",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 59,
                    UlkeId = 1,
                    SehirAdi = "Tekirdağ",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 60,
                    UlkeId = 1,
                    SehirAdi = "Tokat",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 61,
                    UlkeId = 1,
                    SehirAdi = "Trabzon",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 62,
                    UlkeId = 1,
                    SehirAdi = "Tunceli",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 63,
                    UlkeId = 1,
                    SehirAdi = "Şanlıurfa",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 64,
                    UlkeId = 1,
                    SehirAdi = "Uşak",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 65,
                    UlkeId = 1,
                    SehirAdi = "Van",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 66,
                    UlkeId = 1,
                    SehirAdi = "Yozgat",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 67,
                    UlkeId = 1,
                    SehirAdi = "Zonguldak",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 68,
                    UlkeId = 1,
                    SehirAdi = "Aksaray",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 69,
                    UlkeId = 1,
                    SehirAdi = "Bayburt",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 70,
                    UlkeId = 1,
                    SehirAdi = "Karaman",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 71,
                    UlkeId = 1,
                    SehirAdi = "Kırıkkale",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 72,
                    UlkeId = 1,
                    SehirAdi = "Batman",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 73,
                    UlkeId = 1,
                    SehirAdi = "Şırnak",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 74,
                    UlkeId = 1,
                    SehirAdi = "Bartın",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 75,
                    UlkeId = 1,
                    SehirAdi = "Ardahan",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 76,
                    UlkeId = 1,
                    SehirAdi = "Iğdır",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 77,
                    UlkeId = 1,
                    SehirAdi = "Yalova",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 78,
                    UlkeId = 1,
                    SehirAdi = "Karabük",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 79,
                    UlkeId = 1,
                    SehirAdi = "Kilis",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 80,
                    UlkeId = 1,
                    SehirAdi = "Osmaniye",
                    DurumId = 1
                },
                new Sehir
                {
                    SehirId = 81,
                    UlkeId = 1,
                    SehirAdi = "Düzce",
                    DurumId = 1
                }
            });            
            #endregion

            #region //Ilce
            context.Ilceler.AddRange(new List<Ilce>
            {
                new Ilce
                {
                IlceId   = 1,
                SehirId  = 1,
                IlceKodu = 1104,
                IlceAdi  = "Seyhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 2,
                SehirId  = 1,
                IlceKodu = 1219,
                IlceAdi  = "Ceyhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 3,
                SehirId  = 1,
                IlceKodu = 1329,
                IlceAdi  = "Feke",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 4,
                SehirId  = 1,
                IlceKodu = 1437,
                IlceAdi  = "Karaisalı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 5,
                SehirId  = 1,
                IlceKodu = 1443,
                IlceAdi  = "Karataş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 6,
                SehirId  = 1,
                IlceKodu = 1486,
                IlceAdi  = "Kozan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 7,
                SehirId  = 1,
                IlceKodu = 1580,
                IlceAdi  = "Pozantı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 8,
                SehirId  = 1,
                IlceKodu = 1588,
                IlceAdi  = "Saimbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 9,
                SehirId  = 1,
                IlceKodu = 1687,
                IlceAdi  = "Tufanbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 10,
                SehirId  = 1,
                IlceKodu = 1734,
                IlceAdi  = "Yumurtalık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 11,
                SehirId  = 1,
                IlceKodu = 1748,
                IlceAdi  = "Yüreğir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 12,
                SehirId  = 1,
                IlceKodu = 1757,
                IlceAdi  = "Aladağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 13,
                SehirId  = 1,
                IlceKodu = 1806,
                IlceAdi  = "İmamoğlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 14,
                SehirId  = 1,
                IlceKodu = 2032,
                IlceAdi  = "Sarıçam",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 15,
                SehirId  = 1,
                IlceKodu = 2033,
                IlceAdi  = "Çukurova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 16,
                SehirId  = 2,
                IlceKodu = 1105,
                IlceAdi  = "Adıyaman Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 17,
                SehirId  = 2,
                IlceKodu = 1182,
                IlceAdi  = "Besni",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 18,
                SehirId  = 2,
                IlceKodu = 1246,
                IlceAdi  = "Çelikhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 19,
                SehirId  = 2,
                IlceKodu = 1347,
                IlceAdi  = "Gerger",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 20,
                SehirId  = 2,
                IlceKodu = 1354,
                IlceAdi  = "Gölbaşı / Adıyaman",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 21,
                SehirId  = 2,
                IlceKodu = 1425,
                IlceAdi  = "Kahta",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 22,
                SehirId  = 2,
                IlceKodu = 1592,
                IlceAdi  = "Samsat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 23,
                SehirId  = 2,
                IlceKodu = 1985,
                IlceAdi  = "Sincik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 24,
                SehirId  = 2,
                IlceKodu = 1989,
                IlceAdi  = "Tut",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 25,
                SehirId  = 3,
                IlceKodu = 1108,
                IlceAdi  = "Afyonkarahisar Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 26,
                SehirId  = 3,
                IlceKodu = 1200,
                IlceAdi  = "Bolvadin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 27,
                SehirId  = 3,
                IlceKodu = 1239,
                IlceAdi  = "Çay",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 28,
                SehirId  = 3,
                IlceKodu = 1267,
                IlceAdi  = "Dazkırı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 29,
                SehirId  = 3,
                IlceKodu = 1281,
                IlceAdi  = "Dinar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 30,
                SehirId  = 3,
                IlceKodu = 1306,
                IlceAdi  = "Emirdağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 31,
                SehirId  = 3,
                IlceKodu = 1404,
                IlceAdi  = "İhsaniye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 32,
                SehirId  = 3,
                IlceKodu = 1594,
                IlceAdi  = "Sandıklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 33,
                SehirId  = 3,
                IlceKodu = 1626,
                IlceAdi  = "Sinanpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 34,
                SehirId  = 3,
                IlceKodu = 1639,
                IlceAdi  = "Sultandağı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 35,
                SehirId  = 3,
                IlceKodu = 1664,
                IlceAdi  = "Şuhut",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 36,
                SehirId  = 3,
                IlceKodu = 1771,
                IlceAdi  = "Başmakçı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 37,
                SehirId  = 3,
                IlceKodu = 1773,
                IlceAdi  = "Bayat / Afyonkarahisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 38,
                SehirId  = 3,
                IlceKodu = 1809,
                IlceAdi  = "İscehisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 39,
                SehirId  = 3,
                IlceKodu = 1906,
                IlceAdi  = "Çobanlar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 40,
                SehirId  = 3,
                IlceKodu = 1923,
                IlceAdi  = "Evciler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 41,
                SehirId  = 3,
                IlceKodu = 1944,
                IlceAdi  = "Hocalar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 42,
                SehirId  = 3,
                IlceKodu = 1961,
                IlceAdi  = "Kızılören",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 43,
                SehirId  = 4,
                IlceKodu = 1111,
                IlceAdi  = "Ağrı Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 44,
                SehirId  = 4,
                IlceKodu = 1283,
                IlceAdi  = "Diyadin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 45,
                SehirId  = 4,
                IlceKodu = 1287,
                IlceAdi  = "Doğubayazıt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 46,
                SehirId  = 4,
                IlceKodu = 1301,
                IlceAdi  = "Eleşkirt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 47,
                SehirId  = 4,
                IlceKodu = 1379,
                IlceAdi  = "Hamur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 48,
                SehirId  = 4,
                IlceKodu = 1568,
                IlceAdi  = "Patnos",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 49,
                SehirId  = 4,
                IlceKodu = 1667,
                IlceAdi  = "Taşlıçay",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 50,
                SehirId  = 4,
                IlceKodu = 1691,
                IlceAdi  = "Tutak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 51,
                SehirId  = 5,
                IlceKodu = 1134,
                IlceAdi  = "Amasya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 52,
                SehirId  = 5,
                IlceKodu = 1363,
                IlceAdi  = "Göynücek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 53,
                SehirId  = 5,
                IlceKodu = 1368,
                IlceAdi  = "Gümüşhacıköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 54,
                SehirId  = 5,
                IlceKodu = 1524,
                IlceAdi  = "Merzifon",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 55,
                SehirId  = 5,
                IlceKodu = 1641,
                IlceAdi  = "Suluova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 56,
                SehirId  = 5,
                IlceKodu = 1668,
                IlceAdi  = "Taşova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 57,
                SehirId  = 5,
                IlceKodu = 1938,
                IlceAdi  = "Hamamözü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 58,
                SehirId  = 6,
                IlceKodu = 1130,
                IlceAdi  = "Altındağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 59,
                SehirId  = 6,
                IlceKodu = 1157,
                IlceAdi  = "Ayaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 60,
                SehirId  = 6,
                IlceKodu = 1167,
                IlceAdi  = "Bala",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 61,
                SehirId  = 6,
                IlceKodu = 1187,
                IlceAdi  = "Beypazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 62,
                SehirId  = 6,
                IlceKodu = 1227,
                IlceAdi  = "Çamlıdere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 63,
                SehirId  = 6,
                IlceKodu = 1231,
                IlceAdi  = "Çankaya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 64,
                SehirId  = 6,
                IlceKodu = 1260,
                IlceAdi  = "Çubuk",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 65,
                SehirId  = 6,
                IlceKodu = 1302,
                IlceAdi  = "Elmadağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 66,
                SehirId  = 6,
                IlceKodu = 1365,
                IlceAdi  = "Güdül",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 67,
                SehirId  = 6,
                IlceKodu = 1387,
                IlceAdi  = "Haymana",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 68,
                SehirId  = 6,
                IlceKodu = 1427,
                IlceAdi  = "Kalecik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 69,
                SehirId  = 6,
                IlceKodu = 1473,
                IlceAdi  = "Kızılcahamam",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 70,
                SehirId  = 6,
                IlceKodu = 1539,
                IlceAdi  = "Nallıhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 71,
                SehirId  = 6,
                IlceKodu = 1578,
                IlceAdi  = "Polatlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 72,
                SehirId  = 6,
                IlceKodu = 1658,
                IlceAdi  = "Şereflikoçhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 73,
                SehirId  = 6,
                IlceKodu = 1723,
                IlceAdi  = "Yenimahalle",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 74,
                SehirId  = 6,
                IlceKodu = 1744,
                IlceAdi  = "Gölbaşı / Ankara",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 75,
                SehirId  = 6,
                IlceKodu = 1745,
                IlceAdi  = "Keçiören",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 76,
                SehirId  = 6,
                IlceKodu = 1746,
                IlceAdi  = "Mamak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 77,
                SehirId  = 6,
                IlceKodu = 1747,
                IlceAdi  = "Sincan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 78,
                SehirId  = 6,
                IlceKodu = 1815,
                IlceAdi  = "Kazan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 79,
                SehirId  = 6,
                IlceKodu = 1872,
                IlceAdi  = "Akyurt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 80,
                SehirId  = 6,
                IlceKodu = 1922,
                IlceAdi  = "Etimesgut",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 81,
                SehirId  = 6,
                IlceKodu = 1924,
                IlceAdi  = "Evren",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 82,
                SehirId  = 6,
                IlceKodu = 2034,
                IlceAdi  = "Pursaklar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 83,
                SehirId  = 7,
                IlceKodu = 1121,
                IlceAdi  = "Akseki",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 84,
                SehirId  = 7,
                IlceKodu = 1126,
                IlceAdi  = "Alanya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 85,
                SehirId  = 7,
                IlceKodu = 1138,
                IlceAdi  = "Antalya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 86,
                SehirId  = 7,
                IlceKodu = 1303,
                IlceAdi  = "Elmalı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 87,
                SehirId  = 7,
                IlceKodu = 1333,
                IlceAdi  = "Finike",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 88,
                SehirId  = 7,
                IlceKodu = 1337,
                IlceAdi  = "Gazipaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 89,
                SehirId  = 7,
                IlceKodu = 1370,
                IlceAdi  = "Gündoğmuş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 90,
                SehirId  = 7,
                IlceKodu = 1451,
                IlceAdi  = "Kaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 91,
                SehirId  = 7,
                IlceKodu = 1483,
                IlceAdi  = "Korkuteli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 92,
                SehirId  = 7,
                IlceKodu = 1492,
                IlceAdi  = "Kumluca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 93,
                SehirId  = 7,
                IlceKodu = 1512,
                IlceAdi  = "Manavgat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 94,
                SehirId  = 7,
                IlceKodu = 1616,
                IlceAdi  = "Serik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 95,
                SehirId  = 7,
                IlceKodu = 1811,
                IlceAdi  = "Demre",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 96,
                SehirId  = 7,
                IlceKodu = 1946,
                IlceAdi  = "İbradı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 97,
                SehirId  = 7,
                IlceKodu = 1959,
                IlceAdi  = "Kemer / Antalya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 98,
                SehirId  = 7,
                IlceKodu = 2035,
                IlceAdi  = "Aksu / Antalya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 99,
                SehirId  = 7,
                IlceKodu = 2036,
                IlceAdi  = "Döşemealtı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 100,
                SehirId  = 7,
                IlceKodu = 2037,
                IlceAdi  = "Kepez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 101,
                SehirId  = 7,
                IlceKodu = 2038,
                IlceAdi  = "Konyaaltı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 102,
                SehirId  = 7,
                IlceKodu = 2039,
                IlceAdi  = "Muratpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 103,
                SehirId  = 8,
                IlceKodu = 1145,
                IlceAdi  = "Ardanuç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 104,
                SehirId  = 8,
                IlceKodu = 1147,
                IlceAdi  = "Arhavi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 105,
                SehirId  = 8,
                IlceKodu = 1152,
                IlceAdi  = "Artvin Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 106,
                SehirId  = 8,
                IlceKodu = 1202,
                IlceAdi  = "Borçka",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 107,
                SehirId  = 8,
                IlceKodu = 1395,
                IlceAdi  = "Hopa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 108,
                SehirId  = 8,
                IlceKodu = 1653,
                IlceAdi  = "Şavşat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 109,
                SehirId  = 8,
                IlceKodu = 1736,
                IlceAdi  = "Yusufeli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 110,
                SehirId  = 8,
                IlceKodu = 1828,
                IlceAdi  = "Murgul",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 111,
                SehirId  = 9,
                IlceKodu = 1159,
                IlceAdi  = "Aydın Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 112,
                SehirId  = 9,
                IlceKodu = 1206,
                IlceAdi  = "Bozdoğan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 113,
                SehirId  = 9,
                IlceKodu = 1256,
                IlceAdi  = "Çine",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 114,
                SehirId  = 9,
                IlceKodu = 1348,
                IlceAdi  = "Germencik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 115,
                SehirId  = 9,
                IlceKodu = 1435,
                IlceAdi  = "Karacasu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 116,
                SehirId  = 9,
                IlceKodu = 1479,
                IlceAdi  = "Koçarlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 117,
                SehirId  = 9,
                IlceKodu = 1497,
                IlceAdi  = "Kuşadası",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 118,
                SehirId  = 9,
                IlceKodu = 1498,
                IlceAdi  = "Kuyucak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 119,
                SehirId  = 9,
                IlceKodu = 1542,
                IlceAdi  = "Nazilli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 120,
                SehirId  = 9,
                IlceKodu = 1637,
                IlceAdi  = "Söke",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 121,
                SehirId  = 9,
                IlceKodu = 1640,
                IlceAdi  = "Sultanhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 122,
                SehirId  = 9,
                IlceKodu = 1724,
                IlceAdi  = "Yenipazar / Aydın",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 123,
                SehirId  = 9,
                IlceKodu = 1781,
                IlceAdi  = "Buharkent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 124,
                SehirId  = 9,
                IlceKodu = 1807,
                IlceAdi  = "İncirliova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 125,
                SehirId  = 9,
                IlceKodu = 1957,
                IlceAdi  = "Karpuzlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 126,
                SehirId  = 9,
                IlceKodu = 1968,
                IlceAdi  = "Köşk",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 127,
                SehirId  = 9,
                IlceKodu = 2000,
                IlceAdi  = "Didim",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 128,
                SehirId  = 9,
                IlceKodu = 2076,
                IlceAdi  = "Efeler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 129,
                SehirId  = 10,
                IlceKodu = 1161,
                IlceAdi  = "Ayvalık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 130,
                SehirId  = 10,
                IlceKodu = 1168,
                IlceAdi  = "Balıkesir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 131,
                SehirId  = 10,
                IlceKodu = 1169,
                IlceAdi  = "Balya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 132,
                SehirId  = 10,
                IlceKodu = 1171,
                IlceAdi  = "Bandırma",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 133,
                SehirId  = 10,
                IlceKodu = 1191,
                IlceAdi  = "Bigadiç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 134,
                SehirId  = 10,
                IlceKodu = 1216,
                IlceAdi  = "Burhaniye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 135,
                SehirId  = 10,
                IlceKodu = 1291,
                IlceAdi  = "Dursunbey",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 136,
                SehirId  = 10,
                IlceKodu = 1294,
                IlceAdi  = "Edremit / Balıkesir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 137,
                SehirId  = 10,
                IlceKodu = 1310,
                IlceAdi  = "Erdek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 138,
                SehirId  = 10,
                IlceKodu = 1360,
                IlceAdi  = "Gönen / Balıkesir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 139,
                SehirId  = 10,
                IlceKodu = 1384,
                IlceAdi  = "Havran",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 140,
                SehirId  = 10,
                IlceKodu = 1418,
                IlceAdi  = "İvrindi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 141,
                SehirId  = 10,
                IlceKodu = 1462,
                IlceAdi  = "Kepsut",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 142,
                SehirId  = 10,
                IlceKodu = 1514,
                IlceAdi  = "Manyas",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 143,
                SehirId  = 10,
                IlceKodu = 1608,
                IlceAdi  = "Savaştepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 144,
                SehirId  = 10,
                IlceKodu = 1619,
                IlceAdi  = "Sındırgı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 145,
                SehirId  = 10,
                IlceKodu = 1644,
                IlceAdi  = "Susurluk",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 146,
                SehirId  = 10,
                IlceKodu = 1824,
                IlceAdi  = "Marmara",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 147,
                SehirId  = 10,
                IlceKodu = 1928,
                IlceAdi  = "Gömeç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 148,
                SehirId  = 10,
                IlceKodu = 2077,
                IlceAdi  = "Altıeylül",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 149,
                SehirId  = 10,
                IlceKodu = 2078,
                IlceAdi  = "Karesi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 150,
                SehirId  = 11,
                IlceKodu = 1192,
                IlceAdi  = "Bilecik Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 151,
                SehirId  = 11,
                IlceKodu = 1210,
                IlceAdi  = "Bozüyük",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 152,
                SehirId  = 11,
                IlceKodu = 1359,
                IlceAdi  = "Gölpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 153,
                SehirId  = 11,
                IlceKodu = 1559,
                IlceAdi  = "Osmaneli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 154,
                SehirId  = 11,
                IlceKodu = 1571,
                IlceAdi  = "Pazaryeri",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 155,
                SehirId  = 11,
                IlceKodu = 1636,
                IlceAdi  = "Söğüt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 156,
                SehirId  = 11,
                IlceKodu = 1857,
                IlceAdi  = "Yenipazar / Bilecik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 157,
                SehirId  = 11,
                IlceKodu = 1948,
                IlceAdi  = "İnhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 158,
                SehirId  = 12,
                IlceKodu = 1193,
                IlceAdi  = "Bingöl Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 159,
                SehirId  = 12,
                IlceKodu = 1344,
                IlceAdi  = "Genç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 160,
                SehirId  = 12,
                IlceKodu = 1446,
                IlceAdi  = "Karlıova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 161,
                SehirId  = 12,
                IlceKodu = 1475,
                IlceAdi  = "Kiğı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 162,
                SehirId  = 12,
                IlceKodu = 1633,
                IlceAdi  = "Solhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 163,
                SehirId  = 12,
                IlceKodu = 1750,
                IlceAdi  = "Adaklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 164,
                SehirId  = 12,
                IlceKodu = 1855,
                IlceAdi  = "Yayladere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 165,
                SehirId  = 12,
                IlceKodu = 1996,
                IlceAdi  = "Yedisu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 166,
                SehirId  = 13,
                IlceKodu = 1106,
                IlceAdi  = "Adilcevaz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 167,
                SehirId  = 13,
                IlceKodu = 1112,
                IlceAdi  = "Ahlat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 168,
                SehirId  = 13,
                IlceKodu = 1196,
                IlceAdi  = "Bitlis Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 169,
                SehirId  = 13,
                IlceKodu = 1394,
                IlceAdi  = "Hizan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 170,
                SehirId  = 13,
                IlceKodu = 1537,
                IlceAdi  = "Mutki",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 171,
                SehirId  = 13,
                IlceKodu = 1669,
                IlceAdi  = "Tatvan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 172,
                SehirId  = 13,
                IlceKodu = 1798,
                IlceAdi  = "Güroymak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 173,
                SehirId  = 14,
                IlceKodu = 1199,
                IlceAdi  = "Bolu Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 174,
                SehirId  = 14,
                IlceKodu = 1346,
                IlceAdi  = "Gerede",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 175,
                SehirId  = 14,
                IlceKodu = 1364,
                IlceAdi  = "Göynük",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 176,
                SehirId  = 14,
                IlceKodu = 1466,
                IlceAdi  = "Kıbrıscık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 177,
                SehirId  = 14,
                IlceKodu = 1522,
                IlceAdi  = "Mengen",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 178,
                SehirId  = 14,
                IlceKodu = 1531,
                IlceAdi  = "Mudurnu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 179,
                SehirId  = 14,
                IlceKodu = 1610,
                IlceAdi  = "Seben",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 180,
                SehirId  = 14,
                IlceKodu = 1916,
                IlceAdi  = "Dörtdivan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 181,
                SehirId  = 14,
                IlceKodu = 1997,
                IlceAdi  = "Yeniçağa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 182,
                SehirId  = 15,
                IlceKodu = 1109,
                IlceAdi  = "Ağlasun",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 183,
                SehirId  = 15,
                IlceKodu = 1211,
                IlceAdi  = "Bucak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 184,
                SehirId  = 15,
                IlceKodu = 1215,
                IlceAdi  = "Burdur Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 185,
                SehirId  = 15,
                IlceKodu = 1357,
                IlceAdi  = "Gölhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 186,
                SehirId  = 15,
                IlceKodu = 1672,
                IlceAdi  = "Tefenni",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 187,
                SehirId  = 15,
                IlceKodu = 1728,
                IlceAdi  = "Yeşilova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 188,
                SehirId  = 15,
                IlceKodu = 1813,
                IlceAdi  = "Karamanlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 189,
                SehirId  = 15,
                IlceKodu = 1816,
                IlceAdi  = "Kemer / Burdur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 190,
                SehirId  = 15,
                IlceKodu = 1874,
                IlceAdi  = "Altınyayla / Burdur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 191,
                SehirId  = 15,
                IlceKodu = 1899,
                IlceAdi  = "Çavdır",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 192,
                SehirId  = 15,
                IlceKodu = 1903,
                IlceAdi  = "Çeltikçi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 193,
                SehirId  = 16,
                IlceKodu = 1343,
                IlceAdi  = "Gemlik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 194,
                SehirId  = 16,
                IlceKodu = 1411,
                IlceAdi  = "İnegöl",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 195,
                SehirId  = 16,
                IlceKodu = 1420,
                IlceAdi  = "İznik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 196,
                SehirId  = 16,
                IlceKodu = 1434,
                IlceAdi  = "Karacabey",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 197,
                SehirId  = 16,
                IlceKodu = 1457,
                IlceAdi  = "Keles",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 198,
                SehirId  = 16,
                IlceKodu = 1530,
                IlceAdi  = "Mudanya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 199,
                SehirId  = 16,
                IlceKodu = 1535,
                IlceAdi  = "Mustafakemalpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 200,
                SehirId  = 16,
                IlceKodu = 1553,
                IlceAdi  = "Orhaneli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 201,
                SehirId  = 16,
                IlceKodu = 1554,
                IlceAdi  = "Orhangazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 202,
                SehirId  = 16,
                IlceKodu = 1725,
                IlceAdi  = "Yenişehir / Bursa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 203,
                SehirId  = 16,
                IlceKodu = 1783,
                IlceAdi  = "Büyükorhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 204,
                SehirId  = 16,
                IlceKodu = 1799,
                IlceAdi  = "Harmancık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 205,
                SehirId  = 16,
                IlceKodu = 1829,
                IlceAdi  = "Nilüfer",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 206,
                SehirId  = 16,
                IlceKodu = 1832,
                IlceAdi  = "Osmangazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 207,
                SehirId  = 16,
                IlceKodu = 1859,
                IlceAdi  = "Yıldırım",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 208,
                SehirId  = 16,
                IlceKodu = 1935,
                IlceAdi  = "Gürsu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 209,
                SehirId  = 16,
                IlceKodu = 1960,
                IlceAdi  = "Kestel",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 210,
                SehirId  = 17,
                IlceKodu = 1160,
                IlceAdi  = "Ayvacık / Çanakkale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 211,
                SehirId  = 17,
                IlceKodu = 1180,
                IlceAdi  = "Bayramiç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 212,
                SehirId  = 17,
                IlceKodu = 1190,
                IlceAdi  = "Biga",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 213,
                SehirId  = 17,
                IlceKodu = 1205,
                IlceAdi  = "Bozcaada",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 214,
                SehirId  = 17,
                IlceKodu = 1229,
                IlceAdi  = "Çan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 215,
                SehirId  = 17,
                IlceKodu = 1230,
                IlceAdi  = "Çanakkale Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 216,
                SehirId  = 17,
                IlceKodu = 1293,
                IlceAdi  = "Eceabat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 217,
                SehirId  = 17,
                IlceKodu = 1326,
                IlceAdi  = "Ezine",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 218,
                SehirId  = 17,
                IlceKodu = 1340,
                IlceAdi  = "Gelibolu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 219,
                SehirId  = 17,
                IlceKodu = 1408,
                IlceAdi  = "Gökçeada",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 220,
                SehirId  = 17,
                IlceKodu = 1503,
                IlceAdi  = "Lapseki",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 221,
                SehirId  = 17,
                IlceKodu = 1722,
                IlceAdi  = "Yenice / Çanakkale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 222,
                SehirId  = 18,
                IlceKodu = 1232,
                IlceAdi  = "Çankırı Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 223,
                SehirId  = 18,
                IlceKodu = 1248,
                IlceAdi  = "Çerkeş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 224,
                SehirId  = 18,
                IlceKodu = 1300,
                IlceAdi  = "Eldivan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 225,
                SehirId  = 18,
                IlceKodu = 1399,
                IlceAdi  = "Ilgaz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 226,
                SehirId  = 18,
                IlceKodu = 1494,
                IlceAdi  = "Kurşunlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 227,
                SehirId  = 18,
                IlceKodu = 1555,
                IlceAdi  = "Orta",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 228,
                SehirId  = 18,
                IlceKodu = 1649,
                IlceAdi  = "Şabanözü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 229,
                SehirId  = 18,
                IlceKodu = 1718,
                IlceAdi  = "Yapraklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 230,
                SehirId  = 18,
                IlceKodu = 1765,
                IlceAdi  = "Atkaracalar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 231,
                SehirId  = 18,
                IlceKodu = 1817,
                IlceAdi  = "Kızılırmak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 232,
                SehirId  = 18,
                IlceKodu = 1885,
                IlceAdi  = "Bayramören",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 233,
                SehirId  = 18,
                IlceKodu = 1963,
                IlceAdi  = "Korgun",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 234,
                SehirId  = 19,
                IlceKodu = 1124,
                IlceAdi  = "Alaca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 235,
                SehirId  = 19,
                IlceKodu = 1177,
                IlceAdi  = "Bayat / Çorum",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 236,
                SehirId  = 19,
                IlceKodu = 1259,
                IlceAdi  = "Çorum Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 237,
                SehirId  = 19,
                IlceKodu = 1414,
                IlceAdi  = "İskilip",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 238,
                SehirId  = 19,
                IlceKodu = 1445,
                IlceAdi  = "Kargı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 239,
                SehirId  = 19,
                IlceKodu = 1520,
                IlceAdi  = "Mecitözü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 240,
                SehirId  = 19,
                IlceKodu = 1556,
                IlceAdi  = "Ortaköy / Çorum",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 241,
                SehirId  = 19,
                IlceKodu = 1558,
                IlceAdi  = "Osmancık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 242,
                SehirId  = 19,
                IlceKodu = 1642,
                IlceAdi  = "Sungurlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 243,
                SehirId  = 19,
                IlceKodu = 1778,
                IlceAdi  = "Boğazkale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 244,
                SehirId  = 19,
                IlceKodu = 1850,
                IlceAdi  = "Uğurludağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 245,
                SehirId  = 19,
                IlceKodu = 1911,
                IlceAdi  = "Dodurga",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 246,
                SehirId  = 19,
                IlceKodu = 1972,
                IlceAdi  = "Laçin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 247,
                SehirId  = 19,
                IlceKodu = 1976,
                IlceAdi  = "Oğuzlar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 248,
                SehirId  = 20,
                IlceKodu = 1102,
                IlceAdi  = "Acıpayam",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 249,
                SehirId  = 20,
                IlceKodu = 1214,
                IlceAdi  = "Buldan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 250,
                SehirId  = 20,
                IlceKodu = 1224,
                IlceAdi  = "Çal",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 251,
                SehirId  = 20,
                IlceKodu = 1226,
                IlceAdi  = "Çameli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 252,
                SehirId  = 20,
                IlceKodu = 1233,
                IlceAdi  = "Çardak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 253,
                SehirId  = 20,
                IlceKodu = 1257,
                IlceAdi  = "Çivril",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 254,
                SehirId  = 20,
                IlceKodu = 1271,
                IlceAdi  = "Denizli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 255,
                SehirId  = 20,
                IlceKodu = 1371,
                IlceAdi  = "Güney",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 256,
                SehirId  = 20,
                IlceKodu = 1426,
                IlceAdi  = "Kale / Denizli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 257,
                SehirId  = 20,
                IlceKodu = 1597,
                IlceAdi  = "Sarayköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 258,
                SehirId  = 20,
                IlceKodu = 1670,
                IlceAdi  = "Tavas",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 259,
                SehirId  = 20,
                IlceKodu = 1769,
                IlceAdi  = "Babadağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 260,
                SehirId  = 20,
                IlceKodu = 1774,
                IlceAdi  = "Bekilli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 261,
                SehirId  = 20,
                IlceKodu = 1803,
                IlceAdi  = "Honaz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 262,
                SehirId  = 20,
                IlceKodu = 1840,
                IlceAdi  = "Serinhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 263,
                SehirId  = 20,
                IlceKodu = 1871,
                IlceAdi  = "Pamukkale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 264,
                SehirId  = 20,
                IlceKodu = 1881,
                IlceAdi  = "Baklan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 265,
                SehirId  = 20,
                IlceKodu = 1888,
                IlceAdi  = "Beyağaç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 266,
                SehirId  = 20,
                IlceKodu = 1889,
                IlceAdi  = "Bozkurt / Denizli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 267,
                SehirId  = 20,
                IlceKodu = 2079,
                IlceAdi  = "Merkezefendi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 268,
                SehirId  = 21,
                IlceKodu = 1195,
                IlceAdi  = "Bismil",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 269,
                SehirId  = 21,
                IlceKodu = 1249,
                IlceAdi  = "Çermik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 270,
                SehirId  = 21,
                IlceKodu = 1253,
                IlceAdi  = "Çınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 271,
                SehirId  = 21,
                IlceKodu = 1263,
                IlceAdi  = "Çüngüş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 272,
                SehirId  = 21,
                IlceKodu = 1278,
                IlceAdi  = "Dicle",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 273,
                SehirId  = 21,
                IlceKodu = 1284,
                IlceAdi  = "Diyarbakır Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 274,
                SehirId  = 21,
                IlceKodu = 1315,
                IlceAdi  = "Ergani",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 275,
                SehirId  = 21,
                IlceKodu = 1381,
                IlceAdi  = "Hani",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 276,
                SehirId  = 21,
                IlceKodu = 1389,
                IlceAdi  = "Hazro",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 277,
                SehirId  = 21,
                IlceKodu = 1490,
                IlceAdi  = "Kulp",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 278,
                SehirId  = 21,
                IlceKodu = 1504,
                IlceAdi  = "Lice",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 279,
                SehirId  = 21,
                IlceKodu = 1624,
                IlceAdi  = "Silvan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 280,
                SehirId  = 21,
                IlceKodu = 1791,
                IlceAdi  = "Eğil",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 281,
                SehirId  = 21,
                IlceKodu = 1962,
                IlceAdi  = "Kocaköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 282,
                SehirId  = 21,
                IlceKodu = 2040,
                IlceAdi  = "Bağlar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 283,
                SehirId  = 21,
                IlceKodu = 2041,
                IlceAdi  = "Kayapınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 284,
                SehirId  = 21,
                IlceKodu = 2042,
                IlceAdi  = "Sur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 285,
                SehirId  = 21,
                IlceKodu = 2043,
                IlceAdi  = "Yenişehir / Diyarbakır",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 286,
                SehirId  = 22,
                IlceKodu = 1295,
                IlceAdi  = "Edirne Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 287,
                SehirId  = 22,
                IlceKodu = 1307,
                IlceAdi  = "Enez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 288,
                SehirId  = 22,
                IlceKodu = 1385,
                IlceAdi  = "Havsa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 289,
                SehirId  = 22,
                IlceKodu = 1412,
                IlceAdi  = "İpsala",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 290,
                SehirId  = 22,
                IlceKodu = 1464,
                IlceAdi  = "Keşan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 291,
                SehirId  = 22,
                IlceKodu = 1502,
                IlceAdi  = "Lalapaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 292,
                SehirId  = 22,
                IlceKodu = 1523,
                IlceAdi  = "Meriç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 293,
                SehirId  = 22,
                IlceKodu = 1705,
                IlceAdi  = "Uzunköprü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 294,
                SehirId  = 22,
                IlceKodu = 1988,
                IlceAdi  = "Süloğlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 295,
                SehirId  = 23,
                IlceKodu = 1110,
                IlceAdi  = "Ağın",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 296,
                SehirId  = 23,
                IlceKodu = 1173,
                IlceAdi  = "Baskil",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 297,
                SehirId  = 23,
                IlceKodu = 1298,
                IlceAdi  = "Elazığ Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 298,
                SehirId  = 23,
                IlceKodu = 1438,
                IlceAdi  = "Karakoçan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 299,
                SehirId  = 23,
                IlceKodu = 1455,
                IlceAdi  = "Keban",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 300,
                SehirId  = 23,
                IlceKodu = 1506,
                IlceAdi  = "Maden",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 301,
                SehirId  = 23,
                IlceKodu = 1566,
                IlceAdi  = "Palu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 302,
                SehirId  = 23,
                IlceKodu = 1631,
                IlceAdi  = "Sivrice",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 303,
                SehirId  = 23,
                IlceKodu = 1762,
                IlceAdi  = "Arıcak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 304,
                SehirId  = 23,
                IlceKodu = 1820,
                IlceAdi  = "Kovancılar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 305,
                SehirId  = 23,
                IlceKodu = 1873,
                IlceAdi  = "Alacakaya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 306,
                SehirId  = 24,
                IlceKodu = 1243,
                IlceAdi  = "Çayırlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 307,
                SehirId  = 24,
                IlceKodu = 1318,
                IlceAdi  = "Erzincan Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 308,
                SehirId  = 24,
                IlceKodu = 1406,
                IlceAdi  = "İliç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 309,
                SehirId  = 24,
                IlceKodu = 1459,
                IlceAdi  = "Kemah",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 310,
                SehirId  = 24,
                IlceKodu = 1460,
                IlceAdi  = "Kemaliye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 311,
                SehirId  = 24,
                IlceKodu = 1583,
                IlceAdi  = "Refahiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 312,
                SehirId  = 24,
                IlceKodu = 1675,
                IlceAdi  = "Tercan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 313,
                SehirId  = 24,
                IlceKodu = 1853,
                IlceAdi  = "Üzümlü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 314,
                SehirId  = 24,
                IlceKodu = 1977,
                IlceAdi  = "Otlukbeli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 315,
                SehirId  = 25,
                IlceKodu = 1153,
                IlceAdi  = "Aşkale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 316,
                SehirId  = 25,
                IlceKodu = 1235,
                IlceAdi  = "Çat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 317,
                SehirId  = 25,
                IlceKodu = 1319,
                IlceAdi  = "Erzurum Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 318,
                SehirId  = 25,
                IlceKodu = 1392,
                IlceAdi  = "Hınıs",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 319,
                SehirId  = 25,
                IlceKodu = 1396,
                IlceAdi  = "Horasan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 320,
                SehirId  = 25,
                IlceKodu = 1416,
                IlceAdi  = "İspir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 321,
                SehirId  = 25,
                IlceKodu = 1444,
                IlceAdi  = "Karayazı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 322,
                SehirId  = 25,
                IlceKodu = 1540,
                IlceAdi  = "Narman",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 323,
                SehirId  = 25,
                IlceKodu = 1550,
                IlceAdi  = "Oltu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 324,
                SehirId  = 25,
                IlceKodu = 1551,
                IlceAdi  = "Olur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 325,
                SehirId  = 25,
                IlceKodu = 1567,
                IlceAdi  = "Pasinler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 326,
                SehirId  = 25,
                IlceKodu = 1657,
                IlceAdi  = "Şenkaya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 327,
                SehirId  = 25,
                IlceKodu = 1674,
                IlceAdi  = "Tekman",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 328,
                SehirId  = 25,
                IlceKodu = 1683,
                IlceAdi  = "Tortum",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 329,
                SehirId  = 25,
                IlceKodu = 1812,
                IlceAdi  = "Karaçoban",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 330,
                SehirId  = 25,
                IlceKodu = 1851,
                IlceAdi  = "Uzundere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 331,
                SehirId  = 25,
                IlceKodu = 1865,
                IlceAdi  = "Pazaryolu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 332,
                SehirId  = 25,
                IlceKodu = 1945,
                IlceAdi  = "Aziziye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 333,
                SehirId  = 25,
                IlceKodu = 1967,
                IlceAdi  = "Köprüköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 334,
                SehirId  = 25,
                IlceKodu = 2044,
                IlceAdi  = "Palandöken",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 335,
                SehirId  = 25,
                IlceKodu = 2045,
                IlceAdi  = "Yakutiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 336,
                SehirId  = 26,
                IlceKodu = 1255,
                IlceAdi  = "Çifteler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 337,
                SehirId  = 26,
                IlceKodu = 1322,
                IlceAdi  = "Eskişehir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 338,
                SehirId  = 26,
                IlceKodu = 1508,
                IlceAdi  = "Mahmudiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 339,
                SehirId  = 26,
                IlceKodu = 1527,
                IlceAdi  = "Mihalıççık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 340,
                SehirId  = 26,
                IlceKodu = 1599,
                IlceAdi  = "Sarıcakaya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 341,
                SehirId  = 26,
                IlceKodu = 1618,
                IlceAdi  = "Seyitgazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 342,
                SehirId  = 26,
                IlceKodu = 1632,
                IlceAdi  = "Sivrihisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 343,
                SehirId  = 26,
                IlceKodu = 1759,
                IlceAdi  = "Alpu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 344,
                SehirId  = 26,
                IlceKodu = 1777,
                IlceAdi  = "Beylikova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 345,
                SehirId  = 26,
                IlceKodu = 1808,
                IlceAdi  = "İnönü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 346,
                SehirId  = 26,
                IlceKodu = 1934,
                IlceAdi  = "Günyüzü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 347,
                SehirId  = 26,
                IlceKodu = 1939,
                IlceAdi  = "Han",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 348,
                SehirId  = 26,
                IlceKodu = 1973,
                IlceAdi  = "Mihalgazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 349,
                SehirId  = 26,
                IlceKodu = 2046,
                IlceAdi  = "Odunpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 350,
                SehirId  = 26,
                IlceKodu = 2047,
                IlceAdi  = "Tepebaşı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 351,
                SehirId  = 27,
                IlceKodu = 1139,
                IlceAdi  = "Araban",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 352,
                SehirId  = 27,
                IlceKodu = 1415,
                IlceAdi  = "İslahiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 353,
                SehirId  = 27,
                IlceKodu = 1546,
                IlceAdi  = "Nizip",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 354,
                SehirId  = 27,
                IlceKodu = 1549,
                IlceAdi  = "Oğuzeli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 355,
                SehirId  = 27,
                IlceKodu = 1720,
                IlceAdi  = "Yavuzeli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 356,
                SehirId  = 27,
                IlceKodu = 1841,
                IlceAdi  = "Şahinbey",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 357,
                SehirId  = 27,
                IlceKodu = 1844,
                IlceAdi  = "Şehitkamil",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 358,
                SehirId  = 27,
                IlceKodu = 1956,
                IlceAdi  = "Karkamış",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 359,
                SehirId  = 27,
                IlceKodu = 1974,
                IlceAdi  = "Nurdağı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 360,
                SehirId  = 28,
                IlceKodu = 1133,
                IlceAdi  = "Alucra",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 361,
                SehirId  = 28,
                IlceKodu = 1212,
                IlceAdi  = "Bulancak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 362,
                SehirId  = 28,
                IlceKodu = 1272,
                IlceAdi  = "Dereli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 363,
                SehirId  = 28,
                IlceKodu = 1320,
                IlceAdi  = "Espiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 364,
                SehirId  = 28,
                IlceKodu = 1324,
                IlceAdi  = "Eynesil",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 365,
                SehirId  = 28,
                IlceKodu = 1352,
                IlceAdi  = "Giresun Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 366,
                SehirId  = 28,
                IlceKodu = 1361,
                IlceAdi  = "Görele",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 367,
                SehirId  = 28,
                IlceKodu = 1465,
                IlceAdi  = "Keşap",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 368,
                SehirId  = 28,
                IlceKodu = 1654,
                IlceAdi  = "Şebinkarahisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 369,
                SehirId  = 28,
                IlceKodu = 1678,
                IlceAdi  = "Tirebolu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 370,
                SehirId  = 28,
                IlceKodu = 1837,
                IlceAdi  = "Piraziz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 371,
                SehirId  = 28,
                IlceKodu = 1854,
                IlceAdi  = "Yağlıdere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 372,
                SehirId  = 28,
                IlceKodu = 1893,
                IlceAdi  = "Çamoluk",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 373,
                SehirId  = 28,
                IlceKodu = 1894,
                IlceAdi  = "Çanakçı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 374,
                SehirId  = 28,
                IlceKodu = 1912,
                IlceAdi  = "Doğankent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 375,
                SehirId  = 28,
                IlceKodu = 1930,
                IlceAdi  = "Güce",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 376,
                SehirId  = 29,
                IlceKodu = 1369,
                IlceAdi  = "Gümüşhane Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 377,
                SehirId  = 29,
                IlceKodu = 1458,
                IlceAdi  = "Kelkit",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 378,
                SehirId  = 29,
                IlceKodu = 1660,
                IlceAdi  = "Şiran",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 379,
                SehirId  = 29,
                IlceKodu = 1684,
                IlceAdi  = "Torul",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 380,
                SehirId  = 29,
                IlceKodu = 1822,
                IlceAdi  = "Köse",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 381,
                SehirId  = 29,
                IlceKodu = 1971,
                IlceAdi  = "Kürtün",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 382,
                SehirId  = 30,
                IlceKodu = 1261,
                IlceAdi  = "Çukurca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 383,
                SehirId  = 30,
                IlceKodu = 1377,
                IlceAdi  = "Hakkari Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 384,
                SehirId  = 30,
                IlceKodu = 1656,
                IlceAdi  = "Şemdinli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 385,
                SehirId  = 30,
                IlceKodu = 1737,
                IlceAdi  = "Yüksekova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 386,
                SehirId  = 31,
                IlceKodu = 1131,
                IlceAdi  = "Altınözü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 387,
                SehirId  = 31,
                IlceKodu = 1289,
                IlceAdi  = "Dörtyol",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 388,
                SehirId  = 31,
                IlceKodu = 1382,
                IlceAdi  = "Hassa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 389,
                SehirId  = 31,
                IlceKodu = 1383,
                IlceAdi  = "Hatay Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 390,
                SehirId  = 31,
                IlceKodu = 1413,
                IlceAdi  = "İskenderun",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 391,
                SehirId  = 31,
                IlceKodu = 1468,
                IlceAdi  = "Kırıkhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 392,
                SehirId  = 31,
                IlceKodu = 1585,
                IlceAdi  = "Reyhanlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 393,
                SehirId  = 31,
                IlceKodu = 1591,
                IlceAdi  = "Samandağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 394,
                SehirId  = 31,
                IlceKodu = 1721,
                IlceAdi  = "Yayladağı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 395,
                SehirId  = 31,
                IlceKodu = 1792,
                IlceAdi  = "Erzin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 396,
                SehirId  = 31,
                IlceKodu = 1887,
                IlceAdi  = "Belen",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 397,
                SehirId  = 31,
                IlceKodu = 1970,
                IlceAdi  = "Kumlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 398,
                SehirId  = 31,
                IlceKodu = 2080,
                IlceAdi  = "Antakya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 399,
                SehirId  = 31,
                IlceKodu = 2081,
                IlceAdi  = "Arsuz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 400,
                SehirId  = 31,
                IlceKodu = 2082,
                IlceAdi  = "Defne",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 401,
                SehirId  = 31,
                IlceKodu = 2083,
                IlceAdi  = "Payas",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 402,
                SehirId  = 32,
                IlceKodu = 1154,
                IlceAdi  = "Atabey",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 403,
                SehirId  = 32,
                IlceKodu = 1297,
                IlceAdi  = "Eğirdir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 404,
                SehirId  = 32,
                IlceKodu = 1341,
                IlceAdi  = "Gelendost",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 405,
                SehirId  = 32,
                IlceKodu = 1401,
                IlceAdi  = "Isparta Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 406,
                SehirId  = 32,
                IlceKodu = 1456,
                IlceAdi  = "Keçiborlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 407,
                SehirId  = 32,
                IlceKodu = 1615,
                IlceAdi  = "Senirkent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 408,
                SehirId  = 32,
                IlceKodu = 1648,
                IlceAdi  = "Sütçüler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 409,
                SehirId  = 32,
                IlceKodu = 1651,
                IlceAdi  = "Şarkikaraağaç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 410,
                SehirId  = 32,
                IlceKodu = 1699,
                IlceAdi  = "Uluborlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 411,
                SehirId  = 32,
                IlceKodu = 1717,
                IlceAdi  = "Yalvaç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 412,
                SehirId  = 32,
                IlceKodu = 1755,
                IlceAdi  = "Aksu / Isparta",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 413,
                SehirId  = 32,
                IlceKodu = 1929,
                IlceAdi  = "Gönen / Isparta",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 414,
                SehirId  = 32,
                IlceKodu = 2001,
                IlceAdi  = "Yenişarbademli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 415,
                SehirId  = 33,
                IlceKodu = 1135,
                IlceAdi  = "Anamur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 416,
                SehirId  = 33,
                IlceKodu = 1311,
                IlceAdi  = "Erdemli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 417,
                SehirId  = 33,
                IlceKodu = 1366,
                IlceAdi  = "Gülnar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 418,
                SehirId  = 33,
                IlceKodu = 1402,
                IlceAdi  = "Mersin Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 419,
                SehirId  = 33,
                IlceKodu = 1536,
                IlceAdi  = "Mut",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 420,
                SehirId  = 33,
                IlceKodu = 1621,
                IlceAdi  = "Silifke",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 421,
                SehirId  = 33,
                IlceKodu = 1665,
                IlceAdi  = "Tarsus",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 422,
                SehirId  = 33,
                IlceKodu = 1766,
                IlceAdi  = "Aydıncık / Mersin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 423,
                SehirId  = 33,
                IlceKodu = 1779,
                IlceAdi  = "Bozyazı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 424,
                SehirId  = 33,
                IlceKodu = 1892,
                IlceAdi  = "Çamlıyayla",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 425,
                SehirId  = 33,
                IlceKodu = 2064,
                IlceAdi  = "Akdeniz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 426,
                SehirId  = 33,
                IlceKodu = 2065,
                IlceAdi  = "Mezitli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 427,
                SehirId  = 33,
                IlceKodu = 2066,
                IlceAdi  = "Toroslar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 428,
                SehirId  = 33,
                IlceKodu = 2067,
                IlceAdi  = "Yenişehir / Mersin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 429,
                SehirId  = 34,
                IlceKodu = 1103,
                IlceAdi  = "Adalar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 430,
                SehirId  = 34,
                IlceKodu = 1166,
                IlceAdi  = "Bakırköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 431,
                SehirId  = 34,
                IlceKodu = 1183,
                IlceAdi  = "Beşiktaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 432,
                SehirId  = 34,
                IlceKodu = 1185,
                IlceAdi  = "Beykoz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 433,
                SehirId  = 34,
                IlceKodu = 1186,
                IlceAdi  = "Beyoğlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 434,
                SehirId  = 34,
                IlceKodu = 1237,
                IlceAdi  = "Çatalca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 435,
                SehirId  = 34,
                IlceKodu = 1305,
                IlceAdi  = "Eminönü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 436,
                SehirId  = 34,
                IlceKodu = 1325,
                IlceAdi  = "Eyüp",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 437,
                SehirId  = 34,
                IlceKodu = 1327,
                IlceAdi  = "Fatih",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 438,
                SehirId  = 34,
                IlceKodu = 1336,
                IlceAdi  = "Gaziosmanpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 439,
                SehirId  = 34,
                IlceKodu = 1421,
                IlceAdi  = "Kadıköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 440,
                SehirId  = 34,
                IlceKodu = 1449,
                IlceAdi  = "Kartal",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 441,
                SehirId  = 34,
                IlceKodu = 1604,
                IlceAdi  = "Sarıyer",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 442,
                SehirId  = 34,
                IlceKodu = 1622,
                IlceAdi  = "Silivri",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 443,
                SehirId  = 34,
                IlceKodu = 1659,
                IlceAdi  = "Şile",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 444,
                SehirId  = 34,
                IlceKodu = 1663,
                IlceAdi  = "Şişli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 445,
                SehirId  = 34,
                IlceKodu = 1708,
                IlceAdi  = "Üsküdar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 446,
                SehirId  = 34,
                IlceKodu = 1739,
                IlceAdi  = "Zeytinburnu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 447,
                SehirId  = 34,
                IlceKodu = 1782,
                IlceAdi  = "Büyükçekmece",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 448,
                SehirId  = 34,
                IlceKodu = 1810,
                IlceAdi  = "Kağıthane",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 449,
                SehirId  = 34,
                IlceKodu = 1823,
                IlceAdi  = "Küçükçekmece",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 450,
                SehirId  = 34,
                IlceKodu = 1835,
                IlceAdi  = "Pendik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 451,
                SehirId  = 34,
                IlceKodu = 1852,
                IlceAdi  = "Ümraniye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 452,
                SehirId  = 34,
                IlceKodu = 1886,
                IlceAdi  = "Bayrampaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 453,
                SehirId  = 34,
                IlceKodu = 2003,
                IlceAdi  = "Avcılar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 454,
                SehirId  = 34,
                IlceKodu = 2004,
                IlceAdi  = "Bağcılar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 455,
                SehirId  = 34,
                IlceKodu = 2005,
                IlceAdi  = "Bahçelievler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 456,
                SehirId  = 34,
                IlceKodu = 2010,
                IlceAdi  = "Güngören",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 457,
                SehirId  = 34,
                IlceKodu = 2012,
                IlceAdi  = "Maltepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 458,
                SehirId  = 34,
                IlceKodu = 2014,
                IlceAdi  = "Sultanbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 459,
                SehirId  = 34,
                IlceKodu = 2015,
                IlceAdi  = "Tuzla",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 460,
                SehirId  = 34,
                IlceKodu = 2016,
                IlceAdi  = "Esenler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 461,
                SehirId  = 34,
                IlceKodu = 2048,
                IlceAdi  = "Arnavutköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 462,
                SehirId  = 34,
                IlceKodu = 2049,
                IlceAdi  = "Ataşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 463,
                SehirId  = 34,
                IlceKodu = 2050,
                IlceAdi  = "Başakşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 464,
                SehirId  = 34,
                IlceKodu = 2051,
                IlceAdi  = "Beylikdüzü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 465,
                SehirId  = 34,
                IlceKodu = 2052,
                IlceAdi  = "Çekmeköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 466,
                SehirId  = 34,
                IlceKodu = 2053,
                IlceAdi  = "Esenyurt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 467,
                SehirId  = 34,
                IlceKodu = 2054,
                IlceAdi  = "Sancaktepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 468,
                SehirId  = 34,
                IlceKodu = 2055,
                IlceAdi  = "Sultangazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 469,
                SehirId  = 35,
                IlceKodu = 1128,
                IlceAdi  = "Aliağa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 470,
                SehirId  = 35,
                IlceKodu = 1178,
                IlceAdi  = "Bayındır",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 471,
                SehirId  = 35,
                IlceKodu = 1181,
                IlceAdi  = "Bergama",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 472,
                SehirId  = 35,
                IlceKodu = 1203,
                IlceAdi  = "Bornova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 473,
                SehirId  = 35,
                IlceKodu = 1251,
                IlceAdi  = "Çeşme",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 474,
                SehirId  = 35,
                IlceKodu = 1280,
                IlceAdi  = "Dikili",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 475,
                SehirId  = 35,
                IlceKodu = 1334,
                IlceAdi  = "Foça",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 476,
                SehirId  = 35,
                IlceKodu = 1432,
                IlceAdi  = "Karaburun",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 477,
                SehirId  = 35,
                IlceKodu = 1448,
                IlceAdi  = "Karşıyaka",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 478,
                SehirId  = 35,
                IlceKodu = 1461,
                IlceAdi  = "Kemalpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 479,
                SehirId  = 35,
                IlceKodu = 1467,
                IlceAdi  = "Kınık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 480,
                SehirId  = 35,
                IlceKodu = 1477,
                IlceAdi  = "Kiraz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 481,
                SehirId  = 35,
                IlceKodu = 1521,
                IlceAdi  = "Menemen",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 482,
                SehirId  = 35,
                IlceKodu = 1563,
                IlceAdi  = "Ödemiş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 483,
                SehirId  = 35,
                IlceKodu = 1611,
                IlceAdi  = "Seferihisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 484,
                SehirId  = 35,
                IlceKodu = 1612,
                IlceAdi  = "Selçuk",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 485,
                SehirId  = 35,
                IlceKodu = 1677,
                IlceAdi  = "Tire",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 486,
                SehirId  = 35,
                IlceKodu = 1682,
                IlceAdi  = "Torbalı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 487,
                SehirId  = 35,
                IlceKodu = 1703,
                IlceAdi  = "Urla",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 488,
                SehirId  = 35,
                IlceKodu = 1776,
                IlceAdi  = "Beydağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 489,
                SehirId  = 35,
                IlceKodu = 1780,
                IlceAdi  = "Buca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 490,
                SehirId  = 35,
                IlceKodu = 1819,
                IlceAdi  = "Konak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 491,
                SehirId  = 35,
                IlceKodu = 1826,
                IlceAdi  = "Menderes",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 492,
                SehirId  = 35,
                IlceKodu = 2006,
                IlceAdi  = "Balçova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 493,
                SehirId  = 35,
                IlceKodu = 2007,
                IlceAdi  = "Çiğli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 494,
                SehirId  = 35,
                IlceKodu = 2009,
                IlceAdi  = "Gaziemir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 495,
                SehirId  = 35,
                IlceKodu = 2013,
                IlceAdi  = "Narlıdere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 496,
                SehirId  = 35,
                IlceKodu = 2018,
                IlceAdi  = "Güzelbahçe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 497,
                SehirId  = 35,
                IlceKodu = 2056,
                IlceAdi  = "Bayraklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 498,
                SehirId  = 35,
                IlceKodu = 2057,
                IlceAdi  = "Karabağlar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 499,
                SehirId  = 36,
                IlceKodu = 1149,
                IlceAdi  = "Arpaçay",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 500,
                SehirId  = 36,
                IlceKodu = 1279,
                IlceAdi  = "Digor",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 501,
                SehirId  = 36,
                IlceKodu = 1424,
                IlceAdi  = "Kağızman",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 502,
                SehirId  = 36,
                IlceKodu = 1447,
                IlceAdi  = "Kars Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 503,
                SehirId  = 36,
                IlceKodu = 1601,
                IlceAdi  = "Sarıkamış",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 504,
                SehirId  = 36,
                IlceKodu = 1614,
                IlceAdi  = "Selim",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 505,
                SehirId  = 36,
                IlceKodu = 1645,
                IlceAdi  = "Susuz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 506,
                SehirId  = 36,
                IlceKodu = 1756,
                IlceAdi  = "Akyaka",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 507,
                SehirId  = 37,
                IlceKodu = 1101,
                IlceAdi  = "Abana",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 508,
                SehirId  = 37,
                IlceKodu = 1140,
                IlceAdi  = "Araç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 509,
                SehirId  = 37,
                IlceKodu = 1162,
                IlceAdi  = "Azdavay",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 510,
                SehirId  = 37,
                IlceKodu = 1208,
                IlceAdi  = "Bozkurt / Kastamonu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 511,
                SehirId  = 37,
                IlceKodu = 1221,
                IlceAdi  = "Cide",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 512,
                SehirId  = 37,
                IlceKodu = 1238,
                IlceAdi  = "Çatalzeytin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 513,
                SehirId  = 37,
                IlceKodu = 1264,
                IlceAdi  = "Daday",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 514,
                SehirId  = 37,
                IlceKodu = 1277,
                IlceAdi  = "Devrekani",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 515,
                SehirId  = 37,
                IlceKodu = 1410,
                IlceAdi  = "İnebolu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 516,
                SehirId  = 37,
                IlceKodu = 1450,
                IlceAdi  = "Kastamonu Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 517,
                SehirId  = 37,
                IlceKodu = 1499,
                IlceAdi  = "Küre",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 518,
                SehirId  = 37,
                IlceKodu = 1666,
                IlceAdi  = "Taşköprü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 519,
                SehirId  = 37,
                IlceKodu = 1685,
                IlceAdi  = "Tosya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 520,
                SehirId  = 37,
                IlceKodu = 1805,
                IlceAdi  = "İhsangazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 521,
                SehirId  = 37,
                IlceKodu = 1836,
                IlceAdi  = "Pınarbaşı / Kastamonu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 522,
                SehirId  = 37,
                IlceKodu = 1845,
                IlceAdi  = "Şenpazar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 523,
                SehirId  = 37,
                IlceKodu = 1867,
                IlceAdi  = "Ağlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 524,
                SehirId  = 37,
                IlceKodu = 1915,
                IlceAdi  = "Doğanyurt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 525,
                SehirId  = 37,
                IlceKodu = 1940,
                IlceAdi  = "Hanönü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 526,
                SehirId  = 37,
                IlceKodu = 1984,
                IlceAdi  = "Seydiler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 527,
                SehirId  = 38,
                IlceKodu = 1218,
                IlceAdi  = "Bünyan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 528,
                SehirId  = 38,
                IlceKodu = 1275,
                IlceAdi  = "Develi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 529,
                SehirId  = 38,
                IlceKodu = 1330,
                IlceAdi  = "Felahiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 530,
                SehirId  = 38,
                IlceKodu = 1409,
                IlceAdi  = "İncesu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 531,
                SehirId  = 38,
                IlceKodu = 1576,
                IlceAdi  = "Pınarbaşı / Kayseri",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 532,
                SehirId  = 38,
                IlceKodu = 1603,
                IlceAdi  = "Sarıoğlan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 533,
                SehirId  = 38,
                IlceKodu = 1605,
                IlceAdi  = "Sarız",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 534,
                SehirId  = 38,
                IlceKodu = 1680,
                IlceAdi  = "Tomarza",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 535,
                SehirId  = 38,
                IlceKodu = 1715,
                IlceAdi  = "Yahyalı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 536,
                SehirId  = 38,
                IlceKodu = 1727,
                IlceAdi  = "Yeşilhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 537,
                SehirId  = 38,
                IlceKodu = 1752,
                IlceAdi  = "Akkışla",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 538,
                SehirId  = 38,
                IlceKodu = 1846,
                IlceAdi  = "Talas",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 539,
                SehirId  = 38,
                IlceKodu = 1863,
                IlceAdi  = "Kocasinan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 540,
                SehirId  = 38,
                IlceKodu = 1864,
                IlceAdi  = "Melikgazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 541,
                SehirId  = 38,
                IlceKodu = 1936,
                IlceAdi  = "Hacılar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 542,
                SehirId  = 38,
                IlceKodu = 1978,
                IlceAdi  = "Özvatan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 543,
                SehirId  = 39,
                IlceKodu = 1163,
                IlceAdi  = "Babaeski",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 544,
                SehirId  = 39,
                IlceKodu = 1270,
                IlceAdi  = "Demirköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 545,
                SehirId  = 39,
                IlceKodu = 1471,
                IlceAdi  = "Kırklareli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 546,
                SehirId  = 39,
                IlceKodu = 1480,
                IlceAdi  = "Kofçaz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 547,
                SehirId  = 39,
                IlceKodu = 1505,
                IlceAdi  = "Lüleburgaz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 548,
                SehirId  = 39,
                IlceKodu = 1572,
                IlceAdi  = "Pehlivanköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 549,
                SehirId  = 39,
                IlceKodu = 1577,
                IlceAdi  = "Pınarhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 550,
                SehirId  = 39,
                IlceKodu = 1714,
                IlceAdi  = "Vize",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 551,
                SehirId  = 40,
                IlceKodu = 1254,
                IlceAdi  = "Çiçekdağı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 552,
                SehirId  = 40,
                IlceKodu = 1429,
                IlceAdi  = "Kaman",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 553,
                SehirId  = 40,
                IlceKodu = 1472,
                IlceAdi  = "Kırşehir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 554,
                SehirId  = 40,
                IlceKodu = 1529,
                IlceAdi  = "Mucur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 555,
                SehirId  = 40,
                IlceKodu = 1754,
                IlceAdi  = "Akpınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 556,
                SehirId  = 40,
                IlceKodu = 1869,
                IlceAdi  = "Akçakent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 557,
                SehirId  = 40,
                IlceKodu = 1890,
                IlceAdi  = "Boztepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 558,
                SehirId  = 41,
                IlceKodu = 1338,
                IlceAdi  = "Gebze",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 559,
                SehirId  = 41,
                IlceKodu = 1355,
                IlceAdi  = "Gölcük",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 560,
                SehirId  = 41,
                IlceKodu = 1430,
                IlceAdi  = "Kandıra",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 561,
                SehirId  = 41,
                IlceKodu = 1440,
                IlceAdi  = "Karamürsel",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 562,
                SehirId  = 41,
                IlceKodu = 1478,
                IlceAdi  = "Kocaeli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 563,
                SehirId  = 41,
                IlceKodu = 1821,
                IlceAdi  = "Körfez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 564,
                SehirId  = 41,
                IlceKodu = 2030,
                IlceAdi  = "Derince",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 565,
                SehirId  = 41,
                IlceKodu = 2058,
                IlceAdi  = "Başiskele",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 566,
                SehirId  = 41,
                IlceKodu = 2059,
                IlceAdi  = "Çayırova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 567,
                SehirId  = 41,
                IlceKodu = 2060,
                IlceAdi  = "Darıca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 568,
                SehirId  = 41,
                IlceKodu = 2061,
                IlceAdi  = "Dilovası",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 569,
                SehirId  = 41,
                IlceKodu = 2062,
                IlceAdi  = "İzmit",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 570,
                SehirId  = 41,
                IlceKodu = 2063,
                IlceAdi  = "Kartepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 571,
                SehirId  = 42,
                IlceKodu = 1122,
                IlceAdi  = "Akşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 572,
                SehirId  = 42,
                IlceKodu = 1188,
                IlceAdi  = "Beyşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 573,
                SehirId  = 42,
                IlceKodu = 1207,
                IlceAdi  = "Bozkır",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 574,
                SehirId  = 42,
                IlceKodu = 1222,
                IlceAdi  = "Cihanbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 575,
                SehirId  = 42,
                IlceKodu = 1262,
                IlceAdi  = "Çumra",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 576,
                SehirId  = 42,
                IlceKodu = 1285,
                IlceAdi  = "Doğanhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 577,
                SehirId  = 42,
                IlceKodu = 1312,
                IlceAdi  = "Ereğli / Konya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 578,
                SehirId  = 42,
                IlceKodu = 1375,
                IlceAdi  = "Hadim",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 579,
                SehirId  = 42,
                IlceKodu = 1400,
                IlceAdi  = "Ilgın",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 580,
                SehirId  = 42,
                IlceKodu = 1422,
                IlceAdi  = "Kadınhanı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 581,
                SehirId  = 42,
                IlceKodu = 1441,
                IlceAdi  = "Karapınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 582,
                SehirId  = 42,
                IlceKodu = 1491,
                IlceAdi  = "Kulu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 583,
                SehirId  = 42,
                IlceKodu = 1598,
                IlceAdi  = "Sarayönü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 584,
                SehirId  = 42,
                IlceKodu = 1617,
                IlceAdi  = "Seydişehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 585,
                SehirId  = 42,
                IlceKodu = 1735,
                IlceAdi  = "Yunak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 586,
                SehirId  = 42,
                IlceKodu = 1753,
                IlceAdi  = "Akören",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 587,
                SehirId  = 42,
                IlceKodu = 1760,
                IlceAdi  = "Altınekin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 588,
                SehirId  = 42,
                IlceKodu = 1789,
                IlceAdi  = "Derebucak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 589,
                SehirId  = 42,
                IlceKodu = 1804,
                IlceAdi  = "Hüyük",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 590,
                SehirId  = 42,
                IlceKodu = 1814,
                IlceAdi  = "Karatay",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 591,
                SehirId  = 42,
                IlceKodu = 1827,
                IlceAdi  = "Meram",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 592,
                SehirId  = 42,
                IlceKodu = 1839,
                IlceAdi  = "Selçuklu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 593,
                SehirId  = 42,
                IlceKodu = 1848,
                IlceAdi  = "Taşkent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 594,
                SehirId  = 42,
                IlceKodu = 1868,
                IlceAdi  = "Ahırlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 595,
                SehirId  = 42,
                IlceKodu = 1902,
                IlceAdi  = "Çeltik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 596,
                SehirId  = 42,
                IlceKodu = 1907,
                IlceAdi  = "Derbent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 597,
                SehirId  = 42,
                IlceKodu = 1920,
                IlceAdi  = "Emirgazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 598,
                SehirId  = 42,
                IlceKodu = 1933,
                IlceAdi  = "Güneysınır",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 599,
                SehirId  = 42,
                IlceKodu = 1937,
                IlceAdi  = "Halkapınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 600,
                SehirId  = 42,
                IlceKodu = 1990,
                IlceAdi  = "Tuzlukçu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 601,
                SehirId  = 42,
                IlceKodu = 1994,
                IlceAdi  = "Yalıhüyük",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 602,
                SehirId  = 43,
                IlceKodu = 1132,
                IlceAdi  = "Altıntaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 603,
                SehirId  = 43,
                IlceKodu = 1288,
                IlceAdi  = "Domaniç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 604,
                SehirId  = 43,
                IlceKodu = 1304,
                IlceAdi  = "Emet",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 605,
                SehirId  = 43,
                IlceKodu = 1339,
                IlceAdi  = "Gediz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 606,
                SehirId  = 43,
                IlceKodu = 1500,
                IlceAdi  = "Kütahya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 607,
                SehirId  = 43,
                IlceKodu = 1625,
                IlceAdi  = "Simav",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 608,
                SehirId  = 43,
                IlceKodu = 1671,
                IlceAdi  = "Tavşanlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 609,
                SehirId  = 43,
                IlceKodu = 1764,
                IlceAdi  = "Aslanapa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 610,
                SehirId  = 43,
                IlceKodu = 1790,
                IlceAdi  = "Dumlupınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 611,
                SehirId  = 43,
                IlceKodu = 1802,
                IlceAdi  = "Hisarcık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 612,
                SehirId  = 43,
                IlceKodu = 1843,
                IlceAdi  = "Şaphane",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 613,
                SehirId  = 43,
                IlceKodu = 1898,
                IlceAdi  = "Çavdarhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 614,
                SehirId  = 43,
                IlceKodu = 1979,
                IlceAdi  = "Pazarlar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 615,
                SehirId  = 44,
                IlceKodu = 1114,
                IlceAdi  = "Akçadağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 616,
                SehirId  = 44,
                IlceKodu = 1143,
                IlceAdi  = "Arapgir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 617,
                SehirId  = 44,
                IlceKodu = 1148,
                IlceAdi  = "Arguvan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 618,
                SehirId  = 44,
                IlceKodu = 1265,
                IlceAdi  = "Darende",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 619,
                SehirId  = 44,
                IlceKodu = 1286,
                IlceAdi  = "Doğanşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 620,
                SehirId  = 44,
                IlceKodu = 1390,
                IlceAdi  = "Hekimhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 621,
                SehirId  = 44,
                IlceKodu = 1509,
                IlceAdi  = "Malatya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 622,
                SehirId  = 44,
                IlceKodu = 1582,
                IlceAdi  = "Pütürge",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 623,
                SehirId  = 44,
                IlceKodu = 1729,
                IlceAdi  = "Yeşilyurt / Malatya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 624,
                SehirId  = 44,
                IlceKodu = 1772,
                IlceAdi  = "Battalgazi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 625,
                SehirId  = 44,
                IlceKodu = 1914,
                IlceAdi  = "Doğanyol",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 626,
                SehirId  = 44,
                IlceKodu = 1953,
                IlceAdi  = "Kale / Malatya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 627,
                SehirId  = 44,
                IlceKodu = 1969,
                IlceAdi  = "Kuluncak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 628,
                SehirId  = 44,
                IlceKodu = 1995,
                IlceAdi  = "Yazıhan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 629,
                SehirId  = 45,
                IlceKodu = 1118,
                IlceAdi  = "Akhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 630,
                SehirId  = 45,
                IlceKodu = 1127,
                IlceAdi  = "Alaşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 631,
                SehirId  = 45,
                IlceKodu = 1269,
                IlceAdi  = "Demirci",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 632,
                SehirId  = 45,
                IlceKodu = 1362,
                IlceAdi  = "Gördes",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 633,
                SehirId  = 45,
                IlceKodu = 1470,
                IlceAdi  = "Kırkağaç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 634,
                SehirId  = 45,
                IlceKodu = 1489,
                IlceAdi  = "Kula",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 635,
                SehirId  = 45,
                IlceKodu = 1513,
                IlceAdi  = "Manisa Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 636,
                SehirId  = 45,
                IlceKodu = 1590,
                IlceAdi  = "Salihli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 637,
                SehirId  = 45,
                IlceKodu = 1600,
                IlceAdi  = "Sarıgöl",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 638,
                SehirId  = 45,
                IlceKodu = 1606,
                IlceAdi  = "Saruhanlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 639,
                SehirId  = 45,
                IlceKodu = 1613,
                IlceAdi  = "Selendi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 640,
                SehirId  = 45,
                IlceKodu = 1634,
                IlceAdi  = "Soma",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 641,
                SehirId  = 45,
                IlceKodu = 1689,
                IlceAdi  = "Turgutlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 642,
                SehirId  = 45,
                IlceKodu = 1751,
                IlceAdi  = "Ahmetli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 643,
                SehirId  = 45,
                IlceKodu = 1793,
                IlceAdi  = "Gölmarmara",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 644,
                SehirId  = 45,
                IlceKodu = 1965,
                IlceAdi  = "Köprübaşı / Manisa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 645,
                SehirId  = 45,
                IlceKodu = 2086,
                IlceAdi  = "Şehzadeler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 646,
                SehirId  = 45,
                IlceKodu = 2087,
                IlceAdi  = "Yunusemre",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 647,
                SehirId  = 46,
                IlceKodu = 1107,
                IlceAdi  = "Afşin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 648,
                SehirId  = 46,
                IlceKodu = 1136,
                IlceAdi  = "Andırın",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 649,
                SehirId  = 46,
                IlceKodu = 1299,
                IlceAdi  = "Elbistan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 650,
                SehirId  = 46,
                IlceKodu = 1353,
                IlceAdi  = "Göksun",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 651,
                SehirId  = 46,
                IlceKodu = 1515,
                IlceAdi  = "Kahramanmaraş Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 652,
                SehirId  = 46,
                IlceKodu = 1570,
                IlceAdi  = "Pazarcık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 653,
                SehirId  = 46,
                IlceKodu = 1694,
                IlceAdi  = "Türkoğlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 654,
                SehirId  = 46,
                IlceKodu = 1785,
                IlceAdi  = "Çağlayancerit",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 655,
                SehirId  = 46,
                IlceKodu = 1919,
                IlceAdi  = "Ekinözü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 656,
                SehirId  = 46,
                IlceKodu = 1975,
                IlceAdi  = "Nurhak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 657,
                SehirId  = 46,
                IlceKodu = 2084,
                IlceAdi  = "Dulkadiroğlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 658,
                SehirId  = 46,
                IlceKodu = 2085,
                IlceAdi  = "Onikişubat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 659,
                SehirId  = 47,
                IlceKodu = 1273,
                IlceAdi  = "Derik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 660,
                SehirId  = 47,
                IlceKodu = 1474,
                IlceAdi  = "Kızıltepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 661,
                SehirId  = 47,
                IlceKodu = 1516,
                IlceAdi  = "Mardin Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 662,
                SehirId  = 47,
                IlceKodu = 1519,
                IlceAdi  = "Mazıdağı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 663,
                SehirId  = 47,
                IlceKodu = 1526,
                IlceAdi  = "Midyat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 664,
                SehirId  = 47,
                IlceKodu = 1547,
                IlceAdi  = "Nusaybin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 665,
                SehirId  = 47,
                IlceKodu = 1564,
                IlceAdi  = "Ömerli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 666,
                SehirId  = 47,
                IlceKodu = 1609,
                IlceAdi  = "Savur",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 667,
                SehirId  = 47,
                IlceKodu = 1787,
                IlceAdi  = "Dargeçit",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 668,
                SehirId  = 47,
                IlceKodu = 2002,
                IlceAdi  = "Yeşilli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 669,
                SehirId  = 47,
                IlceKodu = 2088,
                IlceAdi  = "Artuklu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 670,
                SehirId  = 48,
                IlceKodu = 1197,
                IlceAdi  = "Bodrum",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 671,
                SehirId  = 48,
                IlceKodu = 1266,
                IlceAdi  = "Datça",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 672,
                SehirId  = 48,
                IlceKodu = 1331,
                IlceAdi  = "Fethiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 673,
                SehirId  = 48,
                IlceKodu = 1488,
                IlceAdi  = "Köyceğiz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 674,
                SehirId  = 48,
                IlceKodu = 1517,
                IlceAdi  = "Marmaris",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 675,
                SehirId  = 48,
                IlceKodu = 1528,
                IlceAdi  = "Milas",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 676,
                SehirId  = 48,
                IlceKodu = 1532,
                IlceAdi  = "Muğla Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 677,
                SehirId  = 48,
                IlceKodu = 1695,
                IlceAdi  = "Ula",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 678,
                SehirId  = 48,
                IlceKodu = 1719,
                IlceAdi  = "Yatağan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 679,
                SehirId  = 48,
                IlceKodu = 1742,
                IlceAdi  = "Dalaman",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 680,
                SehirId  = 48,
                IlceKodu = 1831,
                IlceAdi  = "Ortaca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 681,
                SehirId  = 48,
                IlceKodu = 1958,
                IlceAdi  = "Kavaklıdere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 682,
                SehirId  = 48,
                IlceKodu = 2089,
                IlceAdi  = "Menteşe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 683,
                SehirId  = 48,
                IlceKodu = 2090,
                IlceAdi  = "Seydikemer",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 684,
                SehirId  = 49,
                IlceKodu = 1213,
                IlceAdi  = "Bulanık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 685,
                SehirId  = 49,
                IlceKodu = 1510,
                IlceAdi  = "Malazgirt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 686,
                SehirId  = 49,
                IlceKodu = 1534,
                IlceAdi  = "Muş Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 687,
                SehirId  = 49,
                IlceKodu = 1711,
                IlceAdi  = "Varto",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 688,
                SehirId  = 49,
                IlceKodu = 1801,
                IlceAdi  = "Hasköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 689,
                SehirId  = 49,
                IlceKodu = 1964,
                IlceAdi  = "Korkut",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 690,
                SehirId  = 50,
                IlceKodu = 1155,
                IlceAdi  = "Avanos",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 691,
                SehirId  = 50,
                IlceKodu = 1274,
                IlceAdi  = "Derinkuyu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 692,
                SehirId  = 50,
                IlceKodu = 1367,
                IlceAdi  = "Gülşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 693,
                SehirId  = 50,
                IlceKodu = 1374,
                IlceAdi  = "Hacıbektaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 694,
                SehirId  = 50,
                IlceKodu = 1485,
                IlceAdi  = "Kozaklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 695,
                SehirId  = 50,
                IlceKodu = 1543,
                IlceAdi  = "Nevşehir Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 696,
                SehirId  = 50,
                IlceKodu = 1707,
                IlceAdi  = "Ürgüp",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 697,
                SehirId  = 50,
                IlceKodu = 1749,
                IlceAdi  = "Acıgöl",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 698,
                SehirId  = 51,
                IlceKodu = 1201,
                IlceAdi  = "Bor",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 699,
                SehirId  = 51,
                IlceKodu = 1225,
                IlceAdi  = "Çamardı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 700,
                SehirId  = 51,
                IlceKodu = 1544,
                IlceAdi  = "Niğde Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 701,
                SehirId  = 51,
                IlceKodu = 1700,
                IlceAdi  = "Ulukışla",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 702,
                SehirId  = 51,
                IlceKodu = 1876,
                IlceAdi  = "Altunhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 703,
                SehirId  = 51,
                IlceKodu = 1904,
                IlceAdi  = "Çiftlik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 704,
                SehirId  = 52,
                IlceKodu = 1119,
                IlceAdi  = "Akkuş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 705,
                SehirId  = 52,
                IlceKodu = 1158,
                IlceAdi  = "Aybastı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 706,
                SehirId  = 52,
                IlceKodu = 1328,
                IlceAdi  = "Fatsa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 707,
                SehirId  = 52,
                IlceKodu = 1358,
                IlceAdi  = "Gölköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 708,
                SehirId  = 52,
                IlceKodu = 1482,
                IlceAdi  = "Korgan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 709,
                SehirId  = 52,
                IlceKodu = 1493,
                IlceAdi  = "Kumru",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 710,
                SehirId  = 52,
                IlceKodu = 1525,
                IlceAdi  = "Mesudiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 711,
                SehirId  = 52,
                IlceKodu = 1552,
                IlceAdi  = "Ordu Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 712,
                SehirId  = 52,
                IlceKodu = 1573,
                IlceAdi  = "Perşembe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 713,
                SehirId  = 52,
                IlceKodu = 1696,
                IlceAdi  = "Ulubey / Ordu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 714,
                SehirId  = 52,
                IlceKodu = 1706,
                IlceAdi  = "Ünye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 715,
                SehirId  = 52,
                IlceKodu = 1795,
                IlceAdi  = "Gülyalı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 716,
                SehirId  = 52,
                IlceKodu = 1797,
                IlceAdi  = "Gürgentepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 717,
                SehirId  = 52,
                IlceKodu = 1891,
                IlceAdi  = "Çamaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 718,
                SehirId  = 52,
                IlceKodu = 1897,
                IlceAdi  = "Çatalpınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 719,
                SehirId  = 52,
                IlceKodu = 1900,
                IlceAdi  = "Çaybaşı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 720,
                SehirId  = 52,
                IlceKodu = 1947,
                IlceAdi  = "İkizce",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 721,
                SehirId  = 52,
                IlceKodu = 1950,
                IlceAdi  = "Kabadüz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 722,
                SehirId  = 52,
                IlceKodu = 1951,
                IlceAdi  = "Kabataş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 723,
                SehirId  = 52,
                IlceKodu = 2103,
                IlceAdi  = "Altınordu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 724,
                SehirId  = 53,
                IlceKodu = 1146,
                IlceAdi  = "Ardeşen",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 725,
                SehirId  = 53,
                IlceKodu = 1228,
                IlceAdi  = "Çamlıhemşin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 726,
                SehirId  = 53,
                IlceKodu = 1241,
                IlceAdi  = "Çayeli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 727,
                SehirId  = 53,
                IlceKodu = 1332,
                IlceAdi  = "Fındıklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 728,
                SehirId  = 53,
                IlceKodu = 1405,
                IlceAdi  = "İkizdere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 729,
                SehirId  = 53,
                IlceKodu = 1428,
                IlceAdi  = "Kalkandere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 730,
                SehirId  = 53,
                IlceKodu = 1569,
                IlceAdi  = "Pazar / Rize",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 731,
                SehirId  = 53,
                IlceKodu = 1586,
                IlceAdi  = "Rize Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 732,
                SehirId  = 53,
                IlceKodu = 1796,
                IlceAdi  = "Güneysu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 733,
                SehirId  = 53,
                IlceKodu = 1908,
                IlceAdi  = "Derepazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 734,
                SehirId  = 53,
                IlceKodu = 1943,
                IlceAdi  = "Hemşin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 735,
                SehirId  = 53,
                IlceKodu = 1949,
                IlceAdi  = "İyidere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 736,
                SehirId  = 54,
                IlceKodu = 1123,
                IlceAdi  = "Akyazı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 737,
                SehirId  = 54,
                IlceKodu = 1351,
                IlceAdi  = "Geyve",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 738,
                SehirId  = 54,
                IlceKodu = 1391,
                IlceAdi  = "Hendek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 739,
                SehirId  = 54,
                IlceKodu = 1442,
                IlceAdi  = "Karasu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 740,
                SehirId  = 54,
                IlceKodu = 1453,
                IlceAdi  = "Kaynarca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 741,
                SehirId  = 54,
                IlceKodu = 1589,
                IlceAdi  = "Sakarya Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 742,
                SehirId  = 54,
                IlceKodu = 1595,
                IlceAdi  = "Sapanca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 743,
                SehirId  = 54,
                IlceKodu = 1818,
                IlceAdi  = "Kocaali",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 744,
                SehirId  = 54,
                IlceKodu = 1833,
                IlceAdi  = "Pamukova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 745,
                SehirId  = 54,
                IlceKodu = 1847,
                IlceAdi  = "Taraklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 746,
                SehirId  = 54,
                IlceKodu = 1925,
                IlceAdi  = "Ferizli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 747,
                SehirId  = 54,
                IlceKodu = 1955,
                IlceAdi  = "Karapürçek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 748,
                SehirId  = 54,
                IlceKodu = 1986,
                IlceAdi  = "Söğütlü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 749,
                SehirId  = 54,
                IlceKodu = 2068,
                IlceAdi  = "Adapazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 750,
                SehirId  = 54,
                IlceKodu = 2069,
                IlceAdi  = "Arifiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 751,
                SehirId  = 54,
                IlceKodu = 2070,
                IlceAdi  = "Erenler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 752,
                SehirId  = 54,
                IlceKodu = 2071,
                IlceAdi  = "Serdivan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 753,
                SehirId  = 55,
                IlceKodu = 1125,
                IlceAdi  = "Alaçam",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 754,
                SehirId  = 55,
                IlceKodu = 1164,
                IlceAdi  = "Bafra",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 755,
                SehirId  = 55,
                IlceKodu = 1234,
                IlceAdi  = "Çarşamba",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 756,
                SehirId  = 55,
                IlceKodu = 1386,
                IlceAdi  = "Havza",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 757,
                SehirId  = 55,
                IlceKodu = 1452,
                IlceAdi  = "Kavak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 758,
                SehirId  = 55,
                IlceKodu = 1501,
                IlceAdi  = "Ladik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 759,
                SehirId  = 55,
                IlceKodu = 1593,
                IlceAdi  = "Samsun Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 760,
                SehirId  = 55,
                IlceKodu = 1676,
                IlceAdi  = "Terme",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 761,
                SehirId  = 55,
                IlceKodu = 1712,
                IlceAdi  = "Vezirköprü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 762,
                SehirId  = 55,
                IlceKodu = 1763,
                IlceAdi  = "Asarcık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 763,
                SehirId  = 55,
                IlceKodu = 1830,
                IlceAdi  = "19 Mayıs",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 764,
                SehirId  = 55,
                IlceKodu = 1838,
                IlceAdi  = "Salıpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 765,
                SehirId  = 55,
                IlceKodu = 1849,
                IlceAdi  = "Tekkeköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 766,
                SehirId  = 55,
                IlceKodu = 1879,
                IlceAdi  = "Ayvacık / Samsun",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 767,
                SehirId  = 55,
                IlceKodu = 1993,
                IlceAdi  = "Yakakent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 768,
                SehirId  = 55,
                IlceKodu = 2072,
                IlceAdi  = "Atakum",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 769,
                SehirId  = 55,
                IlceKodu = 2073,
                IlceAdi  = "Canik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 770,
                SehirId  = 55,
                IlceKodu = 2074,
                IlceAdi  = "İlkadım",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 771,
                SehirId  = 56,
                IlceKodu = 1179,
                IlceAdi  = "Baykan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 772,
                SehirId  = 56,
                IlceKodu = 1317,
                IlceAdi  = "Eruh",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 773,
                SehirId  = 56,
                IlceKodu = 1495,
                IlceAdi  = "Kurtalan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 774,
                SehirId  = 56,
                IlceKodu = 1575,
                IlceAdi  = "Pervari",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 775,
                SehirId  = 56,
                IlceKodu = 1620,
                IlceAdi  = "Siirt Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 776,
                SehirId  = 56,
                IlceKodu = 1662,
                IlceAdi  = "Şirvan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 777,
                SehirId  = 56,
                IlceKodu = 1878,
                IlceAdi  = "Tillo",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 778,
                SehirId  = 57,
                IlceKodu = 1156,
                IlceAdi  = "Ayancık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 779,
                SehirId  = 57,
                IlceKodu = 1204,
                IlceAdi  = "Boyabat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 780,
                SehirId  = 57,
                IlceKodu = 1290,
                IlceAdi  = "Durağan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 781,
                SehirId  = 57,
                IlceKodu = 1314,
                IlceAdi  = "Erfelek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 782,
                SehirId  = 57,
                IlceKodu = 1349,
                IlceAdi  = "Gerze",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 783,
                SehirId  = 57,
                IlceKodu = 1627,
                IlceAdi  = "Sinop Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 784,
                SehirId  = 57,
                IlceKodu = 1693,
                IlceAdi  = "Türkeli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 785,
                SehirId  = 57,
                IlceKodu = 1910,
                IlceAdi  = "Dikmen",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 786,
                SehirId  = 57,
                IlceKodu = 1981,
                IlceAdi  = "Saraydüzü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 787,
                SehirId  = 58,
                IlceKodu = 1282,
                IlceAdi  = "Divriği",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 788,
                SehirId  = 58,
                IlceKodu = 1342,
                IlceAdi  = "Gemerek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 789,
                SehirId  = 58,
                IlceKodu = 1373,
                IlceAdi  = "Gürün",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 790,
                SehirId  = 58,
                IlceKodu = 1376,
                IlceAdi  = "Hafik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 791,
                SehirId  = 58,
                IlceKodu = 1407,
                IlceAdi  = "İmranlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 792,
                SehirId  = 58,
                IlceKodu = 1431,
                IlceAdi  = "Kangal",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 793,
                SehirId  = 58,
                IlceKodu = 1484,
                IlceAdi  = "Koyulhisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 794,
                SehirId  = 58,
                IlceKodu = 1628,
                IlceAdi  = "Sivas Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 795,
                SehirId  = 58,
                IlceKodu = 1646,
                IlceAdi  = "Suşehri",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 796,
                SehirId  = 58,
                IlceKodu = 1650,
                IlceAdi  = "Şarkışla",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 797,
                SehirId  = 58,
                IlceKodu = 1731,
                IlceAdi  = "Yıldızeli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 798,
                SehirId  = 58,
                IlceKodu = 1738,
                IlceAdi  = "Zara",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 799,
                SehirId  = 58,
                IlceKodu = 1870,
                IlceAdi  = "Akıncılar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 800,
                SehirId  = 58,
                IlceKodu = 1875,
                IlceAdi  = "Altınyayla / Sivas",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 801,
                SehirId  = 58,
                IlceKodu = 1913,
                IlceAdi  = "Doğanşar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 802,
                SehirId  = 58,
                IlceKodu = 1927,
                IlceAdi  = "Gölova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 803,
                SehirId  = 58,
                IlceKodu = 1991,
                IlceAdi  = "Ulaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 804,
                SehirId  = 59,
                IlceKodu = 1250,
                IlceAdi  = "Çerkezköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 805,
                SehirId  = 59,
                IlceKodu = 1258,
                IlceAdi  = "Çorlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 806,
                SehirId  = 59,
                IlceKodu = 1388,
                IlceAdi  = "Hayrabolu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 807,
                SehirId  = 59,
                IlceKodu = 1511,
                IlceAdi  = "Malkara",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 808,
                SehirId  = 59,
                IlceKodu = 1538,
                IlceAdi  = "Muratlı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 809,
                SehirId  = 59,
                IlceKodu = 1596,
                IlceAdi  = "Saray / Tekirdağ",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 810,
                SehirId  = 59,
                IlceKodu = 1652,
                IlceAdi  = "Şarköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 811,
                SehirId  = 59,
                IlceKodu = 1673,
                IlceAdi  = "Tekirdağ Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 812,
                SehirId  = 59,
                IlceKodu = 1825,
                IlceAdi  = "Marmaraereğlisi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 813,
                SehirId  = 59,
                IlceKodu = 2094,
                IlceAdi  = "Ergene",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 814,
                SehirId  = 59,
                IlceKodu = 2095,
                IlceAdi  = "Kapaklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 815,
                SehirId  = 59,
                IlceKodu = 2096,
                IlceAdi  = "Süleymanpaşa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 816,
                SehirId  = 60,
                IlceKodu = 1129,
                IlceAdi  = "Almus",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 817,
                SehirId  = 60,
                IlceKodu = 1151,
                IlceAdi  = "Artova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 818,
                SehirId  = 60,
                IlceKodu = 1308,
                IlceAdi  = "Erbaa",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 819,
                SehirId  = 60,
                IlceKodu = 1545,
                IlceAdi  = "Niksar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 820,
                SehirId  = 60,
                IlceKodu = 1584,
                IlceAdi  = "Reşadiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 821,
                SehirId  = 60,
                IlceKodu = 1679,
                IlceAdi  = "Tokat Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 822,
                SehirId  = 60,
                IlceKodu = 1690,
                IlceAdi  = "Turhal",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 823,
                SehirId  = 60,
                IlceKodu = 1740,
                IlceAdi  = "Zile",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 824,
                SehirId  = 60,
                IlceKodu = 1834,
                IlceAdi  = "Pazar / Tokat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 825,
                SehirId  = 60,
                IlceKodu = 1858,
                IlceAdi  = "Yeşilyurt / Tokat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 826,
                SehirId  = 60,
                IlceKodu = 1883,
                IlceAdi  = "Başçiftlik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 827,
                SehirId  = 60,
                IlceKodu = 1987,
                IlceAdi  = "Sulusaray",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 828,
                SehirId  = 61,
                IlceKodu = 1113,
                IlceAdi  = "Akçaabat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 829,
                SehirId  = 61,
                IlceKodu = 1141,
                IlceAdi  = "Araklı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 830,
                SehirId  = 61,
                IlceKodu = 1150,
                IlceAdi  = "Arsin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 831,
                SehirId  = 61,
                IlceKodu = 1244,
                IlceAdi  = "Çaykara",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 832,
                SehirId  = 61,
                IlceKodu = 1507,
                IlceAdi  = "Maçka",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 833,
                SehirId  = 61,
                IlceKodu = 1548,
                IlceAdi  = "Of",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 834,
                SehirId  = 61,
                IlceKodu = 1647,
                IlceAdi  = "Sürmene",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 835,
                SehirId  = 61,
                IlceKodu = 1681,
                IlceAdi  = "Tonya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 836,
                SehirId  = 61,
                IlceKodu = 1686,
                IlceAdi  = "Trabzon Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 837,
                SehirId  = 61,
                IlceKodu = 1709,
                IlceAdi  = "Vakfıkebir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 838,
                SehirId  = 61,
                IlceKodu = 1732,
                IlceAdi  = "Yomra",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 839,
                SehirId  = 61,
                IlceKodu = 1775,
                IlceAdi  = "Beşikdüzü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 840,
                SehirId  = 61,
                IlceKodu = 1842,
                IlceAdi  = "Şalpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 841,
                SehirId  = 61,
                IlceKodu = 1896,
                IlceAdi  = "Çarşıbaşı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 842,
                SehirId  = 61,
                IlceKodu = 1909,
                IlceAdi  = "Dernekpazarı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 843,
                SehirId  = 61,
                IlceKodu = 1917,
                IlceAdi  = "Düzköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 844,
                SehirId  = 61,
                IlceKodu = 1942,
                IlceAdi  = "Hayrat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 845,
                SehirId  = 61,
                IlceKodu = 1966,
                IlceAdi  = "Köprübaşı / Trabzon",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 846,
                SehirId  = 61,
                IlceKodu = 2097,
                IlceAdi  = "Ortahisar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 847,
                SehirId  = 62,
                IlceKodu = 1247,
                IlceAdi  = "Çemişgezek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 848,
                SehirId  = 62,
                IlceKodu = 1397,
                IlceAdi  = "Hozat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 849,
                SehirId  = 62,
                IlceKodu = 1518,
                IlceAdi  = "Mazgirt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 850,
                SehirId  = 62,
                IlceKodu = 1541,
                IlceAdi  = "Nazımiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 851,
                SehirId  = 62,
                IlceKodu = 1562,
                IlceAdi  = "Ovacık / Tunceli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 852,
                SehirId  = 62,
                IlceKodu = 1574,
                IlceAdi  = "Pertek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 853,
                SehirId  = 62,
                IlceKodu = 1581,
                IlceAdi  = "Pülümür",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 854,
                SehirId  = 62,
                IlceKodu = 1688,
                IlceAdi  = "Tunceli Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 855,
                SehirId  = 63,
                IlceKodu = 1115,
                IlceAdi  = "Akçakale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 856,
                SehirId  = 63,
                IlceKodu = 1194,
                IlceAdi  = "Birecik",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 857,
                SehirId  = 63,
                IlceKodu = 1209,
                IlceAdi  = "Bozova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 858,
                SehirId  = 63,
                IlceKodu = 1220,
                IlceAdi  = "Ceylanpınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 859,
                SehirId  = 63,
                IlceKodu = 1378,
                IlceAdi  = "Halfeti",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 860,
                SehirId  = 63,
                IlceKodu = 1393,
                IlceAdi  = "Hilvan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 861,
                SehirId  = 63,
                IlceKodu = 1630,
                IlceAdi  = "Siverek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 862,
                SehirId  = 63,
                IlceKodu = 1643,
                IlceAdi  = "Suruç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 863,
                SehirId  = 63,
                IlceKodu = 1702,
                IlceAdi  = "Şanlıurfa Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 864,
                SehirId  = 63,
                IlceKodu = 1713,
                IlceAdi  = "Viranşehir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 865,
                SehirId  = 63,
                IlceKodu = 1800,
                IlceAdi  = "Harran",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 866,
                SehirId  = 63,
                IlceKodu = 2091,
                IlceAdi  = "Eyyübiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 867,
                SehirId  = 63,
                IlceKodu = 2092,
                IlceAdi  = "Haliliye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 868,
                SehirId  = 63,
                IlceKodu = 2093,
                IlceAdi  = "Karaköprü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 869,
                SehirId  = 64,
                IlceKodu = 1170,
                IlceAdi  = "Banaz",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 870,
                SehirId  = 64,
                IlceKodu = 1323,
                IlceAdi  = "Eşme",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 871,
                SehirId  = 64,
                IlceKodu = 1436,
                IlceAdi  = "Karahallı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 872,
                SehirId  = 64,
                IlceKodu = 1629,
                IlceAdi  = "Sivaslı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 873,
                SehirId  = 64,
                IlceKodu = 1697,
                IlceAdi  = "Ulubey / Uşak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 874,
                SehirId  = 64,
                IlceKodu = 1704,
                IlceAdi  = "Uşak Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 875,
                SehirId  = 65,
                IlceKodu = 1175,
                IlceAdi  = "Başkale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 876,
                SehirId  = 65,
                IlceKodu = 1236,
                IlceAdi  = "Çatak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 877,
                SehirId  = 65,
                IlceKodu = 1309,
                IlceAdi  = "Erciş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 878,
                SehirId  = 65,
                IlceKodu = 1350,
                IlceAdi  = "Gevaş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 879,
                SehirId  = 65,
                IlceKodu = 1372,
                IlceAdi  = "Gürpınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 880,
                SehirId  = 65,
                IlceKodu = 1533,
                IlceAdi  = "Muradiye",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 881,
                SehirId  = 65,
                IlceKodu = 1565,
                IlceAdi  = "Ceylanpınar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 882,
                SehirId  = 65,
                IlceKodu = 1710,
                IlceAdi  = "Van Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 883,
                SehirId  = 65,
                IlceKodu = 1770,
                IlceAdi  = "Bahçesaray",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 884,
                SehirId  = 65,
                IlceKodu = 1786,
                IlceAdi  = "Çaldıran",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 885,
                SehirId  = 65,
                IlceKodu = 1918,
                IlceAdi  = "Edremit / Van",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 886,
                SehirId  = 65,
                IlceKodu = 1980,
                IlceAdi  = "Saray / Van",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 887,
                SehirId  = 65,
                IlceKodu = 2098,
                IlceAdi  = "İpekyolu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 888,
                SehirId  = 65,
                IlceKodu = 2099,
                IlceAdi  = "Tuşba",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 889,
                SehirId  = 66,
                IlceKodu = 1117,
                IlceAdi  = "Akdağmadeni",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 890,
                SehirId  = 66,
                IlceKodu = 1198,
                IlceAdi  = "Boğazlıyan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 891,
                SehirId  = 66,
                IlceKodu = 1242,
                IlceAdi  = "Çayıralan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 892,
                SehirId  = 66,
                IlceKodu = 1245,
                IlceAdi  = "Çekerek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 893,
                SehirId  = 66,
                IlceKodu = 1602,
                IlceAdi  = "Sarıkaya",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 894,
                SehirId  = 66,
                IlceKodu = 1635,
                IlceAdi  = "Sorgun",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 895,
                SehirId  = 66,
                IlceKodu = 1655,
                IlceAdi  = "Şefaatli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 896,
                SehirId  = 66,
                IlceKodu = 1726,
                IlceAdi  = "Yerköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 897,
                SehirId  = 66,
                IlceKodu = 1733,
                IlceAdi  = "Yozgat Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 898,
                SehirId  = 66,
                IlceKodu = 1877,
                IlceAdi  = "Aydıncık / Yozgat",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 899,
                SehirId  = 66,
                IlceKodu = 1895,
                IlceAdi  = "Çandır",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 900,
                SehirId  = 66,
                IlceKodu = 1952,
                IlceAdi  = "Kadışehri",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 901,
                SehirId  = 66,
                IlceKodu = 1982,
                IlceAdi  = "Saraykent",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 902,
                SehirId  = 66,
                IlceKodu = 1998,
                IlceAdi  = "Yenifakılı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 903,
                SehirId  = 67,
                IlceKodu = 1240,
                IlceAdi  = "Çaycuma",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 904,
                SehirId  = 67,
                IlceKodu = 1276,
                IlceAdi  = "Devrek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 905,
                SehirId  = 67,
                IlceKodu = 1313,
                IlceAdi  = "Ereğli / Zonguldak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 906,
                SehirId  = 67,
                IlceKodu = 1741,
                IlceAdi  = "Zonguldak Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 907,
                SehirId  = 67,
                IlceKodu = 1758,
                IlceAdi  = "Alaplı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 908,
                SehirId  = 67,
                IlceKodu = 1926,
                IlceAdi  = "Gökçebey",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 909,
                SehirId  = 67,
                IlceKodu = 2100,
                IlceAdi  = "Kilimli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 910,
                SehirId  = 67,
                IlceKodu = 2101,
                IlceAdi  = "Kozlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 911,
                SehirId  = 68,
                IlceKodu = 1120,
                IlceAdi  = "Aksaray Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 912,
                SehirId  = 68,
                IlceKodu = 1557,
                IlceAdi  = "Ortaköy / Aksaray",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 913,
                SehirId  = 68,
                IlceKodu = 1860,
                IlceAdi  = "Ağaçören",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 914,
                SehirId  = 68,
                IlceKodu = 1861,
                IlceAdi  = "Güzelyurt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 915,
                SehirId  = 68,
                IlceKodu = 1866,
                IlceAdi  = "Sarıyahşi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 916,
                SehirId  = 68,
                IlceKodu = 1921,
                IlceAdi  = "Eskil",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 917,
                SehirId  = 68,
                IlceKodu = 1932,
                IlceAdi  = "Gülağaç",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 918,
                SehirId  = 69,
                IlceKodu = 1176,
                IlceAdi  = "Bayburt Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 919,
                SehirId  = 69,
                IlceKodu = 1767,
                IlceAdi  = "Aydıntepe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 920,
                SehirId  = 69,
                IlceKodu = 1788,
                IlceAdi  = "Demirözü",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 921,
                SehirId  = 70,
                IlceKodu = 1316,
                IlceAdi  = "Ermenek",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 922,
                SehirId  = 70,
                IlceKodu = 1439,
                IlceAdi  = "Karaman Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 923,
                SehirId  = 70,
                IlceKodu = 1768,
                IlceAdi  = "Ayrancı",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 924,
                SehirId  = 70,
                IlceKodu = 1862,
                IlceAdi  = "Kazımkarabekir",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 925,
                SehirId  = 70,
                IlceKodu = 1884,
                IlceAdi  = "Başyayla",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 926,
                SehirId  = 70,
                IlceKodu = 1983,
                IlceAdi  = "Sarıveliler",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 927,
                SehirId  = 71,
                IlceKodu = 1268,
                IlceAdi  = "Delice",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 928,
                SehirId  = 71,
                IlceKodu = 1463,
                IlceAdi  = "Keskin",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 929,
                SehirId  = 71,
                IlceKodu = 1469,
                IlceAdi  = "Kırıkkale Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 930,
                SehirId  = 71,
                IlceKodu = 1638,
                IlceAdi  = "Sulakyurt",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 931,
                SehirId  = 71,
                IlceKodu = 1880,
                IlceAdi  = "Bahşili",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 932,
                SehirId  = 71,
                IlceKodu = 1882,
                IlceAdi  = "Balışeyh",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 933,
                SehirId  = 71,
                IlceKodu = 1901,
                IlceAdi  = "Çelebi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 934,
                SehirId  = 71,
                IlceKodu = 1954,
                IlceAdi  = "Karakeçili",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 935,
                SehirId  = 71,
                IlceKodu = 1992,
                IlceAdi  = "Yahşihan",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 936,
                SehirId  = 72,
                IlceKodu = 1174,
                IlceAdi  = "Batman Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 937,
                SehirId  = 72,
                IlceKodu = 1184,
                IlceAdi  = "Beşiri",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 938,
                SehirId  = 72,
                IlceKodu = 1345,
                IlceAdi  = "Gercüş",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 939,
                SehirId  = 72,
                IlceKodu = 1487,
                IlceAdi  = "Kozluk",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 940,
                SehirId  = 72,
                IlceKodu = 1607,
                IlceAdi  = "Sason",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 941,
                SehirId  = 72,
                IlceKodu = 1941,
                IlceAdi  = "Hasankeyf",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 942,
                SehirId  = 73,
                IlceKodu = 1189,
                IlceAdi  = "Beytüşşebap",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 943,
                SehirId  = 73,
                IlceKodu = 1223,
                IlceAdi  = "Cizre",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 944,
                SehirId  = 73,
                IlceKodu = 1403,
                IlceAdi  = "İdil",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 945,
                SehirId  = 73,
                IlceKodu = 1623,
                IlceAdi  = "Silopi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 946,
                SehirId  = 73,
                IlceKodu = 1661,
                IlceAdi  = "Şırnak Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 947,
                SehirId  = 73,
                IlceKodu = 1698,
                IlceAdi  = "Uludere",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 948,
                SehirId  = 73,
                IlceKodu = 1931,
                IlceAdi  = "Güçlükonak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 949,
                SehirId  = 74,
                IlceKodu = 1172,
                IlceAdi  = "Bartın Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 950,
                SehirId  = 74,
                IlceKodu = 1496,
                IlceAdi  = "Kurucaşile",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 951,
                SehirId  = 74,
                IlceKodu = 1701,
                IlceAdi  = "Ulus",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 952,
                SehirId  = 74,
                IlceKodu = 1761,
                IlceAdi  = "Amasra",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 953,
                SehirId  = 75,
                IlceKodu = 1144,
                IlceAdi  = "Ardahan Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 954,
                SehirId  = 75,
                IlceKodu = 1252,
                IlceAdi  = "Çıldır",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 955,
                SehirId  = 75,
                IlceKodu = 1356,
                IlceAdi  = "Göle",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 956,
                SehirId  = 75,
                IlceKodu = 1380,
                IlceAdi  = "Hanak",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 957,
                SehirId  = 75,
                IlceKodu = 1579,
                IlceAdi  = "Posof",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 958,
                SehirId  = 75,
                IlceKodu = 2008,
                IlceAdi  = "Damal",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 959,
                SehirId  = 76,
                IlceKodu = 1142,
                IlceAdi  = "Aralık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 960,
                SehirId  = 76,
                IlceKodu = 1398,
                IlceAdi  = "Iğdır Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 961,
                SehirId  = 76,
                IlceKodu = 1692,
                IlceAdi  = "Tuzluca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 962,
                SehirId  = 76,
                IlceKodu = 2011,
                IlceAdi  = "Karakoyunlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 963,
                SehirId  = 77,
                IlceKodu = 1716,
                IlceAdi  = "Yalova Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 964,
                SehirId  = 77,
                IlceKodu = 2019,
                IlceAdi  = "Altınova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 965,
                SehirId  = 77,
                IlceKodu = 2020,
                IlceAdi  = "Armutlu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 966,
                SehirId  = 77,
                IlceKodu = 2021,
                IlceAdi  = "Çınarcık",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 967,
                SehirId  = 77,
                IlceKodu = 2022,
                IlceAdi  = "Çiftlikköy",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 968,
                SehirId  = 77,
                IlceKodu = 2026,
                IlceAdi  = "Termal",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 969,
                SehirId  = 78,
                IlceKodu = 1296,
                IlceAdi  = "Eflani",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 970,
                SehirId  = 78,
                IlceKodu = 1321,
                IlceAdi  = "Eskipazar",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 971,
                SehirId  = 78,
                IlceKodu = 1433,
                IlceAdi  = "Karabük Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 972,
                SehirId  = 78,
                IlceKodu = 1561,
                IlceAdi  = "Ovacık / Karabük",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 973,
                SehirId  = 78,
                IlceKodu = 1587,
                IlceAdi  = "Safranbolu",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 974,
                SehirId  = 78,
                IlceKodu = 1856,
                IlceAdi  = "Yenice / Karabük",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 975,
                SehirId  = 79,
                IlceKodu = 1476,
                IlceAdi  = "Kilis Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 976,
                SehirId  = 79,
                IlceKodu = 2023,
                IlceAdi  = "Elbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 977,
                SehirId  = 79,
                IlceKodu = 2024,
                IlceAdi  = "Musabeyli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 978,
                SehirId  = 79,
                IlceKodu = 2025,
                IlceAdi  = "Polateli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 979,
                SehirId  = 80,
                IlceKodu = 1165,
                IlceAdi  = "Bahçe",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 980,
                SehirId  = 80,
                IlceKodu = 1423,
                IlceAdi  = "Kadirli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 981,
                SehirId  = 80,
                IlceKodu = 1560,
                IlceAdi  = "Osmaniye Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 982,
                SehirId  = 80,
                IlceKodu = 1743,
                IlceAdi  = "Düziçi",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 983,
                SehirId  = 80,
                IlceKodu = 2027,
                IlceAdi  = "Hasanbeyli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 984,
                SehirId  = 80,
                IlceKodu = 2028,
                IlceAdi  = "Sumbas",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 985,
                SehirId  = 80,
                IlceKodu = 2029,
                IlceAdi  = "Toprakkale",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 986,
                SehirId  = 81,
                IlceKodu = 1116,
                IlceAdi  = "Akçakoca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 987,
                SehirId  = 81,
                IlceKodu = 1292,
                IlceAdi  = "Düzce Merkez",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 988,
                SehirId  = 81,
                IlceKodu = 1730,
                IlceAdi  = "Yığılca",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 989,
                SehirId  = 81,
                IlceKodu = 1784,
                IlceAdi  = "Cumayeri",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 990,
                SehirId  = 81,
                IlceKodu = 1794,
                IlceAdi  = "Gölyaka",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 991,
                SehirId  = 81,
                IlceKodu = 1905,
                IlceAdi  = "Çilimli",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 992,
                SehirId  = 81,
                IlceKodu = 2017,
                IlceAdi  = "Gümüşova",
                DurumId  = 1
                },
                new Ilce
                {
                IlceId   = 993,
                SehirId  = 81,
                IlceKodu = 2031,
                IlceAdi  = "Kaynaşlı",
                DurumId  = 1
                }
            });            
            #endregion
          
            #region //ParaBirimi
            context.ParaBirimleri.AddRange(new List<ParaBirimi>
            {
                new ParaBirimi
                {
                    ParaBirimiId = 1,
                    Kodu = "TL",
                    Cinsi = "Türk Lirası",                    
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 2,
                    Kodu = "USD",
                    Cinsi = "ABD Doları",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 3,
                    Kodu = "AUD",
                    Cinsi = "Avusturalya Doları",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 4,
                    Kodu = "DKK",
                    Cinsi = "Danimarka Kronu",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 5,
                    Kodu = "EUR",
                    Cinsi = "EURO",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 6,
                    Kodu = "GBP",
                    Cinsi = "İngiliz Sterlini",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 7,
                    Kodu = "CHF",
                    Cinsi = "İsviçre Frangı",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 8,
                    Kodu = "SEK",
                    Cinsi = "İsveç Kronu",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 9,
                    Kodu = "CAD",
                    Cinsi = "Kanada Doları",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 10,
                    Kodu = "KWD",
                    Cinsi = "Kuvet Dinarı",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 11,
                    Kodu = "NOK",
                    Cinsi = "Norveç Kronu",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 12,
                    Kodu = "SAR",
                    Cinsi = "Suudi Arabistan riyali",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 13,
                    Kodu = "JPY",
                    Cinsi = "Japon Yeni",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 14,
                    Kodu = "BGN",
                    Cinsi = "Bulgar Levası",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 15,
                    Kodu = "RON",
                    Cinsi = "Rumen Leyi",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 16,
                    Kodu = "RUB",
                    Cinsi = "Rus Rublesi",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 17,
                    Kodu = "IRR",
                    Cinsi = "İran Riyali",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 18,
                    Kodu = "CYN",
                    Cinsi = "Çin Yuanı",
                    DurumId = 1
                },
                new ParaBirimi
                {
                    ParaBirimiId = 19,
                    Kodu = "PKR",
                    Cinsi = "Pakistan Rupisi",
                    DurumId = 1
                }
            });
            #endregion            

            #region //Kategori
            context.Kategoriler.AddRange(new List<Kategori>
            {
                #region //DokumanTipi
                new Kategori
                {
                    KategoriId = 1,
                    Adi = "DokumanTipi",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "Tanımsız",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Adapte Teklifi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Dc",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kitap",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Konu Teklifi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kriter",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kriter İş Programında",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kriter Tasarısı",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kriter Teklifi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "ST",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TD*GD",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TR*TS",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "UTO Rehber Doküman",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "WI (İş Programında)",
                            SiraNo = 0,
                            DurumId = 1
                        },
                    }
                },
                #endregion

                #region //HazirlikGrubu
                new Kategori
                {
                    KategoriId = 2,
                    Adi = "HazirlikGrubu",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "Tanımsız",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Alıcı Ortam Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Ambalaj Özel Daimi Komitesi ÖDK",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Atıklar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Aydınlatma ve İç Tesisat Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Aydınlatma ve Kablo Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Basınçlı Kaplar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Bilgi Teknolojileri ve İletişim İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Bilişim Teknolojileri Test Belgelendirme Sektörü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Cam Seramik ve Refrakter Malzeme Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Çevre İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Çevre Sağlığı Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Çevre Sağlığı ve Atıklar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Demiryolu Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Deprem Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Doğal Gaz Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Doküman Tercüme Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Ekoloji Tarım Ürünleri Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Elektrik İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Elektronik İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Elektroteknik Güvenlik Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Elektroteknik Güvenlik ve Aydınlatma  Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Elektroteknik Sektörü Müdürlüğü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "EMU ve Radyo-TV Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Endüstriyel Yağlar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Gıda Sektörü Müdürlüğü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Helal Gıda Sektör Müdürlüğü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Hizmet Standardları İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Hizmet Yeri Belgelendirme Sektör Müdürlüğü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Isı Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "İnşaat İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "İnşaat Makinaları Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kablo Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kapatılan Hazırlık Grupları",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kapatılan ve Birleştirilen Özel Daimi Komiteler",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kırtasiye Malzemeleri ve Formlar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kimya İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kimya Sektör Müdürlüğü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Laboratuvarlar Hazırlık Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Maden İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Makina İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Makine Sektörü Müdürlüğü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Mamul Gıdalar İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Meslek Standardları İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Metalurji İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Milletlerarası Standardlar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Milli Savunma Sanayii İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Mühendislik Hizmetleri İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "NBC ve KİS Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Nükleer Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Optik ve Optometri Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Orman ve Orman Ürünleri İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Otomotiv Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Otomotiv Sektör Müdürlüğü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Otomotiv ve İnşaat Makinaları Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Özel Standardlar Hazırlık Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Petrokimya İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Petrol İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Plâstik Borular Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Radyo-TV Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Rezerv konular grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Sağlık İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Standard Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Şehiriçi Yollar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Tahribatsız Muayene Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Tarım Alet ve Makinaları Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Teknik Kurul",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Tekstil İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Telekomünikasyon Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Tesisat ve Basınçlı Kaplar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Tıbbi Cihazlar Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK1: Bilişim Teknolojileri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK10: Yapı Malzemeleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK11:İzolasyon, Kaplama ve Yardımcı Yapı Malzemeleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK12: Yapı Güvenliği ve Akustik Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK13: Yapı Güvenliği Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK14: Kimya Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK15: Petrokimya Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK16: Petrol ve Petrol Ürünleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK17: Maden Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK18: İmalat Makineleri ve Takımları Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK19: Otomotiv Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK2: Çevre Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK20: Makine Güvenliği Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK21: Tesisat, Isıtma, Soğutma ve Havalandırma Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK22: Tesisat ve Basınçlı Kaplar Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK23: Metalürji Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK24: Gıda Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK25: Ziraat Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK26: Kişisel Koruyucu ve Oyun Alanı Donanım Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK27: Yangın Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK28: Ambalaj Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK29: Yönetim Sistemleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK3: Elektrik Elektroteknik ve Güvenlik Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK30: Enerji ve Enerji Sistemleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK31: Orman ve Orman Ürünleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK32: Sağlık Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK33: Medikal Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK34: Tekstil Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK35: Elektrik ve Elektronik Yetkili Servisleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK36: Milli Savunma Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK37: Helal Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK38: Sosyal Hizmetler Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK39: Mekanik ve Elektromekanik Yetkili Servisleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK4: Elektrik Üretim,İletim Ve Dağıtım Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK40: Demiryolu Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK41: Uzay ve Havacılık Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK42: Nükleer Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK43: Tercüme-1 Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK44: Tercüme-2 Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK45: İş Sağlığı ve Güvenliği Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK46: Süs Bitkileri",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK5: Aydınlatma ve Bina İçi Tesisleri İle Yardımcı Donanımları Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK6: İletkenler, Kablolar Ve Yalıtım Malzemeleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK7: Yüksek Gerilim Teknikleri ve Yıldırımdan Korunma Sistemleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK8: Elektronik Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TK9: Sanayi Hizmetleri Teknik Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TSEK Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "TSE-Yapılarda Tahribatsız Muayene Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Ulusal Teknik Onay Esas Belirleme Komisyonu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Yangın Özel Daimi Komitesi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Yapı Malzemeleri ÖDK",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Yapı malzemeleri sektörü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Yetkili Servis Standardları İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Yönetim Sistemleri Geliştirme Sektörü",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Ziraat İhtisas Grubu",
                            SiraNo = 0,
                            DurumId = 1
                        }
                    }
                },
                #endregion

                #region //YururlukDurumu
                new Kategori
                {
                    KategoriId = 3,
                    Adi = "YururlukDurumu",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "Tanımsız",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "A (Tadil Görmüş Standard/Amended standard)",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "H (İptal Edilmiş Standard/Withdrawn standard)",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "N (Yeni Standard/New standard)",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "U (Yürürlükteki Standard/Standard)",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "W (Yeni İptal Edilen Standard/Withdrawn standard)",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "A veya N veya U",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "H veya W",
                            SiraNo = 0,
                            DurumId = 1
                        }
                    }
                },
                #endregion

                #region //StandartTur
                new Kategori
                {
                    KategoriId = 4,
                    Adi = "StandartTur",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "Tanımsız",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Kural",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Metot",
                            SiraNo = 0,
                            DurumId = 1
                        }
                    }
                },
                #endregion

                #region //TelefonTipi
                new Kategori
                {
                    KategoriId = 5,
                    Adi = "TelefonTipi",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "Cep Telefonu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Ev Telefonu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "İş Telefonu",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Fax",
                            SiraNo = 0,
                            DurumId = 1
                        }
                    }
                },
                #endregion

                #region //AdresTipi
                new Kategori
                {
                    KategoriId = 6,
                    Adi = "AdresTipi",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "Ev Adresi",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "İş Adresi",
                            SiraNo = 0,
                            DurumId = 1
                        }
                    }
                },
                #endregion

                #region //StandartIcerikTipi
                new Kategori
                {
                    KategoriId = 7,
                    Adi = "StandartIcerikTipi",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "Tablo - Atıf Yapılan",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Denetim",
                            SiraNo = 0,
                            DurumId = 1
                        },
                        new Deger
                        {
                            Deger1 = "Metin",
                            SiraNo = 0,
                            DurumId = 1
                        }
                    }
                },
                #endregion

                #region //AtifYapilanStandartTipi
                new Kategori
                {
                    KategoriId = 8,
                    Adi = "AtifYapilanStandartTipi",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                            Deger1 = "ISO/IEC 15489-1",
                            Deger2 = "Information and documentation – Records management – Part 1: General",
                            Deger3 = "TS ISO 15489-1",
                            Deger4 = "Bilgi ve dokümantasyon - Belge yönetimi Bölüm 1: Genel",
                            DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "ISO/IEC 15489-2",
                             Deger2 = "Information and documentation – Records management – Part 2:Guidelines",
                             Deger3 = "TS ISO/TR 15489-2",
                             Deger4 = "Bilgi ve dokümantasyon - Belge yönetimi - Bölüm 2: Kılavuzlar",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "ISO/IEC 27001",
                             Deger2 = "Information technology - Security techniques - Information security management systems - Requirements",
                             Deger3 = "TS ISO/IEC 27001",
                             Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi güvenliği yönetim sistemleri – Gereksinimler",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "ISO 8601",
                             Deger2 = "Data elements and interchange formats - Information interchange - Representation of dates and times",
                             Deger3 = "TS ISO 8601",
                             Deger4 = "Veri elemanları ve değişim formatları - Bilgi değişimi - Tarih ve zamanın gösterimi",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "ISO/IEC 25051",
                             Deger2 = "Software engineering – Software product Quality Requirements and Evaluation (SQuaRE) – Requirements for quality of Commercial Off - The - Shelf(COTS) software product and instructions for testing",
                             Deger3 = "TS ISO/IEC 25051",
                             Deger4 = "Yazılım mühendisliği - Yazılım ürünü kalite gereksinimleri ve değerlendirmesi(SQuaRE) – Ticari kullanıma hazır(COTS) yazılım ürünü kalitesi için gereksinimler ve test yönergeleri",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "ISO/IEC 15408-1",
                             Deger2 = "Information technology -Security techniques -Evaluation criteria for IT security - Part 1: Introduction and general model",
                             Deger3 = "TS ISO/IEC 15408 - 1",
                             Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi teknolojisi güvenliği için değerlendirme kriterleri - Bölüm 1: Giriş ve genel model",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "ISO/IEC 15408-2",
                             Deger2 = "Information technology -Security techniques -Evaluation criteria for IT security - Part 2: Security functional requirements",
                             Deger3 = "TS ISO/IEC 15408 - 2",
                             Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi teknolojisi güvenliği için değerlendirme kriterleri - Bölüm 2:Güvenlik fonksiyonel bileşenleri",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "ISO/IEC 15408-3",
                             Deger2 = "Information technology -Security techniques -Evaluation criteria for IT security - Part 3: Security assurance requirements",
                             Deger3 = "TS ISO/IEC 15408-3",
                             Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi teknolojisi güvenliği için değerlendirme kriterleri - Bölüm 3:Güvenlik garanti bileşenleri",
                             DurumId = 1,
                        }
                    }
                },
                #endregion

                #region //AtifYapilanDokumanTipi
                new Kategori
                {
                    KategoriId = 9,
                    Adi = "AtifYapilanDokumanTipi",
                    DurumId = 1,
                    Degerler = new List<Deger>
                    {
                        new Deger
                        {
                             Deger1 = "e-Yazışma Teknik Rehberi",
                             Deger2 = "T.C. Kalkınma Bakanlığı Bilgi Toplumu Daire Başkanlığı",
                             Deger3 = "28 Temmuz 2006 tarihli ve 26242 sayılı Resmi Gazetede yayımlanan 2006/38 sayılı Yüksek Planlama Kurulu Kararı ile uygulamaya konan Bilgi Toplumu Stratejisi eki Eylem Planı’nda yer verilen 73 no’lu 'Ortak Hizmetlerin Oluşturulması' eylemi kapsamında geliştirilmiştir.",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "Kayıtlı Elektronik Posta e-Yazışma Projesi İstemci Kütüphaneleri Geliştirici Kılavuzu",
                             Deger2 = "Bilgi Teknolojileri ve İletişim Kurumu (BTK)",
                             Deger3 = "Kayıtlı Elektronik Posta Sistemine İlişkin Usul ve Esaslar Hakkında Yönetmelik, 25 Ağustos 2011 tarih ve 28036 sayılı Resmi Gazete",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "Elektronik Doküman ve Belge Yönetim Sistemi TSE-CCCS-PP-003 Koruma Profili",
                             Deger2 = "Türk Standardları Enstitüsü (TSE)",
                             Deger3 = "2013/4890 sayılı Bakanlar Kurulu Kararı doğrultusunda yayımlanan 20 Haziran 2013 tarihli ve 28683 sayılı Resmi Gazetede yayımlanarak yürürlüğe giren Ulusal Siber Güvenlik Stratejisi ve Eylem Planı Madde 12.",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "Temel Seviye Güvenlik Belgelendirme Kılavuzu",
                             Deger2 = "Türk Standardları Enstitüsü (TSE)",
                             Deger3 = "2013/4890 sayılı Bakanlar Kurulu Kararı doğrultusunda yayımlanan 20 Haziran 2013 tarihli ve 28683 sayılı Resmi Gazetede yayımlanarak yürürlüğe giren Ulusal Siber Güvenlik Stratejisi ve Eylem Planı Madde 12.",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "Birlikte Çalışabilirlik Esasları Rehberi",
                             Deger2 = "T.C. Kalkınma Bakanlığı Bilgi Toplumu Daire Başkanlığı",
                             Deger3 = "2009/4 Sayılı Başbakanlık Genelgesi, Kamu Bilgi Sistemlerinde Birlikte Çalışabilirlik Esasları, 28 Şubat 2009 tarihli ve 27155 sayılı Resmi Gazete",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "Resmi Yazışma Kuralları",
                             Deger2 = "Başbakanlık İdareyi Geliştirme Başkanlığı",
                             Deger3 = "Resmî Yazışmalarda Uygulanacak Usul Ve Esaslar Hakkında Yönetmelik, 2 Şubat 2015 tarih ve 25658 Sayılı Resmi Gazete",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "Standart Dosya Planı",
                             Deger2 = "Başbakanlık Devlet Arşivleri Genel Müdürlüğü",
                             Deger3 = "2005/7 Sayılı Başbakanlık Genelgesi, 25 Mart 2005 tarih ve 25766 sayılı Resmi Gazete",
                             DurumId = 1,
                        },
                        new Deger
                        {
                             Deger1 = "Devlet Teşkilatı VeriTabanı",
                             Deger2 = "Başbakanlık İdareyi Geliştirme Başkanlığı",
                             Deger3 = "2011/1 Sayılı Başbakanlık Genelgesi, 10 Şubat2011 tarih ve 27842 sayılı Resmi Gazete",
                             DurumId = 1,
                        }
                    }
                }
                #endregion
            });            
            #endregion            

            #region //StandartAciklama
            context.StandartAciklamalar.AddRange(new List<StandartAciklama>
            {
                new StandartAciklama
                {
                    StandartAciklamaId = 1,
                    Baslik = "K-Q TSE-ISO-EN 9000 - TSE - TSEK",
                    Detay = $"<ul><li>Bugünkü teknik ve uygulamaya dayanılarak hazırlanmış olan bu standardın, zamanla ortaya çıkacak gelişme ve değişikliklere uydurulması mümkün olduğundan ilgililerin yayınları izlemelerini ve standardın uygulanmasında karşılaştıkları aksaklıkları Enstitümüze iletmelerini rica ederiz.</li><li>Bu standardı oluşturan İhtisas Grubu üyesi değerli uzmanların emeklerini; tasarılar üzerinde görüşlerini bildirmek suretiyle yardımcı olan bilim, kamu ve özel sektör kuruluşları ile kişilerin değerli katkılarınışükranla anarız.</li></ul><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/k-q-tse-iso-en-9000.png' alt='K-Q-TSE-ISO-EN-9000' /><b>Kalite Sistem Belgesi</b><br>İmalât ve hizmet sektörlerinde faaliyet gösteren kuruluşların sistemlerini TS EN ISO 9000 Kalite Standardlarına uygun olarak kurmaları durumunda TSE tarafından verilen belgedir.</p><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/tse.png' alt='TSE' /><b>Türk Standardlarına Uygunluk Markası (TSE Markası)</b><br>TSE Markası, üzerine veya ambalâjına konulduğu malların veya hizmetin ilgili Türk Standardına uygun olduğunu ve mamulle veya hizmetle ilgili bir problem ortaya çıktığında Türk Standardları Enstitüsü’nün garantisi altında olduğunu ifade eder.</p><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/TSEK.png' alt='TSEK' /><b>Kritere Uygunluk Belgesi (TSEK Markası Kullanma Hakkı)</b><br>Kritere Uygunluk Belgesi; Türk Standardları bulunmayan konularda firmaların ürünlerinin ilgili uluslararası standardlar, benzeri Türk Standardları, diğer ülkelerin milli standardları, teknik literatür esas alınarak Türk Standardları Enstitüsü tarafından kabul edilen Kalite Faktör ve Değerlerine uygunluğunu belirten ve akdedilen sözleşme ile TSEK Markası kullanma hakkı verilen firma adına düzenlenen ve üzerinde TSEK Markası kullanılacak ürünlerin ticari Markası, cinsi, sınıfı, tipi ve türünü belirten geçerlilik süresi bir yıl olan belgedir.</p><p><h3>DİKKAT!</h3><br>TS işareti ve yanında yer alan sayı tek başına iken (TS 4600 gibi), mamulün Türk Standardına uygun üretildiğine dair üreticinin beyanını ifade eder. <b>Türk Standardları Enstitüsü tarafından herhangi bir garanti söz konusu değildir.</b></p><p class='text-align:center'><i><b>Standardlar ve standardizasyon konusunda daha geniş bilgi Enstitümüzde sağlanabilir.</i>TÜRK STANDARDLARININ YAYIN HAKLARI SAKLIDIR.</b></p>",
                    DurumId = 1
                }
            });
            #endregion
            
            #region //Standart
            context.Standartlar.AddRange(new List<Standart>
            {
                new Standart
                {   
                    StandartId = 1,                  
                    TsNo = "TS-13298",
                    KabulTarihi = new DateTime(2015, 10, 23),
                    HazirlikGrubuId = 6,
                    DokumanTipiId = 9,
                    YururlukDurumuId = 5,
                    BaslikTr = "Elektronik Belge ve Arşiv Yönetim Sistemi",
                    BaslikEn = "Electronic Records and Archives Management System",
                    StandartTurId = 3,
                    KapsamTr = "Bu standard, kurumlarda üretilen ve/veya üretilmesi muhtemel elektronik dokümanların belge niteliğinin korunabilmesi için gerekli standardlar ile elektronik belgelerin arşivlenmesi ve yönetimine yönelik konuları kapsar.",
                    KapsamEn = "This standard, produced in the institution and / or production of electronic documents, electronic documents possible with the necessary standards to preserve the quality archiving and document covers issues related to management.",
                    YeriniAldigi = "TS 13298 :2009",
                    TadilEden = "TS 13298/T1 :2016",
                    YararlanilanKaynak = "-",
                    TercumeEdildigiStd = "13298",
                    IcsKodu = "01.140.20 Enformasyon Bilimleri; 35.240.20 Büro İşlemlerinde Enformasyon Teknolojisi Uygulamaları; 01.110 Teknik Ürün Dökümantasyonu",
                    CenCenelec = "-",
                    Dili = "tr",
                    RenkDurumu = "Siyah-Beyaz",
                    UygulamaDurumu = "Yürürlükte",
                    SayfaSayisi = 81,
                    Fiyati = 71.00M,
                    ParaBirimiId = 1,
                    StandartAciklamaId = 1,
                    DurumId = 1,                    
                }
            });
            #endregion
            
            context.SaveChanges();            

            #region // StandartIcerik
            context.StandartIcerikler.AddRange(new List<StandartIcerik>
            {
                new StandartIcerik
                {
                    StandartIcerikId = 1,
                    StandartId = 1,
                    BaslikNo = "0",
                    Baslik = "Önsöz",
                    Detay = "<ul><li>- Bu standard, Türk Standardları Enstitüsü’nün Bilişim İhtisas Kurulu’na bağlı TK01 Bilişim Teknolojileri Teknik Komitesi’nce TS 13298: 2009’in revizyonu olarak hazırlanmış ve TSE Teknik Kurulu’nun 23 Ekim 2015 tarihli toplantısında kabul edilerek yayımına karar verilmiştir.</li><li>- Bu standardın daha önce yayımlanmış bulunan baskıları geçersizdir.</li><li>- Bu standardın hazırlanmasında, milli ihtiyaç ve imkânlarımız ön planda olmak üzere, milletlerarası standardlar ve ekonomik ilişkilerimiz bulunan yabancı ülkelerin standardlarındaki esaslar da gözönünde bulundurularak; yarar görülen hallerde, olabilen yakınlık ve benzerliklerin sağlanmasına ve bu esasların, ülkemiz şartları ile bağdaştırılmasına çalışılmıştır.</li><li>- Bu standard son şeklini almadan önce; bilimsel kuruluşlar, üretici/ imalatçı ve tüketici durumundaki konunun ilgilileri ile gerekli işbirliği yapılmış ve alınan görüşlere göre olgunlaştırılmıştır.</li><li>- Bu standardda kullanılan bazı kelime ve/veya ifadeler patent haklarına konu olabilir. Böyle bir patent hakkının belirlenmesi durumunda TSE sorumlu tutulamaz.</li></ul>",
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 1,
                    DurumId = 1
                }, 
                new StandartIcerik
                {
                    StandartIcerikId = 2,
                    StandartId = 1,
                    BaslikNo = "0",
                    Baslik = "Giriş",
                    Detay = @"<p>Bu standard, TS 13298:2009 Elektronik Belge Yönetimi standardının güncel ihtiyaçlara göre yeniden düzenlenmiş halini içermektedir. Standard bir önceki revizyonuna ilave olarak kurumlar arası belge paylaşımı, kayıtlı elektronik postaların yönetimi, elektronik yazışma paketi ve elektronik arşivlerin yönetimi başta olmak üzere bazı yenilikler getirmektedir.</p><p>Kurumların faaliyetlerini kayıt altına alması ve bu bilgileri paydaşları ile paylaşması kurumsal faaliyetlerin ayrılmaz bir parçasıdır. Herkesin, her zaman, her yerden kolaylıkla ulaşabileceği şeffaf, verimli ve sade bir kurum yapısı günümüzde modern ve demokratik kurumların temel hedefi haline gelmiştir. Bilgi ve iletişim teknolojilerindeki gelişmeler bu hedefi gerçekleştirecek olgunluğa ulaşmıştır ve her geçen gün daha da gelişmektedir. Son yıllarda sıkça duyduğumuz e-ticaret ve e-devlet gibi kavramlar bu gelişmelerin bir sonucudur. E-kurum yapısının temelini ise elektronik bilgi sistemleri oluşturmaktadır.</p><p>Kurumlarca üretilen bilgi ve belgelerin verimliliğinin arttırılması için ortak standard ve politikaların belirlenmesi göz ardı edilemez bir gereksinimdir. Böyle bir çalışma kullanımı kolay, erişimi hızlı, güvenilir, ucuz, sürekli ve sağlam 'elektronik kurum' yapısının oluşumuna katkı sağlayarak genelde 'e-toplum'a geçiş sürecini hızlandıracaktır.</p><p>E-kurum faaliyetleri sonucu oluşan elektronik dokümanların belge vasfının korunması, onların üretim aşamasında ve hatta üretim öncesinde elektronik bilgi sistemleri tasarımı aşamasında ele alınmalarını gerekli kılmaktadır. Belge kavramının sistem tasarımcıları ve kullanıcılar tarafından iyi algılanması ve belge yönetimi gereksinimlerinin uygulanması gerekmektedir.</p><p>Elektronik belge yönetimi son derece geniş ve karmaşık bir alandır. Bu alan bir sistem yaklaşımı ile ele alınmalı ve sistemi oluşturan öğelerin birbiri ile uyumlu çalışması için gerekli önlemler alınmalıdır.</p><p>Sistemi oluşturan öğelerin başında Elektronik Belge Yönetim Sistemi (EBYS) yazılımı gelmektedir. Elektronik belgeyi yönetmeye talip her kurum bu konuda uzmanlaşmış bir yazılıma ihtiyaç duyacaktır. Bir EBYS yazılımı hiç şüphesiz kurum ERP yazılımlarının bir parçası olarak üretilebilir ya da kurum fonksiyonlarını elektronik ortamda yürütmek için kullanılan diğer yazılımlarla entegre çalışabilen bağımsız bir paket de olabilir. Bu standard bir EBYS yazılımında bulunması gereken asgari fonksiyonel özellikleri tanımlamaktadır.</p><p>Sistemi oluşturan bir diğer öğe kurumsal politika ve prosedürlerdir. Kurum bilgi ve belge yönetimi prosedürleri EBYS için bir girdi olarak düşünülebilir. Kurumsal belge yönetimi politika ve prosedürlerini henüz geliştirme aşamasında olan kurumlar, bu standardı bir referans kaynağı olarak kullanabilirler.</p><p>Standardın bu revizyonunda Elektronik Arşivleme Sistemi Referans Modelinin (ELAS/RM) adı altında yeni bir bölüm eklenmiştir. Bu bölüm:</p><ul><li>Elektronik belgelerin üretildikleri dönemdeki hukuki varlığının korunabilmesi,</li><li>Sürekli saklanacak elektronik belgelerin kesintisiz olarak erişilebilirliğinin sağlanması için gerekli tedbirlerin alınması,</li><li>Elektronik belgelerin üretildiği bilgi sistemi platformundan bağımsız olarak erişilebilir olması için gerekli sistem gereksinimlerini, elektronik arşivleme sistemleri uygulamalarında bulunması gerekli temel arşivcilik fonksiyonlarını ve elektronik arşivde yer alacak belgelerin sisteme transfer, düzenleme, tanımlama ve kullanımı gibi fonksiyonlara uygun üstveri modelini tanımlamaktır.</li><p>Bu standard, dört bölüm halinde tasarlanmıştır. Bu bölümler kendi içerisinde alt bölümlere ayrılmış ve bu alt bölümler altında da sistem gereksinimleri sıralanmıştır. Bu standard içinde yer alan bölümler şunlardır:</p><li>Sistem kriterleri: Sistem tasarımı ve elektronik belgelerin sisteme dâhil edilmesi için gerekli olan gereksinimlerin ele alındığı bölüm.</li><li>Belge kriterleri: Elektronik belge özellikleri, sayısal görüntüleme sistemleri ve fiziksel ortamdaki belgelerin yönetimi ve EBYS içerisine entegrasyonu gibi konuların ele alındığı bölüm.</li><li>Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM): Elektronik ortamda üretilmiş ya da sonradan elektronik ortama aktarılmış olan arşiv malzemesinin yönetimine yönelik kriterler bu bölümde tanımlanmıştır.</li><li>Üst veri elemanları: EBYS ve ELAS/RM’ye ait üst veri gereksinimleri bu bölümde tanımlanmıştır.</li><p>Sistem ve belge kriterleri ile elektronik arşivleme sistemi referans modeline ait düzenlemeler dört farklı şekilde kodlanmıştır. Her bir kriterin yanındaki kutucuklarda yer alan kodların açılımları şunlardır:</p><li>S/Z: İlgili maddenin seçmeli mi yoksa zorunlu mu olduğunu göstermek için kullanılmıştır.</li> <li>BA: Kriterin bilgi amaçlı olduğunu ifade eder. Genel olarak ürün veya kurum sertifikasyonunda kullanılmamakla birlikte sistemin geneli hakkında ya da ilgili olduğu bölüm ile ilgili teknik bilgi içermektedir.</li><li>KYS: Belge ve arşiv yönetim sistemini kullanan kurumlarda Kurum Yeterlilik Sertifikasyonu için aranacak şartlarla ilgili kriterlerdir. Sistem kurulumu öncesinde ya da esnasında yerine getirilmesi gereken şartları belirler. Ayrıca EBYS ürünü kullanacak kurumların KYS şartlarını sağlamaları ve akredite kurumlardan sertifika almaları gerekir.</li><li>ÜS: Ürün (EBYS yazılımları) sertifikasyonunda kullanılacak kriterleri tanımlar. Bu standarda uyumluluk belgesi alacak ürünlerin taşıması gereken asgari standartları belirler. Aynı ürün farklı ad ve markalar altında birden fazla sertifikalandırılamaz. Yetkili sertifikasyon kurumu, ürünler arasında bu türden bir benzerlik olduğuna karar verdiği durumlarda ürünlerin kaynak kodlarını değerlendirme amaçlı olarak talep edebilir.</li></ul>",
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 2,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 3,
                    StandartId = 1,
                    BaslikNo = "1",
                    Baslik = "Kapsam",
                    Detay = @"<p>Bu standard, kurumlarda üretilen ve/veya üretilmesi muhtemel elektronik dokümanların belge niteliğinin korunabilmesi için gerekli standardların belirlenmesi amacıyla aşağıdaki konuları kapsar:</p><ol><li>Elektronik belge yönetimi sistemi (EBYS) için gerekli sistem gereksinimleri,</li><li>EBYS için gerekli belge yönetim teknikleri ve uygulamaları,</li><li>Elektronik belgelerin yönetilebilmesi için gerekli gereksinimler,</li><li>Elektronik ortamda üretilmemiş belgelerin yönetim fonksiyonlarının elektronik ortamda yürütülebilmesi içingerekli gereksinimler,</li><li>Elektronik belgelerde bulunması gereken diplomatik özellikler,</li><li>Elektronik belgelerin hukuki geçerliliklerinin sağlanması için alınması gereken önlemler,</li><li>Güvenli elektronik imza ve mühür sistemlerinin uygulanması için gerekli sistem alt yapısının tanımlanması.</li></ol><p>Bu standard, ayrıca, elektronik belgelerin arşivlenmesi ve yönetimine yönelik olarak da aşağıdaki konuları kapsamaktadır.</p><ol><li>Elektronik ortamda üretilmiş ve kurumsal kimlik doğrulama sistemleri ve/veya elektronik / mobil imza sistemleri ile imzalanmış kurumsal belgelerin,</li><li>Fiziksel ortamlarda üretilmiş olup sonradan sayısallaştırma yöntemi ile elektronik ortama aktarılmış yazılı, basılı, çizili her türlü doküman ve belgelerin,</li><li>Dijital olarak üretilmiş resim, ses ve görüntü kayıtlarının,</li><li>Sayısallaştırma yöntemi ile elektronik ortama aktarılmış analog resim, ses ve görüntü kayıtlarının yönetilmesine imkân sağlayacak düzenlemeleri kapsamaktadır.</li></ol><p>Bu standard, elektronik belgelerin üretim ortamına ait bilgi güvenliği ile ilgili herhangi bir kriter kapsamaz. Bilgi güvenliği yönetim sistemi ile ilgili olarak TS ISO/IEC 27001 standardı kullanılabilir.</p>",
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 3,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 4,
                    StandartId = 1,
                    BaslikNo = "2",
                    Baslik = "Atıf yapılan standard ve/veya dokümanlar",
                    Detay = @"Aşağıda verilen, atıf yapılan standardların hükümleri bu standardın hükümleri sayılır. Tarih belirtilen atıflarda, daha sonra yapılan tadil ve revizyonlar uygulanmaz. Bununla birlikte, bu standarda dayalı anlaşmalarda taraflara, aşağıda verilen standardların en yeni baskılarını uygulama imkânını araştırmaları önerilir. Tarih belirtilmeyen atıflarda, ilgili standardın en son baskısı kullanılır. Bütün standardların yürürlükte bulunan baskıları TSE’den temin edilebilir. (*) işaretli olanlar bu standardın basıldığı tarihte İngilizce metin olarak yayımlanmış Türk Standardlarıdır.",
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 160,
                    SiraNo = 4,
                    DurumId = 1,
                    StandartAtiflar = new List<StandartAtif>
                    {
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 163,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 164,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 165,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 166,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 167,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 168,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 169,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 8,
                            DegerId = 170,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 171,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 172,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 173,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 174,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 175,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 176,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 177,
                            DurumId = 1
                        },
                        new StandartAtif
                        {
                            StandartId = 1,
                            StandartIcerikId = 4,
                            KategoriId = 9,
                            DegerId = 178,
                            DurumId = 1
                        }
                    }
                },
                new StandartIcerik
                {
                    StandartIcerikId = 5,
                    StandartId = 1,
                    BaslikNo = "3",
                    Baslik = "Terimler, tarifler ve kısaltmalar",
                    Detay = "Bu standard için aşağıdaki terimler ve tarifler geçerlidir. Burada yer almayan terimler için ISO 15489’da belirtilen terimler ve tarifler kullanılmalıdır.",
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 5,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 6,
                    StandartId = 1,
                    BaslikNo = "3.1",
                    Baslik = "Arşiv Kurumu",
                    Detay = "Belirli bir yasal çerçeve içerisinde faaliyet gösteren ve farklı kurumlar tarafından üretilmiş olan arşiv malzemesini ayıklama, düzenleme, tanımlama, hizmete sunma ve diğer yönetimsel fonksiyonları yerine getiren ulusal, bölgesel ya da özel amaçlı arşiv kurumları.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 6,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 7,
                    StandartId = 1,
                    BaslikNo = "3.2",
                    Baslik = "Arşiv Yönetim Sistemi (AYS)",
                    Detay = "Arşiv malzemesinin arşiv kurumlarına transferi, düzenlenmesi, tanımlanması, kullanıma sunulması, korunması ve diğer yönetimsel fonksiyonları gerçekleştirmek üzere geliştirilmiş bilgisayar sistemi.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 7,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 8,
                    StandartId = 1,
                    BaslikNo = "3.3",
                    Baslik = "Belge",
                    Detay = "Herhangi bir bireysel veya kurumsal fonksiyonun yerine getirilmesi için alınmış ya da fonksiyonun sonucunda üretilmiş, içerik, ilişki ve formatı ile ait olduğu fonksiyon için delil teşkil eden kayıtlı bilgi.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 8,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 9,
                    StandartId = 1,
                    BaslikNo = "3.4",
                    Baslik = "Diplomatik özellik",
                    Detay = "Belgelerin orijinalliğinin tespit edilmesinde kullanılabilecek her türlü içerik, format, ilişki ve sunum özellikleri.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 9,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 10,
                    StandartId = 1,
                    BaslikNo = "3.5",
                    Baslik = "Doküman",
                    Detay = "Kurumsal faaliyetlerin yerine getirilmesinde üretilen ya da toplanan, henüz belge vasfı kazanmamış her türlü kayıtlı bilgi.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 10,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 11,
                    StandartId = 1,
                    BaslikNo = "3.6",
                    Baslik = "Dosya tasnif planı",
                    Detay = "Kurumsal faaliyetlerin ve bu faaliyetler sonucunda oluşan belgelerin kurumsal yapıya ve hiyerarşiye uygun olarak konusal olarak sınıflandırılması için geliştirilmiş belge yönetim aracı.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 11,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 12,
                    StandartId = 1,
                    BaslikNo = "3.7",
                    Baslik = "Elektronik belge yönetimi",
                    Detay = "Kurumların gündelik işlerini yerine getirirken oluşturdukları her türlü dokümantasyonun içerisinden kurum faaliyetlerinin delili olabilecek belgelerin ayıklanarak bunların içerik, format ve ilişkisel özelliklerini korumak ve bu belgeleri üretimden nihai tasfiyeye kadar olan süreç içerisinde yönetmek.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 12,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 13,
                    StandartId = 1,
                    BaslikNo = "3.8",
                    Baslik = "Kurum arşivi",
                    Detay = "Ait olduğu kurum tarafından üretilen belgelerden idarî, malî ve hukukî açıdan saklama süresini doldurmuş olan arşiv belgelerinin ayıklanması, düzenlenmesi, tanımlanması, hizmete sunulması ve diğer yönetimsel fonksiyonları yerine getiren birim.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 13,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 14,
                    StandartId = 1,
                    BaslikNo = "3.9",
                    Baslik = "Provenans",
                    Detay = "Kendi faaliyetlerinin yürütülmesi sırasında belge üreten ve saklayan kişi veya kurumlar bir belgenin provenansını oluşturur. Provenans prensibi ise; aynı provenansa (kaynak, köken, menşe) sahip belgelerin, başka bir provenansa sahip olanlarla karıştırılmaması gerektiğini öngören temel ilke. 'Fonlara Saygı' (respectdes fonds) olarak da anılır.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 14,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 15,
                    StandartId = 1,
                    BaslikNo = "3.10",
                    Baslik = "Tasfiye",
                    Detay = "Kurumsal gereksinimler açısından saklanmasına gerek kalmayan belgelerin kurum belge sisteminin dışına çıkarılması. Tasfiye işlemi artık ihtiyaç duyulmayan belgelerin kurum içinde veya kurum dışında başka bir kuruma/birime transfer edilmesini ya da imha edilmesini öngörür.",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 15,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 16,
                    StandartId = 1,
                    BaslikNo = "3.11",
                    Baslik = "Varlık",
                    Detay = "Arşiv yönetim sistemi içerisinde yer alan ve bağımsız olarak tanımlanan belge, dosya / klasör, seri, fon, vs. gibi kayıtlar. <table><h3>Kısaltmalar</h3><tr><td>AYS</td><td>Arşiv Yönetim Sistemi</td></tr><tr><td>DERBİS</td><td>Dernekler Bilgi Sistemi</td></tr><tr><td>DETSİS</td><td>Devlet Teşkilatı Merkezi Kayıt Sistemi</td></tr><tr><td>DGS</td><td>Dijital Görüntüme Sistemi</td></tr><tr><td>DYS</td><td>Doküman Yönetim Sistemi</td></tr><tr><td>EBYS</td><td>Elektronik Belge Yönetim Sistemi</td></tr><tr><td>ELAS/RM</td><td>Elektronik Arşivleme Sistemi Referans Modeli</td></tr><tr><td>EYP</td><td>Elektronik Yazışma Paketi</td></tr><tr><td>KEP</td><td>Kayıtlı Elektronik Posta</td></tr><tr><td>KPS</td><td>Kimlik Paylaşım Sistemi</td></tr><tr><td>MERNİS</td><td>Merkezî Nüfus İdare Sistemi</td></tr><tr><td>MERSİS</td><td>Merkezi Sicil Kayıt Sistemi</td></tr><tr><td>MTK</td><td>Merkezi Tüzel Kişilik Bilgi Sistemi</td></tr><tr><td>UAPS</td><td>Ulusal Adres Paylaşım Sistemi</td></tr><tr><td>VBYS</td><td>Vakıf Bilgi Yönetim Sistemi</td></tr></table>",
                    UstIcerikId = 5,
                    StandartIcerikTipiId = 162,
                    SiraNo = 16,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 17,
                    StandartId = 1,
                    BaslikNo = "Bölüm 1:",
                    Baslik = "Sistem Kriterleri",
                    Detay = null,
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 17,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 18,
                    StandartId = 1,
                    BaslikNo = "4",
                    Baslik = "Dosya tasnif planları",
                    Detay = null,
                    UstIcerikId = 17,
                    StandartIcerikTipiId = 162,
                    SiraNo = 18,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 19,
                    StandartId = 1,
                    BaslikNo = "4.1",
                    Baslik = "Dosya planının oluşturulması",
                    Detay = null,
                    UstIcerikId = 18,
                    StandartIcerikTipiId = 161,
                    SiraNo = 19,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 20,
                    StandartId = 1,
                    BaslikNo = "4.2",
                    Baslik = "Dosya tasnif planı elemanlarının tanımlanması",
                    Detay = null,
                    UstIcerikId = 18,
                    StandartIcerikTipiId = 161,
                    SiraNo = 20,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 21,
                    StandartId = 1,
                    BaslikNo = "4.3",
                    Baslik = "Dosya tasnif planının yönetilmesi",
                    Detay = null,
                    UstIcerikId = 18,
                    StandartIcerikTipiId = 161,
                    SiraNo = 21,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 22,
                    StandartId = 1,
                    BaslikNo = "5",
                    Baslik = "Saklama planları",
                    Detay = null,
                    UstIcerikId = 17,
                    StandartIcerikTipiId = 162,
                    SiraNo = 22,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 23,
                    StandartId = 1,
                    BaslikNo = "5.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikId = 22,
                    StandartIcerikTipiId = 161,
                    SiraNo = 23,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 24,
                    StandartId = 1,
                    BaslikNo = "5.2",
                    Baslik = "Belge hiyerarşisi",
                    Detay = null,
                    UstIcerikId = 22,
                    StandartIcerikTipiId = 161,
                    SiraNo = 24,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 25,
                    StandartId = 1,
                    BaslikNo = "5.3",
                    Baslik = "Saklama kriterleri",
                    Detay = null,
                    UstIcerikId = 22,
                    StandartIcerikTipiId = 161,
                    SiraNo = 25,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 26,
                    StandartId = 1,
                    BaslikNo = "5.4",
                    Baslik = "Saklama süreleri",
                    Detay = null,
                    UstIcerikId = 22,
                    StandartIcerikTipiId = 161,
                    SiraNo = 26,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 27,
                    StandartId = 1,
                    BaslikNo = "5.5",
                    Baslik = "Tasfiye işlem tanımları",
                    Detay = null,
                    UstIcerikId = 22,
                    StandartIcerikTipiId = 161,
                    SiraNo = 27,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 28,
                    StandartId = 1,
                    BaslikNo = "6",
                    Baslik = "Elektronik belgelerin kayıt işlemleri",
                    Detay = null,
                    UstIcerikId = 17,
                    StandartIcerikTipiId = 162,
                    SiraNo = 28,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 29,
                    StandartId = 1,
                    BaslikNo = "6.1",
                    Baslik = "Genel Özellikler",
                    Detay = null,
                    UstIcerikId = 28,
                    StandartIcerikTipiId = 161,
                    SiraNo = 29,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 30,
                    StandartId = 1,
                    BaslikNo = "6.2",
                    Baslik = "Dokümanların belgeye dönüştürülmesi ve ilişkilendirme",
                    Detay = null,
                    UstIcerikId = 28,
                    StandartIcerikTipiId = 161,
                    SiraNo = 30,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 31,
                    StandartId = 1,
                    BaslikNo = "6.3",
                    Baslik = "Belge türleri",
                    Detay = null,
                    UstIcerikId = 28,
                    StandartIcerikTipiId = 161,
                    SiraNo = 31,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 32,
                    StandartId = 1,
                    BaslikNo = "6.4",
                    Baslik = "Elektronik postaların yönetimi",
                    Detay = null,
                    UstIcerikId = 28,
                    StandartIcerikTipiId = 161,
                    SiraNo = 32,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 33,
                    StandartId = 1,
                    BaslikNo = "6.5",
                    Baslik = "Taşıma, kopyalama ve silme",
                    Detay = null,
                    UstIcerikId = 28,
                    StandartIcerikTipiId = 161,
                    SiraNo = 33,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 34,
                    StandartId = 1,
                    BaslikNo = "6.6",
                    Baslik = "Referans kodlarının verilmesi",
                    Detay = null,
                    UstIcerikId = 28,
                    StandartIcerikTipiId = 161,
                    SiraNo = 34,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 35,
                    StandartId = 1,
                    BaslikNo = "7",
                    Baslik = "Elektronik Belgelerin Paylaşımı",
                    Detay = null,
                    UstIcerikId = 17,
                    StandartIcerikTipiId = 162,
                    SiraNo = 35,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 36,
                    StandartId = 1,
                    BaslikNo = "7.1",
                    Baslik = "Kurum Kodlarının Kullanılması",
                    Detay = null,
                    UstIcerikId = 35,
                    StandartIcerikTipiId = 161,
                    SiraNo = 36,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 37,
                    StandartId = 1,
                    BaslikNo = "7.2",
                    Baslik = "Kayıtlı Elektronik Posta (KEP)",
                    Detay = null,
                    UstIcerikId = 35,
                    StandartIcerikTipiId = 161,
                    SiraNo = 37,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 38,
                    StandartId = 1,
                    BaslikNo = "7.3",
                    Baslik = "Elektronik Yazışma Paketi",
                    Detay = null,
                    UstIcerikId = 35,
                    StandartIcerikTipiId = 161,
                    SiraNo = 38,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 39,
                    StandartId = 1,
                    BaslikNo = "8",
                    Baslik = "EBYS kullanım özellikleri",
                    Detay = null,
                    UstIcerikId = 17,
                    StandartIcerikTipiId = 162,
                    SiraNo = 39,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 40,
                    StandartId = 1,
                    BaslikNo = "8.1",
                    Baslik = "Kullanım – Genel kurallar",
                    Detay = null,
                    UstIcerikId = 39,
                    StandartIcerikTipiId = 161,
                    SiraNo = 40,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 41,
                    StandartId = 1,
                    BaslikNo = "8.2",
                    Baslik = "Arama",
                    Detay = null,
                    UstIcerikId = 39,
                    StandartIcerikTipiId = 161,
                    SiraNo = 41,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 42,
                    StandartId = 1,
                    BaslikNo = "8.3",
                    Baslik = "Görüntüleme",
                    Detay = null,
                    UstIcerikId = 39,
                    StandartIcerikTipiId = 161,
                    SiraNo = 42,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 43,
                    StandartId = 1,
                    BaslikNo = "8.4",
                    Baslik = "Yazdırma",
                    Detay = null,
                    UstIcerikId = 39,
                    StandartIcerikTipiId = 161,
                    SiraNo = 43,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 44,
                    StandartId = 1,
                    BaslikNo = "8.5",
                    Baslik = "Raporlama",
                    Detay = null,
                    UstIcerikId = 39,
                    StandartIcerikTipiId = 161,
                    SiraNo = 44,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 45,
                    StandartId = 1,
                    BaslikNo = "9",
                    Baslik = "Erişim kontrolü ve güvenlik",
                    Detay = null,
                    UstIcerikId = 17,
                    StandartIcerikTipiId = 162,
                    SiraNo = 45,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 46,
                    StandartId = 1,
                    BaslikNo = "9.1",
                    Baslik = "Sisteme Giriş",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 46,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 47,
                    StandartId = 1,
                    BaslikNo = "9.2",
                    Baslik = "Erişim Hakları",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 47,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 48,
                    StandartId = 1,
                    BaslikNo = "9.3",
                    Baslik = "Kullanıcı Profilleri",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 48,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 49,
                    StandartId = 1,
                    BaslikNo = "9.4",
                    Baslik = "Kullanıcı Rolleri",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 49,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 50,
                    StandartId = 1,
                    BaslikNo = "9.5",
                    Baslik = "Kullanıcı Grupları",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 50,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 51,
                    StandartId = 1,
                    BaslikNo = "9.6",
                    Baslik = "Kayıtlara erişim haklarının atanması ve uygulanması",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 51,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 52,
                    StandartId = 1,
                    BaslikNo = "9.7",
                    Baslik = "Üretim sorumluluğu ve mülkiyet",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 52,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 53,
                    StandartId = 1,
                    BaslikNo = "9.8",
                    Baslik = "Günlük dosyalarının oluşturulması",
                    Detay = null,
                    UstIcerikId = 45,
                    StandartIcerikTipiId = 161,
                    SiraNo = 53,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 54,
                    StandartId = 1,
                    BaslikNo = "10",
                    Baslik = "Sistem Tasarımı ve Yönetimi",
                    Detay = null,
                    UstIcerikId = 17,
                    StandartIcerikTipiId = 162,
                    SiraNo = 54,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 55,
                    StandartId = 1,
                    BaslikNo = "10.1",
                    Baslik = "Sistem bütünlüğü ve güvenirlik",
                    Detay = null,
                    UstIcerikId = 54,
                    StandartIcerikTipiId = 161,
                    SiraNo = 55,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 56,
                    StandartId = 1,
                    BaslikNo = "10.2",
                    Baslik = "Kullanım kolaylığı",
                    Detay = null,
                    UstIcerikId = 54,
                    StandartIcerikTipiId = 161,
                    SiraNo = 56,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 57,
                    StandartId = 1,
                    BaslikNo = "10.3",
                    Baslik = "Performans ve ölçeklenebilirlik",
                    Detay = null,
                    UstIcerikId = 54,
                    StandartIcerikTipiId = 161,
                    SiraNo = 57,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 58,
                    StandartId = 1,
                    BaslikNo = "10.4",
                    Baslik = "Verilerin Depolanması",
                    Detay = null,
                    UstIcerikId = 54,
                    StandartIcerikTipiId = 161,
                    SiraNo = 58,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 59,
                    StandartId = 1,
                    BaslikNo = "Bölüm II:",
                    Baslik = "Belge Kriterleri",
                    Detay = null,
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 59,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 60,
                    StandartId = 1,
                    BaslikNo = "11",
                    Baslik = "Belge Özellikleri",
                    Detay = null,
                    UstIcerikId = 59,
                    StandartIcerikTipiId = 162,
                    SiraNo = 60,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 61,
                    StandartId = 1,
                    BaslikNo = "11.1",
                    Baslik = "Tanımlanabilirlik",
                    Detay = null,
                    UstIcerikId = 60,
                    StandartIcerikTipiId = 161,
                    SiraNo = 61,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 62,
                    StandartId = 1,
                    BaslikNo = "11.2",
                    Baslik = "Bütünlük",
                    Detay = null,
                    UstIcerikId = 60,
                    StandartIcerikTipiId = 161,
                    SiraNo = 62,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 63,
                    StandartId = 1,
                    BaslikNo = "11.3",
                    Baslik = "Onay ve Kayıt Bilgisi",
                    Detay = null,
                    UstIcerikId = 60,
                    StandartIcerikTipiId = 161,
                    SiraNo = 63,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 64,
                    StandartId = 1,
                    BaslikNo = "11.4",
                    Baslik = "Yapısal özellikler",
                    Detay = null,
                    UstIcerikId = 60,
                    StandartIcerikTipiId = 161,
                    SiraNo = 64,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 65,
                    StandartId = 1,
                    BaslikNo = "11.5",
                    Baslik = "Üretim sorumluluğu ve mülkiyet hakları",
                    Detay = null,
                    UstIcerikId = 60,
                    StandartIcerikTipiId = 161,
                    SiraNo = 65,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 66,
                    StandartId = 1,
                    BaslikNo = "11.6",
                    Baslik = "Teknolojik özellikler",
                    Detay = null,
                    UstIcerikId = 60,
                    StandartIcerikTipiId = 161,
                    SiraNo = 66,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 67,
                    StandartId = 1,
                    BaslikNo = "12",
                    Baslik = "Doküman yönetimi",
                    Detay = null,
                    UstIcerikId = 59,
                    StandartIcerikTipiId = 162,
                    SiraNo = 67,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 68,
                    StandartId = 1,
                    BaslikNo = "12.1",
                    Baslik = "Giriş",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 68,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 69,
                    StandartId = 1,
                    BaslikNo = "12.2",
                    Baslik = "Girdi Yönetimi",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 69,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 70,
                    StandartId = 1,
                    BaslikNo = "12.3",
                    Baslik = "Tanımlama ve indeksleme",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 70,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 71,
                    StandartId = 1,
                    BaslikNo = "12.4",
                    Baslik = "Dosyalama, düzenleme ve tasnif",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 71,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 72,
                    StandartId = 1,
                    BaslikNo = "12.5",
                    Baslik = "Depolama / Yedekleme",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 72,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 73,
                    StandartId = 1,
                    BaslikNo = "12.6",
                    Baslik = "Erişim",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 73,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 74,
                    StandartId = 1,
                    BaslikNo = "12.7",
                    Baslik = "Çıktı yönetimi",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 74,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 75,
                    StandartId = 1,
                    BaslikNo = "12.8",
                    Baslik = "Versiyon kontrolü",
                    Detay = null,
                    UstIcerikId = 67,
                    StandartIcerikTipiId = 161,
                    SiraNo = 75,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 76,
                    StandartId = 1,
                    BaslikNo = "13",
                    Baslik = "Elektronik olmayan sistemlerle uyumluluk",
                    Detay = null,
                    UstIcerikId = 59,
                    StandartIcerikTipiId = 162,
                    SiraNo = 76,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 77,
                    StandartId = 1,
                    BaslikNo = "13.1",
                    Baslik = "Fiziksel dosya ve belgelerin sisteme dahil edilmesi",
                    Detay = null,
                    UstIcerikId = 76,
                    StandartIcerikTipiId = 161,
                    SiraNo = 77,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 78,
                    StandartId = 1,
                    BaslikNo = "13.2",
                    Baslik = "Tanımlama",
                    Detay = null,
                    UstIcerikId = 76,
                    StandartIcerikTipiId = 161,
                    SiraNo = 78,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 79,
                    StandartId = 1,
                    BaslikNo = "13.3",
                    Baslik = "Erişim kontrolü ve kullanım",
                    Detay = null,
                    UstIcerikId = 76,
                    StandartIcerikTipiId = 161,
                    SiraNo = 79,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 80,
                    StandartId = 1,
                    BaslikNo = "13.4",
                    Baslik = "Tasfiye",
                    Detay = null,
                    UstIcerikId = 76,
                    StandartIcerikTipiId = 161,
                    SiraNo = 80,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 81,
                    StandartId = 1,
                    BaslikNo = "14",
                    Baslik = "Dijital görüntüleme sistemleri",
                    Detay = null,
                    UstIcerikId = 59,
                    StandartIcerikTipiId = 162,
                    SiraNo = 81,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 82,
                    StandartId = 1,
                    BaslikNo = "14.1",
                    Baslik = "Genel rensipler",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 82,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 83,
                    StandartId = 1,
                    BaslikNo = "14.2",
                    Baslik = "Görüntülenecek malzeme",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 83,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 84,
                    StandartId = 1,
                    BaslikNo = "14.3",
                    Baslik = "Görüntüleme Tekniği",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 84,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 85,
                    StandartId = 1,
                    BaslikNo = "14.4",
                    Baslik = "Çözünürlük",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 85,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 86,
                    StandartId = 1,
                    BaslikNo = "14.5",
                    Baslik = "Tonlama / Bit derinliği / Tarama modu",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 86,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 87,
                    StandartId = 1,
                    BaslikNo = "14.6",
                    Baslik = "Sıkıştırma",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 87,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 88,
                    StandartId = 1,
                    BaslikNo = "14.7",
                    Baslik = "Zenginleştirme",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 88,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 89,
                    StandartId = 1,
                    BaslikNo = "14.8",
                    Baslik = "Renk yönetimi",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 89,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 90,
                    StandartId = 1,
                    BaslikNo = "14.9",
                    Baslik = "Dosya Formatları",
                    Detay = null,
                    UstIcerikId = 81,
                    StandartIcerikTipiId = 161,
                    SiraNo = 90,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 91,
                    StandartId = 1,
                    BaslikNo = "Bölüm III:",
                    Baslik = "Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM)",
                    Detay = null,
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 91,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 92,
                    StandartId = 1,
                    BaslikNo = "15",
                    Baslik = "Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM)",
                    Detay = null,
                    UstIcerikId = 91,
                    StandartIcerikTipiId = 162,
                    SiraNo = 92,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 93,
                    StandartId = 1,
                    BaslikNo = "15.1",
                    Baslik = "Arşiv Malzemesinin tanımı ve özellikleri",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 93,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 94,
                    StandartId = 1,
                    BaslikNo = "15.2",
                    Baslik = "Arşiv politikasını belirlenmesi",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 94,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 95,
                    StandartId = 1,
                    BaslikNo = "15.3",
                    Baslik = "Arşiv malzemesinin transfer işlemleri",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 95,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 96,
                    StandartId = 1,
                    BaslikNo = "15.4",
                    Baslik = "Tarih ve zaman damgası",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 96,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 97,
                    StandartId = 1,
                    BaslikNo = "15.5",
                    Baslik = "Dosya formatları",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 97,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 98,
                    StandartId = 1,
                    BaslikNo = "15.6",
                    Baslik = "Depolama Üniteleri",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 98,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 99,
                    StandartId = 1,
                    BaslikNo = "15.7",
                    Baslik = "Veri merkezi özellikleri",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 99,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 100,
                    StandartId = 1,
                    BaslikNo = "15.8",
                    Baslik = "Erişimin sürekliliği",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 100,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 101,
                    StandartId = 1,
                    BaslikNo = "15.9",
                    Baslik = "Teknolojik eskimeye karşı alınacak önlemler",
                    Detay = null,
                    UstIcerikId = 92,
                    StandartIcerikTipiId = 161,
                    SiraNo = 101,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 102,
                    StandartId = 1,
                    BaslikNo = "16",
                    Baslik = "Arşiv sisteminin Güvenliği",
                    Detay = null,
                    UstIcerikId = 91,
                    StandartIcerikTipiId = 162,
                    SiraNo = 102,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 103,
                    StandartId = 1,
                    BaslikNo = "16.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikId = 102,
                    StandartIcerikTipiId = 161,
                    SiraNo = 103,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 104,
                    StandartId = 1,
                    BaslikNo = "16.2",
                    Baslik = "Sistem Güvenliği",
                    Detay = null,
                    UstIcerikId = 102,
                    StandartIcerikTipiId = 161,
                    SiraNo = 104,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 105,
                    StandartId = 1,
                    BaslikNo = "16.3",
                    Baslik = "Bilgi Güvenliği",
                    Detay = null,
                    UstIcerikId = 102,
                    StandartIcerikTipiId = 161,
                    SiraNo = 105,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 106,
                    StandartId = 1,
                    BaslikNo = "16.4",
                    Baslik = "Sistem Denetimi",
                    Detay = null,
                    UstIcerikId = 102,
                    StandartIcerikTipiId = 161,
                    SiraNo = 106,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 107,
                    StandartId = 1,
                    BaslikNo = "17",
                    Baslik = "ELAS/RM Uygulama Kılavuzu",
                    Detay = null,
                    UstIcerikId = 91,
                    StandartIcerikTipiId = 162,
                    SiraNo = 107,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 108,
                    StandartId = 1,
                    BaslikNo = "17.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikId = 107,
                    StandartIcerikTipiId = 161,
                    SiraNo = 108,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 109,
                    StandartId = 1,
                    BaslikNo = "17.2",
                    Baslik = "Arşiv Malzemesinin Transfer İşlemleri",
                    Detay = null,
                    UstIcerikId = 107,
                    StandartIcerikTipiId = 161,
                    SiraNo = 109,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 110,
                    StandartId = 1,
                    BaslikNo = "17.3",
                    Baslik = "Düzenleme",
                    Detay = null,
                    UstIcerikId = 107,
                    StandartIcerikTipiId = 161,
                    SiraNo = 110,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 111,
                    StandartId = 1,
                    BaslikNo = "18",
                    Baslik = "Arşiv Malzemesinin Tanımlanması",
                    Detay = null,
                    UstIcerikId = 91,
                    StandartIcerikTipiId = 162,
                    SiraNo = 111,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 112,
                    StandartId = 1,
                    BaslikNo = "18.1",
                    Baslik = "Tanımlama seviyeleri",
                    Detay = null,
                    UstIcerikId = 111,
                    StandartIcerikTipiId = 161,
                    SiraNo = 112,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 113,
                    StandartId = 1,
                    BaslikNo = "18.2",
                    Baslik = "Tanımlama Alanları",
                    Detay = null,
                    UstIcerikId = 111,
                    StandartIcerikTipiId = 161,
                    SiraNo = 113,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 114,
                    StandartId = 1,
                    BaslikNo = "Bölüm:IV",
                    Baslik = "Üstveri Yönetimi",
                    Detay = null,
                    UstIcerikId = 0,
                    StandartIcerikTipiId = 162,
                    SiraNo = 114,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 115,
                    StandartId = 1,
                    BaslikNo = "19",
                    Baslik = "Üstveri Elemanları",
                    Detay = null,
                    UstIcerikId = 114,
                    StandartIcerikTipiId = 162,
                    SiraNo = 115,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 116,
                    StandartId = 1,
                    BaslikNo = "19.1",
                    Baslik = "Genel Özellikler",
                    Detay = null,
                    UstIcerikId = 115,
                    StandartIcerikTipiId = 161,
                    SiraNo = 116,
                    DurumId = 1
                },
                new StandartIcerik
                {
                    StandartIcerikId = 117,
                    StandartId = 1,
                    BaslikNo = "19.2",
                    Baslik = "Dosya Tasnif Planı Üstveri Elemanları",
                    Detay = "<p><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>DTP Eleman Referans Numarası</td></tr><tr><td>Referans Numarası</td><td>DT001</td></tr><tr><td>Tanım</td><td>Dosya tasnif planında yer alacak her bir eleman için verilecek olan referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Dosya tasnif planındaki seri ve alt seri kodları gibi.</td></tr></table></p><p><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>DTP Eleman adı</td></tr><tr><td>Referans Numarası</td><td>DT010</td></tr><tr><td>Tanım</td><td>Dosya tasnif planında yer alan elemanların adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Dosya tasnif planındaki seri ve alt serilerin adıdır. Farklı birimlerde aynı ad ile seriler oluşabilir. Ancak bu serilere ait referans numaraları farklı olmalıdır.</td></tr></table></p><p><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Tanım</td></tr><tr><td>Referans Numarası</td><td>DT050</td></tr><tr><td>Tanım</td><td>Dosya tasnif planı elemanına ait tanımlamalara ve açıklamalara ait bilgidir. Kullanımı zorunlu değildir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td>Kullanıcıların yönlendirilmesi ve EBYS içerisine dahil edilecek belgelerin hangi elemanlar altında tasnif edilmesi gerektiğini göstermek amacıyla kullanılabilir.</td></tr></table></p><p><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seviye numarası</td></tr><tr><td>Referans Numarası</td><td>DT070</td></tr><tr><td>Tanım</td><td>Dosya tasnif planı elemanına ait hiyerarşik seviyeyi gösteren numaradır.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table></p>",
                    UstIcerikId = 115,
                    StandartIcerikTipiId = 162,
                    SiraNo = 117,
                    DurumId = 1
                },
            });
            #endregion
            
            #region //Kisi
            context.Kisiler.AddRange(new List<Kisi>
            {
                new Kisi
                {
                    TcKimlikNo = 28661334272,
                    Adi = "Halil İbrahim",
                    Soyadi = "Poyraz",
                    DurumId = 1,
                    Epostalar = new List<Eposta>
                    {
                        new Eposta
                        {
                            EpostaAdresi = "h.ibrahimpoyraz@gmail.com",
                            VarsayilanEposta = true,
                            DurumId = 1
                        },
                        new Eposta
                        {
                            EpostaAdresi = "hll_pyrz@hotmail.com",
                            VarsayilanEposta = false,
                            DurumId = 1
                        }
                    },
                    KisiTelefonlar = new List<Telefon>
                    {
                        new Telefon
                        {
                            TelefonTipiId = 154,
                            TelefonNo = "05345950053",
                            VarsayilanTelefon = true,
                            DurumId = 1
                        }
                    },
                    KisiAdresler = new List<Adres>
                    {
                        new Adres
                        {
                            AdresTipiId = 158,
                            AdresSatiri = "Çubuklu Mahallesi Nazım Tur Caddesi Mola Çıkmazı Sokak No:4/1",
                            IlceId = 432,
                            SehirId = 34,
                            UlkeId = 1,
                            VarsayilanAdres = true,
                            DurumId = 1
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
                    TcKimlikNo = 44080828284,
                    Adi = "Ali",
                    Soyadi = "Atabey",
                    DurumId = 1,
                    Epostalar = new List<Eposta>
                    {
                        new Eposta
                        {
                            EpostaAdresi = "ali@trendax.com.tr",
                            VarsayilanEposta = true,
                            DurumId = 1
                        }
                    },
                    KisiTelefonlar  = new List<Telefon>
                    {
                        new Telefon
                        {
                            TelefonTipiId = 154,
                            TelefonNo = "05332713638",
                            VarsayilanTelefon = true,
                            DurumId = 1
                        },
                        new Telefon
                        {
                            TelefonTipiId = 155,
                            TelefonNo = "02122605262",
                            DahiliNo = "122",
                            VarsayilanTelefon = false,
                            DurumId = 1
                        },
                        new Telefon
                        {
                            TelefonTipiId = 156,
                            TelefonNo = "4447084",
                            VarsayilanTelefon = false,
                            DurumId = 1
                        },
                        new Telefon
                        {
                            TelefonTipiId = 157,
                            TelefonNo = "02124496227",
                            VarsayilanTelefon = false,
                            DurumId = 1
                        },
                    },
                    KisiAdresler = new List<Adres>
                    {
                        new Adres
                        {
                            AdresTipiId = 158,
                            AdresSatiri = "Asariye Caddesi Şeferliveli Sokak No:19 Kat:2 Daire:2",
                            IlceId = 431,
                            SehirId = 34,
                            UlkeId = 1,
                            VarsayilanAdres = true,
                            DurumId = 1
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

            #region //Firma
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
                            AdresTipiId = 159,
                            AdresSatiri = "Fetih Mahallesi Tahralı Sokak Esin Sitesi B Blok 10/5",
                            IlceId = 432,
                            SehirId = 34,
                            UlkeId = 1,
                            VarsayilanAdres = true,
                            DurumId = 1
                        },
                        new Adres
                        {
                            AdresTipiId = 159,
                            AdresSatiri = "Gebze Teknopark Beyaz Yazılım",
                            IlceId = 432,
                            SehirId = 34,
                            UlkeId = 1,
                            VarsayilanAdres = false,
                            DurumId = 1
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
                            AdresTipiId = 159,
                            AdresSatiri = "İnkılap Mahallesi Küçüksu Caddesi No:101 K:5 D:10",
                            IlceId = 431,
                            SehirId = 34,
                            UlkeId = 1,
                            VarsayilanAdres = true,
                            DurumId = 1
                        }
                    }
                }
            });
            #endregion

            context.SaveChanges();
        }
    }
}