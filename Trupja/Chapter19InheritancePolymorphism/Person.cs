namespace Chapter19InheritancePolymorphism
{
    // base class
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        // virtual method in the base class help to override the method implementation
        // in child class
        public virtual string GetDetails() => $"{FullName} of age {Age}";
        // method overriding - same method name but different signature
        public string GetDetails(double height) => $"{FullName} of age {Age}";
    }
}