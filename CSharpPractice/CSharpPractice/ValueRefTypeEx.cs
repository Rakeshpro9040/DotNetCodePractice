using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ValueRefTypeEx
    {
        public static void ValueRefTypeExMain()
        {
            // Value Type - Diff Copy
            int i = 10;
            int j = i;
            j += 1;

            Console.WriteLine($"i = {i}, j = {j}");

            // Ref Type - Same Copy in memory for Object
            Customer C1 = new Customer();
            C1.ID = 101;
            C1.Name = "Mark";

            Customer C2 = C1;
            C2.ID = 102;
            C2.Name = "John";

            Console.WriteLine($"C1.ID = {C1.ID}, C1.Name = {C1.Name}");
            Console.WriteLine($"C2.ID = {C1.ID}, C2.Name = {C1.Name}");

        }

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
