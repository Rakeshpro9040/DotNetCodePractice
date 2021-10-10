using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Interfaces
    {

        public static void InterfacesMain()
        {
            Customer C1 = new Customer();
            C1.Print1(100);
            C1.Print2(200);
            C1.Print3(300);
            Console.WriteLine("\n");

            ICustomer1 IC1 = new Customer();
            ICustomer2 IC2 = new Customer();
            IC1.Print1(); // Invoke the non-default one
            IC1.Print1(1000); // Invoke teh default one
            Console.WriteLine("\n");

            // Explicit Interface Implemenation
            ((ICustomer1)C1).Print(500);
            ((ICustomer2)C1).Print(500);
            IC1.Print(500);
            IC2.Print(500);
        }

        interface ICustomer1
        {
            // int id; // Field can be used in Abstract clas,s not in Interface
            public void Print(int j);

            public void Print1()
            {
                int i = 1;
                Console.WriteLine($"I am a base Interface, i = {i}");
            }

            public void Print1(int j);
        }

        interface ICustomer2
        {
            public void Print(int j);
            public void Print2(int j);
        }

        interface ICustomer3 : ICustomer2
        {
            public void Print3(int j);
        }

        class Customer : ICustomer1, ICustomer3
        {
            void ICustomer1.Print(int j)
            {
                Console.WriteLine($"I am being Inherited from ICustomer1, j = {j}");
            }

            void ICustomer2.Print(int j)
            {
                Console.WriteLine($"I am being Inherited from ICustomer2, j = {j}");
            }

            public void Print1(int j)
            {
                Console.WriteLine($"I am being Inherited from ICustomer1, j = {j}");
            }

            public void Print2(int j)
            {
                Console.WriteLine($"I am being Inherited from ICustomer2, j = {j}");
            }

            public void Print3(int j)
            {
                Console.WriteLine($"I am being Inherited from ICustomer3, j = {j}");
            }
        }
    }
}


