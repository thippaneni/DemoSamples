using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculator
    {
        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: Division by zero is not allowed. {ex.Message}");
                return 0;
                throw; // Rethrow the exception
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw; // Rethrow the exception
            }
            finally
            {
                Console.WriteLine("Execution completed.");
                Console.WriteLine("This Finally block always executes, whether or not an exception occurred.");
            }
        }
    }
}
