using LiskovSubstitutionPrinciple.Models;

namespace LiskovSubstitutionPrinciple;
class Program
{
    static void Main(string[] args)
    {
        Admin admin = new Admin("admin");
        Employee Employee = new Employee("member");
        User user = new User("bruh");
        DoSomething(admin);
        DoSomething(Employee);
        DoSomething(user);
    }


    public static void DoSomething(User user)
    {
        user.LogIn();
        user.AccessByRole();
        user.LogOut();
    }

}