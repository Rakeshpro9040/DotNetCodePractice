using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachSR
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // NOTE:
            // Refer to Model First Approach
            // There also we did the same mapping but in UI mode
            // Here, we are doing the same process in coding
            // First, we are defining the Navigation Properties mapping
            // HasOptional means the employee can have Zero or One Manager
            // WithMany means the manager can have Many employees
            // Secondly, we are defining the  self-referencing association (0 .. 1)
            // HasForeignKey() defines the referential intigity
            // between manager and employee Id i.e. the FK relationship between
            // the two Navigation properties
            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Manager)
                .WithMany()
                .HasForeignKey(m => m.ManagerID);

            base.OnModelCreating(modelBuilder);
        }

    }
}