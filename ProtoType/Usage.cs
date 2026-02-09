var original = new Employee
{
    Name = "Nagi",
    Role = "Backend Developer",
    Salary = 10000
};

var copy = original.DeepClone();
copy.Name = "Ahmed";

Console.WriteLine(original.Name); // Nagi
Console.WriteLine(copy.Name);     // Ahmed
