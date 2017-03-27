namespace Tse.Dal.Backoffice.App_Start
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public partial class DummyDataConfig : CreateDatabaseIfNotExists<TseBackofficeContext>
    {
        //Methods    
        protected override void Seed(TseBackofficeContext context)
        {

            #region //Durum
            context.Durumlar.AddRange(new List<Durum>
            {
                new Durum { DurumID = 1, DurumAdi = "Aktif" },
                new Durum { DurumID = 2, DurumAdi = "Pasif" },
                new Durum { DurumID = 3, DurumAdi = "Taslak"},
                new Durum { DurumID = 4, DurumAdi = "Silinmiş" }
            });
            #endregion

            #region //Ulke
            context.Ulkeler.AddRange(new List<Ulke>
            {
                new Ulke
                {
                    UlkeID  = 1,
                    UlkeAdi = "Türkiye",
                    DurumID = 1,
                },
                new Ulke
                {
                    UlkeID  = 2,
                    UlkeAdi = "Almanya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 3,
                    UlkeAdi = "Amerika Birleşik Devletleri",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 4,
                    UlkeAdi = "Andora",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 5,
                    UlkeAdi = "Antigua ve Barbuda",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 6,
                    UlkeAdi = "Arjantin",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 7,
                    UlkeAdi = "Arnavutluk",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 8,
                    UlkeAdi = "Avusturalya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 9,
                    UlkeAdi = "Avusturya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 10,
                    UlkeAdi = "Azerbeycan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 11,
                    UlkeAdi = "Bahama",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 12,
                    UlkeAdi = "Bahreyn",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 13,
                    UlkeAdi = "Bangladeş",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 14,
                    UlkeAdi = "Bask Ülkesi",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 15,
                    UlkeAdi = "Batı Sahra",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 16,
                    UlkeAdi = "Belçika",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 17,
                    UlkeAdi = "Belize",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 18,
                    UlkeAdi = "Beyaz Rusya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 19,
                    UlkeAdi = "Bhutan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 20,
                    UlkeAdi = "Birleşik Arap Emirlikleri",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 21,
                    UlkeAdi = "Birleşik Devletler (ABD)",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 22,
                    UlkeAdi = "Birleşik Krallık",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 23,
                    UlkeAdi = "Bolivya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 24,
                    UlkeAdi = "Bosna-Hersek",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 25,
                    UlkeAdi = "Botsvana",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 26,
                    UlkeAdi = "Brezilya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 27,
                    UlkeAdi = "Bulgaristan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 28,
                    UlkeAdi = "Burma",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 29,
                    UlkeAdi = "Büyük Britanya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 30,
                    UlkeAdi = "Büyük Britanya ve Kuzey İrlanda Birleşik Krallığı",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 31,
                    UlkeAdi = "Cezayir",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 32,
                    UlkeAdi = "Cibuti",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 33,
                    UlkeAdi = "Çad",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 34,
                    UlkeAdi = "Çek Cumhuriyeti",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 35,
                    UlkeAdi = "Çin",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 36,
                    UlkeAdi = "Danimarka",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 37,
                    UlkeAdi = "Doğu Timor",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 38,
                    UlkeAdi = "Dominik Cumhuriyeti",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 39,
                    UlkeAdi = "Ekvator Ginesi",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 40,
                    UlkeAdi = "Eritre",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 41,
                    UlkeAdi = "Ermenistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 42,
                    UlkeAdi = "Estonya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 43,
                    UlkeAdi = "Etiyopya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 44,
                    UlkeAdi = "Faroe Adaları",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 45,
                    UlkeAdi = "Fas",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 46,
                    UlkeAdi = "Fiji",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 47,
                    UlkeAdi = "Fildişi Sahilleri",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 48,
                    UlkeAdi = "Filipinler",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 49,
                    UlkeAdi = "Finlandiya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 50,
                    UlkeAdi = "Fransa",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 51,
                    UlkeAdi = "Galler",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 52,
                    UlkeAdi = "Grönland",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 53,
                    UlkeAdi = "Güney Afrika",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 54,
                    UlkeAdi = "Gürcistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 55,
                    UlkeAdi = "Hırvatistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 56,
                    UlkeAdi = "Hindistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 57,
                    UlkeAdi = "Hollanda",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 58,
                    UlkeAdi = "Irak",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 59,
                    UlkeAdi = "İngiltere",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 60,
                    UlkeAdi = "İran",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 61,
                    UlkeAdi = "İrlanda",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 62,
                    UlkeAdi = "İrlanda Cumhuriyeti",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 63,
                    UlkeAdi = "İskoçya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 64,
                    UlkeAdi = "İspanya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 65,
                    UlkeAdi = "İsrail",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 66,
                    UlkeAdi = "İsveç",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 67,
                    UlkeAdi = "İsviçre",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 68,
                    UlkeAdi = "İtalya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 69,
                    UlkeAdi = "İzlanda",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 70,
                    UlkeAdi = "Jameika",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 71,
                    UlkeAdi = "Japonya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 72,
                    UlkeAdi = "Kamboçya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 73,
                    UlkeAdi = "Kamerun",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 74,
                    UlkeAdi = "Kanada",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 75,
                    UlkeAdi = "Karadağ",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 76,
                    UlkeAdi = "Kazakistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 77,
                    UlkeAdi = "Kıbrıs",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 78,
                    UlkeAdi = "Kırgızistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 79,
                    UlkeAdi = "Kolombiya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 80,
                    UlkeAdi = "Komoros",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 81,
                    UlkeAdi = "Kuzey İrlanda",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 82,
                    UlkeAdi = "Küba",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 83,
                    UlkeAdi = "Letonya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 84,
                    UlkeAdi = "Libya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 85,
                    UlkeAdi = "Lihtenştayn",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 86,
                    UlkeAdi = "litvanya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 87,
                    UlkeAdi = "Lübnan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 88,
                    UlkeAdi = "Lüksemburg",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 89,
                    UlkeAdi = "Macaristan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 90,
                    UlkeAdi = "Madagaskar",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 91,
                    UlkeAdi = "Makedonya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 92,
                    UlkeAdi = "Maldivler",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 93,
                    UlkeAdi = "Malezya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 94,
                    UlkeAdi = "Malta",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 95,
                    UlkeAdi = "Marshall Adaları",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 96,
                    UlkeAdi = "Meksika",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 97,
                    UlkeAdi = "Mısır",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 98,
                    UlkeAdi = "Moğolistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 99,
                    UlkeAdi = "Moldovya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 100,
                    UlkeAdi = "Monako",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 101,
                    UlkeAdi = "Mozambik",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 102,
                    UlkeAdi = "Myanmar",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 103,
                    UlkeAdi = "Norveç",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 104,
                    UlkeAdi = "Orta Afrika Cumhuriyeti",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 105,
                    UlkeAdi = "Özbekistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 106,
                    UlkeAdi = "Papua Yeni Gine",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 107,
                    UlkeAdi = "Polonya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 108,
                    UlkeAdi = "Portekiz",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 109,
                    UlkeAdi = "Romanya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 110,
                    UlkeAdi = "Rusya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 111,
                    UlkeAdi = "San Marino",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 112,
                    UlkeAdi = "Sırbistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 113,
                    UlkeAdi = "Sırbistan-Karadağ",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 114,
                    UlkeAdi = "Slovakya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 115,
                    UlkeAdi = "Slovenya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 116,
                    UlkeAdi = "Suriye",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 117,
                    UlkeAdi = "Suudi Arabistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 118,
                    UlkeAdi = "Şili",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 119,
                    UlkeAdi = "Tacikistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 120,
                    UlkeAdi = "Tayland",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 121,
                    UlkeAdi = "Tunus",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 122,
                    UlkeAdi = "Türkmenistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 123,
                    UlkeAdi = "Ukrayna",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 124,
                    UlkeAdi = "Ürdün",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 125,
                    UlkeAdi = "Vatikan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 126,
                    UlkeAdi = "Vietnam",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 127,
                    UlkeAdi = "Yemen",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 128,
                    UlkeAdi = "Yeni Zelanda",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 129,
                    UlkeAdi = "Yeşil Burun",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 130,
                    UlkeAdi = "Yunanistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 131,
                    UlkeAdi = "Zambiye",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 132,
                    UlkeAdi = "Zimbabve",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 133,
                    UlkeAdi = "Kuveyt",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 134,
                    UlkeAdi = "Pakistan",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 135,
                    UlkeAdi = "Güney Kore",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 136,
                    UlkeAdi = "Kuzey Kore",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 137,
                    UlkeAdi = "Singapur",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 138,
                    UlkeAdi = "Katar",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 139,
                    UlkeAdi = "Umman",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 140,
                    UlkeAdi = "Gana",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 141,
                    UlkeAdi = "Sri Lanka",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 142,
                    UlkeAdi = "Rusya",
                    DurumID = 1
                },
                new Ulke
                {
                    UlkeID  = 143,
                    UlkeAdi = "Afganistan",
                    DurumID = 1
                },
                 new Ulke
                {
                    UlkeID  = 144,
                    UlkeAdi = "Hong Kong",
                    DurumID = 1
                }
            });
            #endregion            

            #region //Sehir
            context.Sehirler.AddRange(new List<Sehir>
            {
                new Sehir
                {
                    SehirID = 1,
                    UlkeID = 1,
                    SehirAdi = "Adana",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 2,
                    UlkeID = 1,
                    SehirAdi = "Adıyaman",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 3,
                    UlkeID = 1,
                    SehirAdi = "Afyonkarahisar",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 4,
                    UlkeID = 1,
                    SehirAdi = "Ağrı",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 5,
                    UlkeID = 1,
                    SehirAdi = "Amasya",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 6,
                    UlkeID = 1,
                    SehirAdi = "Ankara",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 7,
                    UlkeID = 1,
                    SehirAdi = "Antalya",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 8,
                    UlkeID = 1,
                    SehirAdi = "Artvin",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 9,
                    UlkeID = 1,
                    SehirAdi = "Aydın",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 10,
                    UlkeID = 1,
                    SehirAdi = "Balıkesir",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 11,
                    UlkeID = 1,
                    SehirAdi = "Bilecik",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 12,
                    UlkeID = 1,
                    SehirAdi = "Bingöl",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 13,
                    UlkeID = 1,
                    SehirAdi = "Bitlis",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 14,
                    UlkeID = 1,
                    SehirAdi = "Bolu",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 15,
                    UlkeID = 1,
                    SehirAdi = "Burdur",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 16,
                    UlkeID = 1,
                    SehirAdi = "Bursa",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 17,
                    UlkeID = 1,
                    SehirAdi = "Çanakkale",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 18,
                    UlkeID = 1,
                    SehirAdi = "Çankırı",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 19,
                    UlkeID = 1,
                    SehirAdi = "Çorum",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 20,
                    UlkeID = 1,
                    SehirAdi = "Denizli",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 21,
                    UlkeID = 1,
                    SehirAdi = "Diyarbakır",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 22,
                    UlkeID = 1,
                    SehirAdi = "Edirne",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 23,
                    UlkeID = 1,
                    SehirAdi = "Elazığ",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 24,
                    UlkeID = 1,
                    SehirAdi = "Erzincan",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 25,
                    UlkeID = 1,
                    SehirAdi = "Erzurum",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 26,
                    UlkeID = 1,
                    SehirAdi = "Eskişehir",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 27,
                    UlkeID = 1,
                    SehirAdi = "Gaziantep",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 28,
                    UlkeID = 1,
                    SehirAdi = "Giresun",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 29,
                    UlkeID = 1,
                    SehirAdi = "Gümüşhane",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 30,
                    UlkeID = 1,
                    SehirAdi = "Hakkari",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 31,
                    UlkeID = 1,
                    SehirAdi = "Hatay",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 32,
                    UlkeID = 1,
                    SehirAdi = "Isparta",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 33,
                    UlkeID = 1,
                    SehirAdi = "Mersin",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 34,
                    UlkeID = 1,
                    SehirAdi = "İstanbul",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 35,
                    UlkeID = 1,
                    SehirAdi = "İzmir",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 36,
                    UlkeID = 1,
                    SehirAdi = "Kars",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 37,
                    UlkeID = 1,
                    SehirAdi = "Kastamonu",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 38,
                    UlkeID = 1,
                    SehirAdi = "Kayseri",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 39,
                    UlkeID = 1,
                    SehirAdi = "Kırklareli",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 40,
                    UlkeID = 1,
                    SehirAdi = "Kırşehir",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 41,
                    UlkeID = 1,
                    SehirAdi = "Kocaeli",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 42,
                    UlkeID = 1,
                    SehirAdi = "Konya",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 43,
                    UlkeID = 1,
                    SehirAdi = "Kütahya",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 44,
                    UlkeID = 1,
                    SehirAdi = "Malatya",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 45,
                    UlkeID = 1,
                    SehirAdi = "Manisa",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 46,
                    UlkeID = 1,
                    SehirAdi = "Kahramanmaraş",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 47,
                    UlkeID = 1,
                    SehirAdi = "Mardin",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 48,
                    UlkeID = 1,
                    SehirAdi = "Muğla",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 49,
                    UlkeID = 1,
                    SehirAdi = "Muş",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 50,
                    UlkeID = 1,
                    SehirAdi = "Nevşehir",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 51,
                    UlkeID = 1,
                    SehirAdi = "Niğde",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 52,
                    UlkeID = 1,
                    SehirAdi = "Ordu",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 53,
                    UlkeID = 1,
                    SehirAdi = "Rize",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 54,
                    UlkeID = 1,
                    SehirAdi = "Sakarya",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 55,
                    UlkeID = 1,
                    SehirAdi = "Samsun",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 56,
                    UlkeID = 1,
                    SehirAdi = "Siirt",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 57,
                    UlkeID = 1,
                    SehirAdi = "Sinop",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 58,
                    UlkeID = 1,
                    SehirAdi = "Sivas",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 59,
                    UlkeID = 1,
                    SehirAdi = "Tekirdağ",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 60,
                    UlkeID = 1,
                    SehirAdi = "Tokat",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 61,
                    UlkeID = 1,
                    SehirAdi = "Trabzon",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 62,
                    UlkeID = 1,
                    SehirAdi = "Tunceli",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 63,
                    UlkeID = 1,
                    SehirAdi = "Şanlıurfa",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 64,
                    UlkeID = 1,
                    SehirAdi = "Uşak",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 65,
                    UlkeID = 1,
                    SehirAdi = "Van",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 66,
                    UlkeID = 1,
                    SehirAdi = "Yozgat",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 67,
                    UlkeID = 1,
                    SehirAdi = "Zonguldak",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 68,
                    UlkeID = 1,
                    SehirAdi = "Aksaray",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 69,
                    UlkeID = 1,
                    SehirAdi = "Bayburt",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 70,
                    UlkeID = 1,
                    SehirAdi = "Karaman",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 71,
                    UlkeID = 1,
                    SehirAdi = "Kırıkkale",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 72,
                    UlkeID = 1,
                    SehirAdi = "Batman",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 73,
                    UlkeID = 1,
                    SehirAdi = "Şırnak",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 74,
                    UlkeID = 1,
                    SehirAdi = "Bartın",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 75,
                    UlkeID = 1,
                    SehirAdi = "Ardahan",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 76,
                    UlkeID = 1,
                    SehirAdi = "Iğdır",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 77,
                    UlkeID = 1,
                    SehirAdi = "Yalova",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 78,
                    UlkeID = 1,
                    SehirAdi = "Karabük",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 79,
                    UlkeID = 1,
                    SehirAdi = "Kilis",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 80,
                    UlkeID = 1,
                    SehirAdi = "Osmaniye",
                    DurumID = 1
                },
                new Sehir
                {
                    SehirID = 81,
                    UlkeID = 1,
                    SehirAdi = "Düzce",
                    DurumID = 1
                }
            });
            #endregion           

            #region //Ilce
            context.Ilceler.AddRange(new List<Ilce>
            {
                new Ilce
                {
                IlceID   = 1,
                SehirID  = 1,
                IlceKodu = 1104,
                IlceAdi  = "Seyhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 2,
                SehirID  = 1,
                IlceKodu = 1219,
                IlceAdi  = "Ceyhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 3,
                SehirID  = 1,
                IlceKodu = 1329,
                IlceAdi  = "Feke",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 4,
                SehirID  = 1,
                IlceKodu = 1437,
                IlceAdi  = "Karaisalı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 5,
                SehirID  = 1,
                IlceKodu = 1443,
                IlceAdi  = "Karataş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 6,
                SehirID  = 1,
                IlceKodu = 1486,
                IlceAdi  = "Kozan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 7,
                SehirID  = 1,
                IlceKodu = 1580,
                IlceAdi  = "Pozantı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 8,
                SehirID  = 1,
                IlceKodu = 1588,
                IlceAdi  = "Saimbeyli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 9,
                SehirID  = 1,
                IlceKodu = 1687,
                IlceAdi  = "Tufanbeyli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 10,
                SehirID  = 1,
                IlceKodu = 1734,
                IlceAdi  = "Yumurtalık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 11,
                SehirID  = 1,
                IlceKodu = 1748,
                IlceAdi  = "Yüreğir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 12,
                SehirID  = 1,
                IlceKodu = 1757,
                IlceAdi  = "Aladağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 13,
                SehirID  = 1,
                IlceKodu = 1806,
                IlceAdi  = "İmamoğlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 14,
                SehirID  = 1,
                IlceKodu = 2032,
                IlceAdi  = "Sarıçam",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 15,
                SehirID  = 1,
                IlceKodu = 2033,
                IlceAdi  = "Çukurova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 16,
                SehirID  = 2,
                IlceKodu = 1105,
                IlceAdi  = "Adıyaman Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 17,
                SehirID  = 2,
                IlceKodu = 1182,
                IlceAdi  = "Besni",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 18,
                SehirID  = 2,
                IlceKodu = 1246,
                IlceAdi  = "Çelikhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 19,
                SehirID  = 2,
                IlceKodu = 1347,
                IlceAdi  = "Gerger",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 20,
                SehirID  = 2,
                IlceKodu = 1354,
                IlceAdi  = "Gölbaşı / Adıyaman",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 21,
                SehirID  = 2,
                IlceKodu = 1425,
                IlceAdi  = "Kahta",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 22,
                SehirID  = 2,
                IlceKodu = 1592,
                IlceAdi  = "Samsat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 23,
                SehirID  = 2,
                IlceKodu = 1985,
                IlceAdi  = "Sincik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 24,
                SehirID  = 2,
                IlceKodu = 1989,
                IlceAdi  = "Tut",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 25,
                SehirID  = 3,
                IlceKodu = 1108,
                IlceAdi  = "Afyonkarahisar Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 26,
                SehirID  = 3,
                IlceKodu = 1200,
                IlceAdi  = "Bolvadin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 27,
                SehirID  = 3,
                IlceKodu = 1239,
                IlceAdi  = "Çay",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 28,
                SehirID  = 3,
                IlceKodu = 1267,
                IlceAdi  = "Dazkırı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 29,
                SehirID  = 3,
                IlceKodu = 1281,
                IlceAdi  = "Dinar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 30,
                SehirID  = 3,
                IlceKodu = 1306,
                IlceAdi  = "Emirdağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 31,
                SehirID  = 3,
                IlceKodu = 1404,
                IlceAdi  = "İhsaniye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 32,
                SehirID  = 3,
                IlceKodu = 1594,
                IlceAdi  = "Sandıklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 33,
                SehirID  = 3,
                IlceKodu = 1626,
                IlceAdi  = "Sinanpaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 34,
                SehirID  = 3,
                IlceKodu = 1639,
                IlceAdi  = "Sultandağı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 35,
                SehirID  = 3,
                IlceKodu = 1664,
                IlceAdi  = "Şuhut",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 36,
                SehirID  = 3,
                IlceKodu = 1771,
                IlceAdi  = "Başmakçı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 37,
                SehirID  = 3,
                IlceKodu = 1773,
                IlceAdi  = "Bayat / Afyonkarahisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 38,
                SehirID  = 3,
                IlceKodu = 1809,
                IlceAdi  = "İscehisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 39,
                SehirID  = 3,
                IlceKodu = 1906,
                IlceAdi  = "Çobanlar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 40,
                SehirID  = 3,
                IlceKodu = 1923,
                IlceAdi  = "Evciler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 41,
                SehirID  = 3,
                IlceKodu = 1944,
                IlceAdi  = "Hocalar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 42,
                SehirID  = 3,
                IlceKodu = 1961,
                IlceAdi  = "Kızılören",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 43,
                SehirID  = 4,
                IlceKodu = 1111,
                IlceAdi  = "Ağrı Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 44,
                SehirID  = 4,
                IlceKodu = 1283,
                IlceAdi  = "Diyadin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 45,
                SehirID  = 4,
                IlceKodu = 1287,
                IlceAdi  = "Doğubayazıt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 46,
                SehirID  = 4,
                IlceKodu = 1301,
                IlceAdi  = "Eleşkirt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 47,
                SehirID  = 4,
                IlceKodu = 1379,
                IlceAdi  = "Hamur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 48,
                SehirID  = 4,
                IlceKodu = 1568,
                IlceAdi  = "Patnos",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 49,
                SehirID  = 4,
                IlceKodu = 1667,
                IlceAdi  = "Taşlıçay",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 50,
                SehirID  = 4,
                IlceKodu = 1691,
                IlceAdi  = "Tutak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 51,
                SehirID  = 5,
                IlceKodu = 1134,
                IlceAdi  = "Amasya Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 52,
                SehirID  = 5,
                IlceKodu = 1363,
                IlceAdi  = "Göynücek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 53,
                SehirID  = 5,
                IlceKodu = 1368,
                IlceAdi  = "Gümüşhacıköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 54,
                SehirID  = 5,
                IlceKodu = 1524,
                IlceAdi  = "Merzifon",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 55,
                SehirID  = 5,
                IlceKodu = 1641,
                IlceAdi  = "Suluova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 56,
                SehirID  = 5,
                IlceKodu = 1668,
                IlceAdi  = "Taşova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 57,
                SehirID  = 5,
                IlceKodu = 1938,
                IlceAdi  = "Hamamözü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 58,
                SehirID  = 6,
                IlceKodu = 1130,
                IlceAdi  = "Altındağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 59,
                SehirID  = 6,
                IlceKodu = 1157,
                IlceAdi  = "Ayaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 60,
                SehirID  = 6,
                IlceKodu = 1167,
                IlceAdi  = "Bala",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 61,
                SehirID  = 6,
                IlceKodu = 1187,
                IlceAdi  = "Beypazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 62,
                SehirID  = 6,
                IlceKodu = 1227,
                IlceAdi  = "Çamlıdere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 63,
                SehirID  = 6,
                IlceKodu = 1231,
                IlceAdi  = "Çankaya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 64,
                SehirID  = 6,
                IlceKodu = 1260,
                IlceAdi  = "Çubuk",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 65,
                SehirID  = 6,
                IlceKodu = 1302,
                IlceAdi  = "Elmadağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 66,
                SehirID  = 6,
                IlceKodu = 1365,
                IlceAdi  = "Güdül",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 67,
                SehirID  = 6,
                IlceKodu = 1387,
                IlceAdi  = "Haymana",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 68,
                SehirID  = 6,
                IlceKodu = 1427,
                IlceAdi  = "Kalecik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 69,
                SehirID  = 6,
                IlceKodu = 1473,
                IlceAdi  = "Kızılcahamam",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 70,
                SehirID  = 6,
                IlceKodu = 1539,
                IlceAdi  = "Nallıhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 71,
                SehirID  = 6,
                IlceKodu = 1578,
                IlceAdi  = "Polatlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 72,
                SehirID  = 6,
                IlceKodu = 1658,
                IlceAdi  = "Şereflikoçhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 73,
                SehirID  = 6,
                IlceKodu = 1723,
                IlceAdi  = "Yenimahalle",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 74,
                SehirID  = 6,
                IlceKodu = 1744,
                IlceAdi  = "Gölbaşı / Ankara",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 75,
                SehirID  = 6,
                IlceKodu = 1745,
                IlceAdi  = "Keçiören",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 76,
                SehirID  = 6,
                IlceKodu = 1746,
                IlceAdi  = "Mamak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 77,
                SehirID  = 6,
                IlceKodu = 1747,
                IlceAdi  = "Sincan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 78,
                SehirID  = 6,
                IlceKodu = 1815,
                IlceAdi  = "Kazan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 79,
                SehirID  = 6,
                IlceKodu = 1872,
                IlceAdi  = "Akyurt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 80,
                SehirID  = 6,
                IlceKodu = 1922,
                IlceAdi  = "Etimesgut",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 81,
                SehirID  = 6,
                IlceKodu = 1924,
                IlceAdi  = "Evren",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 82,
                SehirID  = 6,
                IlceKodu = 2034,
                IlceAdi  = "Pursaklar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 83,
                SehirID  = 7,
                IlceKodu = 1121,
                IlceAdi  = "Akseki",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 84,
                SehirID  = 7,
                IlceKodu = 1126,
                IlceAdi  = "Alanya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 85,
                SehirID  = 7,
                IlceKodu = 1138,
                IlceAdi  = "Antalya Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 86,
                SehirID  = 7,
                IlceKodu = 1303,
                IlceAdi  = "Elmalı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 87,
                SehirID  = 7,
                IlceKodu = 1333,
                IlceAdi  = "Finike",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 88,
                SehirID  = 7,
                IlceKodu = 1337,
                IlceAdi  = "Gazipaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 89,
                SehirID  = 7,
                IlceKodu = 1370,
                IlceAdi  = "Gündoğmuş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 90,
                SehirID  = 7,
                IlceKodu = 1451,
                IlceAdi  = "Kaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 91,
                SehirID  = 7,
                IlceKodu = 1483,
                IlceAdi  = "Korkuteli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 92,
                SehirID  = 7,
                IlceKodu = 1492,
                IlceAdi  = "Kumluca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 93,
                SehirID  = 7,
                IlceKodu = 1512,
                IlceAdi  = "Manavgat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 94,
                SehirID  = 7,
                IlceKodu = 1616,
                IlceAdi  = "Serik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 95,
                SehirID  = 7,
                IlceKodu = 1811,
                IlceAdi  = "Demre",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 96,
                SehirID  = 7,
                IlceKodu = 1946,
                IlceAdi  = "İbradı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 97,
                SehirID  = 7,
                IlceKodu = 1959,
                IlceAdi  = "Kemer / Antalya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 98,
                SehirID  = 7,
                IlceKodu = 2035,
                IlceAdi  = "Aksu / Antalya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 99,
                SehirID  = 7,
                IlceKodu = 2036,
                IlceAdi  = "Döşemealtı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 100,
                SehirID  = 7,
                IlceKodu = 2037,
                IlceAdi  = "Kepez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 101,
                SehirID  = 7,
                IlceKodu = 2038,
                IlceAdi  = "Konyaaltı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 102,
                SehirID  = 7,
                IlceKodu = 2039,
                IlceAdi  = "Muratpaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 103,
                SehirID  = 8,
                IlceKodu = 1145,
                IlceAdi  = "Ardanuç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 104,
                SehirID  = 8,
                IlceKodu = 1147,
                IlceAdi  = "Arhavi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 105,
                SehirID  = 8,
                IlceKodu = 1152,
                IlceAdi  = "Artvin Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 106,
                SehirID  = 8,
                IlceKodu = 1202,
                IlceAdi  = "Borçka",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 107,
                SehirID  = 8,
                IlceKodu = 1395,
                IlceAdi  = "Hopa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 108,
                SehirID  = 8,
                IlceKodu = 1653,
                IlceAdi  = "Şavşat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 109,
                SehirID  = 8,
                IlceKodu = 1736,
                IlceAdi  = "Yusufeli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 110,
                SehirID  = 8,
                IlceKodu = 1828,
                IlceAdi  = "Murgul",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 111,
                SehirID  = 9,
                IlceKodu = 1159,
                IlceAdi  = "Aydın Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 112,
                SehirID  = 9,
                IlceKodu = 1206,
                IlceAdi  = "Bozdoğan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 113,
                SehirID  = 9,
                IlceKodu = 1256,
                IlceAdi  = "Çine",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 114,
                SehirID  = 9,
                IlceKodu = 1348,
                IlceAdi  = "Germencik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 115,
                SehirID  = 9,
                IlceKodu = 1435,
                IlceAdi  = "Karacasu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 116,
                SehirID  = 9,
                IlceKodu = 1479,
                IlceAdi  = "Koçarlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 117,
                SehirID  = 9,
                IlceKodu = 1497,
                IlceAdi  = "Kuşadası",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 118,
                SehirID  = 9,
                IlceKodu = 1498,
                IlceAdi  = "Kuyucak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 119,
                SehirID  = 9,
                IlceKodu = 1542,
                IlceAdi  = "Nazilli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 120,
                SehirID  = 9,
                IlceKodu = 1637,
                IlceAdi  = "Söke",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 121,
                SehirID  = 9,
                IlceKodu = 1640,
                IlceAdi  = "Sultanhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 122,
                SehirID  = 9,
                IlceKodu = 1724,
                IlceAdi  = "Yenipazar / Aydın",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 123,
                SehirID  = 9,
                IlceKodu = 1781,
                IlceAdi  = "Buharkent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 124,
                SehirID  = 9,
                IlceKodu = 1807,
                IlceAdi  = "İncirliova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 125,
                SehirID  = 9,
                IlceKodu = 1957,
                IlceAdi  = "Karpuzlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 126,
                SehirID  = 9,
                IlceKodu = 1968,
                IlceAdi  = "Köşk",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 127,
                SehirID  = 9,
                IlceKodu = 2000,
                IlceAdi  = "Didim",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 128,
                SehirID  = 9,
                IlceKodu = 2076,
                IlceAdi  = "Efeler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 129,
                SehirID  = 10,
                IlceKodu = 1161,
                IlceAdi  = "Ayvalık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 130,
                SehirID  = 10,
                IlceKodu = 1168,
                IlceAdi  = "Balıkesir Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 131,
                SehirID  = 10,
                IlceKodu = 1169,
                IlceAdi  = "Balya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 132,
                SehirID  = 10,
                IlceKodu = 1171,
                IlceAdi  = "Bandırma",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 133,
                SehirID  = 10,
                IlceKodu = 1191,
                IlceAdi  = "Bigadiç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 134,
                SehirID  = 10,
                IlceKodu = 1216,
                IlceAdi  = "Burhaniye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 135,
                SehirID  = 10,
                IlceKodu = 1291,
                IlceAdi  = "Dursunbey",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 136,
                SehirID  = 10,
                IlceKodu = 1294,
                IlceAdi  = "Edremit / Balıkesir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 137,
                SehirID  = 10,
                IlceKodu = 1310,
                IlceAdi  = "Erdek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 138,
                SehirID  = 10,
                IlceKodu = 1360,
                IlceAdi  = "Gönen / Balıkesir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 139,
                SehirID  = 10,
                IlceKodu = 1384,
                IlceAdi  = "Havran",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 140,
                SehirID  = 10,
                IlceKodu = 1418,
                IlceAdi  = "İvrindi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 141,
                SehirID  = 10,
                IlceKodu = 1462,
                IlceAdi  = "Kepsut",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 142,
                SehirID  = 10,
                IlceKodu = 1514,
                IlceAdi  = "Manyas",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 143,
                SehirID  = 10,
                IlceKodu = 1608,
                IlceAdi  = "Savaştepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 144,
                SehirID  = 10,
                IlceKodu = 1619,
                IlceAdi  = "Sındırgı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 145,
                SehirID  = 10,
                IlceKodu = 1644,
                IlceAdi  = "Susurluk",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 146,
                SehirID  = 10,
                IlceKodu = 1824,
                IlceAdi  = "Marmara",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 147,
                SehirID  = 10,
                IlceKodu = 1928,
                IlceAdi  = "Gömeç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 148,
                SehirID  = 10,
                IlceKodu = 2077,
                IlceAdi  = "Altıeylül",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 149,
                SehirID  = 10,
                IlceKodu = 2078,
                IlceAdi  = "Karesi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 150,
                SehirID  = 11,
                IlceKodu = 1192,
                IlceAdi  = "Bilecik Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 151,
                SehirID  = 11,
                IlceKodu = 1210,
                IlceAdi  = "Bozüyük",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 152,
                SehirID  = 11,
                IlceKodu = 1359,
                IlceAdi  = "Gölpazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 153,
                SehirID  = 11,
                IlceKodu = 1559,
                IlceAdi  = "Osmaneli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 154,
                SehirID  = 11,
                IlceKodu = 1571,
                IlceAdi  = "Pazaryeri",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 155,
                SehirID  = 11,
                IlceKodu = 1636,
                IlceAdi  = "Söğüt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 156,
                SehirID  = 11,
                IlceKodu = 1857,
                IlceAdi  = "Yenipazar / Bilecik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 157,
                SehirID  = 11,
                IlceKodu = 1948,
                IlceAdi  = "İnhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 158,
                SehirID  = 12,
                IlceKodu = 1193,
                IlceAdi  = "Bingöl Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 159,
                SehirID  = 12,
                IlceKodu = 1344,
                IlceAdi  = "Genç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 160,
                SehirID  = 12,
                IlceKodu = 1446,
                IlceAdi  = "Karlıova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 161,
                SehirID  = 12,
                IlceKodu = 1475,
                IlceAdi  = "Kiğı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 162,
                SehirID  = 12,
                IlceKodu = 1633,
                IlceAdi  = "Solhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 163,
                SehirID  = 12,
                IlceKodu = 1750,
                IlceAdi  = "Adaklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 164,
                SehirID  = 12,
                IlceKodu = 1855,
                IlceAdi  = "Yayladere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 165,
                SehirID  = 12,
                IlceKodu = 1996,
                IlceAdi  = "Yedisu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 166,
                SehirID  = 13,
                IlceKodu = 1106,
                IlceAdi  = "Adilcevaz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 167,
                SehirID  = 13,
                IlceKodu = 1112,
                IlceAdi  = "Ahlat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 168,
                SehirID  = 13,
                IlceKodu = 1196,
                IlceAdi  = "Bitlis Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 169,
                SehirID  = 13,
                IlceKodu = 1394,
                IlceAdi  = "Hizan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 170,
                SehirID  = 13,
                IlceKodu = 1537,
                IlceAdi  = "Mutki",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 171,
                SehirID  = 13,
                IlceKodu = 1669,
                IlceAdi  = "Tatvan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 172,
                SehirID  = 13,
                IlceKodu = 1798,
                IlceAdi  = "Güroymak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 173,
                SehirID  = 14,
                IlceKodu = 1199,
                IlceAdi  = "Bolu Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 174,
                SehirID  = 14,
                IlceKodu = 1346,
                IlceAdi  = "Gerede",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 175,
                SehirID  = 14,
                IlceKodu = 1364,
                IlceAdi  = "Göynük",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 176,
                SehirID  = 14,
                IlceKodu = 1466,
                IlceAdi  = "Kıbrıscık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 177,
                SehirID  = 14,
                IlceKodu = 1522,
                IlceAdi  = "Mengen",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 178,
                SehirID  = 14,
                IlceKodu = 1531,
                IlceAdi  = "Mudurnu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 179,
                SehirID  = 14,
                IlceKodu = 1610,
                IlceAdi  = "Seben",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 180,
                SehirID  = 14,
                IlceKodu = 1916,
                IlceAdi  = "Dörtdivan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 181,
                SehirID  = 14,
                IlceKodu = 1997,
                IlceAdi  = "Yeniçağa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 182,
                SehirID  = 15,
                IlceKodu = 1109,
                IlceAdi  = "Ağlasun",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 183,
                SehirID  = 15,
                IlceKodu = 1211,
                IlceAdi  = "Bucak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 184,
                SehirID  = 15,
                IlceKodu = 1215,
                IlceAdi  = "Burdur Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 185,
                SehirID  = 15,
                IlceKodu = 1357,
                IlceAdi  = "Gölhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 186,
                SehirID  = 15,
                IlceKodu = 1672,
                IlceAdi  = "Tefenni",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 187,
                SehirID  = 15,
                IlceKodu = 1728,
                IlceAdi  = "Yeşilova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 188,
                SehirID  = 15,
                IlceKodu = 1813,
                IlceAdi  = "Karamanlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 189,
                SehirID  = 15,
                IlceKodu = 1816,
                IlceAdi  = "Kemer / Burdur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 190,
                SehirID  = 15,
                IlceKodu = 1874,
                IlceAdi  = "Altınyayla / Burdur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 191,
                SehirID  = 15,
                IlceKodu = 1899,
                IlceAdi  = "Çavdır",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 192,
                SehirID  = 15,
                IlceKodu = 1903,
                IlceAdi  = "Çeltikçi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 193,
                SehirID  = 16,
                IlceKodu = 1343,
                IlceAdi  = "Gemlik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 194,
                SehirID  = 16,
                IlceKodu = 1411,
                IlceAdi  = "İnegöl",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 195,
                SehirID  = 16,
                IlceKodu = 1420,
                IlceAdi  = "İznik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 196,
                SehirID  = 16,
                IlceKodu = 1434,
                IlceAdi  = "Karacabey",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 197,
                SehirID  = 16,
                IlceKodu = 1457,
                IlceAdi  = "Keles",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 198,
                SehirID  = 16,
                IlceKodu = 1530,
                IlceAdi  = "Mudanya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 199,
                SehirID  = 16,
                IlceKodu = 1535,
                IlceAdi  = "Mustafakemalpaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 200,
                SehirID  = 16,
                IlceKodu = 1553,
                IlceAdi  = "Orhaneli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 201,
                SehirID  = 16,
                IlceKodu = 1554,
                IlceAdi  = "Orhangazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 202,
                SehirID  = 16,
                IlceKodu = 1725,
                IlceAdi  = "Yenişehir / Bursa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 203,
                SehirID  = 16,
                IlceKodu = 1783,
                IlceAdi  = "Büyükorhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 204,
                SehirID  = 16,
                IlceKodu = 1799,
                IlceAdi  = "Harmancık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 205,
                SehirID  = 16,
                IlceKodu = 1829,
                IlceAdi  = "Nilüfer",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 206,
                SehirID  = 16,
                IlceKodu = 1832,
                IlceAdi  = "Osmangazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 207,
                SehirID  = 16,
                IlceKodu = 1859,
                IlceAdi  = "Yıldırım",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 208,
                SehirID  = 16,
                IlceKodu = 1935,
                IlceAdi  = "Gürsu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 209,
                SehirID  = 16,
                IlceKodu = 1960,
                IlceAdi  = "Kestel",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 210,
                SehirID  = 17,
                IlceKodu = 1160,
                IlceAdi  = "Ayvacık / Çanakkale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 211,
                SehirID  = 17,
                IlceKodu = 1180,
                IlceAdi  = "Bayramiç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 212,
                SehirID  = 17,
                IlceKodu = 1190,
                IlceAdi  = "Biga",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 213,
                SehirID  = 17,
                IlceKodu = 1205,
                IlceAdi  = "Bozcaada",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 214,
                SehirID  = 17,
                IlceKodu = 1229,
                IlceAdi  = "Çan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 215,
                SehirID  = 17,
                IlceKodu = 1230,
                IlceAdi  = "Çanakkale Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 216,
                SehirID  = 17,
                IlceKodu = 1293,
                IlceAdi  = "Eceabat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 217,
                SehirID  = 17,
                IlceKodu = 1326,
                IlceAdi  = "Ezine",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 218,
                SehirID  = 17,
                IlceKodu = 1340,
                IlceAdi  = "Gelibolu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 219,
                SehirID  = 17,
                IlceKodu = 1408,
                IlceAdi  = "Gökçeada",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 220,
                SehirID  = 17,
                IlceKodu = 1503,
                IlceAdi  = "Lapseki",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 221,
                SehirID  = 17,
                IlceKodu = 1722,
                IlceAdi  = "Yenice / Çanakkale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 222,
                SehirID  = 18,
                IlceKodu = 1232,
                IlceAdi  = "Çankırı Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 223,
                SehirID  = 18,
                IlceKodu = 1248,
                IlceAdi  = "Çerkeş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 224,
                SehirID  = 18,
                IlceKodu = 1300,
                IlceAdi  = "Eldivan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 225,
                SehirID  = 18,
                IlceKodu = 1399,
                IlceAdi  = "Ilgaz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 226,
                SehirID  = 18,
                IlceKodu = 1494,
                IlceAdi  = "Kurşunlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 227,
                SehirID  = 18,
                IlceKodu = 1555,
                IlceAdi  = "Orta",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 228,
                SehirID  = 18,
                IlceKodu = 1649,
                IlceAdi  = "Şabanözü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 229,
                SehirID  = 18,
                IlceKodu = 1718,
                IlceAdi  = "Yapraklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 230,
                SehirID  = 18,
                IlceKodu = 1765,
                IlceAdi  = "Atkaracalar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 231,
                SehirID  = 18,
                IlceKodu = 1817,
                IlceAdi  = "Kızılırmak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 232,
                SehirID  = 18,
                IlceKodu = 1885,
                IlceAdi  = "Bayramören",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 233,
                SehirID  = 18,
                IlceKodu = 1963,
                IlceAdi  = "Korgun",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 234,
                SehirID  = 19,
                IlceKodu = 1124,
                IlceAdi  = "Alaca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 235,
                SehirID  = 19,
                IlceKodu = 1177,
                IlceAdi  = "Bayat / Çorum",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 236,
                SehirID  = 19,
                IlceKodu = 1259,
                IlceAdi  = "Çorum Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 237,
                SehirID  = 19,
                IlceKodu = 1414,
                IlceAdi  = "İskilip",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 238,
                SehirID  = 19,
                IlceKodu = 1445,
                IlceAdi  = "Kargı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 239,
                SehirID  = 19,
                IlceKodu = 1520,
                IlceAdi  = "Mecitözü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 240,
                SehirID  = 19,
                IlceKodu = 1556,
                IlceAdi  = "Ortaköy / Çorum",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 241,
                SehirID  = 19,
                IlceKodu = 1558,
                IlceAdi  = "Osmancık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 242,
                SehirID  = 19,
                IlceKodu = 1642,
                IlceAdi  = "Sungurlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 243,
                SehirID  = 19,
                IlceKodu = 1778,
                IlceAdi  = "Boğazkale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 244,
                SehirID  = 19,
                IlceKodu = 1850,
                IlceAdi  = "Uğurludağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 245,
                SehirID  = 19,
                IlceKodu = 1911,
                IlceAdi  = "Dodurga",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 246,
                SehirID  = 19,
                IlceKodu = 1972,
                IlceAdi  = "Laçin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 247,
                SehirID  = 19,
                IlceKodu = 1976,
                IlceAdi  = "Oğuzlar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 248,
                SehirID  = 20,
                IlceKodu = 1102,
                IlceAdi  = "Acıpayam",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 249,
                SehirID  = 20,
                IlceKodu = 1214,
                IlceAdi  = "Buldan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 250,
                SehirID  = 20,
                IlceKodu = 1224,
                IlceAdi  = "Çal",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 251,
                SehirID  = 20,
                IlceKodu = 1226,
                IlceAdi  = "Çameli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 252,
                SehirID  = 20,
                IlceKodu = 1233,
                IlceAdi  = "Çardak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 253,
                SehirID  = 20,
                IlceKodu = 1257,
                IlceAdi  = "Çivril",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 254,
                SehirID  = 20,
                IlceKodu = 1271,
                IlceAdi  = "Denizli Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 255,
                SehirID  = 20,
                IlceKodu = 1371,
                IlceAdi  = "Güney",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 256,
                SehirID  = 20,
                IlceKodu = 1426,
                IlceAdi  = "Kale / Denizli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 257,
                SehirID  = 20,
                IlceKodu = 1597,
                IlceAdi  = "Sarayköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 258,
                SehirID  = 20,
                IlceKodu = 1670,
                IlceAdi  = "Tavas",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 259,
                SehirID  = 20,
                IlceKodu = 1769,
                IlceAdi  = "Babadağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 260,
                SehirID  = 20,
                IlceKodu = 1774,
                IlceAdi  = "Bekilli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 261,
                SehirID  = 20,
                IlceKodu = 1803,
                IlceAdi  = "Honaz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 262,
                SehirID  = 20,
                IlceKodu = 1840,
                IlceAdi  = "Serinhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 263,
                SehirID  = 20,
                IlceKodu = 1871,
                IlceAdi  = "Pamukkale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 264,
                SehirID  = 20,
                IlceKodu = 1881,
                IlceAdi  = "Baklan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 265,
                SehirID  = 20,
                IlceKodu = 1888,
                IlceAdi  = "Beyağaç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 266,
                SehirID  = 20,
                IlceKodu = 1889,
                IlceAdi  = "Bozkurt / Denizli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 267,
                SehirID  = 20,
                IlceKodu = 2079,
                IlceAdi  = "Merkezefendi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 268,
                SehirID  = 21,
                IlceKodu = 1195,
                IlceAdi  = "Bismil",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 269,
                SehirID  = 21,
                IlceKodu = 1249,
                IlceAdi  = "Çermik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 270,
                SehirID  = 21,
                IlceKodu = 1253,
                IlceAdi  = "Çınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 271,
                SehirID  = 21,
                IlceKodu = 1263,
                IlceAdi  = "Çüngüş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 272,
                SehirID  = 21,
                IlceKodu = 1278,
                IlceAdi  = "Dicle",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 273,
                SehirID  = 21,
                IlceKodu = 1284,
                IlceAdi  = "Diyarbakır Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 274,
                SehirID  = 21,
                IlceKodu = 1315,
                IlceAdi  = "Ergani",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 275,
                SehirID  = 21,
                IlceKodu = 1381,
                IlceAdi  = "Hani",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 276,
                SehirID  = 21,
                IlceKodu = 1389,
                IlceAdi  = "Hazro",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 277,
                SehirID  = 21,
                IlceKodu = 1490,
                IlceAdi  = "Kulp",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 278,
                SehirID  = 21,
                IlceKodu = 1504,
                IlceAdi  = "Lice",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 279,
                SehirID  = 21,
                IlceKodu = 1624,
                IlceAdi  = "Silvan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 280,
                SehirID  = 21,
                IlceKodu = 1791,
                IlceAdi  = "Eğil",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 281,
                SehirID  = 21,
                IlceKodu = 1962,
                IlceAdi  = "Kocaköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 282,
                SehirID  = 21,
                IlceKodu = 2040,
                IlceAdi  = "Bağlar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 283,
                SehirID  = 21,
                IlceKodu = 2041,
                IlceAdi  = "Kayapınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 284,
                SehirID  = 21,
                IlceKodu = 2042,
                IlceAdi  = "Sur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 285,
                SehirID  = 21,
                IlceKodu = 2043,
                IlceAdi  = "Yenişehir / Diyarbakır",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 286,
                SehirID  = 22,
                IlceKodu = 1295,
                IlceAdi  = "Edirne Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 287,
                SehirID  = 22,
                IlceKodu = 1307,
                IlceAdi  = "Enez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 288,
                SehirID  = 22,
                IlceKodu = 1385,
                IlceAdi  = "Havsa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 289,
                SehirID  = 22,
                IlceKodu = 1412,
                IlceAdi  = "İpsala",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 290,
                SehirID  = 22,
                IlceKodu = 1464,
                IlceAdi  = "Keşan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 291,
                SehirID  = 22,
                IlceKodu = 1502,
                IlceAdi  = "Lalapaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 292,
                SehirID  = 22,
                IlceKodu = 1523,
                IlceAdi  = "Meriç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 293,
                SehirID  = 22,
                IlceKodu = 1705,
                IlceAdi  = "Uzunköprü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 294,
                SehirID  = 22,
                IlceKodu = 1988,
                IlceAdi  = "Süloğlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 295,
                SehirID  = 23,
                IlceKodu = 1110,
                IlceAdi  = "Ağın",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 296,
                SehirID  = 23,
                IlceKodu = 1173,
                IlceAdi  = "Baskil",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 297,
                SehirID  = 23,
                IlceKodu = 1298,
                IlceAdi  = "Elazığ Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 298,
                SehirID  = 23,
                IlceKodu = 1438,
                IlceAdi  = "Karakoçan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 299,
                SehirID  = 23,
                IlceKodu = 1455,
                IlceAdi  = "Keban",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 300,
                SehirID  = 23,
                IlceKodu = 1506,
                IlceAdi  = "Maden",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 301,
                SehirID  = 23,
                IlceKodu = 1566,
                IlceAdi  = "Palu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 302,
                SehirID  = 23,
                IlceKodu = 1631,
                IlceAdi  = "Sivrice",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 303,
                SehirID  = 23,
                IlceKodu = 1762,
                IlceAdi  = "Arıcak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 304,
                SehirID  = 23,
                IlceKodu = 1820,
                IlceAdi  = "Kovancılar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 305,
                SehirID  = 23,
                IlceKodu = 1873,
                IlceAdi  = "Alacakaya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 306,
                SehirID  = 24,
                IlceKodu = 1243,
                IlceAdi  = "Çayırlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 307,
                SehirID  = 24,
                IlceKodu = 1318,
                IlceAdi  = "Erzincan Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 308,
                SehirID  = 24,
                IlceKodu = 1406,
                IlceAdi  = "İliç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 309,
                SehirID  = 24,
                IlceKodu = 1459,
                IlceAdi  = "Kemah",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 310,
                SehirID  = 24,
                IlceKodu = 1460,
                IlceAdi  = "Kemaliye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 311,
                SehirID  = 24,
                IlceKodu = 1583,
                IlceAdi  = "Refahiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 312,
                SehirID  = 24,
                IlceKodu = 1675,
                IlceAdi  = "Tercan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 313,
                SehirID  = 24,
                IlceKodu = 1853,
                IlceAdi  = "Üzümlü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 314,
                SehirID  = 24,
                IlceKodu = 1977,
                IlceAdi  = "Otlukbeli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 315,
                SehirID  = 25,
                IlceKodu = 1153,
                IlceAdi  = "Aşkale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 316,
                SehirID  = 25,
                IlceKodu = 1235,
                IlceAdi  = "Çat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 317,
                SehirID  = 25,
                IlceKodu = 1319,
                IlceAdi  = "Erzurum Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 318,
                SehirID  = 25,
                IlceKodu = 1392,
                IlceAdi  = "Hınıs",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 319,
                SehirID  = 25,
                IlceKodu = 1396,
                IlceAdi  = "Horasan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 320,
                SehirID  = 25,
                IlceKodu = 1416,
                IlceAdi  = "İspir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 321,
                SehirID  = 25,
                IlceKodu = 1444,
                IlceAdi  = "Karayazı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 322,
                SehirID  = 25,
                IlceKodu = 1540,
                IlceAdi  = "Narman",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 323,
                SehirID  = 25,
                IlceKodu = 1550,
                IlceAdi  = "Oltu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 324,
                SehirID  = 25,
                IlceKodu = 1551,
                IlceAdi  = "Olur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 325,
                SehirID  = 25,
                IlceKodu = 1567,
                IlceAdi  = "Pasinler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 326,
                SehirID  = 25,
                IlceKodu = 1657,
                IlceAdi  = "Şenkaya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 327,
                SehirID  = 25,
                IlceKodu = 1674,
                IlceAdi  = "Tekman",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 328,
                SehirID  = 25,
                IlceKodu = 1683,
                IlceAdi  = "Tortum",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 329,
                SehirID  = 25,
                IlceKodu = 1812,
                IlceAdi  = "Karaçoban",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 330,
                SehirID  = 25,
                IlceKodu = 1851,
                IlceAdi  = "Uzundere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 331,
                SehirID  = 25,
                IlceKodu = 1865,
                IlceAdi  = "Pazaryolu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 332,
                SehirID  = 25,
                IlceKodu = 1945,
                IlceAdi  = "Aziziye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 333,
                SehirID  = 25,
                IlceKodu = 1967,
                IlceAdi  = "Köprüköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 334,
                SehirID  = 25,
                IlceKodu = 2044,
                IlceAdi  = "Palandöken",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 335,
                SehirID  = 25,
                IlceKodu = 2045,
                IlceAdi  = "Yakutiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 336,
                SehirID  = 26,
                IlceKodu = 1255,
                IlceAdi  = "Çifteler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 337,
                SehirID  = 26,
                IlceKodu = 1322,
                IlceAdi  = "Eskişehir Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 338,
                SehirID  = 26,
                IlceKodu = 1508,
                IlceAdi  = "Mahmudiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 339,
                SehirID  = 26,
                IlceKodu = 1527,
                IlceAdi  = "Mihalıççık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 340,
                SehirID  = 26,
                IlceKodu = 1599,
                IlceAdi  = "Sarıcakaya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 341,
                SehirID  = 26,
                IlceKodu = 1618,
                IlceAdi  = "Seyitgazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 342,
                SehirID  = 26,
                IlceKodu = 1632,
                IlceAdi  = "Sivrihisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 343,
                SehirID  = 26,
                IlceKodu = 1759,
                IlceAdi  = "Alpu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 344,
                SehirID  = 26,
                IlceKodu = 1777,
                IlceAdi  = "Beylikova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 345,
                SehirID  = 26,
                IlceKodu = 1808,
                IlceAdi  = "İnönü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 346,
                SehirID  = 26,
                IlceKodu = 1934,
                IlceAdi  = "Günyüzü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 347,
                SehirID  = 26,
                IlceKodu = 1939,
                IlceAdi  = "Han",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 348,
                SehirID  = 26,
                IlceKodu = 1973,
                IlceAdi  = "Mihalgazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 349,
                SehirID  = 26,
                IlceKodu = 2046,
                IlceAdi  = "Odunpazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 350,
                SehirID  = 26,
                IlceKodu = 2047,
                IlceAdi  = "Tepebaşı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 351,
                SehirID  = 27,
                IlceKodu = 1139,
                IlceAdi  = "Araban",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 352,
                SehirID  = 27,
                IlceKodu = 1415,
                IlceAdi  = "İslahiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 353,
                SehirID  = 27,
                IlceKodu = 1546,
                IlceAdi  = "Nizip",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 354,
                SehirID  = 27,
                IlceKodu = 1549,
                IlceAdi  = "Oğuzeli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 355,
                SehirID  = 27,
                IlceKodu = 1720,
                IlceAdi  = "Yavuzeli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 356,
                SehirID  = 27,
                IlceKodu = 1841,
                IlceAdi  = "Şahinbey",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 357,
                SehirID  = 27,
                IlceKodu = 1844,
                IlceAdi  = "Şehitkamil",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 358,
                SehirID  = 27,
                IlceKodu = 1956,
                IlceAdi  = "Karkamış",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 359,
                SehirID  = 27,
                IlceKodu = 1974,
                IlceAdi  = "Nurdağı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 360,
                SehirID  = 28,
                IlceKodu = 1133,
                IlceAdi  = "Alucra",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 361,
                SehirID  = 28,
                IlceKodu = 1212,
                IlceAdi  = "Bulancak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 362,
                SehirID  = 28,
                IlceKodu = 1272,
                IlceAdi  = "Dereli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 363,
                SehirID  = 28,
                IlceKodu = 1320,
                IlceAdi  = "Espiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 364,
                SehirID  = 28,
                IlceKodu = 1324,
                IlceAdi  = "Eynesil",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 365,
                SehirID  = 28,
                IlceKodu = 1352,
                IlceAdi  = "Giresun Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 366,
                SehirID  = 28,
                IlceKodu = 1361,
                IlceAdi  = "Görele",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 367,
                SehirID  = 28,
                IlceKodu = 1465,
                IlceAdi  = "Keşap",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 368,
                SehirID  = 28,
                IlceKodu = 1654,
                IlceAdi  = "Şebinkarahisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 369,
                SehirID  = 28,
                IlceKodu = 1678,
                IlceAdi  = "Tirebolu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 370,
                SehirID  = 28,
                IlceKodu = 1837,
                IlceAdi  = "Piraziz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 371,
                SehirID  = 28,
                IlceKodu = 1854,
                IlceAdi  = "Yağlıdere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 372,
                SehirID  = 28,
                IlceKodu = 1893,
                IlceAdi  = "Çamoluk",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 373,
                SehirID  = 28,
                IlceKodu = 1894,
                IlceAdi  = "Çanakçı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 374,
                SehirID  = 28,
                IlceKodu = 1912,
                IlceAdi  = "Doğankent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 375,
                SehirID  = 28,
                IlceKodu = 1930,
                IlceAdi  = "Güce",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 376,
                SehirID  = 29,
                IlceKodu = 1369,
                IlceAdi  = "Gümüşhane Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 377,
                SehirID  = 29,
                IlceKodu = 1458,
                IlceAdi  = "Kelkit",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 378,
                SehirID  = 29,
                IlceKodu = 1660,
                IlceAdi  = "Şiran",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 379,
                SehirID  = 29,
                IlceKodu = 1684,
                IlceAdi  = "Torul",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 380,
                SehirID  = 29,
                IlceKodu = 1822,
                IlceAdi  = "Köse",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 381,
                SehirID  = 29,
                IlceKodu = 1971,
                IlceAdi  = "Kürtün",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 382,
                SehirID  = 30,
                IlceKodu = 1261,
                IlceAdi  = "Çukurca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 383,
                SehirID  = 30,
                IlceKodu = 1377,
                IlceAdi  = "Hakkari Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 384,
                SehirID  = 30,
                IlceKodu = 1656,
                IlceAdi  = "Şemdinli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 385,
                SehirID  = 30,
                IlceKodu = 1737,
                IlceAdi  = "Yüksekova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 386,
                SehirID  = 31,
                IlceKodu = 1131,
                IlceAdi  = "Altınözü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 387,
                SehirID  = 31,
                IlceKodu = 1289,
                IlceAdi  = "Dörtyol",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 388,
                SehirID  = 31,
                IlceKodu = 1382,
                IlceAdi  = "Hassa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 389,
                SehirID  = 31,
                IlceKodu = 1383,
                IlceAdi  = "Hatay Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 390,
                SehirID  = 31,
                IlceKodu = 1413,
                IlceAdi  = "İskenderun",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 391,
                SehirID  = 31,
                IlceKodu = 1468,
                IlceAdi  = "Kırıkhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 392,
                SehirID  = 31,
                IlceKodu = 1585,
                IlceAdi  = "Reyhanlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 393,
                SehirID  = 31,
                IlceKodu = 1591,
                IlceAdi  = "Samandağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 394,
                SehirID  = 31,
                IlceKodu = 1721,
                IlceAdi  = "Yayladağı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 395,
                SehirID  = 31,
                IlceKodu = 1792,
                IlceAdi  = "Erzin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 396,
                SehirID  = 31,
                IlceKodu = 1887,
                IlceAdi  = "Belen",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 397,
                SehirID  = 31,
                IlceKodu = 1970,
                IlceAdi  = "Kumlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 398,
                SehirID  = 31,
                IlceKodu = 2080,
                IlceAdi  = "Antakya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 399,
                SehirID  = 31,
                IlceKodu = 2081,
                IlceAdi  = "Arsuz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 400,
                SehirID  = 31,
                IlceKodu = 2082,
                IlceAdi  = "Defne",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 401,
                SehirID  = 31,
                IlceKodu = 2083,
                IlceAdi  = "Payas",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 402,
                SehirID  = 32,
                IlceKodu = 1154,
                IlceAdi  = "Atabey",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 403,
                SehirID  = 32,
                IlceKodu = 1297,
                IlceAdi  = "Eğirdir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 404,
                SehirID  = 32,
                IlceKodu = 1341,
                IlceAdi  = "Gelendost",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 405,
                SehirID  = 32,
                IlceKodu = 1401,
                IlceAdi  = "Isparta Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 406,
                SehirID  = 32,
                IlceKodu = 1456,
                IlceAdi  = "Keçiborlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 407,
                SehirID  = 32,
                IlceKodu = 1615,
                IlceAdi  = "Senirkent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 408,
                SehirID  = 32,
                IlceKodu = 1648,
                IlceAdi  = "Sütçüler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 409,
                SehirID  = 32,
                IlceKodu = 1651,
                IlceAdi  = "Şarkikaraağaç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 410,
                SehirID  = 32,
                IlceKodu = 1699,
                IlceAdi  = "Uluborlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 411,
                SehirID  = 32,
                IlceKodu = 1717,
                IlceAdi  = "Yalvaç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 412,
                SehirID  = 32,
                IlceKodu = 1755,
                IlceAdi  = "Aksu / Isparta",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 413,
                SehirID  = 32,
                IlceKodu = 1929,
                IlceAdi  = "Gönen / Isparta",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 414,
                SehirID  = 32,
                IlceKodu = 2001,
                IlceAdi  = "Yenişarbademli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 415,
                SehirID  = 33,
                IlceKodu = 1135,
                IlceAdi  = "Anamur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 416,
                SehirID  = 33,
                IlceKodu = 1311,
                IlceAdi  = "Erdemli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 417,
                SehirID  = 33,
                IlceKodu = 1366,
                IlceAdi  = "Gülnar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 418,
                SehirID  = 33,
                IlceKodu = 1402,
                IlceAdi  = "Mersin Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 419,
                SehirID  = 33,
                IlceKodu = 1536,
                IlceAdi  = "Mut",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 420,
                SehirID  = 33,
                IlceKodu = 1621,
                IlceAdi  = "Silifke",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 421,
                SehirID  = 33,
                IlceKodu = 1665,
                IlceAdi  = "Tarsus",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 422,
                SehirID  = 33,
                IlceKodu = 1766,
                IlceAdi  = "Aydıncık / Mersin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 423,
                SehirID  = 33,
                IlceKodu = 1779,
                IlceAdi  = "Bozyazı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 424,
                SehirID  = 33,
                IlceKodu = 1892,
                IlceAdi  = "Çamlıyayla",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 425,
                SehirID  = 33,
                IlceKodu = 2064,
                IlceAdi  = "Akdeniz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 426,
                SehirID  = 33,
                IlceKodu = 2065,
                IlceAdi  = "Mezitli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 427,
                SehirID  = 33,
                IlceKodu = 2066,
                IlceAdi  = "Toroslar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 428,
                SehirID  = 33,
                IlceKodu = 2067,
                IlceAdi  = "Yenişehir / Mersin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 429,
                SehirID  = 34,
                IlceKodu = 1103,
                IlceAdi  = "Adalar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 430,
                SehirID  = 34,
                IlceKodu = 1166,
                IlceAdi  = "Bakırköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 431,
                SehirID  = 34,
                IlceKodu = 1183,
                IlceAdi  = "Beşiktaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 432,
                SehirID  = 34,
                IlceKodu = 1185,
                IlceAdi  = "Beykoz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 433,
                SehirID  = 34,
                IlceKodu = 1186,
                IlceAdi  = "Beyoğlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 434,
                SehirID  = 34,
                IlceKodu = 1237,
                IlceAdi  = "Çatalca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 435,
                SehirID  = 34,
                IlceKodu = 1305,
                IlceAdi  = "Eminönü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 436,
                SehirID  = 34,
                IlceKodu = 1325,
                IlceAdi  = "Eyüp",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 437,
                SehirID  = 34,
                IlceKodu = 1327,
                IlceAdi  = "Fatih",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 438,
                SehirID  = 34,
                IlceKodu = 1336,
                IlceAdi  = "Gaziosmanpaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 439,
                SehirID  = 34,
                IlceKodu = 1421,
                IlceAdi  = "Kadıköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 440,
                SehirID  = 34,
                IlceKodu = 1449,
                IlceAdi  = "Kartal",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 441,
                SehirID  = 34,
                IlceKodu = 1604,
                IlceAdi  = "Sarıyer",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 442,
                SehirID  = 34,
                IlceKodu = 1622,
                IlceAdi  = "Silivri",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 443,
                SehirID  = 34,
                IlceKodu = 1659,
                IlceAdi  = "Şile",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 444,
                SehirID  = 34,
                IlceKodu = 1663,
                IlceAdi  = "Şişli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 445,
                SehirID  = 34,
                IlceKodu = 1708,
                IlceAdi  = "Üsküdar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 446,
                SehirID  = 34,
                IlceKodu = 1739,
                IlceAdi  = "Zeytinburnu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 447,
                SehirID  = 34,
                IlceKodu = 1782,
                IlceAdi  = "Büyükçekmece",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 448,
                SehirID  = 34,
                IlceKodu = 1810,
                IlceAdi  = "Kağıthane",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 449,
                SehirID  = 34,
                IlceKodu = 1823,
                IlceAdi  = "Küçükçekmece",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 450,
                SehirID  = 34,
                IlceKodu = 1835,
                IlceAdi  = "Pendik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 451,
                SehirID  = 34,
                IlceKodu = 1852,
                IlceAdi  = "Ümraniye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 452,
                SehirID  = 34,
                IlceKodu = 1886,
                IlceAdi  = "Bayrampaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 453,
                SehirID  = 34,
                IlceKodu = 2003,
                IlceAdi  = "Avcılar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 454,
                SehirID  = 34,
                IlceKodu = 2004,
                IlceAdi  = "Bağcılar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 455,
                SehirID  = 34,
                IlceKodu = 2005,
                IlceAdi  = "Bahçelievler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 456,
                SehirID  = 34,
                IlceKodu = 2010,
                IlceAdi  = "Güngören",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 457,
                SehirID  = 34,
                IlceKodu = 2012,
                IlceAdi  = "Maltepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 458,
                SehirID  = 34,
                IlceKodu = 2014,
                IlceAdi  = "Sultanbeyli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 459,
                SehirID  = 34,
                IlceKodu = 2015,
                IlceAdi  = "Tuzla",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 460,
                SehirID  = 34,
                IlceKodu = 2016,
                IlceAdi  = "Esenler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 461,
                SehirID  = 34,
                IlceKodu = 2048,
                IlceAdi  = "Arnavutköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 462,
                SehirID  = 34,
                IlceKodu = 2049,
                IlceAdi  = "Ataşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 463,
                SehirID  = 34,
                IlceKodu = 2050,
                IlceAdi  = "Başakşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 464,
                SehirID  = 34,
                IlceKodu = 2051,
                IlceAdi  = "Beylikdüzü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 465,
                SehirID  = 34,
                IlceKodu = 2052,
                IlceAdi  = "Çekmeköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 466,
                SehirID  = 34,
                IlceKodu = 2053,
                IlceAdi  = "Esenyurt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 467,
                SehirID  = 34,
                IlceKodu = 2054,
                IlceAdi  = "Sancaktepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 468,
                SehirID  = 34,
                IlceKodu = 2055,
                IlceAdi  = "Sultangazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 469,
                SehirID  = 35,
                IlceKodu = 1128,
                IlceAdi  = "Aliağa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 470,
                SehirID  = 35,
                IlceKodu = 1178,
                IlceAdi  = "Bayındır",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 471,
                SehirID  = 35,
                IlceKodu = 1181,
                IlceAdi  = "Bergama",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 472,
                SehirID  = 35,
                IlceKodu = 1203,
                IlceAdi  = "Bornova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 473,
                SehirID  = 35,
                IlceKodu = 1251,
                IlceAdi  = "Çeşme",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 474,
                SehirID  = 35,
                IlceKodu = 1280,
                IlceAdi  = "Dikili",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 475,
                SehirID  = 35,
                IlceKodu = 1334,
                IlceAdi  = "Foça",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 476,
                SehirID  = 35,
                IlceKodu = 1432,
                IlceAdi  = "Karaburun",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 477,
                SehirID  = 35,
                IlceKodu = 1448,
                IlceAdi  = "Karşıyaka",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 478,
                SehirID  = 35,
                IlceKodu = 1461,
                IlceAdi  = "Kemalpaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 479,
                SehirID  = 35,
                IlceKodu = 1467,
                IlceAdi  = "Kınık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 480,
                SehirID  = 35,
                IlceKodu = 1477,
                IlceAdi  = "Kiraz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 481,
                SehirID  = 35,
                IlceKodu = 1521,
                IlceAdi  = "Menemen",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 482,
                SehirID  = 35,
                IlceKodu = 1563,
                IlceAdi  = "Ödemiş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 483,
                SehirID  = 35,
                IlceKodu = 1611,
                IlceAdi  = "Seferihisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 484,
                SehirID  = 35,
                IlceKodu = 1612,
                IlceAdi  = "Selçuk",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 485,
                SehirID  = 35,
                IlceKodu = 1677,
                IlceAdi  = "Tire",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 486,
                SehirID  = 35,
                IlceKodu = 1682,
                IlceAdi  = "Torbalı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 487,
                SehirID  = 35,
                IlceKodu = 1703,
                IlceAdi  = "Urla",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 488,
                SehirID  = 35,
                IlceKodu = 1776,
                IlceAdi  = "Beydağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 489,
                SehirID  = 35,
                IlceKodu = 1780,
                IlceAdi  = "Buca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 490,
                SehirID  = 35,
                IlceKodu = 1819,
                IlceAdi  = "Konak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 491,
                SehirID  = 35,
                IlceKodu = 1826,
                IlceAdi  = "Menderes",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 492,
                SehirID  = 35,
                IlceKodu = 2006,
                IlceAdi  = "Balçova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 493,
                SehirID  = 35,
                IlceKodu = 2007,
                IlceAdi  = "Çiğli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 494,
                SehirID  = 35,
                IlceKodu = 2009,
                IlceAdi  = "Gaziemir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 495,
                SehirID  = 35,
                IlceKodu = 2013,
                IlceAdi  = "Narlıdere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 496,
                SehirID  = 35,
                IlceKodu = 2018,
                IlceAdi  = "Güzelbahçe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 497,
                SehirID  = 35,
                IlceKodu = 2056,
                IlceAdi  = "Bayraklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 498,
                SehirID  = 35,
                IlceKodu = 2057,
                IlceAdi  = "Karabağlar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 499,
                SehirID  = 36,
                IlceKodu = 1149,
                IlceAdi  = "Arpaçay",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 500,
                SehirID  = 36,
                IlceKodu = 1279,
                IlceAdi  = "Digor",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 501,
                SehirID  = 36,
                IlceKodu = 1424,
                IlceAdi  = "Kağızman",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 502,
                SehirID  = 36,
                IlceKodu = 1447,
                IlceAdi  = "Kars Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 503,
                SehirID  = 36,
                IlceKodu = 1601,
                IlceAdi  = "Sarıkamış",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 504,
                SehirID  = 36,
                IlceKodu = 1614,
                IlceAdi  = "Selim",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 505,
                SehirID  = 36,
                IlceKodu = 1645,
                IlceAdi  = "Susuz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 506,
                SehirID  = 36,
                IlceKodu = 1756,
                IlceAdi  = "Akyaka",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 507,
                SehirID  = 37,
                IlceKodu = 1101,
                IlceAdi  = "Abana",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 508,
                SehirID  = 37,
                IlceKodu = 1140,
                IlceAdi  = "Araç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 509,
                SehirID  = 37,
                IlceKodu = 1162,
                IlceAdi  = "Azdavay",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 510,
                SehirID  = 37,
                IlceKodu = 1208,
                IlceAdi  = "Bozkurt / Kastamonu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 511,
                SehirID  = 37,
                IlceKodu = 1221,
                IlceAdi  = "Cide",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 512,
                SehirID  = 37,
                IlceKodu = 1238,
                IlceAdi  = "Çatalzeytin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 513,
                SehirID  = 37,
                IlceKodu = 1264,
                IlceAdi  = "Daday",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 514,
                SehirID  = 37,
                IlceKodu = 1277,
                IlceAdi  = "Devrekani",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 515,
                SehirID  = 37,
                IlceKodu = 1410,
                IlceAdi  = "İnebolu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 516,
                SehirID  = 37,
                IlceKodu = 1450,
                IlceAdi  = "Kastamonu Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 517,
                SehirID  = 37,
                IlceKodu = 1499,
                IlceAdi  = "Küre",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 518,
                SehirID  = 37,
                IlceKodu = 1666,
                IlceAdi  = "Taşköprü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 519,
                SehirID  = 37,
                IlceKodu = 1685,
                IlceAdi  = "Tosya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 520,
                SehirID  = 37,
                IlceKodu = 1805,
                IlceAdi  = "İhsangazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 521,
                SehirID  = 37,
                IlceKodu = 1836,
                IlceAdi  = "Pınarbaşı / Kastamonu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 522,
                SehirID  = 37,
                IlceKodu = 1845,
                IlceAdi  = "Şenpazar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 523,
                SehirID  = 37,
                IlceKodu = 1867,
                IlceAdi  = "Ağlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 524,
                SehirID  = 37,
                IlceKodu = 1915,
                IlceAdi  = "Doğanyurt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 525,
                SehirID  = 37,
                IlceKodu = 1940,
                IlceAdi  = "Hanönü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 526,
                SehirID  = 37,
                IlceKodu = 1984,
                IlceAdi  = "Seydiler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 527,
                SehirID  = 38,
                IlceKodu = 1218,
                IlceAdi  = "Bünyan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 528,
                SehirID  = 38,
                IlceKodu = 1275,
                IlceAdi  = "Develi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 529,
                SehirID  = 38,
                IlceKodu = 1330,
                IlceAdi  = "Felahiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 530,
                SehirID  = 38,
                IlceKodu = 1409,
                IlceAdi  = "İncesu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 531,
                SehirID  = 38,
                IlceKodu = 1576,
                IlceAdi  = "Pınarbaşı / Kayseri",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 532,
                SehirID  = 38,
                IlceKodu = 1603,
                IlceAdi  = "Sarıoğlan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 533,
                SehirID  = 38,
                IlceKodu = 1605,
                IlceAdi  = "Sarız",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 534,
                SehirID  = 38,
                IlceKodu = 1680,
                IlceAdi  = "Tomarza",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 535,
                SehirID  = 38,
                IlceKodu = 1715,
                IlceAdi  = "Yahyalı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 536,
                SehirID  = 38,
                IlceKodu = 1727,
                IlceAdi  = "Yeşilhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 537,
                SehirID  = 38,
                IlceKodu = 1752,
                IlceAdi  = "Akkışla",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 538,
                SehirID  = 38,
                IlceKodu = 1846,
                IlceAdi  = "Talas",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 539,
                SehirID  = 38,
                IlceKodu = 1863,
                IlceAdi  = "Kocasinan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 540,
                SehirID  = 38,
                IlceKodu = 1864,
                IlceAdi  = "Melikgazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 541,
                SehirID  = 38,
                IlceKodu = 1936,
                IlceAdi  = "Hacılar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 542,
                SehirID  = 38,
                IlceKodu = 1978,
                IlceAdi  = "Özvatan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 543,
                SehirID  = 39,
                IlceKodu = 1163,
                IlceAdi  = "Babaeski",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 544,
                SehirID  = 39,
                IlceKodu = 1270,
                IlceAdi  = "Demirköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 545,
                SehirID  = 39,
                IlceKodu = 1471,
                IlceAdi  = "Kırklareli Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 546,
                SehirID  = 39,
                IlceKodu = 1480,
                IlceAdi  = "Kofçaz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 547,
                SehirID  = 39,
                IlceKodu = 1505,
                IlceAdi  = "Lüleburgaz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 548,
                SehirID  = 39,
                IlceKodu = 1572,
                IlceAdi  = "Pehlivanköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 549,
                SehirID  = 39,
                IlceKodu = 1577,
                IlceAdi  = "Pınarhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 550,
                SehirID  = 39,
                IlceKodu = 1714,
                IlceAdi  = "Vize",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 551,
                SehirID  = 40,
                IlceKodu = 1254,
                IlceAdi  = "Çiçekdağı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 552,
                SehirID  = 40,
                IlceKodu = 1429,
                IlceAdi  = "Kaman",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 553,
                SehirID  = 40,
                IlceKodu = 1472,
                IlceAdi  = "Kırşehir Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 554,
                SehirID  = 40,
                IlceKodu = 1529,
                IlceAdi  = "Mucur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 555,
                SehirID  = 40,
                IlceKodu = 1754,
                IlceAdi  = "Akpınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 556,
                SehirID  = 40,
                IlceKodu = 1869,
                IlceAdi  = "Akçakent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 557,
                SehirID  = 40,
                IlceKodu = 1890,
                IlceAdi  = "Boztepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 558,
                SehirID  = 41,
                IlceKodu = 1338,
                IlceAdi  = "Gebze",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 559,
                SehirID  = 41,
                IlceKodu = 1355,
                IlceAdi  = "Gölcük",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 560,
                SehirID  = 41,
                IlceKodu = 1430,
                IlceAdi  = "Kandıra",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 561,
                SehirID  = 41,
                IlceKodu = 1440,
                IlceAdi  = "Karamürsel",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 562,
                SehirID  = 41,
                IlceKodu = 1478,
                IlceAdi  = "Kocaeli Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 563,
                SehirID  = 41,
                IlceKodu = 1821,
                IlceAdi  = "Körfez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 564,
                SehirID  = 41,
                IlceKodu = 2030,
                IlceAdi  = "Derince",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 565,
                SehirID  = 41,
                IlceKodu = 2058,
                IlceAdi  = "Başiskele",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 566,
                SehirID  = 41,
                IlceKodu = 2059,
                IlceAdi  = "Çayırova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 567,
                SehirID  = 41,
                IlceKodu = 2060,
                IlceAdi  = "Darıca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 568,
                SehirID  = 41,
                IlceKodu = 2061,
                IlceAdi  = "Dilovası",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 569,
                SehirID  = 41,
                IlceKodu = 2062,
                IlceAdi  = "İzmit",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 570,
                SehirID  = 41,
                IlceKodu = 2063,
                IlceAdi  = "Kartepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 571,
                SehirID  = 42,
                IlceKodu = 1122,
                IlceAdi  = "Akşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 572,
                SehirID  = 42,
                IlceKodu = 1188,
                IlceAdi  = "Beyşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 573,
                SehirID  = 42,
                IlceKodu = 1207,
                IlceAdi  = "Bozkır",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 574,
                SehirID  = 42,
                IlceKodu = 1222,
                IlceAdi  = "Cihanbeyli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 575,
                SehirID  = 42,
                IlceKodu = 1262,
                IlceAdi  = "Çumra",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 576,
                SehirID  = 42,
                IlceKodu = 1285,
                IlceAdi  = "Doğanhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 577,
                SehirID  = 42,
                IlceKodu = 1312,
                IlceAdi  = "Ereğli / Konya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 578,
                SehirID  = 42,
                IlceKodu = 1375,
                IlceAdi  = "Hadim",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 579,
                SehirID  = 42,
                IlceKodu = 1400,
                IlceAdi  = "Ilgın",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 580,
                SehirID  = 42,
                IlceKodu = 1422,
                IlceAdi  = "Kadınhanı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 581,
                SehirID  = 42,
                IlceKodu = 1441,
                IlceAdi  = "Karapınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 582,
                SehirID  = 42,
                IlceKodu = 1491,
                IlceAdi  = "Kulu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 583,
                SehirID  = 42,
                IlceKodu = 1598,
                IlceAdi  = "Sarayönü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 584,
                SehirID  = 42,
                IlceKodu = 1617,
                IlceAdi  = "Seydişehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 585,
                SehirID  = 42,
                IlceKodu = 1735,
                IlceAdi  = "Yunak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 586,
                SehirID  = 42,
                IlceKodu = 1753,
                IlceAdi  = "Akören",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 587,
                SehirID  = 42,
                IlceKodu = 1760,
                IlceAdi  = "Altınekin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 588,
                SehirID  = 42,
                IlceKodu = 1789,
                IlceAdi  = "Derebucak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 589,
                SehirID  = 42,
                IlceKodu = 1804,
                IlceAdi  = "Hüyük",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 590,
                SehirID  = 42,
                IlceKodu = 1814,
                IlceAdi  = "Karatay",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 591,
                SehirID  = 42,
                IlceKodu = 1827,
                IlceAdi  = "Meram",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 592,
                SehirID  = 42,
                IlceKodu = 1839,
                IlceAdi  = "Selçuklu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 593,
                SehirID  = 42,
                IlceKodu = 1848,
                IlceAdi  = "Taşkent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 594,
                SehirID  = 42,
                IlceKodu = 1868,
                IlceAdi  = "Ahırlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 595,
                SehirID  = 42,
                IlceKodu = 1902,
                IlceAdi  = "Çeltik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 596,
                SehirID  = 42,
                IlceKodu = 1907,
                IlceAdi  = "Derbent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 597,
                SehirID  = 42,
                IlceKodu = 1920,
                IlceAdi  = "Emirgazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 598,
                SehirID  = 42,
                IlceKodu = 1933,
                IlceAdi  = "Güneysınır",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 599,
                SehirID  = 42,
                IlceKodu = 1937,
                IlceAdi  = "Halkapınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 600,
                SehirID  = 42,
                IlceKodu = 1990,
                IlceAdi  = "Tuzlukçu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 601,
                SehirID  = 42,
                IlceKodu = 1994,
                IlceAdi  = "Yalıhüyük",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 602,
                SehirID  = 43,
                IlceKodu = 1132,
                IlceAdi  = "Altıntaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 603,
                SehirID  = 43,
                IlceKodu = 1288,
                IlceAdi  = "Domaniç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 604,
                SehirID  = 43,
                IlceKodu = 1304,
                IlceAdi  = "Emet",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 605,
                SehirID  = 43,
                IlceKodu = 1339,
                IlceAdi  = "Gediz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 606,
                SehirID  = 43,
                IlceKodu = 1500,
                IlceAdi  = "Kütahya Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 607,
                SehirID  = 43,
                IlceKodu = 1625,
                IlceAdi  = "Simav",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 608,
                SehirID  = 43,
                IlceKodu = 1671,
                IlceAdi  = "Tavşanlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 609,
                SehirID  = 43,
                IlceKodu = 1764,
                IlceAdi  = "Aslanapa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 610,
                SehirID  = 43,
                IlceKodu = 1790,
                IlceAdi  = "Dumlupınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 611,
                SehirID  = 43,
                IlceKodu = 1802,
                IlceAdi  = "Hisarcık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 612,
                SehirID  = 43,
                IlceKodu = 1843,
                IlceAdi  = "Şaphane",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 613,
                SehirID  = 43,
                IlceKodu = 1898,
                IlceAdi  = "Çavdarhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 614,
                SehirID  = 43,
                IlceKodu = 1979,
                IlceAdi  = "Pazarlar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 615,
                SehirID  = 44,
                IlceKodu = 1114,
                IlceAdi  = "Akçadağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 616,
                SehirID  = 44,
                IlceKodu = 1143,
                IlceAdi  = "Arapgir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 617,
                SehirID  = 44,
                IlceKodu = 1148,
                IlceAdi  = "Arguvan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 618,
                SehirID  = 44,
                IlceKodu = 1265,
                IlceAdi  = "Darende",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 619,
                SehirID  = 44,
                IlceKodu = 1286,
                IlceAdi  = "Doğanşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 620,
                SehirID  = 44,
                IlceKodu = 1390,
                IlceAdi  = "Hekimhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 621,
                SehirID  = 44,
                IlceKodu = 1509,
                IlceAdi  = "Malatya Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 622,
                SehirID  = 44,
                IlceKodu = 1582,
                IlceAdi  = "Pütürge",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 623,
                SehirID  = 44,
                IlceKodu = 1729,
                IlceAdi  = "Yeşilyurt / Malatya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 624,
                SehirID  = 44,
                IlceKodu = 1772,
                IlceAdi  = "Battalgazi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 625,
                SehirID  = 44,
                IlceKodu = 1914,
                IlceAdi  = "Doğanyol",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 626,
                SehirID  = 44,
                IlceKodu = 1953,
                IlceAdi  = "Kale / Malatya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 627,
                SehirID  = 44,
                IlceKodu = 1969,
                IlceAdi  = "Kuluncak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 628,
                SehirID  = 44,
                IlceKodu = 1995,
                IlceAdi  = "Yazıhan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 629,
                SehirID  = 45,
                IlceKodu = 1118,
                IlceAdi  = "Akhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 630,
                SehirID  = 45,
                IlceKodu = 1127,
                IlceAdi  = "Alaşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 631,
                SehirID  = 45,
                IlceKodu = 1269,
                IlceAdi  = "Demirci",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 632,
                SehirID  = 45,
                IlceKodu = 1362,
                IlceAdi  = "Gördes",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 633,
                SehirID  = 45,
                IlceKodu = 1470,
                IlceAdi  = "Kırkağaç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 634,
                SehirID  = 45,
                IlceKodu = 1489,
                IlceAdi  = "Kula",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 635,
                SehirID  = 45,
                IlceKodu = 1513,
                IlceAdi  = "Manisa Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 636,
                SehirID  = 45,
                IlceKodu = 1590,
                IlceAdi  = "Salihli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 637,
                SehirID  = 45,
                IlceKodu = 1600,
                IlceAdi  = "Sarıgöl",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 638,
                SehirID  = 45,
                IlceKodu = 1606,
                IlceAdi  = "Saruhanlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 639,
                SehirID  = 45,
                IlceKodu = 1613,
                IlceAdi  = "Selendi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 640,
                SehirID  = 45,
                IlceKodu = 1634,
                IlceAdi  = "Soma",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 641,
                SehirID  = 45,
                IlceKodu = 1689,
                IlceAdi  = "Turgutlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 642,
                SehirID  = 45,
                IlceKodu = 1751,
                IlceAdi  = "Ahmetli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 643,
                SehirID  = 45,
                IlceKodu = 1793,
                IlceAdi  = "Gölmarmara",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 644,
                SehirID  = 45,
                IlceKodu = 1965,
                IlceAdi  = "Köprübaşı / Manisa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 645,
                SehirID  = 45,
                IlceKodu = 2086,
                IlceAdi  = "Şehzadeler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 646,
                SehirID  = 45,
                IlceKodu = 2087,
                IlceAdi  = "Yunusemre",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 647,
                SehirID  = 46,
                IlceKodu = 1107,
                IlceAdi  = "Afşin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 648,
                SehirID  = 46,
                IlceKodu = 1136,
                IlceAdi  = "Andırın",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 649,
                SehirID  = 46,
                IlceKodu = 1299,
                IlceAdi  = "Elbistan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 650,
                SehirID  = 46,
                IlceKodu = 1353,
                IlceAdi  = "Göksun",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 651,
                SehirID  = 46,
                IlceKodu = 1515,
                IlceAdi  = "Kahramanmaraş Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 652,
                SehirID  = 46,
                IlceKodu = 1570,
                IlceAdi  = "Pazarcık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 653,
                SehirID  = 46,
                IlceKodu = 1694,
                IlceAdi  = "Türkoğlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 654,
                SehirID  = 46,
                IlceKodu = 1785,
                IlceAdi  = "Çağlayancerit",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 655,
                SehirID  = 46,
                IlceKodu = 1919,
                IlceAdi  = "Ekinözü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 656,
                SehirID  = 46,
                IlceKodu = 1975,
                IlceAdi  = "Nurhak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 657,
                SehirID  = 46,
                IlceKodu = 2084,
                IlceAdi  = "Dulkadiroğlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 658,
                SehirID  = 46,
                IlceKodu = 2085,
                IlceAdi  = "Onikişubat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 659,
                SehirID  = 47,
                IlceKodu = 1273,
                IlceAdi  = "Derik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 660,
                SehirID  = 47,
                IlceKodu = 1474,
                IlceAdi  = "Kızıltepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 661,
                SehirID  = 47,
                IlceKodu = 1516,
                IlceAdi  = "Mardin Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 662,
                SehirID  = 47,
                IlceKodu = 1519,
                IlceAdi  = "Mazıdağı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 663,
                SehirID  = 47,
                IlceKodu = 1526,
                IlceAdi  = "Midyat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 664,
                SehirID  = 47,
                IlceKodu = 1547,
                IlceAdi  = "Nusaybin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 665,
                SehirID  = 47,
                IlceKodu = 1564,
                IlceAdi  = "Ömerli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 666,
                SehirID  = 47,
                IlceKodu = 1609,
                IlceAdi  = "Savur",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 667,
                SehirID  = 47,
                IlceKodu = 1787,
                IlceAdi  = "Dargeçit",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 668,
                SehirID  = 47,
                IlceKodu = 2002,
                IlceAdi  = "Yeşilli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 669,
                SehirID  = 47,
                IlceKodu = 2088,
                IlceAdi  = "Artuklu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 670,
                SehirID  = 48,
                IlceKodu = 1197,
                IlceAdi  = "Bodrum",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 671,
                SehirID  = 48,
                IlceKodu = 1266,
                IlceAdi  = "Datça",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 672,
                SehirID  = 48,
                IlceKodu = 1331,
                IlceAdi  = "Fethiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 673,
                SehirID  = 48,
                IlceKodu = 1488,
                IlceAdi  = "Köyceğiz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 674,
                SehirID  = 48,
                IlceKodu = 1517,
                IlceAdi  = "Marmaris",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 675,
                SehirID  = 48,
                IlceKodu = 1528,
                IlceAdi  = "Milas",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 676,
                SehirID  = 48,
                IlceKodu = 1532,
                IlceAdi  = "Muğla Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 677,
                SehirID  = 48,
                IlceKodu = 1695,
                IlceAdi  = "Ula",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 678,
                SehirID  = 48,
                IlceKodu = 1719,
                IlceAdi  = "Yatağan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 679,
                SehirID  = 48,
                IlceKodu = 1742,
                IlceAdi  = "Dalaman",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 680,
                SehirID  = 48,
                IlceKodu = 1831,
                IlceAdi  = "Ortaca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 681,
                SehirID  = 48,
                IlceKodu = 1958,
                IlceAdi  = "Kavaklıdere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 682,
                SehirID  = 48,
                IlceKodu = 2089,
                IlceAdi  = "Menteşe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 683,
                SehirID  = 48,
                IlceKodu = 2090,
                IlceAdi  = "Seydikemer",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 684,
                SehirID  = 49,
                IlceKodu = 1213,
                IlceAdi  = "Bulanık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 685,
                SehirID  = 49,
                IlceKodu = 1510,
                IlceAdi  = "Malazgirt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 686,
                SehirID  = 49,
                IlceKodu = 1534,
                IlceAdi  = "Muş Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 687,
                SehirID  = 49,
                IlceKodu = 1711,
                IlceAdi  = "Varto",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 688,
                SehirID  = 49,
                IlceKodu = 1801,
                IlceAdi  = "Hasköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 689,
                SehirID  = 49,
                IlceKodu = 1964,
                IlceAdi  = "Korkut",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 690,
                SehirID  = 50,
                IlceKodu = 1155,
                IlceAdi  = "Avanos",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 691,
                SehirID  = 50,
                IlceKodu = 1274,
                IlceAdi  = "Derinkuyu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 692,
                SehirID  = 50,
                IlceKodu = 1367,
                IlceAdi  = "Gülşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 693,
                SehirID  = 50,
                IlceKodu = 1374,
                IlceAdi  = "Hacıbektaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 694,
                SehirID  = 50,
                IlceKodu = 1485,
                IlceAdi  = "Kozaklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 695,
                SehirID  = 50,
                IlceKodu = 1543,
                IlceAdi  = "Nevşehir Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 696,
                SehirID  = 50,
                IlceKodu = 1707,
                IlceAdi  = "Ürgüp",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 697,
                SehirID  = 50,
                IlceKodu = 1749,
                IlceAdi  = "Acıgöl",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 698,
                SehirID  = 51,
                IlceKodu = 1201,
                IlceAdi  = "Bor",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 699,
                SehirID  = 51,
                IlceKodu = 1225,
                IlceAdi  = "Çamardı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 700,
                SehirID  = 51,
                IlceKodu = 1544,
                IlceAdi  = "Niğde Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 701,
                SehirID  = 51,
                IlceKodu = 1700,
                IlceAdi  = "Ulukışla",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 702,
                SehirID  = 51,
                IlceKodu = 1876,
                IlceAdi  = "Altunhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 703,
                SehirID  = 51,
                IlceKodu = 1904,
                IlceAdi  = "Çiftlik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 704,
                SehirID  = 52,
                IlceKodu = 1119,
                IlceAdi  = "Akkuş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 705,
                SehirID  = 52,
                IlceKodu = 1158,
                IlceAdi  = "Aybastı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 706,
                SehirID  = 52,
                IlceKodu = 1328,
                IlceAdi  = "Fatsa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 707,
                SehirID  = 52,
                IlceKodu = 1358,
                IlceAdi  = "Gölköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 708,
                SehirID  = 52,
                IlceKodu = 1482,
                IlceAdi  = "Korgan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 709,
                SehirID  = 52,
                IlceKodu = 1493,
                IlceAdi  = "Kumru",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 710,
                SehirID  = 52,
                IlceKodu = 1525,
                IlceAdi  = "Mesudiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 711,
                SehirID  = 52,
                IlceKodu = 1552,
                IlceAdi  = "Ordu Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 712,
                SehirID  = 52,
                IlceKodu = 1573,
                IlceAdi  = "Perşembe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 713,
                SehirID  = 52,
                IlceKodu = 1696,
                IlceAdi  = "Ulubey / Ordu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 714,
                SehirID  = 52,
                IlceKodu = 1706,
                IlceAdi  = "Ünye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 715,
                SehirID  = 52,
                IlceKodu = 1795,
                IlceAdi  = "Gülyalı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 716,
                SehirID  = 52,
                IlceKodu = 1797,
                IlceAdi  = "Gürgentepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 717,
                SehirID  = 52,
                IlceKodu = 1891,
                IlceAdi  = "Çamaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 718,
                SehirID  = 52,
                IlceKodu = 1897,
                IlceAdi  = "Çatalpınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 719,
                SehirID  = 52,
                IlceKodu = 1900,
                IlceAdi  = "Çaybaşı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 720,
                SehirID  = 52,
                IlceKodu = 1947,
                IlceAdi  = "İkizce",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 721,
                SehirID  = 52,
                IlceKodu = 1950,
                IlceAdi  = "Kabadüz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 722,
                SehirID  = 52,
                IlceKodu = 1951,
                IlceAdi  = "Kabataş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 723,
                SehirID  = 52,
                IlceKodu = 2103,
                IlceAdi  = "Altınordu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 724,
                SehirID  = 53,
                IlceKodu = 1146,
                IlceAdi  = "Ardeşen",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 725,
                SehirID  = 53,
                IlceKodu = 1228,
                IlceAdi  = "Çamlıhemşin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 726,
                SehirID  = 53,
                IlceKodu = 1241,
                IlceAdi  = "Çayeli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 727,
                SehirID  = 53,
                IlceKodu = 1332,
                IlceAdi  = "Fındıklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 728,
                SehirID  = 53,
                IlceKodu = 1405,
                IlceAdi  = "İkizdere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 729,
                SehirID  = 53,
                IlceKodu = 1428,
                IlceAdi  = "Kalkandere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 730,
                SehirID  = 53,
                IlceKodu = 1569,
                IlceAdi  = "Pazar / Rize",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 731,
                SehirID  = 53,
                IlceKodu = 1586,
                IlceAdi  = "Rize Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 732,
                SehirID  = 53,
                IlceKodu = 1796,
                IlceAdi  = "Güneysu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 733,
                SehirID  = 53,
                IlceKodu = 1908,
                IlceAdi  = "Derepazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 734,
                SehirID  = 53,
                IlceKodu = 1943,
                IlceAdi  = "Hemşin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 735,
                SehirID  = 53,
                IlceKodu = 1949,
                IlceAdi  = "İyidere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 736,
                SehirID  = 54,
                IlceKodu = 1123,
                IlceAdi  = "Akyazı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 737,
                SehirID  = 54,
                IlceKodu = 1351,
                IlceAdi  = "Geyve",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 738,
                SehirID  = 54,
                IlceKodu = 1391,
                IlceAdi  = "Hendek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 739,
                SehirID  = 54,
                IlceKodu = 1442,
                IlceAdi  = "Karasu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 740,
                SehirID  = 54,
                IlceKodu = 1453,
                IlceAdi  = "Kaynarca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 741,
                SehirID  = 54,
                IlceKodu = 1589,
                IlceAdi  = "Sakarya Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 742,
                SehirID  = 54,
                IlceKodu = 1595,
                IlceAdi  = "Sapanca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 743,
                SehirID  = 54,
                IlceKodu = 1818,
                IlceAdi  = "Kocaali",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 744,
                SehirID  = 54,
                IlceKodu = 1833,
                IlceAdi  = "Pamukova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 745,
                SehirID  = 54,
                IlceKodu = 1847,
                IlceAdi  = "Taraklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 746,
                SehirID  = 54,
                IlceKodu = 1925,
                IlceAdi  = "Ferizli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 747,
                SehirID  = 54,
                IlceKodu = 1955,
                IlceAdi  = "Karapürçek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 748,
                SehirID  = 54,
                IlceKodu = 1986,
                IlceAdi  = "Söğütlü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 749,
                SehirID  = 54,
                IlceKodu = 2068,
                IlceAdi  = "Adapazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 750,
                SehirID  = 54,
                IlceKodu = 2069,
                IlceAdi  = "Arifiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 751,
                SehirID  = 54,
                IlceKodu = 2070,
                IlceAdi  = "Erenler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 752,
                SehirID  = 54,
                IlceKodu = 2071,
                IlceAdi  = "Serdivan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 753,
                SehirID  = 55,
                IlceKodu = 1125,
                IlceAdi  = "Alaçam",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 754,
                SehirID  = 55,
                IlceKodu = 1164,
                IlceAdi  = "Bafra",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 755,
                SehirID  = 55,
                IlceKodu = 1234,
                IlceAdi  = "Çarşamba",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 756,
                SehirID  = 55,
                IlceKodu = 1386,
                IlceAdi  = "Havza",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 757,
                SehirID  = 55,
                IlceKodu = 1452,
                IlceAdi  = "Kavak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 758,
                SehirID  = 55,
                IlceKodu = 1501,
                IlceAdi  = "Ladik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 759,
                SehirID  = 55,
                IlceKodu = 1593,
                IlceAdi  = "Samsun Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 760,
                SehirID  = 55,
                IlceKodu = 1676,
                IlceAdi  = "Terme",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 761,
                SehirID  = 55,
                IlceKodu = 1712,
                IlceAdi  = "Vezirköprü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 762,
                SehirID  = 55,
                IlceKodu = 1763,
                IlceAdi  = "Asarcık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 763,
                SehirID  = 55,
                IlceKodu = 1830,
                IlceAdi  = "19 Mayıs",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 764,
                SehirID  = 55,
                IlceKodu = 1838,
                IlceAdi  = "Salıpazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 765,
                SehirID  = 55,
                IlceKodu = 1849,
                IlceAdi  = "Tekkeköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 766,
                SehirID  = 55,
                IlceKodu = 1879,
                IlceAdi  = "Ayvacık / Samsun",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 767,
                SehirID  = 55,
                IlceKodu = 1993,
                IlceAdi  = "Yakakent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 768,
                SehirID  = 55,
                IlceKodu = 2072,
                IlceAdi  = "Atakum",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 769,
                SehirID  = 55,
                IlceKodu = 2073,
                IlceAdi  = "Canik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 770,
                SehirID  = 55,
                IlceKodu = 2074,
                IlceAdi  = "İlkadım",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 771,
                SehirID  = 56,
                IlceKodu = 1179,
                IlceAdi  = "Baykan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 772,
                SehirID  = 56,
                IlceKodu = 1317,
                IlceAdi  = "Eruh",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 773,
                SehirID  = 56,
                IlceKodu = 1495,
                IlceAdi  = "Kurtalan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 774,
                SehirID  = 56,
                IlceKodu = 1575,
                IlceAdi  = "Pervari",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 775,
                SehirID  = 56,
                IlceKodu = 1620,
                IlceAdi  = "Siirt Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 776,
                SehirID  = 56,
                IlceKodu = 1662,
                IlceAdi  = "Şirvan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 777,
                SehirID  = 56,
                IlceKodu = 1878,
                IlceAdi  = "Tillo",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 778,
                SehirID  = 57,
                IlceKodu = 1156,
                IlceAdi  = "Ayancık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 779,
                SehirID  = 57,
                IlceKodu = 1204,
                IlceAdi  = "Boyabat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 780,
                SehirID  = 57,
                IlceKodu = 1290,
                IlceAdi  = "Durağan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 781,
                SehirID  = 57,
                IlceKodu = 1314,
                IlceAdi  = "Erfelek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 782,
                SehirID  = 57,
                IlceKodu = 1349,
                IlceAdi  = "Gerze",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 783,
                SehirID  = 57,
                IlceKodu = 1627,
                IlceAdi  = "Sinop Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 784,
                SehirID  = 57,
                IlceKodu = 1693,
                IlceAdi  = "Türkeli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 785,
                SehirID  = 57,
                IlceKodu = 1910,
                IlceAdi  = "Dikmen",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 786,
                SehirID  = 57,
                IlceKodu = 1981,
                IlceAdi  = "Saraydüzü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 787,
                SehirID  = 58,
                IlceKodu = 1282,
                IlceAdi  = "Divriği",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 788,
                SehirID  = 58,
                IlceKodu = 1342,
                IlceAdi  = "Gemerek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 789,
                SehirID  = 58,
                IlceKodu = 1373,
                IlceAdi  = "Gürün",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 790,
                SehirID  = 58,
                IlceKodu = 1376,
                IlceAdi  = "Hafik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 791,
                SehirID  = 58,
                IlceKodu = 1407,
                IlceAdi  = "İmranlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 792,
                SehirID  = 58,
                IlceKodu = 1431,
                IlceAdi  = "Kangal",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 793,
                SehirID  = 58,
                IlceKodu = 1484,
                IlceAdi  = "Koyulhisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 794,
                SehirID  = 58,
                IlceKodu = 1628,
                IlceAdi  = "Sivas Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 795,
                SehirID  = 58,
                IlceKodu = 1646,
                IlceAdi  = "Suşehri",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 796,
                SehirID  = 58,
                IlceKodu = 1650,
                IlceAdi  = "Şarkışla",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 797,
                SehirID  = 58,
                IlceKodu = 1731,
                IlceAdi  = "Yıldızeli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 798,
                SehirID  = 58,
                IlceKodu = 1738,
                IlceAdi  = "Zara",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 799,
                SehirID  = 58,
                IlceKodu = 1870,
                IlceAdi  = "Akıncılar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 800,
                SehirID  = 58,
                IlceKodu = 1875,
                IlceAdi  = "Altınyayla / Sivas",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 801,
                SehirID  = 58,
                IlceKodu = 1913,
                IlceAdi  = "Doğanşar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 802,
                SehirID  = 58,
                IlceKodu = 1927,
                IlceAdi  = "Gölova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 803,
                SehirID  = 58,
                IlceKodu = 1991,
                IlceAdi  = "Ulaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 804,
                SehirID  = 59,
                IlceKodu = 1250,
                IlceAdi  = "Çerkezköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 805,
                SehirID  = 59,
                IlceKodu = 1258,
                IlceAdi  = "Çorlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 806,
                SehirID  = 59,
                IlceKodu = 1388,
                IlceAdi  = "Hayrabolu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 807,
                SehirID  = 59,
                IlceKodu = 1511,
                IlceAdi  = "Malkara",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 808,
                SehirID  = 59,
                IlceKodu = 1538,
                IlceAdi  = "Muratlı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 809,
                SehirID  = 59,
                IlceKodu = 1596,
                IlceAdi  = "Saray / Tekirdağ",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 810,
                SehirID  = 59,
                IlceKodu = 1652,
                IlceAdi  = "Şarköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 811,
                SehirID  = 59,
                IlceKodu = 1673,
                IlceAdi  = "Tekirdağ Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 812,
                SehirID  = 59,
                IlceKodu = 1825,
                IlceAdi  = "Marmaraereğlisi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 813,
                SehirID  = 59,
                IlceKodu = 2094,
                IlceAdi  = "Ergene",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 814,
                SehirID  = 59,
                IlceKodu = 2095,
                IlceAdi  = "Kapaklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 815,
                SehirID  = 59,
                IlceKodu = 2096,
                IlceAdi  = "Süleymanpaşa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 816,
                SehirID  = 60,
                IlceKodu = 1129,
                IlceAdi  = "Almus",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 817,
                SehirID  = 60,
                IlceKodu = 1151,
                IlceAdi  = "Artova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 818,
                SehirID  = 60,
                IlceKodu = 1308,
                IlceAdi  = "Erbaa",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 819,
                SehirID  = 60,
                IlceKodu = 1545,
                IlceAdi  = "Niksar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 820,
                SehirID  = 60,
                IlceKodu = 1584,
                IlceAdi  = "Reşadiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 821,
                SehirID  = 60,
                IlceKodu = 1679,
                IlceAdi  = "Tokat Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 822,
                SehirID  = 60,
                IlceKodu = 1690,
                IlceAdi  = "Turhal",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 823,
                SehirID  = 60,
                IlceKodu = 1740,
                IlceAdi  = "Zile",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 824,
                SehirID  = 60,
                IlceKodu = 1834,
                IlceAdi  = "Pazar / Tokat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 825,
                SehirID  = 60,
                IlceKodu = 1858,
                IlceAdi  = "Yeşilyurt / Tokat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 826,
                SehirID  = 60,
                IlceKodu = 1883,
                IlceAdi  = "Başçiftlik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 827,
                SehirID  = 60,
                IlceKodu = 1987,
                IlceAdi  = "Sulusaray",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 828,
                SehirID  = 61,
                IlceKodu = 1113,
                IlceAdi  = "Akçaabat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 829,
                SehirID  = 61,
                IlceKodu = 1141,
                IlceAdi  = "Araklı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 830,
                SehirID  = 61,
                IlceKodu = 1150,
                IlceAdi  = "Arsin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 831,
                SehirID  = 61,
                IlceKodu = 1244,
                IlceAdi  = "Çaykara",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 832,
                SehirID  = 61,
                IlceKodu = 1507,
                IlceAdi  = "Maçka",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 833,
                SehirID  = 61,
                IlceKodu = 1548,
                IlceAdi  = "Of",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 834,
                SehirID  = 61,
                IlceKodu = 1647,
                IlceAdi  = "Sürmene",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 835,
                SehirID  = 61,
                IlceKodu = 1681,
                IlceAdi  = "Tonya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 836,
                SehirID  = 61,
                IlceKodu = 1686,
                IlceAdi  = "Trabzon Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 837,
                SehirID  = 61,
                IlceKodu = 1709,
                IlceAdi  = "Vakfıkebir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 838,
                SehirID  = 61,
                IlceKodu = 1732,
                IlceAdi  = "Yomra",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 839,
                SehirID  = 61,
                IlceKodu = 1775,
                IlceAdi  = "Beşikdüzü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 840,
                SehirID  = 61,
                IlceKodu = 1842,
                IlceAdi  = "Şalpazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 841,
                SehirID  = 61,
                IlceKodu = 1896,
                IlceAdi  = "Çarşıbaşı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 842,
                SehirID  = 61,
                IlceKodu = 1909,
                IlceAdi  = "Dernekpazarı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 843,
                SehirID  = 61,
                IlceKodu = 1917,
                IlceAdi  = "Düzköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 844,
                SehirID  = 61,
                IlceKodu = 1942,
                IlceAdi  = "Hayrat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 845,
                SehirID  = 61,
                IlceKodu = 1966,
                IlceAdi  = "Köprübaşı / Trabzon",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 846,
                SehirID  = 61,
                IlceKodu = 2097,
                IlceAdi  = "Ortahisar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 847,
                SehirID  = 62,
                IlceKodu = 1247,
                IlceAdi  = "Çemişgezek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 848,
                SehirID  = 62,
                IlceKodu = 1397,
                IlceAdi  = "Hozat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 849,
                SehirID  = 62,
                IlceKodu = 1518,
                IlceAdi  = "Mazgirt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 850,
                SehirID  = 62,
                IlceKodu = 1541,
                IlceAdi  = "Nazımiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 851,
                SehirID  = 62,
                IlceKodu = 1562,
                IlceAdi  = "Ovacık / Tunceli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 852,
                SehirID  = 62,
                IlceKodu = 1574,
                IlceAdi  = "Pertek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 853,
                SehirID  = 62,
                IlceKodu = 1581,
                IlceAdi  = "Pülümür",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 854,
                SehirID  = 62,
                IlceKodu = 1688,
                IlceAdi  = "Tunceli Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 855,
                SehirID  = 63,
                IlceKodu = 1115,
                IlceAdi  = "Akçakale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 856,
                SehirID  = 63,
                IlceKodu = 1194,
                IlceAdi  = "Birecik",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 857,
                SehirID  = 63,
                IlceKodu = 1209,
                IlceAdi  = "Bozova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 858,
                SehirID  = 63,
                IlceKodu = 1220,
                IlceAdi  = "Ceylanpınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 859,
                SehirID  = 63,
                IlceKodu = 1378,
                IlceAdi  = "Halfeti",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 860,
                SehirID  = 63,
                IlceKodu = 1393,
                IlceAdi  = "Hilvan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 861,
                SehirID  = 63,
                IlceKodu = 1630,
                IlceAdi  = "Siverek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 862,
                SehirID  = 63,
                IlceKodu = 1643,
                IlceAdi  = "Suruç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 863,
                SehirID  = 63,
                IlceKodu = 1702,
                IlceAdi  = "Şanlıurfa Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 864,
                SehirID  = 63,
                IlceKodu = 1713,
                IlceAdi  = "Viranşehir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 865,
                SehirID  = 63,
                IlceKodu = 1800,
                IlceAdi  = "Harran",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 866,
                SehirID  = 63,
                IlceKodu = 2091,
                IlceAdi  = "Eyyübiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 867,
                SehirID  = 63,
                IlceKodu = 2092,
                IlceAdi  = "Haliliye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 868,
                SehirID  = 63,
                IlceKodu = 2093,
                IlceAdi  = "Karaköprü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 869,
                SehirID  = 64,
                IlceKodu = 1170,
                IlceAdi  = "Banaz",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 870,
                SehirID  = 64,
                IlceKodu = 1323,
                IlceAdi  = "Eşme",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 871,
                SehirID  = 64,
                IlceKodu = 1436,
                IlceAdi  = "Karahallı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 872,
                SehirID  = 64,
                IlceKodu = 1629,
                IlceAdi  = "Sivaslı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 873,
                SehirID  = 64,
                IlceKodu = 1697,
                IlceAdi  = "Ulubey / Uşak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 874,
                SehirID  = 64,
                IlceKodu = 1704,
                IlceAdi  = "Uşak Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 875,
                SehirID  = 65,
                IlceKodu = 1175,
                IlceAdi  = "Başkale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 876,
                SehirID  = 65,
                IlceKodu = 1236,
                IlceAdi  = "Çatak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 877,
                SehirID  = 65,
                IlceKodu = 1309,
                IlceAdi  = "Erciş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 878,
                SehirID  = 65,
                IlceKodu = 1350,
                IlceAdi  = "Gevaş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 879,
                SehirID  = 65,
                IlceKodu = 1372,
                IlceAdi  = "Gürpınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 880,
                SehirID  = 65,
                IlceKodu = 1533,
                IlceAdi  = "Muradiye",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 881,
                SehirID  = 65,
                IlceKodu = 1565,
                IlceAdi  = "Ceylanpınar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 882,
                SehirID  = 65,
                IlceKodu = 1710,
                IlceAdi  = "Van Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 883,
                SehirID  = 65,
                IlceKodu = 1770,
                IlceAdi  = "Bahçesaray",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 884,
                SehirID  = 65,
                IlceKodu = 1786,
                IlceAdi  = "Çaldıran",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 885,
                SehirID  = 65,
                IlceKodu = 1918,
                IlceAdi  = "Edremit / Van",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 886,
                SehirID  = 65,
                IlceKodu = 1980,
                IlceAdi  = "Saray / Van",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 887,
                SehirID  = 65,
                IlceKodu = 2098,
                IlceAdi  = "İpekyolu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 888,
                SehirID  = 65,
                IlceKodu = 2099,
                IlceAdi  = "Tuşba",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 889,
                SehirID  = 66,
                IlceKodu = 1117,
                IlceAdi  = "Akdağmadeni",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 890,
                SehirID  = 66,
                IlceKodu = 1198,
                IlceAdi  = "Boğazlıyan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 891,
                SehirID  = 66,
                IlceKodu = 1242,
                IlceAdi  = "Çayıralan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 892,
                SehirID  = 66,
                IlceKodu = 1245,
                IlceAdi  = "Çekerek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 893,
                SehirID  = 66,
                IlceKodu = 1602,
                IlceAdi  = "Sarıkaya",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 894,
                SehirID  = 66,
                IlceKodu = 1635,
                IlceAdi  = "Sorgun",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 895,
                SehirID  = 66,
                IlceKodu = 1655,
                IlceAdi  = "Şefaatli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 896,
                SehirID  = 66,
                IlceKodu = 1726,
                IlceAdi  = "Yerköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 897,
                SehirID  = 66,
                IlceKodu = 1733,
                IlceAdi  = "Yozgat Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 898,
                SehirID  = 66,
                IlceKodu = 1877,
                IlceAdi  = "Aydıncık / Yozgat",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 899,
                SehirID  = 66,
                IlceKodu = 1895,
                IlceAdi  = "Çandır",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 900,
                SehirID  = 66,
                IlceKodu = 1952,
                IlceAdi  = "Kadışehri",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 901,
                SehirID  = 66,
                IlceKodu = 1982,
                IlceAdi  = "Saraykent",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 902,
                SehirID  = 66,
                IlceKodu = 1998,
                IlceAdi  = "Yenifakılı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 903,
                SehirID  = 67,
                IlceKodu = 1240,
                IlceAdi  = "Çaycuma",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 904,
                SehirID  = 67,
                IlceKodu = 1276,
                IlceAdi  = "Devrek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 905,
                SehirID  = 67,
                IlceKodu = 1313,
                IlceAdi  = "Ereğli / Zonguldak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 906,
                SehirID  = 67,
                IlceKodu = 1741,
                IlceAdi  = "Zonguldak Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 907,
                SehirID  = 67,
                IlceKodu = 1758,
                IlceAdi  = "Alaplı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 908,
                SehirID  = 67,
                IlceKodu = 1926,
                IlceAdi  = "Gökçebey",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 909,
                SehirID  = 67,
                IlceKodu = 2100,
                IlceAdi  = "Kilimli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 910,
                SehirID  = 67,
                IlceKodu = 2101,
                IlceAdi  = "Kozlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 911,
                SehirID  = 68,
                IlceKodu = 1120,
                IlceAdi  = "Aksaray Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 912,
                SehirID  = 68,
                IlceKodu = 1557,
                IlceAdi  = "Ortaköy / Aksaray",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 913,
                SehirID  = 68,
                IlceKodu = 1860,
                IlceAdi  = "Ağaçören",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 914,
                SehirID  = 68,
                IlceKodu = 1861,
                IlceAdi  = "Güzelyurt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 915,
                SehirID  = 68,
                IlceKodu = 1866,
                IlceAdi  = "Sarıyahşi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 916,
                SehirID  = 68,
                IlceKodu = 1921,
                IlceAdi  = "Eskil",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 917,
                SehirID  = 68,
                IlceKodu = 1932,
                IlceAdi  = "Gülağaç",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 918,
                SehirID  = 69,
                IlceKodu = 1176,
                IlceAdi  = "Bayburt Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 919,
                SehirID  = 69,
                IlceKodu = 1767,
                IlceAdi  = "Aydıntepe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 920,
                SehirID  = 69,
                IlceKodu = 1788,
                IlceAdi  = "Demirözü",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 921,
                SehirID  = 70,
                IlceKodu = 1316,
                IlceAdi  = "Ermenek",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 922,
                SehirID  = 70,
                IlceKodu = 1439,
                IlceAdi  = "Karaman Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 923,
                SehirID  = 70,
                IlceKodu = 1768,
                IlceAdi  = "Ayrancı",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 924,
                SehirID  = 70,
                IlceKodu = 1862,
                IlceAdi  = "Kazımkarabekir",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 925,
                SehirID  = 70,
                IlceKodu = 1884,
                IlceAdi  = "Başyayla",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 926,
                SehirID  = 70,
                IlceKodu = 1983,
                IlceAdi  = "Sarıveliler",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 927,
                SehirID  = 71,
                IlceKodu = 1268,
                IlceAdi  = "Delice",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 928,
                SehirID  = 71,
                IlceKodu = 1463,
                IlceAdi  = "Keskin",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 929,
                SehirID  = 71,
                IlceKodu = 1469,
                IlceAdi  = "Kırıkkale Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 930,
                SehirID  = 71,
                IlceKodu = 1638,
                IlceAdi  = "Sulakyurt",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 931,
                SehirID  = 71,
                IlceKodu = 1880,
                IlceAdi  = "Bahşili",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 932,
                SehirID  = 71,
                IlceKodu = 1882,
                IlceAdi  = "Balışeyh",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 933,
                SehirID  = 71,
                IlceKodu = 1901,
                IlceAdi  = "Çelebi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 934,
                SehirID  = 71,
                IlceKodu = 1954,
                IlceAdi  = "Karakeçili",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 935,
                SehirID  = 71,
                IlceKodu = 1992,
                IlceAdi  = "Yahşihan",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 936,
                SehirID  = 72,
                IlceKodu = 1174,
                IlceAdi  = "Batman Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 937,
                SehirID  = 72,
                IlceKodu = 1184,
                IlceAdi  = "Beşiri",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 938,
                SehirID  = 72,
                IlceKodu = 1345,
                IlceAdi  = "Gercüş",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 939,
                SehirID  = 72,
                IlceKodu = 1487,
                IlceAdi  = "Kozluk",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 940,
                SehirID  = 72,
                IlceKodu = 1607,
                IlceAdi  = "Sason",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 941,
                SehirID  = 72,
                IlceKodu = 1941,
                IlceAdi  = "Hasankeyf",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 942,
                SehirID  = 73,
                IlceKodu = 1189,
                IlceAdi  = "Beytüşşebap",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 943,
                SehirID  = 73,
                IlceKodu = 1223,
                IlceAdi  = "Cizre",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 944,
                SehirID  = 73,
                IlceKodu = 1403,
                IlceAdi  = "İdil",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 945,
                SehirID  = 73,
                IlceKodu = 1623,
                IlceAdi  = "Silopi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 946,
                SehirID  = 73,
                IlceKodu = 1661,
                IlceAdi  = "Şırnak Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 947,
                SehirID  = 73,
                IlceKodu = 1698,
                IlceAdi  = "Uludere",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 948,
                SehirID  = 73,
                IlceKodu = 1931,
                IlceAdi  = "Güçlükonak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 949,
                SehirID  = 74,
                IlceKodu = 1172,
                IlceAdi  = "Bartın Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 950,
                SehirID  = 74,
                IlceKodu = 1496,
                IlceAdi  = "Kurucaşile",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 951,
                SehirID  = 74,
                IlceKodu = 1701,
                IlceAdi  = "Ulus",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 952,
                SehirID  = 74,
                IlceKodu = 1761,
                IlceAdi  = "Amasra",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 953,
                SehirID  = 75,
                IlceKodu = 1144,
                IlceAdi  = "Ardahan Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 954,
                SehirID  = 75,
                IlceKodu = 1252,
                IlceAdi  = "Çıldır",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 955,
                SehirID  = 75,
                IlceKodu = 1356,
                IlceAdi  = "Göle",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 956,
                SehirID  = 75,
                IlceKodu = 1380,
                IlceAdi  = "Hanak",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 957,
                SehirID  = 75,
                IlceKodu = 1579,
                IlceAdi  = "Posof",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 958,
                SehirID  = 75,
                IlceKodu = 2008,
                IlceAdi  = "Damal",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 959,
                SehirID  = 76,
                IlceKodu = 1142,
                IlceAdi  = "Aralık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 960,
                SehirID  = 76,
                IlceKodu = 1398,
                IlceAdi  = "Iğdır Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 961,
                SehirID  = 76,
                IlceKodu = 1692,
                IlceAdi  = "Tuzluca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 962,
                SehirID  = 76,
                IlceKodu = 2011,
                IlceAdi  = "Karakoyunlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 963,
                SehirID  = 77,
                IlceKodu = 1716,
                IlceAdi  = "Yalova Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 964,
                SehirID  = 77,
                IlceKodu = 2019,
                IlceAdi  = "Altınova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 965,
                SehirID  = 77,
                IlceKodu = 2020,
                IlceAdi  = "Armutlu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 966,
                SehirID  = 77,
                IlceKodu = 2021,
                IlceAdi  = "Çınarcık",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 967,
                SehirID  = 77,
                IlceKodu = 2022,
                IlceAdi  = "Çiftlikköy",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 968,
                SehirID  = 77,
                IlceKodu = 2026,
                IlceAdi  = "Termal",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 969,
                SehirID  = 78,
                IlceKodu = 1296,
                IlceAdi  = "Eflani",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 970,
                SehirID  = 78,
                IlceKodu = 1321,
                IlceAdi  = "Eskipazar",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 971,
                SehirID  = 78,
                IlceKodu = 1433,
                IlceAdi  = "Karabük Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 972,
                SehirID  = 78,
                IlceKodu = 1561,
                IlceAdi  = "Ovacık / Karabük",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 973,
                SehirID  = 78,
                IlceKodu = 1587,
                IlceAdi  = "Safranbolu",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 974,
                SehirID  = 78,
                IlceKodu = 1856,
                IlceAdi  = "Yenice / Karabük",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 975,
                SehirID  = 79,
                IlceKodu = 1476,
                IlceAdi  = "Kilis Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 976,
                SehirID  = 79,
                IlceKodu = 2023,
                IlceAdi  = "Elbeyli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 977,
                SehirID  = 79,
                IlceKodu = 2024,
                IlceAdi  = "Musabeyli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 978,
                SehirID  = 79,
                IlceKodu = 2025,
                IlceAdi  = "Polateli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 979,
                SehirID  = 80,
                IlceKodu = 1165,
                IlceAdi  = "Bahçe",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 980,
                SehirID  = 80,
                IlceKodu = 1423,
                IlceAdi  = "Kadirli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 981,
                SehirID  = 80,
                IlceKodu = 1560,
                IlceAdi  = "Osmaniye Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 982,
                SehirID  = 80,
                IlceKodu = 1743,
                IlceAdi  = "Düziçi",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 983,
                SehirID  = 80,
                IlceKodu = 2027,
                IlceAdi  = "Hasanbeyli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 984,
                SehirID  = 80,
                IlceKodu = 2028,
                IlceAdi  = "Sumbas",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 985,
                SehirID  = 80,
                IlceKodu = 2029,
                IlceAdi  = "Toprakkale",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 986,
                SehirID  = 81,
                IlceKodu = 1116,
                IlceAdi  = "Akçakoca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 987,
                SehirID  = 81,
                IlceKodu = 1292,
                IlceAdi  = "Düzce Merkez",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 988,
                SehirID  = 81,
                IlceKodu = 1730,
                IlceAdi  = "Yığılca",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 989,
                SehirID  = 81,
                IlceKodu = 1784,
                IlceAdi  = "Cumayeri",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 990,
                SehirID  = 81,
                IlceKodu = 1794,
                IlceAdi  = "Gölyaka",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 991,
                SehirID  = 81,
                IlceKodu = 1905,
                IlceAdi  = "Çilimli",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 992,
                SehirID  = 81,
                IlceKodu = 2017,
                IlceAdi  = "Gümüşova",
                DurumID  = 1
                },
                new Ilce
                {
                IlceID   = 993,
                SehirID  = 81,
                IlceKodu = 2031,
                IlceAdi  = "Kaynaşlı",
                DurumID  = 1
                }
            });
            #endregion

            #region //ParaBirimi
            context.ParaBirimleri.AddRange(new List<ParaBirimi>
            {
                new ParaBirimi
                {
                    ParaBirimiID = 1,
                    Kodu = "TL",
                    Cinsi = "Türk Lirası",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 2,
                    Kodu = "USD",
                    Cinsi = "ABD Doları",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 3,
                    Kodu = "AUD",
                    Cinsi = "Avusturalya Doları",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 4,
                    Kodu = "DKK",
                    Cinsi = "Danimarka Kronu",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 5,
                    Kodu = "EUR",
                    Cinsi = "EURO",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 6,
                    Kodu = "GBP",
                    Cinsi = "İngiliz Sterlini",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 7,
                    Kodu = "CHF",
                    Cinsi = "İsviçre Frangı",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 8,
                    Kodu = "SEK",
                    Cinsi = "İsveç Kronu",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 9,
                    Kodu = "CAD",
                    Cinsi = "Kanada Doları",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 10,
                    Kodu = "KWD",
                    Cinsi = "Kuvet Dinarı",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 11,
                    Kodu = "NOK",
                    Cinsi = "Norveç Kronu",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 12,
                    Kodu = "SAR",
                    Cinsi = "Suudi Arabistan riyali",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 13,
                    Kodu = "JPY",
                    Cinsi = "Japon Yeni",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 14,
                    Kodu = "BGN",
                    Cinsi = "Bulgar Levası",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 15,
                    Kodu = "RON",
                    Cinsi = "Rumen Leyi",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 16,
                    Kodu = "RUB",
                    Cinsi = "Rus Rublesi",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 17,
                    Kodu = "IRR",
                    Cinsi = "İran Riyali",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 18,
                    Kodu = "CYN",
                    Cinsi = "Çin Yuanı",
                    DurumID = 1
                },
                new ParaBirimi
                {
                    ParaBirimiID = 19,
                    Kodu = "PKR",
                    Cinsi = "Pakistan Rupisi",
                    DurumID = 1
                }
            });
            #endregion

            #region //Kategori
            context.Kategoriler.AddRange(new List<Kategori>
            {
                new Kategori
                {
                    KategoriID =1,
                    Adi ="Doküman Tipleri",
                    Icon ="fa fa-file-text-o",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =2,
                    Adi ="Hazırlık Grupları",
                    Icon ="fa fa-clipboard",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =3,
                    Adi ="Yürürlük Durumları",
                    Icon ="fa fa-gavel",
                    DurumID = 1
                },
                new Kategori
                {
                    KategoriID =4,
                    Adi ="Standart Türleri",
                    Icon ="fa fa-file-text-o",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =5,
                    Adi ="Telefon Tipleri",
                    Icon ="fa fa-phone-square",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =6,
                    Adi ="Adres Tipleri",
                    Icon ="fa fa-home",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =7,
                    Adi ="Standart İçerik Tipleri",
                    Icon ="fa fa-file-o",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =8,
                    Adi ="Atıf Yapılan Standart Tipleri",
                    Icon ="fa fa-quote-right",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =9,
                    Adi ="Atıf Yapılan Döküman Tipleri",
                    Icon ="fa fa-quote-left",
                    DurumID =1
                },                
                new Kategori
                {
                    KategoriID =10,
                    Adi ="Denetim Tipleri",
                    Icon ="fa fa-bar-chart",
                    DurumID =1
                }
            });
            #endregion

            #region //Deger
            context.Degerler.AddRange(new List<Deger>
            {
                new Deger
                {
                    DegerID = 1,
                    KategoriID = 1,
                    DegerAdiTr = "Tanımsız",
                    DegerAdiEn = "Undefined",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 2,
                    KategoriID = 1,
                    DegerAdiTr = "Adapte Teklifi",
                    DegerAdiEn = "Adapte Offer",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 3,
                    KategoriID = 1,
                    DegerAdiTr = "Dc",
                    DegerAdiEn = "Dc",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 4,
                    KategoriID = 1,
                    DegerAdiTr = "Kitap",
                    DegerAdiEn = "Book",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 5,
                    KategoriID = 1,
                    DegerAdiTr = "Konu Teklifi",
                    DegerAdiEn = "Subject Offer",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 6,
                    KategoriID = 1,
                    DegerAdiTr = "Kriter",
                    DegerAdiEn = "Criterion",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 7,
                    KategoriID = 1,
                    DegerAdiTr = "Kriter İş Programında",
                    DegerAdiEn = "Criterion Work Program",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 8,
                    KategoriID = 1,
                    DegerAdiTr = "Kriter Tasarısı",
                    DegerAdiEn = "Criteria Design",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 9,
                    KategoriID = 1,
                    DegerAdiTr = "Kriter Teklifi",
                    DegerAdiEn = "Criteria Bid",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 10,
                    KategoriID = 1,
                    DegerAdiTr = "ST",
                    DegerAdiEn = "ST",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 11,
                    KategoriID = 1,
                    DegerAdiTr = "TD*GD",
                    DegerAdiEn = "TD*GD",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 12,
                    KategoriID = 1,
                    DegerAdiTr = "TR*TS",
                    DegerAdiEn = "TR*TS",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 13,
                    KategoriID = 1,
                    DegerAdiTr = "UTO Rehber Doküman",
                    DegerAdiEn = "UTO Directory Document",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 14,
                    KategoriID = 1,
                    DegerAdiTr = "WI (İş Programında)",
                    DegerAdiEn = "WI (Work Program)",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 15,
                    KategoriID = 2,
                    DegerAdiTr = "Tanımsız",
                    DegerAdiEn = "Undefined",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 16,
                    KategoriID = 2,
                    DegerAdiTr = "Akreditasyon ve Belgelendirme Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Accreditation and Documentation",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 17,
                    KategoriID = 2,
                    DegerAdiTr = "Alıcı Ortam Özel Daimi Komitesi",
                    DegerAdiEn = "Buyer Environment Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 18,
                    KategoriID = 2,
                    DegerAdiTr = "Ambalaj Özel Daimi Komitesi ÖDK",
                    DegerAdiEn = "Special Standing Committee for Packaging ÖK",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 19,
                    KategoriID = 2,
                    DegerAdiTr = "Ambalaj ve Kırtasiye Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Packaging and Stationery",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 20,
                    KategoriID = 2,
                    DegerAdiTr = "Atıklar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Waste",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 21,
                    KategoriID = 2,
                    DegerAdiTr = "Aydınlatma ve İç Tesisat Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Lighting and Interior Installation",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 22,
                    KategoriID = 2,
                    DegerAdiTr = "Aydınlatma ve Kablo Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Lighting and Cable",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 23,
                    KategoriID = 2,
                    DegerAdiTr = "Basınçlı Kaplar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Pressure Vessels",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 24,
                    KategoriID = 2,
                    DegerAdiTr = "Bilgi Teknolojileri ve İletişim İhtisas Grubu",
                    DegerAdiEn = "Information Technologies and Communication Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 25,
                    KategoriID = 2,
                    DegerAdiTr = "Bilişim Teknolojileri Test Belgelendirme Sektörü",
                    DegerAdiEn = "Information Technologies Test Certification Sector",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 26,
                    KategoriID = 2,
                    DegerAdiTr = "Cam Seramik ve Refrakter Malzeme Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Glass Ceramics and Refractory Materials",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 27,
                    KategoriID = 2,
                    DegerAdiTr = "Çevre İhtisas Grubu",
                    DegerAdiEn = "Environmental Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 28,
                    KategoriID = 2,
                    DegerAdiTr = "Çevre Sağlığı Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Environmental Health",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 29,
                    KategoriID = 2,
                    DegerAdiTr = "Çevre Sağlığı ve Atıklar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Environmental Health and Waste",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 30,
                    KategoriID = 2,
                    DegerAdiTr = "Demiryolu Özel Daimi Komitesi",
                    DegerAdiEn = "Railway Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 31,
                    KategoriID = 2,
                    DegerAdiTr = "Deprem Özel Daimi Komitesi",
                    DegerAdiEn = "Earthquake Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 32,
                    KategoriID = 2,
                    DegerAdiTr = "Doğal Gaz Özel Daimi Komitesi",
                    DegerAdiEn = "Natural Gas Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 33,
                    KategoriID = 2,
                    DegerAdiTr = "Doküman Tercüme Komitesi",
                    DegerAdiEn = "Document Translation Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 34,
                    KategoriID = 2,
                    DegerAdiTr = "Ekoloji Tarım Ürünleri Özel Daimi Komitesi",
                    DegerAdiEn = "Document Translation Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 35,
                    KategoriID = 2,
                    DegerAdiTr = "Elektrik İhtisas Grubu",
                    DegerAdiEn = "Electricity Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 36,
                    KategoriID = 2,
                    DegerAdiTr = "Elektronik İhtisas Grubu",
                    DegerAdiEn = "Electronic Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 37,
                    KategoriID = 2,
                    DegerAdiTr = "Elektroteknik Güvenlik Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Electrotechnical Safety",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 38,
                    KategoriID = 2,
                    DegerAdiTr = "Elektroteknik Güvenlik ve Aydınlatma  Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Electrotechnical Safety and Lighting",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 39,
                    KategoriID = 2,
                    DegerAdiTr = "Elektroteknik Sektörü Müdürlüğü",
                    DegerAdiEn = "Electrotechnical Sector Directorate",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 40,
                    KategoriID = 2,
                    DegerAdiTr = "EMU ve Radyo-TV Özel Daimi Komitesi",
                    DegerAdiEn = "EMU and Radio-TV Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 41,
                    KategoriID = 2,
                    DegerAdiTr = "Endüstriyel Yağlar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Industrial Oils",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 42,
                    KategoriID = 2,
                    DegerAdiTr = "Gıda Sektörü Müdürlüğü",
                    DegerAdiEn = "Food Sector Directorate",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 43,
                    KategoriID = 2,
                    DegerAdiTr = "Helal Gıda Sektör Müdürlüğü",
                    DegerAdiEn = "Halal Food Sector Directorate",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 44,
                    KategoriID = 2,
                    DegerAdiTr = "Hizmet Standardları İhtisas Grubu",
                    DegerAdiEn = "Service Standards Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 45,
                    KategoriID = 2,
                    DegerAdiTr = "Hizmet Yeri Belgelendirme Sektör Müdürlüğü",
                    DegerAdiEn = "Service Placement Sector Directorate",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 46,
                    KategoriID = 2,
                    DegerAdiTr = "Isı Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Heat",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 47,
                    KategoriID = 2,
                    DegerAdiTr = "İnşaat İhtisas Grubu",
                    DegerAdiEn = "Construction Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 48,
                    KategoriID = 2,
                    DegerAdiTr = "İnşaat Makinaları Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Construction Machinery",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 49,
                    KategoriID = 2,
                    DegerAdiTr = "Kablo Özel Daimi Komitesi",
                    DegerAdiEn = "Cable Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 50,
                    KategoriID = 2,
                    DegerAdiTr = "Kapatılan Hazırlık Grupları",
                    DegerAdiEn = "Closed Preparatory Groups",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 51,
                    KategoriID = 2,
                    DegerAdiTr = "Kapatılan ve Birleştirilen Özel Daimi Komiteler",
                    DegerAdiEn = "Closed and Consolidated Special Permanent Committees",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 52,
                    KategoriID = 2,
                    DegerAdiTr = "Kırtasiye Malzemeleri ve Formlar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Stationery Materials and Forms",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 53,
                    KategoriID = 2,
                    DegerAdiTr = "Kimya İhtisas Grubu",
                    DegerAdiEn = "Chemistry Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 54,
                    KategoriID = 2,
                    DegerAdiTr = "Kimya Sektör Müdürlüğü",
                    DegerAdiEn = "Chemical Sector Directorate",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 55,
                    KategoriID = 2,
                    DegerAdiTr = "Laboratuvarlar Hazırlık Grubu",
                    DegerAdiEn = "Laboratories Preparation Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 56,
                    KategoriID = 2,
                    DegerAdiTr = "Maden İhtisas Grubu",
                    DegerAdiEn = "Mining Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 57,
                    KategoriID = 2,
                    DegerAdiTr = "Makina İhtisas Grubu",
                    DegerAdiEn = "Machine Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 58,
                    KategoriID = 2,
                    DegerAdiTr = "Makine Sektörü Müdürlüğü",
                    DegerAdiEn = "Machinery Sector Directorate",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 59,
                    KategoriID = 2,
                    DegerAdiTr = "Mamul Gıdalar İhtisas Grubu",
                    DegerAdiEn = "Specialty Food Products Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 60,
                    KategoriID = 2,
                    DegerAdiTr = "Meslek Standardları İhtisas Grubu",
                    DegerAdiEn = "Occupational Standards Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 61,
                    KategoriID = 2,
                    DegerAdiTr = "Metalurji İhtisas Grubu",
                    DegerAdiEn = "Metallurgy Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 62,
                    KategoriID = 2,
                    DegerAdiTr = "Milletlerarası Standardlar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on International Standards",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 63,
                    KategoriID = 2,
                    DegerAdiTr = "Milli Savunma Sanayii İhtisas Grubu",
                    DegerAdiEn = "National Defense Industry Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 64,
                    KategoriID = 2,
                    DegerAdiTr = "Mühendislik Hizmetleri İhtisas Grubu",
                    DegerAdiEn = "Engineering Services Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 65,
                    KategoriID = 2,
                    DegerAdiTr = "NBC ve KİS Özel Daimi Komitesi",
                    DegerAdiEn = "NBC and KIS Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 66,
                    KategoriID = 2,
                    DegerAdiTr = "Nükleer Özel Daimi Komitesi",
                    DegerAdiEn = "Nuclear Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 67,
                    KategoriID = 2,
                    DegerAdiTr = "Optik ve Optometri Özel Daimi Komitesi",
                    DegerAdiEn = "Optics and Optometry Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 68,
                    KategoriID = 2,
                    DegerAdiTr = "Orman ve Orman Ürünleri İhtisas Grubu",
                    DegerAdiEn = "Forest and Forest Products Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 69,
                    KategoriID = 2,
                    DegerAdiTr = "Otomotiv Özel Daimi Komitesi",
                    DegerAdiEn = "Automotive Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 70,
                    KategoriID = 2,
                    DegerAdiTr = "Otomotiv Sektör Müdürlüğü",
                    DegerAdiEn = "Automotive Sector Directorate",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 71,
                    KategoriID = 2,
                    DegerAdiTr = "Otomotiv ve İnşaat Makinaları Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Automotive and Construction Machinery",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 72,
                    KategoriID = 2,
                    DegerAdiTr = "Özel Standardlar Hazırlık Grubu",
                    DegerAdiEn = "Special Standards Preparation Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 73,
                    KategoriID = 2,
                    DegerAdiTr = "Petrokimya İhtisas Grubu",
                    DegerAdiEn = "Petrochemicals Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 74,
                    KategoriID = 2,
                    DegerAdiTr = "Petrol İhtisas Grubu",
                    DegerAdiEn = "Petroleum Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 75,
                    KategoriID = 2,
                    DegerAdiTr = "Plâstik Borular Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Plastic Pipes",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 76,
                    KategoriID = 2,
                    DegerAdiTr = "Radyo-TV Özel Daimi Komitesi",
                    DegerAdiEn = "Radio-TV Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 77,
                    KategoriID = 2,
                    DegerAdiTr = "Rezerv konular grubu",
                    DegerAdiEn = "Reserve subject group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 78,
                    KategoriID = 2,
                    DegerAdiTr = "Sağlık İhtisas Grubu",
                    DegerAdiEn = "Health Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 79,
                    KategoriID = 2,
                    DegerAdiTr = "Standard Özel Daimi Komitesi",
                    DegerAdiEn = "Standard Standing Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 80,
                    KategoriID = 2,
                    DegerAdiTr = "Şehiriçi Yollar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Urban Roads",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 81,
                    KategoriID = 2,
                    DegerAdiTr = "Tahribatsız Muayene Özel Daimi Komitesi",
                    DegerAdiEn = "Non-Destructive Testing Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 82,
                    KategoriID = 2,
                    DegerAdiTr = "Tarım Alet ve Makinaları Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Agricultural Equipment and Machinery",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 83,
                    KategoriID = 2,
                    DegerAdiTr = "Teknik Kurul",
                    DegerAdiEn = "Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 84,
                    KategoriID = 2,
                    DegerAdiTr = "Tekstil İhtisas Grubu",
                    DegerAdiEn = "Textile Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 85,
                    KategoriID = 2,
                    DegerAdiTr = "Telekomünikasyon Özel Daimi Komitesi",
                    DegerAdiEn = "Telecommunication Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 86,
                    KategoriID = 2,
                    DegerAdiTr = "Tesisat ve Basınçlı Kaplar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Installation and Pressure Vessels",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 87,
                    KategoriID = 2,
                    DegerAdiTr = "Tıbbi Cihazlar Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Medical Devices",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 88,
                    KategoriID = 2,
                    DegerAdiTr = "TK1: Bilişim Teknolojileri Teknik Komitesi",
                    DegerAdiEn = "TK1: Technical Committee on Information Technologies",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 89,
                    KategoriID = 2,
                    DegerAdiTr = "TK10: Yapı Malzemeleri Teknik Komitesi",
                    DegerAdiEn = "TK10: Technical Committee for Building Materials",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 90,
                    KategoriID = 2,
                    DegerAdiTr = "TK11:İzolasyon, Kaplama ve Yardımcı Yapı Malzemeleri Teknik Komitesi",
                    DegerAdiEn = "TK11: Technical Committee for Insulation, Coating and Auxiliary Materials",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 91,
                    KategoriID = 2,
                    DegerAdiTr = "TK12: Yapı Güvenliği ve Akustik Teknik Komitesi",
                    DegerAdiEn = "TK12: Building Safety and Acoustic Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 92,
                    KategoriID = 2,
                    DegerAdiTr = "TK13: Yapı Güvenliği Teknik Komitesi",
                    DegerAdiEn = "TK13: Construction Safety Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 93,
                    KategoriID = 2,
                    DegerAdiTr = "TK14: Kimya Teknik Komitesi",
                    DegerAdiEn = "TK14: Chemical Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 94,
                    KategoriID = 2,
                    DegerAdiTr = "TK15: Petrokimya Teknik Komitesi",
                    DegerAdiEn = "TK15: Petrochemical Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 95,
                    KategoriID = 2,
                    DegerAdiTr = "TK16: Petrol ve Petrol Ürünleri Teknik Komitesi",
                    DegerAdiEn = "TK15: Petrochemical Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 96,
                    KategoriID = 2,
                    DegerAdiTr = "TK17: Maden Teknik Komitesi",
                    DegerAdiEn = "TK17: Mining Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 97,
                    KategoriID = 2,
                    DegerAdiTr = "TK18: İmalat Makineleri ve Takımları Teknik Komitesi",
                    DegerAdiEn = "TK18: Technical Committee on Manufacturing Machinery and Teams",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 98,
                    KategoriID = 2,
                    DegerAdiTr = "TK19: Otomotiv Teknik Komitesi",
                    DegerAdiEn = "TK19: Automotive Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 99,
                    KategoriID = 2,
                    DegerAdiTr = "TK2: Çevre Teknik Komitesi",
                    DegerAdiEn = "TK2: Environmental Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 100,
                    KategoriID = 2,
                    DegerAdiTr = "TK20: Makine Güvenliği Teknik Komitesi",
                    DegerAdiEn = "TK20: Technical Committee on Machine Safety",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 101,
                    KategoriID = 2,
                    DegerAdiTr = "TK21: Tesisat, Isıtma, Soğutma ve Havalandırma Teknik Komitesi",
                    DegerAdiEn = "TK20: Technical Committee on Machine Safety...",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 102,
                    KategoriID = 2,
                    DegerAdiTr = "TK22: Tesisat ve Basınçlı Kaplar Teknik Komitesi",
                    DegerAdiEn = "TK22: Technical Committee on Installation and Pressure Vessels",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 103,
                    KategoriID = 2,
                    DegerAdiTr = "TK23: Metalürji Teknik Komitesi",
                    DegerAdiEn = "TK23: Metallurgical Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 104,
                    KategoriID = 2,
                    DegerAdiTr = "TK24: Gıda Teknik Komitesi",
                    DegerAdiEn = "TK24: Food Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 105,
                    KategoriID = 2,
                    DegerAdiTr = "TK25: Ziraat Teknik Komitesi",
                    DegerAdiEn = "TK25: Agricultural Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 106,
                    KategoriID = 2,
                    DegerAdiTr = "TK26: Kişisel Koruyucu ve Oyun Alanı Donanım Teknik Komitesi",
                    DegerAdiEn = "TK26: Personal Protective and Playground Hardware Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 107,
                    KategoriID = 2,
                    DegerAdiTr = "TK27: Yangın Teknik Komitesi",
                    DegerAdiEn = "TK27: Fire Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 108,
                    KategoriID = 2,
                    DegerAdiTr = "TK28: Ambalaj Teknik Komitesi",
                    DegerAdiEn = "TK28: Packaging Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 109,
                    KategoriID = 2,
                    DegerAdiTr = "TK29: Yönetim Sistemleri Teknik Komitesi",
                    DegerAdiEn = "TK29: Management Systems Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 110,
                    KategoriID = 2,
                    DegerAdiTr = "TK3: Elektrik Elektroteknik ve Güvenlik Teknik Komitesi",
                    DegerAdiEn = "TK3: Technical Committee on Electrical Electrical and Security",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 111,
                    KategoriID = 2,
                    DegerAdiTr = "TK30: Enerji ve Enerji Sistemleri Teknik Komitesi",
                    DegerAdiEn = "TK30: Technical Committee on Energy and Energy Systems",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 112,
                    KategoriID = 2,
                    DegerAdiTr = "TK31: Orman ve Orman Ürünleri Teknik Komitesi",
                    DegerAdiEn = "TK31: Technical Committee on Forestry and Forest Products",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 113,
                    KategoriID = 2,
                    DegerAdiTr = "TK32: Sağlık Teknik Komitesi",
                    DegerAdiEn = "TK32: Health Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 114,
                    KategoriID = 2,
                    DegerAdiTr = "TK33: Medikal Teknik Komitesi",
                    DegerAdiEn = "TK33: Medical Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 115,
                    KategoriID = 2,
                    DegerAdiTr = "TK34: Tekstil Teknik Komitesi",
                    DegerAdiEn = "TK34: Textile Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 116,
                    KategoriID = 2,
                    DegerAdiTr = "TK35: Elektrik ve Elektronik Yetkili Servisleri Teknik Komitesi",
                    DegerAdiEn = "TK35: Technical Committee for Electrical and Electronics Authorized Services",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 117,
                    KategoriID = 2,
                    DegerAdiTr = "TK36: Milli Savunma Teknik Komitesi",
                    DegerAdiEn = "TK36: National Defense Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 118,
                    KategoriID = 2,
                    DegerAdiTr = "TK37: Helal Teknik Komitesi",
                    DegerAdiEn = "TK37: Halal Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 119,
                    KategoriID = 2,
                    DegerAdiTr = "TK38: Sosyal Hizmetler Teknik Komitesi",
                    DegerAdiEn = "TK38: Social Services Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 120,
                    KategoriID = 2,
                    DegerAdiTr = "TK39: Mekanik ve Elektromekanik Yetkili Servisleri Teknik Komitesi",
                    DegerAdiEn = "TK39: Technical Committee for Mechanical and Electromechanical Authorized Services",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 121,
                    KategoriID = 2,
                    DegerAdiTr = "TK4: Elektrik Üretim,İletim Ve Dağıtım Teknik Komitesi",
                    DegerAdiEn = "TK4: Electricity Production, Transmission and Distribution Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 122,
                    KategoriID = 2,
                    DegerAdiTr = "TK40: Demiryolu Teknik Komitesi",
                    DegerAdiEn = "TK40: Railway Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 123,
                    KategoriID = 2,
                    DegerAdiTr = "TK41: Uzay ve Havacılık Teknik Komitesi",
                    DegerAdiEn = "TK41: Space and Aviation Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 124,
                    KategoriID = 2,
                    DegerAdiTr = "TK42: Nükleer Teknik Komitesi",
                    DegerAdiEn = "TK42: Nuclear Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 125,
                    KategoriID = 2,
                    DegerAdiTr = "TK43: Tercüme-1 Teknik Komitesi",
                    DegerAdiEn = "TK43: Translation-1 Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 126,
                    KategoriID = 2,
                    DegerAdiTr = "TK44: Tercüme-2 Teknik Komitesi",
                    DegerAdiEn = "TK44: Translation-2 Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 127,
                    KategoriID = 2,
                    DegerAdiTr = "TK45: İş Sağlığı ve Güvenliği Teknik Komitesi",
                    DegerAdiEn = "TK45: Technical Committee on Occupational Health and Safety",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 128,
                    KategoriID = 2,
                    DegerAdiTr = "TK46: Süs Bitkileri",
                    DegerAdiEn = "TK46: Ornamental plants",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 129,
                    KategoriID = 2,
                    DegerAdiTr = "TK5: Aydınlatma ve Bina İçi Tesisleri İle Yardımcı Donanımları Teknik Komitesi",
                    DegerAdiEn = "TK5: Technical Committee on Lighting and Building Facilities and Auxiliary Equipment",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 130,
                    KategoriID = 2,
                    DegerAdiTr = "TK6: İletkenler, Kablolar Ve Yalıtım Malzemeleri Teknik Komitesi",
                    DegerAdiEn = "TK5: Technical Committee on Lighting and Building Facilities and Auxiliary Equipment",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 131,
                    KategoriID = 2,
                    DegerAdiTr = "TK7: Yüksek Gerilim Teknikleri ve Yıldırımdan Korunma Sistemleri Teknik Komitesi",
                    DegerAdiEn = "TK7: Technical Committee on High Voltage Techniques and Lightning Protection Systems",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 132,
                    KategoriID = 2,
                    DegerAdiTr = "TK8: Elektronik Teknik Komitesi",
                    DegerAdiEn = "TK8: Electronic Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 133,
                    KategoriID = 2,
                    DegerAdiTr = "TK9: Sanayi Hizmetleri Teknik Komitesi",
                    DegerAdiEn = "TK9: Industrial Services Technical Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 134,
                    KategoriID = 2,
                    DegerAdiTr = "TSEK Özel Daimi Komitesi",
                    DegerAdiEn = "TSEK Special Standing Committee",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 135,
                    KategoriID = 2,
                    DegerAdiTr = "TSE-Yapılarda Tahribatsız Muayene Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee on Non-Destructive Testing in TSE-Structures",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 136,
                    KategoriID = 2,
                    DegerAdiTr = "Ulusal Teknik Onay Esas Belirleme Komisyonu",
                    DegerAdiEn = "National Technical Approval Main Commission",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 137,
                    KategoriID = 2,
                    DegerAdiTr = "Yangın Özel Daimi Komitesi",
                    DegerAdiEn = "Special Standing Committee for Fire",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 138,
                    KategoriID = 2,
                    DegerAdiTr = "Yapı Malzemeleri ÖDK",
                    DegerAdiEn = "Construction Materials ÖDK",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 139,
                    KategoriID = 2,
                    DegerAdiTr = "Yapı malzemeleri sektörü",
                    DegerAdiEn = "Building materials sector",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 140,
                    KategoriID = 2,
                    DegerAdiTr = "Yetkili Servis Standardları İhtisas Grubu",
                    DegerAdiEn = "Authorized Service Standards Specialization Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 141,
                    KategoriID = 2,
                    DegerAdiTr = "Yönetim Sistemleri Geliştirme Sektörü",
                    DegerAdiEn = "Management Systems Development Sector",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 142,
                    KategoriID = 2,
                    DegerAdiTr = "Ziraat İhtisas Grubu",
                    DegerAdiEn = "Agricultural Expert Group",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 143,
                    KategoriID = 3,
                    DegerAdiTr = "Tanımsız",
                    DegerAdiEn = "Undefined",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 144,
                    KategoriID = 3,
                    DegerAdiTr = "A (Tadil Görmüş Standard/Amended standard)",
                    DegerAdiEn = "A (Standard / Amended standard)",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 145,
                    KategoriID = 3,
                    DegerAdiTr = "H (İptal Edilmiş Standard/Withdrawn standard)",
                    DegerAdiEn = "H (Canceled Standard / Withdrawn standard)",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 146,
                    KategoriID = 3,
                    DegerAdiTr = "N (Yeni Standard/New standard)",
                    DegerAdiEn = "EN (New Standard)",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 147,
                    KategoriID = 3,
                    DegerAdiTr = "U (Yürürlükteki Standard/Standard)",
                    DegerAdiEn = "U (Current Standard / Standard)",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 148,
                    KategoriID = 3,
                    DegerAdiTr = "W (Yeni İptal Edilen Standard/Withdrawn standard)",
                    DegerAdiEn = "W (New Canceled Standard / Withdrawn standard)",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 149,
                    KategoriID = 3,
                    DegerAdiTr = "A veya N veya U",
                    DegerAdiEn = "A or N or U",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 150,
                    KategoriID = 3,
                    DegerAdiTr = "H veya W",
                    DegerAdiEn = "H or W",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 151,
                    KategoriID = 4,
                    DegerAdiTr = "Tanımsız",
                    DegerAdiEn = "Undefined",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 152,
                    KategoriID = 4,
                    DegerAdiTr = "Kural",
                    DegerAdiEn = "Rule",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 153,
                    KategoriID = 4,
                    DegerAdiTr = "Metot",
                    DegerAdiEn = "Method",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 154,
                    KategoriID = 5,
                    DegerAdiTr = "Cep Telefonu",
                    DegerAdiEn = "Mobile Phone",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 155,
                    KategoriID = 5,
                    DegerAdiTr = "Ev Telefonu",
                    DegerAdiEn = "Home Phone",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 156,
                    KategoriID = 5,
                    DegerAdiTr = "İş Telefonu",
                    DegerAdiEn = "Office Phone",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 157,
                    KategoriID = 5,
                    DegerAdiTr = "Faks",
                    DegerAdiEn = "Fax",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 158,
                    KategoriID = 6,
                    DegerAdiTr = "Ev Adresi",
                    DegerAdiEn = "Home Address",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 159,
                    KategoriID = 6,
                    DegerAdiTr = "İş Adresi",
                    DegerAdiEn = "Business Address",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 160,
                    KategoriID = 6,
                    DegerAdiTr = "Fatura Adresi",
                    DegerAdiEn = "Billing Address",
                    SiraNo = 0,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 161,
                    KategoriID = 7,
                    DegerAdiTr = "İçerik - Atıf Yapılan Standart/Döküman",
                    DegerAdiEn = "Content - Cited Standard / Document",
                    SiraNo = 5,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 162,
                    KategoriID = 7,
                    DegerAdiTr = "İçerik - Ön Söz",
                    DegerAdiEn = "Content - Audit",
                    SiraNo = 2,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 163,
                    KategoriID = 7,
                    DegerAdiTr = "İçerik - Metin",
                    DegerAdiEn = "Content - Text",
                    SiraNo = 4,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 164,
                    KategoriID = 7,
                    DegerAdiTr = "Denetim - Bölüm",
                    DegerAdiEn = "Control - Section",
                    SiraNo = 20,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 165,
                    KategoriID = 7,
                    DegerAdiTr = "İçerik - Açıklama",
                    DegerAdiEn = "Content - Description",
                    SiraNo = 1,
                    DurumID = 1
                },                
                new Deger
                {
                    DegerID = 166,
                    KategoriID = 7,
                    DegerAdiTr = "İçerik - İçindekiler",
                    DegerAdiEn = "Content - Index",
                    SiraNo = 3,
                    DurumID = 1
                },                
                new Deger
                {
                    DegerID = 167,
                    KategoriID = 7,
                    DegerAdiTr = "İçerik - Bölüm",
                    DegerAdiEn = "Content - Section",
                    SiraNo = 6,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 168,
                    KategoriID = 7,
                    DegerAdiTr = "Denetim - Tablo",
                    DegerAdiEn = "Control - Table",
                    SiraNo = 21,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 169,
                    KategoriID = 7,
                    DegerAdiTr = "Denetim - Metin",
                    DegerAdiEn = "Control - Text",
                    SiraNo = 22,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 170,
                    KategoriID = 7,
                    DegerAdiTr = "İçerik - Dipnot",
                    DegerAdiEn = "Content - Footnote",
                    SiraNo = 7,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 171,
                    KategoriID = 7,
                    DegerAdiTr = "Denetim - Tablo - Madde",
                    DegerAdiEn = "Control - Table - Item",
                    SiraNo = 22,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 172,
                    KategoriID = 10,
                    DegerAdiTr = "Kurumsal Yeterlilik Sertifikası Denetimi",
                    DegerAdiEn = "Corporate Qualification Certificate Audit",
                    SiraNo = 22,
                    DurumID = 1
                },
                new Deger
                {
                    DegerID = 173,
                    KategoriID = 10,
                    DegerAdiTr = "Ürün Sertifikası Denetimi",
                    DegerAdiEn = "Product Certification Audit",
                    SiraNo = 22,
                    DurumID = 1
                }
            });
            #endregion

            #region //StandartIcerikTipiSablon
            context.StandartIcerikTipiSablonlar.AddRange(new List<StandartIcerikTipiSablon>
            {
                new StandartIcerikTipiSablon
                {
                    StandartIcerikTipiSablonID = 1,
                    StandarIcerikTipiID = 165,
                    Baslik = "K-Q TSE-ISO-EN 9000 - TSE - TSEK",
                    Detay = $"<ul><li>Bugünkü teknik ve uygulamaya dayanılarak hazırlanmış olan bu standardın, zamanla ortaya çıkacak gelişme ve değişikliklere uydurulması mümkün olduğundan ilgililerin yayınları izlemelerini ve standardın uygulanmasında karşılaştıkları aksaklıkları Enstitümüze iletmelerini rica ederiz.</li><li>Bu standardı oluşturan İhtisas Grubu üyesi değerli uzmanların emeklerini; tasarılar üzerinde görüşlerini bildirmek suretiyle yardımcı olan bilim, kamu ve özel sektör kuruluşları ile kişilerin değerli katkılarınışükranla anarız.</li></ul><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/k-q-tse-iso-en-9000.png' alt='K-Q-TSE-ISO-EN-9000' /><b>Kalite Sistem Belgesi</b><br>İmalât ve hizmet sektörlerinde faaliyet gösteren kuruluşların sistemlerini TS EN ISO 9000 Kalite Standardlarına uygun olarak kurmaları durumunda TSE tarafından verilen belgedir.</p><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/tse.png' alt='TSE' /><b>Türk Standardlarına Uygunluk Markası (TSE Markası)</b><br>TSE Markası, üzerine veya ambalâjına konulduğu malların veya hizmetin ilgili Türk Standardına uygun olduğunu ve mamulle veya hizmetle ilgili bir problem ortaya çıktığında Türk Standardları Enstitüsü’nün garantisi altında olduğunu ifade eder.</p><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/TSEK.png' alt='TSEK' /><b>Kritere Uygunluk Belgesi (TSEK Markası Kullanma Hakkı)</b><br>Kritere Uygunluk Belgesi; Türk Standardları bulunmayan konularda firmaların ürünlerinin ilgili uluslararası standardlar, benzeri Türk Standardları, diğer ülkelerin milli standardları, teknik literatür esas alınarak Türk Standardları Enstitüsü tarafından kabul edilen Kalite Faktör ve Değerlerine uygunluğunu belirten ve akdedilen sözleşme ile TSEK Markası kullanma hakkı verilen firma adına düzenlenen ve üzerinde TSEK Markası kullanılacak ürünlerin ticari Markası, cinsi, sınıfı, tipi ve türünü belirten geçerlilik süresi bir yıl olan belgedir.</p><p><h3>DİKKAT!</h3><br>TS işareti ve yanında yer alan sayı tek başına iken (TS 4600 gibi), mamulün Türk Standardına uygun üretildiğine dair üreticinin beyanını ifade eder. <b>Türk Standardları Enstitüsü tarafından herhangi bir garanti söz konusu değildir.</b></p><p class='text-align:center'><i><b>Standardlar ve standardizasyon konusunda daha geniş bilgi Enstitümüzde sağlanabilir.</i>TÜRK STANDARDLARININ YAYIN HAKLARI SAKLIDIR.</b></p>",
                    DurumID = 1                
                }
            });
            #endregion

            #region //StandartAtifTipiSablon
            context.StandartAtifTipiSablonlar.AddRange( new List<StandartAtifTipiSablon>
            {
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 1,
                    KategoriID = 8,
                    Deger1 = "ISO/IEC 15489-1",
                    Deger2 = "Information and documentation – Records management – Part 1: General",
                    Deger3 = "TS ISO 15489-1",
                    Deger4 = "Bilgi ve dokümantasyon - Belge yönetimi Bölüm 1: Genel",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 2,
                    KategoriID = 8,
                    Deger1 = "ISO/IEC 15489-2",
                    Deger2 = "Information and documentation – Records management – Part 2:Guidelines",
                    Deger3 = "TS ISO/TR 15489-2",
                    Deger4 = "Bilgi ve dokümantasyon - Belge yönetimi - Bölüm 2: Kılavuzlar",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 3,
                    KategoriID = 8,
                    Deger1 = "ISO/IEC 27001",
                    Deger2 = "Information technology - Security techniques - Information security management systems - Requirements",
                    Deger3 = "TS ISO/IEC 27001",
                    Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi güvenliği yönetim sistemleri – Gereksinimler",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 4,
                    KategoriID = 8,
                    Deger1 = "ISO 8601",
                    Deger2 = "Data elements and interchange formats - Information interchange - Representation of dates and times",
                    Deger3 = "TS ISO 8601",
                    Deger4 = "Veri elemanları ve değişim formatları - Bilgi değişimi - Tarih ve zamanın gösterimi",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 5,
                    KategoriID = 8,
                    Deger1 = "ISO/IEC 25051",
                    Deger2 = "Software engineering – Software product Quality Requirements and Evaluation (SQuaRE) – Requirements for quality of Commercial Off - The - Shelf(COTS) software product and instructions for testing",
                    Deger3 = "TS ISO/IEC 25051",
                    Deger4 = "Yazılım mühendisliği - Yazılım ürünü kalite gereksinimleri ve değerlendirmesi(SQuaRE) – Ticari kullanıma hazır(COTS) yazılım ürünü kalitesi için gereksinimler ve test yönergeleri",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 6,
                    KategoriID = 8,
                    Deger1 = "ISO/IEC 15408-1",
                    Deger2 = "Information technology -Security techniques -Evaluation criteria for IT security - Part 1: Introduction and general model",
                    Deger3 = "TS ISO/IEC 15408 - 1",
                    Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi teknolojisi güvenliği için değerlendirme kriterleri - Bölüm 1: Giriş ve genel model",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 7,
                    KategoriID = 8,
                    Deger1 = "ISO/IEC 15408-2",
                    Deger2 = "Information technology -Security techniques -Evaluation criteria for IT security - Part 2: Security functional requirements",
                    Deger3 = "TS ISO/IEC 15408 - 2",
                    Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi teknolojisi güvenliği için değerlendirme kriterleri - Bölüm 2:Güvenlik fonksiyonel bileşenleri",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 8,
                    KategoriID = 8,
                    Deger1 = "ISO/IEC 15408-3",
                    Deger2 = "Information technology -Security techniques -Evaluation criteria for IT security - Part 3: Security assurance requirements",
                    Deger3 = "TS ISO/IEC 15408-3",
                    Deger4 = "Bilgi teknolojisi - Güvenlik teknikleri - Bilgi teknolojisi güvenliği için değerlendirme kriterleri - Bölüm 3:Güvenlik garanti bileşenleri",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 9,
                    KategoriID = 9,
                    Deger1 = "e-Yazışma Teknik Rehberi",
                    Deger2 = "T.C. Kalkınma Bakanlığı Bilgi Toplumu Daire Başkanlığı",
                    Deger3 = "28 Temmuz 2006 tarihli ve 26242 sayılı Resmi Gazetede yayımlanan 2006/38 sayılı Yüksek Planlama Kurulu Kararı ile uygulamaya konan Bilgi Toplumu Stratejisi eki Eylem Planı’nda yer verilen 73 no’lu 'Ortak Hizmetlerin Oluşturulması' eylemi kapsamında geliştirilmiştir.",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 10,
                    KategoriID = 9,
                    Deger1 = "Kayıtlı Elektronik Posta e-Yazışma Projesi İstemci Kütüphaneleri Geliştirici Kılavuzu",
                    Deger2 = "Bilgi Teknolojileri ve İletişim Kurumu (BTK)",
                    Deger3 = "Kayıtlı Elektronik Posta Sistemine İlişkin Usul ve Esaslar Hakkında Yönetmelik, 25 Ağustos 2011 tarih ve 28036 sayılı Resmi Gazete",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 11,
                    KategoriID = 9,
                    Deger1 = "Elektronik Doküman ve Belge Yönetim Sistemi TSE-CCCS-PP-003 Koruma Profili",
                    Deger2 = "Türk Standardları Enstitüsü (TSE)",
                    Deger3 = "2013/4890 sayılı Bakanlar Kurulu Kararı doğrultusunda yayımlanan 20 Haziran 2013 tarihli ve 28683 sayılı Resmi Gazetede yayımlanarak yürürlüğe giren Ulusal Siber Güvenlik Stratejisi ve Eylem Planı Madde 12.",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 12,
                    KategoriID = 9,
                    Deger1 = "Temel Seviye Güvenlik Belgelendirme Kılavuzu",
                    Deger2 = "Türk Standardları Enstitüsü (TSE)",
                    Deger3 = "2013/4890 sayılı Bakanlar Kurulu Kararı doğrultusunda yayımlanan 20 Haziran 2013 tarihli ve 28683 sayılı Resmi Gazetede yayımlanarak yürürlüğe giren Ulusal Siber Güvenlik Stratejisi ve Eylem Planı Madde 12.",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 13,
                    KategoriID = 9,
                    Deger1 = "Birlikte Çalışabilirlik Esasları Rehberi",
                    Deger2 = "T.C. Kalkınma Bakanlığı Bilgi Toplumu Daire Başkanlığı",
                    Deger3 = "2009/4 Sayılı Başbakanlık Genelgesi, Kamu Bilgi Sistemlerinde Birlikte Çalışabilirlik Esasları, 28 Şubat 2009 tarihli ve 27155 sayılı Resmi Gazete",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 14,
                    KategoriID = 9,
                    Deger1 = "Resmi Yazışma Kuralları",
                    Deger2 = "Başbakanlık İdareyi Geliştirme Başkanlığı",
                    Deger3 = "Resmî Yazışmalarda Uygulanacak Usul Ve Esaslar Hakkında Yönetmelik, 2 Şubat 2015 tarih ve 25658 Sayılı Resmi Gazete",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 15,
                    KategoriID = 9,
                    Deger1 = "Standart Dosya Planı",
                    Deger2 = "Başbakanlık Devlet Arşivleri Genel Müdürlüğü",
                    Deger3 = "2005/7 Sayılı Başbakanlık Genelgesi, 25 Mart 2005 tarih ve 25766 sayılı Resmi Gazete",
                    DurumID = 1
                },
                new StandartAtifTipiSablon
                {
                    StandartAtifTipiSablonID = 16,
                    KategoriID = 9,
                    Deger1 = "Devlet Teşkilatı VeriTabanı",
                    Deger2 = "Başbakanlık İdareyi Geliştirme Başkanlığı",
                    Deger3 = "2011/1 Sayılı Başbakanlık Genelgesi, 10 Şubat2011 tarih ve 27842 sayılı Resmi Gazete",
                    DurumID = 1
                }
            });
            #endregion

            #region //Standart
            context.Standartlar.AddRange(new List<Standart>
            {
                new Standart
                {
                    StandartID = 1,
                    TsNo = "TS-13298",
                    KabulTarihi = new DateTime(2015, 10, 23),
                    HazirlikGrubuID = 6,
                    DokumanTipiID = 9,
                    YururlukDurumuID = 5,
                    BaslikTr = "Elektronik Belge ve Arşiv Yönetim Sistemi",
                    BaslikEn = "Electronic Records and Archives Management System",
                    StandartTurID = 3,
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
                    ParaBirimiID = 1,
                    DurumID = 1
                }
            });
            #endregion

            #region // StandartIcerik
            context.StandartIcerikler.AddRange(new List<StandartIcerik>
            {
                new StandartIcerik
                {
                    StandartIcerikID = 1,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "K-Q TSE-ISO-EN 9000 - TSE - TSEK",
                    Detay = $"<ul><li class='ms-hover'>Bugünkü teknik ve uygulamaya dayanılarak hazırlanmış olan bu standardın, zamanla ortaya çıkacak gelişme ve değişikliklere uydurulması mümkün olduğundan ilgililerin yayınları izlemelerini ve standardın uygulanmasında karşılaştıkları aksaklıkları Enstitümüze iletmelerini rica ederiz.<br><br></li><li class='ms-hover'>Bu standardı oluşturan İhtisas Grubu üyesi değerli uzmanların emeklerini; tasarılar üzerinde görüşlerini bildirmek suretiyle yardımcı olan bilim, kamu ve özel sektör kuruluşları ile kişilerin değerli katkılarını şükranla anarız.<br><br></li></ul><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/k-q-tse-iso-en-9000.png' alt='K-Q-TSE-ISO-EN-9000' style='width: 25%;'><b><br></b></p><p><b>Kalite Sistem Belgesi</b><br>İmalât ve hizmet sektörlerinde faaliyet gösteren kuruluşların sistemlerini TS EN ISO 9000 Kalite Standardlarına uygun olarak kurmaları durumunda TSE tarafından verilen belgedir.</p><p><br></p><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/tse.png' alt='TSE' style='width: 25%;'><b><br></b></p><p><b>Türk Standardlarına Uygunluk Markası (TSE Markası)</b><br>TSE Markası, üzerine veya ambalâjına konulduğu malların veya hizmetin ilgili Türk Standardına uygun olduğunu ve mamulle veya hizmetle ilgili bir problem ortaya çıktığında Türk Standardları Enstitüsü’nün garantisi altında olduğunu ifade eder.</p><p><br></p><p><img src='{Resource.CdnDomain}/Content/Backoffice/Images/StandartAciklama/TSEK.png' alt='TSEK' style='width: 25%;'><b><br></b></p><p><b>Kritere Uygunluk Belgesi (TSEK Markası Kullanma Hakkı)</b><br>Kritere Uygunluk Belgesi; Türk Standardları bulunmayan konularda firmaların ürünlerinin ilgili uluslararası standardlar, benzeri Türk Standardları, diğer ülkelerin milli standardları, teknik literatür esas alınarak Türk Standardları Enstitüsü tarafından kabul edilen Kalite Faktör ve Değerlerine uygunluğunu belirten ve akdedilen sözleşme ile TSEK Markası kullanma hakkı verilen firma adına düzenlenen ve üzerinde TSEK Markası kullanılacak ürünlerin ticari Markası, cinsi, sınıfı, tipi ve türünü belirten geçerlilik süresi bir yıl olan belgedir.</p><p></p><h3><br></h3><h3>DİKKAT!</h3><br>TS işareti ve yanında yer alan sayı tek başına iken (TS 4600 gibi), mamulün Türk Standardına uygun üretildiğine dair üreticinin beyanını ifade eder. <b>Türk Standardları Enstitüsü tarafından herhangi bir garanti söz konusu değildir.</b><p></p><p class='text-align:center'><i><b>Standardlar ve standardizasyon konusunda daha geniş bilgi Enstitümüzde sağlanabilir.</b></i><b>TÜRK STANDARDLARININ YAYIN HAKLARI SAKLIDIR.</b></p>",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 165,
                    SiraNo = 1,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 2,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "Önsöz",
                    Detay = "<ul><li class='ms-hover'><li class='ms-hover'>Bu standard, Türk Standardları Enstitüsü’nün Bilişim İhtisas Kurulu’na bağlı TK01 Bilişim Teknolojileri Teknik Komitesi’nce TS 13298: 2009’in revizyonu olarak hazırlanmış ve TSE Teknik Kurulu’nun 23 Ekim 2015 tarihli toplantısında kabul edilerek yayımına karar verilmiştir.<br><br></li><li class='ms-hover'>Bu standardın daha önce yayımlanmış bulunan baskıları geçersizdir.<br><br></li><li class='ms-hover'>Bu standardın hazırlanmasında, milli ihtiyaç ve imkânlarımız ön planda olmak üzere, milletlerarası &nbsp;standardlar ve ekonomik ilişkilerimiz bulunan yabancı ülkelerin standardlarındaki esaslar da gözönünde bulundurularak; yarar görülen hallerde, olabilen yakınlık ve benzerliklerin sağlanmasına ve bu esasların, ülkemiz şartları ile bağdaştırılmasına çalışılmıştır.<br>&nbsp;</li><li class='ms-hover'><li class='ms-hover'>Bu standard son şeklini almadan önce; bilimsel kuruluşlar, üretici/ imalatçı ve tüketici durumundaki konunun ilgilileri ile gerekli işbirliği yapılmış ve alınan görüşlere göre olgunlaştırılmıştır.<br><br></li><li class='ms-hover'><li class='ms-hover'>Bu standardda kullanılan bazı kelime ve/veya ifadeler patent haklarına konu olabilir. Böyle bir patent hakkının belirlenmesi durumunda TSE sorumlu tutulamaz.&nbsp;</li></li></li></li></ul>",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 162,
                    SiraNo = 2,
                    DurumID = 1
                },
                new StandartIcerik
                {
                     StandartIcerikID = 3,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "İçindekiler",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 166,
                    SiraNo = 3,
                    DurumID = 1
                },
                 new StandartIcerik
                {
                    StandartIcerikID = 4,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "Giriş",
                    Detay = "<p style='text-align: justify; '>Bu standard, TS 13298:2009 Elektronik Belge Yönetimi standardının güncel ihtiyaçlara göre yeniden düzenlenmiş halini içermektedir. Standard bir önceki revizyonuna ilave olarak kurumlar arası belge paylaşımı, kayıtlı elektronik postaların yönetimi, elektronik yazışma paketi ve elektronik arşivlerin yönetimi başta olmak üzere bazı yenilikler getirmektedir.</p><p style='text-align: justify;'>Kurumların faaliyetlerini kayıt altına alması ve bu bilgileri paydaşları ile paylaşması kurumsal faaliyetlerin ayrılmaz bir parçasıdır. Herkesin, her zaman, her yerden kolaylıkla ulaşabileceği şeffaf, verimli ve sade bir kurum yapısı günümüzde modern ve demokratik kurumların temel hedefi haline gelmiştir. Bilgi ve iletişim teknolojilerindeki gelişmeler bu hedefi gerçekleştirecek olgunluğa ulaşmıştır ve her geçen gün daha da gelişmektedir. Son yıllarda sıkça duyduğumuz e-ticaret ve e-devlet gibi kavramlar bu gelişmelerin bir sonucudur. E-kurum yapısının temelini ise elektronik bilgi sistemleri oluşturmaktadır.</p><p style='text-align: justify;'>Kurumlarca üretilen bilgi ve belgelerin verimliliğinin arttırılması için ortak standard ve politikaların belirlenmesi göz ardı edilemez bir gereksinimdir. Böyle bir çalışma kullanımı kolay, erişimi hızlı, güvenilir, ucuz, sürekli ve sağlam 'elektronik kurum' yapısının oluşumuna katkı sağlayarak genelde 'e-toplum'a geçiş sürecini hızlandıracaktır.</p><p style='text-align: justify;'>E-kurum faaliyetleri sonucu oluşan elektronik dokümanların belge vasfının korunması, onların üretim aşamasında ve hatta üretim öncesinde elektronik bilgi sistemleri tasarımı aşamasında ele alınmalarını gerekli kılmaktadır. Belge kavramının sistem tasarımcıları ve kullanıcılar tarafından iyi algılanması ve belge yönetimi gereksinimlerinin uygulanması gerekmektedir.</p><p style='text-align: justify;'>Elektronik belge yönetimi son derece geniş ve karmaşık bir alandır. Bu alan bir sistem yaklaşımı ile ele alınmalı ve sistemi oluşturan öğelerin birbiri ile uyumlu çalışması için gerekli önlemler alınmalıdır.</p><p style='text-align: justify;'>Sistemi oluşturan öğelerin başında Elektronik Belge Yönetim Sistemi (EBYS) yazılımı gelmektedir. Elektronik belgeyi yönetmeye talip her kurum bu konuda uzmanlaşmış bir yazılıma ihtiyaç duyacaktır. Bir EBYS yazılımı hiç şüphesiz kurum ERP yazılımlarının bir parçası olarak üretilebilir ya da kurum fonksiyonlarını elektronik ortamda yürütmek için kullanılan diğer yazılımlarla entegre çalışabilen bağımsız bir paket de olabilir. Bu standard bir EBYS yazılımında bulunması gereken asgari fonksiyonel özellikleri tanımlamaktadır.</p><p style='text-align: justify;'>Sistemi oluşturan bir diğer öğe kurumsal politika ve prosedürlerdir. Kurum bilgi ve belge yönetimi prosedürleri EBYS için bir girdi olarak düşünülebilir. Kurumsal belge yönetimi politika ve prosedürlerini henüz geliştirme aşamasında olan kurumlar, bu standardı bir referans kaynağı olarak kullanabilirler.</p><p style='text-align: justify;'>Standardın bu revizyonunda Elektronik Arşivleme Sistemi Referans Modelinin (ELAS/RM) adı altında yeni bir bölüm eklenmiştir. Bu bölüm:</p><ul><li class='ms-hover' style='text-align: justify;'>Elektronik belgelerin üretildikleri dönemdeki hukuki varlığının korunabilmesi,</li><li class='ms-hover' style='text-align: justify;'>Sürekli saklanacak elektronik belgelerin kesintisiz olarak erişilebilirliğinin sağlanması için gerekli tedbirlerin alınması,</li><li class='ms-hover' style='text-align: justify;'>Elektronik belgelerin üretildiği bilgi sistemi platformundan bağımsız olarak erişilebilir olması için gerekli sistem gereksinimlerini, elektronik arşivleme sistemleri uygulamalarında bulunması gerekli temel arşivcilik fonksiyonlarını ve elektronik arşivde yer alacak belgelerin sisteme transfer, düzenleme, tanımlama ve kullanımı gibi fonksiyonlara uygun üstveri modelini tanımlamaktır.</li><p style='text-align: justify;'>Bu standard, dört bölüm halinde tasarlanmıştır. Bu bölümler kendi içerisinde alt bölümlere ayrılmış ve bu alt bölümler altında da sistem gereksinimleri sıralanmıştır. Bu standard içinde yer alan bölümler şunlardır:</p><li class='ms-hover' style='text-align: justify;'>Sistem kriterleri: Sistem tasarımı ve elektronik belgelerin sisteme dâhil edilmesi için gerekli olan gereksinimlerin ele alındığı bölüm.</li><li class='ms-hover' style='text-align: justify;'>Belge kriterleri: Elektronik belge özellikleri, sayısal görüntüleme sistemleri ve fiziksel ortamdaki belgelerin yönetimi ve EBYS içerisine entegrasyonu gibi konuların ele alındığı bölüm.</li><li class='ms-hover' style='text-align: justify;'>Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM): Elektronik ortamda üretilmiş ya da sonradan elektronik ortama aktarılmış olan arşiv malzemesinin yönetimine yönelik kriterler bu bölümde tanımlanmıştır.</li><li class='ms-hover' style='text-align: justify; '>Üst veri elemanları: EBYS ve ELAS/RM’ye ait üst veri gereksinimleri bu bölümde tanımlanmıştır.</li><p style='text-align: justify;'>Sistem ve belge kriterleri ile elektronik arşivleme sistemi referans modeline ait düzenlemeler dört farklı şekilde kodlanmıştır. Her bir kriterin yanındaki kutucuklarda yer alan kodların açılımları şunlardır:</p><li style='text-align: justify;'>S/Z: İlgili maddenin seçmeli mi yoksa zorunlu mu olduğunu göstermek için kullanılmıştır.</li> <li class='ms-hover' style='text-align: justify;'>BA: Kriterin bilgi amaçlı olduğunu ifade eder. Genel olarak ürün veya kurum sertifikasyonunda kullanılmamakla birlikte sistemin geneli hakkında ya da ilgili olduğu bölüm ile ilgili teknik bilgi içermektedir.</li><li style='text-align: justify;' class='ms-hover'>KYS: Belge ve arşiv yönetim sistemini kullanan kurumlarda Kurum Yeterlilik Sertifikasyonu için aranacak şartlarla ilgili kriterlerdir. Sistem kurulumu öncesinde ya da esnasında yerine getirilmesi gereken şartları belirler. Ayrıca EBYS ürünü kullanacak kurumların KYS şartlarını sağlamaları ve akredite kurumlardan sertifika almaları gerekir.</li><li class='ms-hover' style='text-align: justify; '>ÜS: Ürün (EBYS yazılımları) sertifikasyonunda kullanılacak kriterleri tanımlar. Bu standarda uyumluluk belgesi alacak ürünlerin taşıması gereken asgari standartları belirler. Aynı ürün farklı ad ve markalar altında birden fazla sertifikalandırılamaz. Yetkili sertifikasyon kurumu, ürünler arasında bu türden bir benzerlik olduğuna karar verdiği durumlarda ürünlerin kaynak kodlarını değerlendirme amaçlı olarak talep edebilir.</li></ul>",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 169,
                    SiraNo = 4,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 5,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "Elektronik belge ve arşiv yönetim sistemi",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 167,
                    SiraNo = 5,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 6,
                    StandartID = 1,
                    BaslikNo = "1",
                    Baslik = "Kapsam",
                    Detay = "<p>Bu standard, kurumlarda üretilen ve/veya üretilmesi muhtemel elektronik dokümanların belge niteliğinin korunabilmesi için gerekli standardların belirlenmesi amacıyla aşağıdaki konuları kapsar:</p><ol><li class='ms-hover'>Elektronik belge yönetimi sistemi (EBYS) için gerekli sistem gereksinimleri,</li><li class='ms-hover'>EBYS için gerekli belge yönetim teknikleri ve uygulamaları,</li><li class='ms-hover'>Elektronik belgelerin yönetilebilmesi için gerekli gereksinimler,</li><li class='ms-hover'>Elektronik ortamda üretilmemiş belgelerin yönetim fonksiyonlarının elektronik ortamda yürütülebilmesi içingerekli gereksinimler,</li><li class='ms-hover'>Elektronik belgelerde bulunması gereken diplomatik özellikler,</li><li class='ms-hover'>Elektronik belgelerin hukuki geçerliliklerinin sağlanması için alınması gereken önlemler,</li><li class='ms-hover'>Güvenli elektronik imza ve mühür sistemlerinin uygulanması için gerekli sistem alt yapısının tanımlanması.</li></ol><p>Bu standard, ayrıca, elektronik belgelerin arşivlenmesi ve yönetimine yönelik olarak da aşağıdaki konuları kapsamaktadır.</p><ol><li class='ms-hover'>Elektronik ortamda üretilmiş ve kurumsal kimlik doğrulama sistemleri ve/veya elektronik / mobil imza sistemleri ile imzalanmış kurumsal belgelerin,</li><li class='ms-hover'>Fiziksel ortamlarda üretilmiş olup sonradan sayısallaştırma yöntemi ile elektronik ortama aktarılmış yazılı, basılı, çizili her türlü doküman ve belgelerin,</li><li class='ms-hover'>Dijital olarak üretilmiş resim, ses ve görüntü kayıtlarının,</li><li class='ms-hover'>Sayısallaştırma yöntemi ile elektronik ortama aktarılmış analog resim, ses ve görüntü kayıtlarının yönetilmesine imkân sağlayacak düzenlemeleri kapsamaktadır.</li></ol><p>Bu standard, elektronik belgelerin üretim ortamına ait bilgi güvenliği ile ilgili herhangi bir kriter kapsamaz. Bilgi güvenliği yönetim sistemi ile ilgili olarak TS ISO/IEC 27001 standardı kullanılabilir.</p>",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 163,
                    SiraNo = 6,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 7,
                    StandartID = 1,
                    BaslikNo = "2",
                    Baslik = "Atıf yapılan standard ve/veya dokümanlar",
                    Detay = @"Aşağıda verilen, atıf yapılan standardların hükümleri bu standardın hükümleri sayılır. Tarih belirtilen atıflarda, daha sonra yapılan tadil ve revizyonlar uygulanmaz. Bununla birlikte, bu standarda dayalı anlaşmalarda taraflara, aşağıda verilen standardların en yeni baskılarını uygulama imkânını araştırmaları önerilir. Tarih belirtilmeyen atıflarda, ilgili standardın en son baskısı kullanılır. Bütün standardların yürürlükte bulunan baskıları TSE’den temin edilebilir. (*) işaretli olanlar bu standardın basıldığı tarihte İngilizce metin olarak yayımlanmış Türk Standardlarıdır.",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 161,
                    SiraNo = 7,
                    DurumID = 1,
                    StandartAtiflar = new List<StandartAtif>
                    {
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 1,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 2,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 3,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 4,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 5,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 6,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 7,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 8,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 9,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 10,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 11,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 12,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 13,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 14,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 15,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 7,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 16,
                            DurumID = 1
                        }
                    }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 8,
                    StandartID = 1,
                    BaslikNo = "3",
                    Baslik = "Terimler, tarifler ve kısaltmalar",
                    Detay = "Bu standard için aşağıdaki terimler ve tarifler geçerlidir. Burada yer almayan terimler için ISO 15489’da belirtilen terimler ve tarifler kullanılmalıdır.",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 163,
                    SiraNo = 8,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 9,
                    StandartID = 1,
                    BaslikNo = "3.1",
                    Baslik = "Arşiv Kurumu",
                    Detay = "Belirli bir yasal çerçeve içerisinde faaliyet gösteren ve farklı kurumlar tarafından üretilmiş olan arşiv malzemesini ayıklama, düzenleme, tanımlama, hizmete sunma ve diğer yönetimsel fonksiyonları yerine getiren ulusal, bölgesel ya da özel amaçlı arşiv kurumları.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 9,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 10,
                    StandartID = 1,
                    BaslikNo = "3.2",
                    Baslik = "Arşiv Yönetim Sistemi (AYS)",
                    Detay = "Arşiv malzemesinin arşiv kurumlarına transferi, düzenlenmesi, tanımlanması, kullanıma sunulması, korunması ve diğer yönetimsel fonksiyonları gerçekleştirmek üzere geliştirilmiş bilgisayar sistemi.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 10,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 11,
                    StandartID = 1,
                    BaslikNo = "3.3",
                    Baslik = "Belge",
                    Detay = "Herhangi bir bireysel veya kurumsal fonksiyonun yerine getirilmesi için alınmış ya da fonksiyonun sonucunda üretilmiş, içerik, ilişki ve formatı ile ait olduğu fonksiyon için delil teşkil eden kayıtlı bilgi.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 11,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 12,
                    StandartID = 1,
                    BaslikNo = "3.4",
                    Baslik = "Diplomatik özellik",
                    Detay = "Belgelerin orijinalliğinin tespit edilmesinde kullanılabilecek her türlü içerik, format, ilişki ve sunum özellikleri.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 12,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 13,
                    StandartID = 1,
                    BaslikNo = "3.5",
                    Baslik = "Doküman",
                    Detay = "Kurumsal faaliyetlerin yerine getirilmesinde üretilen ya da toplanan, henüz belge vasfı kazanmamış her türlü kayıtlı bilgi.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 13,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 14,
                    StandartID = 1,
                    BaslikNo = "3.6",
                    Baslik = "Dosya tasnif planı",
                    Detay = "Kurumsal faaliyetlerin ve bu faaliyetler sonucunda oluşan belgelerin kurumsal yapıya ve hiyerarşiye uygun olarak konusal olarak sınıflandırılması için geliştirilmiş belge yönetim aracı.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 14,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 15,
                    StandartID = 1,
                    BaslikNo = "3.7",
                    Baslik = "Elektronik belge yönetimi",
                    Detay = "Kurumların gündelik işlerini yerine getirirken oluşturdukları her türlü dokümantasyonun içerisinden kurum faaliyetlerinin delili olabilecek belgelerin ayıklanarak bunların içerik, format ve ilişkisel özelliklerini korumak ve bu belgeleri üretimden nihai tasfiyeye kadar olan süreç içerisinde yönetmek.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 15,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 16,
                    StandartID = 1,
                    BaslikNo = "3.8",
                    Baslik = "Kurum arşivi",
                    Detay = "Ait olduğu kurum tarafından üretilen belgelerden idarî, malî ve hukukî açıdan saklama süresini doldurmuş olan arşiv belgelerinin ayıklanması, düzenlenmesi, tanımlanması, hizmete sunulması ve diğer yönetimsel fonksiyonları yerine getiren birim.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 16,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 17,
                    StandartID = 1,
                    BaslikNo = "3.9",
                    Baslik = "Provenans",
                    Detay = "Kendi faaliyetlerinin yürütülmesi sırasında belge üreten ve saklayan kişi veya kurumlar bir belgenin provenansını oluşturur. Provenans prensibi ise; aynı provenansa (kaynak, köken, menşe) sahip belgelerin, başka bir provenansa sahip olanlarla karıştırılmaması gerektiğini öngören temel ilke. 'Fonlara Saygı' (respectdes fonds) olarak da anılır.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 17,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 18,
                    StandartID = 1,
                    BaslikNo = "3.10",
                    Baslik = "Tasfiye",
                    Detay = "Kurumsal gereksinimler açısından saklanmasına gerek kalmayan belgelerin kurum belge sisteminin dışına çıkarılması. Tasfiye işlemi artık ihtiyaç duyulmayan belgelerin kurum içinde veya kurum dışında başka bir kuruma/birime transfer edilmesini ya da imha edilmesini öngörür.",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 18,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 19,
                    StandartID = 1,
                    BaslikNo = "3.11",
                    Baslik = "Varlık",
                    Detay = "Arşiv yönetim sistemi içerisinde yer alan ve bağımsız olarak tanımlanan belge, dosya / klasör, seri, fon, vs. gibi kayıtlar. <p><b><br>Kısaltmalar</b><br></p><table><tbody><tr><td width='100'>AYS</td><td>Arşiv Yönetim Sistemi</td></tr><tr><td>DERBİS</td><td>Dernekler Bilgi Sistemi</td></tr><tr><td>DETSİS</td><td>Devlet Teşkilatı Merkezi Kayıt Sistemi</td></tr><tr><td>DGS</td><td>Dijital Görüntüme Sistemi</td></tr><tr><td>DYS</td><td>Doküman Yönetim Sistemi</td></tr><tr><td>EBYS</td><td>Elektronik Belge Yönetim Sistemi</td></tr><tr><td>ELAS/RM</td><td>Elektronik Arşivleme Sistemi Referans Modeli</td></tr><tr><td>EYP</td><td>Elektronik Yazışma Paketi</td></tr><tr><td>KEP</td><td>Kayıtlı Elektronik Posta</td></tr><tr><td>KPS</td><td>Kimlik Paylaşım Sistemi</td></tr><tr><td>MERNİS</td><td>Merkezî Nüfus İdare Sistemi</td></tr><tr><td>MERSİS</td><td>Merkezi Sicil Kayıt Sistemi</td></tr><tr><td>MTK</td><td>Merkezi Tüzel Kişilik Bilgi Sistemi</td></tr><tr><td>UAPS</td><td>Ulusal Adres Paylaşım Sistemi</td></tr><tr><td>VBYS</td><td>Vakıf Bilgi Yönetim Sistemi</td></tr></tbody></table>",
                    UstIcerikID = 8,
                    StandartIcerikTipiID = 163,
                    SiraNo = 19,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 20,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "Bölüm 1: Sistem Kriterleri",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 164,
                    SiraNo = 20,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 21,
                    StandartID = 1,
                    BaslikNo = "4",
                    Baslik = "Dosya tasnif planları",
                    Detay = null,
                    UstIcerikID = 20,
                    StandartIcerikTipiID = 169,
                    SiraNo = 21,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 22,
                    StandartID = 1,
                    BaslikNo = "4.1",
                    Baslik = "Dosya planının oluşturulması",
                    Detay = null,
                    UstIcerikID = 21,
                    StandartIcerikTipiID = 168,
                    SiraNo = 22,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 23,
                    StandartID = 1,
                    BaslikNo = "4.1.1",
                    Baslik = null,
                    Detay = "EBYS ait olduğu kurumun yapısını ve fonksiyonlarını yansıtacak bir dosya tasnif planını içinde barındırmalı ve / veya kurum dosya tasnif planı ile uyumlu olmalıdır.",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 23,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 24,
                    StandartID = 1,
                    BaslikNo = "4.1.2",
                    Baslik = null,
                    Detay = "EBYS içerisinde temsil edilecek olan dosya tasnif planı hiyerarşik bir yapıda olmalı ve asgari üç seviyeden oluşmalıdır. Asgari seviye tercih edildiğinde birim, seri ve dosya seviyeleri tercih edilmelidir. EBYS içerisinde yer alabilecek dosya tasnif planı seviyeleri için Madde 5.2’deki Belge Hiyerarşisi bölümüne bakılmalıdır.",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 24,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 25,
                    StandartID = 1,
                    BaslikNo = "4.1.3",
                    Baslik = null,
                    Detay = "Dosya tasnif planında temsil edilecek olan, kurumsal fonksiyon, seri, alt seri, dosya / klasör adları gibi elemanlar Elektronik Belge Yöneticisi tarafından tanımlanabilmelidir",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 25,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 26,
                    StandartID = 1,
                    BaslikNo = "4.1.4",
                    Baslik = null,
                    Detay = "Sistem, dosya tasnif planında temsil edilen eleman kodlarının tekrar etmemesi için gerekli kontrolleri yapmalı ve kullanıcıyı uyarmalıdır.",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 26,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 27,
                    StandartID = 1,
                    BaslikNo = "4.1.5",
                    Baslik = null,
                    Detay = "Dosya tasnif planındaki eleman adları alfa karakterlerin yanı sıra nümerik karakterleri de içerebilir. Sistem, eleman adlarının oluşturulmasında işletim sisteminin sınırlamalarının dışında herhangi bir sınırlama getirmemelidir.",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 27,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 28,
                    StandartID = 1,
                    BaslikNo = "4.1.6",
                    Baslik = null,
                    Detay = "EBYS, dosya tasnif planının kurulum aşaması sonrasında doğabilecek güncelleme ihtiyaçlarına imkân tanımalıdır. Bu bağlamda herhangi bir seviyeye yeni eleman eklenmesi sağlanmalıdır. Ancak herhangi bir seviyeden bir elemanın çıkarılabilmesi sadece o elemana bağlı alt elemanların veya elektronik belgelerin olmadığı durumlarda ya da elemanlar başka bir yere taşındıktan sonra mümkün olabilmelidir.",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 28,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 29,
                    StandartID = 1,
                    BaslikNo = "4.1.7",
                    Baslik = null,
                    Detay = "<p>Sistem aynı anda birden fazla dosya tasnif planının oluşturulmasına ve kullanılmasına imkân sağlamalıdır. </p><p>Not: Bu, özellikle birleşen kurumların geçmiş dönemlere ait belgelerinin yönetimi aşamasında ihtiyaç duyulabilecek bir özelliktir.<br></p>",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 29,
                    DurumID = 1,
                     StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 30,
                    StandartID = 1,
                    BaslikNo = "4.1.8",
                    Baslik = null,
                    Detay = "EBYS kullanacak kurumlar, kurumsal yapılarına ve 2005/7 sayılı Başbakanlık Genelgesine uygun bir dosya planı oluşturmak ve bunun EBYS sistemine entegre edilmesini sağlamalıdır.",
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 171,
                    SiraNo = 30,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 31,
                    StandartID = 1,
                    BaslikNo = "4.2",
                    Baslik = "Dosya tasnif planı elemanlarının tanımlanması",
                    Detay = null,
                    UstIcerikID = 21,
                    StandartIcerikTipiID = 168,
                    SiraNo = 31,
                    DurumID = 1,
                },
                new StandartIcerik
                {
                    StandartIcerikID = 32,
                    StandartID = 1,
                    BaslikNo = "4.2.1",
                    Baslik = null,
                    Detay = "EBYS, dosya tasnif planında yer alan her bir eleman için üstveri tanımlanmasına imkân sağlamalıdır. Dosya tasnif planında ya da bu planla ilişkilendirilmiş alt elemanlar ile elektronik belgelere ait üstveriler üzerinde değişiklik yapılması yetkisi sadece belge yöneticilerine ait olmalıdır",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 32,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 33,
                    StandartID = 1,
                    BaslikNo = "4.2.2",
                    Baslik = null,
                    Detay = "<div>EBYS, dosya tasnif planı içerisinde temsil edilen her bir eleman için kimlik bilgisi niteliğinde en az iki adet üstveri eleman tanım alanı</div><div>bulundurmalıdır. Bu alanlar şunlardır:&nbsp;<br><br></div><ul><li class='ms-hover'>Her bir eleman için tekrar etmeyecek nitelikte nümerik veya alfa-nümerik bir referans kodu alanı,&nbsp;</li><li class='ms-hover'>Her bir eleman için alfa nümerik bir ad alanı&nbsp;</li></ul>",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 33,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 34,
                    StandartID = 1,
                    BaslikNo = "4.2.3",
                    Baslik = null,
                    Detay = "<div>EBYS, dosya tasnif planındaki elemanların hiyerarşideki en alt seviyeden itibaren bir üst seviye ile ilişkilendirilmesine imkân sağlamalıdır.</div><div>&nbsp;</div><div>Not: En alt seviye her bir eleman için aynı olmak zorunda değildir.</div>",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 34,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 35,
                    StandartID = 1,
                    BaslikNo = "4.2.4",
                    Baslik = null,
                    Detay = "<div>EBYS içerisine dâhil edilen her bir elektronik belgeye ait dosya plan kodları otomatik olarak üstveri tablosuna dâhil edilmelidir. Elektronik belgenin dâhil edildiği seviyeden başlayarak yukarı doğru tüm seviyelere ait kodlar üstveri tablosunda görülebilmelidir. </div><div>&nbsp;</div><div>Not: Elektronik belge yöneticisinin “Halkla İlişkiler” serisi altında “Tanıtım Faaliyetleri” adında bir alt seri açtığını ve buraya “Broşür talebi” konusunda bir yazışmayı dâhil edildiği varsayılsın. “Broşür talebi” belgesine ait üstveri kaydının, söz konusu belgeye, belgenin bağlı olduğu alt seriye ve alt serinin bağlı olduğu seriye ait referans kodlarını barındırması beklenir.</div>",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 35,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 36,
                    StandartID = 1,
                    BaslikNo = "4.2.5",
                    Baslik = null,
                    Detay = "<div>EBYS içindeki elemanların isimlendirilmesi kontrollü terminoloji kullanabilmelidir. Bu bağlamda sistem, içerisinde kontrollü terminoloji listelerinin bulundurulmasına imkân tanımalıdır. </div><div>&nbsp;</div><div>Not: Kontrollü terminoloji, her hangi bir elemanın isimlendirilmesinde kullanılacak tanımlamaların önceden belirlenmiş listelerden alınması anlamını taşımaktadır.</div>",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 36,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 37,
                    StandartID = 1,
                    BaslikNo = "4.2.6",
                    Baslik = null,
                    Detay = "Dosya tasnif planındaki elemanlara ait ad bilgileri şahıs ve tüzel kişilik adları ile tarihler de olabilir. Burada verilen tarihler geçerlilik kontrolüne tabi tutulmalıdır. Şahıs ve tüzel kişi adları daha önceden belirlenmiş listelerden alınabilmelidir.",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 37,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 38,
                    StandartID = 1,
                    BaslikNo = "4.2.7",
                    Baslik = null,
                    Detay = "<div>EBYS içerisine dahil edilen klasörler bölümlerden oluşabilmelidir. Sistem içindeki elemanların birbiri ile dikey ilişkisi olurken bölümler</div><div>kendi aralarında yatay bir ilişki içinde olmalıdır. &nbsp;</div><div>&nbsp;</div><div>Not: Bölüm, klasörleri yönetilebilir küçük parçalara bölmek içinkullanılır. Bazı durumlarda bir klasörü çeşitli nedenlerle birden fazla</div><div>parçaya bölmek gerekebilir. Belge yönetim sistemi içerisindeki elemanları birbirleri ile olan hiyerarşik ilişkileri 5.2’de grafiksel olarak</div><div>gösterilmiş ve açıklanmıştır.&nbsp;</div>",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 38,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 39,
                    StandartID = 1,
                    BaslikNo = "4.2.8",
                    Baslik = null,
                    Detay = "Açılan bölümlere ait tarih bilgileri otomatik olarak kayıt altına alınmalı ve üstveri tablosunda gösterilmelidir.",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 39,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 40,
                    StandartID = 1,
                    BaslikNo = "4.2.9",
                    Baslik = null,
                    Detay = "Bölümlerin klasör adı, ait olduğu seri adı ve kodu gibi ortak bilgileri, yeni açılan bölüme ait üstveri tablosuna otomatik olarak kaydedilmelidir.",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 40,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 41,
                    StandartID = 1,
                    BaslikNo = "4.2.10",
                    Baslik = null,
                    Detay = "<div>Bir klasör için sadece bir bölüm açık olmalıdır. Herhangi bir seri altında yeni bir bölüm açıldığında daha önce açılmış olan bölüm kapatılmalı ve kapalı bölümlere belge kaydı yapılması engellenmelidir.</div><div><br></div><div>Not: Kapatılmış bölümlerdeki belgelere erişiminde yasal ve prosedürsel sınırlamalar olmadığı sürece herhangi bir kısıtlama olmamalıdır.&nbsp;</div>",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 41,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 42,
                    StandartID = 1,
                    BaslikNo = "4.2.11",
                    Baslik = null,
                    Detay = "<div>Kapatılmış bölümlerin tekrar açılması ve bunlara belge kaydı yapılması yalnızca elektronik belge yöneticisi tarafından kontrollü olarak yapılmalıdır.</div><div><br></div><div>Not: Bazı durumlarda kullanıcı hatalarını gidermek için bu işleme ihtiyaç duyulabilir.&nbsp;</div>",
                    UstIcerikID = 31,
                    StandartIcerikTipiID = 171,
                    SiraNo = 42,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 43,
                    StandartID = 1,
                    BaslikNo = "4.3",
                    Baslik = "Dosya tasnif planının yönetilmesi",
                    Detay = null,
                    UstIcerikID = 21,
                    StandartIcerikTipiID = 168,
                    SiraNo = 43,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 44,
                    StandartID = 1,
                    BaslikNo = "4.3.1",
                    Baslik = null,
                    Detay = "<div>EBYS bir seri veya klasör altında sisteme dahil edilmiş olan elektronik belgeler, toplu halde başka bir seri veya klasör altına taşınabilmelidir. &nbsp;</div><div>&nbsp;</div><div>Not: Kurumların yapısında oluşabilecek büyük çaplı değişikliklerde dosya tasnif planı değişikliğe uğrayabilir. Kurumsal devamlılık ve kurum fonksiyonlarının aksamaması için bu tür değişikliklere ihtiyaç duyulabilir. Ancak bu normal şartlarda başvurulacak bir işlem değildir.&nbsp;</div>",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 44,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 45,
                    StandartID = 1,
                    BaslikNo = "4.3.2",
                    Baslik = null,
                    Detay = "<div>Daha önce bir seri ve / veya klasör altında kayıt altına alınmış bir elektronik belge başka bir klasör altına taşınabilmelidir. &nbsp;</div><div>&nbsp;</div><div>Not: Bu işlem dosyalama hatalarını düzeltmek için ihtiyaç duyulabilecek bir işlemdir. Ancak bir elemanın başka bir yere taşınması, o elemana ait referans numarası ve ad bilgisi gibi çeşitli üst verilerde değişiklik yapmayı da gerektirebilir. EBYS taşınan elemanların üst veriler üzerinde yetkili kullanıcılar tarafından değişiklik yapılabilmesine imkân tanımalıdır.&nbsp;</div>",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 45,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 46,
                    StandartID = 1,
                    BaslikNo = "4.3.3",
                    Baslik = null,
                    Detay = "Elektronik belgelerin seriler ve klasörler arasında taşınması işlemi, elektronik belge yöneticisi kontrolünde ve yetkisinde olmalıdır.",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 46,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 47,
                    StandartID = 1,
                    BaslikNo = "4.3.4",
                    Baslik = null,
                    Detay = "<div>Elektronik belgenin yeniden dosyalanmasına ilişkin işlemler kayıt altına alınmalıdır.&nbsp;</div><div>&nbsp;</div><div> Not: Belge hareketlerine ait işlemlerin kayıtları en azından günlük işlem dosyalarında tutulmalıdır. İdeal olarak bu bilgiler elektronik belgeye ait üstveri tablosunda tutulmalıdır. &nbsp;</div>",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 47,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 48,
                    StandartID = 1,
                    BaslikNo = "4.3.5",
                    Baslik = null,
                    Detay = "<div><div>EBYS içerisinde tasnif edilmiş herhangi bir elektronik belgenin tamamının veya bir bölümünün silinmesi veya değiştirilmesi engellenmelidir. Elektronik bir belgenin imha işlemi ancak aşağıdaki şartlarda mümkün olabilmelidir. <br><br></div><ul><li class='ms-hover'>Elektronik belge saklama planları gereğince elektronik belge yöneticisinin kontrol ve yetkisinde silinebilir. Saklama planları ile ilgili kurallar için Madde 5’e bakılmalıdır. <br><br></li><li class='ms-hover'>Herhangi bir hatayı düzeltmek amacıyla yapılan bakım işlemleri sırasında elektronik belgeler silinebilir. Bu işlem yetkili belge yöneticisi tarafından yapılmalı ve işlem kayıt altına alınmalıdır.&nbsp;</li></ul></div>",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 48,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 49,
                    StandartID = 1,
                    BaslikNo = "4.3.6",
                    Baslik = null,
                    Detay = "Klasörlerin açılış ve kapanış işlemleri yetkili belge yöneticisi tarafından yapılmalıdır.",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 49,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 50,
                    StandartID = 1,
                    BaslikNo = "4.3.7",
                    Baslik = null,
                    Detay = "<div><div>Klasörleri kapama ve/veya yeni bölüm açma zamanlarına ait kriterler sistem kurulum aşamasında belirlenebilmelidir. Elektronik Belge Yöneticisi klasörlerin kapanma zamanları ilgili olarak;&nbsp;</div><div>&nbsp;</div><ul><li class='ms-hover'>Takvim yılının veya mali yıl bitişi gibi zaman dilimleri,</li><li class='ms-hover'>Klasöre ilk belge kaydından itibaren belli bir zamanın geçmesini esas alan zaman periyotları,</li><li class='ms-hover'>Klasörde yer alacak dosya sayısı veya toplam dosya büyüklüğü gibi sayısal kriterler geliştirebilir. &nbsp;</li></ul><div>Not: Klasörlerin kapanması aynı zamanda o klasöre bağlı belgeler için saklama süresinin başlatılması anlamına geldiğinden ihmal edilmemesi gereken bir konudur.</div></div>",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 50,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 51,
                    StandartID = 1,
                    BaslikNo = "4.3.8",
                    Baslik = null,
                    Detay = "Klasörlerin ve klasör bölümlerinin kapanış tarihleri ilgili üstveri dosyasında tutulmalıdır.",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 51,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 52,
                    StandartID = 1,
                    BaslikNo = "4.3.9",
                    Baslik = null,
                    Detay = "Elektronik belge yöneticisinin bakım işlemleri için açmış olduğu kapalı klasörler, yönetici sistemden çıkar çıkmaz kapatılmalı, bu klasörlerin açık kalmasına izin verilmemelidir. ",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 52,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 53,
                    StandartID = 1,
                    BaslikNo = "4.3.10",
                    Baslik = null,
                    Detay = "Kullanıcılar belgeler arasında çapraz referanslar verebilmelidir. Bu işlem birbiri ile ilişkili belgelerin birbirine bağlanması için kullanılır.",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 53,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 54,
                    StandartID = 1,
                    BaslikNo = "4.3.11",
                    Baslik = null,
                    Detay = "<div><div>EBYS, sistem bütünlüğünün ve güvenirliğinin sağlanması için<br><br></div><ul><li class='ms-hover'>Her türlü bakım işlemlerini,</li><li class='ms-hover'>Tüm kullanıcı hareketlerini,</li><li class='ms-hover'>Sistem hatalarını ve arızalarını kayıt altına almalıdır.&nbsp;</li></ul></div>",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 54,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 55,
                    StandartID = 1,
                    BaslikNo = "4.3.12",
                    Baslik = null,
                    Detay = "EBYS, herhangi bir elektronik belgenin birden fazla dosya planı elemanı ile ilişkilendirilmesine olanak sağlamalıdır. Bu işlem elektronik belgenin kopyalanmasından ziyade mümkün olduğu ölçüde çapraz referanslar ve işaretleyicilerle yapılmalıdır.",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 55,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 56,
                    StandartID = 1,
                    BaslikNo = "4.3.13",
                    Baslik = null,
                    Detay = "EBYS, dinamik bir raporlama yeteneğine sahip olmalıdır. Dosya tasnif planı ve bu plana bağlı elektronik belgelerle ilgili periyodik ve istatistik raporlar kullanıcıların belirleyeceği kriterlere göre alınabilmelidir",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 56,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 57,
                    StandartID = 1,
                    BaslikNo = "4.3.14",
                    Baslik = null,
                    Detay = "EBYS, kullanıcıların elektronik belgelerin erişimi için görsel bir kullanıcı ara yüzü içermelidir. Kullanıcılar, yetkileri dâhilinde, grafik ara yüz aracılığı ile elektronik belgeler arasında gezinebilmeli, istedikleri belgeleri seçme, görüntüleme, kopyalama ve yazdırma gibi işlemleri yapabilmelidir.",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 57,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 58,
                    StandartID = 1,
                    BaslikNo = "4.3.15",
                    Baslik = null,
                    Detay = "EBYS içerisindeki elemanlara ve bu elemanlara bağlı elektronik belgelere ait envanter listeleri oluşturulabilmelidir. ",
                    UstIcerikID = 43,
                    StandartIcerikTipiID = 171,
                    SiraNo = 58,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 59,
                    StandartID = 1,
                    BaslikNo = "5",
                    Baslik = "Saklama planları",
                    Detay = null,
                    UstIcerikID = 20,
                    StandartIcerikTipiID = 169,
                    SiraNo = 59,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 60,
                    StandartID = 1,
                    BaslikNo = "5.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 168,
                    SiraNo = 60,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 61,
                    StandartID = 1,
                    BaslikNo = "5.1.1",
                    Baslik = null,
                    Detay = "Saklama planları belge yönetiminin en temel unsurlarından biridir. EBYS içerisine dâhil edilmiş olan herhangi bir belgenin ne kadar süre ile sistemde kalacağını ve saklama süresinin bitiminde belgenin nasıl bir işleme tabi tutulacağını belirler. ",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 61,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 62,
                    StandartID = 1,
                    BaslikNo = "5.1.2",
                    Baslik = null,
                    Detay = "<div><div>Saklama planına dâhil edilecek elemanlar dosya tasnif planları ile aynı olmalıdır. Diğer bir deyişle dosya tasnif planı ile sisteme dahil edilen her bir eleman için saklama planında bir saklama süresi tanımlanmalıdır.</div><div><br></div><div>Not: Bazı durumlarda dosya tasnif planlarında seri seviyesinin üzerinde elemanlar tanımlanmış olabilir. Bu seviyeler genelde elektronik belgeyi üreten kurum ve birimleri ifade eder. Teknik olarak saklama planları sadece seri, klasör ve dosya gibi fiziksel varlıkların sistemde ne kadar kalacağını belirleyeceğinden seri seviyesi üzerindeki elemanlar saklama planlarında tanımlanır, ancak bunlar için herhangi bir saklama süresi tanımlanmaz.&nbsp;</div></div>",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 62,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 63,
                    StandartID = 1,
                    BaslikNo = "5.1.3",
                    Baslik = null,
                    Detay = "BYS, saklama planlarının sistem kurulum aşamasında tanımlanmasına imkân tanımalıdır.",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 63,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 64,
                    StandartID = 1,
                    BaslikNo = "5.1.4",
                    Baslik = null,
                    Detay = "BYS bünyesinde tanımlanan saklama planları, sistem içerisinde yer alan elemanların saklama sürelerine ait raporlama ve saklama süresi dolan elemanların inceleme, değerlendirme ve tasfiyesinin gerçekleştirilmesini sağlayacak fonksiyonlar içermelidir.",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 64,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 65,
                    StandartID = 1,
                    BaslikNo = "5.1.5",
                    Baslik = null,
                    Detay = "<div><div>EBYS, saklama süresi dolan elemanların tasfiye işlemlerinin otomatik olarak gerçekleştirilmesine yönelik fonksiyonlar içermelidir. Bu bağlamda: <br><br></div><ul><li class='ms-hover'>Her yıl ocak ayı içerisinde saklama süresi dolan eski yıllara ait belgeler rapor halinde sistemden alınabilmelidir. &nbsp;</li><li class='ms-hover'>Saklama süresi dolmuş olan belgeler için Ayıklama İmha &nbsp;Komisyonlarının vermiş oldukları kararlar (imha, kurum arşivine transfer, başka bir kuruma transfer vs.) sistem üzerinden gerçekleştirilebilmelidir.</li></ul></div>",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 65,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 66,
                    StandartID = 1,
                    BaslikNo = "5.1.6",
                    Baslik = null,
                    Detay = "Saklama planlarının EBYS içerisinde tanımlanması ve planlar üzerinde yapılabilecek değişiklikler ve güncelleme işlemleri, elektronik belge yöneticisinin kontrol ve sorumluluğunda olmalıdır.",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 66,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 67,
                    StandartID = 1,
                    BaslikNo = "5.1.7",
                    Baslik = null,
                    Detay = "Saklama planları, sistemde yer alan herhangi bir eleman ile ilişkilendirilebilmelidir. Bu elemanlar seri, klasör ve dosyadır. Ayrıca bu elemanlarla yatay ve dikey ilişkili alt elemanlarda saklama planları ile ilişkilendirilebilmelidir. Saklama planları arasındaki yatay ve dikey ilişkiler için Şekil 1’e bakılmalıdır.",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 67,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 68,
                    StandartID = 1,
                    BaslikNo = "5.1.8",
                    Baslik = null,
                    Detay = "<div><div>Saklama planları, sisteme dâhil edilen her bir elemana ait referans numarası ve tanım bilgisi, saklama süresi, tasfiye işlem tanımı,</div><div>gerekçe ve yasal dayanakları içermelidir.&nbsp;</div><div><br></div><div>Not: Saklama planında yer alan elemanlara ait referans numaraları ve tanımlar koşullar elverdiği sürece dosya tasnif planlarındaki</div><div>tanımlarla aynı olmalıdır.&nbsp;</div></div>",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 68,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 69,
                    StandartID = 1,
                    BaslikNo = "5.1.9",
                    Baslik = null,
                    Detay = "BYS, sistemde tanımlı her bir elemana ait saklama planını otomatik olarak takip etmeli ve saklama süresi dolanların tasfiye işlemlerinin yapılabilmesi için elektronik belge yöneticisini uyarmalıdır.",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 69,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 70,
                    StandartID = 1,
                    BaslikNo = "5.1.10",
                    Baslik = null,
                    Detay = "Elektronik belgelerin ait oldukları klasörlerin veya serilerin değiştirilmesi durumunda, EBYS yeni klasöre veya seriye ait saklama süreleri konusunda elektronik belge yöneticisini uyarmalı ve gerekli değişiklikler otomatik olarak yapabilmelidir.",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 70,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 71,
                    StandartID = 1,
                    BaslikNo = "5.1.11",
                    Baslik = null,
                    Detay = "EBYS kullanacak kurumlar, dosya tasnif planlarına ve ilgili mevzuata uygun belge saklama planlarını hazırlamalı ve bunların EBYS sistemi içerisine entegre edilmesini sağlamalıdır.",
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 171,
                    SiraNo = 71,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 72,
                    StandartID = 1,
                    BaslikNo = "5.2",
                    Baslik = "Belge hiyerarşisi",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 168,
                    SiraNo = 72,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 73,
                    StandartID = 1,
                    BaslikNo = "5.2.1",
                    Baslik = null,
                    Detay = "<div><div>EBYS içerisinde belge hiyerarşisi en üst seviyeden başlayarak asgari aşağıda belirtilen şekilde olmalıdır.</div><div><br></div><ul><li class='ms-hover'>Seviye 1: Belge Fonu, Elektronik belgeyi üreten kuruma ait seviyedir.</li><li class='ms-hover'>Seviye 2: Birim, Kurum içindeki birimleri gösteren seviyedir. Kurum hiyerarşisine bağlı olarak alt birimler oluşturulabilmelidir. </li><li class='ms-hover'>Seviye 3: Belge Serisi, Birimlerin birbiri ile benzerlik gösteren fonksiyonları sonucunda oluşan dosya ve klasörlerin tamamıdır. Fonksiyonların kompleksliğine bağlı olarak bu seviye ile dikey ilişkili alt seriler oluşturulabilir. </li><li class='ms-hover'>Seviye 4: Klasör / Dosya, Konu veya vaka bütünlüğü açısından bir arada bulunması gereken belgeler topluluğudur. Bu seviye ile yatay ilişkili klasör / dosya bölümleri oluşturulabilir. </li><li class='ms-hover'>Seviye 5: Belge, Tek bir işlemi gösteren dokümandır. Bilgisayar literatüründe ‘dosya’ olarak tanımlanır. Bu seviye ile yatay ilişkili olarak belge bileşenleri tanımlanabilir. Belge bileşeni, bir elektronik belgeyi oluşturan çoklu ortam bileşenleri veya bir belgenin ekleri olabilir.</li></ul></div>",
                    UstIcerikID = 72,
                    StandartIcerikTipiID = 171,
                    SiraNo = 73,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 74,
                    StandartID = 1,
                    BaslikNo = "5.3",
                    Baslik = "Saklama kriterleri",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 168,
                    SiraNo = 74,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 75,
                    StandartID = 1,
                    BaslikNo = "5.3.1",
                    Baslik = null,
                    Detay = "<div><div>Elektronik belgelere ait saklama kriterleri diğer belge türleri ile aynıdır. Bunlar:&nbsp;</div><div><b><br></b></div><ul><li class='ms-hover'><b>İdari Kriter:</b> Elektronik belgeler idari açıdan ihtiyaç duyuldukları sürece saklanmalıdır. Bu süre için tanımlanabilecek bir zaman dilimi yoktur. Çünkü bir belgenin idari değeri o belgenin ait olduğu fonksiyonun cari olması ile ilgilidir.&nbsp;<br><br></li><li class='ms-hover'><b>Mali Kriter:</b> Elektronik belgeler iki veya daha fazla taraf arasındaki mali bir işlemi belgeler nitelikte olabilir. Mali değere &nbsp;sahip elektronik belgeler yasal zaman aşımı sürelerince saklanmalıdır.&nbsp;<br><br></li><li class='ms-hover'><b>Hukuki Kriter: </b>Elektronik belgeler iki veya daha fazla taraf arasında akdedilmiş sözleşmeleri belgeler nitelikte olabilir. Ayrıca bir mülkiyetin, hakkın veya alacağın ispatı için kullanılabilecek belgeler bu grupta ele alınmalıdır. Bu tür belgeler, sözleşmeler, haklar ve alacaklar devam ettiği sürece saklanmalıdır.<br><br></li><li class='ms-hover'><b>Tarihi Kriter:</b> Elektronik belgeler ait oldukları kurumun tarihi açısından önemli bilgiler içerebilir. Bu tür belgeler genelde sürekli saklanacak belgeler olarak tanımlanmalıdır.&nbsp;</li></ul></div>",
                    UstIcerikID = 74,
                    StandartIcerikTipiID = 171,
                    SiraNo = 75,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 76,
                    StandartID = 1,
                    BaslikNo = "5.3.2",
                    Baslik = null,
                    Detay = "Elektronik belge yöneticisi EBYS içerisine dahil edilen belgelere bu kriterlerden bir veya birkaçını atayabilmelidir. ",
                    UstIcerikID = 74,
                    StandartIcerikTipiID = 171,
                    SiraNo = 76,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 77,
                    StandartID = 1,
                    BaslikNo = "5.4",
                    Baslik = "Saklama süreleri",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 168,
                    SiraNo = 77,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 78,
                    StandartID = 1,
                    BaslikNo = "5.4.1",
                    Baslik = null,
                    Detay = "Saklama planlarında yer alan elemanlar için belirlenecek süreler bir 10 ay ile 100 yıl arasında değişebilir.",
                    UstIcerikID = 77,
                    StandartIcerikTipiID = 171,
                    SiraNo = 78,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 79,
                    StandartID = 1,
                    BaslikNo = "5.4.2",
                    Baslik = null,
                    Detay = "Elektronik belgelerin saklama süreleri ve tasfiye işlem tanımları seri seviyesinde yapılmalı ve bu seriye bağlı dosya ve lasörler ile bu dosya ve klasörlerdeki belgeler saklama sürelerini ve tasfiye işlem bilgilerini bağlı oldukları serilerden almalıdır.",
                    UstIcerikID = 77,
                    StandartIcerikTipiID = 171,
                    SiraNo = 79,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 80,
                    StandartID = 1,
                    BaslikNo = "5.4.3",
                    Baslik = null,
                    Detay = "<div><div>Saklama süresi, elektronik belge yöneticisi tarafından belirlenecek bir aksiyona göre başlatılır. Sistem, aksiyon başlangıç tarihini ve saklama süresini esas alarak elektronik belge için öngörülen tasfiye tarihini belirlemelidir. Saklama süresine başlangıç teşkil edebilecek aksiyonların bazıları şunlar olabilir:&nbsp;</div><div><br></div><ul><li class='ms-hover'>Elektronik belgenin üretim tarihi</li><li class='ms-hover'>Klasörlerin açılış veya kapanış tarihleri</li><li class='ms-hover'>Klasör içerisine yerleştirilen ilk veya son belgenin üretim &nbsp;tarihleri&nbsp;</li></ul></div>",
                    UstIcerikID = 77,
                    StandartIcerikTipiID = 171,
                    SiraNo = 80,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 81,
                    StandartID = 1,
                    BaslikNo = "5.4.4",
                    Baslik = null,
                    Detay = "Bazı belgeler için birden fazla saklama kriterine göre işlem yapılması gerekebilir. Bu durumda belge ya da dosya için farklı saklama süreleri ve tasfiye işlemi ortaya çıkabilir. Bu tür durumlarda saklama süresi en uzun olan ve belgenin saklanması yönündeki kriter esas alınmalıdır.",
                    UstIcerikID = 77,
                    StandartIcerikTipiID = 171,
                    SiraNo = 81,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 82,
                    StandartID = 1,
                    BaslikNo = "5.4.5",
                    Baslik = null,
                    Detay = "Elektronik belge yöneticisi herhangi bir seri, klasör veya belgeye ait saklama sürelerini ve tasfiye işlem tanımlarını belgeler sistemde olduğu sürece değiştirebilmelidir.",
                    UstIcerikID = 77,
                    StandartIcerikTipiID = 171,
                    SiraNo = 82,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 83,
                    StandartID = 1,
                    BaslikNo = "5.4.6",
                    Baslik = null,
                    Detay = "Saklama planlarında, elektronik belgelere atanan saklama sürelerinde ve tasfiye işlem tanımlarında yapılan her türlü değişiklikler günlük dosyalarında ya da ilgili üstveri tablosunda tutulmalıdır.",
                    UstIcerikID = 77,
                    StandartIcerikTipiID = 171,
                    SiraNo = 83,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 84,
                    StandartID = 1,
                    BaslikNo = "5.5",
                    Baslik = "Tasfiye işlem tanımları",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 168,
                    SiraNo = 84,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 85,
                    StandartID = 1,
                    BaslikNo = "5.5.1",
                    Baslik = null,
                    Detay = "<div><div>EBYS bünyesindeki her eleman için tasfiye işlem tanımları aşağıdaki şekilde olmalıdır.<br><br></div><ul><li class='ms-hover'><b>Sürekli Saklama: </b>Sistem içerisinde tanımlanan herhangi bir elemanın saklama kriterlerinden bir veya birkaçı nedeniyle sürekli saklanacağını ve hiçbir şekilde imha edilmemesi gerektiğini ifade eder. </li><li class='ms-hover'><b>Değerlendirme: </b>Elektronik belgenin ileri bir tarihte değerlendirmeye tabi tutulacağını ve tasfiye kararının bu değerlendirme sonucuna göre alınacağını ifade eder. </li><li class='ms-hover'><b>İmha: </b>Elektronik belgenin saklama süresinin bitiminde imha edileceğini gösterir. </li><li class='ms-hover'><b>Transfer: </b>Elektronik belgenin, üretildiği kurumdaki saklama süresinin bitiminde başka bir kuruma transfer edileceğini gösterir.&nbsp;</li></ul><div>Not: Sürekli saklama seçeneği, elektronik belgenin üretildiği kurumda sürekli saklanacağı durumlar için geçerlidir. Ayrıca transfer yolu ile Devlet Arşivlerinin sorumluluğuna geçen elektronik belgeler de burada sürekli saklanacaktır.</div></div>",
                    UstIcerikID = 84,
                    StandartIcerikTipiID = 171,
                    SiraNo = 85,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 86,
                    StandartID = 1,
                    BaslikNo = "5.5.2",
                    Baslik = null,
                    Detay = "EBYS bünyesindeki elemanlar için tasfiye işlem tanımlarından sadece bir tanesi atanabilmelidir.",
                    UstIcerikID = 84,
                    StandartIcerikTipiID = 171,
                    SiraNo = 86,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 87,
                    StandartID = 1,
                    BaslikNo = "6",
                    Baslik = "Elektronik belgelerin kayıt işlemleri",
                    Detay = null,
                    UstIcerikID = 20,
                    StandartIcerikTipiID = 169,
                    SiraNo = 87,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 88,
                    StandartID = 1,
                    BaslikNo = "6.1",
                    Baslik = "Genel Özellikler",
                    Detay = null,
                    UstIcerikID = 87,
                    StandartIcerikTipiID = 168,
                    SiraNo = 88,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 89,
                    StandartID = 1,
                    BaslikNo = "6.1.1",
                    Baslik = null,
                    Detay = "Kayıt işlemi, elektronik belgelerin EBYS içerisine dâhil edilmesidir. Bu işlem elektronik bir belgeye ait üstverinin kullanıcılar, elektronik belge yöneticisi ve bazen de bilgisayar sistemi tarafından üretilmesini ve ilgili üstveri tablosuna kaydedilmesini içerir. Üstveri gereksinimleri ve tanımları için Üstveri Elemanları Bölümüne bakılmalıdır.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 89,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }

                },
                new StandartIcerik
                {
                    StandartIcerikID = 90,
                    StandartID = 1,
                    BaslikNo = "6.1.2",
                    Baslik = null,
                    Detay = "Elektronik belgeler kurumsal fonksiyonların yerine getirilmesi sırasında üretilir veya alınırlar. Kurum içinde üretilenler yanında kurum dışı kaynaklardan da belge akışı söz konusudur. Bu belgeler farklı kişi ve kurumlar tarafından üretilmiş farklı formatlarda olabilirler. Belgeler tek ünite şeklinde olabileceği gibi belge grupları şeklinde de olabilirler. Yerel veya geniş alan ağları, elektronik posta veya faks gibi elektronik araçlarla iletilebildikleri gibi sayısallaştırma yöntemiyle de elektronik ortama aktarılmış olabilirler.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 90,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 91,
                    StandartID = 1,
                    BaslikNo = "6.1.3",
                    Baslik = null,
                    Detay = "<div><div>EBYS; elektronik belgelerin sisteme kayıt işlemleri ile ilgili olarak aşağıdaki özelliklere sahip olmalıdır.&nbsp;<br><br></div><ul><li class='ms-hover'>Elektronik belgeleri dosya tasnif ve saklama planları ile ve bir ya da birden fazla klasörle ilişkilendirme,&nbsp;</li><li>Elektronik belgeye ait üstverilerin kontrol ve kayıt işlemlerini gerçekleştirebilme.</li></ul></div>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 91,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 92,
                    StandartID = 1,
                    BaslikNo = "6.1.4",
                    Baslik = null,
                    Detay = "<div><div>EBYS, elektronik belgenin üretim ve kullanım ortamı ile ilgili olarak;<br></div><ul><br><li class='ms-hover'>Elektronik belgenin içeriği,</li><li class='ms-hover'>Elektronik belgenin form, format, sunum ve yapısal özelliklerini,</li><li class='ms-hover'>Elektronik belgenin ekleri ve / veya bileşenlerini,</li><li class='ms-hover'>Dosya adı, üretim tarihi, üreticisi gibi üstveri bilgilerini, </li><li class='ms-hover'>Elektronik belgenin üretildiği uygulama programına ait ad ve versiyon bilgilerini kayıt altına alabilmelidir.&nbsp;</li></ul></div>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 92,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 93,
                    StandartID = 1,
                    BaslikNo = "6.1.5",
                    Baslik = null,
                    Detay = "EBYS, elektronik belge ve bu belge ile ilişkilendirilmiş üstverileri birlikte korumalı; belge ile üstverilerin ilişkisinin koparılmasına izin vermemelidir.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 93,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 94,
                    StandartID = 1,
                    BaslikNo = "6.1.6",
                    Baslik = null,
                    Detay = "Herhangi bir elektronik belgeye ait üstveriler üzerinde değişiklik yapma işlemi yalnızca yetkili belge yöneticisi tarafından yapılabilmelidir. Üstveri üzerinde yapılan her türlü değişiklik kayıt altına alınmalıdır.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 94,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 95,
                    StandartID = 1,
                    BaslikNo = "6.1.7",
                    Baslik = null,
                    Detay = "Herhangi bir elektronik belge fiziksel olarak çoğaltılmadan birden fazla klasör ile ilişkilendirilebilmelidir.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 95,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 96,
                    StandartID = 1,
                    BaslikNo = "6.1.8",
                    Baslik = null,
                    Detay = "EBYS içerisine kayıt edilmiş her belgeye ait görüntülenebilir ve izlenebilir bir üstveri bilgisi olmalıdır. Elektronik belgeye ait üstveri bilgilerinden sistem tarafından otomatik olarak alınmayanlar kullanıcı, elektronik belge yöneticisi veya sistem yöneticisi tarafından tamamlanabilmelidir.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 96,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 97,
                    StandartID = 1,
                    BaslikNo = "6.1.9",
                    Baslik = null,
                    Detay = "Elektronik belgeye ait üstveriler, kayıt esnasında ya da daha sonra girilebilmelidir.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 97,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 98,
                    StandartID = 1,
                    BaslikNo = "6.1.10",
                    Baslik = null,
                    Detay = "<div>EBYS, elektronik belgelerin dosya tasnif planı ile ilişkilendirilmesi için kullanıcıyı yönlendirici özelliklere sahip olmalıdır. Bu bağlamda</div><div>EBYS,&nbsp;</div><div><br></div><ul><li class='ms-hover'>Sadece söz konusu kullanıcının kullanabileceği bir dosya planı başlıklarından oluşan bir setin hazırlanabilmesine imkân tanımalıdır.</li><li class='ms-hover'>Kullanıcının en son kullandığı klasörlerin listesi tutulmalı ve yeni kayıt yapılacağı zaman bu listeden seçim yapmaya imkân tanınmalıdır. </li><li class='ms-hover'>Kullanıcının görev alanı ile ilgili ikinci dereceden klasörler listelenebilmelidir.</li></ul>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 98,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 99,
                    StandartID = 1,
                    BaslikNo = "6.1.11",
                    Baslik = null,
                    Detay = "<div>EBYS, elektronik belgelerin dosya tasnif planı ile ilişkilendirilmesi için kullanıcıyı yönlendirici özelliklere sahip olmalıdır. Bu bağlamda</div><div>EBYS,&nbsp;</div><div><br></div><ul><li class='ms-hover'>Sadece söz konusu kullanıcının kullanabileceği bir dosya planı başlıklarından oluşan bir setin hazırlanabilmesine imkân tanımalıdır.</li><li class='ms-hover'>Kullanıcının en son kullandığı klasörlerin listesi tutulmalı ve yeni kayıt yapılacağı zaman bu listeden seçim yapmaya imkân tanınmalıdır. </li><li class='ms-hover'>Kullanıcının görev alanı ile ilgili ikinci dereceden klasörler listelenebilmelidir.</li></ul>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 99,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 100,
                    StandartID = 1,
                    BaslikNo = "6.1.12",
                    Baslik = null,
                    Detay = "<div>Birden fazla parçadan oluşan elektronik belgeler,<br><br></div><ul><li class='ms-hover'>Parçalar arasındaki ilişkiler korunarak tek bir belge şeklinde sisteme kayıt edilebilmelidir.</li><li>Belgenin yapısal özellikleri korunmalıdır.</li><li>Belgenin yeniden erişimi tüm parçalar aralarındaki ilişkiler korunarak gerçekleşmelidir.</li><li>Tasfiye aşamasında tüm parçalar tek bir ünite olarak işlem görmelidir.</li></ul><div>Not: Bu tür belgelere örnek olarak web sayfaları ve içerisinde grafik</div><div>barındıran dokümanlar gösterilebilir.&nbsp;</div>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 100,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 101,
                    StandartID = 1,
                    BaslikNo = "6.1.13",
                    Baslik = null,
                    Detay = "<div>EBYS, elektronik belgelere ait üstveri bilgilerini mümkün olduğu ölçüde otomatik olarak alabilmelidir.</div><div><br></div><div>Not: Burada amaçlanan üstveri dosyasına alınacak bilgilerin doğruluğunu ve tutarlılığını sağlamaktır. Ayrıca veri girişinde kolay ve verimli bir yöntem olması açısından da otomatik veri girişi tercih edilmelidir. Ancak herhangi bir elektronik belge ile ilgili olarak otomatik olarak alınabilecek veri miktarı uygulama programına göre değişebilir.</div>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 101,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 102,
                    StandartID = 1,
                    BaslikNo = "6.1.14",
                    Baslik = null,
                    Detay = "Elektronik belgenin EBYS içerisine kayıt işlemine ait tarih ve zaman üstveri dosyasında tutulmalıdır.",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 102,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 103,
                    StandartID = 1,
                    BaslikNo = "6.1.15",
                    Baslik = null,
                    Detay = "<div>BYS, elektronik ortamda üretilen dokümanlara toplu olarak belge statüsü kazandırarak, sisteme dâhil edilmesine imkân tanımalıdır</div><div><br></div><div>Not: Bu fonksiyon özellikle rutin olarak sisteme aktarılması gereken dokümanlar içindir. Örneğin gün sonunda kesilmiş olan  üm faturaların toplu halde sisteme aktarılması kullanım açısından kolaylık sağlayacaktır. Bu kapsamda işlem görecek olan belgelerin evrak sayısı alması ve dosya tasnif planı kapsamında dosyalanması otomatik olarak gerçekleştirilmelidir.</div>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 103,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 104,
                    StandartID = 1,
                    BaslikNo = "6.1.16",
                    Baslik = null,
                    Detay = "<div>EBYS, toplu transfer işlemini gerçekleştirirken;<br><br></div><ul><li class='ms-hover'>Önceden tanımlanmış toplu işlem prosedürlerini desteklemeli,</li><li class='ms-hover'>Otomatik toplu transfer işlemi prosedürlerinin kullanıcı tarafından tanımlanabilmesine ve mevcut prosedürlerin değiştirilebilmesine olanak sağlamalı, </li><li class='ms-hover'>Bir toplu işlem süreci içerisinde sisteme aktarılan belgelerin nicelik, nitelik ve bütünlük kontrollerinin yapılabilmesine imkan tanımalıdır.&nbsp;</li></ul>",
                    UstIcerikID = 88,
                    StandartIcerikTipiID = 171,
                    SiraNo = 104,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 105,
                    StandartID = 1,
                    BaslikNo = "6.2",
                    Baslik = "Dokümanların belgeye dönüştürülmesi ve ilişkilendirme",
                    Detay = null,
                    UstIcerikID = 87,
                    StandartIcerikTipiID = 168,
                    SiraNo = 105,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 106,
                    StandartID = 1,
                    BaslikNo = "6.2.1",
                    Baslik = null,
                    Detay = "EBYS, kurum tarafından üretilen ya da kurumsal faaliyetler sırasında başka kurum veya şahıslardan alınan elektronik dokümanların ‘kurumsal resmi belgeler’ olarak işaretlenmesine imkan tanımalıdır.Bu süreç yetkili personel (kullanıcı veya yönetici) tarafından yapılmalı ve işleme ait üstveriler kayıt altına alınmalıdır.",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 106,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 107,
                    StandartID = 1,
                    BaslikNo = "6.2.2",
                    Baslik = null,
                    Detay = "Elektronik belge olarak işaretlenen dokümanlar dosya tasnif planında belirlenen kurallar çerçevesinde en az bir klasör ile ilişkilendirilmelidir.",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 107,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 108,
                    StandartID = 1,
                    BaslikNo = "6.2.3",
                    Baslik = null,
                    Detay = "Elektronik belge olarak tanımlanan dokümanlar üzerinde kullanıcı ve yöneticiler de dâhil olmak üzere herhangi bir değişiklik yapılmasına izin verilmemelidir.",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 108,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 109,
                    StandartID = 1,
                    BaslikNo = "6.2.4",
                    Baslik = null,
                    Detay = "<div>EBYS, elektronik belge olarak tanımlanmış dokümanların aşağıdaki istisnalar dışında imhasına izin vermemelidir.</div><div><br></div><ul><li class='ms-hover'>Elektronik belgeler ancak saklama planlarında gösterilen zaman aşımı süreleri dolduğunda imha edilebilir.</li><li class='ms-hover'><li class='ms-hover'>Elektronik belgeler bir yanlış işlemin düzeltilmesi amacıyla EBYS dışına çıkarılabilir. &nbsp;Ancak bu işleme ait üstveriler kayıt altına alınmalıdır</li></li></ul>",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 109,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 110,
                    StandartID = 1,
                    BaslikNo = "6.2.5",
                    Baslik = null,
                    Detay = "<div>EBYS içerisine dâhil edilen elektronik belgelerin ad ve konuları gerektiğinde kullanıcı veya sistem yöneticisi tarafından değiştirilebilmelidir.</div><div><br></div><div>Not: Bu fonksiyon özellikle dosya adlarının ve elektronik posta mesajlarının konu hanelerinin anlamlı ve içeriği yansıtır nitelikte olması açısından önemlidir. Ancak bu işlemin dosya adları ve konu haneleri ile sınırlı kalması gerekir. Elektronik dokümanlarıni çeriğine herhangi bir müdahalenin yapılması önlenmelidir</div>",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 110,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 111,
                    StandartID = 1,
                    BaslikNo = "6.2.6",
                    Baslik = null,
                    Detay = "Elektronik dokümanların gönderen, alıcı, gönderilme ve alınma tarih ve saatleri gibi iletişim bilgileri otomatik olarak alınmalı ve bunlar üzerinde herhangi bir değişikliğe izin verilmemelidir. Bu veriler ayrıca, uygun olduğu durumlarda, elektronik imza ile de güvence altına alınmalıdır.",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 111,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 112,
                    StandartID = 1,
                    BaslikNo = "6.2.7",
                    Baslik = null,
                    Detay = "EBYS içerisine alınan elektronik belgeler gerekli olduğu durumlarda birden fazla klasörle ilişkilendirilebilmelidir.",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 112,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 113,
                    StandartID = 1,
                    BaslikNo = "6.2.8",
                    Baslik = null,
                    Detay = "İlişkilendirme işleminde kullanılacak referansların her zaman doğru belgeyi bulması sağlanmalıdır. Belgenin yeri değişmesi durumunda ilişkilendirme referansları otomatik olarak güncellenmelidir.",
                    UstIcerikID = 105,
                    StandartIcerikTipiID = 171,
                    SiraNo = 113,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 114,
                    StandartID = 1,
                    BaslikNo = "6.3",
                    Baslik = "Belge türleri",
                    Detay = null,
                    UstIcerikID = 87,
                    StandartIcerikTipiID = 168,
                    SiraNo = 114,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 115,
                    StandartID = 1,
                    BaslikNo = "6.3.1",
                    Baslik = null,
                    Detay = "<div style='text-align: justify; '>EBYS, 2009/4 Sayılı Başbakanlık Genelgesi ile yayınlanan Birlikte Çalışabilirlik Esasları dokümanında tanımlanan dosya formatlarındaki elektronik belgeleri sisteme entegre edebilme özelliğine sahip olmalıdır.</div><div style='text-align: justify; '><br></div><div style='text-align: justify; '>Not: Kurumlar yapıları ve fonksiyonları gereği çok farklı ortamlarda elektronik belge üretebilirler. Elektronik belgelerin yapısal özellikleri ve formatlarındaki farklılıklar bu belgelerin EBYS içerisinde temsil edilmelerinde standard bir tekniğin uygulanmasını imkânsız hale getirebilir. Bu nedenle EBYS, aşağıda tanımlanan yaygın elektronik belge türlerinin sistem içerisine alınmasına imkân sağlayacak teknik alt yapıya sahip olmalıdır. Yeni geliştirilen dosya yapıları ve formatları için de genişleyebilir ve güncellenebil ir bir yapının oluşturulması gereklidir.</div><div style='text-align: justify; '><br></div><div style='text-align: justify; '>Ayrıca, kurumlar faaliyetleri sırasında kendi ürettikleri belgelerin yanı sıra diğer kurumlardan ya da gerçek kişilerden gelen belgeleri de sistemlerine dâhil etmek durumundadırlar. Bu belgelerin bazılarının üretilmiş oldukları uygulama programları dahi kendi kurumda bulunmayabilir. EBYS kurum dışında üretilmiş elektronik belgeleri de sisteme entegre etmek için gerekli teknik altyapıya da sahip olmalıdır&nbsp;</div>",
                    UstIcerikID = 114,
                    StandartIcerikTipiID = 171,
                    SiraNo = 115,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 116,
                    StandartID = 1,
                    BaslikNo = "6.3.2",
                    Baslik = null,
                    Detay = "<div style='text-align: justify; '><div>EBYS, otomatik olarak kendisini güncelleyen elektronik dokümanların sisteme dâhil edilmesinde ve sonraki kullanımında içeriğinin korunmasına özen göstermelidir. Belge statüsü kazanmış dokümanların içeriğinin her ne sebeple olursa olsun değişmesi ya da değiştirilmesi önlenmelidir.</div><div><br></div><div>Not: Dokümanlar üzerindeki bazı bilgilerin otomatik olarak güncellenmesi birkaç farklı şekilde karşımıza çıkabilir. Bunlardan en yaygın olarak bilinenlerinden bir tanesi dokümanlar üzerindeki tarih alanlarıdır. Bazı dokümanlar üzerindeki tarih bilgisi kod olarak girilmekte ve dokümanın her açılışında bu bilgi bilgisayar sisteminin tarih bilgisi esas alınarak güncellenmektedir.</div><div><br></div><div>Bir diğer durum ise özellikle birden fazla uygulama parçalarının bir araya getirilmesiyle üretilen tümleşik dokümanlar için geçerlidir. Bir kelime işlem dosyası içerisine gömülmüş olan bir tablo, üretildiği uygulama üzerinde değiştirildiğinde tümleşik doküman üzerindeki bilgiler de otomatik olarak güncellenebilmektedir.</div><div><div><br></div><div>Tablolama ve çeşitli analiz programlarında kullanıcı tarafından tanımlanan makrolar çalıştırıldığında ise doküman üzerindeki bazı bilgiler değişebilmektedir.&nbsp;</div><div><br></div><div>Bunlar, mevcut teknolojiler çerçevesinde, elektronik dokümanın belgeye dönüştürülmesi ve kullanılması sırasında içeriğinin değişmesine sebep olabilecek durumlardan bazılarıdır. Şüphesiz sürekli değişen ve gelişen bilişim teknolojileri bu alanda elektronik belge yönetimi için yeni sorunlar doğuracaktır.&nbsp;</div><div><br></div><div>EBYS, bu tür dokümanların değişimine sebep olan kodların veya makroların devre dışı bırakılmasını veya bu tür dokümanların sisteme aktarılırken içeriğinin değişmesini önleyici bir formata (örneğin PDF veya TIFF formatı gibi) dönüştürülmesini sağlamalıdır.&nbsp;</div></div></div>",
                    UstIcerikID = 114,
                    StandartIcerikTipiID = 171,
                    SiraNo = 116,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 117,
                    StandartID = 1,
                    BaslikNo = "6.3.3",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>EBYS, tümleşik dokümanları tek bir belge olarak sisteme entegre edebildiği gibi, tümleşik dokümanı oluşturan parçaların ayrı ayrı da kayıt edilmesine imkan tanımalıdır.</p><p><div style='text-align: justify;'>Not: Elektronik belgeler temelde iki kategoride değerlendirilebilir.</div><div style='text-align: justify;'>Bunlar:</div></p><ul><li class='ms-hover' style='text-align: justify; '><b>Basit dokümanlar: </b>Tek bir uygulama yazılımı ile üretilmiş olan dokümanlardır. Ofis programları üzerinde üretilmiş dokümanlar, elektronik postalar, sunum, metin, resim ve ses dosyaları bu tür dokümanlara örnek olarak gösterilebilir. </li><li class='ms-hover' style='text-align: justify; '><b>Tümleşik dokümanlar: </b>Birden fazla uygulamanın parçalarının tek bir doküman üzerinde birleştirilmesi ile oluşturulan belgelerdir. Bunlara örnek olarak web sayfaları, ekleri bulunan elektronik postalar, bazı grafikler ve masa üstü yayıncılık uygulamaları ile üretilen dokümanlar gösterilebilir.&nbsp;</li></ul>",
                    UstIcerikID = 114,
                    StandartIcerikTipiID = 171,
                    SiraNo = 117,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 118,
                    StandartID = 1,
                    BaslikNo = "6.4",
                    Baslik = "Elektronik postaların yönetimi",
                    Detay = null,
                    UstIcerikID = 87,
                    StandartIcerikTipiID = 168,
                    SiraNo = 118,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 119,
                    StandartID = 1,
                    BaslikNo = "6.4.1",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>EBYS, elektronik postaların sisteme alınması işlemini iki farklı metotla gerçekleştirebilmelidir. Elektronik belge yöneticisi bu metotlardan kendi kurumu için uygun olanı sistem kurulum aşamasında seçebilmelidir. Bu metotlar hem e-postaların gönderilmesinde hem de e-postaların sisteme alınmasında kullanılabilmelidir. </p><ul><li style='text-align: justify;' class='ms-hover'>E-Postaların otomatik olarak sisteme alınmasını,</li><li style='text-align: justify;' class='ms-hover'>Bir e-postanın belirli bir prosedür sonunda sisteme otomatik olarak alınmasını,</li><li style='text-align: justify;' class='ms-hover'>Kullanıcının seçtiği e-postaların sisteme alınmasını desteklemelidir.</li></ul>",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 119,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 120,
                    StandartID = 1,
                    BaslikNo = "6.4.2",
                    Baslik = null,
                    Detay = "Elektronik postalara ait iletişim üstverileri (gönderen, alıcı, gönderilme tarihi gibi) EBYS içerisine kısaltma ya da rumuz kullanılmadan açık bir şekilde alınmalı elektronik posta belgesi ile ilişkilendirilebilmelidir.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 120,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 121,
                    StandartID = 1,
                    BaslikNo = "6.4.3",
                    Baslik = null,
                    Detay = "Kullanıcılar bir e-postayı alt klasöre, klasöre ekleyebilmelidirler.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 121,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 122,
                    StandartID = 1,
                    BaslikNo = "6.4.4",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>Alınan e-postalar sisteme kayıt edilirken EBYS kayıt etme ile ilgili bazı seçenekler sunmalıdır. </p><ul><li style='text-align: justify;' class='ms-hover'>E-posta mesajını sisteme kayıt etmesi</li><li style='text-align: justify;' class='ms-hover'>E-posta mesajı ile birlikte ekleri tek bir belge olarak sisteme kayıt etmesi</li><li style='text-align: justify;' class='ms-hover'>Gelen e-postanın eklerinde bulunan sadece dokümanı/belgeyi sisteme kaydetmek.</li></ul>",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 122,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 123,
                    StandartID = 1,
                    BaslikNo = "6.4.5",
                    Baslik = null,
                    Detay = "Gelen e-postanın metninin önemsiz olduğu durumlarda ya da sadece e-postanın ekinin önemli olduğu durumlarda gelen e-postanın eki mesajdan arındırılarak sisteme kaydedilebilmelidir.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 123,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 124,
                    StandartID = 1,
                    BaslikNo = "6.4.6",
                    Baslik = null,
                    Detay = "BYS kullanıcıların e-posta mesajlarının başlıklarını düzenleyerek sisteme almasına izin vermelidir.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 124,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 125,
                    StandartID = 1,
                    BaslikNo = "6.4.7",
                    Baslik = null,
                    Detay = "EBYS kullanıcılara e-postaların gönderilme ve alınma tarihlerinin otomatik olanak tanımalıdır.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 125,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 126,
                    StandartID = 1,
                    BaslikNo = "6.4.8",
                    Baslik = null,
                    Detay = "EBYS, e-postaların sisteme toplu olarak alınmasını, kaydedilmesine olanak vermelidir.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 126,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 127,
                    StandartID = 1,
                    BaslikNo = "6.4.9",
                    Baslik = null,
                    Detay = "EBYS e-postaların sisteme otomatik olarak alınmasına ve bir epostanın bir klasörle, alt klasörle ya da kişi ile ilişkilendirilmesine olanak tanımalıdır.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 127,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 128,
                    StandartID = 1,
                    BaslikNo = "6.4.10",
                    Baslik = null,
                    Detay = "EBYS içerisine alınan e-postaların erişilebilir bir formatta olmasına, yaygın kullanılan formatların kullanılmasına dikkat edilmesi gerekir.",
                    UstIcerikID = 118,
                    StandartIcerikTipiID = 171,
                    SiraNo = 128,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 129,
                    StandartID = 1,
                    BaslikNo = "6.5",
                    Baslik = "Taşıma, kopyalama ve silme",
                    Detay = null,
                    UstIcerikID = 87,
                    StandartIcerikTipiID = 168,
                    SiraNo = 129,
                    DurumID = 1,
                },
                new StandartIcerik
                {
                    StandartIcerikID = 130,
                    StandartID = 1,
                    BaslikNo = "6.5.1",
                    Baslik = null,
                    Detay = "EBYS, elektronik belgelerin ilişkilendirildikleri klasörlerden alınarak başka bir klasörle ilişkilendirilmelerine imkân tanımalıdır. Yeniden dosyalama olarak da adlandırılan bu işlem yalnızca yetkili kullanıcılar tarafından yapılabilmelidir.",
                    UstIcerikID = 129,
                    StandartIcerikTipiID = 171,
                    SiraNo = 130,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 131,
                    StandartID = 1,
                    BaslikNo = "6.5.2",
                    Baslik = null,
                    Detay = "EBYS, mevcut bir elektronik belgenin kopyalanarak yeni bir belge oluşturulmasına veya farklı amaçlarla kullanılmasına imkân tanımalıdır. Ancak bu işlem gerçekleştirilirken mevcut belgeye ait içerik ve üstveri bilgilerinin korunması sağlanmalıdır.",
                    UstIcerikID = 129,
                    StandartIcerikTipiID = 171,
                    SiraNo = 131,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 132,
                    StandartID = 1,
                    BaslikNo = "6.5.3",
                    Baslik = null,
                    Detay = "EBYS, mevcut bir elektronik belgenin tamamı ya da bir bölümü kopyalanarak oluşturulan yeni elektronik belgeler arasında ilişki kurabilmelidir. Aynı kaynaktan üretilmiş tüm elektronik belgeler kullanıcıya aynı anda gösterilebilmelidir.",
                    UstIcerikID = 129,
                    StandartIcerikTipiID = 171,
                    SiraNo = 132,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 133,
                    StandartID = 1,
                    BaslikNo = "6.5.4",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>Mevcut bir elektronik belge kopyalandığında, bu belgeye ait üstveri bilgileri de kopyalanmalı ve kullanıcının veriler üzerinde değişiklik yapabilmesine olanak sağlanmalıdır.&nbsp;</p><p style='text-align: justify; '>Not: Kopyalanan elektronik belgeye ait gizlilik statüsü ve erişim hakları kopyalanan elektronik belge için de geçerli olmalıdır. Teknik olarak bir kullanıcının herhangi bir belgeyi kopyalayabilmesi ancak o belgeye erişim hakkı olduğu takdirde gerçekleşebilmelidir. Kopyalanan bir belgedeki gizlilikle ilgili bölümlerin çıkartılarak gizli olmayan bir belge üretmekte mümkündür. Bu nedenle kullanıcının kopyalanan belgeye ait erişim hakları ile ilgili üstveri bilgilerini de değiştirebilmesi gerekir. Ancak bunun da bazı güvenlik sorunları doğurması mümkündür. Burada kullanıcıların bu tür belgelerin kopyalanması noktasında uyarılması ve eğitilmesi gerekir. Ayrıca yapılan işlemlerin de üstveri dosyasında kayıt altına alınması gerekir.&nbsp;</p>",
                    UstIcerikID = 129,
                    StandartIcerikTipiID = 171,
                    SiraNo = 133,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 134,
                    StandartID = 1,
                    BaslikNo = "6.6",
                    Baslik = "Referans kodlarının verilmesi",
                    Detay = null,
                    UstIcerikID = 87,
                    StandartIcerikTipiID = 168,
                    SiraNo = 134,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 135,
                    StandartID = 1,
                    BaslikNo = "6.6.1",
                    Baslik = null,
                    Detay = "EBYS, içerisinde yer alan her bir elemana eşsiz bir referans kodu verilmelidir. Referans kodları tüm EBYS içerisinde eşsiz olabileceği gibi sadece sistemdeki her bir hiyerarşik seviye içinde de eşsiz olabilir.",
                    UstIcerikID = 134,
                    StandartIcerikTipiID = 171,
                    SiraNo = 135,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 136,
                    StandartID = 1,
                    BaslikNo = "6.6.2",
                    Baslik = null,
                    Detay = "Referans kodlarının formatı elektronik belge yöneticisi tarafından belirlenmeli ve bu format sistem kurulum aşamasında tanımlanabilmelidir. Referans kodları nümerik, alfabetik veya alfanümerik olabilir.",
                    UstIcerikID = 134,
                    StandartIcerikTipiID = 171,
                    SiraNo = 136,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 137,
                    StandartID = 1,
                    BaslikNo = "6.6.3",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>Referans kodlarının eşsiz olabilmesi için;</p><ul><li style='text-align: justify;' class='ms-hover'>Sistem tarafından otomatik olarak verilmesi sağlanabilir,</li><li style='text-align: justify;' class='ms-hover'>Kullanıcı tarafından verilen referans kodları sistem tarafından eşsizlik kontrolünden geçirilebilir,</li><li style='text-align: justify;' class='ms-hover'>Kullanıcı tarafından verilen referans kodu ilgili elemanın üstveri dosyasında anahtar kelime olarak tutulur ve buna ilaveten sistem tarafından eşsiz bir referans kodu tanımlanabilir.</li></ul>",
                    UstIcerikID = 134,
                    StandartIcerikTipiID = 171,
                    SiraNo = 137,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 138,
                    StandartID = 1,
                    BaslikNo = "7",
                    Baslik = "Elektronik Belgelerin Paylaşımı",
                    Detay = null,
                    UstIcerikID = 20,
                    StandartIcerikTipiID = 169,
                    SiraNo = 138,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 139,
                    StandartID = 1,
                    BaslikNo = "7.1",
                    Baslik = "Kurum Kodlarının Kullanılması",
                    Detay = null,
                    UstIcerikID = 138,
                    StandartIcerikTipiID = 168,
                    SiraNo = 139,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 140,
                    StandartID = 1,
                    BaslikNo = "7.1.1",
                    Baslik = null,
                    Detay = "Elektronik belgelerin üretim ve transfer işlemlerine esas olmak üzere, belgeyi üreten kamu kurumu / birimi kimliği ile muhatap kurumun /birimin kimliği DETSİS veri tabanında tanımlanan kodlardan oluşmalıdır.",
                    UstIcerikID = 139,
                    StandartIcerikTipiID = 171,
                    SiraNo = 140,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 141,
                    StandartID = 1,
                    BaslikNo = "7.1.2",
                    Baslik = null,
                    Detay = "EBY sistemi, belge üreten ya da belgenin muhatabı kamu kurumlarının haberleşme kodlarını DETSİS veri tabanından otomatik olarak alabilmelidir. Kamu kurumları dışında faaliyet gösteren EBY sistemleri de DETSİS veri tabanından bilgi alabilecek servisleri bünyesinde barındırmalıdır.",
                    UstIcerikID = 139,
                    StandartIcerikTipiID = 171,
                    SiraNo = 141,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 142,
                    StandartID = 1,
                    BaslikNo = "7.1.3",
                    Baslik = null,
                    Detay = "Kamu kurumları hiyerarşik yapılarına uygun olarak DETSİS veri tabanının güncel tutulmasından sorumludur. ",
                    UstIcerikID = 139,
                    StandartIcerikTipiID = 171,
                    SiraNo = 142,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 143,
                    StandartID = 1,
                    BaslikNo = "7.1.4",
                    Baslik = null,
                    Detay = "EBYS sistemi, şahıslar ile yapılan yazışmalarda muhataba ait kimlik ve adres bilgilerinin Kimlik Paylaşım Sistemi (KPS) ve Ulusal Adres Paylaşım Sistemi (UAPS) üzerinden kontrol edilmesine ve yazışmalarda kullanılmasına imkân sağlamalıdır.",
                    UstIcerikID = 139,
                    StandartIcerikTipiID = 171,
                    SiraNo = 143,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 144,
                    StandartID = 1,
                    BaslikNo = "7.1.5",
                    Baslik = null,
                    Detay = "Kamu kurumları, EBYS sistemlerinin KPS ve UAPS ile haberleşebilmesi için gerekli işlemleri yapmalıdır",
                    UstIcerikID = 139,
                    StandartIcerikTipiID = 171,
                    SiraNo = 144,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 145,
                    StandartID = 1,
                    BaslikNo = "7.1.6",
                    Baslik = null,
                    Detay = "EBYS sistemi, tüzel kuruluşlarla yapılan yazışmalarda, mümkün olduğu ölçüde, Merkezi Tüzel Kişilik Bilgi Sistemi (MTK) tarafından kullanılan ‘kurum sicil numaralarını’ haberleşme kodu olarak kullanmalıdır. MTK işlevsel hale gelene kadar özel şirketler için MERSİS, vakıf kurumları için Vakıf Bilgi Yönetim Sistemi (VBYS) ve dernekler için de Dernekler Bilgi Sistemi (DERBİS) tarafından kullanılan kurum kodları kullanılmalıdır.",
                    UstIcerikID = 139,
                    StandartIcerikTipiID = 171,
                    SiraNo = 145,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 146,
                    StandartID = 1,
                    BaslikNo = "7.1.7",
                    Baslik = null,
                    Detay = "Kamu kurumları, EBYS sistemlerinin MTK, VBYS ve DERBİS sistemleri ile haberleşebilmesi için gerekli işlemleri yapmalıdır. ",
                    UstIcerikID = 139,
                    StandartIcerikTipiID = 171,
                    SiraNo = 146,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 147,
                    StandartID = 1,
                    BaslikNo = "7.2",
                    Baslik = "Kayıtlı Elektronik Posta (KEP)",
                    Detay = null,
                    UstIcerikID = 138,
                    StandartIcerikTipiID = 168,
                    SiraNo = 147,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 148,
                    StandartID = 1,
                    BaslikNo = "7.2.1",
                    Baslik = null,
                    Detay = "Elektronik ortamda üretilmiş ve elektronik / mobil imza sistemleri ile onaylanmış belgeler ile bu belgelere ek olarak tanımlanmış her türlü dokümanı alıcı kurumlara veya kişilere iletimi Kayıtlı Elektronik Posta (KEP) sistemi üzerinden yapılabilmelidir. ",
                    UstIcerikID = 147,
                    StandartIcerikTipiID = 171,
                    SiraNo = 148,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 149,
                    StandartID = 1,
                    BaslikNo = "7.2.2",
                    Baslik = null,
                    Detay = "EBYS sistemi, kurumun belge paylaşımını yapabileceği kişi veya kurumların iletişim bilgilerini bünyesinde barındırabilmeli ve bunları iş akışı süreçlerine dâhil edebilmelidir. Kişi veya kurumlara ait KEP adreslerine ait bilgiler 16.05.2012 tarih ve 28294 sayılı Resmi Gazetede yayınlanan ‘Kayıtlı Elektronik Posta Rehberi ve Kayıtlı Elektronik Posta Hesabı Adreslerine İlişkin Tebliğ’in 5. Maddesinde belirlenen esaslara göre olmalıdır. ",
                    UstIcerikID = 147,
                    StandartIcerikTipiID = 171,
                    SiraNo = 149,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 150,
                    StandartID = 1,
                    BaslikNo = "7.2.3",
                    Baslik = null,
                    Detay = "EBYS sistemi, KEP sistemi üzerinden belge gönderirken standart bir üstveri setini belge ile birlikte göndermelidir. Aynı şekilde kendisine gönderilen elektronik belgelerini standart üstveri setini sisteme dahil edebilmelidir.",
                    UstIcerikID = 147,
                    StandartIcerikTipiID = 171,
                    SiraNo = 150,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 151,
                    StandartID = 1,
                    BaslikNo = "7.2.4",
                    Baslik = null,
                    Detay = "BYS sistemi, KEP sistemi üzerinden göndereceği belgeleri Elektronik Yazışma Paketi (EYP) formatına uygun şekilde göndermelidir.",
                    UstIcerikID = 147,
                    StandartIcerikTipiID = 171,
                    SiraNo = 151,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 152,
                    StandartID = 1,
                    BaslikNo = "7.2.5",
                    Baslik = null,
                    Detay = "Sistem üzerinden gönderilen belgeler üstveri seti bir EBYS yazılımına ihtiyaç duymadan da okunabilir formatta olmalıdır. ",
                    UstIcerikID = 147,
                    StandartIcerikTipiID = 171,
                    SiraNo = 152,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 153,
                    StandartID = 1,
                    BaslikNo = "7.2.6",
                    Baslik = null,
                    Detay = "Kurumlara gönderilecek olan belgelerin üstveri seti bu standart sertifikasına sahip yazılımlar arasında herhangi bir ilave işleme tabi olmadan sisteme kayıt olarak girebilmelidir.",
                    UstIcerikID = 147,
                    StandartIcerikTipiID = 171,
                    SiraNo = 153,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 154,
                    StandartID = 1,
                    BaslikNo = "7.2.7",
                    Baslik = null,
                    Detay = "Elektronik belgelere ek olarak gönderilen dokümanlar ‘Birlikte Çalışabilirlik Esaslarındaki doküman formatlarına uygun olmalıdır.",
                    UstIcerikID = 147,
                    StandartIcerikTipiID = 171,
                    SiraNo = 154,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 155,
                    StandartID = 1,
                    BaslikNo = "7.3",
                    Baslik = "Elektronik Yazışma Paketi",
                    Detay = null,
                    UstIcerikID = 138,
                    StandartIcerikTipiID = 168,
                    SiraNo = 155,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 156,
                    StandartID = 1,
                    BaslikNo = "7.3.1",
                    Baslik = null,
                    Detay = "EBYS sistemi, kurumlar arası belge paylaşımını sağlamak amacıyla sistemdeki herhangi bir belgeyi ilgili üstveri seti ile birlikte Elektronik Yazışma Paketi (EYP) kurallarına uygun olarak gönderebilmeli ve alabilmelidir.",
                    UstIcerikID = 155,
                    StandartIcerikTipiID = 171,
                    SiraNo = 156,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 157,
                    StandartID = 1,
                    BaslikNo = "7.3.2",
                    Baslik = null,
                    Detay = "EYP formatı Kalkınma Bakanlığı Bilgi Toplumu Dairesi Başkanlığı tarafından hazırlanan e-Yazışma Teknik Rehberinde belirtilen esaslara uygun olmalıdır.",
                    UstIcerikID = 155,
                    StandartIcerikTipiID = 171,
                    SiraNo = 157,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 158,
                    StandartID = 1,
                    BaslikNo = "8",
                    Baslik = "EBYS kullanım özellikleri",
                    Detay = null,
                    UstIcerikID = 20,
                    StandartIcerikTipiID = 169,
                    SiraNo = 158,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 159,
                    StandartID = 1,
                    BaslikNo = "8.1",
                    Baslik = "Kullanım – Genel kurallar",
                    Detay = null,
                    UstIcerikID = 158,
                    StandartIcerikTipiID = 168,
                    SiraNo = 159,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 160,
                    StandartID = 1,
                    BaslikNo = "8.1.1",
                    Baslik = null,
                    Detay = "EBYS, bünyesindeki elemanlar üzerinde arama, görüntüleme ve yazdırma gibi kullanım fonksiyonlarını içermelidir.",
                    UstIcerikID = 159,
                    StandartIcerikTipiID = 171,
                    SiraNo = 160,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 161,
                    StandartID = 1,
                    BaslikNo = "8.1.2",
                    Baslik = null,
                    Detay = "EBYS, bu bölümde tanımlanan fonksiyonları kullanıcıya bir grafik ara yüz ile sunmalıdır. Bu ara yüz, seri ve klasör listelerinin gözden geçirilerek aranan belgelere erişimi sağlayacağı gibi, anahtar kelimeler veya referans kodları ile doğrudan erişimi de sağlamalıdır.",
                    UstIcerikID = 159,
                    StandartIcerikTipiID = 171,
                    SiraNo = 161,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 162,
                    StandartID = 1,
                    BaslikNo = "8.2",
                    Baslik = "Arama",
                    Detay = null,
                    UstIcerikID = 158,
                    StandartIcerikTipiID = 168,
                    SiraNo = 162,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 163,
                    StandartID = 1,
                    BaslikNo = "8.2.1",
                    Baslik = null,
                    Detay = "EBYS, bünyesindeki elemanlara ait üstveri bilgileri üzerinden arama yapabilmelidir. Arama kapsamına elektronik belge yöneticisinin tanımladığı üstveri elemanları yanı sıra kullanıcı tarafından tanımlanan üstveri bilgileri de dâhil edilmelidir. ",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 163,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 164,
                    StandartID = 1,
                    BaslikNo = "8.2.2",
                    Baslik = null,
                    Detay = "Üstveri bilgilerinin oluşturulmasında kontrollü terminolojinin kullanıldığı durumlarda arama işlemi kontrollü terminoloji üzerinden yapılmalıdır.",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 164,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 165,
                    StandartID = 1,
                    BaslikNo = "8.2.3",
                    Baslik = null,
                    Detay = "EBYS, bünyesinde bulunan belgelerden uygun olanlar üzerinde tam metin (full-text)  arama yapabilmelidir.",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 165,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 166,
                    StandartID = 1,
                    BaslikNo = "8.2.4",
                    Baslik = null,
                    Detay = "EBYS, kullanıcıların aramaları sonucunda ilgilendikleri belgeleri kaydetmelerine ve ileride tekrar kullanmalarına olanak tanımalıdır.",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 166,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 167,
                    StandartID = 1,
                    BaslikNo = "8.2.5",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>EBYS arama fonksiyonu;</p><ul><li style='text-align: justify;' class='ms-hover'>Ve, veya, eşit, eşit değil gibi mantıksal operatörleri kullanmaya,</li><li style='text-align: justify;' class='ms-hover'>Kısmi eşleşmeleri bulmaya,</li><li style='text-align: justify;' class='ms-hover'> Jokey karakterleri kullanmaya uygun olmalıdır.&nbsp;</li></ul>",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 167,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 168,
                    StandartID = 1,
                    BaslikNo = "8.2.6",
                    Baslik = null,
                    Detay = "Arama sonuçları kullanıcıya liste halinde sunulmalıdır. Arama sonucu olumsuz ise kullanıcı uyarılmalıdır ",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 168,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 169,
                    StandartID = 1,
                    BaslikNo = "8.2.7",
                    Baslik = null,
                    Detay = "Arama sonucu farklı klasörlerden elde edilen belgeler kullanıcının tanımlayacağı ayrı bir klasörde tutulabilmedir. Bu işlem belgelerin kopyalanması yöntemiyle yapılabileceği gibi sadece linklerin saklaması şeklinde de gerçekleştirilebilir. ",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 169,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 170,
                    StandartID = 1,
                    BaslikNo = "8.2.8",
                    Baslik = null,
                    Detay = "Arama sonucu listelenecek dokümanlar kullanıcının erişim hakları göz önünde bulundurularak filtrelenmelidir. ",
                    UstIcerikID = 162,
                    StandartIcerikTipiID = 171,
                    SiraNo = 170,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 171,
                    StandartID = 1,
                    BaslikNo = "8.3",
                    Baslik = "Görüntüleme",
                    Detay = null,
                    UstIcerikID = 158,
                    StandartIcerikTipiID = 168,
                    SiraNo = 171,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 172,
                    StandartID = 1,
                    BaslikNo = "8.3.1",
                    Baslik = null,
                    Detay = "EBYS, arama sonucunca listelenen klasör ve belge içeriklerine doğrudan erişim sağlayabilmelidir. Kullanıcılar aradıkları belgeleri görüntülemek için ikinci bir işlem yapmaya gerek duymamalıdır. ",
                    UstIcerikID = 171,
                    StandartIcerikTipiID = 171,
                    SiraNo = 172,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 173,
                    StandartID = 1,
                    BaslikNo = "8.3.2",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>EBYS, birden fazla parçadan oluşan elektronik belgeleri tek bir ünite olarak görüntüleyebilmelidir. Özellikle çoklu ortam dosyalarının tek bir tümleşik dosya olarak kullanıcıya sunulması gerekir.</p><p style='text-align: justify; '>Not: Elektronik belgeye entegre ses ve görüntü dosyaları, dış bağlantı linklerinin içerikleri ve belgeye fiziksel ya da mantıksal olarak ilişkilendirilmiş diğer eklerin bütünlük içerisinde kullanıcıya gösterilmesi gerekir.&nbsp;</p>",
                    UstIcerikID = 171,
                    StandartIcerikTipiID = 171,
                    SiraNo = 173,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 174,
                    StandartID = 1,
                    BaslikNo = "8.3.3",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>EBYS, elektronik belgeleri görüntülerken, o belgenin üretiminde kullanılan uygulama programına ihtiyaç duymamalıdır. </p><p style='text-align: justify; '>Not: Sisteme dâhil edilecek belgelerin dosya formatları 2009/4 Sayılı Başbakanlık Genelgesi ile yürürlüğe giren Kamu Bilgi Sistemlerinde Birlikte Çalışabilirlik Esaslarına uygun olmalıdır.&nbsp;</p>",
                    UstIcerikID = 171,
                    StandartIcerikTipiID = 171,
                    SiraNo = 174,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 175,
                    StandartID = 1,
                    BaslikNo = "8.3.4",
                    Baslik = null,
                    Detay = "EBYS, elektronik belgeleri birden fazla kullanıcıya aynı anda görüntüleyebilmedir. ",
                    UstIcerikID = 171,
                    StandartIcerikTipiID = 171,
                    SiraNo = 175,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 176,
                    StandartID = 1,
                    BaslikNo = "8.3.5",
                    Baslik = null,
                    Detay = "EBYS, elektronik belge ile birlikte o belgeye ait üstverilerin tamamını ya da bir bölümünü de talep edildiği takdirde, aynı anda görüntüleyebilmelidir. ",
                    UstIcerikID = 171,
                    StandartIcerikTipiID = 171,
                    SiraNo = 176,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 177,
                    StandartID = 1,
                    BaslikNo = "8.4",
                    Baslik = "Yazdırma",
                    Detay = null,
                    UstIcerikID = 158,
                    StandartIcerikTipiID = 168,
                    SiraNo = 177,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 178,
                    StandartID = 1,
                    BaslikNo = "8.4.1",
                    Baslik = null,
                    Detay = "EBYS, bünyesinde bulunan yazdırılabilir formatta olan elektronik belgeler orijinal sunum özellikleri korunarak yazdırılabilmelidir. Bu işlem sırasında normal yazdırma rutini dışında bir işleme gerek olmamalıdır. Elektronik imzalı belgelerin yazdırılmasında söz konusu belgenin imzalı olduğunu gösterecek bir teknik kullanılmalıdır.",
                    UstIcerikID = 177,
                    StandartIcerikTipiID = 171,
                    SiraNo = 178,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 179,
                    StandartID = 1,
                    BaslikNo = "8.4.2",
                    Baslik = null,
                    Detay = "EBYS, istendiği takdirde, herhangi bir elektronik belge, klasör veya diğer elemanlara ait üstverilerin yazdırılmasına izin vermelidir. ",
                    UstIcerikID = 177,
                    StandartIcerikTipiID = 171,
                    SiraNo = 179,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 180,
                    StandartID = 1,
                    BaslikNo = "8.4.3",
                    Baslik = null,
                    Detay = "<p>EBYS, yazdırılması mümkün olmayan elektronik belgeler (ses ve hareketli görüntü dosyaları gibi) için uygun çıktı ortamı sağlamalıdır.&nbsp;</p><p>Not: Uygun çıktı ortamı, EBYS’nin, ses ve görüntü dosyaları istendiğinde bu tür dosyaları çalıştıracak bir uygulama programının yürütülmesi anlamını taşır. Kullanıcının bilgisayarında uygun bir program yok ise bir hata mesajı üretilmelidir.</p>",
                    UstIcerikID = 177,
                    StandartIcerikTipiID = 171,
                    SiraNo = 180,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 181,
                    StandartID = 1,
                    BaslikNo = "8.5",
                    Baslik = "Raporlama",
                    Detay = null,
                    UstIcerikID = 158,
                    StandartIcerikTipiID = 168,
                    SiraNo = 181,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 182,
                    StandartID = 1,
                    BaslikNo = "8.5.1",
                    Baslik = null,
                    Detay = "EBYS, sistem yöneticine ve yetkili kullanıcılara sistem yönetimi, kullanıcı aktiviteleri ve istatistik raporları sunabilmelidir.",
                    UstIcerikID = 181,
                    StandartIcerikTipiID = 171,
                    SiraNo = 182,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 183,
                    StandartID = 1,
                    BaslikNo = "8.5.2",
                    Baslik = null,
                    Detay = "EBYS, dosya tasnif planı elemanlarının tamamını veya bir bölümünü liste halinde raporlayabilmelidir.",
                    UstIcerikID = 181,
                    StandartIcerikTipiID = 171,
                    SiraNo = 183,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 184,
                    StandartID = 1,
                    BaslikNo = "8.5.3",
                    Baslik = null,
                    Detay = "Üretilen raporlar ekrana ve/veya yazıcıya yönlendirilebilmelidir.",
                    UstIcerikID = 181,
                    StandartIcerikTipiID = 171,
                    SiraNo = 184,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 185,
                    StandartID = 1,
                    BaslikNo = "8.5.4",
                    Baslik = null,
                    Detay = "<p>EBYS içerisinde gerçekleştirilen kullanıcı aktivitelerinin raporlanması bağlamında;&nbsp;</p><ul><li class='ms-hover'>Belli bir dönem içerisinde sisteme kayıt edilen elemanlara ait detay ve/veya istatistik raporları, </li><li class='ms-hover'>Belli bir dönem içerisinde açılan ve/veya kapatılan klasörlere ait detay ve/veya istatistik raporları, </li><li class='ms-hover'>Belli dönem içerisinde belli bir kullanıcının aktivite raporları, </li><li class='ms-hover'>Belli bir dönem içerisinde belli bir kayıt üzerindeki aktivite raporları üretilebilmelidir.&nbsp;</li></ul>",
                    UstIcerikID = 181,
                    StandartIcerikTipiID = 171,
                    SiraNo = 185,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 186,
                    StandartID = 1,
                    BaslikNo = "8.5.5",
                    Baslik = null,
                    Detay = "BYS, sisteme kayıtlı elektronik belgeleri tür, uygulama, üretici, güvenlik kategorisi, statüsü, dosya büyüklüğü gibi değişkenlere göre listeleyebilmeli ve istatistikler üretebilmelidir.",
                    UstIcerikID = 181,
                    StandartIcerikTipiID = 171,
                    SiraNo = 186,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 187,
                    StandartID = 1,
                    BaslikNo = "8.5.6",
                    Baslik = null,
                    Detay = "EBYS, saklama planları, transfer ve imha listeleri ile bunlara ait istatistikleri raporlayabilmelidir.",
                    UstIcerikID = 181,
                    StandartIcerikTipiID = 171,
                    SiraNo = 187,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 188,
                    StandartID = 1,
                    BaslikNo = "9",
                    Baslik = "Erişim kontrolü ve güvenlik",
                    Detay = null,
                    UstIcerikID = 20,
                    StandartIcerikTipiID = 169,
                    SiraNo = 188,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 189,
                    StandartID = 1,
                    BaslikNo = "9.1",
                    Baslik = "Sisteme Giriş",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 189,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 190,
                    StandartID = 1,
                    BaslikNo = "9.1.1",
                    Baslik = null,
                    Detay = "<p>EBYS, kullanıcıların sisteme girişini kontrol altına almaya yönelik bir mekanizmaya sahip olmalıdır.&nbsp;</p><p>Not: Böyle bir mekanizmanın en basit hali, kullanıcıya bir kullanıcı adı ve şifrenin verilmesidir. Kendisine kullanıcı adı ve şifresi verilenler için erişim haklarını gösteren bir profil tanımlanmalıdır. Ayrıca kullanıcının sistem içindeki rolleri ve ait olduğu kullanıcı grubu bu profil içerisinde tanımlanmalıdır.</p>",
                    UstIcerikID = 189,
                    StandartIcerikTipiID = 171,
                    SiraNo = 190,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 191,
                    StandartID = 1,
                    BaslikNo = "9.1.2",
                    Baslik = null,
                    Detay = "<p>EBYS,&nbsp;</ p >< ul >< li class='ms-hover'>Sisteme yeni kullanıcıların kayıt edilmesine, </li><li class='ms-hover'>Mevcut kullanıcıların geçici bir süre pasif hale getirilmesine,</li><li class='ms-hover'>Mevcut bir kullanıcının sistemden silinmesine imkan tanımlıdır. Ancak bu işlem sadece kullanıcının sisteme yanlışlıkla kayıt edilmiş olduğu veya sistemde herhangi bir işlem yapmadığı durumlar için geçerlidir. Teorik olarak sistemde herhangi bir işlem yapmış tüm kullanıcılara ait bilgiler sürekli saklanmalıdır. </li></ul>",
                    UstIcerikID = 189,
                    StandartIcerikTipiID = 171,
                    SiraNo = 191,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 192,
                    StandartID = 1,
                    BaslikNo = "9.1.3",
                    Baslik = null,
                    Detay = "Kullanıcı hesapları ile ilgili işlemler yalnızca yetkili sistem yöneticisi tarafından gerçekleştirilmelidir.",
                    UstIcerikID = 189,
                    StandartIcerikTipiID = 171,
                    SiraNo = 192,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 193,
                    StandartID = 1,
                    BaslikNo = "9.2",
                    Baslik = "Erişim Hakları",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 193,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 194,
                    StandartID = 1,
                    BaslikNo = "9.2.1",
                    Baslik = null,
                    Detay = "EBYS, kullanıcı, seri, klasör veya belge gibi sistem elemanlarına atanacak erişim haklarının sistem yöneticisi tarafından tanımlanmasına izin vermelidir.",
                    UstIcerikID = 193,
                    StandartIcerikTipiID = 171,
                    SiraNo = 194,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 195,
                    StandartID = 1,
                    BaslikNo = "9.2.2",
                    Baslik = null,
                    Detay = "Erişim haklarının tanımlanması, atanması ve değiştirilmesi gibi işlemler yalnızca sistem yöneticisinin yetkisinde olmalıdır.",
                    UstIcerikID = 193,
                    StandartIcerikTipiID = 171,
                    SiraNo = 195,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 196,
                    StandartID = 1,
                    BaslikNo = "9.2.3",
                    Baslik = null,
                    Detay = "<div><div style='text-align: justify;'>EBYS, bünyesinde yer alan elemanlar için en azından beş kademeli erişim hakları tanımlayabilmelidir. Bunlar:</div><div style='text-align: justify;'><br></div></div><ul><li class='ms-hover' style='text-align: justify;'><b>Tasnif dışı: </b>içerdiği konular itibariyle, gizlilik dereceli bilgi taşımayan, bilgi, belge, evrak, mesaj ve dokümanlara verilen,</li><li class='ms-hover' style='text-align: justify;'><b>Hizmete özel: </b>içerdiği konular itibariyle, gizlilik dereceli konular dışında olan, güvenlik işlemine ihtiyaç gösteren ve Devlet hizmetine ait özel bilgileri ihtiva eden bilgi, belge, evrak, mesaj ve dokümanlara verilen gizlilik derecesidir,</li><li class='ms-hover' style='text-align: justify;'><b>Özel: </b>İçerdiği konular itibariyle, müsaadesiz olarak açıklandığı takdirde, milli menfaatlerimizi olumsuz yönde etkileyecek olan bilgi, belge, evrak, mesaj ve dokümanlara verilen gizlilik derecesidir. </li><li class='ms-hover' style='text-align: justify;'><b>Gizli: </b>Müsaadesiz olarak açıklandığı takdirde, ulusal güvenliği, milli prestij ve menfaatlerimizi ciddi ve önemli derecede zedeleyecek olan bilgi, belge, evrak, mesaj ve dokümanlara verilen gizlilik derecesidir.</li><li class='ms-hover' style='text-align: justify; '><b>Çok gizli: </b>Müsaadesiz olarak açıklandığı takdirde, ulusal güvenliği büyük ölçüde tehlikeye düşürecek, Devletimize ve müttefiklerimize büyük ölçüde zararlar verebilecek olan bilgi, belge, evrak, mesaj ve dokümanlara verilen gizlilik derecesidir.</li></ul>",
                    UstIcerikID = 193,
                    StandartIcerikTipiID = 171,
                    SiraNo = 196,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 197,
                    StandartID = 1,
                    BaslikNo = "9.2.4",
                    Baslik = null,
                    Detay = "EBYS, kullanıcı grupları ve bireysel kullanıcılar tanımlamaya müsait olmalıdır.",
                    UstIcerikID = 193,
                    StandartIcerikTipiID = 171,
                    SiraNo = 197,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 198,
                    StandartID = 1,
                    BaslikNo = "9.3",
                    Baslik = "Kullanıcı Profilleri",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 198,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 199,
                    StandartID = 1,
                    BaslikNo = "9.3.1",
                    Baslik = null,
                    Detay = "EBYS, içindeki her kullanıcı için bir fonksiyon (kullanıcı, yönetici gibi) tanımlanmalıdır. Kullanıcının fonksiyonu, kimlik ve şifre bilgileri ile erişim hakları gibi bilgiler kullanıcı profili bölümünde tutulmalıdır.",
                    UstIcerikID = 198,
                    StandartIcerikTipiID = 171,
                    SiraNo = 199,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 200,
                    StandartID = 1,
                    BaslikNo = "9.3.2",
                    Baslik = null,
                    Detay = "Kullanıcı profilleri üzerinde değişiklik işlemleri ve erişim haklarının değiştirilmesi yalnızca sistem yöneticisinin kontrolünde olmalıdır.",
                    UstIcerikID = 198,
                    StandartIcerikTipiID = 171,
                    SiraNo = 200,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 201,
                    StandartID = 1,
                    BaslikNo = "9.3.3",
                    Baslik = null,
                    Detay = "Kullanıcılar bireysel olarak veya bir kullanıcı grubunun üyesi olarak erişim hakları ile donatılmalıdır. Kullanıcılara verilecek erişim hakları EBYS elemanları için tanımlanan haklarla paralellik göstermelidir. Her kullanıcı kendi erişim hakkı ve daha düşük güvenlik seviyesindeki belgelere erişebilmelidir.",
                    UstIcerikID = 198,
                    StandartIcerikTipiID = 171,
                    SiraNo = 201,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 202,
                    StandartID = 1,
                    BaslikNo = "9.4",
                    Baslik = "Kullanıcı Rolleri",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 202,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 203,
                    StandartID = 1,
                    BaslikNo = "9.4.1",
                    Baslik = null,
                    Detay = "<p><div style='text-align: justify;'>EBYS, kullanıcıların sistem içerisindeki fonksiyonlarını belirleyici nitelikte roller tanımlayabilmelidir. Bu roller kullanıcıların erişim haklarını düzenleyici nitelikte olacaktır. Bu rollerin tanımlanması ve kullanıcılara atanması yetkisi sistem yöneticisinde olmalıdır. Bu rollerin neler olacağı kurumların hiyerarşik yapısına göre değişebilir.</div><div style='text-align: justify;'>Aşağıdaki roller birçok kurum hiyerarşisine uygun olabilir.</div></p><ul><li class='ms-hover' style='text-align: justify;'><b>Sistem yöneticisi: </b>EBYS üzerindeki en yetkili kullanıcıdır. Bilgisayar sisteminin düzenli ve kurumsal fonksiyonlara uygun olarak çalışmasından sorumludur.</li><li class='ms-hover' style='text-align: justify;'><b>Elektronik belge yöneticisi (Uzman arşivci): </b>EBYS içerisindeki belge yönetimi fonksiyonlarını yerine getiren uzmandır. Özellikle dosya tasnif ve saklama planlarının tanımlanması ve güncel tutulması gibi fonksiyonlardan sorumludurlar.</li><li class='ms-hover' style='text-align: justify; '><b>Arşivci: </b>EBYS ile elektronik olmayan belgelerin entegrasyonu ve yönetiminden sorumludur. Genel olarak Elektronik Belge Yöneticisine bağlı olarak çalışır.</li><li class='ms-hover' style='text-align: justify; '><b>Kullanıcı: </b>Sistem içerisinde kendi birimi ile ilgili elektronik belgelerin yer almasını ve kullanımını sağlayacak haklara sahip kişidir.</li><li class='ms-hover' style='text-align: justify; '><b>Misafir kullanıcı: </b>Kendi birimi dışındaki birimlere ait elektronik belgeleri görme yetkisine sahip olan kullanıcıdır. Misafir kullanıcıların hangi yetkilerle hangi belgelere erişeceği konusu kurumsal izinlerle düzenlenmelidir.</li><li class='ms-hover' style='text-align: justify; '><b>Üretici/Sahip: </b>Elektronik belgelerin üretiminden ve dolayısıyla içeriğinden sorumlu kişi ve birimler.</li></ul>",
                    UstIcerikID = 202,
                    StandartIcerikTipiID = 171,
                    SiraNo = 203,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 204,
                    StandartID = 1,
                    BaslikNo = "9.4.2",
                    Baslik = null,
                    Detay = "Her kullanıcı için en az bir rol tanımlanmış olmalıdır.",
                    UstIcerikID = 202,
                    StandartIcerikTipiID = 171,
                    SiraNo = 204,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 204,
                    StandartID = 1,
                    BaslikNo = "9.4.3",
                    Baslik = null,
                    Detay = "EBYS fonksiyonları sisteme giriş yapan kullanıcı yetkisine göre düzenlenmelidir. Kullanıcının yetkisinde olmayan fonksiyonlar gizlenmelidir.",
                    UstIcerikID = 202,
                    StandartIcerikTipiID = 171,
                    SiraNo = 205,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 206,
                    StandartID = 1,
                    BaslikNo = "9.5",
                    Baslik = "Kullanıcı Grupları",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 206,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 207,
                    StandartID = 1,
                    BaslikNo = "9.5.1",
                    Baslik = null,
                    Detay = "<p></p><div style='text-align: justify;'><div>EBYS, kullanıcı grupları tanımlamaya uygun olmalıdır. Bu gruplardan bazıları şunlar olabilir:<br><br></div><ul><li class='ms-hover'>Fonksiyonel gruplar: Aynı birimde çalışan benzer fonksiyonları gerçekleştiren kişilerden oluşan gruplar.</li><li class='ms-hover'>Yönetici grupları: İdari olarak yönetici sorumluluğu bulunan kişilerden oluşan gruplar.</li><li class='ms-hover'>Proje grupları: Belli projeleri gerçekleştirmek için belirli zaman dilimlerinde bir araya getirilmiş kişilerden oluşan gruplar.</li></ul><div>Not: Bir kişi aynı anda birden fazla grubun üyesi olabilir.</div></div>",
                    UstIcerikID = 206,
                    StandartIcerikTipiID = 171,
                    SiraNo = 207,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 208,
                    StandartID = 1,
                    BaslikNo = "9.5.2",
                    Baslik = null,
                    Detay = "<p>EBYS:</p><ul><li class='ms-hover'>Yeni grupların tanımlanmasına,</li><li class='ms-hover'>Mevcut grupların geçici sürelerle veya sürekli olarak pasif hale getirilmesine ve</li><li class='ms-hover'>Mevcut grupların sistemden silinmesine uygun olmalıdır. Ancak bu işlem sadece kullanıcı grubunun sisteme yanlışlıkla kayıt edilmiş olduğu veya sistemde herhangi bir işlem yapmadığı durumlar için geçerlidir. Teorik olarak sistemde herhangi bir işlem yapmış tüm kullanıcı gruplarına ait bilgiler sürekli saklanmalıdır.</li></ul>",
                    UstIcerikID = 206,
                    StandartIcerikTipiID = 171,
                    SiraNo = 208,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 209,
                    StandartID = 1,
                    BaslikNo = "9.5.3",
                    Baslik = null,
                    Detay = "Gruplarla ilgili işlemler sistem yöneticisinin yetkisinde olmalıdır.",
                    UstIcerikID = 206,
                    StandartIcerikTipiID = 171,
                    SiraNo = 209,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 210,
                    StandartID = 1,
                    BaslikNo = "9.5.4",
                    Baslik = null,
                    Detay = "Gruplara yeni kişilerin eklenmesi veya mevcut kişilerden birinin gruptan çıkarılması mümkün olmalıdır. Ancak bu işlem kayıt altına alınmalıdır. Ancak, herhangi bir personelin hangi tarihler arasında hangi grubun üyesi olduğu kayıt altında olmalıdır.",
                    UstIcerikID = 206,
                    StandartIcerikTipiID = 171,
                    SiraNo = 210,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 211,
                    StandartID = 1,
                    BaslikNo = "9.6",
                    Baslik = "Kayıtlara erişim haklarının atanması ve uygulanması",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 211,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 212,
                    StandartID = 1,
                    BaslikNo = "9.6.1",
                    Baslik = null,
                    Detay = "EBYS, bünyesindeki elemanlara erişim haklarının ve güvenlik seviye kodlarının atanmasına olanak tanımalıdır. Sistemde yer alan seri, klasör ve elektronik belgelere erişim, yalnızca kendilerine hak tanınmış olan kullanıcı gruplarına ya da bireysel kullanıcılara verilmelidir.",
                    UstIcerikID = 211,
                    StandartIcerikTipiID = 171,
                    SiraNo = 212,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 213,
                    StandartID = 1,
                    BaslikNo = "9.6.2",
                    Baslik = null,
                    Detay = "EBYS bünyesindeki elemanlar, hiyerarşik yapı içerisinde ait oldukları üst elemanların güvenlik sınırlamalarına sahip olmalıdır. Not: Örneğin bir elektronik belge otomatik olarak bağlı bulunduğu klasöre verilmiş olan erişim haklarını taşır. Söz konusu klasöre erişim hakkı olan kullanıcılar o klasöre bağlı elektronik belgelere erişebilmelidir.",
                    UstIcerikID = 211,
                    StandartIcerikTipiID = 171,
                    SiraNo = 213,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 214,
                    StandartID = 1,
                    BaslikNo = "9.6.3",
                    Baslik = null,
                    Detay = "EBYS elemanlarına atanan erişim haklarında olabilecek uyuşmazlıklarda, sistem otomatik olarak en üst güvenlik seviyesine göre hareket etmeli ve sistem yöneticisini uyarmalıdır.",
                    UstIcerikID = 211,
                    StandartIcerikTipiID = 171,
                    SiraNo = 214,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 215,
                    StandartID = 1,
                    BaslikNo = "9.6.4",
                    Baslik = null,
                    Detay = "EBYS elemanlarına tanınan erişim hakları yetkili kullanıcılar tarafından değiştirilebilmelidir. Erişim haklarında yapılan değişiklikler kayıt altına alınmalıdır.",
                    UstIcerikID = 211,
                    StandartIcerikTipiID = 171,
                    SiraNo = 215,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 216,
                    StandartID = 1,
                    BaslikNo = "9.6.5",
                    Baslik = null,
                    Detay = "EBYS elemanları için belirlenen erişim kısıtlamaları mutlaka süreli olmalıdır. Kısıtlama süresinin bitiminde, sistem otomatik olarak kısıtlamayı kaldırabilmelidir. Not: Üzerinden kısıtlamaların kaldırılacağı elektronik klasör ve belgeler sistem yöneticisine periyodik olarak raporlanmalıdır. Sistem yöneticisi gerekli gördüğü durumlarda kısıtlılığın devamını sağlayabilmelidir.",
                    UstIcerikID = 211,
                    StandartIcerikTipiID = 171,
                    SiraNo = 216,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 217,
                    StandartID = 1,
                    BaslikNo = "9.6.6",
                    Baslik = null,
                    Detay = "EBYS bünyesindeki elemanları, yalnızca bu elemanlar için belirlenmiş güvenlik seviyesine eşit veya daha yüksek erişim hakkı olan kullanıcılara göstermelidir.",
                    UstIcerikID = 211,
                    StandartIcerikTipiID = 171,
                    SiraNo = 217,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 218,
                    StandartID = 1,
                    BaslikNo = "9.6.7",
                    Baslik = null,
                    Detay = "Kullanıcılar, erişim hakları bulunmayan elektronik klasör ve belgelerden haberdar olmamalıdır. EBYS arama ve listeleme gibi fonksiyonları gerçekleştirirken erişim haklarını kontrol etmelidir. Arama işlemleri yalnızca kullanıcının erişim hakkı bulunan kayıtlar ve bunlara ait üstveriler üzerinden yapılmalıdır. Not: Bazı kurumlarda bu kuralın esnetilmesi gerekebilir. Özellikle istatistik amaçlı yapılan çalışmalarda kullanıcıların sistemdeki tüm belgelerden miktar olarak haberdar olmaları gerekebilir. Bu gibi durumlarda kullanıcılara geçici olarak yetkileri ötesindeki belgelerden haberdar olma izni verilebilir. Ancak belgelerin içeriğinin görüntülenmesi yetki sınırları içerisinde tutulmalıdır.",
                    UstIcerikID = 211,
                    StandartIcerikTipiID = 171,
                    SiraNo = 218,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 219,
                    StandartID = 1,
                    BaslikNo = "9.7",
                    Baslik = "Üretim sorumluluğu ve mülkiyet",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 219,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 220,
                    StandartID = 1,
                    BaslikNo = "9.7.1",
                    Baslik = null,
                    Detay = "EBYS bünyesine dâhil edilen her elemanın (seri, klasör, belge, vs.) bir üreticisi ve/veya sahibi olmalıdır. Not: Kişi ve kurumlar kendi faaliyetleri sonucu ürettikleri belgelerin üreticisi ve sahibidirler. Kişi ve kurumlar faaliyetleri sırasında kendilerine başka kurum veya kişiler tarafından gönderilen belgelerin sahibi sayılırlar.",
                    UstIcerikID = 219,
                    StandartIcerikTipiID = 171,
                    SiraNo = 220,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 221,
                    StandartID = 1,
                    BaslikNo = "9.7.2",
                    Baslik = null,
                    Detay = "EBYS elemanlarının üreticileri ve/veya sahipleri söz konusu elemanlara otomatik olarak erişim hakkı kazanmalıdır. Not: Belgenin üreticisi, ürettiği belgenin içeriği konusunda bilgi sahibi olduğu halde kurumdaki pozisyonu gereği erişiminin engellediği durumlar olabilmektedir. Bu tür durumların önüne geçilebilmesi için üretim sorumluluğuna sahip kişilerin kendi ürettikleri belgelere erişim hakkı güvence altına alınmalıdır.",
                    UstIcerikID = 219,
                    StandartIcerikTipiID = 171,
                    SiraNo = 221,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 222,
                    StandartID = 1,
                    BaslikNo = "9.7.3",
                    Baslik = null,
                    Detay = "EBYS elemanlarına erişim, yalnızca üreticisi veya sahibi ile sınırlı tutulabilmelidir.",
                    UstIcerikID = 219,
                    StandartIcerikTipiID = 171,
                    SiraNo = 222,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 223,
                    StandartID = 1,
                    BaslikNo = "9.7.4",
                    Baslik = null,
                    Detay = "EBYS elemanlarına ait üretim ve/veya mülkiyet bilgileri sadece sistem yöneticisi tarafından değiştirilebilmedir. Yapılan değişiklikler kayıt altına alınmalıdır.",
                    UstIcerikID = 219,
                    StandartIcerikTipiID = 171,
                    SiraNo = 223,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 224,
                    StandartID = 1,
                    BaslikNo = "9.8",
                    Baslik = "Günlük dosyalarının oluşturulması",
                    Detay = null,
                    UstIcerikID = 188,
                    StandartIcerikTipiID = 168,
                    SiraNo = 224,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 225,
                    StandartID = 1,
                    BaslikNo = "9.8.1",
                    Baslik = null,
                    Detay = "<p>EBYS otomatik olarak bir günlük tutabilmelidir. Bu günlük sistemdeki kullanıcı aktivitelerinin kayıt altına alınmasını sağlamalıdır. Günlükteasgari olarak şu bilgiler tutulmalıdır:</p><ul><li class='ms-hover'>Gerçekleştirilen aktivitenin ne olduğu (kayıt ekleme, değiştirme, arama, vs.),</li><li class='ms-hover'>İşlemin hangi EBYS elemanı üzerinde gerçekleştirildiği,</li><li class='ms-hover'>İşlemin kim tarafından gerçekleştirildiği,</li><li class='ms-hover'>İşlemin gerçekleştirildiği tarih ve saat.</li></ul>",
                    UstIcerikID = 224,
                    StandartIcerikTipiID = 171,
                    SiraNo = 225,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 226,
                    StandartID = 1,
                    BaslikNo = "9.8.2",
                    Baslik = null,
                    Detay = "<p>Günlük dosyasında takip edilmesi gereken aktivitelerden bazıları şunlardır:</p><ul><li class='ms-hover'>Elektronik dokümanların belge olarak tanımlanma işlemine ait tarih ve saat bilgisi,</li><li class='ms-hover'>EBYS elemanların birbirleriyle ilişkilendirme ve/veya yer değiştirme işlemleri,</li><li class='ms-hover'>Saklama planı ve saklama sürelerinde yapılacak değişiklikler,</li><li class='ms-hover'><li class='ms-hover'>EBYS elemanlarına ait üstveri bilgilerinde yapılan değişiklikler,</li><li class='ms-hover'>Erişim hakları ve bunların atanması ile ilgili yapılan değişiklikler,</li><li class='ms-hover'>Elektronik belgelerin kopyalama, taşıma ve silme işlemleri</li></li></ul>",
                    UstIcerikID = 224,
                    StandartIcerikTipiID = 171,
                    SiraNo = 226,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 227,
                    StandartID = 1,
                    BaslikNo = "9.8.3",
                    Baslik = null,
                    Detay = "Günlük dosyasında yer alan bilgiler sistem yöneticisi dâhil hiç kimse tarafından değiştirilemeyecek veya silinemeyecek şekilde korunmalıdır.",
                    UstIcerikID = 224,
                    StandartIcerikTipiID = 171,
                    SiraNo = 227,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 228,
                    StandartID = 1,
                    BaslikNo = "9.8.4",
                    Baslik = null,
                    Detay = "Günlük bilgilerin saklama planları çerçevesinde imha edilebilir. Ancak herhangi bir günlük girişine ait saklama süresi referans verdiği elektronik belgeden daha kısa olamaz.",
                    UstIcerikID = 224,
                    StandartIcerikTipiID = 171,
                    SiraNo = 228,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 229,
                    StandartID = 1,
                    BaslikNo = "9.8.5",
                    Baslik = null,
                    Detay = "Günlük bilgileri gerekli olduğu durumlarda kurum dışı yetkililer tarafından incelebilmelidir. Ayrıca günlük bilgileri dışarıdan birinin anlayacağı format ve açıklıkta olmalıdır.",
                    UstIcerikID = 224,
                    StandartIcerikTipiID = 171,
                    SiraNo = 229,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 230,
                    StandartID = 1,
                    BaslikNo = "9.8.6",
                    Baslik = null,
                    Detay = "<p>Günlük bilgileri üzerinde belirli kriterlere göre filtrelenmiş raporlar hazırlanabilmelidir.<br>Örneğin:</p><ul><li class='ms-hover'>Bir kullanıcıya ait belli bir zaman dilimi içindeki aktiviteler, </li><li class='ms-hover'>Bir EBYS elemanı üzerinde belirli bir zaman dilimi içerindeki aktiviteler</li></ul>",
                    UstIcerikID = 224,
                    StandartIcerikTipiID = 171,
                    SiraNo = 230,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 231,
                    StandartID = 1,
                    BaslikNo = "10",
                    Baslik = "Sistem Tasarımı ve Yönetimi",
                    Detay = null,
                    UstIcerikID = 20,
                    StandartIcerikTipiID = 169,
                    SiraNo = 231,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 232,
                    StandartID = 1,
                    BaslikNo = "10.1",
                    Baslik = "Sistem bütünlüğü ve güvenirlik",
                    Detay = null,
                    UstIcerikID = 231,
                    StandartIcerikTipiID = 168,
                    SiraNo = 232,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 233,
                    StandartID = 1,
                    BaslikNo = "10.1.1",
                    Baslik = null,
                    Detay = "EBYS, sistemin, verilerin, veriler arasındaki referansların ve EBYS elemanlarının bütünlüğünü ve güvenirliliği sağlamak ve gerektiğinde göstermek zorundadır",
                    UstIcerikID = 232,
                    StandartIcerikTipiID = 171,
                    SiraNo = 233,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 234,
                    StandartID = 1,
                    BaslikNo = "10.1.2",
                    Baslik = null,
                    Detay = "EBYS, bünyesindeki her elemanı eşsiz bir referans numarası kodlamalıdır. Referans numaralarının üretim ve kullanım prosedürü gerektiğinde gösterilebilmelidir.",
                    UstIcerikID = 232,
                    StandartIcerikTipiID = 171,
                    SiraNo = 234,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 235,
                    StandartID = 1,
                    BaslikNo = "10.1.3",
                    Baslik = null,
                    Detay = "EBYS içerisinde tarihlerin yıl hanesi dört haneli (2005 gibi) olarak kullanılmalıdır.",
                    UstIcerikID = 232,
                    StandartIcerikTipiID = 171,
                    SiraNo = 235,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 236,
                    StandartID = 1,
                    BaslikNo = "10.2",
                    Baslik = "Kullanım kolaylığı",
                    Detay = null,
                    UstIcerikID = 231,
                    StandartIcerikTipiID = 168,
                    SiraNo = 236,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 237,
                    StandartID = 1,
                    BaslikNo = "10.2.1",
                    Baslik = null,
                    Detay = "EBYS’nin tamamı çevrimiçi yardıma sahip olmalıdır. Sağlanan yardım dokümanları farklı formatlarda (metin, video, vs.) olabilir. Yardım dosyasının dilinin Türkçe olması esastır. Ancak sistemi kullanan kamu kurumunun talebi üzerine farklı dillerde de yardım dosyaları oluşturulabilir.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 237,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 238,
                    StandartID = 1,
                    BaslikNo = "10.2.2",
                    Baslik = null,
                    Detay = "Sağlanan çevrimiçi yardım içerik duyarlı olmalıdır.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 238,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 239,
                    StandartID = 1,
                    BaslikNo = "10.2.3",
                    Baslik = null,
                    Detay = "Sistem tarafından üretilen tüm hata mesajları anlamlı olmalıdır. Kullanıcılar gördükleri hata mesajından sorunun ne olduğunu kolayca anlayabilmelidir.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 239,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 240,
                    StandartID = 1,
                    BaslikNo = "10.2.4",
                    Baslik = null,
                    Detay = "Kullanıcı ara yüzü basit ve işletim sistemi ile uyumlu olmalıdır.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 240,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 241,
                    StandartID = 1,
                    BaslikNo = "10.2.5",
                    Baslik = null,
                    Detay = "EBYS, kullanıcıların aynı anda birden fazla kayda erişmesine ve işlem yapmasına olanak tanımalıdır.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 241,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 242,
                    StandartID = 1,
                    BaslikNo = "10.2.6",
                    Baslik = null,
                    Detay = "EBYS veri girişlerinde varsayılan değerleri önermelidir. Not: Özellikle tarih, referans numarası gibi veriler sistem tarafında izlenebilir ve veri girişi esnasında kullanıcıya önerilebilir.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 242,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 243,
                    StandartID = 1,
                    BaslikNo = "10.2.7",
                    Baslik = null,
                    Detay = "Kullanıcılar sistem içerisinde sık kullandıkları fonksiyonlar için kısa yol tuşu veya simgesi tanımlayabilmelidir",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 243,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 244,
                    StandartID = 1,
                    BaslikNo = "10.2.8",
                    Baslik = null,
                    Detay = "EBYS kurum elektronik posta sistemi ile entegre çalışabilmelidir. Kullanıcılar gönderdikleri ya da aldıkları postaları kolayca sisteme kaydedebilmelidir.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 244,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 245,
                    StandartID = 1,
                    BaslikNo = "10.2.9",
                    Baslik = null,
                    Detay = "EBYS, taranmış dokümanlara ait üstverilerin kolayca elde edilebilmesi için optik karakter tanıma (OCR) özelliğine sahip olmalı ya da OCR programları ile entegre çalışabilmelidir.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 245,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 246,
                    StandartID = 1,
                    BaslikNo = "10.2.10",
                    Baslik = null,
                    Detay = "EBYS kullanıcılara dosya tasnif planının kullanımı hakkında rehberlik ve yardım edecek özelliklere sahip olmalıdır.",
                    UstIcerikID = 236,
                    StandartIcerikTipiID = 171,
                    SiraNo = 246,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 247,
                    StandartID = 1,
                    BaslikNo = "10.3",
                    Baslik = "Performans ve ölçeklenebilirlik",
                    Detay = null,
                    UstIcerikID = 231,
                    StandartIcerikTipiID = 168,
                    SiraNo = 247,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 248,
                    StandartID = 1,
                    BaslikNo = "10.3.1",
                    Baslik = null,
                    Detay = "<p>EBYS normal işletim koşulları altında kabul edilebilir bir performans göstermelidir. Normal işletim koşulları asgari olarak;</p><ul><li class='ms-hover'>Sistemde bileşenleri ve ekleri olan bir milyon belge yükü</li><li class='ms-hover'>Aynı anda sistemde aktif</li><li class='ms-hover'>20 kullanıcı,</li><li class='ms-hover'>100 kullanıcı,</li><li class='ms-hover'>500 kullanıcı olduğu durumlar olarak düşünülmelidir.</li></ul>",
                    UstIcerikID = 247,
                    StandartIcerikTipiID = 171,
                    SiraNo = 248,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 249,
                    StandartID = 1,
                    BaslikNo = "10.3.2",
                    Baslik = null,
                    Detay = "<p>EBYS tarafından performans açısından aşağıdaki kriterlere uygun süreler için yapılan beyanlar “Onaylı veya Akredite Laboratuvarlar” tarafından doğrulanmalıdır.</p><ul><li class='ms-hover'>Bir seri veya klasöre ait elemanların grafik olarak görüntülenme zamanı,&nbsp;<br>-10 belgeli klasör<br>-1000 belgeli klasör<br>-50000 belgeli klasör</li><li class='ms-hover'>Elektronik bir belgeyi sisteme dahil etme zamanı,</li><li class='ms-hover'>Basit bir aramaya (tek değişkenli) cevap zamanı,<br>-Belgenin sayı numarası<br>-Belgenin konusu<br>-Tam metin</li><li class='ms-hover'>Karmaşık bir aramaya (dört değişkenli) cevap zamanı,<br>-Tarih, Konu, Dosya Plan Kodu, Tam Metin<br>- Tarih, Konu, Dosya Plan Kodu, Birim</li></ul>",
                    UstIcerikID = 247,
                    StandartIcerikTipiID = 171,
                    SiraNo = 249,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 250,
                    StandartID = 1,
                    BaslikNo = "10.3.3",
                    Baslik = null,
                    Detay = "TS 13298 uyumlu yazılım, aynı zamanda TS ISO/IEC 25051 standardının gereksinimlerinden Ürün Açıklaması, Kullanıcı Dokümantasyonu ve fonksiyonel testleri TS 13298 kapsamında gerçekleştirmeli ve belgeleyebilmelidir.",
                    UstIcerikID = 247,
                    StandartIcerikTipiID = 171,
                    SiraNo = 250,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 251,
                    StandartID = 1,
                    BaslikNo = "10.4",
                    Baslik = "Verilerin Depolanması",
                    Detay = null,
                    UstIcerikID = 231,
                    StandartIcerikTipiID = 168,
                    SiraNo = 251,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 252,
                    StandartID = 1,
                    BaslikNo = "10.4.1",
                    Baslik = null,
                    Detay = "EBYS bünyesinde tutulan elektronik belgelerin okunabilirlik açısından periyodik olarak denetlenmesine imkân tanıyacak fonksiyonlar içermelidir. Bu denetimler sırasında karşılaşılacak saklama ünitesi bozuklukları ve veri kayıpları rapor edilmelidir.",
                    UstIcerikID = 251,
                    StandartIcerikTipiID = 171,
                    SiraNo = 252,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 253,
                    StandartID = 1,
                    BaslikNo = "10.4.2",
                    Baslik = null,
                    Detay = "EBYS saklama ünitelerinin toplu olarak yenilenmesine imkan tanıyacak fonksiyonlar içermelidir. Not: EBYS bünyesindeki veriler sağlam ve uzun ömürlü saklama üniteleri üzerinde depolanmalıdır. Depolama için kullanılan ürünler, üreticilerinin tavsiye ettiği ürün ömrü boyunca ve yine üreticisinin tavsiye ettiği çevresel şartların sağlandığı ortamlarda saklanmalıdır.",
                    UstIcerikID = 251,
                    StandartIcerikTipiID = 171,
                    SiraNo = 253,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 254,
                    StandartID = 1,
                    BaslikNo = "10.4.3",
                    Baslik = null,
                    Detay = "EBYS versiyon ilerlemelerinde ve teknolojik değişimlerde veri kayıplarının olmayacağını gösterebilmelidir.",
                    UstIcerikID = 251,
                    StandartIcerikTipiID = 171,
                    SiraNo = 254,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 255,
                    StandartID = 1,
                    BaslikNo = "10.4.4",
                    Baslik = null,
                    Detay = "EBYS tasarım ve üretiminde yaygın standardlar kullanılmalıdır. Program kodları, depolama fonksiyonları ve veri tabanı yapısı açık kaynak kodlu veya endüstri standardlarından oluşmalıdır.",
                    UstIcerikID = 251,
                    StandartIcerikTipiID = 171,
                    SiraNo = 255,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 256,
                    StandartID = 1,
                    BaslikNo = "10.4.5",
                    Baslik = null,
                    Detay = "EBYS yapısı ve kodlarına ait dokümantasyon koruma altına alınmalıdır.",
                    UstIcerikID = 251,
                    StandartIcerikTipiID = 171,
                    SiraNo = 256,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 257,
                    StandartID = 1,
                    BaslikNo = "10.4.6",
                    Baslik = null,
                    Detay = "Elektronik belgelerin korunmasına yönelik üstveriler EBYS içerisinde tanımlanabilir olmalıdır.",
                    UstIcerikID = 251,
                    StandartIcerikTipiID = 171,
                    SiraNo = 257,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 258,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "Bölüm II: Belge Kriterleri",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 164,
                    SiraNo = 258,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 259,
                    StandartID = 1,
                    BaslikNo = "11",
                    Baslik = "Belge Özellikleri",
                    Detay = null,
                    UstIcerikID = 258,
                    StandartIcerikTipiID = 169,
                    SiraNo = 259,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 260,
                    StandartID = 1,
                    BaslikNo = "11.1",
                    Baslik = "Tanımlanabilirlik",
                    Detay = null,
                    UstIcerikID = 259,
                    StandartIcerikTipiID = 168,
                    SiraNo = 260,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 261,
                    StandartID = 1,
                    BaslikNo = "11.1.1",
                    Baslik = null,
                    Detay = "Elektronik ortamda üretilen dokümanlardan belge statüsü kazananlar EBYS içerisinde tanımlanabilir olmalıdır. Tanımlanabilirlik, herhangi bir elektronik belge üreticisi, yazarı, alıcısı ve belgeye ait tarih bilgilerinin kayıt altına alınması ile sağlanır.",
                    UstIcerikID = 260,
                    StandartIcerikTipiID = 171,
                    SiraNo = 261,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 262,
                    StandartID = 1,
                    BaslikNo = "11.1.2",
                    Baslik = null,
                    Detay = "<p style='text-align: justify; '>Elektronik belgeye ait tanımlanabilirlik özellikleri şunlardır:</p><ul><li class='ms-hover' style='text-align: justify;'><b>Üretici: </b>Herhangi bir elektronik belgenin üretilmesi için yetkili tüzel kuruluş ve gerçek kişiler üretici olarak tanımlanır. Geleneksel sistemlerde bir belgeye ait üretici bilgisi evrakın başında antet olarak veya evrakın sonunda imza bölümünde yer alır.</li><li class='ms-hover' style='text-align: justify;'><b>Yazar: </b>Herhangi bir belgenin entelektüel sorumluluğunu taşıyan kişi veya kurumdur. Genel olarak belgeyi imzalayan kişi yazar olarak tanımlanır. Yazar, entelektüel sorumluluğu kendi adına taşıyabileceği gibi yetkilisi olduğu kurum adına da taşıyabilir.</li></ul><p style='text-align: justify;'>Not: Bir belgeye ait yazar sorumluluğu ile üretici sorumluluğu aynı kişi veya kuruluşu işaret edebilir.</p><ul><li class='ms-hover' style='text-align: justify;'><b>Gönderen: </b>Herhangi bir belgenin çıkış kaynağı olan kişi, kurum veya süreç sorumlusudur.</li></ul><p style='text-align: justify;'>Not: Bir belgenin üreticisi, yazarı veya göndericisi tarafından diğer bir kuruma veya şahsa gönderilmesi dokümanların belgeye dönüşmesindeki en önemli unsurdur. Gönderilme işlemi fonksiyonu tetiklemesi ve şekillendirmesi açısından son derece &nbsp;önemlidir. Bir belgeye ait gönderen sorumluluğu, yazar ve / veya üretici sorumluluğu aynı kişi veya kuruluşu işaret edebilir.</p><ul><li class='ms-hover' style='text-align: justify;'><b>Çıkış yeri: </b>Elektronik belgenin üretildiği veya gönderildiği yere ait coğrafi bilgidir.</li></ul><p style='text-align: justify;'>Not: Elektronik belgeye ait çıkış yeri bilgisi kurumsal ihtiyaçlara göre detaylandırılabilir. Ülke, bölge, şehir, ilçe gibi detaylar EBYS içerisinde gerekli olduğu durumlarda hiyerarşik olarak verilebilmelidir.</p><ul><li class='ms-hover' style='text-align: justify;'><b>Üretim tarihi: </b>Belgenin üretildiği tarih bilgisidir.</li><li class='ms-hover' style='text-align: justify;'><b>İletim tarihi: </b>Belgenin gönderildiği tarihtir.</li><li class='ms-hover' style='text-align: justify;'><b>Arşivleme tarihi: </b>Elektronik belgenin kurumsal arşiv sistemine dâhil edildiği tarihtir.</li><li class='ms-hover' style='text-align: justify;'><b>Transfer tarihi: </b>Elektronik belgenin kurum arşivine veya kurum dışı bir arşive transfer edilme tarihidir.</li></ul><p style='text-align: justify;'>Not: Transfer işlemi birden fazla gerçekleşebilir. Bu nedenle belgenin mülkiyet zincirinde bir kopukluk olmaması için tüm transferlere ait tarih bilgileri kayıt altına alınmalıdır.</p><ul><li class='ms-hover' style='text-align: justify;'><b>İmha tarihi: </b>Elektronik belgenin kurum saklama planları çerçevesinde imha edildiği tarihtir.</li><li class='ms-hover' style='text-align: justify;'><b>Alıcı adı: </b>Elektronik belgenin işlem yapılmak veya bilgilendirmek üzere gönderildiği kişi, kurum veya süreç sorumlularıdır.</li></ul><p style='text-align: justify;'>Not: Alıcı birden fazla olabilir. Alıcının birden fazla olduğu durumlarda gereği için gönderilenlerle bilgi için gönderilenler ayırt edilebilmelidir.</p><ul><li class='ms-hover' style='text-align: justify;'><b>Fonksiyon adı: </b>Elektronik belgenin ilgili olduğu kurumsal fonksiyonun adıdır.</li></ul><p style='text-align: justify; '>Not: Bu bilgi elektronik belge üzerinde kayıtlı olmayabilir. Dolayısıyla genelde bir belgeye ait fonksiyon bilgisi içerik analizi yapıldıktan sonra belirlenebilir. Fonksiyon bilgisi oluşturulurken kullanılacak anahtar kelimeler kurumsal dosya tasnif planları içerisindenseçilmelidir.</p>",
                    UstIcerikID = 260,
                    StandartIcerikTipiID = 171,
                    SiraNo = 262,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 263,
                    StandartID = 1,
                    BaslikNo = "11.2",
                    Baslik = "Bütünlük",
                    Detay = null,
                    UstIcerikID = 259,
                    StandartIcerikTipiID = 168,
                    SiraNo = 263,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 264,
                    StandartID = 1,
                    BaslikNo = "11.2.1",
                    Baslik = null,
                    Detay = "<p>EBYS, bünyesindeki elektronik belgelerin bütünlüğünü korumalı ve söz konusu belgelerin bütünlüğünün sorgulandığı durumlarda bütünlüğün bozulmadığını gösterebilmelidir. Bütünlük kavramı elektronik belgenin entelektüel (içerik), tanımsal ve fiziksel olarak bir bütün olarak korunmasıdır.</p><ul><li class='ms-hover'><b>Entelektüel bütünlük: </b>EBYS, elektronik bir belgenin entelektüel bütünlüğü ile ilgili olarak;</li></ul><p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; -belge vasfı kazanmış elektronik dokümanların içeriğine herhangi bir müdahalenin yapılmasını engellemelidir.</p><p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; -elektronik belgelerin endüstri standardı sistemlerle erişilebilir, okunabilir ve yorumlanabilir olmasını sağlamalıdır.</p><ul><li class='ms-hover'>Tanımsal bütünlük: EBYS, elektronik belgelerin üretim, iletim, alınma ve kullanımı ile ilgili tanımlama ögelerini bir bütün içerisinde korumalıdır.</li><li class='ms-hover'>Fiziksel bütünlük: EBYS, elektronik bir belgeyi oluşturan tüm bileşenlerin bir bütün olarak bir arada korunmasını ve kullanımını sağlamalıdır. Ayrıca belgenin bir bölümünün ya da tamamının bozulmasına veya kaybolmasına neden olabilecek sistem hatalarına karşı gerekli önlemli almalıdır.</li></ul><p>Not: Elektronik belgelerin fiziksel bütünlüğü çeşitli çevresel faktörler ya da insan hataları nedeni ile de tehdit altında olabilir. Elektronik belge yöneticileri bu tür faktörlere karşı gerekli prosedürsel ve yönetimsel tedbirleri almalıdır.</p>",
                    UstIcerikID = 263,
                    StandartIcerikTipiID = 171,
                    SiraNo = 264,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 265,
                    StandartID = 1,
                    BaslikNo = "11.3",
                    Baslik = "Onay ve Kayıt Bilgisi",
                    Detay = null,
                    UstIcerikID = 259,
                    StandartIcerikTipiID = 168,
                    SiraNo = 265,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 266,
                    StandartID = 1,
                    BaslikNo = "11.3.1",
                    Baslik = null,
                    Detay = "EBYS, elektronik belgelerin üreticisi tarafından onaylanmasına ve kurumsal kayıt sistemleri içerisinde temsil edilmesine imkan sağlayacak teknolojileri bünyesinde barındırmalı ya da bu türden bağımsız sistemlerle entegre çalışabilmelidir. Bu sistemlerin yasal ve prosedürsel olarak kabul edilebilir olması uygulamada bir önkoşul olmalıdır. Not: Geleneksel belge yönetim sistemlerinde bir belgenin ‘resmi’ bir hüviyet kazanabilmesi için o belgenin imza yetkisine sahip kişilerce imzalanmış olması ve belgenin kurumsal evrak kayıt sistemi içerisinde yer alması gerekir. Belge ile ifade edilen mal ve hizmet alma ilişkileri, medeni ilişkiler, hak ve alacak ilişkilerinin hukuki geçerliğinin olabilmesi için belgenin ilgili ve yetkili kişilerce imzalanmış ve bir kayıt sistemi içerisinde gösterilmesi esastır.",
                    UstIcerikID = 265,
                    StandartIcerikTipiID = 171,
                    SiraNo = 266,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 267,
                    StandartID = 1,
                    BaslikNo = "11.3.2",
                    Baslik = null,
                    Detay = "<p>EBYS, elektronik belgelerin onaylanması ve kayıt altına alınması ile ilgili olarak güncel teknolojiler ışığında aşağıdaki tekniklerden bir ya da birkaçını bünyesinde barındırmalı veya bu sistemlerle entegre çalışabilmelidir. Bu bağlamda EBYS, elektronik imzalı belgeleri yönetebilme özelliklerine sahip olmalıdır. Elektronik imza dışındaki onay ve kayıt sistemleri artı bir özellik olarak düşünülmelidir.</p><ul><li class='ms-hover'><b>Elektronik imza: </b>Elektronik belgenin üretim, iletim, kullanım, saklama ve imhasının sorumlu kişi veya kişiler tarafından gerçekleştirildiğini gösteren dijital bir işarettir. Bu işaret belgeye eklenmiş veya belge ile mantıksal olarak ilişkilendirilmiş olabilir.</li><li class='ms-hover'><b>Elektronik mühür: </b>Elektronik belgenin yalnızca kastedilen alıcısı tarafından alındığını veya okunduğunu sağlamak üzere geliştirilmiş elektronik bir araçtır. Bu araç ile gönderilen elektronik belgelere ait gönderilme işlemi güvenilir üçüncü bir kurum tarafından onaylanır ve şifrelenir.</li><li class='ms-hover'><b>Elektronik zaman damgası: </b>Elektronik belgenin üretim, iletim ve alındısına ait tarih bilgilerinin fiziksel olarak belgeye eklenmesi veya belge ile mantıksal olarak ilişkilendirilmesidir.</li><li class='ms-hover'><b>Özel elektronik işaretler: </b>Elektronik belgelere eklenmiş veya onlarla ilişkilendirilmiş dijital filigran, amblem, logo ve benzeri işaretlerdir.</li><li class='ms-hover'><b>Kurum evrak sistemi: </b>Elektronik onay; Güvenli elektronik imza kullanılamayan durumlarda paraf yerine geçecek kaydın elektronik ortamda alınması ve bunun değiştirilemeyecek mahiyette loglanmasını ifade eder. Elektronik belgelerinin ve ait olduğu evrak serisinin kurumsal evrak kayıt, dosya tasnif ve evrak saklama planlarında gösterilmiş olmasıdır.</li></ul>",
                    UstIcerikID = 265,
                    StandartIcerikTipiID = 171,
                    SiraNo = 267,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 268,
                    StandartID = 1,
                    BaslikNo = "11.4",
                    Baslik = "Yapısal özellikler",
                    Detay = null,
                    UstIcerikID = 259,
                    StandartIcerikTipiID = 168,
                    SiraNo = 268,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 269,
                    StandartID = 1,
                    BaslikNo = "11.4.1",
                    Baslik = null,
                    Detay = "<p>EBYS, belgelerin üretim aşamasında kazandıkları yapısal özellikleri korumalıdır. Yapısal özellikler üreticilerin, belgeyi alıcının görmesini istediği sunum özellikleri, belgeye ait form özellikleri ve dosya formatına ait özelliklerden oluşur.</p><ul><li class='ms-hover'><b>Sunum özellikleri:</b> EBYS, belge üreticisinin söz konusu belgeye eklemiş olduğu sunum özelliklerini korumalıdır.</li></ul><p>Not: Sunum özellikleri, belgelerdeki mesajın anlaşılmasına veya belirli bir şekilde anlaşılmasına yardımcı olan özelliklerdir. Bunlar genelde üreticinin mesajın daha iyi anlaşılabilmesi için belgeye katmış olduğu çeşitli yapısal özellikleri kapsar ve belge içeriğini herhangi bir şekilde etkilemez. Kullanıcının dikkatini belli bir noktaya çekmeyi amaçlayan altı çizili bir cümle, farklı girintide &nbsp;azılmış bir paragraf, renklendirilmiş bir rakamın mesajın anlaşılmasına ya da mesajın üreticinin istediği şekilde anlaşılmasına katkısı oldukça önemlidir.</p><ul><li class='ms-hover'><b>Belge formu:</b> EBYS, elektronik belgelerin form özelliklerinin korunmasını sağlamalıdır.</li></ul><p>Not: Elektronik belgelerin, diğer belge türlerinde de olduğu gibi, form özellikleri mevcuttur. Bu özellikler, örneğin, bir rapor formunda üretilmiş bir belgenin bir yazışma belgesinden ayırmak için kullanılır. Her belge formunun kendine özgü olan üretim formu belgenin içerik bilgilerine ilave bilgiler içerir. Bu üretim formu, kullanıcının aradığı bilgiye ulaşmasında bazen bir filtre görevi görür. Kullanıcı aradığı bilginin ne tür belgelerde olabileceğini bilir ve aramasını bu bilgiye göre şekillendirir. Örneğin kullanıcı bir bilanço ile faaliyet raporunun farklı bilgiler içerdiğini bilir. Bu bilgi kullanıcıya son derece değerli zaman kazandırabilir.</p><ul><li class='ms-hover'><b>Dosya formatı:</b> EBYS, elektronik belgenin orijinal üretimformatını ve arşiv formatını birlikte yönetebilmelidir.</li></ul><p>Not: Elektronik belgelerin kurumsal olarak tercih edilebilecek standard dosya formatlarına transferi esnasında belge bütünlüğünü korumalıdır.</p>",
                    UstIcerikID = 268,
                    StandartIcerikTipiID = 171,
                    SiraNo = 269,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 270,
                    StandartID = 1,
                    BaslikNo = "11.5",
                    Baslik = "Üretim sorumluluğu ve mülkiyet hakları",
                    Detay = null,
                    UstIcerikID = 259,
                    StandartIcerikTipiID = 168,
                    SiraNo = 270,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 271,
                    StandartID = 1,
                    BaslikNo = "11.5.1",
                    Baslik = null,
                    Detay = "<p>EBYS, elektronik belgelerin üretim sorumluluğu taşıyan kişi ve kuruluşlarla olan ilişki bağını korumalıdır. Ayrıca belgensin üretiminden nihai tasfiyesine kadar geçen süreçteki mülkiyet zinciri kayıt altına alınmalıdır.</p><p>Not: Gerek geleneksel metotlarla üretilmiş belgelerde gerekse elektronik ortamda üretilmiş belgelerde içerik bilgilerinin anlam ifade edebilmesi için bu bilgilerin kurumsal veya bireysel aktivite ile ilişkilendirilmesi gerekmektedir. Bu ilişki belgelerde yazılı olmayan ancak belgeyi üreten kurum, diğer belgelerle olan konusal bütünlüğü, ekleri, vs. kullanıcı açısından son derece önemli bilgiler içerir. İlişkili olduğu diğer belgelerden soyutlanması veya üretim koşullarının bilinmemesi belgelerin ifade ettikleri mesajı zayıflatır bazen de mesaj anlamsızlaşır. Geleneksel kayıt ortamlarında ilişkinin korunması için bilgi ve belge yöneticilerinin fazla bir çaba harcaması gerekmemektedir. Çünkü mesaj ile mesajın kayıtlı olduğu ortamın birbirinden ayrılamaz olması ilişkinin doğal olarak korunmasını sağlar. Diğer taraftan elektronik ortamda üretilen bilgilerin ilişkilerinin korunması için özel önlemler alınması gerekmektedir.</p><ul><li class='ms-hover'><b>Kurumsal ilişki:</b> Elektronik belgenin üretiminden sorumlu kurumla ve söz konusu kurumun üretmiş olduğu diğer belgelerle olan organik bağı korunmalıdır. Bu bağın korunması EBYS’nin kurumsal dosya planlarını içermesi ile doğrudan ilişkilidir.</li><li class='ms-hover'><b>Fonksiyonel ilişki: </b>Elektronik belgelerin üretilmesine neden olan kurumsal fonksiyonlarla olan ilişkisi korunmalıdır. Fonksiyonel ilişkinin korunması belge serilerinin, klasörlerin ve dosyaların tasarımı ve bunlar arasındaki hiyerarşik ilişkinin doğru kurulması son derece önemlidir.</li><li class='ms-hover'><b>Provenans: </b>Elektronik belgelerin üretim kaynağı ve üretiminden tasfiyesine kadar olan yaşam sürecindeki mülkiyet zinciri korunmalıdır. Provenans bilgisi elektronik belgenin yaşam sürecinde her dönemin sorumlularının kayıt altına alınmasıdır. Bu kayıt elektronik belgeye olan güvenin sağlamlaştırılması ve belgenin yasal statüsünün korunması açısından son derece önemlidir.</li></ul>",
                    UstIcerikID = 270,
                    StandartIcerikTipiID = 171,
                    SiraNo = 271,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 272,
                    StandartID = 1,
                    BaslikNo = "11.6",
                    Baslik = "Teknolojik özellikler",
                    Detay = null,
                    UstIcerikID = 259,
                    StandartIcerikTipiID = 168,
                    SiraNo = 272,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 273,
                    StandartID = 1,
                    BaslikNo = "11.6.1",
                    Baslik = null,
                    Detay = "<p>EBYS, elektronik belgelerin üretim, iletim, depolama ve kullanımına imkan sağlayan teknolojik özelliklerini kayıt altına almalıdır.</p><p>Not: Elektronik belgelerin üretim ortamına ait bilgilerin kayıt altına alınması belgeleri gelecekte karşılaşabilecekleri orijinallik incelemelerine yardımcı olabileceği gibi belge üreten kurumların teknolojik yetkinliği konusunda da bilgiler vermesi açısından önemlidir. Burada ifade edilen verilerin önemli bir bölümü herhangi bir kullanıcı müdahalesi olmadan kayıt altına alınabilir.</p><ul><li class='ms-hover'><b>Donanım: </b>Elektronik belgelerin üretim, iletim, depolama ve kullanımı için gerekli olan donanım altyapısı kayıt altına alınmalıdır. Donanım altyapısı ile ilgili olarak aşağıdaki bilgiler tutulmalıdır.</li></ul><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Ana Bellek: </b>Elektronik belgenin yeniden kullanımı için gerekli olan ana bellek miktarının bilinmesidir.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Depolama ünitesi: </b>Elektronik belgenin depolama ünitesinin ne olduğu ve belgeyi depolamak için ne kadar yere ihtiyaç &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;duyulduğu bilgisidir.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-İşlemci: </b>Elektronik belgenin üretiminde kullanılan bilgisayar sistemine ait işlemci bilgisidir.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Ağ altyapısı: </b>Elektronik belgenin bir ağ üzerinden kullanılması gerektiği durumlar için, ağ yapısı ve mimarisine ait &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;bilgidir.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Diğer donanım: </b>Elektronik belgenin kullanımı için gerekli diğer donanımlara ait bilgilerdir. Bunlar arasında ekran &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;özellikleri ve fare kullanımına ihtiyaç olup olmadığı gibi bilgiler sayılabilir.</p><ul><li class='ms-hover'><b>Yazılım: </b>Elektronik belgenin üretim, iletim ve kullanımı için gerekli yazılımlara ait bilgilerdir.</li></ul><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-İşletim sistemi: </b>Elektronik belgenin üretimi için kullanılan bilgisayar sisteminin kullandığı işletim sistemine ait ad ve &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;versiyon bilgileridir.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Diğer sistem yazılımları: </b>İşletim sistemi dışında kalan diğer sistem yazılımlarıdır. Bunlar arasında ağ ve güvenlik &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;yazılımları en başta gelenlerdir.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Uygulama programı: </b>Elektronik belgenin üretimi ve iletiminin gerçekleştirildiği yazılımlardır. Bunlar, elektronik belgenin &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;sunum özellikleri ve dosya format özellikleri kazanmasını sağlayan yazılımlardır.</p><ul><li class='ms-hover'>Veri ve dosya formatı: Elektronik belgenin üretiminin gerçekleştirildiği bilgisayar sistemine ait işletim sistemi ve uygulama yazılımı tarafından verilerin kodlanması ve depolanması için kullanılan metotların tanımlanmasıdır.</li></ul><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Dosya sistemi: </b>Elektronik sistemin, belgeleri kaydetmek ve saklamak için kullandığı sistemidir.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Veri/dosya formatı: </b>Elektronik sistemin veri ve dosyaları saklamak için kullandığı formattır.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>-Veri tabanı modeli: </b>Verilerin bir veri tabanı yönetim sistemi içerisinde tutulduğu durumlarda veri tabanına ait bilgilerin &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;kayıt altına alınmasıdır.</p><ul><li class='ms-hover'><b>Sistem yönetimi: </b>Elektronik belgenin üretim, iletim, depolama ve kullanımı için kullanılan elektronik sistemlere ait erişim şartları ve güvenlik sınırlamaları gibi sistem yöneticisi tarafından getirilen kurallardır.</li></ul>",
                    UstIcerikID = 272,
                    StandartIcerikTipiID = 171,
                    SiraNo = 273,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 274,
                    StandartID = 1,
                    BaslikNo = "12",
                    Baslik = "Doküman yönetimi",
                    Detay = null,
                    UstIcerikID = 258,
                    StandartIcerikTipiID = 169,
                    SiraNo = 274,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 275,
                    StandartID = 1,
                    BaslikNo = "12.1",
                    Baslik = "Giriş",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 275,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 276,
                    StandartID = 1,
                    BaslikNo = "12.1.1",
                    Baslik = null,
                    Detay = "<p>Doküman yönetim sistemleri (DYS), genel olarak kurumsal bilgi kaynaklarının elektronik ortamda depolanması ve kullanılması için geliştirilmiş sistemlerdir. Bu sistemler kurum içerisinde belge statüsü kazanmış dokümanların yanı sıra belge özelliği taşımayan ancak içerdiği bilgi açısından depolanan ve kullanılan dokümanları düzenleme, tanımlama ve erişim gibi fonksiyonları yerine getirmek üzere kullanılır. Doküman yönetim sistemleri kurum bilgi kaynaklarının etkin ve verimli bir şekilde kullanılması ile zaman, maliyet ve işgücü tasarrufu sağlaması açısından kurumlar için önemli bir araçtır. Bu sistemler, elektronik belge yönetimi sistem kriterleri açısından iki temel fonksiyonu yerine getirmek için kullanılabilir:</p><ul><li class='ms-hover'>Doküman yönetim sistemleri, diğer bilgi kaynakları için olduğu gibi, elektronik belge özellikleri korunduğu takdirde, elektronik belgelerin yönetimi için de kullanılabilir.</li><li class='ms-hover'>Doküman yönetimi sistemi içerisine dahil her türlü bilgi kaynağı potansiyel olarak bir belge olarak tanımlanabilir. Bu nedenle doküman yönetim sistemleri EBYS için bir ön süreç aracı olabilir. Sistem içindeki dokümanlardan bir bölümü belge statüsü kazandırılarak ayrı bir yönetim prosedürüne tabi tutulabilir.</li></ul>",
                    UstIcerikID = 275,
                    StandartIcerikTipiID = 171,
                    SiraNo = 276,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 277,
                    StandartID = 1,
                    BaslikNo = "12.2",
                    Baslik = "Girdi Yönetimi",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 277,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 278,
                    StandartID = 1,
                    BaslikNo = "12.2.1",
                    Baslik = null,
                    Detay = "<p>Doküman yönetim sistemleri farklı kaynaklardan gelen dokümanları sisteme dâhil edebilmelidir. Bu kaynaklar:</p><ul><li class='ms-hover'>Elektronik dokümanlar: Çeşitli uygulama yazılımları ile üretilen elektronik dokümanlar, </li><li class='ms-hover'>Elektronik posta ve faks: Elektronik posta ya da faks yoluyla alınan dokümanlar ve ekleri,</li><li class='ms-hover'>Görüntülenmiş dokümanlar: Elektronik olarak üretilmeyen ancak tarayıcılar ve dijital görüntüleme cihazları gibi araçlarla elektronik ortama aktarılmış olan dokümanlar,</li><li class='ms-hover'>Sesli ve görüntülü dokümanlar: Dijital ya da analog olarak kaydedilmiş ses ve görüntü dokümanları, </li><li class='ms-hover'>Uzaktan algılama sistemleri: Coğrafi bilgi sistemleri ve radar sistemleri gibi uzaktan algılama yöntemiyle üretilmişverilerin oluşturduğu dokümanlar,</li><li class='ms-hover'>Veri tabanı yönetim sistemleri: Veri tabanı formunda ve bir veri tabanı yönetim sistemi içerisinde üretilmiş olan dokümanlar.</li></ul>",
                    UstIcerikID = 277,
                    StandartIcerikTipiID = 171,
                    SiraNo = 278,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 279,
                    StandartID = 1,
                    BaslikNo = "12.3",
                    Baslik = "Tanımlama ve indeksleme",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 279,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 280,
                    StandartID = 1,
                    BaslikNo = "12.3.1",
                    Baslik = null,
                    Detay = "Elektronik doküman yönetim sistemleri içerisine dahil edilen elektronik dokümanların tanımlama ve indeksleme işlemleri elektronik belgelerde olduğu gibi yapılmalıdır.",
                    UstIcerikID = 279,
                    StandartIcerikTipiID = 171,
                    SiraNo = 280,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 281,
                    StandartID = 1,
                    BaslikNo = "12.3.2",
                    Baslik = null,
                    Detay = "Tanımlama işlemi doküman seviyesinde yapılmalı ve dokümanlar için kullanılacak üstveri ögeleri bu referans modelinde belge seviyesi için belirlenen ögelerden oluşmalıdır.",
                    UstIcerikID = 279,
                    StandartIcerikTipiID = 171,
                    SiraNo = 281,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 282,
                    StandartID = 1,
                    BaslikNo = "12.3.3",
                    Baslik = null,
                    Detay = "Doküman yönetim sistemleri tanımlama için kullanılan üstveri ögeleri için indeksleme yapabilmelidir.",
                    UstIcerikID = 279,
                    StandartIcerikTipiID = 171,
                    SiraNo = 282,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 283,
                    StandartID = 1,
                    BaslikNo = "12.3.4",
                    Baslik = null,
                    Detay = "Elektronik olarak üretilmiş veya metin haline dönüştürülmüş olan dokümanlar (OCR, ICR, OMR vb sistemler ile) üzerinde tam metin (full-text) indeksleme yapılabilmelidir",
                    UstIcerikID = 279,
                    StandartIcerikTipiID = 171,
                    SiraNo = 283,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 284,
                    StandartID = 1,
                    BaslikNo = "12.4",
                    Baslik = "Dosyalama, düzenleme ve tasnif",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 284,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 285,
                    StandartID = 1,
                    BaslikNo = "12.4.1",
                    Baslik = null,
                    Detay = "Elektronik dokümanların dosyalama, düzenleme ve tasnif işlemleri elektronik belgelerde olduğu gibi yapılır.",
                    UstIcerikID = 284,
                    StandartIcerikTipiID = 171,
                    SiraNo = 285,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 286,
                    StandartID = 1,
                    BaslikNo = "12.5",
                    Baslik = "Depolama / Yedekleme",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 286,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 287,
                    StandartID = 1,
                    BaslikNo = "12.5.1",
                    Baslik = null,
                    Detay = "Elektronik dokümanlar depolama ve yedekleme ünitelerine kopyalanabilmelidir.",
                    UstIcerikID = 286,
                    StandartIcerikTipiID = 171,
                    SiraNo = 287,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 288,
                    StandartID = 1,
                    BaslikNo = "12.6",
                    Baslik = "Erişim",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 288,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 289,
                    StandartID = 1,
                    BaslikNo = "12.6.1",
                    Baslik = null,
                    Detay = "<p>Elektronik dokümanlara erişim kullanıcıların değişik arama stratejilerine uygun olacak şekilde tasarlanmalıdır. Arama stratejilerini üç temel grupta toplamak mümkündür.</p><ul><li class='ms-hover'>Doğrudan erişim: Aranan dokümanın referans numarası girilerek erişimin gerçekleştirilmesidir.</li><li class='ms-hover'>Üstveri üzerinden arama: Dokümanlar için tanımlanmış üstverilerin ve indeks terimlerinin çeşitli operatörlerin kullanılması ile taranmasıdır. </li><li class='ms-hover'>Tam metin (full-text) arama: Elektronik olarak üretilmiş veya metin haline dönüştürülmüş olan dokümanların (OCR, ICR, OMR vb sistemler ile) içeriklerinin taranmasıdır.</li></ul>",
                    UstIcerikID = 288,
                    StandartIcerikTipiID = 171,
                    SiraNo = 289,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 290,
                    StandartID = 1,
                    BaslikNo = "12.7",
                    Baslik = "Çıktı yönetimi",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 290,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 291,
                    StandartID = 1,
                    BaslikNo = "12.7.1",
                    Baslik = null,
                    Detay = "<p>Elektronik doküman yönetim sistemi içerisindeki dokümanların gerekli olduğu durumlarda çıktıları alınabilmelidir. Sistem kullanıcıların ihtiyaçlarına göre farklı formatlarda çıktılar üretebilmelidir.</p><p><b>Görüntüleme:</b> Sistem içerisindeki dokümanlar görüntülenebilmelidir. Bu işlem iki ayrı formatta gerçekleştirilebilmelidir.</p><ul><li class='ms-hover'>Orijinal format: Elektronik dokümanların üretildiği uygulama yazılımlarının formatıdır.</li><li class='ms-hover'>Standard format: Elektronik dokümanlar orijinal formatları dışında PDF, XML gibi standard formatlarda da görüntülenebilmelidir. Bu işlem gerçekleştirilirken doküman üzerinde bilgi ve format kaybının yaşanmamasına dikkat edilmelidir.</li></ul><p><b>Yazdırma:</b> Elektronik dokümanlar yazıcı ve çiziciler aracılığı ile kâğıt ortama aktarılabilmelidir.</p><p><b>Kopyalama:</b> Elektronik belgeler, EBYS dışındaki depolama üniteleri üzerine kopyalanabilmelidir.</p><p><b>İletme:</b> Elektronik dokümanlar, sistem içerisinden diğer kullanıcılara gönderilebilmelidir.</p><p><b>İş akışı:</b> Elektronik dokümanlar önceden tanımlanmış iş süreçleri çerçevesinde diğer kullanıcılara iletilebilmelidir.</p>",
                    UstIcerikID = 290,
                    StandartIcerikTipiID = 171,
                    SiraNo = 291,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 292,
                    StandartID = 1,
                    BaslikNo = "12.8",
                    Baslik = "Versiyon kontrolü",
                    Detay = null,
                    UstIcerikID = 274,
                    StandartIcerikTipiID = 168,
                    SiraNo = 292,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 293,
                    StandartID = 1,
                    BaslikNo = "12.8.1",
                    Baslik = null,
                    Detay = "<p>Sisteme dâhil edilmiş dokümanların farklı versiyonları korunabilmelidir. Versiyonların korunması iki farklı metot ile yapılabilir.</p><ul><li class='ms-hover'>Dokümana ait tüm versiyonlar ayrı bir doküman olarak düşünülür ve sisteme dâhil edilir. Ancak bir dokümana erişim sağlandığında tüm versiyonlarının varlığından kullanıcı haberdar edilir. </li><li class='ms-hover'>Dokümana ait versiyonlar orijinal dokümanın altında versiyon kronolojisi ile tutulur. Böylece kullanıcı doküman üzerindeki değişiklikleri ve bu değişikliklerin kimler tarafından ne zaman yapıldığını izleyebilir.</li></ul>",
                    UstIcerikID = 292,
                    StandartIcerikTipiID = 171,
                    SiraNo = 293,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = true,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 294,
                    StandartID = 1,
                    BaslikNo = "13",
                    Baslik = "Elektronik olmayan sistemlerle uyumluluk",
                    Detay = null,
                    UstIcerikID = 258,
                    StandartIcerikTipiID = 169,
                    SiraNo = 294,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 295,
                    StandartID = 1,
                    BaslikNo = "13.1",
                    Baslik = "Fiziksel dosya ve belgelerin sisteme dahil edilmesi",
                    Detay = null,
                    UstIcerikID = 294,
                    StandartIcerikTipiID = 168,
                    SiraNo = 295,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 296,
                    StandartID = 1,
                    BaslikNo = "13.1.1",
                    Baslik = null,
                    Detay = "EBYS, elektronik ortamda olmayan dosya ve belgelere ait tanımlama bilgilerini bünyesinde barındırabilmelidir.",
                    UstIcerikID = 295,
                    StandartIcerikTipiID = 171,
                    SiraNo = 296,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 297,
                    StandartID = 1,
                    BaslikNo = "13.1.2",
                    Baslik = null,
                    Detay = "EBYS, elektronik olmayan dosya ve belgelerle elektronik ortamdaki belgelerin aynı dosya tasnif planı içerisinde düzenlenmesine imkân tanımalıdır.",
                    UstIcerikID = 295,
                    StandartIcerikTipiID = 171,
                    SiraNo = 297,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 298,
                    StandartID = 1,
                    BaslikNo = "13.1.3",
                    Baslik = null,
                    Detay = "Kurum içerisinde tek bir saklama planı olmalı, saklama planı bulunduğu ortam ne olursa olsun tüm belgeleri kapsamalıdır",
                    UstIcerikID = 295,
                    StandartIcerikTipiID = 171,
                    SiraNo = 298,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 299,
                    StandartID = 1,
                    BaslikNo = "13.2",
                    Baslik = "Tanımlama",
                    Detay = null,
                    UstIcerikID = 294,
                    StandartIcerikTipiID = 168,
                    SiraNo = 299,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 300,
                    StandartID = 1,
                    BaslikNo = "13.2.1",
                    Baslik = null,
                    Detay = "Elektronik olmayan belgelerin tanımlanması için kullanılacak üstveriler elektronik belgelerle aynı olmalıdır. Üstveri havuzu her türlü ortamdaki belgeyi tanımlayacak nitelik ve kapsamda olmalıdır.",
                    UstIcerikID = 299,
                    StandartIcerikTipiID = 171,
                    SiraNo = 300,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 301,
                    StandartID = 1,
                    BaslikNo = "13.2.2",
                    Baslik = null,
                    Detay = "Elektronik olmayan belgelerin tanımlanmasında belgenin bulunduğu yer bilgisi olmalıdır.",
                    UstIcerikID = 299,
                    StandartIcerikTipiID = 171,
                    SiraNo = 301,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 302,
                    StandartID = 1,
                    BaslikNo = "13.3",
                    Baslik = "Erişim kontrolü ve kullanım",
                    Detay = null,
                    UstIcerikID = 294,
                    StandartIcerikTipiID = 168,
                    SiraNo = 302,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 303,
                    StandartID = 1,
                    BaslikNo = "13.3.1",
                    Baslik = null,
                    Detay = "Fiziksel dosyalara erişim, elektronik belgelerle aynı kurallara tabi olmalıdır. Not: Elektronik belgelere erişim hakları bilgisayar ortamında denetlenebilir. EBYS yazılımı erişim ile ilgili üstveri bilgilerini otomatik olarak alabilir. Ancak, fiziksel ortamdaki dosyalar için bunun belge yöneticisi tarafından yapılması gerekir. Fiziksel ortamdaki dosyaların sadece tanımlama bilgilerine erişim program aracılığı ile gerçekleştirilebilir. Fiziksel bir dosyanın herhangi bir kullanıcı tarafından talep edilmesi ve görülmesi durumunda bu aksiyona ait bilgiler elle girilebilir ya da yarı otomatik (barkod sistemleri gibi) olarak gerçekleştirilebilir.",
                    UstIcerikID = 302,
                    StandartIcerikTipiID = 171,
                    SiraNo = 303,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 304,
                    StandartID = 1,
                    BaslikNo = "13.4",
                    Baslik = "Tasfiye",
                    Detay = null,
                    UstIcerikID = 294,
                    StandartIcerikTipiID = 168,
                    SiraNo = 304,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 305,
                    StandartID = 1,
                    BaslikNo = "13.4.1",
                    Baslik = null,
                    Detay = "Fiziksel dosyaların tasfiye işlemleri de fiziksel olarak gerçekleştirilmesi gerektiği için EBYS uygun yönetim fonksiyonlarını bünyesinde barındırmalıdır.",
                    UstIcerikID = 304,
                    StandartIcerikTipiID = 171,
                    SiraNo = 305,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 306,
                    StandartID = 1,
                    BaslikNo = "13.4.2",
                    Baslik = null,
                    Detay = "EBYS, fiziksel dosyalar için transfer ve imha listeleri oluşturabilmelidir.",
                    UstIcerikID = 304,
                    StandartIcerikTipiID = 171,
                    SiraNo = 306,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 307,
                    StandartID = 1,
                    BaslikNo = "13.4.3",
                    Baslik = null,
                    Detay = "EBYS, tasfiyesi gereken fiziksel dosyaları saklama planları çerçevesinde kontrol etmeli ve belge yöneticilerini uyarabilmelidir.",
                    UstIcerikID = 304,
                    StandartIcerikTipiID = 171,
                    SiraNo = 307,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 308,
                    StandartID = 1,
                    BaslikNo = "14",
                    Baslik = "Dijital görüntüleme sistemleri",
                    Detay = null,
                    UstIcerikID = 258,
                    StandartIcerikTipiID = 169,
                    SiraNo = 308,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 309,
                    StandartID = 1,
                    BaslikNo = "14.1",
                    Baslik = "Genel rensipler",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 309,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 310,
                    StandartID = 1,
                    BaslikNo = "14.1.1",
                    Baslik = null,
                    Detay = "EBYS, dijital görüntüleme sistemleri ile elektronik ortama aktarılan fiziksel belgeleri sisteme dâhil edebilmelidir. Not: Dijital görüntüleme sistemleri (DGS), elektronik sistemler dışındaki ortamlarda üretilmiş olan bilgi kaynaklarının elektronik ortama aktarılması için kullanılan teknik ve teknolojileri içerir. Bu sistemlerde elektronik olmayan belge ve dokümanlar tarayıcılar, dijital fotoğraf makineleri ve dijital kameralar aracılığı elektronik ortama aktarılabilir. Ayrıca elektronik ortama aktarılan görüntüler OCR, ICR ve OMR gibi karakter ve işaret tanıma sistemleri ile bilgisayar sistemlerinde elektronik veri olarak kullanılabilir hale dönüştürülebilir. Çizim ve planlar gibi matris (raster image) görüntüler ise yine benzer teknik ve teknolojilerle vektör görüntü (vector graphic image) haline dönüştürülebilir ve bilgisayar ortamında kullanılabilir hale getirilebilir.",
                    UstIcerikID = 309,
                    StandartIcerikTipiID = 171,
                    SiraNo = 310,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 311,
                    StandartID = 1,
                    BaslikNo = "14.1.2",
                    Baslik = null,
                    Detay = "EBYS, dijital görüntüleme sistemleri (DGS) ile elektronik ortama aktarılmış belgeleri diğer elektronik belgelerde olduğu gibi yönetmeye yönelik fonksiyonları içermelidir.",
                    UstIcerikID = 309,
                    StandartIcerikTipiID = 171,
                    SiraNo = 311,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 312,
                    StandartID = 1,
                    BaslikNo = "14.1.3",
                    Baslik = null,
                    Detay = "Belgelerin dijital ortama aktarılması ve yönetilmesi işlemi EBYS bünyesinde bir fonksiyon olabileceği gibi üçüncü parti bir yazılım kullanılarak da gerçekleştirilebilir. Üçüncü parti bir yazılım kullanıldığı durumlarda, EBYS bu tür yazılımlarla sorunsuz olarak çalıştığını göstermelidir.",
                    UstIcerikID = 309,
                    StandartIcerikTipiID = 171,
                    SiraNo = 312,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 313,
                    StandartID = 1,
                    BaslikNo = "14.2",
                    Baslik = "Görüntülenecek malzeme",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 313,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 314,
                    StandartID = 1,
                    BaslikNo = "14.2.1",
                    Baslik = null,
                    Detay = "<p>DGS, aşağıda tarif edilen belge türlerini görüntüleyebilmelidir </p><ul><li class='ms-hover'>Basılı metin: Çeşitli tekniklerle (matbaa, bilgisayar çıktısı, vs.) kâğıt ortamda üretilmiş belge ve dokümanlar,</li><li class='ms-hover'>Basılı fotoğraf: Her türlü pozitif resimler,</li><li class='ms-hover'>Nadir eserler: Her türlü basılı ya da el yazması nadir eserler,</li><li class='ms-hover'>Haritalar</li><li class='ms-hover'>Grafik ve çizimler: Her türlü mimari, teknik ve diğer grafik ve çizimler,</li><li class='ms-hover'>Sanat eserleri: Değişik ortamlardaki iki boyutlu sanat eserleri,</li><li class='ms-hover'>Negatif fotoğraflar: Her türlü negatif resim ve dialar,</li><li class='ms-hover'>Mikro formlar: Her türlü (mikro film, mikro fiş, vs.) mikro formlar,</li></ul>",
                    UstIcerikID = 313,
                    StandartIcerikTipiID = 171,
                    SiraNo = 314,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 315,
                    StandartID = 1,
                    BaslikNo = "14.3",
                    Baslik = "Görüntüleme Tekniği",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 315,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 316,
                    StandartID = 1,
                    BaslikNo = "14.3.1",
                    Baslik = null,
                    Detay = "<p>Görüntülenen malzeme kullanım amacına uygun olarak farklı şekillerde görüntülenebilir. Değişik amaçlara hizmet etmek üzere üç ayrı görüntüleme tekniği aşağıdaki gibidir;</p><p><b>Asıl Kopya: </b>Malzemenin ana kopyası orijinaline en yakın şekilde (mastır) olarak görüntülenmelidir. Asıl kopya uzun süreli saklama ve değişik amaçlarla çoğaltmak üzere kullanılabilir. Belge niteliğinin korunması ve arşivsel değeri olan belgelerin asıl kopyası çıkarılmalıdır. Asıl kopyada olması gereken bazı özellikler şunlardır:</p><ul><li class='ms-hover'>Orijinaldeki bilgileri ve belgesel özelliklere en yakın kopyadır,</li><li class='ms-hover'>Herhangi bir sıkıştırma yapılmadan üretilir ve depolanır,</li><li class='ms-hover'>Üzerinde herhangi bir düzeltme yapılmaz,</li><li class='ms-hover'>Uzun dönemli saklama ve türevler üretmek amacına yöneliktir,</li><li class='ms-hover'>Orijinal kopyanın yerine veya yedeği olarak kullanılır,</li><li class='ms-hover'>Yüksek kaliteli bir görüntüdür,</li><li class='ms-hover'>Dosya boyutu büyüktür,</li><li class='ms-hover'>Röprodüksiyonlar için kullanılır,</li><li class='ms-hover'>Günümüz teknolojilerinde genelde sıkıştırmasız TIFF formatında saklanır.</li></ul><p><b>Kullanım Kopyası: </b>Asıl kopyadan üretilmiş ya da çekim esnasında farklı bir şekilde kaydedilmiş günlük kullanım kopyasıdır. Kullanım kopyasının temel özellikleri şunlardır:</p><ul><li class='ms-hover'>Genelde web sayfalarında asıl kopya yerine kullanılır,</li><li class='ms-hover'>Bilgisayar ekranlarına sığacak şekilde boyutlandırılmıştır,</li><li class='ms-hover'>Dosya boyutu büyük değildir,</li><li class='ms-hover'>Ağ üzerinden iletmek için uygundur,</li><li class='ms-hover'>Bilgi ve araştırma amaçlı görüntülemek için kabul edilebilir kalitedir,</li><li class='ms-hover'>Hızlı erişim için sıkıştırılmıştır,</li><li class='ms-hover'>Genelde JPEG formatında saklanır.</li></ul><p><b>Mini Kopya:</b> Görüntünün küçültülmüş halidir. Aşağıdaki özellikleri taşır:</p><ul><li class='ms-hover'>Genelde bibliyografik amaçla kullanılır,</li><li class='ms-hover'>Kullanıcının görüntüyü açmadan ya da bilgisayarına indirmeden önce içeriği hakkında bilgi verir, </li><li class='ms-hover'>Genelde GIF ya da JPEG formatında saklanır,</li><li class='ms-hover'>Metin içeren belgeler için uygun değildir.</li></ul>",
                    UstIcerikID = 315,
                    StandartIcerikTipiID = 171,
                    SiraNo = 316,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 317,
                    StandartID = 1,
                    BaslikNo = "14.4",
                    Baslik = "Çözünürlük",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 317,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 318,
                    StandartID = 1,
                    BaslikNo = "14.4.1",
                    Baslik = null,
                    Detay = "<div>Asıl kopya için çözünürlük Çizelge 1’deki olmalıdır. Kullanım kopyası ve mini kopya için bağlayıcı bir değer bulunmayıp kurumsal ihtiyaçlar dikkate alınmalıdır.</div><div><br></div><div>Not: Çözünürlüğü ifade etmek için genelde iki ayrı terim kullanılır.<br><br></div><div>Bunlar:</div><ul><li class='ms-hover'>DPI (Dots Per Inch): Görüntülenen malzemenin yeniden baskı çıktısı alındığındaki çözünürlük yoğunluğunu ifade eder.</li><li class='ms-hover'>PPI (Pixels Per Inch): Görüntülenen malzemenin tarama esnasında hangi yoğunlukta taranacağını ve bilgisayar ekranında hangi çözünürlükte görüntüleneceğini ifade eder.</li></ul>",
                    UstIcerikID = 317,
                    StandartIcerikTipiID = 171,
                    SiraNo = 318,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 319,
                    StandartID = 1,
                    BaslikNo = "14.5",
                    Baslik = "Tonlama / Bit derinliği / Tarama modu",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 319,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 320,
                    StandartID = 1,
                    BaslikNo = "14.5.1",
                    Baslik = null,
                    Detay = "<p>Asıl kopyalar için öngörülen tonlama özellikleri Çizelge 2’deki gibi olmalıdır.</p><p>Not: Görüntülenecek malzeme türüne ve belgesel niteliklerine göre üç ayrı şekilde tonlanabilir. Bunlar</p><ul><li class='ms-hover'><b>Siyah / Beyaz (Bitonal):</b> Tek bit ile temsil edilen tonlama türüdür.</li><li class='ms-hover'><b>Gri tonlama (Gray Scale):</b> 8 bit ile temsil edilen tonlama türüdür.</li><li class='ms-hover'><b>Renkli (Color):</b> Genelde 24 bit ile temsil edilen renk ayrımlı tonlama türüdür.</li></ul>",
                    UstIcerikID = 319,
                    StandartIcerikTipiID = 171,
                    SiraNo = 320,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 321,
                    StandartID = 1,
                    BaslikNo = "14.6",
                    Baslik = "Sıkıştırma",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 321,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 322,
                    StandartID = 1,
                    BaslikNo = "14.6.1",
                    Baslik = null,
                    Detay = "<p>Sıkıştırma işlemi asıl kopya görüntüler üzerinde uygulanmamalıdır. Kullanım kopyası ve mini kopyalar sıkıştırma işlemine tabi tutulabilir.</p><p>Not: Görüntülenen malzeme görüntüleme esnasında ya da depolama esnasında sıkıştırılabilir. Bu işlem görüntü dosyalarının daha az yer kaplamasını ve kullanım kolaylığı sağlar. Sıkıştırma işlemi görüntü formatlarına göre farklı şekillerde uygulanabilir:</p><ul><li class='ms-hover'><b>Sıkıştırmasız görüntüleme: </b>Görüntülenen malzeme herhangi bir sıkıştırma işlemine tabi tutulmaz.</li><li class='ms-hover'><b>Veri kaybına yol açmayan sıkıştırma: </b>Görüntüleme işlemi sırasında sıkıştırma yapılır ancak bu işlem verikaybına neden olmaz.</li><li class='ms-hover'><b> Veri kaybına yol açan sıkıştırma: </b>Sıkıştırma işlemi sırasında insan gözüyle fark edilmese bile veri kaybına neden olan görüntüleme metodudur.</li></ul>",
                    UstIcerikID = 321,
                    StandartIcerikTipiID = 171,
                    SiraNo = 322,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 323,
                    StandartID = 1,
                    BaslikNo = "14.7",
                    Baslik = "Zenginleştirme",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 323,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 324,
                    StandartID = 1,
                    BaslikNo = "14.7.1",
                    Baslik = null,
                    Detay = "<p>Asıl kopya görüntüler üzerinde herhangi bir zenginleştirme işlemi yapılmamalıdır. Kullanım kopyası ve mini kopyalar sıkıştırma</p><p>işlemine tabi tutulabilir.</p><p>Not: Görüntülenen malzeme dijital teknolojinin sağladığı imkânlarla zenginleştirilebilir. Bu işlem görüntülenen malzemenin bilgisel ve belgesel özelliklerine zarar vermeyecek şekilde uygulanmalıdır. Zenginleştirme işlemi genel bir kavram olup değişik metot ve teknikleri içermektedir. Bunlardan bazıları şunlardır:</p><ul><li class='ms-hover'>Görüntünün keskinleştirilmesi,</li><li class='ms-hover'>Görüntü üzerindeki leke ve noktaların ayıklanması,</li><li class='ms-hover'>Gri veya renkli tonların görüntünün tamamına homojen olarak dağıtılması,</li><li class='ms-hover'>Görüntü etrafındaki gereksiz boşlukların tıraşlanması,</li><li class='ms-hover'>Renkler arasındaki zıtlıkların belirginleştirilmesi,</li><li class='ms-hover'>Görüntü bozukluklarının giderilmesi.</li></ul>",
                    UstIcerikID = 323,
                    StandartIcerikTipiID = 171,
                    SiraNo = 324,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 325,
                    StandartID = 1,
                    BaslikNo = "14.8",
                    Baslik = "Renk yönetimi",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 325,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 326,
                    StandartID = 1,
                    BaslikNo = "14.8.1",
                    Baslik = null,
                    Detay = "Görüntülenen malzeme için hangi renk profilinin kullanıldığı gösterilmelidir. Not: Renkli görüntüleme işlemi ekipman ve uzman personel maliyetleri açısından en pahalı olanıdır. Bu işlem sırasında renklerin orijinale uygun olmasına özen gösterilmelidir. Renkli görüntüleme işlemi sırasında uluslararası standardlara uygun renk profilleri tercih edilmelidir. Renk profilleri genelde çeşitli firmaların kendi adlarına tescil ettirdikleri şemalardan oluşur. Ancak genel bir standard olarak International Color Consortium (ICC) tarafından geliştirilen renk profilleri kullanılabilir.",
                    UstIcerikID = 325,
                    StandartIcerikTipiID = 171,
                    SiraNo = 326,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 327,
                    StandartID = 1,
                    BaslikNo = "14.9",
                    Baslik = "Dosya Formatları",
                    Detay = null,
                    UstIcerikID = 308,
                    StandartIcerikTipiID = 168,
                    SiraNo = 327,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 328,
                    StandartID = 1,
                    BaslikNo = "14.9.1",
                    Baslik = null,
                    Detay = "Seçilen dosya formatının açık kaynak kodlu olmasına özen gösterilmelidir. Alternatif olarak uluslararası kabul görmüş, endüstri standardı niteliği taşıyan formatlar seçilmelidir. Not: Çeşitli firmalara tescilli formatlar sorun çıkarabilir. Görüntülenen malzemenin saklama formatı gelecekte malzemeye erişim ve teknolojik yeniliklere terfi açısından son derece önemlidir. Format seçimi yapılırken birçok unsur göz önünde bulundurulmalıdır. Bunlardan bazıları aşağıdaki maddelerde sıralamıştır. Mevcut görüntü formatlarının en yaygın olanlarının özelliklerinin karşılaştırması için Çizelge 3’e bakılmalıdır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 328,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 329,
                    StandartID = 1,
                    BaslikNo = "14.9.2",
                    Baslik = null,
                    Detay = "Dosya formatı iyi bir dokümantasyona sahip olmalıdır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 329,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 330,
                    StandartID = 1,
                    BaslikNo = "14.9.3",
                    Baslik = null,
                    Detay = "Dosya formatı eski versiyonları sorunsuz okuyabilmelidir.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 330,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 331,
                    StandartID = 1,
                    BaslikNo = "14.9.4",
                    Baslik = null,
                    Detay = "Seçilecek format Electronic Document Interchange Format (EDIF) gibi çeşitli dosya değişim formatlarını desteklemelidir.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 331,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 332,
                    StandartID = 1,
                    BaslikNo = "14.9.5",
                    Baslik = null,
                    Detay = "24 bitten yüksek tonlama özelliğine sahip olmalıdır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 332,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 333,
                    StandartID = 1,
                    BaslikNo = "14.9.6",
                    Baslik = null,
                    Detay = "Veri sıkıştırma (kayıplı ve kayıpsız) olanaklarına sahip olmalıdır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 333,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 334,
                    StandartID = 1,
                    BaslikNo = "14.9.7",
                    Baslik = null,
                    Detay = "ICC gibi çeşitli renk yönetimi profillerine sahip olmalıdır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 334,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 335,
                    StandartID = 1,
                    BaslikNo = "14.9.8",
                    Baslik = null,
                    Detay = "Asıl, kullanım ve mini görüntü kopyaları oluşturmak için farklı çözünürlük seçenekleri bulunmalıdır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 335,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 336,
                    StandartID = 1,
                    BaslikNo = "14.9.9",
                    Baslik = null,
                    Detay = "Görüntü ile birlikte çeşitli üstveri bilgilerini kayıt edebilecek nitelikte olmadır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 336,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 337,
                    StandartID = 1,
                    BaslikNo = "14.9.10",
                    Baslik = null,
                    Detay = "Görüntü ile görüntüye ait üstveriler arasında ilişki kurabilme özelliğine sahip olmalıdır.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 337,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 338,
                    StandartID = 1,
                    BaslikNo = "14.9.11",
                    Baslik = null,
                    Detay = "Görüntü üstverilerinin tutulabileceği harici kaynaklara bağlanabilmeli ya da harici kaynaklarla entegre çalışabilmelidir.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 338,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 339,
                    StandartID = 1,
                    BaslikNo = "14.9.12",
                    Baslik = null,
                    Detay = "Donanım veya yazılım bağımlı olmamalıdır. Farklı bilgisayar sistemlerinde çalışabilmelidir.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 339,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 340,
                    StandartID = 1,
                    BaslikNo = "14.9.13",
                    Baslik = null,
                    Detay = "Veri kayıplarını ve görüntüleme hatalarını rapor edebilmelidir.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 340,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 341,
                    StandartID = 1,
                    BaslikNo = "14.9.14",
                    Baslik = null,
                    Detay = "Görüntünün üzerinde yapılabilecek değişiklikleri kayıt altına almalı ve gerektiğinde görüntüye müdahale edilmesini engelleyebilmelidir.",
                    UstIcerikID = 327,
                    StandartIcerikTipiID = 171,
                    SiraNo = 341,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 342,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "Bölüm III: Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM)",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 164,
                    SiraNo = 342,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 343,
                    StandartID = 1,
                    BaslikNo = "15",
                    Baslik = "Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM)",
                    Detay = null,
                    UstIcerikID = 342,
                    StandartIcerikTipiID = 169,
                    SiraNo = 343,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 344,
                    StandartID = 1,
                    BaslikNo = "15.1",
                    Baslik = "Arşiv Malzemesinin tanımı ve özellikleri",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 344,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 345,
                    StandartID = 1,
                    BaslikNo = "15.1.1",
                    Baslik = null,
                    Detay = "<div>Arşiv malzemesinin tanımı </div><div>Arşiv malzemesi kavramı farklı amaçlarla kullanılabilen bir kavramdır. Arşiv malzemesinin mülkiyetini elinde bulunduran özel veya tüzel kişilerin amaçlarına göre ya da arşiv malzemesini oluşturan belge formlarına göre farklı tanımlamalar yapılabilir. ELAS/RM arşiv malzemesi kavramını en geniş tanımıyla ele alır. Bu bağlamda aşağıda tanımlanan ancak bunlarla sınırlı olmayan arşiv malzemesi tanımları ELAS/RM kapsamında yönetilebilmelidir. Arşiv malzemesi:</div><div><br></div><div>a) Özel veya kamu kurumlarının faaliyetleri sırasında alınan ya da üretilen; kanıt değeri ya da idarî, hukukî, malî ve/veya tarihî bilgi değeri taşıdığı için saklanmasına karar verilen, genel olarak güncel olmayan her türlü belgeyi,<br><br></div><div>b) Belli bir amaç ve bütünlük içerisinde derlenmiş her türlü;</div><div>&nbsp;&nbsp;&nbsp;&nbsp;i. Ses ve görüntü kayıtlarını,</div><div>&nbsp;&nbsp;&nbsp;&nbsp;ii. Mikro form kayıtlarını,</div><div>&nbsp;&nbsp;&nbsp;&nbsp;iii. Harita, plan, çizim ve benzeri kartografik malzemeyi,</div><div>&nbsp;&nbsp;&nbsp;&nbsp;iv. Elektronik ortamda üretilmiş belge ve dosyaları ifade eder.</div>",
                    UstIcerikID = 344,
                    StandartIcerikTipiID = 171,
                    SiraNo = 345,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 346,
                    StandartID = 1,
                    BaslikNo = "15.1.2",
                    Baslik = null,
                    Detay = "<p>Arşiv malzemesinin özellikleri Arşiv malzemesinin ELAS/RM içerisinde tanımlanabilmesinde aşağıdaki özniteliklerin varlığına özellikle dikkat edilmelidir.</p><p>a) Erişilebilirlik: Arşiv malzemesi fiziksel ve idarî açıdan erişilebilir olmalıdır. Bu bağlamda:</p><p>&nbsp;&nbsp;&nbsp;&nbsp;i. Arşiv malzemesine erişim yetkileri tanımlanmış olmalıdır</p><p>&nbsp;&nbsp;&nbsp;&nbsp;ii. Saklama üniteleri güncel teknolojilerle okunabilir olmalıdır</p><p>&nbsp;&nbsp;&nbsp;&nbsp;iii. Dosya formatları güncel uygulamalarda belge bütünlüğüne zarar vermeden kullanıma uygun olmalıdır.</p><p>b) Tanımlanabilirlik: Arşiv malzemesi ELAS/RM sistemi içerisinde hem bağımsız hem de bağlantılı olarak tanımlanabilir olmalıdır. Bu bağlamda arşiv malzemesine ait:</p><p>&nbsp;&nbsp;&nbsp;&nbsp;i. Kimlik bilgisi: referans numarası, varsa adı ve diğer ayırıcı özellikleri,</p><p>&nbsp;&nbsp;&nbsp;&nbsp;ii. Aidiyet bilgisi: üretim sorumlu kişi veya kurumları,</p><p>&nbsp;&nbsp;&nbsp;&nbsp;iii. Form özellikleri: üretim formatı ve/veya belge türü,</p><p>&nbsp;&nbsp;&nbsp;&nbsp;iv. Tarih ve/veya zaman bilgisi tanımlanabilir olmalıdır.</p><p>c) Bütünlük: Arşiv malzemesinin içerdiği bilgi, kurumsal idiyeti ile cari olduğu dönemdeki belge ve sunumformatı her türlü değişiklikten ve müdahaleden korunmuş olmalıdır. ELAS/RM içerisinde bütünlüğün korunmasının devamı sağlanmalıdır.</p>",
                    UstIcerikID = 344,
                    StandartIcerikTipiID = 171,
                    SiraNo = 346,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 347,
                    StandartID = 1,
                    BaslikNo = "15.2",
                    Baslik = "Arşiv politikasını belirlenmesi",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 347,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 348,
                    StandartID = 1,
                    BaslikNo = "15.2.1",
                    Baslik = null,
                    Detay = "Arşiv kurumları ve kurumsal arşivler öncelikle ne tür malzemeleri transfer edeceklerini ve hangi hizmet koşullarında kullanıma açacaklarını belirten bir kurum politikası geliştirmelidir. Bu politika dokümanı arşiv kurumlarının mevzuat ile kendilerine verilmiş olan yetkilerine atıfta bulunmalı ve arşiv malzemesi üreten kurumlarla olan ilişkilerini açık bir şekilde ifade etmelidir.",
                    UstIcerikID = 347,
                    StandartIcerikTipiID = 171,
                    SiraNo = 348,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 349,
                    StandartID = 1,
                    BaslikNo = "15.3",
                    Baslik = "Arşiv malzemesinin transfer işlemleri",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 349,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 350,
                    StandartID = 1,
                    BaslikNo = "15.3.1",
                    Baslik = null,
                    Detay = "<p>Arşiv kurumlarına ya da kurumsal arşivlere transfer edilebilecek malzemeler aşağıdaki yöntemlerle gerçekleştirilir. </p><ul><li class='ms-hover'>Elektronik ortamda üretilmiş her türlü belge, doküman ve kayıtların güncel oldukları dönemdeki içerik, format ve sunum özellikleri korunarak AYS’ne aktarılmalıdır. Elektronik belge, doküman ya da kayıtların bir elektronik belge yönetim &nbsp;sisteminin (EBYS) parçası olduğu durumlarda bunlar ilgili üstveri ile birlikte aktarılmalıdır. Otomatik olarak aktarılan belge, doküman ve kayıtlara ilişkin üstveri verileri ELAS/RM tarafından öngörülen tanımlama kriterlerini karşılayacak nitelikte olmalıdır.</li><li class='ms-hover'>Herhangi bir EBYS’nin parçası olmayan, bağımsız olarak üretilmiş elektronik belge, doküman ve kayıtlar AYS’ne aktarılabilir. Bu durumda da AYS içerisine aktarılan elektronik arşivlerin tanımlanması için ELAS/RM’nin öngördüğü üstverinin bulunması şarttır.</li><li class='ms-hover'>Dijital formatta üretilmiş her türlü ses ve görüntü kayıtları AYS’ne dijital ortamda aktarılabilir. Bu aktarım sırasında her kayıt türü için ELAS/RM tarafından öngörülen üstverinin kayıtlarla birlikte aktarılması veya kayıt esnasında sisteme girilmesi esastır. </li><li class='ms-hover'>Fiziksel ortamda üretilmiş belge ve dokümanlar ile analog sistemlerde üretilmiş resim, ses ve görüntü kayıtları sayısallaştırma yöntemi ile AYS içerisine aktarılabilir. Sayısallaştırma işlemi AYS’nin bir fonksiyonu olabileceği gibi üçüncü parti sayısallaştırma sistemleri ile de yapılabilir. Ancak sayısallaştırılan arşiv malzemesinin ELAS/RM tarafından öngörülen standartlara uygun olması şarttır.</li></ul>",
                    UstIcerikID = 349,
                    StandartIcerikTipiID = 171,
                    SiraNo = 350,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 351,
                    StandartID = 1,
                    BaslikNo = "15.4",
                    Baslik = "Tarih ve zaman damgası",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 351,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 352,
                    StandartID = 1,
                    BaslikNo = "15.4.1",
                    Baslik = null,
                    Detay = "AYS içerisine aktarılan her türlü belge, doküman ve kayıt aktarım esnasında tarih ve zaman damgası almalıdır. Tarih ve zaman damgası AYS sistemine entegre edilmiş bir sistem tarafından üretilebileceği gibi elektronik ve mobil imza sistemleri ile de üretilebilir. ELAS/RM açısından tarih ve zaman damgasının varlığı ve değiştirilemez olması esastır. Tarih ve zaman damgası TS ISO 8601 standardına uygun olmalıdır.",
                    UstIcerikID = 351,
                    StandartIcerikTipiID = 171,
                    SiraNo = 352,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 353,
                    StandartID = 1,
                    BaslikNo = "15.5",
                    Baslik = "Dosya formatları",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 353,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 354,
                    StandartID = 1,
                    BaslikNo = "15.5.1",
                    Baslik = null,
                    Detay = "AYS içerisine aktarılan her türlü belge, doküman ve kayıtlar güncel oldukları dönemdeki içerik, format ve sunum özellikleri korunarak saklanmalıdır. Bu bağlamda arşivleme için seçilecek dosya formatlarının bütünlük, erişilebilirlik ve güvenlik ile ilgili özelliklerini koruyacak nitelikte olması gerekir. Ayrıca elektronik arşiv belgelerinin uzun dönemli veya sürekli saklanacağı düşünülerek dosya formatlarının zaman içerisinde değişebileceği ve yeni formatlara aktarım yapılabileceği göz önünde bulundurulmalıdır. Kullanılacak dosya formatlarının seçiminde Birlikte Çalışabilirlik Esasları Rehberi1 referans alınmalıdır.",
                    UstIcerikID = 353,
                    StandartIcerikTipiID = 171,
                    SiraNo = 354,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 355,
                    StandartID = 1,
                    BaslikNo = "15.6",
                    Baslik = "Depolama Üniteleri",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 355,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 356,
                    StandartID = 1,
                    BaslikNo = "15.6.1",
                    Baslik = null,
                    Detay = "<p>Elektronik arşiv malzemesinin uzun süreli veya sürekli olarak saklanmasına imkân sağlayacak depolama ünitelerinin seçiminde arşiv malzemesinin özniteliklerinin korunması ve arşiv kurumlarının operasyonel ihtiyaçlarına cevap verebilecek ürünlerin seçilmesi gerekmektedir. Bu bağlamda depolama ünitelerinin değerlendirilmesinde aşağıdaki bilgiler göz önünde bulundurulmalıdır.</p><p>i) Taşınabilir depolama üniteleri: Genel olarak bir bilgisayar sisteminin disk sürücüsüne takılabilen ve üzerindeki kayıtlı bilginin kullanımına imkân sağlayan depolama üniteleridir. Güncel olarak manyetik veya optik teknolojiler kullanılarak üretilmiş ürünlerdir. Taşınabilir depolama üniteleri üzerindeki verilerin değiştirilmesine imkân veren (rewritable) üniteleri ile üzerindeki verinin silinmesine ya da değiştirilmesine imkan tanımayan (Physical WORM) olmak üzere iki farklı şekilde üretilmektedir.</p><p>ii) Sabit depolama üniteleri: Bir bilgisayar sistemi ile bütünleşik olarak kullanılan depolama üniteleridir. Genelolarak manyetik teknolojiler kullanılarak üretilirler. Sabit depolama üniteleri üzerindeki verinin değiştirilmesine ve silinmesine imkân sağlar. Ancak bu üniteler üzerindeki verinin silinmesini veya değiştirilmesinin önleyecek şekilde mantıksal sadece okunabilir şekilde (Logical WORM) veri yüklemek mümkündür.</p>",
                    UstIcerikID = 355,
                    StandartIcerikTipiID = 171,
                    SiraNo = 356,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 357,
                    StandartID = 1,
                    BaslikNo = "15.7",
                    Baslik = "Veri merkezi özellikleri",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 357,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 358,
                    StandartID = 1,
                    BaslikNo = "15.7.1",
                    Baslik = null,
                    Detay = "Uzun süreli veya sürekli saklanacak olan elektronik arşiv malzemesinin saklanması için oluşturulacak olan depolama alanlarının veya veri merkezlerinin erişim ve güvenlik önlemleri açısından ulusal ve uluslararası standartlara uygun olması gerekir. Veri merkezlerinin asgari TIER 32 seviyesi standartlarına veya muadil ulusal standartlara uygunluğu karşılaması sağlanmalıdır. Muadil ulusal standartların neler olacağına yetkili sertifikasyon kurumu karar verir.",
                    UstIcerikID = 357,
                    StandartIcerikTipiID = 171,
                    SiraNo = 358,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 359,
                    StandartID = 1,
                    BaslikNo = "15.8",
                    Baslik = "Erişimin sürekliliği",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 359,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 360,
                    StandartID = 1,
                    BaslikNo = "15.8.1",
                    Baslik = null,
                    Detay = "Elektronik arşiv malzemeleri internet ortamında hizmete sunulabileceği gibi yerel ağlar üzerinden sınırlı mekânlarda ya da arşiv kurumlarının okuma salonlarındaki terminallerden erişilebilir şekilde hizmete sunulabilir. AYS bünyesinde hizmete sunulan elektronik arşiv malzemesin erişimin kesintiye uğramaması için gerekli idarî, çevresel ve teknolojik tedbirler alınmalıdır.",
                    UstIcerikID = 359,
                    StandartIcerikTipiID = 171,
                    SiraNo = 360,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 361,
                    StandartID = 1,
                    BaslikNo = "15.8.2",
                    Baslik = null,
                    Detay = "Elektronik arşiv malzemesine erişimin hangi kanallar üzerinden sağlanacağı arşiv kurumlarının yönetimi tarafından hazırlanacak yönergelerle düzenlenmelidir.",
                    UstIcerikID = 359,
                    StandartIcerikTipiID = 171,
                    SiraNo = 361,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 362,
                    StandartID = 1,
                    BaslikNo = "15.8.3",
                    Baslik = null,
                    Detay = "Elektronik arşiv malzemesinin uzun süreli veya sürekli korunmasını sağlayacak çevresel faktörler dikkate alınarak gerekli düzenlemeler yapılmalıdır.",
                    UstIcerikID = 359,
                    StandartIcerikTipiID = 171,
                    SiraNo = 362,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 363,
                    StandartID = 1,
                    BaslikNo = "15.8.4",
                    Baslik = null,
                    Detay = "Elektronik arşiv malzemelerinin güncel teknolojilerle erişilebilirliğini sağlayacak önlemler alınmalıdır.",
                    UstIcerikID = 359,
                    StandartIcerikTipiID = 171,
                    SiraNo = 363,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 364,
                    StandartID = 1,
                    BaslikNo = "15.9",
                    Baslik = "Teknolojik eskimeye karşı alınacak önlemler",
                    Detay = null,
                    UstIcerikID = 343,
                    StandartIcerikTipiID = 168,
                    SiraNo = 364,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 365,
                    StandartID = 1,
                    BaslikNo = "15.9.1",
                    Baslik = null,
                    Detay = "Elektronik ortamda korunan bilgi, belge ve arşiv malzemesinin karşı karşıya olduğu en önemli tehditlerin başında teknolojik eskime gelmektedir. Elektronik arşiv malzemelerinin uzun süreli veya sürekli korunması için seçilen dosya formatları ile arşiv malzemesinin saklandığı depolama ünitelerinin güncel teknolojilerle erişilebilir ve okunabilir olması gerekir. Bu bağlamda arşiv malzemesinin güncel depolama ünitelerine aktarımının ve/veya dosya formatlarının güncel okunabilir formatlara dönüşümünün gerekli olabileceği göz önünde bulundurulmalıdır. Bünyesinde elektronik arşiv malzemesi bulunduran kurumlar bu malzemelerin teknolojik eskimeye karşı korunması için gerekli önlemleri almalı ve bunları kurumsal dönüşüm stratejisi olarak kayıt altına almalıdır.",
                    UstIcerikID = 364,
                    StandartIcerikTipiID = 171,
                    SiraNo = 365,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 366,
                    StandartID = 1,
                    BaslikNo = "16",
                    Baslik = "Arşiv sisteminin Güvenliği",
                    Detay = null,
                    UstIcerikID = 342,
                    StandartIcerikTipiID = 169,
                    SiraNo = 366,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 367,
                    StandartID = 1,
                    BaslikNo = "16.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikID = 366,
                    StandartIcerikTipiID = 168,
                    SiraNo = 367,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 368,
                    StandartID = 1,
                    BaslikNo = "16.1.1",
                    Baslik = null,
                    Detay = "ELAS/RM, sistem ve veri güvenliği açısından endüstri uygulamalarına ve uluslararası standartlara uygun düzenlemeleri barındırmalıdır. Güvenlik konuları kurumsal politika belgelerinde yer almalı ve uygulaması denetlenmelidir. Kurumlara bilgi sistemlerinin güvenliği ile ilgili olarak ISO 27001 ve bağlantılı standartlara uygun tedbirleri almaları önerilmelidir. Ayrıca, EBYS ve ELAS/RM uyumlu sistemler 2013/4890 sayılı Bakanlar Kurulu Kararı doğrultusunda yayımlanan 20 Haziran 2013 tarihli ve 28683 sayılı Resmi Gazetede yayımlanarak yürürlüğe giren Ulusal Siber Güvenlik Stratejisi ve Eylem Planı kapsamında TSE tarafından geliştirilen Elektronik Doküman ve Belge Yönetim Sistemi TSE-CCCS-PP-003 numaralı Koruma Profiline uyumlu TS ISO/IEC 15408: Ortak Kriterler standardından EAL 2 sertifikasına sahip veya Koruma Profiline uyumlu Temel Seviye Güvenlik sertifikasına sahip olmalıdır. Ancak, güvenlik konuları ile ilgili olarak aşağıdaki unsurlarla sınırlı olmamak üzere optimum tedbirler alınmalıdır. EBYS, seçilmiş arşiv belgelerinin test edilmiş ve belgelendirilmiş şifreleme sistemleri ile şifrelenmiş olarak saklanmasına imkan tanıyacak altyapıyı bünyesinde barındırmalıdır.",
                    UstIcerikID = 367,
                    StandartIcerikTipiID = 171,
                    SiraNo = 368,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 369,
                    StandartID = 1,
                    BaslikNo = "16.2",
                    Baslik = "Sistem Güvenliği",
                    Detay = null,
                    UstIcerikID = 366,
                    StandartIcerikTipiID = 168,
                    SiraNo = 369,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 370,
                    StandartID = 1,
                    BaslikNo = "16.2.1",
                    Baslik = null,
                    Detay = "<p>Fiziksel güvenlik: Arşiv kurumlarının depo ve kullanıcılara açık alanlarının fizikî güvenliği ile ilgili tedbirlerin alınması gereklidir. Bu bağlamda:</p><p>i) Depo alanlarının ve kullanıcıların alanlarının giriş yetkileri tanımlanmalı ve denetlenmelidir.</p><p>ii) Arşiv kurumların fiziksel alanlarının tamamı alarm sistemleri ile donatılmalıdır</p><p>iii) Doğal afetlere karşı gerekli tedbirler alınmalıdır./p>",
                    UstIcerikID = 369,
                    StandartIcerikTipiID = 171,
                    SiraNo = 370,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 371,
                    StandartID = 1,
                    BaslikNo = "16.2.2",
                    Baslik = null,
                    Detay = "<p>Donanım güvenliği: Arşiv kurumlarında kullanılan her türlü bilgisayar ve ağ sistemleri ile depolama ünitelerinin kullanım ve bakımı ile ilgili güvenlik tedbirleri alınmalıdır. Bu bağlamda:</p><p>i) Bilgisayar ve ağ sistemlerine giriş yetkilerinin tanımlanması ve giriş – çıkış kayıtlarının tutulması gereklidir.</p><p>ii) Depolama ünitelerinin kullanımı, çoğaltılması ve imhası yetkiler dâhilinde gerçekleştirilmeli ve uygulamalar kayıt altına alınmalıdır.</p><p>iii) Yedekleme sistemleri kurulmalı ve çalışır durumda olduğu periyodik olarak denetlenmelidir.</p>",
                    UstIcerikID = 369,
                    StandartIcerikTipiID = 171,
                    SiraNo = 371,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 372,
                    StandartID = 1,
                    BaslikNo = "16.2.3",
                    Baslik = null,
                    Detay = "<p>Yazılım sistemlerinin ve verilerin güvenliğini tehdit edebilecek unsurlara karşı önlemler alınmalıdır. Bu bağlamda:</p><p>i)Yazılımlara ve verilere erişim yetkileri tanımlanmalı ve uygulamalar kayıt altına alınmalıdır.</p><p>ii) Yazılımlara ve verilere yetkisiz erişim denemeleri rapor edilmeli ve gerekli araştırmalar yapılmalıdır.</p><p>iii) Verilerin bilerek ya da kaza ile değiştirilmesine veya silinmesine karşı önlemler alınmalıdır.</p>",
                    UstIcerikID = 369,
                    StandartIcerikTipiID = 171,
                    SiraNo = 372,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 373,
                    StandartID = 1,
                    BaslikNo = "16.2.4",
                    Baslik = null,
                    Detay = "<p>AYS, Arşiv malzemesinin arşiv kurumlarında kimler tarafından, ne zaman sorgulandığının ve kullanıldığının kayıt altına alınmasına yönelik fonksiyonları yönetmek üzere:</p><p>a) Arşiv kullanıcılarını kayıt altına almaya yönelik bir sistemi bünyesinde barındırması</p><p>b) Kayıtlı kullanıcıların arşiv malzemesini nasıl kullandıklarının (görme, kopya üretme, referans verme) kayıt altına alınması ile ilgili bilgilerin yönetilmesine yönelik fonksiyonları içermelidir.</p>",
                    UstIcerikID = 369,
                    StandartIcerikTipiID = 171,
                    SiraNo = 373,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = false,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 374,
                    StandartID = 1,
                    BaslikNo = "16.3",
                    Baslik = "Bilgi Güvenliği",
                    Detay = null,
                    UstIcerikID = 366,
                    StandartIcerikTipiID = 168,
                    SiraNo = 374,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 375,
                    StandartID = 1,
                    BaslikNo = "16.3.1",
                    Baslik = null,
                    Detay = "Orijinallik: Belgelerin üretildiği dönemdeki içerik, ilişki ve sunum özelliklerinin korunması için gerekli tedbirlerin alınması gereklidir.",
                    UstIcerikID = 374,
                    StandartIcerikTipiID = 171,
                    SiraNo = 375,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 376,
                    StandartID = 1,
                    BaslikNo = "16.3.2",
                    Baslik = null,
                    Detay = "Bütünlük: Belgelerin üretildiği dönemdeki dosya bütünlüğü ve ekleri ile birlikte korunması sağlanmalıdır.",
                    UstIcerikID = 374,
                    StandartIcerikTipiID = 171,
                    SiraNo = 376,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 377,
                    StandartID = 1,
                    BaslikNo = "16.3.3",
                    Baslik = null,
                    Detay = "İlgi: Belgelerin üretildiği dönemdeki kurumsal ve fonksiyonel ilgileri ile birlikte kayıt altına alınması ve korunması sağlanmalıdır.",
                    UstIcerikID = 374,
                    StandartIcerikTipiID = 171,
                    SiraNo = 377,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 378,
                    StandartID = 1,
                    BaslikNo = "16.4",
                    Baslik = "Sistem Denetimi",
                    Detay = null,
                    UstIcerikID = 366,
                    StandartIcerikTipiID = 168,
                    SiraNo = 378,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 379,
                    StandartID = 1,
                    BaslikNo = "16.4.1",
                    Baslik = null,
                    Detay = "Elektronik arşiv yönetim sistemleri tüm çalışanların, kullanıcıların ve sistemde hizmete sunulan belgelerin sistem üzerindeki tüm hareketlerini kayıt altına almalı ve gerektiğinde raporlayabilmelidir. Bu bağlamda:",
                    UstIcerikID = 378,
                    StandartIcerikTipiID = 171,
                    SiraNo = 379,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 380,
                    StandartID = 1,
                    BaslikNo = "16.4.2",
                    Baslik = null,
                    Detay = "Çalışanların sisteme giriş – çıkışları ve sistemdeki hareketleri (sorgulama, çoğaltma, düzeltme, değiştirme, silme, raporlama, vs.) kayıt altına alınmalıdır.",
                    UstIcerikID = 378,
                    StandartIcerikTipiID = 171,
                    SiraNo = 380,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 381,
                    StandartID = 1,
                    BaslikNo = "16.4.3",
                    Baslik = null,
                    Detay = "Kullanıcıların sistem giriş – çıkışları ve kullandıkları belgeler ile ilgili tüm hareketler (görme, çoğaltma, referans verme, vs.) kayıt altına alınmadır.",
                    UstIcerikID = 378,
                    StandartIcerikTipiID = 171,
                    SiraNo = 381,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 382,
                    StandartID = 1,
                    BaslikNo = "16.4.4",
                    Baslik = null,
                    Detay = "Sistemdeki tüm belgeler üzerindeki tüm çalışan ve kullanıcı hareketleri, sisteme giriş aşamasından başlayarak kayıt altına alınmalıdır. Çalışanlar tarafından uygulanan yönetimsel fonksiyonlar (düzenleme, tanımlama, indeksleme, vs.) ile kullanıcıları aktiviteleri (görme, çoğaltma, referans verme, vs.) bu kapsamda ele alınmalıdır.",
                    UstIcerikID = 378,
                    StandartIcerikTipiID = 171,
                    SiraNo = 382,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 383,
                    StandartID = 1,
                    BaslikNo = "17",
                    Baslik = "ELAS/RM Uygulama Kılavuzu",
                    Detay = null,
                    UstIcerikID = 342,
                    StandartIcerikTipiID = 169,
                    SiraNo = 383,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 384,
                    StandartID = 1,
                    BaslikNo = "17.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikID = 383,
                    StandartIcerikTipiID = 168,
                    SiraNo = 384,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 385,
                    StandartID = 1,
                    BaslikNo = "17.1.1",
                    Baslik = null,
                    Detay = "Bu bölüm fiziksel, elektronik veya diğer formatlardaki arşiv malzemesinin arşiv kurumlarına transferi öncesinde yapılacak işlemler ile transfer sürecini ve transfer sonrası arşiv malzemesini kullanıma sunmak için yapılması gerekli işlemleri ele almaktadır. Transfer işlemi genel olarak iki farklı kaynaktan yapılabilir. Bunlardan birincisi kurumsal belge yönetim sistemlerinden kurum arşivine yapılan transfer işlemidir ki kurum içi transfer olarak tanımlanabilir. İkinci transfer yöntemi ise farklı kurumlardan arşiv kurumlarına yapılan transfer işlemidir. Her iki yöntemde de transfer işleminin temel bir devir – teslim işlemi olarak ele alınması ve sürecin kayıt altına alınması önemlidir. Transfer eden birim veya kurum ile transferi kabul eden kurum veya birim arasında bir devir – teslim tutanağı oluşturulması gerekir. Ayrıca, farklı formatlardaki arşiv malzemesinin transfer işlemlerinde ise her formatın özelliklerine uygun yöntemler geliştirilmelidir. Bu yöntemlerin neler olabileceği ve nasıl uygulanacağı ile ilgili düzenlemeler aşağıda verilmiştir.",
                    UstIcerikID = 384,
                    StandartIcerikTipiID = 171,
                    SiraNo = 385,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 386,
                    StandartID = 1,
                    BaslikNo = "17.2",
                    Baslik = "Arşiv Malzemesinin Transfer İşlemleri",
                    Detay = null,
                    UstIcerikID = 383,
                    StandartIcerikTipiID = 168,
                    SiraNo = 386,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 387,
                    StandartID = 1,
                    BaslikNo = "17.2.1",
                    Baslik = null,
                    Detay = "<p>Belgeler, elektronik arşiv yönetim sistemi içerisine üretim formatlarına uygun yöntemler geliştirilerek aktarılmalıdır. Elektronik arşiv yönetim sistemleri içerisine aktarılacak belgeler genel olarak beş ayrı grupta değerlendirilebilir.</p><p><ul><li>Elektronik belgeler Kurumsal aktivitelerin yerine getirilmesi sırasında üretilen ya da alınan; kurumsal kimlik doğrulama sistemleri, elektronik veya mobil imza sistemleri ile imzalanmış her türlü kayıtlı belgeyi ifade eder.</li><li>Sayısallaştırılmış belgeler Kurumsal aktivitelerin yerine getirilmesi sırasında fiziksel ortamlarda üretilmiş ya da alınmış ancak sonradan sayısallaştırma teknikleri ile elektronik ortama taşınmış olan her türlü kayıtlı belgeyi ifade eder.</li><li>Sayısallaştırılmış dokümantasyon Bilgi değeri açısından gelecek nesillere aktarılmasında yarar görülen her türlü sayısallaştırılmış dokümantasyonu ifade eder.</li><li>Dijital ses ve görüntü kayıtları Dijital olarak üretilmiş her türlü hareketli / hareketsiz görüntü ve ses kayıtlarını ifade eder</li><li>Sayısallaştırılmış ses ve görüntü kayıtları Analog ortamlarda üretilen ve depolanan ancak sonradan sayısallaştırma teknikleri ile elektronik ortama aktarılan her türlü hareketli / hareketsiz görüntü ve ses kayıtlarını ifade eder.</li></ul></p>",
                    UstIcerikID = 386,
                    StandartIcerikTipiID = 171,
                    SiraNo = 387,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 388,
                    StandartID = 1,
                    BaslikNo = "17.2.2",
                    Baslik = null,
                    Detay = "Tüm sayısallaştırılmış belge, doküman, resim, ses ve görüntü kayıtları ELAS/RM içerisine transfer edilmeden önce bunların TS13298 Standardının Dijital Görüntüleme Sistemleri bölümünde yer alan ilgili maddelere uygunluğu denetlenmelidir. Ayrıca, tüm belge, doküman, resim, ses ve görüntü kayıtların e-arşiv sistemine aktarılması sırasında aktarım paketine bu standardın Üstveri Modeli bölümünde ifade edilen ilgili veri alanlarının dahil edilmesi gereklidir.",
                    UstIcerikID = 386,
                    StandartIcerikTipiID = 171,
                    SiraNo = 388,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 389,
                    StandartID = 1,
                    BaslikNo = "17.3",
                    Baslik = "Düzenleme",
                    Detay = null,
                    UstIcerikID = 383,
                    StandartIcerikTipiID = 168,
                    SiraNo = 389,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 390,
                    StandartID = 1,
                    BaslikNo = "17.3.1",
                    Baslik = null,
                    Detay = "<p>Düzenleme arşiv malzemesi üzerinde fiziksel kontrolün sağlanmasıdır. Arşiv malzemesinin herhangi bir işleme tabi tutulmadan önce düzenlenmesi gerekir. Düzenleme arşiv malzemesini kullanılabilir bir şekilde kullanıcılara sunmak için yapılır. Arşiv malzemesini diğer bilgi kaynaklarından ayıran en önemli özelliği üretildiği dönemdeki yönetim yapısını yansıtması ve kullanıcıyı belgelerin üretildiği çevre şartlarına yeniden götürmesidir. Düzenleme arşivcilik mesleğinin temel prensibini oluşturan respect des fonds olarak bilinen kaynağa saygı prensibine göre yapılır. Kaynağa saygı arşiv malzemesinin üretildiği dönemdeki kurumsal çevre şartlarının korunarak ya da yeniden tesis edilerek kullanıcıya sunulmasıdır. Bu prensibin uygulamada iki farklı yansıması vardır ki bunlar da arşivcilik mesleğinin temel prensiplerini oluşturur.</p><p>Provenans prensibi (the principle of provenance) Kelime anlamı kaynak olan provenans kavram olarak arşiv malzemesini üreten ya da mülkiyetini elinde bulunduran kurum veya bireyi ifade eder. Bu prensip doğrultusunda farklı kaynaklardan gelen arşiv malzemesi hiçbir surette birbirine karıştırılmamalıdır. Bunlar benzer faaliyetleri yürüten kurumlar veya aynı olayları tecrübe etmiş bireyler dahi olsa farklı kaynaklardan gelen arşiv malzemesi birbirinden bağımsız olarak düzenlenir ve kullanıcılara bu şekilde sunulur. Provenans prensibi arşiv malzemesinin niceliği, niteliği ya da üretici kişi veya kurumların özelliklerine bakılmaksızın her şartta uygulanması gereken bir unsurdur.</p><p>Asli düzen prensibi (the principle of original order) Arşiv malzemesi üretildiği dönemdeki orijinal düzeni ile kullanıcıya sunulmalıdır. Arşiv malzemesini düzenlenmesi sırasında uzmanlar malzemeyi üreten kurumun nasıl bir dosya düzeni kurduğunu araştırmalı ve orijinal düzen eğer bozulmuş ise yeniden tesis edilmelidir. Arşiv malzemesi için orijinal düzenden daha iyi bir düzen yoktur. Çünkü orijinal düzen araştırmacıya belgelerde yer almayan çok değerli kurumsal çevre bilgilerini ve arşiv malzemesini üretiminden, kullanımından ve saklanmasından sorumlu olan kurumlar ve kişiler hakkında belgelerde olmayan ve araştırmacı için son derece değerli olan bağlam bilgisi (context information) verebilir.</p>",
                    UstIcerikID = 389,
                    StandartIcerikTipiID = 171,
                    SiraNo = 390,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 391,
                    StandartID = 1,
                    BaslikNo = "18",
                    Baslik = "Arşiv Malzemesinin Tanımlanması",
                    Detay = null,
                    UstIcerikID = 342,
                    StandartIcerikTipiID = 169,
                    SiraNo = 391,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 392,
                    StandartID = 1,
                    BaslikNo = "18.1",
                    Baslik = "Tanımlama seviyeleri",
                    Detay = null,
                    UstIcerikID = 391,
                    StandartIcerikTipiID = 168,
                    SiraNo = 392,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 393,
                    StandartID = 1,
                    BaslikNo = "18.1.1",
                    Baslik = null,
                    Detay = "Arşiv malzemesi ELAS/RM içerisinde farklı seviyelerde tanımlanmalıdır. Tanımlama seviyeleri arşiv malzemeleri arasında hiyerarşik bir ilişki kurarak malzemenin üretildiği dönemdeki çevre şartlarının yeniden kurulmasına ve kullanıcıya arşiv malzemesinin üretim ortamı hakkında detaylı bilgi vererek arşiv malzemesinin bir bağlam içerisinde incelenmesine ortam hazırlar. Arşiv malzemesinin tanımlama seviyelerinin hiyerarşisi aşağıdaki şekilde olmalıdır.a) Arşiv kurumu seviyesi(0): Hiyerarşideki en üst düzeydir. Ulusal düzeyde arşiv malzemesi bulunduran ve arşiv hizmeti veren kurumları tanımlamak için kullanılır.Birden fazla arşiv kurumunu tek bir sistem üzerinde yönetme durumunda kullanılır. b) Fon grubu seviyesi(1): Bir arşiv kurumu içerisindeki benzer fonksiyonlara sahip kurumlardan gelen arşiv malzemelerinin bütünüdür.Örneğin üniversiteler, belediyeler, hastaneler gibi aynı fonksiyonları yerine getiren farklı kurumların arşivlerin birlikte tanımlanmasına imkân sağlar. Teşkilat yapısı ile ilgili düzenlemeler açısından bir yürütme organına bağlı ancak faaliyetleri açısından bağımsız veya özerk olan(Yüksek Öğretim Kurumu ile Milli Eğitim Bakanlığı, Hâkimler ve Savcılar Yüksek Kurulu ile Adalet Bakanlığı ilişkisinde olduğu gibi) kurumlar, kuruluşlar ve kurullar ayrı fon olarak değerlendirilmelidir. c) Fon(2): Arşiv malzemesini üreten veya malzemenin fikrî, fizikî, idarî veya ticarî mülkiyetine sahip olan kurumları tanımlamak için kullanılır.Farklı fonlardan gelen arşiv malzemesi hiçbir surette birbirine karıştırılmaz.Fonlar tanımlanırken üretici kurumdaki hiyerarşik yapıya göre alt fonlara bölünerek tanımlanabilir. d) Seri(3): Arşiv malzemesini üreten birimdeki faaliyet alanlarını ifade eder. Genel olarak birimlerde birden fazla seri bulunur.Aynı faaliyet alanına ait, aynı dosyalama sistemi içerisinde dosyalanmış, aynı dosya formatına sahip veya belli bir konu temelinde bir araya getirilmiş olan belgeler bütünüdür. Faaliyet alanlarının bağımsız süreçlerden oluştuğu(aynı faaliyet alanına farklı dosya / klasörler oluşturulduğu) durumlarda seriler alt  serilere bölünebilir.Bu durumda alt seriler ayrı bir seviye olarak tanımlanmalıdır.İki veya daha fazla alt serinin oluşmadığı durumlarda ise alt seriler kullanılmamalıdır. e) Dosya / Klasör(4): Arşiv malzemesi genel olarak iki farklı yapıda dosyalanmış olabilir.Bunlardan birincisi belli bir olay, şahıs, proje, kurum gibi birbirinden kesin olarak ayrılabileceknitelikteki belgelerin oluşturduğu bütündür ve vaka dosyası olarak anılırlar. İkinci dosya türü konu dosyalarıdır. Konu dosyaları aynı veya benzer konudaki belgelerin bir araya gelmesi ile oluşur. Genel olarak yıllık olarak ayrılırlar ancak belge trafiğinin az olduğu konu başlıklarında daha uzun süreli ayrımlarda yapılabilir. f) Belge(5): Genel olarak tek bir işlem için üretilmiş olan bilgi ünitesidir.Belge fiziksel olarak tek bir parçadan oluşabileceği gibi bazen de ekleri olan çoklu bir ünite olabilir ya da elektronik belgelerde ve web sayfalarında olduğu gibi bileşenlerden oluşabilir.Ancak belge arşivcilik açısından tek bir bütün olarak ele alınmalıdır. g) Belge Bileşeni: Arşiv malzemesinin yönetilebilir en küçük parçası belgedir.Ancak bazı belgelerin ekleri ya da belgeyi oluşturan bileşenlerin farklı formatları olması durumunda belgeden bağısız olarak tanımlanması, depolanması ve hizmete sunulması gerekebilir.Bu durumlarda belge bileşeni, belge ile olan organik bağ korunarak bağımsız olarak tanımlanabilir.",
                    UstIcerikID = 392,
                    StandartIcerikTipiID = 171,
                    SiraNo = 393,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = true,
                        KurumYeterlilikSertifikasi = true,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 394,
                    StandartID = 1,
                    BaslikNo = "18.2",
                    Baslik = "Tanımlama Alanları",
                    Detay = null,
                    UstIcerikID = 391,
                    StandartIcerikTipiID = 168,
                    SiraNo = 394,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 395,
                    StandartID = 1,
                    BaslikNo = "18.2.1",
                    Baslik = null,
                    Detay = "Kimlik bilgileri tanımlama ve kontrol alanları: Arşiv yönetim sistemi içerisinde tanımlanacak her bir varlık için bir kayıt olması ve her kayıt için bir anahtar alan ve uygun tanımlama bilgileri üretilmesi gerekir. AYS içerisindeki varlıklar 2.4.1’de ifade edilen tanımlama seviyelerine uygun hiyerarşi içerisinde tanımlanmalıdır. AYS içerisindeki her varlık asgari bir anahtar alan, varlık adı, kapsadığı tarihler ve varlık türünden oluşmalıdır.",
                    UstIcerikID = 394,
                    StandartIcerikTipiID = 171,
                    SiraNo = 395,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 396,
                    StandartID = 1,
                    BaslikNo = "18.2.2",
                    Baslik = null,
                    Detay = "Üretim ve mülkiyet bilgileri tanımlama ve kontrol alanları: AYS içerisinde yer alan arşiv malzemelerin üretiminden sorumlu kişi ve kurumların uygun alt birim bilgileri ile birlikte sisteme girilmesi gereklidir. Kurum ve şahıs adlarındaki benzerliklerden ya da yazım hatalarından doğabilecek karışıklıkları önlemek için bu tür bir bilgilerin bir referans tabloda tutulması önerilmelidir. Üretim bilgilerinin yanı sıra arşiv malzemesi hizmete sunulduğu son kuruma gelene kadar olan mülkiyet zincirinin de sistemden takip edilebilmesi gerekir. Mülkiyet zinciri tarihçesi tek bir metin alanında verilebilir. Ancak arşiv malzemesinin hizmete sunulduğu kuruma malzeme sağlayan kişi veya kurumlar ayrıca tanımlanmalıdır.",
                    UstIcerikID = 394,
                    StandartIcerikTipiID = 171,
                    SiraNo = 396,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 397,
                    StandartID = 1,
                    BaslikNo = "18.2.3",
                    Baslik = null,
                    Detay = "İçerik tanımlama ve kontrol alanları: Arşiv malzemesinin içerik açısından tanımlanması için kullanılan alanlarıdır. Malzemenin konusu, malzemenin üretiminden sorumlu şahıs ve/veya tüzel kişiler, malzemeye konu edilmiş şahıslar, yerler, kurumlar, olaylar ve tarihler gibi malzemenin araştırmacılar tarafından bulunmasını ve kullanılmasını kolaylaştıracak tanımlama unsurlarıdır. İçerik tanımlama ve kontrol alanlarının dosya / klasör, seri ve fon düzeyindeki varlıklar için kullanılması daha uygundur.",
                    UstIcerikID = 394,
                    StandartIcerikTipiID = 171,
                    SiraNo = 397,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 398,
                    StandartID = 1,
                    BaslikNo = "18.2.4",
                    Baslik = null,
                    Detay = "Fiziksel özellikler tanımlama ve kontrol alanları: Arşiv malzemesine ait fiziksel tanımlama alanları belge, dosya ve seri bazında ayrı ayrı tanımlanmalıdır. Fiziksel tanımlama alanları arşiv malzemesinin niceliksel olarak tanımlayacak uygun tanımlama alanlarında oluşmalıdır.",
                    UstIcerikID = 394,
                    StandartIcerikTipiID = 171,
                    SiraNo = 398,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 399,
                    StandartID = 1,
                    BaslikNo = "18.2.5",
                    Baslik = null,
                    Detay = "Yönetimsel fonksiyonları tanımlama ve kontrol alanları: Bu bölümde yer alacak olan bilgileri arşiv malzemesinin bünyesinde bulunduran ve hizmete sunan kurumların yönetimsel fonksiyonlarını kontrol altına almasını ve yönetmesi kolaylaştıracak bilgiler içermektedir. Bu bağlamda: i) Arşiv malzemesinin kuruma nereden / kimden, nasıl(bağış, satın alma, ödünç) sağlandığının,ii) Malzemenin fiziksel ve/veya dijital kopyalarının nerede depolandığının, iii) Her biri ayrı ayrı olmak üzere, malzemenin düzenleme, tanımlama ve indeksleme işlemlerinin kimler tarafından ne zaman yapıldığının, iv) Malzeme herhangi bir ayıklama işlemine tabi tutulmuş ise, bu işleme ait yasal çerçevenin ne olduğunu; işlemin kimler tarafından ne zaman yapıldığının, v) Arşiv malzemesinin korunmasına ve restorasyonuna yönelik olarak ne tür onarımların gerekli olduğu, öncelik derecesi, her hangi bir onarım yapılmış ise bunun kim tarafından, ne zaman ve ne tür malzeme kullanılarak yapıldığının tanımlanmasına ve kontrol altına alınmasına yönelik alanlardan oluşur.",
                    UstIcerikID = 394,
                    StandartIcerikTipiID = 171,
                    SiraNo = 399,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 400,
                    StandartID = 1,
                    BaslikNo = null,
                    Baslik = "Bölüm:IV Üstveri Yönetimi",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 164,
                    SiraNo = 400,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 401,
                    StandartID = 1,
                    BaslikNo = "19",
                    Baslik = "Üstveri Elemanları",
                    Detay = null,
                    UstIcerikID = 400,
                    StandartIcerikTipiID = 169,
                    SiraNo = 401,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 402,
                    StandartID = 1,
                    BaslikNo = "19.1",
                    Baslik = "Genel Özellikler",
                    Detay = null,
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 402,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 403,
                    StandartID = 1,
                    BaslikNo = "19.1.1",
                    Baslik = null,
                    Detay = "<p>EBYS, sistem içerisinde tanımlanacak üstveri elemanları için herhangi bir sınırlama getirmemelidir.</p><p> Not: Bu bölümde tanımlanan üstveri elemanları EBYS sistemi için en genel olanlardır. EBYS kullanacak kurumlar kendi ihtiyaçlarına göre üstveri elemanlarının sayısını artırabilmeli ya da zorunlu elemanların dışında kalanları sistemden çıkarabilmelidir. Ayrıca, sistem tasarımı aşamasında üstveri elemanlarının veri kaynaklarının neler olduğu tanımlanmalıdır. EBYS üstveri elemanları için veri kaynakları şunlar olabilir:</p><p><ul><li>İşletim sistemi</li><li>Ağ yazılımı</li><li>Uygulama programı</li><li>EBYS</li><li>Bilgisayar sistemi yöneticisi</li><li>Bilgi ve belge yöneticisi</li><li>Kullanıcı</li></ul></p>",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 403,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 404,
                    StandartID = 1,
                    BaslikNo = "19.1.2",
                    Baslik = null,
                    Detay = "<p>Üstveri elemanlarının içerdiği bilgiler, EBYS’nin fonksiyonlarını şekillendirmelidir.</p><p>Not: Örneğin sistemdeki bir belge güvenlik seviyesi içeriyorsa, EBYS bu belgeye kimlerin erişim hakkı olduğunu belirleyebilmeli ve yalnızca yetkili kullanıcılara erişim hakkı vermelidir. Bu kural tüm üstveri elemanları için geçerlidir.</p>",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 404,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 405,
                    StandartID = 1,
                    BaslikNo = "19.1.3",
                    Baslik = null,
                    Detay = "<p>EBYS içerisinde farklı belge türleri için farklı üstveri elemanları tanımlanabilmelidir.</p><p>Not: Örneğin bir elektronik posta dokümanı için gerekli üstveri elemanları, görüntüleme teknikleri ile sisteme dâhil edilmiş dokümanlardan farklı üstveri elemanlarına ihtiyaç duyar. Bu bölümün devamında tanımlanan üstveri elemanlar her türlü belgeyi kapsayacak şekilde tasarlanmıştır. Ancak bu modülde verilen üstveri elemanlarını kullanacak kurumlar belge türlerine göre ilgili üstveri elemanlarını seçmelidir.</p>",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 405,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 406,
                    StandartID = 1,
                    BaslikNo = "19.1.4",
                    Baslik = null,
                    Detay = "Üstveri elemanlarının EBYS sistemi içerisinde zorunlu veya isteğe bağlı olup olmadığı ile bu elemanların indekslenip indekslenmeyeceği sistem tasarımı aşamasında sistem yöneticisi tarafından belirlenebilmelidir.",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 406,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 407,
                    StandartID = 1,
                    BaslikNo = "19.1.5",
                    Baslik = null,
                    Detay = "<p>Üstveri elemanları asgari olarak aşağıdaki formatları desteklemelidir.</p><p><ul><li>Alfabetik</li><li>Nümerik</li><li>Alfa-nümerik</li><li>Tarih / saat</li><li>Mantıksal (Evet/Hayır)</li></ul></p>",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 407,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 408,
                    StandartID = 1,
                    BaslikNo = "19.1.6",
                    Baslik = null,
                    Detay = "<p>Sistem tasarımı aşamasında, üstveri elemanları için veri giriş maskesi tanımlanabilmelidir.</p><p>Not: Özellikle tarih alanları ve nümerik alanlar için veri giriş maskesi tanımlanması kullanım kolaylığı ve verilerin doğru girilmesini sağlayacaktır.</p>",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 408,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 409,
                    StandartID = 1,
                    BaslikNo = "19.1.7",
                    Baslik = null,
                    Detay = "İşletim sistemi, ağ yazılımı ve uygulama programından otomatik olarak alınan bilgiler üzerinde herhangi bir değişiklik yapılması engellenmelidir. Diğer bilgiler üzerinde yapılabilecek değişikler yetki sınırları içerisinde olmalı ve yapılan değişikler kayıt altına alınmalıdır.",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 409,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 410,
                    StandartID = 1,
                    BaslikNo = "19.1.8",
                    Baslik = null,
                    Detay = "<p>Üstveri elemanlarına ait bilgiler mümkün olduğu ölçüde sistem tarafından kontrol edilmelidir. Yanlış veri girişleri engellenmeli ve kullanıcılar uyarılmalıdır.</p><p>Not: Özellikle tarihler, telefon numaraları ve elektronik posta adresleri gibi bilgiler sistem tarafından kontrol edilebilir.</p>",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 410,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 411,
                    StandartID = 1,
                    BaslikNo = "19.1.9",
                    Baslik = null,
                    Detay = "Tarih ve nümerik alanlar dâhil olmak üzere üstveri elemanları tam metin (full-text) metodu ile sorgulanabilmelidir.",
                    UstIcerikID = 402,
                    StandartIcerikTipiID = 171,
                    SiraNo = 411,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = true,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 412,
                    StandartID = 1,
                    BaslikNo = "19.2",
                    Baslik = "Dosya Tasnif Planı Üstveri Elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>DTP Eleman Referans Numarası</td></tr><tr><td>Referans Numarası</td><td>DT001</td></tr><tr><td>Tanım</td><td>Dosya tasnif planında yer alacak her bir eleman için verilecek olan referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Dosya tasnif planındaki seri ve alt seri kodları gibi.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>DTP Eleman adı</td></tr><tr><td>Referans Numarası</td><td>DT010</td></tr><tr><td>Tanım</td><td>Dosya tasnif planında yer alan elemanların adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Dosya tasnif planındaki seri ve alt serilerin adıdır. Farklı birimlerde aynı ad ile seriler oluşabilir. Ancak bu serilere ait referans numaraları farklı olmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Tanım</td></tr><tr><td>Referans Numarası</td><td>DT050</td></tr><tr><td>Tanım</td><td>Dosya tasnif planı elemanına ait tanımlamalara ve açıklamalara ait bilgidir. Kullanımı zorunlu değildir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td>Kullanıcıların yönlendirilmesi ve EBYS içerisine dahil edilecek belgelerin hangi elemanlar altında tasnif edilmesi gerektiğini göstermek amacıyla kullanılabilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seviye numarası</td></tr><tr><td>Referans Numarası</td><td>DT070</td></tr><tr><td>Tanım</td><td>Dosya tasnif planı elemanına ait hiyerarşik seviyeyi gösteren numaradır.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 412,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 413,
                    StandartID = 1,
                    BaslikNo = "19.3",
                    Baslik = "Saklama Planı Üstveri Elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>SP Eleman referans numarası</td></tr><tr><td>Referans Numarası</td><td>SP001</td></tr><tr><td>Tanım</td><td>Saklama planında yer alacak her bir eleman için verilecek olan referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama planındaki seri ve alt seri kodları gibi.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>SP Eleman adı</td></tr><tr><td>Referans Numarası</td><td>SP010</td></tr><tr><td>Tanım</td><td>Saklama planında yer alan elemanların adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama planındaki seri ve alt serilerin adıdır. Farklı birimlerde aynı ad ile seriler oluşabilir. Ancak bu serilere ait referans numaraları farklı olmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama süresi</td></tr><tr><td>Referans Numarası</td><td>SP040</td></tr><tr><td>Tanım</td><td>Saklama planında yer alan elemanların kurumda ne kadar süre ile saklanacağı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Genelde yıl olarak ifade edilir. Sistemdeki belgelerin idari kullanımının tamamlandıktan sonra kaç yıl süre ile saklanacağını gösterir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Tasfiye işlem kodu</td></tr><tr><td>Referans Numarası</td><td>TS001</td></tr><tr><td>Tanım</td><td>Saklama süresi dolan klasör/dosya ve belgelerin ne tür işleme tabi tutulacağı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tasfiye işlem kodlarının tanımları için Madde 5.5’e bakılmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Yasal kaynak</td></tr><tr><td>Referans Numarası</td><td>SP110</td></tr><tr><td>Tanım</td><td>Saklama sürelerinin hangi yasal düzenlemeye göre atandığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td></td></tr><tr><td>Notlar</td><td>Kanun ve yönetmelik gibi yasal düzenlemelere ait referansları içerir.</td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 413,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 414,
                    StandartID = 1,
                    BaslikNo = "19.4",
                    Baslik = "Birim/Alt Birim tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR001</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı kurumdaki birimlere verilmiş olan kodnumarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim adı</td></tr><tr><td>Referans Numarası</td><td>BR010</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı kurumdaki birimlerin adlarıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim Seviye numarası</td></tr><tr><td>Referans Numarası</td><td>BR120</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği kurumdaki birimlere ait hiyerarşik seviyeyi gösteren numaradır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR101</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı, kurumlara bağlı birimlerin, alt birimleri için verilmiş kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td></td></tr><tr><td>Notlar</td><td>Bazı durumlarda kullanılır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Birim Adı</td></tr><tr><td>Referans Numarası</td><td>BR110</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı kurumlara bağlı birimlerin, alt birimlerinin adlarıdır.</td></tr><tr><td>Zorunluluk</td><td></td></tr><tr><td>Notlar</td><td>Bazı durumlarda kullanılır.</td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 414,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 415,
                    StandartID = 1,
                    BaslikNo = "19.5",
                    Baslik = "Seri tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri kodu:</td></tr><tr><td>Referans Numarası</td><td>SE001</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge serisine ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri adı</td></tr><tr><td>Referans Numarası</td><td>SE010</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge serisinin adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Belge serileri aynı zamanda kurumsal fonksiyonları ifade eder. Farklı birimlerde aynı ad altında belge serileri olabilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri tanımı</td></tr><tr><td>Referans Numarası</td><td>SE050</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge serisine ait açıklayıcı bilgilerin yer aldığı alandır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim/Alt Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR001/BR101</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisinin ait olduğu birime/alt birime ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Birim kodu tanımlamaları için Madde 11.5’e bakılmalıdır. Belge serisinin ya da kurumsal fonksiyonun hangi birime ait olduğunun kayıt altına alınması belge provenansının tespiti açısından son derece önemlidir. Birim kodu uygulama programı tarafından kullanıcı sistem giriş bilgileri kullanılarak otomatik olarak atanabilir ya da Bilgi ve Belge Yöneticisi veya kullanıcı tarafından girilebilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Açılış tarihi/Başlangıç Tarihi</td></tr><tr><td>Referans Numarası</td><td>SE210</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisinin hangi tarihte açıldığını gösteren bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kapanış tarihi/Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>SE290</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisinin hangi tarihte kapatıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Erişim hakları</td></tr><tr><td>Referans Numarası</td><td>SE300</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisine erişim hakkı bulunan kullanıcılar ve/veya kullanıcı gruplarının kimler olduğuna ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Erişim hakları tanımlamaları için Madde 9.2’ye bakılmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Güvenlik kodu</td></tr><tr><td>Referans Numarası</td><td>SE500</td></tr><tr><td>Tanım</td><td>Elektronik belge serisinin gizlilik derecesini ya da kullanım kısıtlamalarını gösteren kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Güvenlik kod tanımları için Madde 9.2’ye bakılmalıdır. Güvenlik kodları, erişim hakları tanımları ile entegre çalışmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama plan kodu</td></tr><tr><td>Referans Numarası</td><td>SE770</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisi içinde yer alan belgelerin ne kadar sürelerle saklanacağını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama Plan kodu tanımları için Madde 5’e bakılmalıdır</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Anahtar kelimeler</td></tr><tr><td>Referans Numarası</td><td>SE610</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisini tanımlayıcı anahtar kelimelerin verildiği alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Miktar</td></tr><tr><td>Referans Numarası</td><td>SE550</td></tr><tr><td>Tanım</td><td>Serinin fiziksel boyutları ile seriye ait dosya sayısının nicelik olarak tanımlandığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Devamı olduğu seri</td></tr><tr><td>Referans Numarası</td><td>SE910</td></tr><tr><td>Tanım</td><td>Mevcut serinin herhangi bir serinin devamı olup olmadığı bu üstveri alanında tanımlanır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 415,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 416,
                    StandartID = 1,
                    BaslikNo = "19.6",
                    Baslik = "Alt Seri tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Seri Kodu</td></tr><tr><td>Referans Numarası</td><td>AS101</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge alt serisine ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Seri adı</td></tr><tr><td>Referans Numarası</td><td>AS110</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge alt serisinin adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Seri Tanımı</td></tr><tr><td>Referans Numarası</td><td>AS050</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge alt serisine ait açıklayıcı bilgilerin yer aldığı alandır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Açılış tarihi/Başlangıç Tarihi</td></tr><tr><td>Referans Numarası</td><td>AS210</td></tr><tr><td>Tanım</td><td>Elektronik belgenin alt serisinin hangi tarihte açıldığını gösteren bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kapanış tarihi/Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>AS290</td></tr><tr><td>Tanım</td><td>Elektronik belgenin alt serisinin hangi tarihte kapatıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Miktar</td></tr><tr><td>Referans Numarası</td><td>AS550</td></tr><tr><td>Tanım</td><td>Alt serinin fiziksel boyutları ile seriye ait dosya sayısının nicelik olarak tanımlandığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Devamı olduğu alt seri (varsa)</td></tr><tr><td>Referans Numarası</td><td>AS910</td></tr><tr><td>Tanım</td><td>Mevcut serinin herhangi bir serinin devamı olup olmadığı bu üstveri alanında tanımlanır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 416,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 417,
                    StandartID = 1,
                    BaslikNo = "19.7",
                    Baslik = "Klasör/Dosya tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Klasör/dosya numarası</td></tr><tr><td>Referans Numarası</td><td>KD001</td></tr><tr><td>Tanım</td><td>Belgelerin ait olduğu klasör veya dosyalara ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Klasör/dosya adı</td></tr><tr><td>Referans Numarası</td><td>KD010</td></tr><tr><td>Tanım</td><td>Belgelerin ait olduğu klasör veya dosyaların adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Açılış tarihi/Başlangıç Tarihi</td></tr><tr><td>Referans Numarası</td><td>KD210</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi tarihte açıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kapanış tarihi/Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>KD290</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi tarihte kapatıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri numarası</td></tr><tr><td>Referans Numarası</td><td>SE001</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi seriye ait olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama ortamı</td></tr><tr><td>Referans Numarası</td><td>KD180</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi ortamda saklandığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama ortamı fiziki, elektronik ya da karma olabilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama yeri referans numarası</td></tr><tr><td>Referans Numarası</td><td>KD181</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın nerede depolandığını gösteren yer numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Bu alan yalnızca fiziki klasör ve dosyalar içindir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Bölüm numarası</td></tr><tr><td>Referans Numarası</td><td>KD400</td></tr><tr><td>Tanım</td><td>Birden fazla bölümden oluşan klasör veya dosyalara ait bölüm numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Tasfiye tarihi</td></tr><tr><td>Referans Numarası</td><td>KD041</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi tarihte tasfiye edileceğini gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tasfiye işlem tanımlamaları Madde 5.5’e bakılmalıdır.</td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 417,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 418,
                    StandartID = 1,
                    BaslikNo = "19.8",
                    Baslik = "Belge tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge referans numarası</td></tr><tr><td>Referans Numarası</td><td>BE001</td></tr><tr><td>Tanım</td><td>Belgeye ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge adı</td></tr><tr><td>Referans Numarası</td><td>BE010</td></tr><tr><td>Tanım</td><td>Belgeye ait ad ve/veya tür bilgisidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Elektronik dosya adı</td></tr><tr><td>Referans Numarası</td><td>BE019</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bilgisayar sisteminde hangi ad ile tutulduğu bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Klasör/dosya numarası.</td></tr><tr><td>Referans Numarası</td><td>KD001</td></tr><tr><td>Tanım</td><td>Belgenin bağlı bulunduğu klasör veya dosyaya ait referans numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Konu</td></tr><tr><td>Referans Numarası</td><td>BE055</td></tr><tr><td>Tanım</td><td>Belge içeriğini açıklayıcı bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Üretici</td></tr><tr><td>Referans Numarası</td><td>BE100</td></tr><tr><td>Tanım</td><td>Belge üreticisini gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Üretim tarihi</td></tr><tr><td>Referans Numarası</td><td>BE210</td></tr><tr><td>Tanım</td><td>Belgenin üretildiği tarihtir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Gönderme / alma tarihi</td></tr><tr><td>Referans Numarası</td><td>BE240</td></tr><tr><td>Tanım</td><td>Belgenin gönderildiği ya da alındığı tarihtir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alıcı/Muhatap</td></tr><tr><td>Referans Numarası</td><td>BE200</td></tr><tr><td>Tanım</td><td>Belgenin kime gönderildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Dil</td></tr><tr><td>Referans Numarası</td><td>BE350</td></tr><tr><td>Tanım</td><td>Belgenin hangi dilde üretildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge türü</td></tr><tr><td>Referans Numarası</td><td>BE420</td></tr><tr><td>Tanım</td><td>Belgeye ait tür tanımlamasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Kurumdaki belge türleri (yazışma, rapor, vs.) kullanıcıya liste halinde sunularak çoktan seçmeli bilgi girişi sağlanmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Sisteme giriş tarihi</td></tr><tr><td>Referans Numarası</td><td>BE260</td></tr><tr><td>Tanım</td><td>Belgenin EBYS içerisine kayıt edildiği tarihtir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Erişim hakları</td></tr><tr><td>Referans Numarası</td><td>BE300</td></tr><tr><td>Tanım</td><td>Elektronik belgeye erişim hakkı bulunan kullanıcılar ve/veya kullanıcı gruplarının kimler olduğuna ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Erişim hakları tanımlamaları için Madde 9.2’ye bakılmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Güvenlik kodu</td></tr><tr><td>Referans Numarası</td><td>GS001</td></tr><tr><td>Tanım</td><td>Elektronik belgenin gizlilik derecesini yada kullanım kısıtlamalarını gösteren kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Güvenlik kod tanımları için Madde 9.2’ye bakılmalıdır. Güvenlik kodları, erişim hakları tanımları ile entegre çalışmalıdır</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Dosya formatı</td></tr><tr><td>Referans Numarası</td><td>BE830</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği yazılımın belgeye kazandırmış olduğu orijinal dosya formatının adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Arşiv formatı</td></tr><tr><td>Referans Numarası</td><td>BE880</td></tr><tr><td>Tanım</td><td>Elektronik belgenin uzun dönem saklama ve kullanımı için dönüştürüldüğü arşiv dosya formatıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Donanım</td></tr><tr><td>Referans Numarası</td><td>BE420</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği bilgisayar sisteminin donanım özelliklerine ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>İşletim Sistemi</td></tr><tr><td>Referans Numarası</td><td>BE430</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği bilgisayar sisteminin kullandığı işletim sistemine ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Uygulama Programı</td></tr><tr><td>Referans Numarası</td><td>BE440</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği uygulama yazılımına ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kodlama Şeması</td></tr><tr><td>Referans Numarası</td><td>BE570</td></tr><tr><td>Tanım</td><td>Elektronik belgenin hangi kodlama şemasına göre üretildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Öncelik derecesi</td></tr><tr><td>Referans Numarası</td><td>BE620</td></tr><tr><td>Tanım</td><td>Elektronik belgenin kurumsal faaliyetlerin devamı açısından taşıdığı önemi gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Bilgi edinme kanunu kapsamı</td></tr><tr><td>Referans Numarası</td><td>BE460</td></tr><tr><td>Tanım</td><td>Elektronik belgenin Bilgi Edinme Kanunu kapsamında olup olmadığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Telif hakları kanunu kapsamı</td></tr><tr><td>Referans Numarası</td><td>BE470</td></tr><tr><td>Tanım</td><td>Elektronik belgenin Telif Hakları Kanunu kapsamında olup olmadığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Elektronik imza</td></tr><tr><td>Referans Numarası</td><td>BE500</td></tr><tr><td>Tanım</td><td>Belge üzerinde elektronik imzanın varlığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Elektronik imza sertifika kurumu</td></tr><tr><td>Referans Numarası</td><td>BE510</td></tr><tr><td>Tanım</td><td>Belge üzerinde elektronik imzanın hangi kurum tarafından onaylandığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Zaman damgası</td></tr><tr><td>Referans Numarası</td><td>BE520</td></tr><tr><td>Tanım</td><td>Elektronik belgenin hangi tarih ve saatte imzalandığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Şifreleme algoritması</td></tr><tr><td>Referans Numarası</td><td>BE580</td></tr><tr><td>Tanım</td><td>Şifrelenmiş elektronik belgelerin kullanımına imkan verecek algoritmadır.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Diğer dijital işaretler</td></tr><tr><td>Referans Numarası</td><td>BE590</td></tr><tr><td>Tanım</td><td>Elektronik belge üzerindeki dijital antet, filigran gibi işaretler varlığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 418,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 419,
                    StandartID = 1,
                    BaslikNo = "19.9",
                    Baslik = "Belge bileşeni tanımları üstveri elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Belge bileşeni referans numarası</td></tr><tr><td>Referans Numarası</td><td>BB001</td></tr><tr><td>Tanım</td><td>Belge bileşenine ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge Bileşeni Elektronik dosya adı</td></tr><tr><td>Referans Numarası</td><td>BB010</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin bilgisayar sisteminde hangi ad ile tutulduğu bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge numarası</td></tr><tr><td>Referans Numarası</td><td>BE001</td></tr><tr><td>Tanım</td><td>Belge bileşeninin bağlı bulunduğu belgeye ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge Bileşini Dosya formatı</td></tr><tr><td>Referans Numarası</td><td>BB830</td>/tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin üretildiği yazılımın belgeye kazandırmış olduğu orijinal dosya formatının adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Çözünürlük</td></tr><tr><td>Referans Numarası</td><td>DG160</td></tr><tr><td>Tanım</td><td>Görüntü olarak üretilmiş olan elektronik belge bileşenlerinin çözünürlük bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Sıkıştırma parametreleri</td></tr><tr><td>Referans Numarası</td><td>BB650</td></tr><tr><td>Tanım</td><td>Görüntü olarak üretilmiş olan elektronik belge bileşenlerinin sıkıştırma parametrelerine ait bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Donanım</td></tr><tr><td>Referans Numarası</td><td>BB420</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşenin üretildiği bilgisayar sisteminin donanım özelliklerine ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>İşletim Sistemi</td></tr><tr><td>Referans Numarası</td><td>BB430</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşenin üretildiği bilgisayar sisteminin kullandığı işletim sistemine ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Uygulama Programı</td></tr><tr><td>Referans Numarası</td><td>BB440</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşenin üretildiği uygulama yazılımına ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kodlama şeması</td></tr><tr><td>Referans Numarası</td><td>BB670</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin hangi kodlama şemasına göre üretildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Arşiv formatı</td></tr><tr><td>Referans Numarası</td><td>BB880</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin uzun dönem saklama ve kullanımı için dönüştürüldüğü arşiv dosya formatıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 419,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 420,
                    StandartID = 1,
                    BaslikNo = "19.10",
                    Baslik = "Kullanıcı profil tanımları üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı kodu</td></tr><tr><td>Referans Numarası</td><td>KP001</td></tr><tr><td>Tanım</td><td>Kullanıcıyı sistem içerisinde tanımlayan referans kodudur</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı adı soyadı</td></tr><tr><td>Referans Numarası</td><td>KP010</td></tr><tr><td>Tanım</td><td>Kullanıcının ad ve soyadı bilgileridir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR001/BR101</td></tr><tr><td>Tanım</td><td>Kullanıcının mensubu bulunduğu birime ait kod numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı rol tanım kodu</td></tr><tr><td>Referans Numarası</td><td>KP910</td></tr><tr><td>Tanım</td><td>Kullanıcının sistem içerisindeki rolünü tanımlayan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı grup tanım kodu</td></tr><tr><td>Referans Numarası</td><td>KP950</td></tr><tr><td>Tanım</td><td>Kullanıcı grubuna ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 420,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 421,
                    StandartID = 1,
                    BaslikNo = "19.11",
                    Baslik = "Kullanıcı rol tanımları üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı rol kodu</td></tr><tr><td>Referans Numarası</td><td>KR001</td></tr><tr><td>Tanım</td><td>Kullanıcı rolüne ait kod numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı rol adı</td></tr><tr><td>Referans Numarası</td><td>KR010</td></tr><tr><td>Tanım</td><td>Kullanıcı rolünün adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Geçerlilik tarihi</td></tr><tr><td>Referans Numarası</td><td>KR390</td></tr><tr><td>Tanım</td><td>Kullanıcı rolünün ne kadar süre ile geçerli olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 421,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 422,
                    StandartID = 1,
                    BaslikNo = "19.12",
                    Baslik = "Kullanıcı grup tanımları üstveri elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı grup kodu</td></tr><tr><td>Referans Numarası</td><td>KG001</td></tr><tr><td>Tanım</td><td>Kullanıcı grupları için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı grup adı</td></tr><tr><td>Referans Numarası</td><td>KG010</td></tr><tr><td>Tanım</td><td>Kullanıcı grubunun adıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Geçerlilik tarihi</td></tr><tr><td>Referans Numarası</td><td>KG390</td></tr><tr><td>Tanım</td><td>Kullanıcı grubunun ne kadar süre ile geçerli olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 422,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 423,
                    StandartID = 1,
                    BaslikNo = "19.13",
                    Baslik = "Güvenlik seviye tanımları üstveri elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Güvenlik kodu</td></tr><tr><td>Referans Numarası</td><td>GS001</td></tr><tr><td>Tanım</td><td>Güvenlik seviyesi için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tanım</td></tr><tr><td>Referans Numarası</td><td>GS050</td></tr><tr><td>Tanım</td><td>Güvenlik seviyesinin ne olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yasal dayanak</td></tr><tr><td>Referans Numarası</td><td>GS110</td></tr><tr><td>Tanım</td><td>Güvenlik kısıtlamasının yasal dayanağının ne olduğu bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Kanunlar, yönetmelikler v.s</td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 423,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 424,
                    StandartID = 1,
                    BaslikNo = "19.14",
                    Baslik = "Tasfiye işlem tanımları üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tasfiye işlem kodu</td></tr><tr><td>Referans Numarası</td><td>TS001</td></tr><tr><td>Tanım</td><td>Tasfiye işlemi için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tanım</td></tr><tr><td>Referans Numarası</td><td>TS050</td></tr><tr><td>Tanım</td><td>Tasfiye işleminin ne olduğunu gösteren bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 424,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 425,
                    StandartID = 1,
                    BaslikNo = "19.15",
                    Baslik = "Sistem kullanımı üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Sistem Kullanım Referans numarası</td></tr><tr><td>Referans Numarası</td><td>SK001</td></tr><tr><td>Tanım</td><td>Sistemde gerçekleştirilen her bir işlem için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı kodu</td></tr><tr><td>Referans Numarası</td><td>KP001</td></tr><tr><td>Tanım</td><td>İşlemi gerçekleştiren kullanıcıyı tanımlamak için verilmiş olan kod numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Fonksiyon kodu</td></tr><tr><td>Referans Numarası</td><td>SK101</td></tr><tr><td>Tanım</td><td>Kullanıcının sistemde gerçekleştirmiş olduğu fonksiyona ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İşlem kodu</td></tr><tr><td>Referans Numarası</td><td>IT001</td></tr><tr><td>Tanım</td><td>Kullanıcının fonksiyon üzerinde ne tür bir işlem gerçekleştirmiş olduğunu gösteren kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarih ve saat</td></tr><tr><td>Referans Numarası</td><td>SK255</td></tr><tr><td>Tanım</td><td>İşlemin ne zaman gerçekleştirilmiş olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 425,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 426,
                    StandartID = 1,
                    BaslikNo = "19.16",
                    Baslik = "Dijital Görüntüleme ile Sisteme alınanlara ait üstveri tanımları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Referans Kodu</td></tr><tr><td>Referans Numarası</td><td>DG001</td></tr><tr><td>Tanım</td><td>Dosyanın sistemdeki türeme kodudur. Sistem tarafından dijital görüntüye verilen değişmez numarası</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Adı</td></tr><tr><td>Referans Numarası</td><td>DG010</td></tr><tr><td>Tanım</td><td>Dijital ortama aktarılan materyalin dijital ortamda aldığı addır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Türü</td></tr><tr><td>Referans Numarası</td><td>DG070</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin türünü ifade eden üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Kopya Türü</td></tr><tr><td>Referans Numarası</td><td>DG140</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin hangi kopya türü ile elektronik ortamda aktarılacağını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Çözünürlük</td></tr><tr><td>Referans Numarası</td><td>DG160</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin DPI veya PPI olarak ölçütlerinin belirlenmesidir. Görüntülenecek malzemenin elektronik ortamdaki kalitesini belirleyen en temel unsurdur.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tonlama/Bit Derinliği</td></tr><tr><td>Referans Numarası</td><td>DG170</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin renk ve bit derinliğinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Renk Yönetimi</td></tr><tr><td>Referans Numarası</td><td>DG190</td></tr><tr><td>Tanım</td><td>Kullanılan tarayıcının veya yazılım özelliğine bağlı olarak aktarılan materyallerin renk profilini ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Dosya Formatı</td></tr><tr><td>Referans Numarası</td><td>DG830</td></tr><tr><td>Tanım</td><td>Dijitalleştirilen görüntünün hangi dosya formatı ile sisteme alındığının tanımlandığı alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Boyut</td></tr><tr><td>Referans Numarası</td><td>DG350</td></tr><tr><td>Tanım</td><td>Belgenin elektronik ortamda kapsadığı boyuttur. Dijitalleştirilen görüntünün sistemde ne kadar yer kapladığının bir göstergesidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Lokasyon</td></tr><tr><td>Referans Numarası</td><td>DG400</td></tr><tr><td>Tanım</td><td>Dijitalleştirilen görüntünün çevrim dışı olarak hangi lokasyonda tutulduğunu ifade etmek için kullanılan alandır. Dijitalleştirilmiş görüntünün fiziksel ortamdaki yerini ifade etmek için de kullanılır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Zaman damgası</td></tr><tr><td>Referans Numarası</td><td>DG520</td></tr><tr><td>Tanım</td><td>Elektronik görüntünün hangi tarih ve saatte imzalandığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>İmza görevi görmez. Sadece işlemin ne zaman yapıldığını ispatlamak için kullanılır.</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kurumsal İmza</td></tr><tr><td>Referans Numarası</td><td>DG540</td></tr><tr><td>Tanım</td><td>Dijitalleştirilen malzemenin görüntüsünün idare tarafından elektronik onay yoluyla kayıt altına alınmasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Açıklama</td></tr><tr><td>Referans Numarası</td><td>DG600</td></tr><tr><td>Tanım</td><td>Dijitalleştirmenin amacının tanımlandığı veya görüntü ile ilgili herhangi bir notun eklenebilmesi için oluşturmuş üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 426,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 427,
                    StandartID = 1,
                    BaslikNo = "19.17",
                    Baslik = "Fon/Kurum Üstveri Elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>Fon/Kurum Kodu</td></tr><tr><td>Referans Numarası</td><td>FO001</td></tr><tr><td>Tanım</td><td>DETSİS’te tanımlı idari kimlik kodunu ifade eder. Tüzel bir kuruluş olması durumunda MERSİS ticari sicil numarası kullanılabilir. Bir şahıs olması durumunda ise Şahsa ait vatandaşlık numarasını ifade eder. Şahsa ait bir vatandaşlık numarası yoksa otorite dosyasından bir ID üretilerek şahısla eşleştirilir. Aynı şekilde bir kurum veya tüzel kuruluş için de ilgili veri tabanlarında kayıt bulunamazsa otorite dosyası üzerinden bir ID üretilerek işlem yapılabilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Fon /Kurum Adı (Kuruluş ve Şahıs)</td></tr><tr><td>Referans Numarası</td><td>FO010</td></tr><tr><td>Tanım</td><td>Kurumunun kanundaki tam adını veya Şahsın adını veya soyadını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yasal Dayanak</td></tr><tr><td>Referans Numarası</td><td>FO110</td></tr><tr><td>Tanım</td><td>Saklama sürelerinin hangi yasal düzenlemeye göre atandığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarihçe (İdari/Biyografik Tarih)</td></tr><tr><td>Referans Numarası</td><td>FO100</td></tr><tr><td>Tanım</td><td>Tanımlama biriminin şartları ve çevresi içinde bir yere oturtabilmek ve daha anlaşılabilir kılmak amacıyla üreticisi hakkında idari tarih ya da biyografik ayrıntılar sağlamak</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tanımlama biriminin oluşumundan sorumlu kurumun(ların) ortaya çıkış, ilerleme, gelişim ve işleyişi ya da şahsın(ların) yaşamı ve çalışmaları konusunda önemli bilgi özet olarak verilir. Eğer basılı kaynaklarda ek bilgi mevcutsa bu kaynaklar referans olarak gösterilir</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş/Doğum Tarihi</td></tr><tr><td>Referans Numarası</td><td>FO210</td></tr><tr><td>Tanım</td><td>Kurumun faaliyet gösterdiği ilk tarihi ifade eder. Şahıslar için doğum tarihi kabul edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kapanış/Ölüm Tarihi</td></tr><tr><td>Referans Numarası</td><td>FO290</td></tr><tr><td>Tanım</td><td>Kurumun faaliyetlerinin sona erdiği tarihi ya da sadece devrettiği o fon için devrettiği tarihi ifade eder. Şahıslar için ölüm tarihi kabul edilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yöneticiler</td></tr><tr><td>Referans Numarası</td><td>FO130</td></tr><tr><td>Tanım</td><td>Kurumda yöneticilik yapmış kişilerin tanımlandığı üstveri dizinidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş Yeri</td></tr><tr><td>Referans Numarası</td><td>FO150</td></tr><tr><td>Tanım</td><td>Kurumun faaliyet gösterdiği yeri ifade eder. Şahıslar için doğum yeri, yaşadığı yer gibi alanlar dâhil edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Devamı olduğu Kurumlar (Varsa)</td></tr><tr><td>Referans Numarası</td><td>FO090</td></tr><tr><td>Tanım</td><td>Daha evvel bir fonun devamı olup olmadığının ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Önemli Tarihler</td></tr><tr><td>Referans Numarası</td><td>FO250</td></tr><tr><td>Tanım</td><td>Fon içinde geçen önemli tarihlerin vurgulandığı tarihlerdir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Koleksiyon tanımı</td></tr><tr><td>Referans Numarası</td><td>FO320</td></tr><tr><td>Tanım</td><td>Devredilecek koleksiyonun tanımını içeren üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı hizmetleri</td></tr><tr><td>Referans Numarası</td><td>FO380</td></tr><tr><td>Tanım</td><td>Arşiv kullanıcılarını kayıt altına almaya yönelik bir sistemi bünyesinde barındırması ya da Kayıtlı kullanıcıların arşiv malzemesini nasıl kullandıklarının (görme, kopya üretme, referans verme) kayıt altına alınması ile ilgili bilgilerin yönetilmesine yönelik fonksiyonların izlendiği üstveri alanıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Adres</td></tr><tr><td>Referans Numarası</td><td>FO470</td></tr><tr><td>Tanım</td><td>İlgili Kurumun adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Telefon</td></tr><tr><td>Referans Numarası</td><td>FO480</td></tr><tr><td>Tanım</td><td>İlgili kurumun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İnternet Adresi</td></tr><tr><td>Referans Numarası</td><td>FO490</td></tr><tr><td>Tanım</td><td>İlgili kurumun internet adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Adresi</td></tr><tr><td>Referans Numarası</td><td>FO810</td></tr><tr><td>Tanım</td><td>İlgili kurumun e-posta adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP adresi</td></tr><tr><td>Referans Numarası</td><td>FO960</td></tr><tr><td>Tanım</td><td>İlgili kurumun kullandığı Kayıtlı Elektronik Posta adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 427,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 428,
                    StandartID = 1,
                    BaslikNo = "19.18",
                    Baslik = "Alt Fon/ Alt Kurum Üstveri Elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>Alt Fon/ Alt Kurum Üstveri Elemanları</td></tr><tr><td>Referans Numarası</td><td>AF001</td></tr><tr><td>Tanım</td><td>DETSİS’te tanımlı idari kimlik kodunu ifade eder. Tüzel bir kuruluş olması durumunda MERSİS ticari sicil numarası kullanılabilir. Bir şahıs olması durumunda ise Şahsa ait vatandaşlık numarasını ifade eder. Şahsa ait bir vatandaşlık numarası yoksa otorite dosyasından bir ID üretilerek şahısla eşleştirilir. Aynı şekilde bir kurum veya tüzel kuruluş için de ilgili veri tabanlarında kayıt bulunamazsa otorite dosyası üzerinden bir ID üretilerek işlem yapılabilir. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Kuruma bağlı bir birimi ifade etmek için de kullanılabilir.</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alt Fon /Alt Kurum Adı</td></tr><tr><td>Referans Numarası</td><td>AF010</td></tr><tr><td>Tanım</td><td>Alt kurumunun kanundaki tam adını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yasal Dayanak</td></tr><tr><td>Referans Numarası</td><td>AF110</td></tr><tr><td>Tanım</td><td>Saklama koşulunun hangi yasal düzenlemeye göre atandığını gösteren bilgidir. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarihçe (İdari/Biyografik Tarih)</td></tr><tr><td>Referans Numarası</td><td>AF100</td></tr><tr><td>Tanım</td><td>Tanımlama biriminin şartları ve çevresi içinde bir yere oturtabilmek ve daha anlaşılabilir kılmak amacıyla üreticisi hakkında idari tarih ya da biyografik ayrıntılar sağlamak amacıyla kullanılan üstveri</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tanımlama biriminin oluşumundan sorumlu kurumun(ların) ortaya çıkış, ilerleme, gelişim ve işleyişi ya da şahsın(ların) yaşamı ve çalışmaları konusunda önemli bilgi özet olarak verilir. Eğer basılı kaynaklarda ek bilgi mevcutsa bu kaynaklar referans olarak gösterilir</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş/Doğum Tarihi</td></tr><tr><td>Referans Numarası</td><td>AF210</td></tr><tr><td>Tanım</td><td>Alt kurumun faaliyet gösterdiği ilk tarihi ifade eder. Şahıslar için doğum tarihi kabul edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kapanış/Ölüm Tarihi</td></tr><tr><td>Referans Numarası</td><td>AF290</td></tr><tr><td>Tanım</td><td>Alt kurumun faaliyetlerinin sona erdiği tarihi ya da sadece devrettiği o fon için devrettiği tarihi ifade eder. Şahıslar için ölüm tarihi kabul edilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yöneticiler</td></tr><tr><td>Referans Numarası</td><td>AF130</td></tr><tr><td>Tanım</td><td>Kurumda yöneticilik yapmış kişilerin tanımlandığı üstveri dizinidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş Yeri</td></tr><tr><td>Referans Numarası</td><td>AF150</td></tr><tr><td>Tanım</td><td>Kurumun faaliyet gösterdiği yeri ifade eder. Şahıslar için doğum yeri, yaşadığı yer gibi alanlar dâhil edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Devamı olduğu Kurumlar (Varsa)</td></tr><tr><td>Referans Numarası</td><td>AF090</td></tr><tr><td>Tanım</td><td>Daha evvel bir fonun devamı olup olmadığının ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Önemli Tarihler</td></tr><tr><td>Referans Numarası</td><td>AF250</td></tr><tr><td>Tanım</td><td>Fon içinde geçen önemli tarihlerin vurgulandığı tarihlerdir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Koleksiyon tanımı</td></tr><tr><td>Referans Numarası</td><td>AF320</td></tr><tr><td>Tanım</td><td>Devredilecek koleksiyonun tanımını içeren üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı hizmetleri</td></tr><tr><td>Referans Numarası</td><td>AF380</td></tr><tr><td>Tanım</td><td>Arşiv kullanıcılarını kayıt altına almaya yönelik bir sistemi bünyesinde barındırması ya da Kayıtlı kullanıcıların arşiv malzemesini nasıl kullandıklarının (görme, kopya üretme, referans verme) kayıt altına alınması ile ilgili bilgilerin yönetilmesine yönelik fonksiyonların izlendiği üstveri alanıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Adres</td></tr><tr><td>Referans Numarası</td><td>AF470</td></tr><tr><td>Tanım</td><td>İlgili Kurumun adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Telefon</td></tr><tr><td>Referans Numarası</td><td>AF480</td></tr><tr><td>Tanım</td><td>İlgili kurumun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İnternet Adresi</td></tr><tr><td>Referans Numarası</td><td>AF490</td></tr><tr><td>Tanım</td><td>İlgili kurumun internet adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Adresi</td></tr><tr><td>Referans Numarası</td><td>AF810</td></tr><tr><td>Tanım</td><td>İlgili kurumun e-posta adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP adresi</td></tr><tr><td>Referans Numarası</td><td>AF960</td></tr><tr><td>Tanım</td><td>İlgili kurumun kullandığı Kayıtlı Elektronik Posta adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 428,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 429,
                    StandartID = 1,
                    BaslikNo = "19.19",
                    Baslik = "Fon Grubu Üstveri Tanımları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>Fon Grubu Üstveri Tanımları</td></tr><tr><td>Referans Numarası</td><td>FG001</td></tr><tr><td>Tanım</td><td>Fon grubu kodunun tanımlandığı üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Fon Grup Tanımı</td></tr><tr><td>Referans Numarası</td><td>FG010</td></tr><tr><td>Tanım</td><td>ir arşiv kurumu içerisindeki benzer fonksiyonlara sahip kurumlardan gelen arşiv malzemelerinin bütününün ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 429,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 430,
                    StandartID = 1,
                    BaslikNo = "19.20",
                    Baslik = "Arşiv Kurumları Üstverisi Tanımları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>rşiv Kurum Kodu</td></tr><tr><td>Referans Numarası</td><td>AK001</td></tr><tr><td>Tanım</td><td>rşiv kurumunun kodlandığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>rşiv Kurum Adı</td></tr><tr><td>Referans Numarası</td><td>AK010</td></tr><tr><td>Tanım</td><td>Belirli bir yasal çerçeve içerisinde faaliyet gösteren ve farklı kurumlar tarafından üretilmiş olan arşiv malzemesini ayıklama, düzenleme, tanımlama, hizmete sunma ve diğer yönetimsel fonksiyonları yerine getiren ulusal, bölgesel ya da özel amaçlı arşiv kurumlarını ifade eden üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş Tarihi</td></tr><tr><td>Referans Numarası</td><td>AK210</td></tr><tr><td>Tanım</td><td>Arşiv kurumun faaliyetlerine başladığı tarihi ifade eder </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarihçe (İdari/Biyografik Tarih)</td></tr><tr><td>Referans Numarası</td><td>AK100</td></tr><tr><td>Tanım</td><td>rşiv kurumunun yıllar içerisinde uğramış olduğu fonksiyon değişiklikleri önemli mevzuat gelişmeleri vb. gibi durumları ifade etmek için kullanılan üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Koleksiyon Tanımı</td></tr><tr><td>Referans Numarası</td><td>AK320</td></tr><tr><td>Tanım</td><td>Arşiv kurumuna devredilen koleksiyonun tanımlandığı üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı Hizmetleri</td></tr><tr><td>Referans Numarası</td><td>AK380</td></tr><tr><td>Tanım</td><td>Arşiv kullanıcılarını kayıt altına almaya yönelik bir sistemi bünyesinde barındırması ya da Kayıtlı kullanıcıların arşiv malzemesini nasıl kullandıklarının (görme, kopya üretme, referans verme) kayıt altına alınması ile ilgili bilgilerin yönetilmesine yönelik fonksiyonların izlendiği üstveri alanıdır..</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Adres</td></tr><tr><td>Referans Numarası</td><td>AK470</td></tr><tr><td>Tanım</td><td>Arşiv Kurumunun adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Telefon</td></tr><tr><td>Referans Numarası</td><td>AK480</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İnternet Adresi</td></tr><tr><td>Referans Numarası</td><td>AK490</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun internet adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Adresi</td></tr><tr><td>Referans Numarası</td><td>AK810</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun e-posta adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP adresi</td></tr><tr><td>Referans Numarası</td><td>AK960</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun kullandığı Kayıtlı Elektronik Posta adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 430,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 431,
                    StandartID = 1,
                    BaslikNo = "19.21",
                    Baslik = "İşlem Tanımları Üstveri Alanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>İşlem referans numarası</td></tr><tr><td>Referans Numarası</td><td>IT001</td></tr><tr><td>Tanım</td><td>Yapılan işlemin referans numarasını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Sorumlu Personel</td></tr><tr><td>Referans Numarası</td><td>IT110</td></tr><tr><td>Tanım</td><td>Yapılan işlemden sorumlu personel veya personelleri ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İşlem Başlama Tarihi</td></tr><tr><td>Referans Numarası</td><td>IT210</td></tr><tr><td>Tanım</td><td>İşlemin başlama tarihini ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İşlem Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>IT290</td></tr><tr><td>Tanım</td><td>İşlemin bitiş tarihini ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Maliyet</td></tr><tr><td>Referans Numarası</td><td>IT352</td></tr><tr><td>Tanım</td><td>Yapılan işlemin maliyetinin ne kadar olduğunun belirtildiği üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Notlar</td></tr><tr><td>Referans Numarası</td><td>IT800</td></tr><tr><td>Tanım</td><td>İşlem tanımı ile ilgili belirtilmesi gerekenlerin ifade edildiği üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yetkili Personel</td></tr><tr><td>Referans Numarası</td><td>IT115</td></tr><tr><td>Tanım</td><td>İşlemi yapma yetkisi bulunan personeli ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Elektronik belgenin üretim, iletim ve alındısına ait tarih bilgilerinin fiziksel olarak belgeye eklenmesi veya belge ile mantıksal olarak ilişkilendirilmesidir </td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarih ve Zaman Damgası</td></tr><tr><td>Referans Numarası</td><td>IT550</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Güncelleme İçeriği</td></tr><tr><td>Referans Numarası</td><td>IT320</td></tr><tr><td>Tanım</td><td>Yapılan işlemin ne olduğu ve hangi güncellemeleri kapsadığının ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 431,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 432,
                    StandartID = 1,
                    BaslikNo = "19.22",
                    Baslik = "E-Posta Üstveri Elemanlar",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>e-Posta ID</td></tr><tr><td>Referans Numarası</td><td>EP001</td></tr><tr><td>Tanım</td><td>E-postanın sistem tarafından verilen ve tekrar etmeyen referans numarasıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Hesap</td></tr><tr><td>Referans Numarası</td><td>EP010</td></tr><tr><td>Tanım</td><td>Posta içeriğinden sorumlu kişi veya hesabın bulunduğu kişiyi ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alıcı (To)</td></tr><tr><td>Referans Numarası</td><td>EP020</td></tr><tr><td>Tanım</td><td>E-postayı alan hesabı ifade eder. Asıl postayı alan muhataptır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Gönderen (From)</td></tr><tr><td>Referans Numarası</td><td>EP050</td></tr><tr><td>Tanım</td><td>Elektronik postayı gönderen hesabı ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>lıcı İlgili-Görünür (CC) (Varsa)</td></tr><tr><td>Referans Numarası</td><td>EP030</td></tr><tr><td>Tanım</td><td>E-postayı kopya olarak alan başka bir hesabı ifade eder. Mesajı alan kişi tarafından görülürdür.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alıcı İlgili-Görünmez (BCC) (Varsa)</td></tr><tr><td>Referans Numarası</td><td>EP080</td></tr><tr><td>Tanım</td><td>E-postayı kopya olarak alan başka bir hesabı ifade der. Mesajı alan kişi görünür değildir. Postayı gönderen hesap tarafından bilinirdir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Gönderim Tarihi/Zamanı</td></tr><tr><td>Referans Numarası</td><td>EP210</td></tr><tr><td>Tanım</td><td>E-Postanın gönderildiği tarih ve zaman bilgisidir. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alma Tarihi/Zamanı</td></tr><tr><td>Referans Numarası</td><td>EP220</td></tr><tr><td>Tanım</td><td>E-postanın alıcısı tarafından alındığı tarihtir ve zamandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Gönderim tarihi/zamanı ile alma tarihi/zamanı arasında çeşitli sebeplerden kaynaklanan farklılıklar olabilir.</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Konusu</td></tr><tr><td>Referans Numarası</td><td>EP055</td></tr><tr><td>Tanım</td><td>Elektronik postanın içeriği hakkında kısa bilginin olduğu alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Ek Bilgisi</td></tr><tr><td>Referans Numarası</td><td>EP750</td></tr><tr><td>Tanım</td><td>E-postanın eki ya da eklerini olup olmadığını belirlendiği alandır </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-postanın eki ya da eklerini olup olmadığını belirlendiği alandır </td></tr><tr><td>Referans Numarası</td><td>EP300</td></tr><tr><td>Tanım</td><td>E-postanın gövde metnini ifade eden alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-postanın Sisteme Kayıt Edilme Tarihi/Zamanı</td></tr><tr><td>Referans Numarası</td><td>EP240</td></tr><tr><td>Tanım</td><td>Alınan e-postanın sisteme kayıt edilme tarihini/zamanını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP Sağlayıcı Kurulu</td></tr><tr><td>Referans Numarası</td><td>EP850</td></tr><tr><td>Tanım</td><td>Kayıtlı Elektronik Posta Sağlayıcısının bilgilerini içerir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 401,
                    StandartIcerikTipiID = 168,
                    SiraNo = 432,
                    DurumID = 1,
                    StandartIcerikDenetim =
                        new StandartIcerikDenetim {
                        StandartID = 1,
                        Secmeli = false,
                        Zorunlu = false,
                        BilgiAmacli = false,
                        KurumYeterlilikSertifikasi = false,
                        UrunSertifikasi = true,
                        DurumID = 1
                        }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 433,
                    StandartID = 1,
                    BaslikNo = "20",
                    Baslik = "Yararlanılan Kaynaklar",
                    Detay = "<p>ANSI/ARMA 5-2010. Vital Records Programs: Identifying, Managing, and Recovering BusineÜS-Critical Records ARMA International, 2010, ISBN 978-1-931786-87-4</p><p>BS 10008:2014. Evidential weight and legal admiÜSibility of electronic information. Specification, London:2014,  ISBN 978 0 580 83673 2</p><p>Design Criteria Standard for Electronic Records Management Software Applicaitons. DoD 5015-2-STD. Washington, DC: Department of Defence, 25 Nisan 2007.</p><p>Digital recordkeeping: guidelines for creating, managing and preserving digital records. Canberra: National Archives of Australia, 2004. ISBN 1-620807-08-X</p><p>Digital Preservation in Archives:Overview of Current Research and Practices, National Archives of Sweden, 2005</p><p>ANSI/NISO Z39.85-2012: The Dublin Core Metadata Element Set, The American National Standards Institute, 20 Şubat 2013, IÜSN: 1041-5635</p><p>Guide for managing electronic records from an archival perspective. Paris: ICA Committee on Electronic Records, 1997. ISBN 0-9682361-0-3</p><p>ISO 15836:2009 -Information and documentation -- The Dublin Core metadata element set, Cenevre: ISO, 2009.</p><p>International Research on Permanent Authentic Records in Electronic Systems (InterPARES) 2: Experiential, Interactive and Dynamic Records, ed. Luciana Duranti ve Randy Preston, AÜSociazione Nazionale Archivistica Italiana Padova, Italy, 2008</p><p>ISAD (G): General International Standard Archival Description. 2nd ed. Stockholm, Sweden: ICA, Committee on Descriptive Standards, 2000. ISBN: 0-9696035-5-X</p><p>ISO 15489-1: 2001. Information and Documentation – Records Management. Part 1: General. Cenevre: ISO, 2001.</p><p>ISO 15489-2: 2001. Information and Documentation – Records Management. Part 2: Guidelines. Cenevre:ISO, 2001.</p><p>ISO/TSE 17799. Information technology: Code of practice for information security management. Cenevre: ISO, 2005.</p><p>Kandur, Hamza. Elektronik Belge Yönetim Sistemleri Referans Kriterleri v.2, Başbakanlık Devlet Arşivleri Genel Müdürlüğü, 2006, Ankara, Cumhuriyet Arşivi Daire Başkanlığı Yayın Nu: 29, ISBN: 975-19-3877-5 Management, appraisal and preservation of electronic records. 2 vol. 2nd ed. London: Public Record Office, 1999.</p><p>MoReq2 Specification: Model requirements for the management of electronic records Update  and Extension, 2008,  European CommiÜSion by Serco Consulting with funding from the IDABC programme, ISBN 978-9279-09772-0, DOI 10.2792/11981</p><p>NISO Z39-50. Information Retrieval : Application Service Definition & Protocol Specification. Bethesda, Maryland: National Information Standards Organizatoin, 2002. ISBN: 1-8800124-55-6. IÜSN: 1041-5653. NISO Z39-87. Data Dictionary – Technical Metadata for Digital Still Images. Draft standard for trial use. Bethesda, Maryland: National Information Standards Organizatoin, 2003.</p><p>Records/Document/Information Management (RDIM): Integrated Document Management System for the Government of Canada.Ottowa: National Archives Canada, 1996.</ p >< p > Requirements for Electronic Records Management Systems.Londra: Public Record Office, 2002.</ p >< p > Yalçınkaya, Bahattin.E - Devlet Üstveri Standardının Oluşturulması ve Türkiye İçin Modellenmesi, (Doktora Tezi) Marmara Üniversitesi, Bilgi ve Belge Yönetimi, 2014, Tez Numarası: 10028138 </ p > ",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 170,
                    SiraNo = 433,
                    DurumID = 1
                }           
            });
            #endregion
           
            #region //StandartIcerikPuan
            context.StandartIcerikPuanlar.AddRange(new List<StandartIcerikPuan>
            {
                new StandartIcerikPuan
                {
                    StandartIcerikPuanID = 1,                    
                    TipAdi = "Seçmeli",
                    Puan = 5,
                    DurumID = 1
                },
                new StandartIcerikPuan
                {
                    StandartIcerikPuanID = 2,                    
                    TipAdi = "Zorunlu",
                    Puan = 10,
                    DurumID = 1
                },
                new StandartIcerikPuan
                {
                    StandartIcerikPuanID = 3,                   
                    TipAdi = "Bilgi Amaçlı",
                    Puan = 1,
                    DurumID = 1
                }
            });
            #endregion

            #region //Kisi
            context.Kisiler.AddRange(new List<Kisi>
            {
                #region //1 Halil İbrahim Poyraz
                new Kisi
                {
                    KisiID = 1,
                    TcKimlikNo = 28661334272,
                    Adi = "Halil İbrahim",
                    Soyadi = "Poyraz",
                    Unvan = "Senior Software Engineer",
                    FirmaID = 2,
                    DurumID = 1
                },
                #endregion
                #region //2 Ali Atabey
                new Kisi
                {
                    KisiID = 2,
                    TcKimlikNo = 44080828284,
                    Adi = "Ali",
                    Soyadi = "Atabey",
                    Unvan = "Full Stack Software Developer",
                    FirmaID = 3,
                    DurumID = 1
                }
                #endregion
            });
            #endregion

            #region //Firma
            context.Firmalar.AddRange(new List<Firma>
            {
                #region //1 Türk Standartları Enstitüsü
                new Firma
                {
                    FirmaID = 1,
                    TicaretUnvani = "Türk Standartları Enstitüsü",
                    WebAdresi = "http://www.tse.org.tr",
                    DurumID = 1
                },
                #endregion
                #region //2 Beyaz Yazılım
                new Firma
                {
                    FirmaID = 2,
                    TicaretUnvani = "Beyaz Yazılım Ltd. Şti.",
                    WebAdresi = "http://www.beyazyazilim.com",
                    DurumID = 1
                },
                #endregion
                #region //3 Yeditepe Turizm
                new Firma
                {
                    FirmaID = 3,
                    TicaretUnvani = "Yeditepe Turizm Gıda Reklam Yayın Bilgisayar Hiz. San. Ve Tic. Ltd. Şti.",
                    WebAdresi = "http://www.yeditepeturizm.com.tr",
                    DurumID = 1
                }
                #endregion                
            });
            base.Seed(context);
            #endregion

            #region //Adres
            context.Adresler.AddRange(new List<Adres>
            {
                new Adres
                {
                    AdresID = 1,
                    FirmaID = 1,
                    AdresTipiID = 159,
                    AdresSatiri = "Necatibey Cad. No:112 06100",
                    IlceID = 63,
                    SehirID = 6,
                    UlkeID = 1,
                    VarsayilanAdres = true,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 2,
                    FirmaID = 1,
                    AdresTipiID = 160,
                    AdresSatiri = "Necatibey Cad. No:112 06100",
                    IlceID = 63,
                    SehirID = 6,
                    UlkeID = 1,
                    VarsayilanAdres = false,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 3,
                    KisiID = 2,
                    AdresTipiID = 158,
                    AdresSatiri = "Asariye Caddesi Şeferliveli Sokak No:19 Kat:2 Daire:2",
                    IlceID = 431,
                    SehirID = 34,
                    UlkeID = 1,
                    VarsayilanAdres = true,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 4,
                    KisiID = 2,
                    AdresTipiID = 160,
                    AdresSatiri = "Asariye Caddesi Şeferliveli Sokak No:19 Kat:2 Daire:2",
                    IlceID = 431,
                    SehirID = 1,
                    UlkeID = 1,
                    VarsayilanAdres = false,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 5,
                    KisiID = 1,
                    AdresTipiID = 158,
                    AdresSatiri = "Çubuklu Mahallesi Nazım Tur Caddesi Mola Çıkmazı Sokak No:4/1",
                    IlceID = 432,
                    SehirID = 34,
                    UlkeID = 1,
                    VarsayilanAdres = true,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 6,
                    KisiID = 1,
                    AdresTipiID = 160,
                    AdresSatiri = "Çubuklu Mahallesi Nazım Tur Caddesi Mola Çıkmazı Sokak No:4/1",
                    IlceID = 432,
                    SehirID = 1,
                    UlkeID = 1,
                    VarsayilanAdres = false,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 7,
                    FirmaID = 3,
                    AdresTipiID = 159,
                    AdresSatiri = "İnkılap Mahallesi Küçüksu Caddesi No:101 K:5 D:10",
                    IlceID = 451,
                    SehirID = 34,
                    UlkeID = 1,
                    VarsayilanAdres = true,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 8,
                    FirmaID = 3,
                    AdresTipiID = 160,
                    AdresSatiri = "İnkılap Mahallesi Küçüksu Caddesi No:101 K:5 D:10",
                    IlceID = 451,
                    SehirID = 34,
                    UlkeID = 1,
                    VarsayilanAdres = false,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 9,
                    FirmaID = 2,
                    AdresTipiID = 159,
                    AdresSatiri = "Fetih Mahallesi Tahralı Sokak Kavakyeli Plaza No:7 Daire:15",
                    IlceID = 462,
                    SehirID = 34,
                    UlkeID = 1,
                    VarsayilanAdres = true,
                    DurumID = 1
                },
                new Adres
                {
                    AdresID = 10,
                    FirmaID = 2,
                    AdresTipiID = 160,
                    AdresSatiri = "Fetih Mahallesi Tahralı Sokak Kavakyeli Plaza No:7 Daire:15",
                    IlceID = 462,
                    SehirID = 34,
                    UlkeID = 1,
                    VarsayilanAdres = true,
                    DurumID = 1
                }
            });
            #endregion

            #region //Telefon
            context.Telefonlar.AddRange(new List<Telefon>
            {
                new Telefon
                {
                    TelefonID = 1,
                    KisiID = 1,
                    TelefonTipiID = 154,
                    TelefonNo = "05345950053",
                    VarsayilanTelefon = true,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 2,
                    KisiID = 2,
                    TelefonTipiID = 154,
                    TelefonNo = "05332713638",
                    VarsayilanTelefon = true,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 3,
                    KisiID = 2,
                    TelefonTipiID = 155,
                    TelefonNo = "02122605262",
                    VarsayilanTelefon = false,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 4,
                    KisiID = 2,
                    TelefonTipiID = 156,
                    TelefonNo = "4447084",
                    DahiliNo = "122",
                    VarsayilanTelefon = false,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 5,
                    KisiID = 2,
                    TelefonTipiID = 157,
                    TelefonNo = "02124496227",
                    VarsayilanTelefon = false,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 6,
                    FirmaID = 3,
                    TelefonTipiID = 156,
                    TelefonNo = "4447084",
                    VarsayilanTelefon = true,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 7,
                    FirmaID = 2,
                    TelefonTipiID = 156,
                    TelefonNo = "02164257262",
                    VarsayilanTelefon = true,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 8,
                    FirmaID = 2,
                    TelefonTipiID = 156,
                    TelefonNo = "02163215165",
                    VarsayilanTelefon = false,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 9,
                    FirmaID = 2,
                    TelefonTipiID = 157,
                    TelefonNo = "02164863424",
                    VarsayilanTelefon = false,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 10,
                    FirmaID = 1,
                    TelefonTipiID = 156,
                    TelefonNo = "03124166200",
                    VarsayilanTelefon = true,
                    DurumID = 1
                },
                new Telefon
                {
                    TelefonID = 11,
                    FirmaID = 1,
                    TelefonTipiID = 157,
                    TelefonNo = "03124166611",
                    VarsayilanTelefon = false,
                    DurumID = 1
                }
            });
            #endregion

            #region //Eposta
            context.Epostalar.AddRange(new List<Eposta>
            {
                new Eposta
                {
                    EpostaID = 1,
                    KisiID = 1,
                    EpostaAdresi = "h.ibrahimpoyraz@gmail.com",
                    VarsayilanEposta = true,
                    DurumID = 1
                },
                new Eposta
                {
                    EpostaID = 2,
                    KisiID = 1,
                    EpostaAdresi = "hll_pyrz@hotmail.com",
                    VarsayilanEposta = false,
                    DurumID = 1
                },
                new Eposta
                {
                    EpostaID = 3,
                    KisiID = 2,
                    EpostaAdresi = "ali@trendax.com.tr",
                    VarsayilanEposta = true,
                    DurumID = 1
                },
                new Eposta
                {
                    EpostaID = 4,
                    FirmaID = 3,
                    EpostaAdresi = "info@yeditepeturizm.com.tr",
                    VarsayilanEposta = true,
                    DurumID = 1
                },
                new Eposta
                {
                    EpostaID = 5,
                    FirmaID = 2,
                    EpostaAdresi = "yazilim@beyazyazilim.com",
                    VarsayilanEposta = true,
                    DurumID = 1
                },
                new Eposta
                {
                    EpostaID = 6,
                    FirmaID = 1,
                    EpostaAdresi = "info@tse.org.tr",
                    VarsayilanEposta = true,
                    DurumID = 1
                }
            });
            #endregion

            #region //FaturaBilgi
            context.FaturaBilgileri.AddRange( new List<FaturaBilgi>
            {
                new FaturaBilgi
                {
                    FaturaBilgiID = 1,
                    FirmaID = 1,
                    VergiDairesi = "Çankaya",
                    VergiNo = "1260154581",
                    AdresID = 2,
                    DurumID = 1
                },
                new FaturaBilgi
                {
                    FaturaBilgiID = 2,
                    KisiID = 2,
                    VergiDairesi = "Beyoğlu",
                    VergiNo = "9879876541",
                    AdresID = 4,
                    DurumID = 1
                },
                new FaturaBilgi
                {
                    FaturaBilgiID = 3,
                    KisiID = 1,
                    VergiDairesi = "Üsküdar",
                    VergiNo = "9876543210",
                    AdresID = 6,
                    DurumID = 1
                },                
                new FaturaBilgi
                {
                    FaturaBilgiID = 4,
                    FirmaID = 3,
                    VergiDairesi = "Ümraniye",
                    VergiNo = "9460131281",
                    AdresID = 8,
                    DurumID = 1
                },
                new FaturaBilgi
                {
                    FaturaBilgiID = 5,
                    FirmaID = 2,
                    VergiDairesi = "Ataşehir",
                    VergiNo = "9876543210",
                    AdresID = 10,
                    DurumID = 1
                }                
            });
            #endregion

            #region //Hata
            context.Hatalar.AddRange(new List<Hata>
            {
                new Hata
                {
                    HataID = 1,
                    Baslik = "Parametre Hatası",
                    Detay = "HataId null değer olamaz."
                },
                new Hata
                {
                    HataID = 2,
                    Baslik = "Parametre Hatası",
                    Detay = "id geçersiz, null değer olamaz."
                },
                new Hata
                {
                    HataID = 3,
                    Baslik = "Parametre Hatası",
                    Detay = "Kayıt bulamadı."
                },
                new Hata
                {
                    HataID = 4,
                    Baslik = "Piston Aşşa Düştü !!!",
                    Detay = "Bilinmeyen bir hata oluştu."
                }
            });
            #endregion

            #region //Denetim            
            context.Denetimler.AddRange(new List<Denetim>
            {
                new Denetim
                {
                    DenetimID = 1,
                    StandartID = 1,
                    DenetimTipiID = 173,
                    FirmaID = 2,
                    DenetimTarihi = new DateTime(2017,2,15),
                    DurumID = 1
                },
                new Denetim
                {
                    DenetimID = 2,
                    StandartID = 1,
                    DenetimTipiID = 172,
                    FirmaID = 3,
                    DenetimTarihi = new DateTime(2017,3,24),
                    DurumID = 1                                            
                }             
            });
            #endregion

            base.Seed(context);
        }
    }
}