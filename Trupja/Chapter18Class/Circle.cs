using System;

namespace Chapter18Class
{
    // class is a blue print of a object
    // class can have the following members
    // access modifiers define the scope of the class and its members
    public class Circle
    {
        // fields
        private const double PI = Math.PI;
        // property
        public double Radius { get; set; }
        // constructors
        public Circle()
        {
            System.Console.WriteLine("Circle Object Created");
        }
        // constructor - overloading
        public Circle(double radius)
        {
            Radius = radius;
        }
        // methods
        public double GetArea() => PI * Math.Pow(Radius,2);
        public double GetPerimeter() => 2*PI*Radius;
        // events
    }
}