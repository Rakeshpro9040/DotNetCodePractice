using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class EnumClass
    {
        public static void EnumClassMain()
        {
            Console.WriteLine($"Maximum value short dattype can hold = {short.MaxValue}");
            Console.WriteLine($"Testing: {typeof(Gender)}");

            // Here typeof is used to pass the Type of Gender Enum
            short[] Values = (short[])Enum.GetValues(typeof(Gender));
            Console.WriteLine("Gender Enum Values");
            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            string[] Names = Enum.GetNames(typeof(Gender));
            Console.WriteLine("Gender Enum Names");
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }

        public enum Gender : short
        {
            Unknown = 1,
            Male = 2,
            Female = 3
        }
    }
}
