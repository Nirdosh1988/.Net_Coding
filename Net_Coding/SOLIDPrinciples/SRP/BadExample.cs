using System;
using System.Threading.Tasks;

namespace SolidPriciples.SRP.BadExample
{
    public class OrderService
    {
        public OrderService() { }
        public async Task CreateOrder(dynamic orderRequest)
        {
            //Create order logic

            //Send email notification
            _ = await SendEmailNotification(new { Email = "test@t.com" });
        }
        private static Task<bool> SendEmailNotification(dynamic notificationRequest)
        {
            //Send notification logic
            return Task.FromResult(true);
        }
    }
}
