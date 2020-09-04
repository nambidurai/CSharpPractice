using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class  Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List <Person> Children = new List<Person>();
        public const string Species = "Homo Sapiens";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        //constructor
        public Person()
        {
            Name ="Unkown";
            Instantiated = DateTime.Now;
        }
        /// <summary>
        /// my first method
        /// </summary>
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }
        /// <summary>
        /// my second method 
        /// </summary>
        /// <returns> a string</returns>
        public string GetOrigin()
        {
            return $"{Name} was born on a {HomePlanet}";
        }

        public (string, int) GetFruit()
        {
            return ("Apples",5);
        }
        
        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }
        // say hello
        public string SayHello()
        {
            return $"{Name} says Hello!";
        }
        /// <summary>
        /// say hello method
        /// </summary>
        /// <param name="name">
        /// enter the name
        /// </param>
        /// <returns>
        /// none
        /// </returns>
        public string SayHello(string name)
        {
            return $"{Name} says Hello! to {name}";
        }

        public string OptionalParameters(
            string command ="run",
            double number = 0.0,
            bool active = true)
            {
                return string.Format(
                    format: "Command is {0}, number is {1}, active is {2}",
                    arg0: command, arg1: number, arg2: active );
            } 

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameter cannot have a default valve and must be initialized inside the method
            z=99;
            x++;
            y++;
            z++;
        }
        
    } 
}
