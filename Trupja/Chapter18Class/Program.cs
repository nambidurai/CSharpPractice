using System;

namespace Chapter18Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance of a class is object
            // class has to be instanchiated to use its public members
            Circle c1 = new Circle();
            c1.Radius = 5;
            Console.WriteLine("1st circle area = " + c1.GetArea());
            Console.WriteLine("1st circle perimeter = " + c1.GetPerimeter());
            // class can be instanchiated multiple times
            Circle c2 = new Circle(5);
            Console.WriteLine("2nd circle area = " + c2.GetArea());
            Console.WriteLine("2nd circle perimeter = " + c2.GetPerimeter());
        }
    }
}