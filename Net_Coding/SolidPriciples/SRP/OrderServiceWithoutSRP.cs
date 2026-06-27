using System;
using System.Threading.Tasks;

namespace SolidPriciples.SRP
{
    public class OrderServiceWithoutSRP
    {
        public OrderServiceWithoutSRP() { }
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
