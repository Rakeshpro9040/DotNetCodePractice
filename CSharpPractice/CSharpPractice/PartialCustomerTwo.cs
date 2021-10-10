using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + ", " + _lastName;
        }

        // Partial method implemented
        partial void SampleMethod()
        {
            Console.WriteLine("Partial SampleMethod Invoked");
        }
    }
}
