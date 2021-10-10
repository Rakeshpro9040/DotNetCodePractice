using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Properties
    {
        public static void PropertieseMain()
        {
            Student C1 = new Student();
            C1.ID = 10;
            C1.Name = "Rakesh";
            // C1.PassMark = 40;

            Console.WriteLine($"ID = {C1.ID}, Name = {C1.Name}, PassMark = {C1.PassMark}");
        }
    }

    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;

        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id can't be negative");
                }
                this._id = value;
            }
        }

        public string Name
        {
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }

            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._Name = value;
            }
        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        // Auto Implemented Property
        public int City { get; set; }
    }
}
