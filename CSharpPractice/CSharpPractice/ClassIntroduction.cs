using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ClassIntroduction
    {
        public static void ClassIntroductionMain()
        {
            Customer C1 = new Customer("Rakesh", "Panigrahi");
            C1.PrintFullName();

            // Parametereless Constructor
            Customer C2 = new Customer();
            C2.PrintFullName();
        }
    }

    class Customer
    {
        // Class Fields/State/Data
        string _firstName;
        string _lastName;

        // Constructors
        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            this._lastName = LastName;
        }

        // Constructor Overloading
        // Parametereless Constructor
        public Customer() : this("No FirstName provided", "No LastName provided")
        {

        }

        // Class Behaviour 
        public void PrintFullName()
        {
            Console.WriteLine($"Full Name = {this._firstName} {this._lastName}");
        }

        // Destructor
        ~Customer()
        {
            // Clean up code
            Console.WriteLine("Destructor invoked by Garbage Collector Implicitly");
        }

    }
}
