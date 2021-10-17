using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkDemoEF5.EFSchemaFirstApproachSR
{
    public partial class EFSchemaFirstApproachSRWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            // Select the Employee Name and It's Manager's Name
            GridView1.DataSource = employeeDBContext.Employees.Select(emp => new
            {
                EmployeeName = emp.EmployeeName,

                // Manager's Name can be fetched by joining with the
                // Navigation Property "Manager" and returning the 
                // coresponding EmployeeName column for the Id
                ManagerName = emp.Manager == null ? "Super Boss" : emp.Manager.EmployeeName
            }).ToList();

            // DataBind is to display data in Gridview
            GridView1.DataBind();
        }
    }
}