namespace Chapter19InheritancePolymorphism
{
    public class Professor: Person
    {
        public string Subject { get; set; }
        public override string GetDetails() => $"{FullName} of age {Age} subject = {Subject}";
    }
}