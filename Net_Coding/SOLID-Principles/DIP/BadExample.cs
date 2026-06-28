using SOLID_Principles.DIP.GoodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.BadExample
{
    public class SmsService
    {
        public void SendSms(string msg) => Console.WriteLine($"SMS: {msg}");
    }

    public class NotificationEngine
    {
        private SmsService _smsService = new SmsService(); // Tight coupling

        public void Broadcast(string alert)
        {
            _smsService.SendSms(alert);
        }
    }
    public class ExecuteNotification
    {
        static void Main()
        {
            NotificationEngine notification = new NotificationEngine();
            notification.Broadcast("Order Placed Successfully");
        }
    }
}
