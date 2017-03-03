namespace Tse.UI.Web.Backoffice.Models
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
                Tum = context.Degerler.Where(d=>d.KategoriID== kategoriID).Count();
                Aktif = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID==1).Count();
                Pasif = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID == 2).Count();
                Taslak = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID == 3).Count();
                Silinmis = context.Degerler.Where(d => d.KategoriID == kategoriID && d.DurumID == 4).Count();

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
