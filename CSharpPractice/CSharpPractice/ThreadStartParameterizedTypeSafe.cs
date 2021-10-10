using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpPractice
{
    class ThreadStartParameterizedTypeSafe
    {
        internal static void ThreadStartParameterizedTypeSafeMain()
        {
            // Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the Number class, passing it
            // the target number that was read from the console
            Number number = new Number(target);
            // Specify the Thread function
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            // Alternatively we can just use Thread class constructor as shown below
            // Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();


            // Or We can pass the argument using delegate keyword/lambda expression
            ThreadStartParameterizedTypeSafe threadStartParameterizedTypeSafe= new ThreadStartParameterizedTypeSafe();
            Thread T2 = new Thread(delegate () { threadStartParameterizedTypeSafe.PrintNumbers(target); });
            T2.Start();
        }

        class Number
        {
            int _target;
            // When an instance is created, the target number needs to be specified
            public Number(int target)
            {
                // The targer number is then stored in the class private variable _target
                this._target = target;
            }

            // Function prints the numbers from 1 to the traget number that the user provided
            public void PrintNumbers()
            {
                for (int i = 1; i <= _target; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        protected void PrintNumbers(int target)
        {
            for (int i = 1; i <= target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
