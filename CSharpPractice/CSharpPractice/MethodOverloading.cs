using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class MethodOverloading
    {
        public static void MethodOverloadingMain()
        {
            
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine($"Sum = {FN + SN}");
        }

        public static void Add(float FN, int SN)
        {
            Console.WriteLine($"Sum = {FN + SN}");
        }

        public static void Add(int FN, float SN)
        {
            Console.WriteLine($"Sum = {FN + SN}");
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine($"Sum = {FN + SN + TN}");
        }

        public static void Add(int FN, int SN, out int TN)
        {
            Console.WriteLine($"Sum = {FN + SN}");
            TN = FN + SN;
        }

        public static void Add(int FN, int SN, int TN, int FrN)
        {
            Console.WriteLine($"Sum = {FN + SN + TN + FrN}");
        }
    }
}
