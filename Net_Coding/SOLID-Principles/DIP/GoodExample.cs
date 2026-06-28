using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.GoodExample
{
    public interface IMessageService
    {
        void Send(string message);
    }

    public class SmsService : IMessageService
    {
        public void Send(string message) => Console.WriteLine($"SMS: {message}");
    }

    public class WhatsAppService : IMessageService
    {
        public void Send(string message) => Console.WriteLine($"WhatsApp: {message}");
    }

    public class NotificationEngine
    {
        private readonly IMessageService _sender;

        // High-level engine depends strictly on the abstraction interface
        public NotificationEngine(IMessageService sender)
        {
            _sender = sender;
        }

        public void Broadcast(string alert)
        {
            _sender.Send(alert);
        }
    }

    public class ExecuteNotification
    {
        static void Main()
        {
            IMessageService sms = new SmsService();
            NotificationEngine notification = new NotificationEngine(sms);
            notification.Broadcast("Order Placed Successfully");
        }
    }
}
