using System.Web;
using System.Web.Optimization;

namespace TurkSeker.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
         "~/Content/kendo/js/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Content/kendo/js/kendo.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
              "~/Content/kendo/js/cultures/kendo.culture.tr-TR.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Content/kendo/js/messages/kendo.messages.tr-TR.min.js"));

 
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                      "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                      "~/Content/plugins/jqvmap/jqvmap.min.css",
                      "~/Content/dist/css/adminlte.min.css",
                      "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                      "~/Content/plugins/daterangepicker/daterangepicker.css",
                      "~/Content/plugins/summernote/summernote-bs4.css"));
        }
    }
}
