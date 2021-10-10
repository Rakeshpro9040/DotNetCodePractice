using System;
using System.Collections.Generic;
using System.Text;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
using PATC = ProjectA.TeamC;
using PATD = ProjectA.TeamD;

namespace CSharpPractice
{
    class Namespaces
    {
        public static void NamespacesMain()
        {
            // Access from same Assebmly
            // Using Full Qualified Name
            ProjectA.TeamA.ClassA.Print();
            ProjectA.TeamB.ClassA.Print();

            // Using Namespace Alias Directive - 
            PATA.ClassA.Print();
            PATB.ClassA.Print();

            // Access from different Assebmly
            // Added Refernce in .csproj file
            PATC.ClassA.Print();
            PATD.ClassA.Print();
        }

    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }

    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }

    }
}
