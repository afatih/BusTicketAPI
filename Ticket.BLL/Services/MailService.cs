using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ticket.BLL.IServices;
using Ticket.Helpers;

namespace Ticket.BLL.Services
{
    public class MailService : IMailService
    {
        IConfiguration _configuration;
        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmail(string email, string subject, string htmlContent)
        {
            try
            {
                var apiKey = _configuration.GetSection("SendGridAPIKey").Value;
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("qr1903@gmail.com", "Support");
                var to = new EmailAddress(email);
                var plainTextContent = Regex.Replace(htmlContent, "<[^>]*>", "");
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
            }
            catch (Exception e)
            {
                throw new AppException(e.Message);

            }
        }
    }
}
