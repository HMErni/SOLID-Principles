namespace DependencyInversionPrinciple.Services.Email;

public class AnotherEmailService : IEmailService
{
    public void SendEmail(string emailContent)
    {
        Console.WriteLine("Sending email to another email service");
    }
}