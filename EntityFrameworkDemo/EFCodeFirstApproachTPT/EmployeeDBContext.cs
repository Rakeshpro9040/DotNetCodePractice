using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachTPT
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        // Fluent API to do the table mapping
        // We can comment out the [Table] rename attributes
        // in each of the Model classes
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractEmployee>().ToTable("ContractEmployees");
            modelBuilder.Entity<PermanentEmployee>().ToTable("PermanentEmployees");

            base.OnModelCreating(modelBuilder);
        }
    }
}