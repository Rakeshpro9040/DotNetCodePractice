using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpPractice
{
    class ThreadJoinIsAlive
    {
        internal static void ThreadJoinIsAliveMain()
        {
            {
                Console.WriteLine("Main Started");
                Thread T1 = new Thread(Thread1Function);
                T1.Start();

                Thread T2 = new Thread(Thread2Function);
                T2.Start();

                // Simple Join() call
                // Mein/UI Thread will wait for T1 to complete to proceed further
                // If you want to see the IsAlive in action
                // comment the T1.Join() line & un-comment the overload Join() method and for/while block

                // T1.Join();
                Console.WriteLine("Thread1Function completed");

                // Overloaded Join() method
                if (T1.Join(1000))
                {
                    Console.WriteLine("Thread1Function completed");
                }
                else
                {
                    Console.WriteLine("Thread1Function has not completed in 1 second");
                }


                // Mein/UI Thread will wait for T2 to complete to proceed further
                T2.Join();
                Console.WriteLine("Thread2Function completed");


                // Use either one of these loops to test IsAlive functionality

                //for (int i = 1; i <= 10; i++)
                //{
                //    if (T1.IsAlive)
                //    {
                //        Console.WriteLine("Thread1Function is still doing it's work");
                //        Thread.Sleep(500);
                //    }
                //    else
                //    {
                //        Console.WriteLine("Thread1Function Completed");
                //        break;
                //    }
                //}

                while (T1.IsAlive)
                {
                    IsThread1Running(T1);
                    Thread.Sleep(1000);
                }
                IsThread1Running(T1);

                Console.WriteLine("Main Completed");
            }
        }

        private static void IsThread1Running(Thread T1)
        {
            var result = T1.IsAlive ? "Thread1Function is still executing" : "Thread1Function completed";
            Console.WriteLine(result);
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            // 10 sec delay
            Thread.Sleep(10000);
            Console.WriteLine("Thread1Function is about to return");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
            // 3 sec delay
            Thread.Sleep(3000);
            Console.WriteLine("Thread2Function is about to return");
        }
    }
}
