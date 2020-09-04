/* 
    Local variables
        1. Declared inside methods and memory is released when medhod returns
        2. Values types are release while reference types wait for garbage collection
        3. var keyword is used to declare local variables
        4. Complier infers the data type from assignment made during variable declaration 
 */

using System;
using static System.Console;

namespace TypeVar
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("{0,-18}{1}", "Variable", "Type");
            // uint
            var minInYear = 525_600u;
            Console.WriteLine($"{nameof(minInYear),-18}{minInYear.GetType()}");
            // ulong
            var population = 66_000_000uL; // 66 million
            Console.WriteLine($"{nameof(population),-18}{population.GetType()}");
            // int - default inference 
            var deflation = 525_600;
            Console.WriteLine($"{nameof(deflation),-18}{deflation.GetType()}");
            // long 
            var timeTravel = 66_000_000L; // 66 million
            Console.WriteLine($"{nameof(timeTravel),-18}{timeTravel.GetType()}");
            // float
            var speed = 30.5f;
            Console.WriteLine($"{nameof(speed),-18}{speed.GetType()}");
            // double - default can be also suffixed "d"
            var distance = 50.55;
            Console.WriteLine($"{nameof(distance),-18}{distance.GetType()}");
            // decimal
            var price = 60.50m;
            Console.WriteLine($"{nameof(price),-18}{price.GetType()}");
            // bool
            var happy = true;
            Console.WriteLine($"{nameof(happy),-18}{happy.GetType()}");
            // char
            var grade = 'A';
            Console.WriteLine($"{nameof(grade),-18}{grade.GetType()}");
            // DateTime
            var today = DateTime.Now;
            Console.WriteLine($"{nameof(today),-18}{today.GetType()}");
            // string
            var name = "Gandhi";
            Console.WriteLine($"{nameof(name),-18}{name.GetType()}");      
        }
    }
}
