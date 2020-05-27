/*
    Dynamic types
        Can store any type of data, unlike object types it dose not require explict cast and can have members
        Comes at the cost of performance
        Unlike var, resolved at runtime instead of compile time
        Dose not have intellisense support
        A method can have dynamic type parameters
        Throws an exception at runtime when method or property is not compatible
*/

using System;

namespace DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            // declared using dynamic keyword
            dynamic anotherName = "Amir";
            Console.WriteLine(anotherName.Length);
            anotherName = 10;
            // throws an exception at runtime when method or property is not compatible
            Console.WriteLine(anotherName.Length);
        }
    }
}