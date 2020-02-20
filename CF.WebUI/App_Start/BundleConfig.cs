using System.Web.Optimization;

namespace MVCEvimiKur.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Common/Styles").Include(
                "~/Content/CommonTheme/css/bootstrap.min.css",
                "~/Content/CommonTheme/css/bootstrap-reset.css",
                "~/Content/CommonTheme/assets/font-awesome/css/font-awesome.css",
                "~/Content/CommonTheme/css/owl.carousel.css",
                "~/Content/CommonTheme/css/style.css",
                "~/Content/CommonTheme/css/style-responsive.css"
                ));

            bundles.Add(new ScriptBundle("~/Common/Scripts").Include(
                "~/Content/CommonTheme/js/jquery.js",
                "~/Content/CommonTheme/js/jquery-1.8.3.min.js",
                "~/Content/CommonTheme/js/bootstrap.min.js",
                "~/Content/CommonTheme/js/jquery.dcjqaccordion.2.7.js",
                "~/Content/CommonTheme/js/jquery.scrollTo.min.js",
                "~/Content/CommonTheme/js/jquery.nicescroll.js",
                "~/Content/CommonTheme/js/jquery.sparkline.js",
                "~/Content/CommonTheme/js/owl.carousel.js",
                "~/Content/CommonTheme/js/jquery.customSelect.min.js",
                "~/Content/CommonTheme/js/respond.min.js",
                "~/Content/CommonTheme/js/common-scripts.js"
                ));
        }
    }
}