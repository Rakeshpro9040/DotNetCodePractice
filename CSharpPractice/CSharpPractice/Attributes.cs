using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Attributes
    {
        public static void AttributesMain()
        {
            //This will now generate an Error/Warning based on Attribute Customization
            //Calculator.Add(10, 15);

            //Below Code will work fine
            var Sum = Calculator.Add(new List<int>() { 10, 15 });
            Console.WriteLine($"Sum: {Sum}");
        }

        public class Calculator
        {
            //Without warning message
            //[Obsolete]

            //With warning message
            //[Obsolete("Use Add(List<int> Numbers) instead")]

            //With a compiler error instead of warning
            [Obsolete("Use Add(List<int> Numbers) instead", true)]

            public static int Add(int FirstNumber, int SecondNumber)
            {
                return FirstNumber + SecondNumber;
            }
            public static int Add(List<int> Numbers)
            {
                int Sum = 0;
                foreach (int Number in Numbers)
                {
                    Sum = Sum + Number;
                }
                return Sum;
            }
        }
    }
}
