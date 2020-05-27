/*  1. Object types can store any types of data
    2. Flexability comes at the cost of messier code (require explict cast and cannot have members) and poor performance
    3. Better alternative is generics
*/

using System;

namespace ObjectType
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // double
            object name = "Amir"; // string
                       
            Console.WriteLine($"{name} is {height} meters tall");

            // int length1 = name.Length // gives a complier error
            int length2 = ((string)name).Length; // tells the complier it is a string
            Console.WriteLine("# of characters in name is " + length2);
        }
    }
} 