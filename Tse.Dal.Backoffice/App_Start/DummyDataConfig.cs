namespace Tse.Dal.Backoffice.App_Start
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public partial class DummyDataConfig : DropCreateDatabaseIfModelChanges<TseBackofficeContext>
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
                    Adi ="DokumanTipi",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =2,
                    Adi ="HazirlikGrubu",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =3,
                    Adi ="YururlukDurumu",
                    DurumID = 1
                },
                new Kategori
                {
                    KategoriID =4,
                    Adi ="StandartTur",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =5,
                    Adi ="TelefonTipi",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =6,
                    Adi ="AdresTipi",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =7,
                    Adi ="StandartIcerikTipi",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =8,
                    Adi ="AtifYapilanStandartTipi",
                    DurumID =1
                },
                new Kategori
                {
                    KategoriID =9,
                    Adi ="AtifYapilanDokumanTipi",
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
                    BaslikNo = "0",
                    Baslik = "Önsöz",
                    Detay = "<ul><li>- Bu standard, Türk Standardları Enstitüsü’nün Bilişim İhtisas Kurulu’na bağlı TK01 Bilişim Teknolojileri Teknik Komitesi’nce TS 13298: 2009’in revizyonu olarak hazırlanmış ve TSE Teknik Kurulu’nun 23 Ekim 2015 tarihli toplantısında kabul edilerek yayımına karar verilmiştir.</li><li>- Bu standardın daha önce yayımlanmış bulunan baskıları geçersizdir.</li><li>- Bu standardın hazırlanmasında, milli ihtiyaç ve imkânlarımız ön planda olmak üzere, milletlerarası standardlar ve ekonomik ilişkilerimiz bulunan yabancı ülkelerin standardlarındaki esaslar da gözönünde bulundurularak; yarar görülen hallerde, olabilen yakınlık ve benzerliklerin sağlanmasına ve bu esasların, ülkemiz şartları ile bağdaştırılmasına çalışılmıştır.</li><li>- Bu standard son şeklini almadan önce; bilimsel kuruluşlar, üretici/ imalatçı ve tüketici durumundaki konunun ilgilileri ile gerekli işbirliği yapılmış ve alınan görüşlere göre olgunlaştırılmıştır.</li><li>- Bu standardda kullanılan bazı kelime ve/veya ifadeler patent haklarına konu olabilir. Böyle bir patent hakkının belirlenmesi durumunda TSE sorumlu tutulamaz.</li></ul>",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 163,
                    SiraNo = 1,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 2,
                    StandartID = 1,
                    BaslikNo = "0",
                    Baslik = "Giriş",
                    Detay = @"<p>Bu standard, TS 13298:2009 Elektronik Belge Yönetimi standardının güncel ihtiyaçlara göre yeniden düzenlenmiş halini içermektedir. Standard bir önceki revizyonuna ilave olarak kurumlar arası belge paylaşımı, kayıtlı elektronik postaların yönetimi, elektronik yazışma paketi ve elektronik arşivlerin yönetimi başta olmak üzere bazı yenilikler getirmektedir.</p><p>Kurumların faaliyetlerini kayıt altına alması ve bu bilgileri paydaşları ile paylaşması kurumsal faaliyetlerin ayrılmaz bir parçasıdır. Herkesin, her zaman, her yerden kolaylıkla ulaşabileceği şeffaf, verimli ve sade bir kurum yapısı günümüzde modern ve demokratik kurumların temel hedefi haline gelmiştir. Bilgi ve iletişim teknolojilerindeki gelişmeler bu hedefi gerçekleştirecek olgunluğa ulaşmıştır ve her geçen gün daha da gelişmektedir. Son yıllarda sıkça duyduğumuz e-ticaret ve e-devlet gibi kavramlar bu gelişmelerin bir sonucudur. E-kurum yapısının temelini ise elektronik bilgi sistemleri oluşturmaktadır.</p><p>Kurumlarca üretilen bilgi ve belgelerin verimliliğinin arttırılması için ortak standard ve politikaların belirlenmesi göz ardı edilemez bir gereksinimdir. Böyle bir çalışma kullanımı kolay, erişimi hızlı, güvenilir, ucuz, sürekli ve sağlam 'elektronik kurum' yapısının oluşumuna katkı sağlayarak genelde 'e-toplum'a geçiş sürecini hızlandıracaktır.</p><p>E-kurum faaliyetleri sonucu oluşan elektronik dokümanların belge vasfının korunması, onların üretim aşamasında ve hatta üretim öncesinde elektronik bilgi sistemleri tasarımı aşamasında ele alınmalarını gerekli kılmaktadır. Belge kavramının sistem tasarımcıları ve kullanıcılar tarafından iyi algılanması ve belge yönetimi gereksinimlerinin uygulanması gerekmektedir.</p><p>Elektronik belge yönetimi son derece geniş ve karmaşık bir alandır. Bu alan bir sistem yaklaşımı ile ele alınmalı ve sistemi oluşturan öğelerin birbiri ile uyumlu çalışması için gerekli önlemler alınmalıdır.</p><p>Sistemi oluşturan öğelerin başında Elektronik Belge Yönetim Sistemi (EBYS) yazılımı gelmektedir. Elektronik belgeyi yönetmeye talip her kurum bu konuda uzmanlaşmış bir yazılıma ihtiyaç duyacaktır. Bir EBYS yazılımı hiç şüphesiz kurum ERP yazılımlarının bir parçası olarak üretilebilir ya da kurum fonksiyonlarını elektronik ortamda yürütmek için kullanılan diğer yazılımlarla entegre çalışabilen bağımsız bir paket de olabilir. Bu standard bir EBYS yazılımında bulunması gereken asgari fonksiyonel özellikleri tanımlamaktadır.</p><p>Sistemi oluşturan bir diğer öğe kurumsal politika ve prosedürlerdir. Kurum bilgi ve belge yönetimi prosedürleri EBYS için bir girdi olarak düşünülebilir. Kurumsal belge yönetimi politika ve prosedürlerini henüz geliştirme aşamasında olan kurumlar, bu standardı bir referans kaynağı olarak kullanabilirler.</p><p>Standardın bu revizyonunda Elektronik Arşivleme Sistemi Referans Modelinin (ELAS/RM) adı altında yeni bir bölüm eklenmiştir. Bu bölüm:</p><ul><li>Elektronik belgelerin üretildikleri dönemdeki hukuki varlığının korunabilmesi,</li><li>Sürekli saklanacak elektronik belgelerin kesintisiz olarak erişilebilirliğinin sağlanması için gerekli tedbirlerin alınması,</li><li>Elektronik belgelerin üretildiği bilgi sistemi platformundan bağımsız olarak erişilebilir olması için gerekli sistem gereksinimlerini, elektronik arşivleme sistemleri uygulamalarında bulunması gerekli temel arşivcilik fonksiyonlarını ve elektronik arşivde yer alacak belgelerin sisteme transfer, düzenleme, tanımlama ve kullanımı gibi fonksiyonlara uygun üstveri modelini tanımlamaktır.</li><p>Bu standard, dört bölüm halinde tasarlanmıştır. Bu bölümler kendi içerisinde alt bölümlere ayrılmış ve bu alt bölümler altında da sistem gereksinimleri sıralanmıştır. Bu standard içinde yer alan bölümler şunlardır:</p><li>Sistem kriterleri: Sistem tasarımı ve elektronik belgelerin sisteme dâhil edilmesi için gerekli olan gereksinimlerin ele alındığı bölüm.</li><li>Belge kriterleri: Elektronik belge özellikleri, sayısal görüntüleme sistemleri ve fiziksel ortamdaki belgelerin yönetimi ve EBYS içerisine entegrasyonu gibi konuların ele alındığı bölüm.</li><li>Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM): Elektronik ortamda üretilmiş ya da sonradan elektronik ortama aktarılmış olan arşiv malzemesinin yönetimine yönelik kriterler bu bölümde tanımlanmıştır.</li><li>Üst veri elemanları: EBYS ve ELAS/RM’ye ait üst veri gereksinimleri bu bölümde tanımlanmıştır.</li><p>Sistem ve belge kriterleri ile elektronik arşivleme sistemi referans modeline ait düzenlemeler dört farklı şekilde kodlanmıştır. Her bir kriterin yanındaki kutucuklarda yer alan kodların açılımları şunlardır:</p><li>S/Z: İlgili maddenin seçmeli mi yoksa zorunlu mu olduğunu göstermek için kullanılmıştır.</li> <li>BA: Kriterin bilgi amaçlı olduğunu ifade eder. Genel olarak ürün veya kurum sertifikasyonunda kullanılmamakla birlikte sistemin geneli hakkında ya da ilgili olduğu bölüm ile ilgili teknik bilgi içermektedir.</li><li>KYS: Belge ve arşiv yönetim sistemini kullanan kurumlarda Kurum Yeterlilik Sertifikasyonu için aranacak şartlarla ilgili kriterlerdir. Sistem kurulumu öncesinde ya da esnasında yerine getirilmesi gereken şartları belirler. Ayrıca EBYS ürünü kullanacak kurumların KYS şartlarını sağlamaları ve akredite kurumlardan sertifika almaları gerekir.</li><li>ÜS: Ürün (EBYS yazılımları) sertifikasyonunda kullanılacak kriterleri tanımlar. Bu standarda uyumluluk belgesi alacak ürünlerin taşıması gereken asgari standartları belirler. Aynı ürün farklı ad ve markalar altında birden fazla sertifikalandırılamaz. Yetkili sertifikasyon kurumu, ürünler arasında bu türden bir benzerlik olduğuna karar verdiği durumlarda ürünlerin kaynak kodlarını değerlendirme amaçlı olarak talep edebilir.</li></ul>",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 163,
                    SiraNo = 2,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 3,
                    StandartID = 1,
                    BaslikNo = "1",
                    Baslik = "Kapsam",
                    Detay = @"<p>Bu standard, kurumlarda üretilen ve/veya üretilmesi muhtemel elektronik dokümanların belge niteliğinin korunabilmesi için gerekli standardların belirlenmesi amacıyla aşağıdaki konuları kapsar:</p><ol><li>Elektronik belge yönetimi sistemi (EBYS) için gerekli sistem gereksinimleri,</li><li>EBYS için gerekli belge yönetim teknikleri ve uygulamaları,</li><li>Elektronik belgelerin yönetilebilmesi için gerekli gereksinimler,</li><li>Elektronik ortamda üretilmemiş belgelerin yönetim fonksiyonlarının elektronik ortamda yürütülebilmesi içingerekli gereksinimler,</li><li>Elektronik belgelerde bulunması gereken diplomatik özellikler,</li><li>Elektronik belgelerin hukuki geçerliliklerinin sağlanması için alınması gereken önlemler,</li><li>Güvenli elektronik imza ve mühür sistemlerinin uygulanması için gerekli sistem alt yapısının tanımlanması.</li></ol><p>Bu standard, ayrıca, elektronik belgelerin arşivlenmesi ve yönetimine yönelik olarak da aşağıdaki konuları kapsamaktadır.</p><ol><li>Elektronik ortamda üretilmiş ve kurumsal kimlik doğrulama sistemleri ve/veya elektronik / mobil imza sistemleri ile imzalanmış kurumsal belgelerin,</li><li>Fiziksel ortamlarda üretilmiş olup sonradan sayısallaştırma yöntemi ile elektronik ortama aktarılmış yazılı, basılı, çizili her türlü doküman ve belgelerin,</li><li>Dijital olarak üretilmiş resim, ses ve görüntü kayıtlarının,</li><li>Sayısallaştırma yöntemi ile elektronik ortama aktarılmış analog resim, ses ve görüntü kayıtlarının yönetilmesine imkân sağlayacak düzenlemeleri kapsamaktadır.</li></ol><p>Bu standard, elektronik belgelerin üretim ortamına ait bilgi güvenliği ile ilgili herhangi bir kriter kapsamaz. Bilgi güvenliği yönetim sistemi ile ilgili olarak TS ISO/IEC 27001 standardı kullanılabilir.</p>",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 163,
                    SiraNo = 3,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 4,
                    StandartID = 1,
                    BaslikNo = "2",
                    Baslik = "Atıf yapılan standard ve/veya dokümanlar",
                    Detay = @"Aşağıda verilen, atıf yapılan standardların hükümleri bu standardın hükümleri sayılır. Tarih belirtilen atıflarda, daha sonra yapılan tadil ve revizyonlar uygulanmaz. Bununla birlikte, bu standarda dayalı anlaşmalarda taraflara, aşağıda verilen standardların en yeni baskılarını uygulama imkânını araştırmaları önerilir. Tarih belirtilmeyen atıflarda, ilgili standardın en son baskısı kullanılır. Bütün standardların yürürlükte bulunan baskıları TSE’den temin edilebilir. (*) işaretli olanlar bu standardın basıldığı tarihte İngilizce metin olarak yayımlanmış Türk Standardlarıdır.",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 161,
                    SiraNo = 4,
                    DurumID = 1,
                    StandartAtiflar = new List<StandartAtif>
                    {
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 1,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 2,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 3,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 4,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 5,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 6,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 8,
                            StandartAtifTipiSablonID = 7,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
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
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 10,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 11,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 12,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 13,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 14,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 15,
                            DurumID = 1
                        },
                        new StandartAtif
                        {
                            StandartID = 1,
                            StandartIcerikID = 4,
                            KategoriID = 9,
                            StandartAtifTipiSablonID = 16,
                            DurumID = 1
                        }
                    }
                },
                new StandartIcerik
                {
                    StandartIcerikID = 5,
                    StandartID = 1,
                    BaslikNo = "3",
                    Baslik = "Terimler, tarifler ve kısaltmalar",
                    Detay = "Bu standard için aşağıdaki terimler ve tarifler geçerlidir. Burada yer almayan terimler için ISO 15489’da belirtilen terimler ve tarifler kullanılmalıdır.",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 163,
                    SiraNo = 5,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 6,
                    StandartID = 1,
                    BaslikNo = "3.1",
                    Baslik = "Arşiv Kurumu",
                    Detay = "Belirli bir yasal çerçeve içerisinde faaliyet gösteren ve farklı kurumlar tarafından üretilmiş olan arşiv malzemesini ayıklama, düzenleme, tanımlama, hizmete sunma ve diğer yönetimsel fonksiyonları yerine getiren ulusal, bölgesel ya da özel amaçlı arşiv kurumları.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 6,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 7,
                    StandartID = 1,
                    BaslikNo = "3.2",
                    Baslik = "Arşiv Yönetim Sistemi (AYS)",
                    Detay = "Arşiv malzemesinin arşiv kurumlarına transferi, düzenlenmesi, tanımlanması, kullanıma sunulması, korunması ve diğer yönetimsel fonksiyonları gerçekleştirmek üzere geliştirilmiş bilgisayar sistemi.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 7,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 8,
                    StandartID = 1,
                    BaslikNo = "3.3",
                    Baslik = "Belge",
                    Detay = "Herhangi bir bireysel veya kurumsal fonksiyonun yerine getirilmesi için alınmış ya da fonksiyonun sonucunda üretilmiş, içerik, ilişki ve formatı ile ait olduğu fonksiyon için delil teşkil eden kayıtlı bilgi.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 8,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 9,
                    StandartID = 1,
                    BaslikNo = "3.4",
                    Baslik = "Diplomatik özellik",
                    Detay = "Belgelerin orijinalliğinin tespit edilmesinde kullanılabilecek her türlü içerik, format, ilişki ve sunum özellikleri.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 9,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 10,
                    StandartID = 1,
                    BaslikNo = "3.5",
                    Baslik = "Doküman",
                    Detay = "Kurumsal faaliyetlerin yerine getirilmesinde üretilen ya da toplanan, henüz belge vasfı kazanmamış her türlü kayıtlı bilgi.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 10,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 11,
                    StandartID = 1,
                    BaslikNo = "3.6",
                    Baslik = "Dosya tasnif planı",
                    Detay = "Kurumsal faaliyetlerin ve bu faaliyetler sonucunda oluşan belgelerin kurumsal yapıya ve hiyerarşiye uygun olarak konusal olarak sınıflandırılması için geliştirilmiş belge yönetim aracı.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 11,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 12,
                    StandartID = 1,
                    BaslikNo = "3.7",
                    Baslik = "Elektronik belge yönetimi",
                    Detay = "Kurumların gündelik işlerini yerine getirirken oluşturdukları her türlü dokümantasyonun içerisinden kurum faaliyetlerinin delili olabilecek belgelerin ayıklanarak bunların içerik, format ve ilişkisel özelliklerini korumak ve bu belgeleri üretimden nihai tasfiyeye kadar olan süreç içerisinde yönetmek.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 12,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 13,
                    StandartID = 1,
                    BaslikNo = "3.8",
                    Baslik = "Kurum arşivi",
                    Detay = "Ait olduğu kurum tarafından üretilen belgelerden idarî, malî ve hukukî açıdan saklama süresini doldurmuş olan arşiv belgelerinin ayıklanması, düzenlenmesi, tanımlanması, hizmete sunulması ve diğer yönetimsel fonksiyonları yerine getiren birim.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 13,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 14,
                    StandartID = 1,
                    BaslikNo = "3.9",
                    Baslik = "Provenans",
                    Detay = "Kendi faaliyetlerinin yürütülmesi sırasında belge üreten ve saklayan kişi veya kurumlar bir belgenin provenansını oluşturur. Provenans prensibi ise; aynı provenansa (kaynak, köken, menşe) sahip belgelerin, başka bir provenansa sahip olanlarla karıştırılmaması gerektiğini öngören temel ilke. 'Fonlara Saygı' (respectdes fonds) olarak da anılır.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 14,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 15,
                    StandartID = 1,
                    BaslikNo = "3.10",
                    Baslik = "Tasfiye",
                    Detay = "Kurumsal gereksinimler açısından saklanmasına gerek kalmayan belgelerin kurum belge sisteminin dışına çıkarılması. Tasfiye işlemi artık ihtiyaç duyulmayan belgelerin kurum içinde veya kurum dışında başka bir kuruma/birime transfer edilmesini ya da imha edilmesini öngörür.",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 15,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 16,
                    StandartID = 1,
                    BaslikNo = "3.11",
                    Baslik = "Varlık",
                    Detay = "Arşiv yönetim sistemi içerisinde yer alan ve bağımsız olarak tanımlanan belge, dosya / klasör, seri, fon, vs. gibi kayıtlar. <table><h3>Kısaltmalar</h3><tr><td>AYS</td><td>Arşiv Yönetim Sistemi</td></tr><tr><td>DERBİS</td><td>Dernekler Bilgi Sistemi</td></tr><tr><td>DETSİS</td><td>Devlet Teşkilatı Merkezi Kayıt Sistemi</td></tr><tr><td>DGS</td><td>Dijital Görüntüme Sistemi</td></tr><tr><td>DYS</td><td>Doküman Yönetim Sistemi</td></tr><tr><td>EBYS</td><td>Elektronik Belge Yönetim Sistemi</td></tr><tr><td>ELAS/RM</td><td>Elektronik Arşivleme Sistemi Referans Modeli</td></tr><tr><td>EYP</td><td>Elektronik Yazışma Paketi</td></tr><tr><td>KEP</td><td>Kayıtlı Elektronik Posta</td></tr><tr><td>KPS</td><td>Kimlik Paylaşım Sistemi</td></tr><tr><td>MERNİS</td><td>Merkezî Nüfus İdare Sistemi</td></tr><tr><td>MERSİS</td><td>Merkezi Sicil Kayıt Sistemi</td></tr><tr><td>MTK</td><td>Merkezi Tüzel Kişilik Bilgi Sistemi</td></tr><tr><td>UAPS</td><td>Ulusal Adres Paylaşım Sistemi</td></tr><tr><td>VBYS</td><td>Vakıf Bilgi Yönetim Sistemi</td></tr></table>",
                    UstIcerikID = 5,
                    StandartIcerikTipiID = 163,
                    SiraNo = 16,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 17,
                    StandartID = 1,
                    BaslikNo = "Bölüm 1:",
                    Baslik = "Sistem Kriterleri",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 162,
                    SiraNo = 17,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 18,
                    StandartID = 1,
                    BaslikNo = "4",
                    Baslik = "Dosya tasnif planları",
                    Detay = null,
                    UstIcerikID = 17,
                    StandartIcerikTipiID = 162,
                    SiraNo = 18,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 19,
                    StandartID = 1,
                    BaslikNo = "4.1",
                    Baslik = "Dosya planının oluşturulması",
                    Detay = null,
                    UstIcerikID = 18,
                    StandartIcerikTipiID = 162,
                    SiraNo = 19,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 20,
                    StandartID = 1,
                    BaslikNo = "4.2",
                    Baslik = "Dosya tasnif planı elemanlarının tanımlanması",
                    Detay = null,
                    UstIcerikID = 18,
                    StandartIcerikTipiID = 162,
                    SiraNo = 20,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 21,
                    StandartID = 1,
                    BaslikNo = "4.3",
                    Baslik = "Dosya tasnif planının yönetilmesi",
                    Detay = null,
                    UstIcerikID = 18,
                    StandartIcerikTipiID = 162,
                    SiraNo = 21,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 22,
                    StandartID = 1,
                    BaslikNo = "5",
                    Baslik = "Saklama planları",
                    Detay = null,
                    UstIcerikID = 17,
                    StandartIcerikTipiID = 162,
                    SiraNo = 22,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 23,
                    StandartID = 1,
                    BaslikNo = "5.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 162,
                    SiraNo = 23,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 24,
                    StandartID = 1,
                    BaslikNo = "5.2",
                    Baslik = "Belge hiyerarşisi",
                    Detay = null,
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 162,
                    SiraNo = 24,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 25,
                    StandartID = 1,
                    BaslikNo = "5.3",
                    Baslik = "Saklama kriterleri",
                    Detay = null,
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 162,
                    SiraNo = 25,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 26,
                    StandartID = 1,
                    BaslikNo = "5.4",
                    Baslik = "Saklama süreleri",
                    Detay = null,
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 162,
                    SiraNo = 26,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 27,
                    StandartID = 1,
                    BaslikNo = "5.5",
                    Baslik = "Tasfiye işlem tanımları",
                    Detay = null,
                    UstIcerikID = 22,
                    StandartIcerikTipiID = 162,
                    SiraNo = 27,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 28,
                    StandartID = 1,
                    BaslikNo = "6",
                    Baslik = "Elektronik belgelerin kayıt işlemleri",
                    Detay = null,
                    UstIcerikID = 17,
                    StandartIcerikTipiID = 162,
                    SiraNo = 28,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 29,
                    StandartID = 1,
                    BaslikNo = "6.1",
                    Baslik = "Genel Özellikler",
                    Detay = null,
                    UstIcerikID = 28,
                    StandartIcerikTipiID = 162,
                    SiraNo = 29,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 30,
                    StandartID = 1,
                    BaslikNo = "6.2",
                    Baslik = "Dokümanların belgeye dönüştürülmesi ve ilişkilendirme",
                    Detay = null,
                    UstIcerikID = 28,
                    StandartIcerikTipiID = 162,
                    SiraNo = 30,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 31,
                    StandartID = 1,
                    BaslikNo = "6.3",
                    Baslik = "Belge türleri",
                    Detay = null,
                    UstIcerikID = 28,
                    StandartIcerikTipiID = 162,
                    SiraNo = 31,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 32,
                    StandartID = 1,
                    BaslikNo = "6.4",
                    Baslik = "Elektronik postaların yönetimi",
                    Detay = null,
                    UstIcerikID = 28,
                    StandartIcerikTipiID = 162,
                    SiraNo = 32,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 33,
                    StandartID = 1,
                    BaslikNo = "6.5",
                    Baslik = "Taşıma, kopyalama ve silme",
                    Detay = null,
                    UstIcerikID = 28,
                    StandartIcerikTipiID = 162,
                    SiraNo = 33,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 34,
                    StandartID = 1,
                    BaslikNo = "6.6",
                    Baslik = "Referans kodlarının verilmesi",
                    Detay = null,
                    UstIcerikID = 28,
                    StandartIcerikTipiID = 162,
                    SiraNo = 34,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 35,
                    StandartID = 1,
                    BaslikNo = "7",
                    Baslik = "Elektronik Belgelerin Paylaşımı",
                    Detay = null,
                    UstIcerikID = 17,
                    StandartIcerikTipiID = 162,
                    SiraNo = 35,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 36,
                    StandartID = 1,
                    BaslikNo = "7.1",
                    Baslik = "Kurum Kodlarının Kullanılması",
                    Detay = null,
                    UstIcerikID = 35,
                    StandartIcerikTipiID = 162,
                    SiraNo = 36,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 37,
                    StandartID = 1,
                    BaslikNo = "7.2",
                    Baslik = "Kayıtlı Elektronik Posta (KEP)",
                    Detay = null,
                    UstIcerikID = 35,
                    StandartIcerikTipiID = 162,
                    SiraNo = 37,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 38,
                    StandartID = 1,
                    BaslikNo = "7.3",
                    Baslik = "Elektronik Yazışma Paketi",
                    Detay = null,
                    UstIcerikID = 35,
                    StandartIcerikTipiID = 162,
                    SiraNo = 38,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 39,
                    StandartID = 1,
                    BaslikNo = "8",
                    Baslik = "EBYS kullanım özellikleri",
                    Detay = null,
                    UstIcerikID = 17,
                    StandartIcerikTipiID = 162,
                    SiraNo = 39,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 40,
                    StandartID = 1,
                    BaslikNo = "8.1",
                    Baslik = "Kullanım – Genel kurallar",
                    Detay = null,
                    UstIcerikID = 39,
                    StandartIcerikTipiID = 161,
                    SiraNo = 40,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 41,
                    StandartID = 1,
                    BaslikNo = "8.2",
                    Baslik = "Arama",
                    Detay = null,
                    UstIcerikID = 39,
                    StandartIcerikTipiID = 161,
                    SiraNo = 41,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 42,
                    StandartID = 1,
                    BaslikNo = "8.3",
                    Baslik = "Görüntüleme",
                    Detay = null,
                    UstIcerikID = 39,
                    StandartIcerikTipiID = 161,
                    SiraNo = 42,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 43,
                    StandartID = 1,
                    BaslikNo = "8.4",
                    Baslik = "Yazdırma",
                    Detay = null,
                    UstIcerikID = 39,
                    StandartIcerikTipiID = 161,
                    SiraNo = 43,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 44,
                    StandartID = 1,
                    BaslikNo = "8.5",
                    Baslik = "Raporlama",
                    Detay = null,
                    UstIcerikID = 39,
                    StandartIcerikTipiID = 161,
                    SiraNo = 44,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 45,
                    StandartID = 1,
                    BaslikNo = "9",
                    Baslik = "Erişim kontrolü ve güvenlik",
                    Detay = null,
                    UstIcerikID = 17,
                    StandartIcerikTipiID = 162,
                    SiraNo = 45,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 46,
                    StandartID = 1,
                    BaslikNo = "9.1",
                    Baslik = "Sisteme Giriş",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 46,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 47,
                    StandartID = 1,
                    BaslikNo = "9.2",
                    Baslik = "Erişim Hakları",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 47,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 48,
                    StandartID = 1,
                    BaslikNo = "9.3",
                    Baslik = "Kullanıcı Profilleri",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 48,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 49,
                    StandartID = 1,
                    BaslikNo = "9.4",
                    Baslik = "Kullanıcı Rolleri",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 49,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 50,
                    StandartID = 1,
                    BaslikNo = "9.5",
                    Baslik = "Kullanıcı Grupları",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 50,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 51,
                    StandartID = 1,
                    BaslikNo = "9.6",
                    Baslik = "Kayıtlara erişim haklarının atanması ve uygulanması",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 51,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 52,
                    StandartID = 1,
                    BaslikNo = "9.7",
                    Baslik = "Üretim sorumluluğu ve mülkiyet",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 52,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 53,
                    StandartID = 1,
                    BaslikNo = "9.8",
                    Baslik = "Günlük dosyalarının oluşturulması",
                    Detay = null,
                    UstIcerikID = 45,
                    StandartIcerikTipiID = 161,
                    SiraNo = 53,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 54,
                    StandartID = 1,
                    BaslikNo = "10",
                    Baslik = "Sistem Tasarımı ve Yönetimi",
                    Detay = null,
                    UstIcerikID = 17,
                    StandartIcerikTipiID = 162,
                    SiraNo = 54,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 55,
                    StandartID = 1,
                    BaslikNo = "10.1",
                    Baslik = "Sistem bütünlüğü ve güvenirlik",
                    Detay = null,
                    UstIcerikID = 54,
                    StandartIcerikTipiID = 161,
                    SiraNo = 55,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 56,
                    StandartID = 1,
                    BaslikNo = "10.2",
                    Baslik = "Kullanım kolaylığı",
                    Detay = null,
                    UstIcerikID = 54,
                    StandartIcerikTipiID = 161,
                    SiraNo = 56,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 57,
                    StandartID = 1,
                    BaslikNo = "10.3",
                    Baslik = "Performans ve ölçeklenebilirlik",
                    Detay = null,
                    UstIcerikID = 54,
                    StandartIcerikTipiID = 161,
                    SiraNo = 57,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 58,
                    StandartID = 1,
                    BaslikNo = "10.4",
                    Baslik = "Verilerin Depolanması",
                    Detay = null,
                    UstIcerikID = 54,
                    StandartIcerikTipiID = 161,
                    SiraNo = 58,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 59,
                    StandartID = 1,
                    BaslikNo = "Bölüm II:",
                    Baslik = "Belge Kriterleri",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 162,
                    SiraNo = 59,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 60,
                    StandartID = 1,
                    BaslikNo = "11",
                    Baslik = "Belge Özellikleri",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 162,
                    SiraNo = 60,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 61,
                    StandartID = 1,
                    BaslikNo = "11.1",
                    Baslik = "Tanımlanabilirlik",
                    Detay = null,
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 161,
                    SiraNo = 61,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 62,
                    StandartID = 1,
                    BaslikNo = "11.2",
                    Baslik = "Bütünlük",
                    Detay = null,
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 161,
                    SiraNo = 62,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 63,
                    StandartID = 1,
                    BaslikNo = "11.3",
                    Baslik = "Onay ve Kayıt Bilgisi",
                    Detay = null,
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 161,
                    SiraNo = 63,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 64,
                    StandartID = 1,
                    BaslikNo = "11.4",
                    Baslik = "Yapısal özellikler",
                    Detay = null,
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 161,
                    SiraNo = 64,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 65,
                    StandartID = 1,
                    BaslikNo = "11.5",
                    Baslik = "Üretim sorumluluğu ve mülkiyet hakları",
                    Detay = null,
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 161,
                    SiraNo = 65,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 66,
                    StandartID = 1,
                    BaslikNo = "11.6",
                    Baslik = "Teknolojik özellikler",
                    Detay = null,
                    UstIcerikID = 60,
                    StandartIcerikTipiID = 161,
                    SiraNo = 66,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 67,
                    StandartID = 1,
                    BaslikNo = "12",
                    Baslik = "Doküman yönetimi",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 162,
                    SiraNo = 67,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 68,
                    StandartID = 1,
                    BaslikNo = "12.1",
                    Baslik = "Giriş",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 68,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 69,
                    StandartID = 1,
                    BaslikNo = "12.2",
                    Baslik = "Girdi Yönetimi",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 69,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 70,
                    StandartID = 1,
                    BaslikNo = "12.3",
                    Baslik = "Tanımlama ve indeksleme",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 70,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 71,
                    StandartID = 1,
                    BaslikNo = "12.4",
                    Baslik = "Dosyalama, düzenleme ve tasnif",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 71,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 72,
                    StandartID = 1,
                    BaslikNo = "12.5",
                    Baslik = "Depolama / Yedekleme",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 72,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 73,
                    StandartID = 1,
                    BaslikNo = "12.6",
                    Baslik = "Erişim",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 73,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 74,
                    StandartID = 1,
                    BaslikNo = "12.7",
                    Baslik = "Çıktı yönetimi",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 74,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 75,
                    StandartID = 1,
                    BaslikNo = "12.8",
                    Baslik = "Versiyon kontrolü",
                    Detay = null,
                    UstIcerikID = 67,
                    StandartIcerikTipiID = 161,
                    SiraNo = 75,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 76,
                    StandartID = 1,
                    BaslikNo = "13",
                    Baslik = "Elektronik olmayan sistemlerle uyumluluk",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 162,
                    SiraNo = 76,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 77,
                    StandartID = 1,
                    BaslikNo = "13.1",
                    Baslik = "Fiziksel dosya ve belgelerin sisteme dahil edilmesi",
                    Detay = null,
                    UstIcerikID = 76,
                    StandartIcerikTipiID = 161,
                    SiraNo = 77,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 78,
                    StandartID = 1,
                    BaslikNo = "13.2",
                    Baslik = "Tanımlama",
                    Detay = null,
                    UstIcerikID = 76,
                    StandartIcerikTipiID = 161,
                    SiraNo = 78,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 79,
                    StandartID = 1,
                    BaslikNo = "13.3",
                    Baslik = "Erişim kontrolü ve kullanım",
                    Detay = null,
                    UstIcerikID = 76,
                    StandartIcerikTipiID = 161,
                    SiraNo = 79,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 80,
                    StandartID = 1,
                    BaslikNo = "13.4",
                    Baslik = "Tasfiye",
                    Detay = null,
                    UstIcerikID = 76,
                    StandartIcerikTipiID = 161,
                    SiraNo = 80,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 81,
                    StandartID = 1,
                    BaslikNo = "14",
                    Baslik = "Dijital görüntüleme sistemleri",
                    Detay = null,
                    UstIcerikID = 59,
                    StandartIcerikTipiID = 162,
                    SiraNo = 81,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 82,
                    StandartID = 1,
                    BaslikNo = "14.1",
                    Baslik = "Genel rensipler",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 82,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 83,
                    StandartID = 1,
                    BaslikNo = "14.2",
                    Baslik = "Görüntülenecek malzeme",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 83,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 84,
                    StandartID = 1,
                    BaslikNo = "14.3",
                    Baslik = "Görüntüleme Tekniği",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 84,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 85,
                    StandartID = 1,
                    BaslikNo = "14.4",
                    Baslik = "Çözünürlük",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 85,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 86,
                    StandartID = 1,
                    BaslikNo = "14.5",
                    Baslik = "Tonlama / Bit derinliği / Tarama modu",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 86,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 87,
                    StandartID = 1,
                    BaslikNo = "14.6",
                    Baslik = "Sıkıştırma",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 87,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 88,
                    StandartID = 1,
                    BaslikNo = "14.7",
                    Baslik = "Zenginleştirme",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 88,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 89,
                    StandartID = 1,
                    BaslikNo = "14.8",
                    Baslik = "Renk yönetimi",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 89,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 90,
                    StandartID = 1,
                    BaslikNo = "14.9",
                    Baslik = "Dosya Formatları",
                    Detay = null,
                    UstIcerikID = 81,
                    StandartIcerikTipiID = 161,
                    SiraNo = 90,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 91,
                    StandartID = 1,
                    BaslikNo = "Bölüm III:",
                    Baslik = "Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM)",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 162,
                    SiraNo = 91,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 92,
                    StandartID = 1,
                    BaslikNo = "15",
                    Baslik = "Elektronik Arşivleme Sistemi Referans Modeli (ELAS/RM)",
                    Detay = null,
                    UstIcerikID = 91,
                    StandartIcerikTipiID = 162,
                    SiraNo = 92,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 93,
                    StandartID = 1,
                    BaslikNo = "15.1",
                    Baslik = "Arşiv Malzemesinin tanımı ve özellikleri",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 93,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 94,
                    StandartID = 1,
                    BaslikNo = "15.2",
                    Baslik = "Arşiv politikasını belirlenmesi",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 94,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 95,
                    StandartID = 1,
                    BaslikNo = "15.3",
                    Baslik = "Arşiv malzemesinin transfer işlemleri",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 95,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 96,
                    StandartID = 1,
                    BaslikNo = "15.4",
                    Baslik = "Tarih ve zaman damgası",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 96,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 97,
                    StandartID = 1,
                    BaslikNo = "15.5",
                    Baslik = "Dosya formatları",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 97,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 98,
                    StandartID = 1,
                    BaslikNo = "15.6",
                    Baslik = "Depolama Üniteleri",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 98,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 99,
                    StandartID = 1,
                    BaslikNo = "15.7",
                    Baslik = "Veri merkezi özellikleri",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 99,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 100,
                    StandartID = 1,
                    BaslikNo = "15.8",
                    Baslik = "Erişimin sürekliliği",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 100,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 101,
                    StandartID = 1,
                    BaslikNo = "15.9",
                    Baslik = "Teknolojik eskimeye karşı alınacak önlemler",
                    Detay = null,
                    UstIcerikID = 92,
                    StandartIcerikTipiID = 161,
                    SiraNo = 101,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 102,
                    StandartID = 1,
                    BaslikNo = "16",
                    Baslik = "Arşiv sisteminin Güvenliği",
                    Detay = null,
                    UstIcerikID = 91,
                    StandartIcerikTipiID = 162,
                    SiraNo = 102,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 103,
                    StandartID = 1,
                    BaslikNo = "16.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikID = 102,
                    StandartIcerikTipiID = 161,
                    SiraNo = 103,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 104,
                    StandartID = 1,
                    BaslikNo = "16.2",
                    Baslik = "Sistem Güvenliği",
                    Detay = null,
                    UstIcerikID = 102,
                    StandartIcerikTipiID = 161,
                    SiraNo = 104,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 105,
                    StandartID = 1,
                    BaslikNo = "16.3",
                    Baslik = "Bilgi Güvenliği",
                    Detay = null,
                    UstIcerikID = 102,
                    StandartIcerikTipiID = 161,
                    SiraNo = 105,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 106,
                    StandartID = 1,
                    BaslikNo = "16.4",
                    Baslik = "Sistem Denetimi",
                    Detay = null,
                    UstIcerikID = 102,
                    StandartIcerikTipiID = 161,
                    SiraNo = 106,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 107,
                    StandartID = 1,
                    BaslikNo = "17",
                    Baslik = "ELAS/RM Uygulama Kılavuzu",
                    Detay = null,
                    UstIcerikID = 91,
                    StandartIcerikTipiID = 162,
                    SiraNo = 107,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 108,
                    StandartID = 1,
                    BaslikNo = "17.1",
                    Baslik = "Genel",
                    Detay = null,
                    UstIcerikID = 107,
                    StandartIcerikTipiID = 161,
                    SiraNo = 108,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 109,
                    StandartID = 1,
                    BaslikNo = "17.2",
                    Baslik = "Arşiv Malzemesinin Transfer İşlemleri",
                    Detay = null,
                    UstIcerikID = 107,
                    StandartIcerikTipiID = 161,
                    SiraNo = 109,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 110,
                    StandartID = 1,
                    BaslikNo = "17.3",
                    Baslik = "Düzenleme",
                    Detay = null,
                    UstIcerikID = 107,
                    StandartIcerikTipiID = 161,
                    SiraNo = 110,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 111,
                    StandartID = 1,
                    BaslikNo = "18",
                    Baslik = "Arşiv Malzemesinin Tanımlanması",
                    Detay = null,
                    UstIcerikID = 91,
                    StandartIcerikTipiID = 162,
                    SiraNo = 111,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 112,
                    StandartID = 1,
                    BaslikNo = "18.1",
                    Baslik = "Tanımlama seviyeleri",
                    Detay = null,
                    UstIcerikID = 111,
                    StandartIcerikTipiID = 161,
                    SiraNo = 112,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 113,
                    StandartID = 1,
                    BaslikNo = "18.2",
                    Baslik = "Tanımlama Alanları",
                    Detay = null,
                    UstIcerikID = 111,
                    StandartIcerikTipiID = 161,
                    SiraNo = 113,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 114,
                    StandartID = 1,
                    BaslikNo = "Bölüm:IV",
                    Baslik = "Üstveri Yönetimi",
                    Detay = null,
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 162,
                    SiraNo = 114,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 115,
                    StandartID = 1,
                    BaslikNo = "19",
                    Baslik = "Üstveri Elemanları",
                    Detay = null,
                    UstIcerikID = 114,
                    StandartIcerikTipiID = 162,
                    SiraNo = 115,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 116,
                    StandartID = 1,
                    BaslikNo = "19.1",
                    Baslik = "Genel Özellikler",
                    Detay = null,
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 161,
                    SiraNo = 116,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 117,
                    StandartID = 1,
                    BaslikNo = "19.2",
                    Baslik = "Dosya Tasnif Planı Üstveri Elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>DTP Eleman Referans Numarası</td></tr><tr><td>Referans Numarası</td><td>DT001</td></tr><tr><td>Tanım</td><td>Dosya tasnif planında yer alacak her bir eleman için verilecek olan referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Dosya tasnif planındaki seri ve alt seri kodları gibi.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>DTP Eleman adı</td></tr><tr><td>Referans Numarası</td><td>DT010</td></tr><tr><td>Tanım</td><td>Dosya tasnif planında yer alan elemanların adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Dosya tasnif planındaki seri ve alt serilerin adıdır. Farklı birimlerde aynı ad ile seriler oluşabilir. Ancak bu serilere ait referans numaraları farklı olmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Tanım</td></tr><tr><td>Referans Numarası</td><td>DT050</td></tr><tr><td>Tanım</td><td>Dosya tasnif planı elemanına ait tanımlamalara ve açıklamalara ait bilgidir. Kullanımı zorunlu değildir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td>Kullanıcıların yönlendirilmesi ve EBYS içerisine dahil edilecek belgelerin hangi elemanlar altında tasnif edilmesi gerektiğini göstermek amacıyla kullanılabilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seviye numarası</td></tr><tr><td>Referans Numarası</td><td>DT070</td></tr><tr><td>Tanım</td><td>Dosya tasnif planı elemanına ait hiyerarşik seviyeyi gösteren numaradır.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 117,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 118,
                    StandartID = 1,
                    BaslikNo = "19.3",
                    Baslik = "Saklama Planı Üstveri Elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>SP Eleman referans numarası</td></tr><tr><td>Referans Numarası</td><td>SP001</td></tr><tr><td>Tanım</td><td>Saklama planında yer alacak her bir eleman için verilecek olan referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama planındaki seri ve alt seri kodları gibi.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>SP Eleman adı</td></tr><tr><td>Referans Numarası</td><td>SP010</td></tr><tr><td>Tanım</td><td>Saklama planında yer alan elemanların adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama planındaki seri ve alt serilerin adıdır. Farklı birimlerde aynı ad ile seriler oluşabilir. Ancak bu serilere ait referans numaraları farklı olmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama süresi</td></tr><tr><td>Referans Numarası</td><td>SP040</td></tr><tr><td>Tanım</td><td>Saklama planında yer alan elemanların kurumda ne kadar süre ile saklanacağı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Genelde yıl olarak ifade edilir. Sistemdeki belgelerin idari kullanımının tamamlandıktan sonra kaç yıl süre ile saklanacağını gösterir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Tasfiye işlem kodu</td></tr><tr><td>Referans Numarası</td><td>TS001</td></tr><tr><td>Tanım</td><td>Saklama süresi dolan klasör/dosya ve belgelerin ne tür işleme tabi tutulacağı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tasfiye işlem kodlarının tanımları için Madde 5.5’e bakılmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Yasal kaynak</td></tr><tr><td>Referans Numarası</td><td>SP110</td></tr><tr><td>Tanım</td><td>Saklama sürelerinin hangi yasal düzenlemeye göre atandığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td></td></tr><tr><td>Notlar</td><td>Kanun ve yönetmelik gibi yasal düzenlemelere ait referansları içerir.</td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 118,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 119,
                    StandartID = 1,
                    BaslikNo = "19.4",
                    Baslik = "Birim/Alt Birim tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR001</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı kurumdaki birimlere verilmiş olan kodnumarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim adı</td></tr><tr><td>Referans Numarası</td><td>BR010</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı kurumdaki birimlerin adlarıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim Seviye numarası</td></tr><tr><td>Referans Numarası</td><td>BR120</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği kurumdaki birimlere ait hiyerarşik seviyeyi gösteren numaradır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR101</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı, kurumlara bağlı birimlerin, alt birimleri için verilmiş kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td></td></tr><tr><td>Notlar</td><td>Bazı durumlarda kullanılır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Birim Adı</td></tr><tr><td>Referans Numarası</td><td>BR110</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği ya da alındığı kurumlara bağlı birimlerin, alt birimlerinin adlarıdır.</td></tr><tr><td>Zorunluluk</td><td></td></tr><tr><td>Notlar</td><td>Bazı durumlarda kullanılır.</td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 119,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 120,
                    StandartID = 1,
                    BaslikNo = "19.5",
                    Baslik = "Seri tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri kodu:</td></tr><tr><td>Referans Numarası</td><td>SE001</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge serisine ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri adı</td></tr><tr><td>Referans Numarası</td><td>SE010</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge serisinin adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Belge serileri aynı zamanda kurumsal fonksiyonları ifade eder. Farklı birimlerde aynı ad altında belge serileri olabilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri tanımı</td></tr><tr><td>Referans Numarası</td><td>SE050</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge serisine ait açıklayıcı bilgilerin yer aldığı alandır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Birim/Alt Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR001/BR101</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisinin ait olduğu birime/alt birime ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Birim kodu tanımlamaları için Madde 11.5’e bakılmalıdır. Belge serisinin ya da kurumsal fonksiyonun hangi birime ait olduğunun kayıt altına alınması belge provenansının tespiti açısından son derece önemlidir. Birim kodu uygulama programı tarafından kullanıcı sistem giriş bilgileri kullanılarak otomatik olarak atanabilir ya da Bilgi ve Belge Yöneticisi veya kullanıcı tarafından girilebilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Açılış tarihi/Başlangıç Tarihi</td></tr><tr><td>Referans Numarası</td><td>SE210</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisinin hangi tarihte açıldığını gösteren bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kapanış tarihi/Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>SE290</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisinin hangi tarihte kapatıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Erişim hakları</td></tr><tr><td>Referans Numarası</td><td>SE300</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisine erişim hakkı bulunan kullanıcılar ve/veya kullanıcı gruplarının kimler olduğuna ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Erişim hakları tanımlamaları için Madde 9.2’ye bakılmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Güvenlik kodu</td></tr><tr><td>Referans Numarası</td><td>SE500</td></tr><tr><td>Tanım</td><td>Elektronik belge serisinin gizlilik derecesini ya da kullanım kısıtlamalarını gösteren kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Güvenlik kod tanımları için Madde 9.2’ye bakılmalıdır. Güvenlik kodları, erişim hakları tanımları ile entegre çalışmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama plan kodu</td></tr><tr><td>Referans Numarası</td><td>SE770</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisi içinde yer alan belgelerin ne kadar sürelerle saklanacağını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama Plan kodu tanımları için Madde 5’e bakılmalıdır</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Anahtar kelimeler</td></tr><tr><td>Referans Numarası</td><td>SE610</td></tr><tr><td>Tanım</td><td>Elektronik belgenin serisini tanımlayıcı anahtar kelimelerin verildiği alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Miktar</td></tr><tr><td>Referans Numarası</td><td>SE550</td></tr><tr><td>Tanım</td><td>Serinin fiziksel boyutları ile seriye ait dosya sayısının nicelik olarak tanımlandığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Devamı olduğu seri</td></tr><tr><td>Referans Numarası</td><td>SE910</td></tr><tr><td>Tanım</td><td>Mevcut serinin herhangi bir serinin devamı olup olmadığı bu üstveri alanında tanımlanır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 120,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 121,
                    StandartID = 1,
                    BaslikNo = "19.6",
                    Baslik = "Alt Seri tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Seri Kodu</td></tr><tr><td>Referans Numarası</td><td>AS101</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge alt serisine ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Seri adı</td></tr><tr><td>Referans Numarası</td><td>AS110</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge alt serisinin adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alt Seri Tanımı</td></tr><tr><td>Referans Numarası</td><td>AS050</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bağlı bulunduğu belge alt serisine ait açıklayıcı bilgilerin yer aldığı alandır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Açılış tarihi/Başlangıç Tarihi</td></tr><tr><td>Referans Numarası</td><td>AS210</td></tr><tr><td>Tanım</td><td>Elektronik belgenin alt serisinin hangi tarihte açıldığını gösteren bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kapanış tarihi/Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>AS290</td></tr><tr><td>Tanım</td><td>Elektronik belgenin alt serisinin hangi tarihte kapatıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Miktar</td></tr><tr><td>Referans Numarası</td><td>AS550</td></tr><tr><td>Tanım</td><td>Alt serinin fiziksel boyutları ile seriye ait dosya sayısının nicelik olarak tanımlandığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Devamı olduğu alt seri (varsa)</td></tr><tr><td>Referans Numarası</td><td>AS910</td></tr><tr><td>Tanım</td><td>Mevcut serinin herhangi bir serinin devamı olup olmadığı bu üstveri alanında tanımlanır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 121,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 122,
                    StandartID = 1,
                    BaslikNo = "19.7",
                    Baslik = "Klasör/Dosya tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Klasör/dosya numarası</td></tr><tr><td>Referans Numarası</td><td>KD001</td></tr><tr><td>Tanım</td><td>Belgelerin ait olduğu klasör veya dosyalara ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Klasör/dosya adı</td></tr><tr><td>Referans Numarası</td><td>KD010</td></tr><tr><td>Tanım</td><td>Belgelerin ait olduğu klasör veya dosyaların adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Açılış tarihi/Başlangıç Tarihi</td></tr><tr><td>Referans Numarası</td><td>KD210</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi tarihte açıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kapanış tarihi/Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>KD290</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi tarihte kapatıldığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Seri numarası</td></tr><tr><td>Referans Numarası</td><td>SE001</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi seriye ait olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama ortamı</td></tr><tr><td>Referans Numarası</td><td>KD180</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi ortamda saklandığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Saklama ortamı fiziki, elektronik ya da karma olabilir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Saklama yeri referans numarası</td></tr><tr><td>Referans Numarası</td><td>KD181</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın nerede depolandığını gösteren yer numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Bu alan yalnızca fiziki klasör ve dosyalar içindir.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Bölüm numarası</td></tr><tr><td>Referans Numarası</td><td>KD400</td></tr><tr><td>Tanım</td><td>Birden fazla bölümden oluşan klasör veya dosyalara ait bölüm numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Tasfiye tarihi</td></tr><tr><td>Referans Numarası</td><td>KD041</td></tr><tr><td>Tanım</td><td>Klasör veya dosyanın hangi tarihte tasfiye edileceğini gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tasfiye işlem tanımlamaları Madde 5.5’e bakılmalıdır.</td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 122,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 123,
                    StandartID = 1,
                    BaslikNo = "19.8",
                    Baslik = "Belge tanımları üstveri elemanları",
                    Detay = "<table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge referans numarası</td></tr><tr><td>Referans Numarası</td><td>BE001</td></tr><tr><td>Tanım</td><td>Belgeye ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge adı</td></tr><tr><td>Referans Numarası</td><td>BE010</td></tr><tr><td>Tanım</td><td>Belgeye ait ad ve/veya tür bilgisidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Elektronik dosya adı</td></tr><tr><td>Referans Numarası</td><td>BE019</td></tr><tr><td>Tanım</td><td>Elektronik belgenin bilgisayar sisteminde hangi ad ile tutulduğu bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Klasör/dosya numarası.</td></tr><tr><td>Referans Numarası</td><td>KD001</td></tr><tr><td>Tanım</td><td>Belgenin bağlı bulunduğu klasör veya dosyaya ait referans numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Konu</td></tr><tr><td>Referans Numarası</td><td>BE055</td></tr><tr><td>Tanım</td><td>Belge içeriğini açıklayıcı bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Üretici</td></tr><tr><td>Referans Numarası</td><td>BE100</td></tr><tr><td>Tanım</td><td>Belge üreticisini gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Üretim tarihi</td></tr><tr><td>Referans Numarası</td><td>BE210</td></tr><tr><td>Tanım</td><td>Belgenin üretildiği tarihtir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Gönderme / alma tarihi</td></tr><tr><td>Referans Numarası</td><td>BE240</td></tr><tr><td>Tanım</td><td>Belgenin gönderildiği ya da alındığı tarihtir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Alıcı/Muhatap</td></tr><tr><td>Referans Numarası</td><td>BE200</td></tr><tr><td>Tanım</td><td>Belgenin kime gönderildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Dil</td></tr><tr><td>Referans Numarası</td><td>BE350</td></tr><tr><td>Tanım</td><td>Belgenin hangi dilde üretildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge türü</td></tr><tr><td>Referans Numarası</td><td>BE420</td></tr><tr><td>Tanım</td><td>Belgeye ait tür tanımlamasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Kurumdaki belge türleri (yazışma, rapor, vs.) kullanıcıya liste halinde sunularak çoktan seçmeli bilgi girişi sağlanmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Sisteme giriş tarihi</td></tr><tr><td>Referans Numarası</td><td>BE260</td></tr><tr><td>Tanım</td><td>Belgenin EBYS içerisine kayıt edildiği tarihtir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Erişim hakları</td></tr><tr><td>Referans Numarası</td><td>BE300</td></tr><tr><td>Tanım</td><td>Elektronik belgeye erişim hakkı bulunan kullanıcılar ve/veya kullanıcı gruplarının kimler olduğuna ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Erişim hakları tanımlamaları için Madde 9.2’ye bakılmalıdır.</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Güvenlik kodu</td></tr><tr><td>Referans Numarası</td><td>GS001</td></tr><tr><td>Tanım</td><td>Elektronik belgenin gizlilik derecesini yada kullanım kısıtlamalarını gösteren kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Güvenlik kod tanımları için Madde 9.2’ye bakılmalıdır. Güvenlik kodları, erişim hakları tanımları ile entegre çalışmalıdır</td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Dosya formatı</td></tr><tr><td>Referans Numarası</td><td>BE830</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği yazılımın belgeye kazandırmış olduğu orijinal dosya formatının adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Arşiv formatı</td></tr><tr><td>Referans Numarası</td><td>BE880</td></tr><tr><td>Tanım</td><td>Elektronik belgenin uzun dönem saklama ve kullanımı için dönüştürüldüğü arşiv dosya formatıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Donanım</td></tr><tr><td>Referans Numarası</td><td>BE420</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği bilgisayar sisteminin donanım özelliklerine ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>İşletim Sistemi</td></tr><tr><td>Referans Numarası</td><td>BE430</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği bilgisayar sisteminin kullandığı işletim sistemine ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Uygulama Programı</td></tr><tr><td>Referans Numarası</td><td>BE440</td></tr><tr><td>Tanım</td><td>Elektronik belgenin üretildiği uygulama yazılımına ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kodlama Şeması</td></tr><tr><td>Referans Numarası</td><td>BE570</td></tr><tr><td>Tanım</td><td>Elektronik belgenin hangi kodlama şemasına göre üretildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Öncelik derecesi</td></tr><tr><td>Referans Numarası</td><td>BE620</td></tr><tr><td>Tanım</td><td>Elektronik belgenin kurumsal faaliyetlerin devamı açısından taşıdığı önemi gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Bilgi edinme kanunu kapsamı</td></tr><tr><td>Referans Numarası</td><td>BE460</td></tr><tr><td>Tanım</td><td>Elektronik belgenin Bilgi Edinme Kanunu kapsamında olup olmadığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Telif hakları kanunu kapsamı</td></tr><tr><td>Referans Numarası</td><td>BE470</td></tr><tr><td>Tanım</td><td>Elektronik belgenin Telif Hakları Kanunu kapsamında olup olmadığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Elektronik imza</td></tr><tr><td>Referans Numarası</td><td>BE500</td></tr><tr><td>Tanım</td><td>Belge üzerinde elektronik imzanın varlığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Elektronik imza sertifika kurumu</td></tr><tr><td>Referans Numarası</td><td>BE510</td></tr><tr><td>Tanım</td><td>Belge üzerinde elektronik imzanın hangi kurum tarafından onaylandığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Zaman damgası</td></tr><tr><td>Referans Numarası</td><td>BE520</td></tr><tr><td>Tanım</td><td>Elektronik belgenin hangi tarih ve saatte imzalandığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Şifreleme algoritması</td></tr><tr><td>Referans Numarası</td><td>BE580</td></tr><tr><td>Tanım</td><td>Şifrelenmiş elektronik belgelerin kullanımına imkan verecek algoritmadır.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Diğer dijital işaretler</td></tr><tr><td>Referans Numarası</td><td>BE590</td></tr><tr><td>Tanım</td><td>Elektronik belge üzerindeki dijital antet, filigran gibi işaretler varlığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 123,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 124,
                    StandartID = 1,
                    BaslikNo = "19.9",
                    Baslik = "Belge bileşeni tanımları üstveri elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Belge bileşeni referans numarası</td></tr><tr><td>Referans Numarası</td><td>BB001</td></tr><tr><td>Tanım</td><td>Belge bileşenine ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge Bileşeni Elektronik dosya adı</td></tr><tr><td>Referans Numarası</td><td>BB010</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin bilgisayar sisteminde hangi ad ile tutulduğu bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge numarası</td></tr><tr><td>Referans Numarası</td><td>BE001</td></tr><tr><td>Tanım</td><td>Belge bileşeninin bağlı bulunduğu belgeye ait referans numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Belge Bileşini Dosya formatı</td></tr><tr><td>Referans Numarası</td><td>BB830</td>/tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin üretildiği yazılımın belgeye kazandırmış olduğu orijinal dosya formatının adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Çözünürlük</td></tr><tr><td>Referans Numarası</td><td>DG160</td></tr><tr><td>Tanım</td><td>Görüntü olarak üretilmiş olan elektronik belge bileşenlerinin çözünürlük bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Sıkıştırma parametreleri</td></tr><tr><td>Referans Numarası</td><td>BB650</td></tr><tr><td>Tanım</td><td>Görüntü olarak üretilmiş olan elektronik belge bileşenlerinin sıkıştırma parametrelerine ait bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Donanım</td></tr><tr><td>Referans Numarası</td><td>BB420</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşenin üretildiği bilgisayar sisteminin donanım özelliklerine ait bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>İşletim Sistemi</td></tr><tr><td>Referans Numarası</td><td>BB430</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşenin üretildiği bilgisayar sisteminin kullandığı işletim sistemine ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Uygulama Programı</td></tr><tr><td>Referans Numarası</td><td>BB440</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşenin üretildiği uygulama yazılımına ait ad ve versiyon bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Kodlama şeması</td></tr><tr><td>Referans Numarası</td><td>BB670</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin hangi kodlama şemasına göre üretildiği bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td>Eleman Adı</td><td>Arşiv formatı</td></tr><tr><td>Referans Numarası</td><td>BB880</td></tr><tr><td>Tanım</td><td>Elektronik belge bileşeninin uzun dönem saklama ve kullanımı için dönüştürüldüğü arşiv dosya formatıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 124,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 125,
                    StandartID = 1,
                    BaslikNo = "19.10",
                    Baslik = "Kullanıcı profil tanımları üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı kodu</td></tr><tr><td>Referans Numarası</td><td>KP001</td></tr><tr><td>Tanım</td><td>Kullanıcıyı sistem içerisinde tanımlayan referans kodudur</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı adı soyadı</td></tr><tr><td>Referans Numarası</td><td>KP010</td></tr><tr><td>Tanım</td><td>Kullanıcının ad ve soyadı bilgileridir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Birim kodu</td></tr><tr><td>Referans Numarası</td><td>BR001/BR101</td></tr><tr><td>Tanım</td><td>Kullanıcının mensubu bulunduğu birime ait kod numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı rol tanım kodu</td></tr><tr><td>Referans Numarası</td><td>KP910</td></tr><tr><td>Tanım</td><td>Kullanıcının sistem içerisindeki rolünü tanımlayan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı grup tanım kodu</td></tr><tr><td>Referans Numarası</td><td>KP950</td></tr><tr><td>Tanım</td><td>Kullanıcı grubuna ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 125,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 126,
                    StandartID = 1,
                    BaslikNo = "19.11",
                    Baslik = "Kullanıcı rol tanımları üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı rol kodu</td></tr><tr><td>Referans Numarası</td><td>KR001</td></tr><tr><td>Tanım</td><td>Kullanıcı rolüne ait kod numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı rol adı</td></tr><tr><td>Referans Numarası</td><td>KR010</td></tr><tr><td>Tanım</td><td>Kullanıcı rolünün adıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Geçerlilik tarihi</td></tr><tr><td>Referans Numarası</td><td>KR390</td></tr><tr><td>Tanım</td><td>Kullanıcı rolünün ne kadar süre ile geçerli olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 126,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 127,
                    StandartID = 1,
                    BaslikNo = "19.12",
                    Baslik = "Kullanıcı grup tanımları üstveri elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı grup kodu</td></tr><tr><td>Referans Numarası</td><td>KG001</td></tr><tr><td>Tanım</td><td>Kullanıcı grupları için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı grup adı</td></tr><tr><td>Referans Numarası</td><td>KG010</td></tr><tr><td>Tanım</td><td>Kullanıcı grubunun adıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Geçerlilik tarihi</td></tr><tr><td>Referans Numarası</td><td>KG390</td></tr><tr><td>Tanım</td><td>Kullanıcı grubunun ne kadar süre ile geçerli olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 127,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 128,
                    StandartID = 1,
                    BaslikNo = "19.13",
                    Baslik = "Güvenlik seviye tanımları üstveri elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Güvenlik kodu</td></tr><tr><td>Referans Numarası</td><td>GS001</td></tr><tr><td>Tanım</td><td>Güvenlik seviyesi için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tanım</td></tr><tr><td>Referans Numarası</td><td>GS050</td></tr><tr><td>Tanım</td><td>Güvenlik seviyesinin ne olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yasal dayanak</td></tr><tr><td>Referans Numarası</td><td>GS110</td></tr><tr><td>Tanım</td><td>Güvenlik kısıtlamasının yasal dayanağının ne olduğu bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Kanunlar, yönetmelikler v.s</td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 128,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 129,
                    StandartID = 1,
                    BaslikNo = "19.14",
                    Baslik = "Tasfiye işlem tanımları üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tasfiye işlem kodu</td></tr><tr><td>Referans Numarası</td><td>TS001</td></tr><tr><td>Tanım</td><td>Tasfiye işlemi için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tanım</td></tr><tr><td>Referans Numarası</td><td>TS050</td></tr><tr><td>Tanım</td><td>Tasfiye işleminin ne olduğunu gösteren bilgidir</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 129,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 130,
                    StandartID = 1,
                    BaslikNo = "19.15",
                    Baslik = "Sistem kullanımı üstveri elemanları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Sistem Kullanım Referans numarası</td></tr><tr><td>Referans Numarası</td><td>SK001</td></tr><tr><td>Tanım</td><td>Sistemde gerçekleştirilen her bir işlem için verilmiş olan kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı kodu</td></tr><tr><td>Referans Numarası</td><td>KP001</td></tr><tr><td>Tanım</td><td>İşlemi gerçekleştiren kullanıcıyı tanımlamak için verilmiş olan kod numarasıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Fonksiyon kodu</td></tr><tr><td>Referans Numarası</td><td>SK101</td></tr><tr><td>Tanım</td><td>Kullanıcının sistemde gerçekleştirmiş olduğu fonksiyona ait kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İşlem kodu</td></tr><tr><td>Referans Numarası</td><td>IT001</td></tr><tr><td>Tanım</td><td>Kullanıcının fonksiyon üzerinde ne tür bir işlem gerçekleştirmiş olduğunu gösteren kod numarasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarih ve saat</td></tr><tr><td>Referans Numarası</td><td>SK255</td></tr><tr><td>Tanım</td><td>İşlemin ne zaman gerçekleştirilmiş olduğunu gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 130,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 131,
                    StandartID = 1,
                    BaslikNo = "19.16",
                    Baslik = "Dijital Görüntüleme ile Sisteme alınanlara ait üstveri tanımları",
                    Detay = "<table table border='1' cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Referans Kodu</td></tr><tr><td>Referans Numarası</td><td>DG001</td></tr><tr><td>Tanım</td><td>Dosyanın sistemdeki türeme kodudur. Sistem tarafından dijital görüntüye verilen değişmez numarası</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Adı</td></tr><tr><td>Referans Numarası</td><td>DG010</td></tr><tr><td>Tanım</td><td>Dijital ortama aktarılan materyalin dijital ortamda aldığı addır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Türü</td></tr><tr><td>Referans Numarası</td><td>DG070</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin türünü ifade eden üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Kopya Türü</td></tr><tr><td>Referans Numarası</td><td>DG140</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin hangi kopya türü ile elektronik ortamda aktarılacağını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Çözünürlük</td></tr><tr><td>Referans Numarası</td><td>DG160</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin DPI veya PPI olarak ölçütlerinin belirlenmesidir. Görüntülenecek malzemenin elektronik ortamdaki kalitesini belirleyen en temel unsurdur.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tonlama/Bit Derinliği</td></tr><tr><td>Referans Numarası</td><td>DG170</td></tr><tr><td>Tanım</td><td>Görüntülenecek malzemenin renk ve bit derinliğinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Renk Yönetimi</td></tr><tr><td>Referans Numarası</td><td>DG190</td></tr><tr><td>Tanım</td><td>Kullanılan tarayıcının veya yazılım özelliğine bağlı olarak aktarılan materyallerin renk profilini ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Görüntü Dosya Formatı</td></tr><tr><td>Referans Numarası</td><td>DG830</td></tr><tr><td>Tanım</td><td>Dijitalleştirilen görüntünün hangi dosya formatı ile sisteme alındığının tanımlandığı alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Boyut</td></tr><tr><td>Referans Numarası</td><td>DG350</td></tr><tr><td>Tanım</td><td>Belgenin elektronik ortamda kapsadığı boyuttur. Dijitalleştirilen görüntünün sistemde ne kadar yer kapladığının bir göstergesidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Lokasyon</td></tr><tr><td>Referans Numarası</td><td>DG400</td></tr><tr><td>Tanım</td><td>Dijitalleştirilen görüntünün çevrim dışı olarak hangi lokasyonda tutulduğunu ifade etmek için kullanılan alandır. Dijitalleştirilmiş görüntünün fiziksel ortamdaki yerini ifade etmek için de kullanılır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Zaman damgası</td></tr><tr><td>Referans Numarası</td><td>DG520</td></tr><tr><td>Tanım</td><td>Elektronik görüntünün hangi tarih ve saatte imzalandığı bilgisidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>İmza görevi görmez. Sadece işlemin ne zaman yapıldığını ispatlamak için kullanılır.</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kurumsal İmza</td></tr><tr><td>Referans Numarası</td><td>DG540</td></tr><tr><td>Tanım</td><td>Dijitalleştirilen malzemenin görüntüsünün idare tarafından elektronik onay yoluyla kayıt altına alınmasıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Açıklama</td></tr><tr><td>Referans Numarası</td><td>DG600</td></tr><tr><td>Tanım</td><td>Dijitalleştirmenin amacının tanımlandığı veya görüntü ile ilgili herhangi bir notun eklenebilmesi için oluşturmuş üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 131,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 132,
                    StandartID = 1,
                    BaslikNo = "19.17",
                    Baslik = "Fon/Kurum Üstveri Elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>Fon/Kurum Kodu</td></tr><tr><td>Referans Numarası</td><td>FO001</td></tr><tr><td>Tanım</td><td>DETSİS’te tanımlı idari kimlik kodunu ifade eder. Tüzel bir kuruluş olması durumunda MERSİS ticari sicil numarası kullanılabilir. Bir şahıs olması durumunda ise Şahsa ait vatandaşlık numarasını ifade eder. Şahsa ait bir vatandaşlık numarası yoksa otorite dosyasından bir ID üretilerek şahısla eşleştirilir. Aynı şekilde bir kurum veya tüzel kuruluş için de ilgili veri tabanlarında kayıt bulunamazsa otorite dosyası üzerinden bir ID üretilerek işlem yapılabilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Fon /Kurum Adı (Kuruluş ve Şahıs)</td></tr><tr><td>Referans Numarası</td><td>FO010</td></tr><tr><td>Tanım</td><td>Kurumunun kanundaki tam adını veya Şahsın adını veya soyadını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yasal Dayanak</td></tr><tr><td>Referans Numarası</td><td>FO110</td></tr><tr><td>Tanım</td><td>Saklama sürelerinin hangi yasal düzenlemeye göre atandığını gösteren bilgidir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarihçe (İdari/Biyografik Tarih)</td></tr><tr><td>Referans Numarası</td><td>FO100</td></tr><tr><td>Tanım</td><td>Tanımlama biriminin şartları ve çevresi içinde bir yere oturtabilmek ve daha anlaşılabilir kılmak amacıyla üreticisi hakkında idari tarih ya da biyografik ayrıntılar sağlamak</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tanımlama biriminin oluşumundan sorumlu kurumun(ların) ortaya çıkış, ilerleme, gelişim ve işleyişi ya da şahsın(ların) yaşamı ve çalışmaları konusunda önemli bilgi özet olarak verilir. Eğer basılı kaynaklarda ek bilgi mevcutsa bu kaynaklar referans olarak gösterilir</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş/Doğum Tarihi</td></tr><tr><td>Referans Numarası</td><td>FO210</td></tr><tr><td>Tanım</td><td>Kurumun faaliyet gösterdiği ilk tarihi ifade eder. Şahıslar için doğum tarihi kabul edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kapanış/Ölüm Tarihi</td></tr><tr><td>Referans Numarası</td><td>FO290</td></tr><tr><td>Tanım</td><td>Kurumun faaliyetlerinin sona erdiği tarihi ya da sadece devrettiği o fon için devrettiği tarihi ifade eder. Şahıslar için ölüm tarihi kabul edilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yöneticiler</td></tr><tr><td>Referans Numarası</td><td>FO130</td></tr><tr><td>Tanım</td><td>Kurumda yöneticilik yapmış kişilerin tanımlandığı üstveri dizinidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş Yeri</td></tr><tr><td>Referans Numarası</td><td>FO150</td></tr><tr><td>Tanım</td><td>Kurumun faaliyet gösterdiği yeri ifade eder. Şahıslar için doğum yeri, yaşadığı yer gibi alanlar dâhil edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Devamı olduğu Kurumlar (Varsa)</td></tr><tr><td>Referans Numarası</td><td>FO090</td></tr><tr><td>Tanım</td><td>Daha evvel bir fonun devamı olup olmadığının ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Önemli Tarihler</td></tr><tr><td>Referans Numarası</td><td>FO250</td></tr><tr><td>Tanım</td><td>Fon içinde geçen önemli tarihlerin vurgulandığı tarihlerdir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Koleksiyon tanımı</td></tr><tr><td>Referans Numarası</td><td>FO320</td></tr><tr><td>Tanım</td><td>Devredilecek koleksiyonun tanımını içeren üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı hizmetleri</td></tr><tr><td>Referans Numarası</td><td>FO380</td></tr><tr><td>Tanım</td><td>Arşiv kullanıcılarını kayıt altına almaya yönelik bir sistemi bünyesinde barındırması ya da Kayıtlı kullanıcıların arşiv malzemesini nasıl kullandıklarının (görme, kopya üretme, referans verme) kayıt altına alınması ile ilgili bilgilerin yönetilmesine yönelik fonksiyonların izlendiği üstveri alanıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Adres</td></tr><tr><td>Referans Numarası</td><td>FO470</td></tr><tr><td>Tanım</td><td>İlgili Kurumun adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Telefon</td></tr><tr><td>Referans Numarası</td><td>FO480</td></tr><tr><td>Tanım</td><td>İlgili kurumun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İnternet Adresi</td></tr><tr><td>Referans Numarası</td><td>FO490</td></tr><tr><td>Tanım</td><td>İlgili kurumun internet adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Adresi</td></tr><tr><td>Referans Numarası</td><td>FO810</td></tr><tr><td>Tanım</td><td>İlgili kurumun e-posta adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP adresi</td></tr><tr><td>Referans Numarası</td><td>FO960</td></tr><tr><td>Tanım</td><td>İlgili kurumun kullandığı Kayıtlı Elektronik Posta adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 132,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 133,
                    StandartID = 1,
                    BaslikNo = "19.18",
                    Baslik = "Alt Fon/ Alt Kurum Üstveri Elemanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>Alt Fon/ Alt Kurum Üstveri Elemanları</td></tr><tr><td>Referans Numarası</td><td>AF001</td></tr><tr><td>Tanım</td><td>DETSİS’te tanımlı idari kimlik kodunu ifade eder. Tüzel bir kuruluş olması durumunda MERSİS ticari sicil numarası kullanılabilir. Bir şahıs olması durumunda ise Şahsa ait vatandaşlık numarasını ifade eder. Şahsa ait bir vatandaşlık numarası yoksa otorite dosyasından bir ID üretilerek şahısla eşleştirilir. Aynı şekilde bir kurum veya tüzel kuruluş için de ilgili veri tabanlarında kayıt bulunamazsa otorite dosyası üzerinden bir ID üretilerek işlem yapılabilir. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Kuruma bağlı bir birimi ifade etmek için de kullanılabilir.</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alt Fon /Alt Kurum Adı</td></tr><tr><td>Referans Numarası</td><td>AF010</td></tr><tr><td>Tanım</td><td>Alt kurumunun kanundaki tam adını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yasal Dayanak</td></tr><tr><td>Referans Numarası</td><td>AF110</td></tr><tr><td>Tanım</td><td>Saklama koşulunun hangi yasal düzenlemeye göre atandığını gösteren bilgidir. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarihçe (İdari/Biyografik Tarih)</td></tr><tr><td>Referans Numarası</td><td>AF100</td></tr><tr><td>Tanım</td><td>Tanımlama biriminin şartları ve çevresi içinde bir yere oturtabilmek ve daha anlaşılabilir kılmak amacıyla üreticisi hakkında idari tarih ya da biyografik ayrıntılar sağlamak amacıyla kullanılan üstveri</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Tanımlama biriminin oluşumundan sorumlu kurumun(ların) ortaya çıkış, ilerleme, gelişim ve işleyişi ya da şahsın(ların) yaşamı ve çalışmaları konusunda önemli bilgi özet olarak verilir. Eğer basılı kaynaklarda ek bilgi mevcutsa bu kaynaklar referans olarak gösterilir</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş/Doğum Tarihi</td></tr><tr><td>Referans Numarası</td><td>AF210</td></tr><tr><td>Tanım</td><td>Alt kurumun faaliyet gösterdiği ilk tarihi ifade eder. Şahıslar için doğum tarihi kabul edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kapanış/Ölüm Tarihi</td></tr><tr><td>Referans Numarası</td><td>AF290</td></tr><tr><td>Tanım</td><td>Alt kurumun faaliyetlerinin sona erdiği tarihi ya da sadece devrettiği o fon için devrettiği tarihi ifade eder. Şahıslar için ölüm tarihi kabul edilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yöneticiler</td></tr><tr><td>Referans Numarası</td><td>AF130</td></tr><tr><td>Tanım</td><td>Kurumda yöneticilik yapmış kişilerin tanımlandığı üstveri dizinidir.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş Yeri</td></tr><tr><td>Referans Numarası</td><td>AF150</td></tr><tr><td>Tanım</td><td>Kurumun faaliyet gösterdiği yeri ifade eder. Şahıslar için doğum yeri, yaşadığı yer gibi alanlar dâhil edilebilir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Devamı olduğu Kurumlar (Varsa)</td></tr><tr><td>Referans Numarası</td><td>AF090</td></tr><tr><td>Tanım</td><td>Daha evvel bir fonun devamı olup olmadığının ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Önemli Tarihler</td></tr><tr><td>Referans Numarası</td><td>AF250</td></tr><tr><td>Tanım</td><td>Fon içinde geçen önemli tarihlerin vurgulandığı tarihlerdir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Koleksiyon tanımı</td></tr><tr><td>Referans Numarası</td><td>AF320</td></tr><tr><td>Tanım</td><td>Devredilecek koleksiyonun tanımını içeren üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı hizmetleri</td></tr><tr><td>Referans Numarası</td><td>AF380</td></tr><tr><td>Tanım</td><td>Arşiv kullanıcılarını kayıt altına almaya yönelik bir sistemi bünyesinde barındırması ya da Kayıtlı kullanıcıların arşiv malzemesini nasıl kullandıklarının (görme, kopya üretme, referans verme) kayıt altına alınması ile ilgili bilgilerin yönetilmesine yönelik fonksiyonların izlendiği üstveri alanıdır</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Adres</td></tr><tr><td>Referans Numarası</td><td>AF470</td></tr><tr><td>Tanım</td><td>İlgili Kurumun adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Telefon</td></tr><tr><td>Referans Numarası</td><td>AF480</td></tr><tr><td>Tanım</td><td>İlgili kurumun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İnternet Adresi</td></tr><tr><td>Referans Numarası</td><td>AF490</td></tr><tr><td>Tanım</td><td>İlgili kurumun internet adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Adresi</td></tr><tr><td>Referans Numarası</td><td>AF810</td></tr><tr><td>Tanım</td><td>İlgili kurumun e-posta adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP adresi</td></tr><tr><td>Referans Numarası</td><td>AF960</td></tr><tr><td>Tanım</td><td>İlgili kurumun kullandığı Kayıtlı Elektronik Posta adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 133,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 134,
                    StandartID = 1,
                    BaslikNo = "19.19",
                    Baslik = "Fon Grubu Üstveri Tanımları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>Fon Grubu Üstveri Tanımları</td></tr><tr><td>Referans Numarası</td><td>FG001</td></tr><tr><td>Tanım</td><td>Fon grubu kodunun tanımlandığı üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Fon Grup Tanımı</td></tr><tr><td>Referans Numarası</td><td>FG010</td></tr><tr><td>Tanım</td><td>ir arşiv kurumu içerisindeki benzer fonksiyonlara sahip kurumlardan gelen arşiv malzemelerinin bütününün ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 134,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 135,
                    StandartID = 1,
                    BaslikNo = "19.20",
                    Baslik = "Arşiv Kurumları Üstverisi Tanımları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>rşiv Kurum Kodu</td></tr><tr><td>Referans Numarası</td><td>AK001</td></tr><tr><td>Tanım</td><td>rşiv kurumunun kodlandığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>rşiv Kurum Adı</td></tr><tr><td>Referans Numarası</td><td>AK010</td></tr><tr><td>Tanım</td><td>Belirli bir yasal çerçeve içerisinde faaliyet gösteren ve farklı kurumlar tarafından üretilmiş olan arşiv malzemesini ayıklama, düzenleme, tanımlama, hizmete sunma ve diğer yönetimsel fonksiyonları yerine getiren ulusal, bölgesel ya da özel amaçlı arşiv kurumlarını ifade eden üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kuruluş Tarihi</td></tr><tr><td>Referans Numarası</td><td>AK210</td></tr><tr><td>Tanım</td><td>Arşiv kurumun faaliyetlerine başladığı tarihi ifade eder </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarihçe (İdari/Biyografik Tarih)</td></tr><tr><td>Referans Numarası</td><td>AK100</td></tr><tr><td>Tanım</td><td>rşiv kurumunun yıllar içerisinde uğramış olduğu fonksiyon değişiklikleri önemli mevzuat gelişmeleri vb. gibi durumları ifade etmek için kullanılan üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Koleksiyon Tanımı</td></tr><tr><td>Referans Numarası</td><td>AK320</td></tr><tr><td>Tanım</td><td>Arşiv kurumuna devredilen koleksiyonun tanımlandığı üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Kullanıcı Hizmetleri</td></tr><tr><td>Referans Numarası</td><td>AK380</td></tr><tr><td>Tanım</td><td>Arşiv kullanıcılarını kayıt altına almaya yönelik bir sistemi bünyesinde barındırması ya da Kayıtlı kullanıcıların arşiv malzemesini nasıl kullandıklarının (görme, kopya üretme, referans verme) kayıt altına alınması ile ilgili bilgilerin yönetilmesine yönelik fonksiyonların izlendiği üstveri alanıdır..</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Adres</td></tr><tr><td>Referans Numarası</td><td>AK470</td></tr><tr><td>Tanım</td><td>Arşiv Kurumunun adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Telefon</td></tr><tr><td>Referans Numarası</td><td>AK480</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İnternet Adresi</td></tr><tr><td>Referans Numarası</td><td>AK490</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun internet adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Adresi</td></tr><tr><td>Referans Numarası</td><td>AK810</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun e-posta adresinin yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP adresi</td></tr><tr><td>Referans Numarası</td><td>AK960</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun kullandığı Kayıtlı Elektronik Posta adresinin ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 135,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 136,
                    StandartID = 1,
                    BaslikNo = "19.21",
                    Baslik = "İşlem Tanımları Üstveri Alanları",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>İşlem referans numarası</td></tr><tr><td>Referans Numarası</td><td>IT001</td></tr><tr><td>Tanım</td><td>Yapılan işlemin referans numarasını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Sorumlu Personel</td></tr><tr><td>Referans Numarası</td><td>IT110</td></tr><tr><td>Tanım</td><td>Yapılan işlemden sorumlu personel veya personelleri ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İşlem Başlama Tarihi</td></tr><tr><td>Referans Numarası</td><td>IT210</td></tr><tr><td>Tanım</td><td>İşlemin başlama tarihini ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>İşlem Bitiş Tarihi</td></tr><tr><td>Referans Numarası</td><td>IT290</td></tr><tr><td>Tanım</td><td>İşlemin bitiş tarihini ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Maliyet</td></tr><tr><td>Referans Numarası</td><td>IT352</td></tr><tr><td>Tanım</td><td>Yapılan işlemin maliyetinin ne kadar olduğunun belirtildiği üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Notlar</td></tr><tr><td>Referans Numarası</td><td>IT800</td></tr><tr><td>Tanım</td><td>İşlem tanımı ile ilgili belirtilmesi gerekenlerin ifade edildiği üstveri alanıdır. </td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Yetkili Personel</td></tr><tr><td>Referans Numarası</td><td>IT115</td></tr><tr><td>Tanım</td><td>İşlemi yapma yetkisi bulunan personeli ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Elektronik belgenin üretim, iletim ve alındısına ait tarih bilgilerinin fiziksel olarak belgeye eklenmesi veya belge ile mantıksal olarak ilişkilendirilmesidir </td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Tarih ve Zaman Damgası</td></tr><tr><td>Referans Numarası</td><td>IT550</td></tr><tr><td>Tanım</td><td>Arşiv kurumunun telefon numarasının yer aldığı üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Güncelleme İçeriği</td></tr><tr><td>Referans Numarası</td><td>IT320</td></tr><tr><td>Tanım</td><td>Yapılan işlemin ne olduğu ve hangi güncellemeleri kapsadığının ifade edildiği üstveri alanıdır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 136,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 137,
                    StandartID = 1,
                    BaslikNo = "19.22",
                    Baslik = "E-Posta Üstveri Elemanlar",
                    Detay = "<table table border='1'  cellspacing='0' cellpadding='0' ><tr><td width=150>Eleman Adı</td><td width=700>e-Posta ID</td></tr><tr><td>Referans Numarası</td><td>EP001</td></tr><tr><td>Tanım</td><td>E-postanın sistem tarafından verilen ve tekrar etmeyen referans numarasıdır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Hesap</td></tr><tr><td>Referans Numarası</td><td>EP010</td></tr><tr><td>Tanım</td><td>Posta içeriğinden sorumlu kişi veya hesabın bulunduğu kişiyi ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alıcı (To)</td></tr><tr><td>Referans Numarası</td><td>EP020</td></tr><tr><td>Tanım</td><td>E-postayı alan hesabı ifade eder. Asıl postayı alan muhataptır. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Gönderen (From)</td></tr><tr><td>Referans Numarası</td><td>EP050</td></tr><tr><td>Tanım</td><td>Elektronik postayı gönderen hesabı ifade eder</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>lıcı İlgili-Görünür (CC) (Varsa)</td></tr><tr><td>Referans Numarası</td><td>EP030</td></tr><tr><td>Tanım</td><td>E-postayı kopya olarak alan başka bir hesabı ifade eder. Mesajı alan kişi tarafından görülürdür.</td></tr><tr><td>Zorunluluk</td><td>Seçmeli</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alıcı İlgili-Görünmez (BCC) (Varsa)</td></tr><tr><td>Referans Numarası</td><td>EP080</td></tr><tr><td>Tanım</td><td>E-postayı kopya olarak alan başka bir hesabı ifade der. Mesajı alan kişi görünür değildir. Postayı gönderen hesap tarafından bilinirdir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Gönderim Tarihi/Zamanı</td></tr><tr><td>Referans Numarası</td><td>EP210</td></tr><tr><td>Tanım</td><td>E-Postanın gönderildiği tarih ve zaman bilgisidir. </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Alma Tarihi/Zamanı</td></tr><tr><td>Referans Numarası</td><td>EP220</td></tr><tr><td>Tanım</td><td>E-postanın alıcısı tarafından alındığı tarihtir ve zamandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td>Gönderim tarihi/zamanı ile alma tarihi/zamanı arasında çeşitli sebeplerden kaynaklanan farklılıklar olabilir.</td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-Posta Konusu</td></tr><tr><td>Referans Numarası</td><td>EP055</td></tr><tr><td>Tanım</td><td>Elektronik postanın içeriği hakkında kısa bilginin olduğu alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>Ek Bilgisi</td></tr><tr><td>Referans Numarası</td><td>EP750</td></tr><tr><td>Tanım</td><td>E-postanın eki ya da eklerini olup olmadığını belirlendiği alandır </td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-postanın eki ya da eklerini olup olmadığını belirlendiği alandır </td></tr><tr><td>Referans Numarası</td><td>EP300</td></tr><tr><td>Tanım</td><td>E-postanın gövde metnini ifade eden alandır.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>E-postanın Sisteme Kayıt Edilme Tarihi/Zamanı</td></tr><tr><td>Referans Numarası</td><td>EP240</td></tr><tr><td>Tanım</td><td>Alınan e-postanın sisteme kayıt edilme tarihini/zamanını ifade eder.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table><br><table table border='1'  cellspacing='0' cellpadding='0'><tr><td width=150>Eleman Adı</td><td width=700>KEP Sağlayıcı Kurulu</td></tr><tr><td>Referans Numarası</td><td>EP850</td></tr><tr><td>Tanım</td><td>Kayıtlı Elektronik Posta Sağlayıcısının bilgilerini içerir.</td></tr><tr><td>Zorunluluk</td><td>Zorunlu</td></tr><tr><td>Notlar</td><td></td></tr></table>",
                    UstIcerikID = 115,
                    StandartIcerikTipiID = 162,
                    SiraNo = 137,
                    DurumID = 1
                },
                new StandartIcerik
                {
                    StandartIcerikID = 138,
                    StandartID = 1,
                    BaslikNo = "20",
                    Baslik = "Yararlanılan Kaynaklar",
                    Detay = "<p>ANSI/ARMA 5-2010. Vital Records Programs: Identifying, Managing, and Recovering BusineÜS-Critical Records ARMA International, 2010, ISBN 978-1-931786-87-4</p><p>BS 10008:2014. Evidential weight and legal admiÜSibility of electronic information. Specification, London:2014,  ISBN 978 0 580 83673 2</p><p>Design Criteria Standard for Electronic Records Management Software Applicaitons. DoD 5015-2-STD. Washington, DC: Department of Defence, 25 Nisan 2007.</p><p>Digital recordkeeping: guidelines for creating, managing and preserving digital records. Canberra: National Archives of Australia, 2004. ISBN 1-620807-08-X</p><p>Digital Preservation in Archives:Overview of Current Research and Practices, National Archives of Sweden, 2005</p><p>ANSI/NISO Z39.85-2012: The Dublin Core Metadata Element Set, The American National Standards Institute, 20 Şubat 2013, IÜSN: 1041-5635</p><p>Guide for managing electronic records from an archival perspective. Paris: ICA Committee on Electronic Records, 1997. ISBN 0-9682361-0-3</p><p>ISO 15836:2009 -Information and documentation -- The Dublin Core metadata element set, Cenevre: ISO, 2009.</p><p>International Research on Permanent Authentic Records in Electronic Systems (InterPARES) 2: Experiential, Interactive and Dynamic Records, ed. Luciana Duranti ve Randy Preston, AÜSociazione Nazionale Archivistica Italiana Padova, Italy, 2008</p><p>ISAD (G): General International Standard Archival Description. 2nd ed. Stockholm, Sweden: ICA, Committee on Descriptive Standards, 2000. ISBN: 0-9696035-5-X</p><p>ISO 15489-1: 2001. Information and Documentation – Records Management. Part 1: General. Cenevre: ISO, 2001.</p><p>ISO 15489-2: 2001. Information and Documentation – Records Management. Part 2: Guidelines. Cenevre:ISO, 2001.</p><p>ISO/TSE 17799. Information technology: Code of practice for information security management. Cenevre: ISO, 2005.</p><p>Kandur, Hamza. Elektronik Belge Yönetim Sistemleri Referans Kriterleri v.2, Başbakanlık Devlet Arşivleri Genel Müdürlüğü, 2006, Ankara, Cumhuriyet Arşivi Daire Başkanlığı Yayın Nu: 29, ISBN: 975-19-3877-5 Management, appraisal and preservation of electronic records. 2 vol. 2nd ed. London: Public Record Office, 1999.</p><p>MoReq2 Specification: Model requirements for the management of electronic records Update  and Extension, 2008,  European CommiÜSion by Serco Consulting with funding from the IDABC programme, ISBN 978-9279-09772-0, DOI 10.2792/11981</p><p>NISO Z39-50. Information Retrieval : Application Service Definition & Protocol Specification. Bethesda, Maryland: National Information Standards Organizatoin, 2002. ISBN: 1-8800124-55-6. IÜSN: 1041-5653. NISO Z39-87. Data Dictionary – Technical Metadata for Digital Still Images. Draft standard for trial use. Bethesda, Maryland: National Information Standards Organizatoin, 2003.</p><p>Records/Document/Information Management (RDIM): Integrated Document Management System for the Government of Canada.Ottowa: National Archives Canada, 1996.</ p >< p > Requirements for Electronic Records Management Systems.Londra: Public Record Office, 2002.</ p >< p > Yalçınkaya, Bahattin.E - Devlet Üstveri Standardının Oluşturulması ve Türkiye İçin Modellenmesi, (Doktora Tezi) Marmara Üniversitesi, Bilgi ve Belge Yönetimi, 2014, Tez Numarası: 10028138 </ p > ",
                    UstIcerikID = 0,
                    StandartIcerikTipiID = 162,
                    SiraNo = 138,
                    DurumID = 1
                }
            });
            #endregion

            #region //StandartIcerikDenetim
            context.StandartIcerikDenetimler.AddRange(new List<StandartIcerikDenetim>
            {
                new StandartIcerikDenetim
                {
                    StandartIcerikDenetimID = 1,
                    StandartID = 1,
                    StandartIcerikID = 19,
                    Secmeli = false,
                    Zorunlu = true,
                    BilgiAmacli = false,
                    KurumYeterlilikSertifikasi = true,
                    UrunSertifikasi = true,
                    DurumID = 1
                },
                new StandartIcerikDenetim
                {
                    StandartIcerikDenetimID = 1,
                    StandartID = 1,
                    StandartIcerikID = 20,
                    Secmeli = false,
                    Zorunlu = true,
                    BilgiAmacli = false,
                    KurumYeterlilikSertifikasi = false,
                    UrunSertifikasi = true,
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
                    VarsayilanAdres = true,
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
                    VarsayilanAdres = true,
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
                    VarsayilanAdres = true,
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
                    VarsayilanAdres = true,
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

            base.Seed(context);
        }
    }
}