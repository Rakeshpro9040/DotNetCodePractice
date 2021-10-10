using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ListSort
    {
        public static void LisSortSimpleTypeMain()
        {
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Sort() will sort data in ascending order 
            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Use Reverse() method to retrieve data in descending order
            numbers.Reverse();

            Console.WriteLine("Numbers in descending order");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine("Alphabets before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();

            Console.WriteLine("Alpabets in descending order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            CustomerSimpleType CustomerSimpleType1 = new CustomerSimpleType()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            CustomerSimpleType CustomerSimpleType2 = new CustomerSimpleType()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            CustomerSimpleType CustomerSimpleType3 = new CustomerSimpleType()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };

            List<CustomerSimpleType> listCustomerSimpleTypes = new List<CustomerSimpleType>();
            listCustomerSimpleTypes.Add(CustomerSimpleType1);
            listCustomerSimpleTypes.Add(CustomerSimpleType2);
            listCustomerSimpleTypes.Add(CustomerSimpleType3);

            Console.WriteLine("CustomerSimpleTypes before sorting");
            foreach (CustomerSimpleType CustomerSimpleType in listCustomerSimpleTypes)
            {
                Console.WriteLine(CustomerSimpleType.Name);
            }

            // Invoking Sort() on list of complex types will 
            // throw invalid operation exception, unless 
            // IComparable interface is implemented
            listCustomerSimpleTypes.Sort();

            Console.WriteLine("CustomerSimpleTypes after sorting");
            foreach (CustomerSimpleType CustomerSimpleType in listCustomerSimpleTypes)
            {
                Console.WriteLine(CustomerSimpleType.Name);
            }
        }

        public static void LisSortComplexType1Main()
        {
            CustomerComplexType CustomerComplexType1 = new CustomerComplexType()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            CustomerComplexType CustomerComplexType2 = new CustomerComplexType()
            {
                ID = 102,
                Name = "John",
                Salary = 7000
            };

            CustomerComplexType CustomerComplexType3 = new CustomerComplexType()
            {
                ID = 103,
                Name = "Ken",
                Salary = 5500
            };

            List<CustomerComplexType> listCutomers = new List<CustomerComplexType>();
            listCutomers.Add(CustomerComplexType1);
            listCutomers.Add(CustomerComplexType2);
            listCutomers.Add(CustomerComplexType3);

            Console.WriteLine("CustomerComplexTypes before sorting");
            foreach (CustomerComplexType CustomerComplexType in listCutomers)
            {
                Console.WriteLine(CustomerComplexType.Name + " - " + CustomerComplexType.Salary);
            }

            // Sort() method should sort CustomerComplexTypes by salary
            listCutomers.Sort();

            Console.WriteLine("CustomerComplexTypes after sorting");
            foreach (CustomerComplexType CustomerComplexType in listCutomers)
            {
                Console.WriteLine(CustomerComplexType.Name + " - " + CustomerComplexType.Salary);
            }

            // To sort CustomerComplexTypes by name instead of salary
            // If you prefer not to use the Sort functionality provided by the Customer class, 
            // then you can provide your own by implementing IComparer interface. 
            // For example, if I want the customers to sorted by name instead of salary.
            SortByName sortByName = new SortByName();
            listCutomers.Sort(sortByName);

            Console.WriteLine("CustomerComplexTypes after sorting by Name");
            foreach (CustomerComplexType CustomerComplexType in listCutomers)
            {
                Console.WriteLine(CustomerComplexType.Name + " - " + CustomerComplexType.Salary);
            }
        }

        public static void LisSortComplexType2Main()
        {
            CustomerSimpleType CustomerSimpleType1 = new CustomerSimpleType()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };

            CustomerSimpleType CustomerSimpleType2 = new CustomerSimpleType()
            {
                ID = 103,
                Name = "John",
                Salary = 7000
            };

            CustomerSimpleType CustomerSimpleType3 = new CustomerSimpleType()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<CustomerSimpleType> listCutomers = new List<CustomerSimpleType>();
            listCutomers.Add(CustomerSimpleType1);
            listCutomers.Add(CustomerSimpleType2);
            listCutomers.Add(CustomerSimpleType3);

            Console.WriteLine("CustomerSimpleTypes before sorting");
            foreach (CustomerSimpleType CustomerSimpleType in listCutomers)
            {
                Console.WriteLine(CustomerSimpleType.ID);
            }

            // Approach 1
            // Step 2: Create an instance of Comparison delegate
            //Comparison<CustomerSimpleType> CustomerSimpleTypeComparer = 
            //    new Comparison<CustomerSimpleType>(CompareCustomerSimpleTypes);

            // Step 3: Pass the delegate instance to the Sort method
            //listCutomers.Sort(CustomerSimpleTypeComparer);

            // Approach 2: Using delegate keyword
            //listCutomers.Sort(delegate(CustomerSimpleType c1, CustomerSimpleType c2)
            //{
            //    return (c1.ID.CompareTo(c2.ID));
            //});

            // Aaproach 3: Using lambda expression
            listCutomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("CustomerSimpleTypes after sorting by ID");
            foreach (CustomerSimpleType CustomerSimpleType in listCutomers)
            {
                Console.WriteLine(CustomerSimpleType.ID);
            }

            listCutomers.Reverse();
            Console.WriteLine("CustomerSimpleTypes in descending order of ID");
            foreach (CustomerSimpleType CustomerSimpleType in listCutomers)
            {
                Console.WriteLine(CustomerSimpleType.ID);
            }
        }

        public class SortByName : IComparer<CustomerComplexType>
        {
            public int Compare(CustomerComplexType x, CustomerComplexType y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        // Approach 1 - Step 1
        // Method that contains the logic to compare customers
        private static int CompareCustomers(CustomerSimpleType c1, CustomerSimpleType c2)
        {
            return c1.ID.CompareTo(c2.ID);
        }

        public class CustomerSimpleType
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

        }

        public class CustomerComplexType : IComparable<CustomerComplexType>
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public int CompareTo(CustomerComplexType obj)
            {
                //if (this.Salary > obj.Salary)
                //    return 1;
                //else if (this.Salary < obj.Salary)
                //    return -1;
                //else
                //    return 0;

                // OR, Alternatively you can also invoke CompareTo() method. 
                return this.Salary.CompareTo(obj.Salary);
            }
        }
    }
}
