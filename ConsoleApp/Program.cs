using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program Structure
            Console.WriteLine("Hello World!");
            //Argument was passed from the command line
            if (args.Length == 1)
                Console.WriteLine("First command line argument is " + args[0]);
    
            //Comments
            // Single line comments
            /* Multiple
            line comments */

            // Console I/O;'
            Write("What's your name? ");
            string name = Console.ReadLine();
            Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            WriteLine("{0} is {1} years old.", name, age);
            // or
            WriteLine(name + " is " + age + " years old.");
            int c = Console.Read();  // Read single char
            WriteLine(c);    // Prints 65 if user enters "A"
        }
    }
}
