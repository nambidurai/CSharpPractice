using System;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass x = new MyClass();
            x.streamObj = IamListener;
            Task t = new Task(x.Task);
            t.Start();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void IamListener(int i)
        {
            Console.WriteLine(i);
        }
    }

    class MyClass
    {
        // delegate is a pointer to the function
        // delegate is call back
        // delegate helps us to listen t async data
        // declaration of a delegate
        public delegate void Stream(int i);
        // creating  an instance
        public Stream streamObj;
        public void Task()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                streamObj(i);
            }
        }
    }
}
