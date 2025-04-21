using CSharpBasics.AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.AccessModifiersClient
{
    public class ChildClass : PublicClass
    {
        public static void Main()
        {
            ChildClass childClass = new ChildClass();
            childClass.PublicMethod(); // Accessible
            // childClass.PrivateMethod(); // Not accessible, outside the class
            childClass.ProtectedMethod(); // Not accessible, only accessible in derived classes
            childClass.InternalMethod(); // Accessible in the same assembly
            childClass.ProtectedInternalMethod(); // Accessible in the derived class
        }
    }

    public class Test()
    {
        public static void Main()
        {
            PublicClass publicClass = new PublicClass();
            publicClass.PublicMethod(); // Accessible
            // publicClass.PrivateMethod(); // Not accessible, outside the class
            // publicClass.ProtectedMethod(); // Not accessible, only accessible in derived classes
            publicClass.InternalMethod(); // Accessible in the same assembly
            publicClass.ProtectedInternalMethod(); // Accessible in the same assembly
            
        }
    }
}
