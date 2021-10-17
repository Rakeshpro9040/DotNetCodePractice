using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachES
{
    public class Employee
    {
        // These property values should be stored in Employees Table
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        // These property values should be stored in EmployeeContactDetails Table
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
    }
}