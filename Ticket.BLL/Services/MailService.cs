using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
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
                var message = new MailMessage()
                {
                    From = new MailAddress("noreply@fatih.com","Metro Support"),
                    Subject = subject,
                    Body = htmlContent
                };

                message.IsBodyHtml = true;
                message.To.Add(new MailAddress(email));

                var credential = new NetworkCredential("fatihtest1903@gmail.com", "grhn43gurhan");

                using (var emailClient = new SmtpClient())
                {
                    emailClient.Host = "smtp.gmail.com";
                    emailClient.Port = 587;
                    emailClient.EnableSsl = true;
                    emailClient.UseDefaultCredentials = false;
                    emailClient.Credentials = credential;
                    emailClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                    emailClient.Send(message);
                }

            }
            catch (Exception e)
            {

                throw new AppException(e.Message);
            }


     
        }
    }
}
