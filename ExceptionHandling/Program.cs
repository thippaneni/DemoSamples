using ExceptionHandling;

try
{
    var result = Calculator.Divide(10, 0);
    Console.WriteLine($"Result: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Caught in Main: {ex.Message}");
}
finally
{
    Console.WriteLine("This block executes after the try-catch.");
    Console.WriteLine("It is used for cleanup code, like closing files or releasing resources.");
}

Console.ReadLine();