namespace LiskovSubstitutionPrinciple.Models;

public class Admin : User
{
    public Admin(string name) : base(name)
    {
    }

    public override void AccessByRole()
    {
        Console.WriteLine($"User {_name} accessed admin");

    }
}
