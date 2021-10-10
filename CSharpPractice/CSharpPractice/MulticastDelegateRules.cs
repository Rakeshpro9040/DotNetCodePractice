using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class MulticastDelegateRules
    {
        public delegate int SampleDelegate();
        public delegate void SampleDelegate2(out int Integer);

        public static void MulticastDelegateRulesMain()
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateReturnedValue = del();
            Console.WriteLine($"DelegateReturnedValue = {DelegateReturnedValue}");

            SampleDelegate2 del2 = new SampleDelegate2(SampleMethodThree);
            del2 += SampleMethodFour;

            int DelegateOutParamterValue = -1;
            del2(out DelegateOutParamterValue);
            Console.WriteLine($"DelegateOutParamterValue = {DelegateOutParamterValue}");

        }

        public static int SampleMethodOne()
        {
            return 1;
        }

        public static int SampleMethodTwo()
        {
            return 2;
        }

        public static void SampleMethodThree(out int Number)
        {
            Number = 1;
        }

        public static void SampleMethodFour(out int Number)
        {
            Number = 2;
        }
    }
}
