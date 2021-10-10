using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // var book = new InMemoryBook("Scott's Grade Book");
            var book = new DiskBook("Scott's Grade Book");

            // Subscribe or Unsuscribe from an Event
            book.GardeAdded += onGardeAdded;
            /*
            book.GardeAdded += onGardeAdded;
            book.GardeAdded -= onGardeAdded;
            // Here we are Subtarcting out a Call
            book.GardeAdded += onGardeAdded; 
            // onGardeAdded will be invoked 3 times
            */

            /*
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            */
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The average grade is: {stats.Average:N1}");
            Console.WriteLine($"The Letter grade is: {stats.Letter}");

            /*
            book.AddLetterGrade('B');
            Console.WriteLine($"AddLetterGrade-Test: {book.grades[3]}");
            */
        }

        // Polymorphism Implementaion - during Runtime the Book type will be defined
        // Interfaces
        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine(); // This will return a String

                if (input == "q") // Converting the char q to str q
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input); // Parsing the variable (Casting) from str to double
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // This block will always execute

                }
            }
        }

        static void onGardeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added"); 
        }
    }

}