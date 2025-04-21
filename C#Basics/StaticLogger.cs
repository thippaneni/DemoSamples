using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    public static class StaticLogger
    {
        private static readonly string _logFilePath = "log.txt";

        // Static constructor
        // Acceess Modifiers not allowed
        // Static constructor is called once per type, not per instance
        static StaticLogger()
        {
            _logFilePath = "log1.txt";
        }
        public static void Log(string message) =>
            Console.WriteLine($"Writing logs to {_logFilePath} with message {message}");
    }
}
