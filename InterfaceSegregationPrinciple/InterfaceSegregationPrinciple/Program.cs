using InterfaceSegregationPrinciple.Models;

namespace InterfaceSegregationPrinciple;

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee();
        employee.Work();
        employee.TimeIn();

        Manager manager = new Manager();
        manager.Work();
        manager.TimeIn();
        manager.Manage();

        Admin admin = new Admin();
        admin.Work();
        admin.TimeIn();
        admin.DeleteUser();
    }
}