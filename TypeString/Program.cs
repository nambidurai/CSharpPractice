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
        }
    }
}
