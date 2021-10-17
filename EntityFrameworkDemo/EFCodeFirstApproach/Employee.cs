using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproach
{
    // Below decorator will be used to change table name
    // [Table("tblEmployees")]
    public class Employee
    {
        // Scalar Properties
        public int Id { get; set; }
        // Below decorator will be used to change column name
        // [Column("First_Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        

        // Navigation Property
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public string JobTitle { get; set; }
    }
}