/*

*/
using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add("this is a string");
            myArrayList.Add(12.5);
            myArrayList.AddRange(new ArrayList(){"John",24, 25.8});
            myArrayList.Insert(1,"fist insert");
            myArrayList.Insert(3,"third insert");
            myArrayList.Remove("third insert");
            myArrayList.Remove(1);
            myArrayList.Clear();
            myArrayList.AddRange(new ArrayList(){10,50});
            myArrayList.Sort();
            myArrayList.Reverse();
            Console.WriteLine("array contains 50 ? " + myArrayList.Contains(50));
            Console.WriteLine("count {0} and capcity {1}",myArrayList.Count, myArrayList.Capacity);
            myArrayList.Add(25);
            Console.WriteLine("count {0} and capcity {1}",myArrayList.Count, myArrayList.Capacity);

            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
                        
        }
    }
}
