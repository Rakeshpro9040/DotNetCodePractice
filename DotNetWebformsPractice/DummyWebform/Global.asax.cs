using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace DummyWebform
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            HttpContext con = HttpContext.Current;
            var v = Server.GetLastError();

            var HttpEx = v as HttpException;
            if (HttpEx != null && HttpEx.GetHttpCode() == 404)
            {
                // Invalid URL
                //Server.Transfer("~/POC/PageNotFound.aspx");

            }
            else
            {
                // Exception 
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Page :           " + con.Request.Url.ToString());
                sb.AppendLine("Error Message :  " + v.Message);
                sb.AppendLine("Inner Message :  " + v.InnerException.ToString());

                // Here save text file containing this error details
                string fileName = Path.Combine(Server.MapPath("~/Errors"), DateTime.Now.ToString("ddMMyyyyhhmmss") + ".txt");
                File.WriteAllText(fileName, sb.ToString());
                Server.Transfer("~/POC/DummyErrorPage.aspx");
            }
        }
    }
}