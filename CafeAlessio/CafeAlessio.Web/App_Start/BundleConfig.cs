using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CafeAlessio.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-1.12.4.js",
                "~/Scripts/jquery-ui-1.12.1.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"
                        ));


            bundles.Add(new ScriptBundle("~/bootstrap/js").Include("~/js/bootstrap.js"/*, "~/js/site.js"*/));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.css"/*, "~/Content/Site.css"*/));

            
            BundleTable.EnableOptimizations = true;
        }
    }
}