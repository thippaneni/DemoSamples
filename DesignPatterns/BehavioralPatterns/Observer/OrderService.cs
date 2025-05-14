using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    public class OrderService
    {
        private readonly List<IOrderObserver> _observers = [];

        public void RegisterObserver(IOrderObserver observer) =>
            _observers.Add(observer);

        public void UnregisterObserver(IOrderObserver observer) =>
            _observers.Remove(observer);

        public void PlaceOrder(string orderId)
        {
            Console.WriteLine($"Order {orderId} placed.");

            foreach (var observer in _observers)
            {
                observer.OnOrderPlaced(orderId);
            }
        }
    }

    public interface IOrderObserver
    {
        void OnOrderPlaced(string orderId);
    }
    public class EmailNotification : IOrderObserver
    {
        public void OnOrderPlaced(string orderId) =>
            Console.WriteLine($"Email: Order {orderId} confirmation sent.");
    }

    public class SmsNotification : IOrderObserver
    {
        public void OnOrderPlaced(string orderId) =>
            Console.WriteLine($"SMS: Order {orderId} status message sent.");
    }
}
