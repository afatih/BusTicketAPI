using System;
using System.Collections.Generic;
using System.Text;
using Ticket.Helpers;

namespace Ticket.BLL.IServices
{
    public interface ITokenService
    {
        string GetToken(int id, AppSettings appSettings);
    }
}
