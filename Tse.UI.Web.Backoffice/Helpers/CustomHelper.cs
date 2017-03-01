using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tse.UI.Web.Backoffice.Helpers
{
    public static class CustomHelper
    {
        public static IEnumerable<SelectListItem> AddFirstItem(this IEnumerable<SelectListItem> list, string emptyText = "", string emptyValue = "")
        {
            return new[] { new SelectListItem { Text = emptyText, Value = emptyValue } }.Concat(list);
        }
    }
}