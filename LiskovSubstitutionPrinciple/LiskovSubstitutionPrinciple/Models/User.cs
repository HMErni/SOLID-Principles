namespace LiskovSubstitutionPrinciple;

public class User
{
    protected string _name = string.Empty;

    public User(string name)
    {
        _name = name;
    }

    public void LogIn()
    {
        Console.WriteLine($"User {_name} logged in");
    }
    public void LogOut()
    {
        Console.WriteLine($"User {_name} logged out");
    }

    public virtual void AccessByRole()
    {
        Console.WriteLine($"User {_name} accessed user");
    }
}

