namespace Chapter20Interface
{
    // inherit from both IPerson and ITest interface
    // all the members from both IPerson and ITest interface are implemented
    public class Professor: IPerson, ITest
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        // additional property to Interface
        public string Subject { get; set; }
        public string GetDetails() => $"{FullName} of age {Age} subject = {Subject}";
        public string GetDetails(double height)=> $"{FullName} of age {Age} subject = {Subject}";
        public void test()=> System.Console.WriteLine($"{FullName} of age {Age} subject = {Subject}");
    }
}