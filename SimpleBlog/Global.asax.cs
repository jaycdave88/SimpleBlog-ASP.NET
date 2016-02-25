using SimpleBlog.FilterConfig;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.AppStart;

namespace SimpleBlog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);
            App_Start.FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            Database.Configure();
           
        }

        protected void Application_BeginRequest()
        {
            Database.OpenSession();
        }

        protected void Application_EndRequest()
        {
            Database.CloseSession();
        }
    }
}
