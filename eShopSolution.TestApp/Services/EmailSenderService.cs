using Microsoft.AspNetCore.Identity.UI.Services;

namespace eShopSolution.TestApp.Services
{
    public class EmailSenderService : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

        }
    }
}
