using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP
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
    public class PaymentServiceGoodExample
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
            PaymentServiceGoodExample service = new PaymentServiceGoodExample();
            IPayment payment = new PayPalPayment();
            service.ProcessPayment(payment, 1500);
        }
    }

}
