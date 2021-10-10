using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class StringBuilderEx
    {
        public static void StringBuilderWithoutOneMain()
        {
            string userString = "C#";
            userString += " Video";
            userString += " Tutorial";
            userString += " for";
            userString += " beginners";
            Console.WriteLine(userString);
        }

        public static void StringBuilderWithoutTwoMain()
        {
            string strNumbers = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                strNumbers += i.ToString() + " ";
            }
            Console.WriteLine(strNumbers);
        }

        public static void StringBuilderMain()
        {
            StringBuilder userStringBuilder = new StringBuilder("C#");
            userStringBuilder.Append(" Video");
            userStringBuilder.Append(" Tutorial");
            userStringBuilder.Append(" for");
            userStringBuilder.Append(" beginners");
            Console.WriteLine(userStringBuilder.ToString());
        }
    }
}
