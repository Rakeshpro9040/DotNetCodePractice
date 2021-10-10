using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ForLoop
    {
        public ForLoop()
        {
            int[] Number = new int[5];

            Number[0] = 101;
            Number[1] = 102;
            Number[2] = 103;
            Number[3] = 104;
            Number[4] = 105;

            Console.WriteLine($"Array length: {Number.Length}");
            Console.WriteLine($"for loop");

            for (int i = 0; i < Number.Length; i++)
            {
                if (i == 4)
                    break;
                else if (i == 2)
                    continue;
                else
                    Console.WriteLine(Number[i]);
            }

            Console.WriteLine($"\nforeach loop");

            foreach (var num in Number)
            {
                Console.WriteLine(num);
            }

            // Print all odd number between 0 to 20
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.Write(i + " ");
            }
        }
    }
}
