using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpPractice
{
    class EarltBindingUsingReflection
    {
        public static void EarltBindingUsingReflectionMain()
        {
            Customer C1 = new Customer();
            string fullName = C1.GetFullName("Rakesh", "Panigrahi");
            Console.WriteLine("Full Name = {0}", fullName);
        }

        public class Customer
        {
            public string GetFullName(string FirstName, string LastName)
            {
                return FirstName + " " + LastName;
            }
        }
    }

    class LateBindingUsingReflection
    {
        public static void LateBindingUsingReflectionMain()
        {
            // Load the current executing assembly as the Customer class is present in it.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            // Load the Customer class for which we want to create an instance dynamically
            String typeName = typeof(Customer).FullName;
            Type customerType = executingAssembly.GetType(typeName);
            
            // Create the instance of the customer type using Activator class 
            object customerInstance = Activator.CreateInstance(customerType);
            
            // Get the method information using the customerType and GetMethod()
            MethodInfo getFullName = customerType.GetMethod("GetFullName");
            
            // Create the parameter array and populate first and last names
            string[] methodParameters = new string[2];
            methodParameters[0] = "Rakesh"; //FirstName
            methodParameters[1] = "Panigrahi"; //LastName
            
            // Invoke the method passing in customerInstance and parameters array
            string fullName = (string)getFullName.Invoke(customerInstance, methodParameters);
            Console.WriteLine("Full Name = {0}", fullName);
        }
        public class Customer
        {
            public string GetFullName(string FirstName, string LastName)
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
