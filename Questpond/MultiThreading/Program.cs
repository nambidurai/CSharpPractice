using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating threads  - time slicing
            // Thread t1 = new Thread(new ThreadStart(fun1));
            // Thread t2 = new Thread(new ThreadStart(fun2));

            // creating tasking - parallel running 
            // Task t1 = new Task(fun1);
            // Task t2 = new Task(fun2);

            // t1.Start();
            // t2.Start();

            fun1();
            fun2();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        static async void fun1()
        {
            for (int i = 0; i < 100; i++)
            {
                // sleep 0.5 sec
                // Thread.Sleep(500);
                await Task.Delay(500);
                Console.WriteLine("fun 1 = " + i);
            }
        }
        static async void fun2()
        {
            for (int i = 0; i < 100; i++)
            {
                // sleep 0.5 sec
                // Thread.Sleep(500);
                await Task.Delay(500);
                Console.WriteLine("fun 2 = " + i);
            }
        }
    }
}
