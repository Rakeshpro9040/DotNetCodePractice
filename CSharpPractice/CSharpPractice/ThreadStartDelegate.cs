using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpPractice
{
    class ThreadStartDelegate
    {
        public static void ThreadStartDelegateMain()
        {
            string threadName = null;

            // passign the function name directly (ThreadStart delegate implicitly)
            threadName = "T1";
            Thread T1 = new Thread(Number.PrintNumbers);
            // Number.PrintNumbers(threadName);
            Console.WriteLine($"Thread-1 Started");
            T1.Start();
            Console.WriteLine($"Thread-1 Completed");

            // using ThreadStart delegate (passing ThreadStart delegate explicitly)
            threadName = "T2";
            Thread T2 = new Thread(new ThreadStart(Number.PrintNumbers));
            Console.WriteLine($"Thread-2 Started");
            T2.Start();
            Console.WriteLine($"Thread-2 Completed");

            // using delegate keyword
            threadName = "T3";
            Thread T3 = new Thread(delegate () { Number.PrintNumbers(threadName); });
            Console.WriteLine($"Thread-3 Started");
            T3.Start();
            Console.WriteLine($"Thread-3 Completed");

            // using Lambda expression
            threadName = "T4";
            Thread T4 = new Thread(() => Number.PrintNumbers(threadName));
            Console.WriteLine($"Thread-4 Started");
            T4.Start();
            Console.WriteLine($"Thread-4 Completed");

        }

        class Number
        {
            public static void PrintNumbers()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }

            public static void PrintNumbers(string threadName)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"  {threadName} : {i}");
                }
            }
        }
    }
}
