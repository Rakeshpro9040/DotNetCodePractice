using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPractice
{
    class LambdaExpression
    {
        public static void LambdaExpressionMain()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Mark"},
                new Employee{ ID = 102, Name = "John"},
                new Employee{ ID = 103, Name = "Mary"},
            };

            // Lambda Expression
            Employee employee = listEmployees.Find(Emp => Emp.ID == 102);
            Console.WriteLine("ID = {0}, Name {1}", employee.ID, employee.Name);

            // Using Linq
            int count = listEmployees.Count(Emp => Emp.Name.StartsWith("M"));
            Console.WriteLine($"Count = {count}");
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

    }

}
