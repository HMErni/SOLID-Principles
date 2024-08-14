namespace LiskovSubstitutionPrinciple.Models;

public class Employee : User
{
    public Employee(string name) : base(name)
    {

    }

    public override void AccessByRole()
    {
        Console.WriteLine($"User {_name} accessed Employee");

    }
}