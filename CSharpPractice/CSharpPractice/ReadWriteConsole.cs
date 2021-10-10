using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ReadWriteConsole
    {
        public ReadWriteConsole()
        {
            Console.WriteLine("What is your Name: ");
            var name = Console.ReadLine();

            // String Concatenation (Old)
            Console.WriteLine("My Name is : " + name);

            // PlaceHolder (Old)
            Console.WriteLine("My Name is : {0}", name);

            // String Interpolation/New (Recommended)
            Console.WriteLine($"My Name is : {name}");
        }
    }
}
