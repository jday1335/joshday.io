using System.Web;
using System.Web.Optimization;

namespace joshday.io
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-mdb").Include(
                        "~/Scripts/mdbootstrap/js/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-mdb").Include(
                        "~/Scripts/mdbootstrap/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mdbootstrap").Include(
                        "~/Scripts/mdbootstrap/js/mdb.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Scripts/mdbootstrap/js/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mdbootstrap-addons").Include(
                        //"~/Scripts/mdbootstrap/js/addons/datatables-select.min.js",
                        "~/Scripts/mdbootstrap/js/addons/datatables.min.js",
                        "~/Scripts/mdbootstrap/js/addons/directives.min.js",
                        "~/Scripts/mdbootstrap/js/addons/flag.min.js",
                        "~/Scripts/mdbootstrap/js/addons/imagesloaded.pkgd.min.js",
                        "~/Scripts/mdbootstrap/js/addons/jquery.zmd.hierarchical-display.min.js",
                        "~/Scripts/mdbootstrap/js/addons/masonry.pkgd.min.js",
                        "~/Scripts/mdbootstrap/js/addons/rating.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mdbootstrap-addons-pro").Include(
                        "~/Scripts/mdbootstrap/js/addons-pro/cards-extended.min.js",
                        "~/Scripts/mdbootstrap/js/addons-pro/chat.min.js",
                        "~/Scripts/mdbootstrap/js/addons-pro/multi-range.min.js",
                        "~/Scripts/mdbootstrap/js/addons-pro/simple-charts.min.js",
                        "~/Scripts/mdbootstrap/js/addons-pro/steppers.min.js",
                        "~/Scripts/mdbootstrap/js/addons-pro/timeline.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mdbootstrap-modules").Include(
                        "~/Scripts/mdbootstrap/js/modules/dropdown/dropdown-searchable.min.js",
                        "~/Scripts/mdbootstrap/js/modules/dropdown/dropdown.min.js",
                        "~/Scripts/mdbootstrap/js/modules/material-select/material-select-view-renderer.min.js",
                        "~/Scripts/mdbootstrap/js/modules/material-select/material-select-view.min.js",
                        "~/Scripts/mdbootstrap/js/modules/material-select/material-select.min.js",
                        "~/Scripts/mdbootstrap/js/modules/accordion-extended.min.js",
                        "~/Scripts/mdbootstrap/js/modules/animations-extended.min.js",
                        "~/Scripts/mdbootstrap/js/modules/buttons.min.js",
                        "~/Scripts/mdbootstrap/js/modules/cards.min.js",
                        "~/Scripts/mdbootstrap/js/modules/character-counter.min.js",
                        "~/Scripts/mdbootstrap/js/modules/chips.min.js",
                        "~/Scripts/mdbootstrap/js/modules/collapsible.min.js",
                        "~/Scripts/mdbootstrap/js/modules/file-input.min.js",
                        "~/Scripts/mdbootstrap/js/modules/forms-free.min.js",
                        "~/Scripts/mdbootstrap/js/modules/lightbox.min.js",
                        "~/Scripts/mdbootstrap/js/modules/mdb-autocomplete.min.js",
                        "~/Scripts/mdbootstrap/js/modules/megamenu.min.js",
                        "~/Scripts/mdbootstrap/js/modules/parallax.min.js",
                        "~/Scripts/mdbootstrap/js/modules/preloading.min.js",
                        "~/Scripts/mdbootstrap/js/modules/range-input.min.js",
                        "~/Scripts/mdbootstrap/js/modules/scrolling-navbar.min.js",
                        "~/Scripts/mdbootstrap/js/modules/sidenav.min.js",
                        "~/Scripts/mdbootstrap/js/modules/smooth-scroll.min.js",
                        "~/Scripts/mdbootstrap/js/modules/sticky.min.js",
                        "~/Scripts/mdbootstrap/js/modules/treeview.min.js",
                        "~/Scripts/mdbootstrap/js/modules/wow.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                        "~/Scripts/script.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/mdbootstrap/css/bootstrap.min.css",
                      "~/Scripts/mdbootstrap/css/mdb.min.css",
                      //"~/Scripts/mdbootstrap/css/addons/datatables-select.min.css",
                      "~/Scripts/mdbootstrap/css/addons/datatables.min.css",
                      "~/Scripts/mdbootstrap/css/addons/directives.min.css",
                      "~/Scripts/mdbootstrap/css/addons/flag.min.css",
                      "~/Scripts/mdbootstrap/css/addons/jquery.zmd.hierarchiacal-display.min.css",
                      "~/Scripts/mdbootstrap/css/addons/rating.min.css",
                      "~/Scripts/mdbootstrap/css/addons-pro/cards-extended.min.css",
                      "~/Scripts/mdbootstrap/css/addons-pro/chat.min.css",
                      "~/Scripts/mdbootstrap/css/addons-pro/multi-range.min.css",
                      "~/Scripts/mdbootstrap/css/addons-pro/simple-charts.min.css",
                      "~/Scripts/mdbootstrap/css/addons-pro/steppers.min.css",
                      "~/Scripts/mdbootstrap/css/addons-pro/timeline.min.css",
                      "~/Scripts/mdbootstrap/css/modules/accordion-extended.min.css",
                      "~/Scripts/mdbootstrap/css/modules/animations-extended.min.css",
                      "~/Scripts/mdbootstrap/css/modules/lightbox.min.css",
                      "~/Scripts/mdbootstrap/css/modules/megamenu.min.css",
                      "~/Scripts/mdbootstrap/css/modules/parallax.min.css",
                      "~/Content/site.css"));
        }
    }
}
