using System;
using System.IO;

namespace FileReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\Users\Dheep\source\repos\CSharpPractice\Questpond\Temp\data.txt", "hello world");
            string fileContents = File.ReadAllText(@"C:\Users\Dheep\source\repos\CSharpPractice\Questpond\Temp\data.txt");
            Console.WriteLine(fileContents);
        }
    }
}
