using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class GenericsWithout
    {
        public static void GenericsWithoutMain()
        {
            bool Equal = Calculator.AreEqual(1, 2);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public class Calculator
        {
            public static bool AreEqual(int value1, int value2)
            {
                return value1 == value2;
            }
        }
    }

    class GenericsWithObject
    {
        public static void GenericsWithObjectMain()
        {
            bool Equal = Calculator.AreEqual("A", "B");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public class Calculator
        {
            public static bool AreEqual(object value1, object value2)
            {
                return value1 == value2;
            }
        }
    }

    class GenericsMethod
    {
        public static void GenericsMain()
        {
            bool Equal = Calculator.AreEqual<int>(2, 1);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public class Calculator
        {
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }
    }

    class GenericsClass
    {
        public static void GenericsClassMain()
        {
            bool Equal = Calculator<int>.AreEqual(2, 1);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public class Calculator<T>
        {
            public static bool AreEqual(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }
    }
}
