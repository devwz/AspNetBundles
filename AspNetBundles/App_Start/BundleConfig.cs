using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AspNetBundles
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/Script.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Style.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}