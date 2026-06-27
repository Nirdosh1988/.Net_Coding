using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciples.SRP
{
    public class OrderServiceGoodExample
    {
        private readonly ICommunication _communication;
        public OrderServiceGoodExample(ICommunication communication) 
        {
          _communication = communication;
        }
        public async Task<OrderResponse> CreateOrder(dynamic orderRequest)
        {
            //Create order logic

            //Send email notification
            _ = await _communication.SendEmailNotification("test@gmail.com","Order created successfully");

            return new OrderResponse(Guid.NewGuid(),"Test",100,"Inprogress", DateTime.UtcNow);
        }
    }
}
