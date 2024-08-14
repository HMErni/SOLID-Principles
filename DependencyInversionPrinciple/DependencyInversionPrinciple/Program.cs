using DependencyInversionPrinciple.Services;
using DependencyInversionPrinciple.Services.Email;

namespace DependencyInversionPrinciple;
public class Program
{
    public static void Main()
    {
        var emailService = new EmailService();
        var notification = new Notification(emailService);
        notification.PromotionalNotification();

        var anotherEmailService = new AnotherEmailService();
        var anotherNotification = new Notification(anotherEmailService);
        anotherNotification.PromotionalNotification();

    }
}