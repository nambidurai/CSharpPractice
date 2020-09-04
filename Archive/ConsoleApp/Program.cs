/*
    Console App
        Applications that run in console (commandline or terminal)
        Good starring point to learn the language
        
        dotnet --version
        To run on linux 
            ./executable
            dotnet executable.dll arg0 arg1 arg2 ...
            dotnet run arg0 arg1 arg2 ...
        To find the c# version
            dotnet /usr/share/dotnet/sdk/3.1.300/Roslyn/bincore/csc.dll -langversion:?

        Statements, blocks, types, fields, variables and methods
        
        Naming Conventions 
            camelCase - local variable and private variables
            PascalCase / TitleCase - all the others 
*/

// Importing Namespace
using System;
/*  
    Namespace.Type.Method()
    Statically importing Namespace.Type, lets you to use the method directly omiting 
    Namespace.Type for each occurrence of the method inside the program
    eg - System.Console.WriteLine() to just WriteLine()
*/
using static System.Console;
// required for string builder
using System.Text;

namespace ConsoleApp    // Namespace
{
    class Program   // Class
    {
        static void Main(string[] args) //Main method - program entry point
        {    
           
            // Single line comment
            /* This is a
                multi-line comment.*/
            
            // a semicolon indicate end of a statement;
            Clear(); // Clears console
            Console.WriteLine("Hello World!"); // prints to console
            
            // variable declaration and assign
            DateTime today = DateTime.Today;
            //press F12 to choose Go To Definition
            float temperature = 23.5F;

            // Display output in console
            
            // String concatenation
            WriteLine("Temperature on " + today + "is " + temperature);
            
            // String formatting
            //Numbered positional arguments
            WriteLine(
                format: "Temperature on {0:D} is {1} deg.C",
                arg0: today,
                arg1: temperature
            );
            WriteLine("Temperature on {0:D} is {1} deg.C",today, temperature);

            //String Format method
            string formatted = String.Format(
                format: "Temperature on {0:D} is {1} deg.C",
                arg0: today,
                arg1: temperature
            );
            WriteLine(formatted);
       
           /*   String format syntax - {index[,alignment][:formatString]}
                alignment -ve left aligned +ve right aligned
                table style output */
            WriteLine("{0,-12}{1}","Item","Price");
            WriteLine("{0,-12}{1:C1}","Shirt",10.12345);
            WriteLine("{0,-12}{1:C}","Tee",20.12345);
            WriteLine("{0,-12}{1:C3}","Pants",30.1245);

            // Interpolated string
            Console.WriteLine($"Temperature on {today:D} is {temperature} deg.C");
            Console.WriteLine($"The name of the variable is {nameof (today)} ans its value is {today}");

            // String Builder
            var builder = new StringBuilder();
            builder.AppendFormat("word 1");
            builder.AppendFormat(" word 2");
            WriteLine(builder);

            //Getting text input
            Write("What's your name? ");
            string name = ReadLine();
            Write("How old are you? ");
            int age = Convert.ToInt32(ReadLine());
            WriteLine("{0} is {1} years old.", name, age);

            // Getting key input
            WriteLine("Press any key combinations");
            ConsoleKeyInfo key = ReadKey();
            WriteLine($"Key: {key.Key} Char: {key.KeyChar} Modifier: {key.Modifiers}");

            // Read single char
            WriteLine ("Enter user choice");
            char userChoice = (char)Console.Read();
            // captures the enter key that was pressed for the above console read
            ReadKey();
            // assigning from a function or method
            WriteLine (userChoice);
		
            /*
                Arguments passed from the command line
                dotnet run arg0 arg1 arg2 ...
                Arguments are seprated by space, if space is apart of argument, include them in ' ' or " "
            */
            if (args.Length < 4)
            {
                WriteLine("You must specify two colors and dimensions");
                WriteLine("eg. dotnet run red yellow 80 40");
                return; // stop running
            }
            // console colors
            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true);
            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true);
            try
            {
                // API not available other than windows, hence catch runtime exception
                WindowWidth = int.Parse(args[2]);
                WindowHeight = int.Parse(args[2]);
            }
            catch (PlatformNotSupportedException)
            {
                WriteLine("Current OS dose not support changing console size");
            }
        }
    }
}