namespace Chapter20Interface
{
    // inherit from IPerson interface
    // all the members of IPerson interface are implemented
    public class Person : IPerson
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        // methods cannot override as interface have no implementation 
        public string GetDetails() => $"{FullName} of age {Age}";
        // all the members of IPerson interface have to be implemented
        public string GetDetails(double height) => $"{FullName} of age {Age}";
    }
}