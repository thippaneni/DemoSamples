using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Interfaces
{
    // Explicit Interface Implementation
    public class Demo
    {
        public interface A
        {
            void Print();
        }

        public interface B
        {
            void Print();
        }

        public class C : A, B
        {
            void A.Print()
            {
                Console.WriteLine("A");
            }
            void B.Print()
            {
                Console.WriteLine("B");
            }
            
            public static void Main()
            {
                C obj = new C();
                A a = obj;
                B b = obj;
                a.Print(); // Output: A
                b.Print(); // Output: B
            }
        }
    }

    public interface IBingo
    {
        public void Search();
    }

    public interface IGoogle
    {
        public void Search();
    }    

    public class SearchService : IGoogle, IBingo
    {
        void IBingo.Search() => Console.WriteLine("Bingo Search");
        void IGoogle.Search() => Console.WriteLine("Google Search");
    }
}
