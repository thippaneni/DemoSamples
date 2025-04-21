using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Oops.Inheritance
{
    public class InheritanceSample
    {
        public class Animal
        {            
            public Animal()
            {
                Console.WriteLine("Animal Constructor...");
            }

            public void Eat() => Console.WriteLine("Can Eat...");
        }

        public class Dog : Animal
        {
            public Dog()
            {
                Console.WriteLine("Dog Constructor...");
            }

            public void Bark() => Console.WriteLine("Can Bark...");
        }

        public static void Main() 
        {
            Console.WriteLine("Inheritance Sample");
            Dog dog = new();
            dog.Eat(); // Inherited method from Animal class
            dog.Bark(); // Dog class method
        }
    }
}
