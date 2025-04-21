using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Oops.Polymorphism
{
    public class RunTimeOverriding
    {
        public class Base
        {
            public virtual void Display() => Console.WriteLine("Base class method");
        }        

        public class Child : Base // Method Overriding
        {
            public override void Display() => Console.WriteLine("Child class method");
            
        }

        public class AnotherChild : Base // Method hiding
        {
            public new void Display() => Console.WriteLine("AnotherChild class method");
        }

        

        public static void Main()
        {
            Base obj1 = new Base();
            obj1.Display(); // Output: Base class method            
                        
            Base obj2 = new Child();
            obj2.Display(); // Output: Child class method
            
            Base obj3 = new AnotherChild();
            obj3.Display(); // Output: Base class method (not overridden)

            AnotherChild obj4 = (AnotherChild)obj3;
            obj4.Display(); // Output: AnotherChild class method

        }
    }
}
