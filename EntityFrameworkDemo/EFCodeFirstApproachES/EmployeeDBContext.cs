using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachES
{
    public class EmployeeDBContext : DbContext
    {        
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
            // Specify properties to map to Employees table
            .Map(map =>
            {
                map.Properties(p => new
                {
                    p.EmployeeId,
                    p.FirstName,
                    p.LastName,
                    p.Gender
                });

                map.ToTable("Employees"); // we can give any name here, this will be reflected in DB
            })
            // Specify properties to map to EmployeeContactDetails table
            .Map(map =>
            {
                map.Properties(p => new
                {
                    p.EmployeeId,
                    p.Email,
                    p.Mobile,
                    p.Landline
                });

                map.ToTable("EmployeeContactDetails");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}