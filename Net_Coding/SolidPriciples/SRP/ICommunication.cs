using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.SRP
{
    public interface ICommunication
    {
        Task<bool> SendEmailNotification(string email, string emailContent);
    }
}
