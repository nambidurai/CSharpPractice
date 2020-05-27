using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {    
            /* dotnet --version
            on linux ./executable or dotnet executable.dll
            dotnet /usr/share/dotnet/sdk/3.1.300/Roslyn/bincore/csc.dll -langversion:? */

            // single line comment
            /* This is a
                multi-line comment.*/
            
            // a semicolon indicated end of a statement;
            // statements, blocks, types(class, struct, enum, interface or delegate), fields, variables and methods
            /* Naming Conventions - camelCase - local variable and private variables
                                    PascalCase / TitleCase - all the others */

            Console.WriteLine("Hello World!");
            DateTime today = DateTime.Today;
            //press F12 to choose Go To Definition
            float temperature = 23.5F;
            // string concatenation
            Console.WriteLine("Temperature on " + today + "is " + temperature);
            Console.WriteLine("Temperature on {0:D} is {1} deg.C",today, temperature);
            // Interpolated string
            Console.WriteLine($"Temperature on {today:D} is {temperature} deg.C");
            Console.WriteLine($"The name of the variable is {nameof (today)} ans its value is {today}");
            // literal values - fixed values
			
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