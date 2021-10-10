using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class DoWhileLoop
    {
        /// <summary>
        /// This Constructor will take target as user input and print all even values
        /// starting from 0.
        /// </summary>
        public DoWhileLoop()
        {
            Console.WriteLine("Please enter your target:");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            String UserResponse = String.Empty;

            do
            {
                Console.Write(Start + " ");
                Start += 2;

                if (Start > UserTarget)
                {
                    Console.WriteLine("\n");
                 
                    while (true)
                    {
                        Console.WriteLine("Do you want to Continue: Yes/No");
                        UserResponse = Console.ReadLine();

                        if (UserResponse.ToUpper() == "YES")
                        {
                            Start = 0;
                            Console.WriteLine("Please enter your target:");
                            UserTarget = int.Parse(Console.ReadLine());
                            break;
                        }
                        else if (UserResponse.ToUpper() == "NO")
                        {
                            Console.WriteLine("Thanks for playing :)");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!!!");
                        }
                    }                    
                }

            } while (Start <= UserTarget);

            Console.WriteLine("\n");
        }
    }
}
