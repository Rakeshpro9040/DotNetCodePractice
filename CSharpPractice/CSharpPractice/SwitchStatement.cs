using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class SwitchStatement
    {
        public SwitchStatement()
        {
            int TotalCoffeCost = 0;
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine($"Your choice {UserChoice} is invalid");
                    break;
            }

            Console.WriteLine($"Total Bill: {TotalCoffeCost}");
        }
    }
}
