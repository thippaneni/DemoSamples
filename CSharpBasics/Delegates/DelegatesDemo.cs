using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Delegates
{
    public class DelegatesDemo
    {
        public delegate void OrderHandler(Guid OrderId);
        
        public class ProcessOrder
        {            
            public void StartOrder(Guid OrderId) 
                => Console.WriteLine($"Starting... for Odrder Id - {OrderId}");

            public void CompleteOrder(Guid OrderId) 
                => Console.WriteLine($"Completing Order... for Odrder Id - {OrderId}");        }

        public static void Main()
        {
            ProcessOrder processOrder = new();
            OrderHandler orderHandler = processOrder.StartOrder; // single delegate
            orderHandler += processOrder.CompleteOrder; // Multicast delegate
            Guid orderId = Guid.NewGuid();
            
            orderHandler(orderId); // hanldes both Start and Complete order
        }
    }
}
