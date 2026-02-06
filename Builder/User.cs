public class User
{
    public string Name { get; }
    public string Email { get; }
    public int Age { get; }
    public string Address { get; }

    internal User(string name, string email, int age, string address)
    {
        Name = name;
        Email = email;
        Age = age;
        Address = address;
    }
}
