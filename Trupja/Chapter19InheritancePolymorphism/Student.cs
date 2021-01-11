namespace Chapter19InheritancePolymorphism
{
    // Person child class
    public class Student: Person
    {
        // additional property to base class
        public int Grade { get; set; }
        // method overriding use virtual and override keywords
        public override string GetDetails() => $"{FullName} of age {Age} grade = {Grade}";
    }
}