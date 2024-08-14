namespace DependencyInversionPrinciple.Services.Email;
public class EmailService : IEmailService
{
    public void SendEmail(string emailContent)
    {
        Console.WriteLine(emailContent);
    }
}