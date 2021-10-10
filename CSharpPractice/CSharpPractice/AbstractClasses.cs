using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public abstract class AbstractClasses
    {
        // int id; // Field can be used in Abstract clas,s not in Interface

        public void Print()
        {
            Console.WriteLine("Parent");
        }
        public virtual void PrintVirtual()
        {
            Console.WriteLine("Parent - Virtual");
        }

        public abstract void PrintAbstract();
    }

    public class ChildClass : AbstractClasses
    {
        /*public void Print()
        {
            Console.WriteLine("Child");
        }*/

        public override void PrintVirtual()
        {
            Console.WriteLine("Child - Virtual");
        }
        public override void PrintAbstract()
        {
            Console.WriteLine("Child - Abstract");
        }

        public void DummyMethod()
        {
            // A Parent class Ref variable can point to a Child/drived class object
            AbstractClasses C = new ChildClass();
            // ChildClass C = new ChildClass();
            C.Print();
            C.PrintVirtual();
            C.PrintAbstract();
        }
    }
}
