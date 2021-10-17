using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkDemoEF5.EFSchemaFirstApproachCM
{
    public partial class EFSchemaFirstApproachCMWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            // LINQ
            // GridView1.DataSource = employeeDBContext.Employees.ToList().Where(emp => emp.IsTerminated == false);

            // ToList()
            GridView1.DataSource = employeeDBContext.Employees.ToList();
            GridView1.DataBind();
        }
    }
}