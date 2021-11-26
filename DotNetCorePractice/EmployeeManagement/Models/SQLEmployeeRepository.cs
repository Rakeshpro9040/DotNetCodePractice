using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<SQLEmployeeRepository> logger;

        public SQLEmployeeRepository(AppDbContext context, ILogger<SQLEmployeeRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");

            return context.Employees.Find(Id);
        }

        /// <summary>
        /// Implementation of the update method is slightly different.
        /// We take the employee object that has the changes and
        /// attach it to the employee's property of the context object.
        /// We use the attach method for that.
        /// Now we have to tell entity framework the entity that we have attached is modified,
        /// the way we do that is by setting the state property on the employee entity to modified.
        /// Next on the context object call Save Changes method,
        /// when the Save Changes method is called that's when entity framework issues 
        /// the required updates equal sql statement to update the data in the employees table 
        /// in the underlying sequel server database once the changes are saved.
        /// Finally, let's return the updated employee object.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        public Employee Update(Employee employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
