using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachOverrideSP
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // This line will tell entity framework to use stored procedures
            // when inserting, updating and deleting Employees

            // Overriding only SP names
            /*
            modelBuilder.Entity<Employee>().MapToStoredProcedures(p => p.Insert(x => x.HasName("InsertEmployee")));
            modelBuilder.Entity<Employee>().MapToStoredProcedures(p => p.Update(x => x.HasName("UpdateEmployee")));
            modelBuilder.Entity<Employee>().MapToStoredProcedures(p => p.Delete(x => x.HasName("DeleteEmployee")));
            */
            // The above code can be re-written as below
            /*
            modelBuilder.Entity<Employee>().MapToStoredProcedures
            (p => p.Insert(i => i.HasName("InsertEmployee"))
                    .Update(u => u.HasName("UpdateEmployee"))
                    .Delete(d => d.HasName("DeleteEmployee"))
            );
            */

            // Overriding both SP and parameter name
            modelBuilder.Entity<Employee>().MapToStoredProcedures
            (p => p.Insert(i => i.HasName("InsertEmployee")
                                    .Parameter(n => n.Name, "EmployeeName")
                                    .Parameter(n => n.Gender, "EmployeeGender")
                                    .Parameter(n => n.Salary, "EmployeeSalary"))
                    .Update(u => u.HasName("UpdateEmployee")
                                    .Parameter(n => n.ID, "EmployeeID")
                                    .Parameter(n => n.Name, "EmployeeName")
                                    .Parameter(n => n.Gender, "EmployeeGender")
                                    .Parameter(n => n.Salary, "EmployeeSalary"))
                    .Delete(d => d.HasName("DeleteEmployee")
                                    .Parameter(n => n.ID, "EmployeeID"))
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}