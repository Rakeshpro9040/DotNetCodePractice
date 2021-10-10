using System.Net;
using System.IO;
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    // Base Class
    // Ideal case every class used to be encapsulated in a separate cs file
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }

    // Interfaces
    // IBook provides all kind of Absttraction for a Book Class
    public interface IBook
    {
        void AddGrade(double grade);
        Stastics GetStatistics();
        string Name {get;}
        event GradeAddedDelegate GardeAdded;
    }

    // Abstract Class
    public abstract class Book : NamedObject, IBook
    // Book is a NamedObject
    {
        protected Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GardeAdded;

        public abstract void AddGrade(double grade);

        public abstract Stastics GetStatistics();

    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GardeAdded;

        public override void AddGrade(double grade)
        {
            using(var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if(GardeAdded != null)
                {
                    GardeAdded(this, new EventArgs());
                }
            }
            // using - C# compiler will generate try finally block, at the it will call Dispose the code

            // writer.Close(); 
            // But while exception this will cuase issue as file will remain open
            
            // writer.Dispose();
            // This will free up memory, in this case teh file handler
        }

        public override Stastics GetStatistics()
        {
            var result = new Stastics();

            using(var reader = File.OpenText($"{Name}.txt"))
            {
               var line = reader.ReadLine();
               while(line != null)
               {
                   var number = double.Parse(line);
                   result.Add(number);
                   line = reader.ReadLine();
               }
            }

            return result;
        }
    }

    // Derived Class
    // Challenge - Create a New class to store the Book in a file system/ Disk instead of memory
    public class InMemoryBook : Book
    {
        // Declare all Private objects
        public List<double> grades; 
        // Property - Must Initialize inside Constructor
        
        
        // Declare all Public objects
        public const string CATEGORY = "Science";
        
        // Commenting as already Inherited from Base Class
        /*
        public string Name
        {
            get; 
            set;
        }
        */

        // Constructor
        // This will force to pass name parameter when an object will be instantiated of this class
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name; // Name - Field, name - Parameter
        }

        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade) // Method
        {
            if(grade <= 100 && grade >= 0)
            {
                this.grades.Add(grade); // Storing piece of state into our object
                if(GardeAdded != null)
                {
                    GardeAdded(this, new EventArgs());
                    // EventArgs - we can add more functionality like what is teh garde
                    // Need knowledge of Inheritence
                }
            }
            else
            {
                // Console.WriteLine("Inavlid value");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
            // Challenge - Write a Unit Test to check if grade 105 or -1 is allowed or now
        }

        public override event GradeAddedDelegate GardeAdded;

        public override Stastics GetStatistics()
        {
            var result = new Stastics();

         
            foreach (var grade in grades)
            {
                result.Add(grade);    
            } 

            return result;
            
            /*
            for(var index = 0; index < grades.Count; index += 1)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }
            */
        }

    }
}