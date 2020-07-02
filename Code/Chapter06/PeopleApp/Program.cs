using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var trialPerson = new Person {Name="trial", DateOfBirth= new DateTime(1982,05,02)};
            // trialPerson.WriteToConsole();

            var harry = new Person {Name = "Harry"};
            var mary = new Person {Name = "Mary"};
            var jill = new Person {Name = "Jill"};
            
            //call instance medhod
            var baby1 = mary.ProcreateWtih(harry);

            //call static method
            var baby2 = Person.Procreate(harry, jill);

            //call an operator
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children's");
            WriteLine($"{mary.Name} has {mary.Children.Count} children's");
            WriteLine($"{jill.Name} has {jill.Children.Count} children's");
            WriteLine($"Harry's first child name is {harry.Children[0].Name}");

            // call local function 
            WriteLine($"5! is {Person.Factorial(5)}");

            // events
            static void Harry_Shout (object sender, EventArgs e)
            {
                Person p = (Person)sender;
                WriteLine($"{p.Name} is this angry : {p.AngerLevel}");
            }
            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            // implementing interferace 
            Person [] people = 
            {
                new Person {Name="Simon"},
                new Person {Name="Jenny"},
                new Person {Name="Adam"},
                new Person {Name="Richard"}
            };

            WriteLine ("Initial list of people: ");
            foreach (var person in people)
            {
                WriteLine(person.Name);
            }

            WriteLine("sort using IComparable");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine(person.Name);
            }      

            WriteLine("sort using IComparer");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine(person.Name);
            }  

            //non-Generics
            var t1 = new Thing();
            t1.Data = 42;
            WriteLine ($"Thing with an integer :{t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "Apple";
            WriteLine ($"Thing with an string :{t2.Process("Apple")}");

            //Generics
            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine ($"GenericThing with an integer :{gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "Apple";
            WriteLine ($"GenericThing with an string :{gt2.Process("Apple")}");

            //generic method
            string number1 ="4";
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");
            byte number2 = 3;
            WriteLine($"{number2} squared is {Squarer.Square(number2)}");

            // struct
            var dv1 = new DisplacementVector(3,5);
            var dv2 = new DisplacementVector(-2,7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv3.X},{dv3.Y})");

        }
    }
}