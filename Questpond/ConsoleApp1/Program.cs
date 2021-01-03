using System;
using ClassLibraryDemo;

// complier decloration to check for Common language specificaiton
[assembly: CLSCompliant(true)]

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // console app demo
            Console.WriteLine("Hello World C#");

            // class libary demo
            Class1 x = new Class1();
            Console.WriteLine(x.GetCurrentDateTime());

            // variable demo
            int counter = 0;
            counter++;
            Console.WriteLine(counter);

            //datatypes
            int i = 100;
            double d = 100.23;
            string str = "928";
            bool b = true;

           //implicit casting 
            d = i;
            Console.WriteLine("implicit casting " + d);

            //explict casting
            d = 100.23;
            i = (int)d;
            Console.WriteLine("explicit casting " + i);

            //conversation 
            i = Convert.ToInt32(str);
            Console.WriteLine("conversation " + i);

            // wait for user input prevent console app from closing
            Console.Read();
        }
    }
}
