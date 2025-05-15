using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    // Purpose: Convert the interface of a class into another interface that clients expect    
    // Real-time Usage: Adapting a legacy system to a new interface, e.g., converting a file format.
    // External Paymentgateways , Adapting third-party gateway to our system    
    public class ModernSystem() : IModernSystem
    {
        private readonly LegacySystem _legacy = new LegacySystem();
        public void Request() => _legacy.LegacyRequest();
    }

    public class LegacySystem
    {
        public void LegacyRequest() => Console.WriteLine("Legacy Request Called");
    }

    public interface IModernSystem
    {
        void Request();
    }
}
