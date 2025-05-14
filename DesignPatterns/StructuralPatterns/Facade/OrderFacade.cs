using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Facade
{
    public class OrderFacade
    {
        private readonly InventoryService _inventory;
        private readonly DiscountService _discount;
        private readonly PaymentGatewayService _payment;
        private readonly EmailService _email;

        public OrderFacade()
        {
            _inventory = new InventoryService();
            _discount = new DiscountService();
            _payment = new PaymentGatewayService();
            _email = new EmailService();
        }

        public void PlaceOrder(string productId, string userId, string email, decimal amount)
        {
            _inventory.CheckStock(productId);
            _discount.ApplyDiscount(userId);
            _payment.ProcessPayment(amount);
            _email.SendConfirmation(email);
        }
    }

    public class InventoryService
    {
        public void CheckStock(string productId) => Console.WriteLine("Stock checked.");
    }
    public class DiscountService
    {
        public void ApplyDiscount(string userId) => Console.WriteLine("Discount applied.");
    }
    public class PaymentGatewayService
    {
        public void ProcessPayment(decimal amount) => Console.WriteLine($"Payment of ₹{amount} processed.");
    }
    public class EmailService
    {
        public void SendConfirmation(string userEmail) => Console.WriteLine("Confirmation email sent.");
    }
}
