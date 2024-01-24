using SecureTrade.Services.MailServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Services.MailServices.Services
{
    public interface IEmailServices
    {
        void SendEmail(Message message);
    }
}
