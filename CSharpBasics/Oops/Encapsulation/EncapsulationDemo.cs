using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Oops.Encapsulation
{
    public class EncapsulationDemo
    {
        public class BankAccount
        {
            private decimal _balance; // Encapsulated field

            public void Deposit(decimal amount)
            {
                if (amount > 0)
                    _balance += amount;
            }

            public decimal GetBalance()
            {
                return _balance - 10;
            }
        }

        public static void Main()
        {
            BankAccount account = new();
            account.Deposit(1000);
            // account._balance = 5000; // Not accessible, private field            
            var balance = account.GetBalance();
            Console.WriteLine($"Account Balance first time: {balance}");
            account.Deposit(1000);
            // account._balance = 5000; // Not accessible, private field            
            balance = account.GetBalance();
            Console.WriteLine($"Account Balance second time: {balance}");
        }
    }
    
}
