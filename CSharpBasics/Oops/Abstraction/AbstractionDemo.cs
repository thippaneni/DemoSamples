using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Oops.Abstraction
{
    public class AbstractionDemo
    {
        public interface IShape
        {
            double GetArea();
        }

        public class Circle : IShape
        {
            public double Radius { get; set; }
            public double GetArea() => Math.PI * Radius * Radius;
        }

        public static void Main()
        {
            Circle circle = new() { Radius = 5 };
            var area = circle.GetArea();
            Console.WriteLine($"Area of Circle: {area}");
        }
    }
}
