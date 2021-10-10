
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace CSharpPractice
{
    // To Test run below exe file multiple times in cmd
    // "D:\C_Workspaces_Repositories\GitHub_Repositories\DotNetCodePractice\CSharpPractice\CSharpPractice\bin\Debug\netcoreapp3.1\CSharpPractice.exe"
    // CMD - CSharpPractice.exe
    // Powershell - ./CSharpPractice.exe

    class ThreadProtectingSharedResources
    {
        static int Total = 0;

        internal static void ThreadProtectingSharedResourcesWithoutThreadMain()
        {
            AddOneMillion();
            AddOneMillion();
            AddOneMillion();
            Console.WriteLine("Total = " + Total);
        }

        internal static void ThreadProtectingSharedResourcesWithThreadMain()
        {
            Thread thread1 = new Thread(AddOneMillion);
            Thread thread2 = new Thread(AddOneMillion);
            Thread thread3 = new Thread(AddOneMillion);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Total = " + Total);
        }

        internal static void ThreadProtectingSharedResourcesWithThreadInterlockedMain()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread thread1 = new Thread(AddOneMillionInterlocked);
            Thread thread2 = new Thread(AddOneMillionInterlocked);
            Thread thread3 = new Thread(AddOneMillionInterlocked);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Total = " + Total);

            stopwatch.Stop();
            // 1 millisecond consists of 10000 ticks
            // You can use the TimeSpan object to find ticks per second, ticks per millisecond etc
            Console.WriteLine($"TicksPerMillisecond: {TimeSpan.TicksPerMillisecond}");
            Console.WriteLine("Time Taken in Ticks = " + stopwatch.ElapsedTicks);

        }

        internal static void ThreadProtectingSharedResourcesWithThreadLockMain()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread thread1 = new Thread(AddOneMillionLock);
            Thread thread2 = new Thread(AddOneMillionLock);
            Thread thread3 = new Thread(AddOneMillionLock);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Total = " + Total);

            stopwatch.Stop();
            Console.WriteLine("Time Taken in Ticks = " + stopwatch.ElapsedTicks);
        }

        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                Total++;
            }
        }

        // Using Interlocked.Increment() method
        public static void AddOneMillionInterlocked()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                Interlocked.Increment(ref Total);
            }
        }

        // Using a lock
        static object _lock = new object();

        public static void AddOneMillionLock()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }
    }
}
