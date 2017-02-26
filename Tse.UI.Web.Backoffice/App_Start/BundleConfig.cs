using System.Web;
using System.Web.Optimization;

namespace Tse.UI.Web.Backoffice
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/cssHead").Include(
                    "~/Content/assets/global/plugins/font-awesome/css/font-awesome.css",
                    "~/Content/assets/global/plugins/simple-line-icons/simple-line-icons.css",
                    "~/Content/assets/global/plugins/bootstrap/css/bootstrap.css",
                    "~/Content/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.css",
                    "~/Content/assets/global/plugins/select2/css/select2.css",
                    "~/Content/assets/global/plugins/select2/css/select2-bootstrap.min.css",
                    "~/Content/assets/global/plugins/bootstrap-datepicker/css/bootstrap-datepicker3.css",
                    "~/Content/assets/global/plugins/bootstrap-wysihtml5/bootstrap-wysihtml5.css",
                    "~/Content//assets/global/plugins/bootstrap-markdown/css/bootstrap-markdown.min.css",
                    "~/Content/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.css",
                    "~/Content/assets/global/plugins/morris/morris.css",
                    "~/Content/assets/global/plugins/fullcalendar/fullcalendar.css",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/jqvmap.css",
                    "~/Content/assets/layouts/layout/css/layout.css",
                    "~/Content/assets/layouts/layout/css/themes/darkblue.css",
                    "~/Content/assets/layouts/layout/css/custom.css",
                    "~/Content/assets/global/plugins/datatables/datatables.min.css",
                    "~/Content/assets/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.css",
                    "~/Content/assets/global/css/components.css",
                    "~/Content/assets/global/css/plugins.css",
                    "~/Content/assets/global/plugins/simple-line-icons/simple-line-icons.css",
                    "~/Content/assets/global/plugins/bootstrap-table/bootstrap-table.css"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/scriptHead").Include(
                "~/Content/assets/global/plugins/modernizr/modernizr-2.8.3.js",
                "~/Content/assets/global/plugins/jquery.min.js"
                ));
                     
            bundles.Add(new ScriptBundle("~/bundles/scriptFoother").Include());
        }
    }
}
