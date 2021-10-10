using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ObjectClassMethodsToStringWithoutOverride
    {
        public static void ObjectClassMethodsToStringWithoutOverrideMain()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Rakesh";
            C1.LastName = "Panigrahi";

            Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));
        }

        public class Customer
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
        }
    }

    class ObjectClassMethodsToStringWithOverride
    {
        public static void ObjectClassMethodsToStringWithOverrideMain()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Rakesh";
            C1.LastName = "Panigrahi";

            Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));
        }

        public class Customer
        {
            public String FirstName {  get; set; }
            public String LastName {  get; set; }

            public override string ToString()
            {
                //return base.ToString();
                return FirstName + " " + LastName;
            }
        }
    }

    class ObjectClassMethodsToStringDiff
    {
        public static void ObjectClassMethodsToStringDiffMain()
        {
            Customer C1 = null;

            // The below call will throw NULL Reference exception
            //Console.WriteLine(C1.ToString());

            // Below code will return Empty String
            Console.WriteLine(Convert.ToString(C1));
        }

        public class Customer
        {
            public string Name { get; set; }
        }
    }

    // This contains Four Use cases
    class ObjectClassMethodsEqualsWithoutOverride
    {
        public static void ObjectClassMethodsEqualsCompSimpleTypeOneMain()
        {
            int i = 10;
            int j = 10;

            // Both will retun True due to simple Types - int
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));
        }

        public static void ObjectClassMethodsEqualsCompSimpleTypeTwoMain()
        {
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;

            // Both will retun True due to simple Types - enum - underlying int
            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));
        }

        public static void ObjectClassMethodsEqualsComplexTypeOneMain()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Customer C2 = C1;

            // Complex Type but due to Reference Equality both will return True
            // if the type is a reference type,
            // then by default "==" operator checks for reference equality and
            // .Equals() method checks for value equality
            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }

        public static void ObjectClassMethodsEqualsComplexTypeTwoMain()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Customer C2 = new Customer();
            C2.FirstName = "Simon";
            C2.LastName = "Tan";

            // Due to diffent objects - Object/Value InEquality both will return false
            /*
            == operator returns False. 
            This makes sense because C1 and C2 are referring to different objects. 
            However, .Equals() method returns flase, 
            inspite of the values across C1 and C2 being the same. 
            Hence, it makes sense to override, 
            the Equals() method to return true when the values across the objects are same.
            */
            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }

        public enum Direction
        {
            East = 1,
            West = 2,
            North = 3,
            South = 4
        }

        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }

    class ObjectClassMethodsEqualsWithOverride
    {
        // Here we are tryign to fix the issue occured by ObjectClassMethodsEqualsComplexTypeTwoMain
        public static void ObjectClassMethodsEqualsWithOverrideMain()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            Customer C2 = new Customer();
            C2.FirstName = "Simon";
            C2.LastName = "Tan";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }

        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Override Equals() method
            public override bool Equals(object obj)
            {
                // If the passed in object is null
                if (obj == null)
                {
                    return false;
                }

                // Check if passing object is Customer Object or not
                if (!(obj is Customer))
                {
                    return false;
                }

                // if aboev two conditions satisfies, then return result
                return (this.FirstName == ((Customer)obj).FirstName)
                    && (this.LastName == ((Customer)obj).LastName);
            }


            // Override GetHashCode() method to avoid warning
            public override int GetHashCode()
            {
                return FirstName.GetHashCode() ^ LastName.GetHashCode();
            }
        }
    }

}