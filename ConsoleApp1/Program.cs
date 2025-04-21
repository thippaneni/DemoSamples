// See https://aka.ms/new-console-template for more information
using CSharpBasics.AccessModifiers;
using CSharpBasics.PartialClasses;

int x = 100;
float y = x; // Implicit conversion from int to float

Console.WriteLine(x); // Output: 100
Console.WriteLine(y); // Output: 100

float z = 100.5f;
int a = (int)z; // Explicit conversion from float to int

Console.WriteLine(z);
Console.WriteLine(a);