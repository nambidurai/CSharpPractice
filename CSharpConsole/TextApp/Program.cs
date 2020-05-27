using System;

namespace TextApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
