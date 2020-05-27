using System;
using static System.Console;
using System.Text;

namespace TypeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();

            DateTime today = DateTime.Now;
            // string formatting
            //syntax - {index[,alignment][:formatString]}
            WriteLine("{0,-12}{1}","Item","Price");
            WriteLine("{0,-12}{1:C1}","Shirt",10.12345);
            WriteLine("{0,-12}{1:C}","Tee",20.12345);
            WriteLine("{0,-12}{1:C3}","Pants",30.1245);
            WriteLine();
            WriteLine("Date  : {0:dd}", today);
            WriteLine("Month : {0:MMM}", today);
            WriteLine("Year  : {0:yyyy}", today);
            WriteLine("Date  : {0:dd}", today);

            /* string formatting using Console.WriteLine(), 
            string.Format() and StringBuilder.AppendFormat() */
            WriteLine();
            WriteLine("Short time : {0:t}", today);
            string str = string.Format("Long date  : {0:D}", today);
            WriteLine(str);

            var builder = new StringBuilder();
            builder.AppendFormat("Short time : {0:t}", today);
            WriteLine(builder);

            //char type is to store single letter or digit or symbol using single quotes
            //assigning literal character
            char letter = 'a';
            char digit ='1';
            char symbol = '$';
            Console.WriteLine ("Enter user choice");
            char userChoice = (char)Console.Read();
            // captures the enter key that was pressed for the above console read
            Console.ReadKey();
            // assigning from a function or method
            Console.WriteLine (userChoice);
            
            //string type is to store multiple letter or digit or symbol using double quotes, which dose not require an arithmetic operation on it
            // assigning literal strings
            string firstName = "Bob";
            string lastName = "Smith";
            string phoneNumber = "(225) 555-4256";
            // assigning from a function or method
            Console.WriteLine ("Enter address");
            string address = Console.ReadLine();
            Console.WriteLine (address);

            // Literal string - double quotes and allows escape characters 
            // with tab separator
            string fullName = "Bob\tSmith";
            // Verbatim sting - prefix with @ to disable escape characters 
            string filePath = @"/etc/apt/sources.list";
            // Interpolated Sting - prefix with $ to enable embedded formatted variables
            fullName = $"{firstName} {lastName}";
            Console.WriteLine (fullName);




        }
    }
}
