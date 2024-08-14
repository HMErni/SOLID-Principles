using InterfaceSegregationPrinciple.Interfaces;


namespace InterfaceSegregationPrinciple.Models;
public class Manager : IEmployee, IManager
{

    public void Manage()
    {
        Console.WriteLine("Manager Class can do Manage");
    }

    public void TimeIn()
    {
        Console.WriteLine("Manager Class can do TimeIn");
    }

    public void Work()
    {
        Console.WriteLine("Manager Class can do Work");
    }
}