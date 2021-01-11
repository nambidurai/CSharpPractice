using System;

namespace Chapter19InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(){Age = 15, FullName = "John Smith"};
            System.Console.WriteLine(person.GetDetails());     
            Professor professor = new Professor(){Age = 45, FullName = "Jimmy Snack", Subject = "Math"};
            System.Console.WriteLine(professor.GetDetails()); 
            Student student = new Student(){Age = 18, FullName = "Joe Doe", Grade = 8};
            System.Console.WriteLine(student.GetDetails()); 
        }
    }
}
