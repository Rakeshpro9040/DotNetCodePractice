using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpPractice
{
    class OptionalParameter
    {
        public static void OptionalParameterMain()
        {
            // Use parameter arrays
            AddNumbers1(10, 20, 30, 40, 50);
            Console.WriteLine();

            // Making method parameters optional using method overloading
            AddNumbers2(10, 20);
            AddNumbers2(10, 20, new int[] { 30, 40, 50 });
            Console.WriteLine();

            // Making method parameters optional by specifying parameter defaults
            AddNumbers3(10, 20);
            AddNumbers3(10, 20, new int[] { 30, 40, 50 });
            Console.WriteLine();

            // Named Parameter
            AddNumbers4(10);
            AddNumbers4(10, 20);
            // Here we are not  passing the parameter b
            AddNumbers4(10, c:30);
            Console.WriteLine();

            // Making method parameters optional by using OptionalAttribute
            AddNumbers5(10, 20);
            AddNumbers5(10, 20, new int[] { 30, 40, 50 });
            Console.WriteLine();

        }

        // Use parameter arrays
        public static void AddNumbers1(int firstNumber, int secondNumber, params object[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }

            Console.WriteLine("Total = " + result.ToString());
        }

        // Making method parameters optional using method overloading
        public static void AddNumbers2(int firstNumber, int secondNumber, int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = " + result);
        }

        public static void AddNumbers2(int firstNumber, int secondNumber)
        {
            AddNumbers2(firstNumber, secondNumber, null);
        }

        // Making method parameters optional by specifying parameter defaults
        public static void AddNumbers3(int firstNumber, int secondNumber, int[] restOfTheNumbers = null)
        {
            int result = firstNumber + secondNumber;

            // loop thru restOfTheNumbers only if it is not null
            // otherwise you will get a null reference exception
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }

        // Named Parameter
        public static void AddNumbers4(int a, int b = 200, int c = 300)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }

        // Making method parameters optional by using OptionalAttribute
        public static void AddNumbers5(int firstNumber, int secondNumber, [Optional] int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;

            // loop thru restOfTheNumbers only if it is not null
            // otherwise you will get a null reference exception
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = " + result.ToString());
        }

    }
}
