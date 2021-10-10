using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class StringTypes
    {
        public StringTypes()
        {
            // Escape Sequence
            string Name = "\"Line1\"\nLine2\nLine3\\";
            Console.WriteLine(Name);

            // Verbatim Literal
            string Path = @"C:\abc\xyz";
            Console.WriteLine(Path);
        }
    }
}
