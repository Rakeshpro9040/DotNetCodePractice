using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class PredicateDelegate
    {
        public PredicateDelegate()
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
