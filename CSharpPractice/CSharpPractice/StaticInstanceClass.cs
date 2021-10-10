using System;
using System.Collections.Generic;
using System.Text;

class Circle
{
    public static float _PI = 3.141F;
    int _Radius;

    // Static Constructor
    static Circle()
    {
        Console.WriteLine("Satic Constrcutor Called");
        Circle._PI = 3.141F;
    }

    // Instance Constructor
    public Circle(int Radius)
    {
        Console.WriteLine("Instance Constrcutor Called");
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        return _PI * this._Radius * this._Radius;
    }
}

namespace CSharpPractice
{
    class StaticInstanceClass
    {
        public static void StaticInstanceClassMain()
        {
            Console.WriteLine($"PI = {Circle._PI}");

            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine($"Area of Circle1 = {Area1}");

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine($"Area of Circle2 = {Area2}");
        }
    }
}
