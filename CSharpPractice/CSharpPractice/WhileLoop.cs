using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class WhileLoop
    {
        public WhileLoop()
        {
            Console.WriteLine("Please enter your target:");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start += 2;
            }
            Console.WriteLine("\n");
        }
    }
}
