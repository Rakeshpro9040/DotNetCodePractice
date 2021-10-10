using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public interface IAbstractVsInterface
    {
        public void Print()
        {
            Console.WriteLine("Interface");
        }
    }

    class AbstractVsInterface : IAbstractVsInterface
    {
        public void Print()
        {
            Console.WriteLine("Interface - Derived");
        }

        public void DummyMethod()
        {
            IAbstractVsInterface C = new AbstractVsInterface();
            C.Print();
        }
    }
}


