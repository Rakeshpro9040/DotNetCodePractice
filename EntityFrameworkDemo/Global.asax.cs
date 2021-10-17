// using EntityFrameworkDemo.EFCodeFirstApproachTPT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace EntityFrameworkDemo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Only Enabled for Code First Approach 
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmployeeDBContext>());
            // Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDBContext>());
            // Database.SetInitializer(new EmployeeDBContextSeeder());
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}