using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

public class FakeEmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // Bu örnekte e-posta gönderimi yapılmıyor, sadece loglama yapılabilir.
        Console.WriteLine($"E-posta gönderiliyor: {email}, Konu: {subject}");
        return Task.CompletedTask;
    }
}
