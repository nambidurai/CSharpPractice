using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            // string length
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long");
            // string class is array of char
            WriteLine($"First charter i {city[0]} and third chracters is {city[2]}");
            //splitting string
            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach(string item in citiesArray)
            {
                WriteLine(item);
            }
            string fullName = "Alan Jones";
            int indexOfSpace = fullName.IndexOf(" ");
            string firstName = fullName.Substring(0,indexOfSpace);
            string lastName = fullName.Substring(indexOfSpace+1);
            WriteLine(lastName + ", " + firstName);
        }
    } 
}