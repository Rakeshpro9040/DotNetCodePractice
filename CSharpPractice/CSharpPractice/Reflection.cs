using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpPractice
{
    class Reflection
    {
        public static void ReflectionMain()
        {

            /* Error: NULLReference - DEBUG Code
            // Test Customer class Instance
            CSharpPractice.Reflection.Customer C1 = new CSharpPractice.Reflection.Customer();
            C1.Id = 1;
            C1.Name = "Rakesh";
            C1.PrintID();
            C1.PrintName();

            // Intead of accessing Nested classes using . use +
            Type T = Type.GetType("CSharpPractice.Reflection+Customer");
            Console.WriteLine("Full Name = {0}", T.FullName);
            */


            // Steps to get Fully Qalified Name for a Class
            String typeName1 = typeof(CSharpPractice.Reflection.Customer).FullName;
            String typeName2 = typeof(Customer).FullName;
            Console.WriteLine($"Fully Qualified Name way1: {typeName1}");
            Console.WriteLine($"Fully Qualified Name way2: {typeName2}");
            Console.WriteLine();

            // Get the Type Using GetType() static method
            Type T = Type.GetType("CSharpPractice.Reflection+Customer");

            // Print the Type details
            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Class Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine();

            //  Print the Properties
            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                // Print the property type and the name of the property
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();

            // Print the list of Methods
            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                // Print the Return type and the name of the method
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();

            //  Print the Constructors
            Console.WriteLine("Constructors in Customer Class");
            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                // WIthout ToString() it will not give useful info
                Console.WriteLine(constructor.ToString());
            }
           
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Customer(int ID, string Name)
            {
                this.Id = ID;
                this.Name = Name;
            }

            public Customer()
            {
                this.Id = -1;
                this.Name = string.Empty;
            }

            public void PrintID()
            {
                Console.WriteLine("ID = {0}", this.Id);
            }

            public void PrintName()
            {
                Console.WriteLine("Name = {0}", this.Name);
            }
        }
    }
}
