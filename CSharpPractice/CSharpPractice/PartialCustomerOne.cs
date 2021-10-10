using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // Declaration of the partial method.
        // Check PartialCustomerTwo.cs for Implementaion
        partial void SampleMethod();

        // In the same class also we can provide Implementation
        /*partial void SampleMethod()
        {
            Console.WriteLine("Partial SampleMethod Invoked");
        }*/

        // Declare a Public method to invoke Partial Method
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SampleMethod();
        }
    }
}
