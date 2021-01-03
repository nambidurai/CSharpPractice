using System;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5000; i++)
            {
                // int i1 = 10;
                // int y1 = i1;

                Cusotmer x = new Cusotmer();
                x.name = "questpond";

            }
            Console.Read();
        }
    }

    public class Cusotmer
    {
        public string name;
    }
}
