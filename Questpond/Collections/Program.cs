using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // array is fixed type and size - strongly typed
            // hence better perofrmance and less flexability
            // integer only array
            int[] intarr = new int[5];
            // all collections are zero indexed
            intarr[0] = 10;
            intarr[1] = 20;
            intarr[2] = 30;
            // string only array
            string[] strarr =new string[5];
            strarr[0] = "car";
            strarr[1] = "dog";
            strarr[2] = "rat";
            // array list collection no size and type limitation
            // hence poor perforance and more flexability
            ArrayList arrlist = new ArrayList();
            arrlist.Add(1);
            arrlist.Add(1.05);
            arrlist.Add("bat");
            // generic arrary list is best of both worlds
            // better performace and flexability
            // generic int list
            List<int> genericIntList = new List<int>();
            genericIntList.Add(10);
            genericIntList.Add(20);
            genericIntList.Add(30);
            // generic string list
            List<string> genericStrList = new List<string>();
            genericStrList.Add("cat");
            genericStrList.Add("dot");
            genericStrList.Add("rat");

            for (int i = 0; i < intarr.Length; i++)
            {
                Console.WriteLine(intarr[i]);
            }

            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
