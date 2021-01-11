namespace Chapter20Interface
{
    // Person child class
    public class Student: Person
    {
        // additional property to base class
        public int Grade { get; set; }
        // method overriding using virtual and override keywords cannot not be done 
        // as base class Person was implemented from IPerson Interface
        // public string GetDetails() => $"{FullName} of age {Age} grade = {Grade}";
    }
}