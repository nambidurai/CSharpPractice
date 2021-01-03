using System;

// boxing and unboxing have preformance degrade, avoid when possible
namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = i;
            // boxing coping value type to referance type
            // data moved from stack to heap
            object obj = j;
            // unboxing coping referance type to value type
            // data moved from heap to stack
            int z = (int)obj;
            Console.WriteLine("Hello World!");
        }
    }
}
