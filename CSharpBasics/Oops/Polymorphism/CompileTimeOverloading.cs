using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Oops.Polymorphism
{
    public class CompileTimeOverloading
    {
        public static void Add(int a, int b) => Console.WriteLine($"Sum of {a} and {b} is {a + b}");
        public static void Add(double a, double b) => Console.WriteLine($"Sum of {a} and {b} is {a + b}");
        public static void Add(int a, double b) => Console.WriteLine($"Sum of {a} and {b} is {a + b}");
        public static void Add(double a, int b) => Console.WriteLine($"Sum of {a} and {b} is {a + b}");
        public static void Add(int a, int b, int c) => Console.WriteLine($"Sum of {a}, {b} and {c} is {a + b + c}");

        
        public static void Add(int a, int b, params int[] c)
        {
            if (c == null)
            {
                Console.WriteLine("No additional numbers provided.");                
            }
            else
            {
                Console.WriteLine($"Sum of {a}, {b} and additional numbers is {a + b + c.Sum()}");
            }            
        }

        public static string Add(string a, string b)
        {
            return a + b;
        }

        public static void Main()
        {
            Console.WriteLine("Compile Time Polymorphism");
                        
            Add(10, 20); // Calls the first method
            Add(10.5, 20.5); // Calls the second method
            Add(10, 20.5); // Calls the third method
            Add(10.5, 20); // Calls the fourth method
            Add(10, 20, 30); // Calls the fifth method
            Add(10, 20, 30, 40, 50); // Calls the sixth method with params
            Console.WriteLine(Add("Hello", "World")); // Calls the seventh method
        }

    }
}
