namespace Tse.UI.Web.Backoffice.Models
{
    using Dal.Backoffice.Model;
    using System.Linq;
    using System.Data.Entity;
    using System.Data.Entity.Core.Metadata.Edm;
    using System.Collections.Generic;
    using System;

    public partial class Filter
    {
        //Constructor
        public Filter()
        {
            ByTum = 0;
            ByAktif = 0;
            ByPasif = 0;
            ByTaslak = 0;
            BySilinmis = 0;
        }

        //Properties
        private int ByTum { get; set; }
        private int ByAktif { get; set; }
        private int ByPasif { get; set; }
        private int ByTaslak { get; set; }
        private int BySilinmis { get; set; }

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
                Filter filter = new Filter();

                if (entityName=="Ulkeler")
                {
                    filter.ByTum = context.Ulkeler.Count();
                    filter.ByAktif = context.Ulkeler.Where(u => u.DurumID == 1).Count();
                    filter.ByPasif = context.Ulkeler.Where(u => u.DurumID == 2).Count();
                    filter.ByTaslak = context.Ulkeler.Where(u => u.DurumID == 3).Count();
                    filter.BySilinmis = context.Ulkeler.Where(u => u.DurumID == 4).Count();
                }

                return filter;
            }            
        }
    }
}
