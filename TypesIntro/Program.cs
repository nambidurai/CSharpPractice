using System;

namespace TypesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
/* 
            Data Types

            Reference Data Types
            objects
            string
            arrays
            delegates

            // Value Date Types & Initializing
            bool correct = true;
            byte b = 0x2A;   // hex
            object person = null;
            string name1 = "Dwight";
            char grade = 'B';
            DateTime today = DateTime.Parse("12/31/2010 12:15:00 PM"); //not  a built-in in datatype
            decimal amount = 35.99m;
            float gpa = 2.9f;
            double pi = 3.14159265;   // or 3.14159265D
            long lTotal = 123456L;
            short sTotal = 123;
            int iTotal = 123;
            ushort usTotal = 123;
            uint uiTotal = 123;   // or 123U
            ulong ulTotal = 123;   // or 123UL

            value types
            sbyte
            structs
            enumerations



            //Nullable Types
            int? x = null;

            //Anonymous Types
            var stu = new {Name = "Sue", Gpa = 3.5};
            var stu2 = new {Name = "Bob", Gpa = 2.9};   // no Key equivalent
            //Implicitly Typed Local Variables
            var s = "Hello!";
            var nums = new int[] { 1, 2, 3 };
            var hero = new SuperHero() { Name = "Batman" };

            //Type Information
            int x;
            Console.WriteLine(x.GetType());              // System.Int32
            Console.WriteLine(typeof(int));               // System.Int32
            Console.WriteLine(x.GetType().Name);   // Int32

            Circle c = new Circle();
            isShape = c is Shape;   // true if c is a Shape

            isSame = Object.ReferenceEquals(o1, o2)   // true if o1 and o2 reference same object

            Type Conversion / Casting
            float d = 3.5f;
            i = Convert.ToInt32(d);     // Set to 4 (rounds)
            int i = (int)d;     // set to 3 (truncates decimal)


            Shape s = new Shape();
            Circle c = s as Circle;   // Returns null if type cast fails
            c = (Circle)s;   // Throws InvalidCastException if type cast fails
*/
        }
    }
}
