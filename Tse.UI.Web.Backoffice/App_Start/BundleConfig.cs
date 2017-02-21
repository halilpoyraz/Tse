using System.Web;
using System.Web.Optimization;

namespace Tse.UI.Web.Backoffice
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                    "~/Content/assets/global/plugins/font-awesome/css/font-awesome.css",
                    "~/Content/assets/global/plugins/simple-line-icons/simple-line-icons.css",
                    "~/Content/assets/global/plugins/bootstrap/css/bootstrap.css",
                    "~/Content/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.css",
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

            bundles.Add(new ScriptBundle("~/bundles/script").Include(                                
                    "~/Content/assets/global/plugins/bootstrap/js/bootstrap.js",
                    "~/Content/assets/global/plugins/js.cookie.min.js",
                    "~/Content/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.js",
                    "~/Content/assets/global/plugins/jquery.blockui.min.js",
                    "~/Content/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.js",
                    "~/Content/assets/global/plugins/moment.min.js",
                    "~/Content/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.js",
                    "~/Content/assets/global/plugins/morris/morris.js",
                    "~/Content/assets/global/plugins/morris/raphael-min.js",
                    "~/Content/assets/global/plugins/counterup/jquery.waypoints.min.js",
                    "~/Content/assets/global/plugins/counterup/jquery.counterup.min.js",
                    "~/Content/assets/global/plugins/amcharts/amcharts/amcharts.js",
                    "~/Content/assets/global/plugins/amcharts/amcharts/serial.js",
                    "~/Content/assets/global/plugins/amcharts/amcharts/pie.js",
                    "~/Content/assets/global/plugins/amcharts/amcharts/radar.js",
                    "~/Content/assets/global/plugins/amcharts/amcharts/themes/light.js",
                    "~/Content/assets/global/plugins/amcharts/amcharts/themes/patterns.js",
                    "~/Content/assets/global/plugins/amcharts/amcharts/themes/chalk.js",
                    "~/Content/assets/global/plugins/amcharts/ammap/ammap.js",
                    "~/Content/assets/global/plugins/amcharts/ammap/maps/js/worldLow.js",
                    "~/Content/assets/global/plugins/amcharts/amstockcharts/amstock.js",
                    "~/Content/assets/global/plugins/fullcalendar/fullcalendar.js",
                    "~/Content/assets/global/plugins/horizontal-timeline/horizontal-timeline.js",
                    "~/Content/assets/global/plugins/flot/jquery.flot.js",
                    "~/Content/assets/global/plugins/flot/jquery.flot.resize.js",
                    "~/Content/assets/global/plugins/flot/jquery.flot.categories.js",
                    "~/Content/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.js",
                    "~/Content/assets/global/plugins/jquery.sparkline.min.js",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/jquery.vmap.js",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.russia.js",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.world.js",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.europe.js",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.germany.js",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.usa.js",
                    "~/Content/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js",
                    "~/Content/assets/global/scripts/app.js",
                    "~/Content/assets/pages/scripts/dashboard.js",
                    "~/Content/assets/layouts/layout/scripts/layout.js",
                    "~/Content/assets/layouts/layout/scripts/demo.js",
                    "~/Content/assets/layouts/global/scripts/quick-sidebar.js",
                    "~/Content/assets/layouts/global/scripts/quick-nav.js",
                    "~/Content/assets/global/scripts/datatable.js",
                    "~/Content/assets/global/plugins/datatables/datatables.min.js",
                    "~/Content/assets/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.js",
                    "~/Content/assets/apps/scripts/table-datatables-ulke.js",
                    "~/Content/assets/global/plugins/bootstrap-table/bootstrap-table.js",
                    "~/Content/assets/global/plugins/bootstrap-table-contextmenu/bootstrap-table-contextmenu.js"
                    ));
        }
    }
}
