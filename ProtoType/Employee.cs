public class Employee : IPrototype<Employee>
{
    public string Name { get; set; }
    public string Role { get; set; }
    public decimal Salary { get; set; }

    public Employee ShallowClone()
    {
        return (Employee)this.MemberwiseClone();
    }

    public Employee DeepClone()
    {
        return new Employee
        {
            Name = this.Name,
            Role = this.Role,
            Salary = this.Salary
        };
    }

}
