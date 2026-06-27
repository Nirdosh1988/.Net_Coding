using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.SRP
{
    public class CommunicationService : ICommunication
    {
        public CommunicationService() { }
        public async Task<bool> SendEmailNotification(string email, string emailContent)
        {
           //Send notification
           return await Task.FromResult(true);
        }   
    }
}
