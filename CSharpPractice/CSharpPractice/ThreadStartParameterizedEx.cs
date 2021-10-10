using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpPractice
{
    class ThreadStartParameterizedEx
    {
        internal static void ParameterizedThreadStartExMain()
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            Thread T1 = new Thread(new ParameterizedThreadStart(Number.PrintNumbers));
            // Or can be written as below - he compiler implicitly converts to ParameterizedThreadStart
            // Thread T1 = new Thread(Number.PrintNumbers);
            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            T1.Start(target);
        }

        class Number
        {
            public static void PrintNumbers(object target)
            {
                int number = 0;

                // Type cast to String
                if (int.TryParse(target.ToString(), out number))
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
