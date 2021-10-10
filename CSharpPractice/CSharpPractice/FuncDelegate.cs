using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPractice
{
    class FuncDelegate
    {
        public static void FuncDelegateMain()
        {
            List<Employee> listEmployees = new List<Employee>()
        {
            new Employee{ ID = 101, Name = "Mark"},
            new Employee{ ID = 102, Name = "John"},
            new Employee{ ID = 103, Name = "Mary"},
        };

            // Create a Func delegate - Accepts T, TResult
            // It can be overridden in 17 ways
            // Here "employee" is the Input/T parameter
            // "selector" is the Output/TResult parameter
            Func<Employee, string> selector = employee => "Name = " + employee.Name;
            string resultnamesFunc = selector(listEmployees[0]);
            Console.WriteLine($"Employee-1 Name: {resultnamesFunc}");

            // Pass the delegate to the Select() LINQ function
            // Here "names" is an IEnumerable object
            // "selector" is a delegate that
            IEnumerable<string> namesFunc = listEmployees.Select(selector);

            Console.WriteLine("namesFunc");
            foreach (string name in namesFunc)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // The above output can be achieved using
            // lambda expression as shown below
            IEnumerable<string> namesLambda = listEmployees.Select(employee => "Name = " + employee.Name);

            Console.WriteLine("namesLambda");
            foreach (string name in namesLambda)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //  Pass two or more input parameters to Func
            Console.WriteLine("sumOfTwoNumbersFunc");
            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();

            string result = funcDelegate(10, 20);
            Console.WriteLine(result);
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}