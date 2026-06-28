using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP
{
    public class PaymentServiceBadExample
    {
        public void ProcessPayment(string paymentType, decimal amount)
        {
            if (paymentType == "CreditCard")
            {
                // Process credit card payment
                Console.WriteLine($"Processing credit card payment of {amount:C}");
            }
            else if (paymentType == "PayPal")
            {
                // Process PayPal payment
                Console.WriteLine($"Processing PayPal payment of {amount:C}");
            }
            else if (paymentType == "BankTransfer")
            {
                // Process bank transfer payment
                Console.WriteLine($"Processing bank transfer payment of {amount:C}");
            }
            else
            {
                throw new NotSupportedException($"Payment type '{paymentType}' is not supported.");
            }
        }

    }

    public class ExecutePaymenServiceBadExample
    {
        public void Execute()
        {
            PaymentServiceBadExample service = new PaymentServiceBadExample();
            service.ProcessPayment("PayPal", 1500);
        }
    }
}
