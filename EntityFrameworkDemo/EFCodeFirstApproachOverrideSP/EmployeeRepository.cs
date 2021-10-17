using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachOverrideSP
{
    public class EmployeeRepository
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public List<Employee> GetEmployees()
        {
            return employeeDBContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            // Insert employee object
            employeeDBContext.Employees.Add(employee);
            // Commit changes to DB
            employeeDBContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            // Using LINQ retrive the employee object that we want to updtae
            Employee employeeToUpdate = employeeDBContext.Employees.SingleOrDefault(x => x.ID == employee.ID);
            // Update the enployee object properties
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Salary = employee.Salary;
            employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            Employee employeeToDelete = employeeDBContext.Employees.SingleOrDefault(x => x.ID == employee.ID);
            // Delete the employee object
            employeeDBContext.Employees.Remove(employeeToDelete);
            employeeDBContext.SaveChanges();
        }
    }
}