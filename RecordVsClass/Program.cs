// See https://aka.ms/new-console-template for more information
using RecordVsClass;

Console.WriteLine("Wlcome to Record Vs Class Demo");

var person1 = new Person("John", 21);
var person2 = new Person("John", 21);
//var person3 = person1 with { Age = 30 };

var customer1 = new Customer { Name = "John", Age = 21 };
var customer2 = new Customer { Name = "John", Age = 21 };

Console.WriteLine($"Person1 == Person2: {person1 == person2}"); // True, value-based equality
Console.WriteLine($"Customer1 == Customer2: {customer1 == customer2}"); // False, reference-based equality
