using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    // Purpose: Ensure only one instance of a class exists
    // Real-time Usage: Logging service, configuration manager, DB connection manager

    // thread safe Singleton class
    // Lazy<T> ensures that the instance is created only when it is needed
    public sealed class Logger
    {        
        private static readonly Lazy<Logger> _instance = new(() => new Logger());
        public static Logger Instance => _instance.Value;

        private Logger() { }

        public void Log(string message) => Console.WriteLine($"Log: {message}");
    }
}
