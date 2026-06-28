using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP.GoodExample
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
    public class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Credit Card.");
        }
    }
    public class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid ₹{amount} using PayPal.");
        }
    }
    public class PaymentService
    {
        public void ProcessPayment(IPayment payment, decimal amount)
        {
            payment.Pay(amount);
        }
    }
    public class ExecutePaymenService
    {
        public void Execute()
        {
            PaymentService service = new PaymentService();
            IPayment payment = new PayPalPayment();
            service.ProcessPayment(payment, 1500);
        }
    }

}
