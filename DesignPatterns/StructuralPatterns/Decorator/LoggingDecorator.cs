using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class LoggingDecorator(IPaymentService service) : PaymentServiceDecorator(service)
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Logging: Payment of ₹{amount} is being processed.");
            _service.ProcessPayment(amount);
            Console.WriteLine($"Logging: Payment of ₹{amount} has been processed.");
        }
    }   

    public abstract class PaymentServiceDecorator(IPaymentService service) : IPaymentService
    {
        protected readonly IPaymentService _service = service;
        public abstract void ProcessPayment(decimal amount);
    }

    public interface IPaymentService
    {
        void ProcessPayment(decimal amount);
    }

    public class PaymentService : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of ₹{amount}");
        }
    }    
}
