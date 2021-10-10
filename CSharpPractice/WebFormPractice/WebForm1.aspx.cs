using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormPractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*************   Indexers-1   ************/

            /*
            // Using the string indexer to store session data
            Session["Session1"] = "Session 1 Data";
            // Using the string indexer to store session data
            Session["Session2"] = "Session 2 Data";

            // Using the integral indexer to retrieve data 
            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");
            // Using the string indexer to retrieve data 
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());
            */

            /*************   Indexers-2   ************/
            /*
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Using integral indexer to retrieve Id column value
                    Response.Write("Id = " + rdr[0].ToString() + " ");
                    // Using string indexer to retrieve Id column value
                    Response.Write("Name = " + rdr["Name"].ToString());
                    Response.Write("<br/>");
                }
            }
            */

            /*************   Indexers-3: Create Indexer  ************/
            /*
            Company company = new Company();
            Response.Write("Name of Employee with Id = 2: " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8]);

            Response.Write("<br/>");
            Response.Write("<br/>");

            Response.Write("Changing names of employees with Id = 2,5,8");
            Response.Write("<br/>");
            company[2] = "Employee 2 Name Changed";
            company[5] = "Employee 5 Name Changed";
            company[8] = "Employee 8 Name Changed";

            Response.Write("Name of Employee with Id = 2: " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8]);
            */

            /*************   Indexers-4: Indexer Overload   ************/
            Company company = new Company();

            Response.Write("Before changing the Gender of all male employees to Female");
            Response.Write("<br/>");

            // Get accessor of string indexer is invoked to return the total
            // count of male employees
            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);
            Response.Write("<br/>");
            Response.Write("<br/>");

            // Set accessor of string indexer is invoked to change the gender
            // all "Male" employees to "Female"
            company["Male"] = "Female";

            Response.Write("After changing the Gender of all male employees to Female");
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);

        }
    }
}