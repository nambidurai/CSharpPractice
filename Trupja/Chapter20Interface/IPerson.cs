namespace Chapter20Interface
{
    // all members are declaration only, no implementaton
    // hence cannot have virtual methods to override in child class
    // all members of interface are public, hence public key is not required 
    // all interface members have to be implemented in child class
    public interface IPerson
    {
        string FullName { get; set; }
        int Age { get; set; }
        string GetDetails();
        string GetDetails(double height);
    }
    public interface ITest
    {
        void test();
    }
}