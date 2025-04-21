using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Oops.Inheritance
{
    public class ClassExample
    {
        public class Parent 
        { 
         
        }        

        public class Child : Parent
        {
            public void Display() => Console.WriteLine("Child class method");
        }

        public class  GrandChild : Parent
        {
            
        }
    }
}
