using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class MulticastDelegates
    {
        public delegate void SampleDelegate();

        public MulticastDelegates()
        {
            // In this example del is a multicast delegate. You use += operator 
            // to chain delegates together and -= operator to remove.
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodTwo;

            // Here we have Invoked SampleMethodOne First, then SampleMethodTwo
            // then SampleMethodThree, and later removed SampleMethodTwo

            // Invokation list is First to Last in Order
            del();
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    }
}
