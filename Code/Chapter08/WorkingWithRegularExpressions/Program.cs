using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace WorkingWithRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: ");
            string input = ReadLine();

            var agechecker = new Regex(@"^\d+$");
            if (agechecker.IsMatch(input))
                WriteLine("Thank you");
            else
                WriteLine("This is not a valid age");
            
        }
    }
}
