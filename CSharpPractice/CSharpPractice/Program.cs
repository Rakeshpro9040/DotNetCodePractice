using System;

namespace CSharpPractice
{
    /// <summary>
    /// This is the main class for the Current Project
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // var InvokeClass = new MulticastDelegates();

            FuncDelegate.FuncDelegateMain();

            // Console.WriteLine($"\n\nInvoked Constructor: {InvokeClass.GetType().Name}");
        }
    }

}