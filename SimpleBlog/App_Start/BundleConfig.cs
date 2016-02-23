using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.Optimization;
using System.Web.Optimization;

namespace SimpleBlog.App_Start
{
    public class BundleConfig
    {

        internal static void RegisterBundles(System.Web.Optimization.BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
             .Include("~/Content/bootstrap.css")
             .Include("~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/bootstrap.css")
                .Include("~/content/site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scripts/jquery-2.2.0.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/scripts/modernizr-2.6.2.js"));

            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-2.2.0.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/scripts/modernizr-2.6.2.js"));
        }
    }
}