using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] {typeof (PostsController).Namespace}; // creating namespace to allow for multiple controllers with the same name (ie index PostsController and namespace Admin, PostsController

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces); // Login Route

            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "Logout" }, namespaces); // Logout Route

            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces); // Index Route
        }
    }
}
