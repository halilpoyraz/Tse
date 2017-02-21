using System.Web;
using System.Web.Mvc;

namespace Tse.UI.Web.Backoffice
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
