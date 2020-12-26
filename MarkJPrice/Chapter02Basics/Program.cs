using System; // a semicolon indicates the end of a statement 

namespace Chapter02Basics
{
    class Program
    {
        static void Main(string[] args)
        {   // the start of block
            Console.WriteLine("Hello World!");
            // the end of a block
            // outputs a carriage return 
            Console.WriteLine();
            // outputs the greeting and a carriage return 
            Console.WriteLine("Hello Ahmed");
            // outputs a formatted number and date and a carriage return 
            Console.WriteLine(
                "Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);
            double heightInMeters = 1.88;
            System.Console.WriteLine($@"The variable {nameof(heightInMeters)} 
has the value {heightInMeters}");
        }
    }
}
