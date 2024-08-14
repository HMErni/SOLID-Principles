namespace DependencyInversionPrinciple.Services.Email;

public interface IEmailService
{
    void SendEmail(string emailContent);
}