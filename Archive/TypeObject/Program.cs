using System;

namespace TypeObject
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