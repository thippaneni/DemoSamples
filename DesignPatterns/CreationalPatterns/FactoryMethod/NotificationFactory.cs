using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    // Purpose: Define an interface for creating an object, but let subclasses alter the type of objects that will be created
    // Real-time Usage: Notification service that selects type at runtime.

    public class NotificationFactory
    {
        public static INotification Create(string type) =>
            type switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "event" => new EventNotification(),
                _ => throw new NotImplementedException()
            };
    }

    public interface INotification
    {
        void Notify(string to);
    }

    public class EmailNotification : INotification
    {
        public void Notify(string to) => Console.WriteLine($"Email sent to {to}");
    }

    public class SmsNotification : INotification
    {
        public void Notify(string to) => Console.WriteLine($"SMS sent to {to}");
    }

    public class EventNotification : INotification
    {
        public void Notify(string to) => Console.WriteLine($"Event sent to {to}");
    }
}
