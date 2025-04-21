using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.AccessModifiers
{
    public class Test1 : PublicClass
    {
        public static void Main()
        {
            Test1 test1 = new Test1();
            test1.PublicMethod(); // Accessible
            test1.InternalMethod(); // Accessible in the same assembly
            test1.ProtectedMethod(); // Accessible in derived class
            test1.ProtectedInternalMethod(); // Accessible in the derived class
            // Test.PrivateMethod(); // Not accessible
        }
    }

    public class Test
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
