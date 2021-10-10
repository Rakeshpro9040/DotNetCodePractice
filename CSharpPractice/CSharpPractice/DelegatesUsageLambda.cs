using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class DelegatesUsageLambda
    {
        delegate bool IsPromotable(Employee empl);

        public DelegatesUsageLambda()
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { ID = 101, Name = "Mohan", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 102, Name = "Alan", Salary = 6000, Experience = 6 });
            emplist.Add(new Employee() { ID = 103, Name = "Suresh", Salary = 7000, Experience = 3 });
            emplist.Add(new Employee() { ID = 104, Name = "Jay", Salary = 4000, Experience = 3 });
            emplist.Add(new Employee() { ID = 105, Name = "Sachin", Salary = 4500, Experience = 3 });

            Employee.PromoteEmployee(emplist, Emp => Emp.Experience >= 5);
        }

       class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Experience { get; set; }

            public static void PromoteEmployee(List<Employee> employeelist, IsPromotable ispromotable)
            {
                foreach (Employee employee in employeelist)
                {
                    if (ispromotable(employee))
                    {
                        Console.WriteLine(employee.Name + " is promoted");
                    }
                }
            }
        }
    }

}
