using static System.Console;

namespace Chapter04WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table");
            for (int i = 1; i <=12; i++)
            {
                WriteLine($"{i} x {number} = {i*number}");
            }
        }
        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 to 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("you did not enter a valid number!");
                }
            }while (isNumber);
        }
        static void Main(string[] args)
        {
            RunTimesTable();            
        }
    }
}
