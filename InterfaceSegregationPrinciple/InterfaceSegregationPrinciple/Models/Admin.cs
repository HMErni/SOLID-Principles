using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Models;

public class Admin : IEmployee, IAdmin
{
    public void DeleteUser()
    {
        Console.WriteLine("Admin Class can do DeleteUser");
    }

    public void TimeIn()
    {
        Console.WriteLine("Admin Class can do TimeIn");
    }

    public void Work()
    {
        Console.WriteLine("Admin Class can do Work");
    }
}