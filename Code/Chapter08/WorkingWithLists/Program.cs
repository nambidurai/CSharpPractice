using System;
using static System.Console;
using System.Collections.Generic;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            
            WriteLine("Initial List");
            foreach (string city in cities)
            {
                WriteLine(city);
            }
            WriteLine($"First city is {cities[0]}");
            WriteLine($"last city is {cities[cities.Count - 1]}");

            cities.Insert(0,"Sydney");
            WriteLine("After inseting");
            foreach (string city in cities)
            {
                WriteLine(city);
            }

            cities.RemoveAt(1);
            cities.Remove("Milan");
            WriteLine("After removing");
            foreach (string city in cities)
            {
                WriteLine(city);
            }
        }
    }
}
