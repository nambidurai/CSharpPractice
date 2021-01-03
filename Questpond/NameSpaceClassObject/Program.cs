using System;
// import the namespace to use the classes and its method
// otherwise we may use like namespacename.classname.classmembername
using MathNameSpace;

namespace NameSpaceClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a instance or objects of a class using new keyword
            MathNameSpace.MathBase x1 = new MathBase();
            Console.WriteLine("About: " + x1.AboutVariable);
            x1.AboutMethod();
            Console.WriteLine("add: " + x1.add(10,10));
            Console.WriteLine("subtract: " + x1.subtract(10, 10));

            // multiple instances or objects of the same class
            MathBase x2 = new MathBase();
            Console.WriteLine("About: " + x2.AboutVariable);
            x2.AboutMethod();
            Console.WriteLine("add: " + x2.add(20, 20));
            Console.WriteLine("subtract: " + x2.subtract(20, 20));
         
            MathAdvance y = new MathAdvance();
            Console.WriteLine("About: " + y.AboutVariable);
            y.AboutMethod();
            int ylocal;
            ylocal = y.multiply(10, 10);
            Console.WriteLine("add: " + ylocal);
            Console.WriteLine("subtract: " + y.divide(10, 10));

            System.Console.WriteLine("system is root namespace of all namespaces");
            object z = y;
            System.Console.WriteLine("Object is root class of all classes");
        }
    }
}

// namespace in used to group related classes
namespace MathNameSpace
{
    // class is a template
    class MathBase
    {
        public string AboutVariable = "Base math class in math namespace";
        public void AboutMethod()
        {
            Console.WriteLine("Base math class in math namespace");
        }
        public int add (int number1, int number2)
        {
            return number1 + number2;
        }
        public int subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
    class MathAdvance
    {
        public string AboutVariable = "Advanced math class in math namespace";
        public void AboutMethod()
        {
            Console.WriteLine("Advanced math class in math namespace");
        }
        public int multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}