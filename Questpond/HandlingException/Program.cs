using System;

namespace HandlingException
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter Number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            number2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("output = " + number1 / number2);
            }
            catch (Exception errorMessage)
            {
                Console.WriteLine("Error Occured " + errorMessage);
            }
            Console.ReadKey();
        }
    }
}
