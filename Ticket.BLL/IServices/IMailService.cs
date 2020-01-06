using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.BLL.IServices
{
    public interface IMailService
    {
         Task SendEmail(string email, string subject, string htmlContent);
        
    }
}
