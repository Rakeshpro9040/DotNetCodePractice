using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{

    class MethodsParametersType
    {
        /// <summary>
        /// var InvokeClass = new Methods();
        /// InvokeClass.EvenNumbers(); // instance method
        /// Methods.EvenNumbersStatic(); // static method
        /// </summary>
        public MethodsParametersType()
        {
        }

        // Instance Method
        public void EvenNumbers()
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }

        // Static Method
        public static void EvenNumbersStatic()
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }

        // Parameterized Method
        public static void EvenNumbersParameter(int Target)
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }

        // Return Method
        public static int SumNumbersReturn(int FNum, int SNum)
        {
            return FNum + SNum;
        }

        // Method Parameters
        // Pass by value
        public static void SimpleMethod(int j)
        {
            j = 101;
        }

        // Pass by Reference
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }

        // Out Parameter
        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        // Parameter Arrays
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine($"There are {Numbers.Length} elements");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

        public static void MethodsMain()
        {
            // Pass by value
            int i = 0;
            SimpleMethod(i);
            Console.WriteLine($"Result - Pass by value: {i}");

            // Pass by Reference
            int k = 0;
            SimpleMethod(ref k);
            Console.WriteLine($"Result - Pass by Reference: {k}");

            // Out Parameter
            int Total;
            int Product;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine($"Total = {Total}, and Product = {Product}\n");

            // Parameter Arrays
            // Way-1 -- Create Array and pass
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            ParamsMethod(Numbers);

            // Way-2 -- Pass values by comma-separated as Arguments
            ParamsMethod(1, 2, 3, 4, 5);
        }
    }
}
