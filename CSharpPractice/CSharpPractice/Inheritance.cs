using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    // Base/Parent Class
    class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";
        // public string Email;

        public Employee()
        {
            Console.WriteLine("Parent Class Constructor Called");
        }

        public Employee(string Message)
        {
            Console.WriteLine(Message + " - " + "Testing");
        }

        public virtual void PrintFullName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }
    }

    // Derived/Child Class
    class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        public FullTimeEmployee() : base("Derived class controlling Parent class")
        {
            Console.WriteLine("Child Class Constructor Called");
        }

        public override void PrintFullName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " - Full Time");
        }
    }
    class PartTimeEmployee : Employee
    {
        // public float HourlyRate;
    }

    class TemporaryEmployee : Employee
    {

    }

    class Inheritance
    {
        public static void InheritanceeMain()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Rakesh";
            FTE.LastName = "Panigrahi";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            /*PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Rakesh";
            PTE.LastName = "Panigrahi";
            PTE.HourlyRate = 500000;
            PTE.PrintFullName();*/
        }
    }
}
