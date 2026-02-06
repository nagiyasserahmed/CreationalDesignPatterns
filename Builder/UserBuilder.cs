public class UserBuilder
{
    private string _name;
    private string _email;
    private int _age;
    private string _address;

    public UserBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public UserBuilder SetEmail(string email)
    {
        _email = email;
        return this;
    }

    public UserBuilder SetAge(int age)
    {
        _age = age;
        return this;
    }

    public UserBuilder SetAddress(string address)
    {
        _address = address;
        return this;
    }

    public User Build()
    {
        return new User(_name, _email, _age, _address);
    }
}
