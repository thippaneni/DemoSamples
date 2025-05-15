using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    // Strategy Pattern allows you to define a family of algorithms, encapsulate each one, and make them interchangeable at runtime
    // It promotes Open/Closed Principle
    public class PaymentStrategyContext
    {
        private IPaymentStrategy _strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ExecutePayment(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }

    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"Paid ₹{amount} using Credit Card.");
    }

    public class UpiPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"Paid ₹{amount} using UPI.");
    }
}
