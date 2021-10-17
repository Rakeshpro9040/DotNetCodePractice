using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachCM
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // A table column cannot be mapped more than once.
            // Hence at the last line we are ignoring the field
            // as its already mapped/filetered above
            // HasValue is like Where and Requires is to specify column
            modelBuilder.Entity<Employee>()
                .Map(m => m.Requires("IsTerminated")
                .HasValue(true))
                .Ignore(m => m.IsTerminated);

            base.OnModelCreating(modelBuilder);
        }
    }
}