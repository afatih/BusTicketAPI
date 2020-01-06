using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ticket.BLL.IServices;

namespace Ticket.BLL.Services
{
    public class MailService:IMailService
    {
        public async Task SendEmail(string email, string subject, string htmlContent)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("qr1903@gmail.com", "Support");
            var to = new EmailAddress(email);
            var plainTextContent = Regex.Replace(htmlContent, "<[^>]*>", "");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
