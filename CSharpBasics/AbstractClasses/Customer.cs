using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.AbstractClasses
{
    public abstract class Customer
    {
        private readonly string _custometId;
        public Customer()
        {
            _custometId = Guid.NewGuid().ToString();
            Console.WriteLine("Customer constructor called");
        }

        public string CustomerId
        {
            get { return _custometId; }
        }
        public void GetCustomerOffers()         
        {
            Console.WriteLine("Customer Offers");
        }
        public abstract void GetCustomerDetails();
    }

    public class RegularCustomer : Customer
    {
        public override void GetCustomerDetails()
        {
            Console.WriteLine("Regular Customer Details");
        }
    }
    public class PremiumCustomer : Customer
    {
        public override void GetCustomerDetails()
        {
            Console.WriteLine("Premium Customer Details");
        }

        public void GetCustomerInfo()
        {
            Console.WriteLine("Premium Customer Details");
        }
    }

    public class AbstractClassDemo()
    {
        public static void Main()
        {
            RegularCustomer regularCustomer = new RegularCustomer();
            var id = regularCustomer.CustomerId;
            regularCustomer.GetCustomerDetails();

            Customer premiumCustomer = new PremiumCustomer();
            premiumCustomer.GetCustomerDetails();
            
        }
    }
}
