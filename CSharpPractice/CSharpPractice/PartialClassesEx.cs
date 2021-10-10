using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class PartialClassesEx
    {
        public static void PartialClassesExMain()
        {
            // Without PartialClass
            Customer c1 = new Customer();
            c1.FirstName = "Rakesh";
            c1.LastName = "Panigrahi";

            string FullName1 = c1.GetFullName();
            Console.WriteLine($"Full Name = {FullName1}");

            // With PartialClass
            PartialCustomer c2 = new PartialCustomer();
            c2.FirstName = "Rakesh";
            c2.LastName = "Panigrahi";

            string FullName2 = c2.GetFullName();
            Console.WriteLine($"Full Name = {FullName2}");
            Console.WriteLine();

            // Invoke Partial method via Public Method due to private 
            c2.PublicMethod();
            
        }

        public class Customer
        {
            private string _firstName;
            private string _lastName;

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            public string LastName { get => _lastName; set => _lastName = value; }

            public string GetFullName()
            {
                return _firstName + ", " + _lastName;
            }
        }
    }
}
