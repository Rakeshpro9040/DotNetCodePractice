using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachTS
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(pk => pk.EmployeeID)
                .ToTable("Employees");

            modelBuilder.Entity<EmployeeContactDetail>()
                .HasKey(pk => pk.EmployeeID)
                .ToTable("Employees");

            // This is smililar to the configuration of foreign key in edmx, refer to slide
            modelBuilder.Entity<Employee>()
                .HasRequired(p => p.EmployeeContactDetail)
                .WithRequiredPrincipal(c => c.Employee);
        }
    }
}