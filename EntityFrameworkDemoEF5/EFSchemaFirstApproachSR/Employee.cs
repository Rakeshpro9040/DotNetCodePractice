//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDemoEF5.EFSchemaFirstApproachSR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Subordinates = new HashSet<Employee>();
        }
    
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<int> ManagerID { get; set; }
    
        public virtual ICollection<Employee> Subordinates { get; set; }
        public virtual Employee Manager { get; set; }
    }
}
