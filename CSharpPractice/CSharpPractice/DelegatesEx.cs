using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class DelegatesEx
    {
        // Delegate Declaration. 
        // Delegate is a type safe function pointer
        public delegate void HelloFunctionDelegate(string Message);

        public DelegatesEx()
        {
            // Create the instance of the delegate and pass in the function
            // name as the parameter to the constructor. The passed in
            // function signature must match the signature of the delegate
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);

            // Invoke the delegate, which will invoke the method
            del("Hello from Delegate");
        }

        public static void Hello(string strMessge)
        {
            Console.WriteLine(strMessge);
        }
    }
}
