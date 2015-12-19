using System.Web;
using System.Web.Optimization;

namespace AngularJS_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/AngularJS-MVC")
            .IncludeDirectory("~/Scripts/Controllers", "*.js")
            .Include("~/Scripts/AngularJS-MVC.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
