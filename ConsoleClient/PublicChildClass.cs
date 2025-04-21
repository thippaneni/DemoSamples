using CSharpBasics.AccessModifiers;

namespace ConsoleClient
{
    public class PublicChildClass : PublicClass
    {
        public static void Main()
        {
            PublicChildClass childClass = new PublicChildClass();
            childClass.PublicMethod(); // Accessible
            //childClass.InternalMethod(); // Not accessible, Accessible in the same assembly
            childClass.ProtectedMethod(); // Accessible in derived class
            childClass.ProtectedInternalMethod(); // Accessible in the derived class
            // childClass.PrivateMethod(); // Not accessible
        }
    }

    public class PublicChildClass1 : PublicClass
    {
        public static void Main()
        {
            PublicClass childClass = new PublicClass();
            childClass.PublicMethod(); // Accessible
            //childClass.InternalMethod(); // Not accessible, Accessible in the same assembly
            //childClass.ProtectedMethod(); // Accessible in derived class
            //childClass.ProtectedInternalMethod(); // Accessible in the derived class
            // childClass.PrivateMethod(); // Not accessible

            PublicChildClass1 obj = new PublicChildClass1();
            obj.ProtectedMethod();
            obj.ProtectedInternalMethod();
            obj.PublicMethod();
        }
    }
}
