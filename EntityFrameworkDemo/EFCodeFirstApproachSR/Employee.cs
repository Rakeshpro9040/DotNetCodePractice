using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachSR
{
    public class Employee
    {
        // Scalar properties
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        // int? is same as Nullable<int>
        public int? ManagerID { get; set; }

        // Navigation property
        public Employee Manager { get; set; }
    }
}