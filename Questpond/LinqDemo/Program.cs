using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic cusotmer list
            List<Cusotmer> customerList = new List<Cusotmer>();
            customerList.Add(new Cusotmer() { name = "shiv", address = "India" });
            customerList.Add(new Cusotmer() { name = "raju", address = "Nepal" });
            customerList.Add(new Cusotmer() { name = "sham", address = "India" });
            customerList.Add(new Cusotmer() { name = "khadak", address = "India" });
            customerList.Add(new Cusotmer() { name = "guru", address = "India" });
            // linq query
            var cusotmerFilterList = (from temp in customerList
                                      where temp.address == "India"
                                      select temp).ToList<Cusotmer>();
            
            foreach (var item in cusotmerFilterList)
            {
                Console.WriteLine(item.name);
            }

            Console.ReadKey();
        }
    }
    // cusotmer data type
    public class Cusotmer
    {
        public string name = "";
        public string address = "";
    }
}
