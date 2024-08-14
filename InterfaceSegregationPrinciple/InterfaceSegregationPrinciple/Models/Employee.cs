using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Models;

public class Employee : IEmployee
{
    public void TimeIn()
    {
        Console.WriteLine("Employee Class can do TimeIn");
    }

    public void Work()
    {
        Console.WriteLine("Employee Class can do Work");
    }
}