using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Polymorphism
    {
        public static void PolymorphismMain()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}