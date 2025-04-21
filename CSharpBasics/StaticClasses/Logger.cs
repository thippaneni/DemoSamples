using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.StaticClasses
{
    
    public static class Logger
    {
        private static readonly string _logFilePath = "log.txt";

        // Static constructor
        // Acceess Modifiers not allowed
        // Static constructor is called once per type, not per instance
        // Will have only parameter less constructor
        static Logger()
        {
            _logFilePath = "log1.txt";
        }
        public static void LogMessage(string message) =>
            Console.WriteLine($"Writing logs to {_logFilePath} with message {message}");
        
    }

    public static class RoleConstants
    {
        public static readonly string DevRole = "Dev";
    }

    public class LoggerTest
    {
        public static void Main()
        {            
            Logger.LogMessage("This is a test log message...");
            Logger.LogMessage("This is a test log message....");
            Logger.LogMessage("This is a test log message...");
            Logger.LogMessage("This is a test log message...");
            Console.ReadLine();
        }
    }

}
