using static CSharpBasics.Oops.Abstraction.AbstractionDemo;

Console.WriteLine("Hello, World!");

Circle circle = new() { Radius = 5 };
var area = circle.GetArea();
Console.WriteLine($"Area of Circle: {area}");