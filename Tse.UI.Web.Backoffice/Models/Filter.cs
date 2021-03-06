﻿namespace Tse.UI.Web.Backoffice.Models
{
    using Dal.Backoffice.Model;
    using System.Linq;

    public partial class Filter
    {
        //Constructor
        public Filter()
        {
            Tum = 0;
            Aktif = 0;
            Pasif = 0;
            Taslak = 0;
            Silinmis = 0;
        }

        //Properties
        private int Tum { get; set; }
        private int Aktif { get; set; }
        private int Pasif { get; set; }
        private int Taslak { get; set; }
        private int Silinmis { get; set; }

        //Methods
        /// <summary>
        /// Yeni bir filtre yaratır.
        /// </summary>
        /// <param name="entityName">Filtreleme yapılacak Entity adı</param>
        /// <returns></returns>
        public Filter Create(string entityName)
        {            
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (entityName == "Ulkeler")
                {

                    Tum = context.Ulkeler.Count();
                    Aktif = context.Ulkeler.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Ulkeler.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Ulkeler.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Ulkeler.Where(u => u.DurumID == 4).Count();
                }
                else if (entityName == "Sehirler")
                {
                    Tum = context.Sehirler.Count();
                    Aktif = context.Sehirler.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Sehirler.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Sehirler.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Sehirler.Where(u => u.DurumID == 4).Count();
                }
                else if (entityName == "Ilceler")
                {
                    Tum = context.Ilceler.Count();
                    Aktif = context.Ilceler.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Ilceler.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Ilceler.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Ilceler.Where(u => u.DurumID == 4).Count();
                }
                else if (entityName == "Kategoriler")
                {
                    Tum = context.Kategoriler.Count();
                    Aktif = context.Kategoriler.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Kategoriler.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Kategoriler.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Kategoriler.Where(u => u.DurumID == 4).Count();
                }
                else if (entityName == "Standartlar")
                {
                    Tum = context.Standartlar.Count();
                    Aktif = context.Standartlar.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Standartlar.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Standartlar.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Standartlar.Where(u => u.DurumID == 4).Count();
                }
                else if (entityName == "Kisiler")
                {
                    Tum = context.Kisiler.Count();
                    Aktif = context.Kisiler.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Kisiler.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Kisiler.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Kisiler.Where(u => u.DurumID == 4).Count();
                }
                else if (entityName == "Firmalar")
                {
                    Tum = context.Firmalar.Count();
                    Aktif = context.Firmalar.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Firmalar.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Firmalar.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Firmalar.Where(u => u.DurumID == 4).Count();
                }
                else if (entityName == "Denetimler")
                {
                    Tum = context.Denetimler.Count();
                    Aktif = context.Denetimler.Where(u => u.DurumID == 1).Count();
                    Pasif = context.Denetimler.Where(u => u.DurumID == 2).Count();
                    Taslak = context.Denetimler.Where(u => u.DurumID == 3).Count();
                    Silinmis = context.Denetimler.Where(u => u.DurumID == 4).Count();
                }
                return this;
            }            
        }

        /// <summary>
        /// Yeni bir filtre yaratır.
        /// </summary>
        /// <param name="kategoriID">Kategoriler tablosundan gelen KategoriID</param>
        /// <returns></returns>
        public Filter Create(int kategoriID)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (kategoriID==8 || kategoriID==9)
                {
                    Tum = context.StandartAtifTipiSablonlar.Where(s => s.KategoriID == kategoriID).Count();
                    Aktif = context.StandartAtifTipiSablonlar.Where(s => s.KategoriID == kategoriID && s.DurumID == 1).Count();
                    Pasif = context.StandartAtifTipiSablonlar.Where(s => s.KategoriID == kategoriID && s.DurumID == 2).Count();
                    Taslak = context.StandartAtifTipiSablonlar.Where(s => s.KategoriID == kategoriID && s.DurumID == 3).Count();
                    Silinmis = context.StandartAtifTipiSablonlar.Where(s => s.KategoriID == kategoriID && s.DurumID == 4).Count();
                }
                else
                {
                    Tum = context.Degerler.Where(d=>d.KategoriID== kategoriID).Count();
                    Aktif = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID==1).Count();
                    Pasif = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID == 2).Count();
                    Taslak = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID == 3).Count();
                    Silinmis = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID == 4).Count();
                }      
                return this;
            }
        }
     
        /// <summary>
        /// Yeni bir filtre yaratır.
        /// </summary>
        /// <param name="entityName">Filtreleme yapılacak Entity adı</param>
        /// <param name="id">Filtreleme yapılacak kolon</param>
        /// <returns></returns>
        public Filter Create(string entityName, int? id)
        {
            using (TseBackofficeContext context = new TseBackofficeContext())
            {
                if (entityName == "StandartIcerikler")
                {

                    Tum = context.StandartIcerikler.Where(e=>e.StandartID==id).Count();
                    Aktif = context.StandartIcerikler.Where(e => e.StandartID == id && e.DurumID == 1).Count();
                    Pasif = context.StandartIcerikler.Where(e => e.StandartID== id && e.DurumID == 2).Count();
                    Taslak = context.StandartIcerikler.Where(e => e.StandartID == id && e.DurumID == 3).Count();
                    Silinmis = context.StandartIcerikler.Where(e => e.StandartID == id && e.DurumID == 4).Count();                            
                }
                else if(entityName== "FirmaAdres")
                {
                    Tum = context.Adresler.Where(e => e.FirmaID == id).Count();
                    Aktif = context.Adresler.Where(e => e.FirmaID == id && e.DurumID == 1).Count();
                    Pasif = context.Adresler.Where(e => e.FirmaID == id && e.DurumID == 2).Count();
                    Taslak = context.Adresler.Where(e => e.FirmaID == id && e.DurumID == 3).Count();
                    Silinmis = context.Adresler.Where(e => e.FirmaID == id && e.DurumID == 4).Count();
                }
                else if (entityName == "KisiAdres")
                {
                    Tum = context.Adresler.Where(e => e.KisiID == id).Count();
                    Aktif = context.Adresler.Where(e => e.KisiID == id && e.DurumID == 1).Count();
                    Pasif = context.Adresler.Where(e => e.KisiID == id && e.DurumID == 2).Count();
                    Taslak = context.Adresler.Where(e => e.KisiID == id && e.DurumID == 3).Count();
                    Silinmis = context.Adresler.Where(e => e.KisiID == id && e.DurumID == 4).Count();
                }
                else if (entityName == "FirmaTelefon")
                {
                    Tum = context.Telefonlar.Where(e => e.FirmaID == id).Count();
                    Aktif = context.Telefonlar.Where(e => e.FirmaID == id && e.DurumID == 1).Count();
                    Pasif = context.Telefonlar.Where(e => e.FirmaID == id && e.DurumID == 2).Count();
                    Taslak = context.Telefonlar.Where(e => e.FirmaID == id && e.DurumID == 3).Count();
                    Silinmis = context.Telefonlar.Where(e => e.FirmaID == id && e.DurumID == 4).Count();
                }
                else if (entityName == "KisiTelefon")
                {
                    Tum = context.Telefonlar.Where(e => e.KisiID == id).Count();
                    Aktif = context.Telefonlar.Where(e => e.KisiID == id && e.DurumID == 1).Count();
                    Pasif = context.Telefonlar.Where(e => e.KisiID == id && e.DurumID == 2).Count();
                    Taslak = context.Telefonlar.Where(e => e.KisiID == id && e.DurumID == 3).Count();
                    Silinmis = context.Telefonlar.Where(e => e.KisiID == id && e.DurumID == 4).Count();
                }
                else if (entityName == "FirmaEposta")
                {
                    Tum = context.Epostalar.Where(e => e.FirmaID == id).Count();
                    Aktif = context.Epostalar.Where(e => e.FirmaID == id && e.DurumID == 1).Count();
                    Pasif = context.Epostalar.Where(e => e.FirmaID == id && e.DurumID == 2).Count();
                    Taslak = context.Epostalar.Where(e => e.FirmaID == id && e.DurumID == 3).Count();
                    Silinmis = context.Epostalar.Where(e => e.FirmaID == id && e.DurumID == 4).Count();
                }
                else if (entityName == "KisiEposta")
                {
                    Tum = context.Epostalar.Where(e => e.KisiID == id).Count();
                    Aktif = context.Epostalar.Where(e => e.KisiID == id && e.DurumID == 1).Count();
                    Pasif = context.Epostalar.Where(e => e.KisiID == id && e.DurumID == 2).Count();
                    Taslak = context.Epostalar.Where(e => e.KisiID == id && e.DurumID == 3).Count();
                    Silinmis = context.Epostalar.Where(e => e.KisiID == id && e.DurumID == 4).Count();
                }
                else if (entityName == "FirmaFaturaBilgi")
                {
                    Tum = context.FaturaBilgileri.Where(e => e.FirmaID == id).Count();
                    Aktif = context.FaturaBilgileri.Where(e => e.FirmaID == id && e.DurumID == 1).Count();
                    Pasif = context.FaturaBilgileri.Where(e => e.FirmaID == id && e.DurumID == 2).Count();
                    Taslak = context.FaturaBilgileri.Where(e => e.FirmaID == id && e.DurumID == 3).Count();
                    Silinmis = context.FaturaBilgileri.Where(e => e.FirmaID == id && e.DurumID == 4).Count();
                }
                else if (entityName == "KisiFaturaBilgi")
                {
                    Tum = context.FaturaBilgileri.Where(e => e.KisiID == id).Count();
                    Aktif = context.FaturaBilgileri.Where(e => e.KisiID == id && e.DurumID == 1).Count();
                    Pasif = context.FaturaBilgileri.Where(e => e.KisiID == id && e.DurumID == 2).Count();
                    Taslak = context.FaturaBilgileri.Where(e => e.KisiID == id && e.DurumID == 3).Count();
                    Silinmis = context.FaturaBilgileri.Where(e => e.KisiID == id && e.DurumID == 4).Count();
                }               
                return this;
            }
        }

        /// <summary>
        /// durumId değerine göre kayıt sayısını döndürür. 
        /// </summary>
        /// <param name="id">0:Tümü | 1: Aktif | 2: Pasif | 3:Taslak | 4:Silinmiş</param>
        /// <returns></returns>
        public int CountByDurumId(int? durumId)
        {
            if (durumId == 1)
                return Aktif;
            else if (durumId == 2)
                return Pasif;
            else if (durumId == 3)
                return Taslak;
            else if (durumId == 4)
                return Silinmis;
            else
                return Tum;                                            
        }      
    }
}
