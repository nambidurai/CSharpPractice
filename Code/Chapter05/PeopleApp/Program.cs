using System;
using static System.Console;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            // WriteLine(bob.ToString());
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime (1965,12,22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeus;
            bob.BucketList = WondersOfTheAncientWorld.Pyramid
            | WondersOfTheAncientWorld.StatueOfZeus;
            // bob.BucketList = (WondersOfTheAncientWorld)5;
            bob.Children.Add(new Person{Name = "Jeff"});
            bob.Children.Add(new Person{Name = "Mary"});
            WriteLine($"{bob.Name} was bon on {bob.DateOfBirth:d}");
            WriteLine($"{bob.Name} favorite place is {(int)bob.FavoriteAncientWonder}");
            WriteLine($"{bob.Name} bucketlist is {bob.BucketList}");
            WriteLine($"{bob.Name} has {bob.Children.Count} children");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine(bob.Children[child].Name);
            }
            WriteLine($"{bob.Name} is a {Person.Species}");
            WriteLine($"{bob.Name} was born in {bob.HomePlanet}");

            var blankPerson = new Person();
            WriteLine (
                format : "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated
            );

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());

            (string, int) fruit = bob.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            var fruitNamed = bob.GetNamedFruit();
            WriteLine($"{fruitNamed.Name}, {fruitNamed.Number} there are.");

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("emily"));
            WriteLine(bob.OptionalParameters());
            WriteLine(bob.OptionalParameters("jump",98.5));
            WriteLine(bob.OptionalParameters(number:52.7, command:"Hide"));
            WriteLine(bob.OptionalParameters("Poke", active: false));

            int a = 10, b=20, c=30;
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");
            a = 10; b=20;
            WriteLine($"Before: a = {a}, b = {b}, d dose not exist");
            bob.PassingParameters(a, ref b, out int d);
            WriteLine($"After: a = {a}, b = {b}, d = {d}");

            BankAccount.IntrestRate=0.012M;
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;
            WriteLine(format: "{0} earned {1:C} interest.",
            arg0: jonesAccount.AccountName,
            arg1: jonesAccount.Balance*BankAccount.IntrestRate);

            var sam = new Person
            {
                Name = "sam",
                DateOfBirth = new DateTime(1972,1,27)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);
            sam.FavoriteIceCream = "Chocolate Fudge";
            sam.FavoritePrimaryColor = "red";
            WriteLine($"sam's Favorite icecream is {sam.FavoriteIceCream}");
            WriteLine($"sam's Favorite color is {sam.FavoritePrimaryColor}");

        }
    }
}