using DependencyInversionPrinciple.Services.Email;

namespace DependencyInversionPrinciple.Services;

public class Notification
{
    private IEmailService _emailService;

    public Notification(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void PromotionalNotification()
    {
        var content = "You have won a gift!";
        _emailService.SendEmail(content);
    }
}