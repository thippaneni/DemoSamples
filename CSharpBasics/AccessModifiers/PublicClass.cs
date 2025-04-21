using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.AccessModifiers
{
    public class PublicClass
    {
        // Public members are accessible from anywhere and no restriction       
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }

        // Private members are accessible only within the class.        
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        // Protected members are accessible within the class and by derived classes.        
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }

        // Internal members are accessible only within the same assembly.        
        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }

        // Protected Internal members are accessible within the same assembly and by derived classes.        
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method.");
        }
    }

}
