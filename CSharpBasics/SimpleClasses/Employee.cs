using CSharpBasics.AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.SimpleClasses
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        // Default constructor        
        public Employee()
        {
            Id = 0;
            Name = string.Empty;
            Department = string.Empty;
        }

        // Constructor with parameters
        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        // Method to display employee information
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Department: {Department} \n");
        }

        // Static method to create an employee
        public static Employee CreateEmployee(int id, string name, string department)
        {
            return new Employee(id, name, department);
        }

        public static void Main()
        {
            // Creating an instance of the Employee class
            Employee employee = new(1, "John Doe", "IT");
            employee.DisplayInfo();

            var employee2 = new Employee() { Id = 2, Department = "Admin", Name = "Jane Miller" };
            employee2.DisplayInfo();

            Employee.CreateEmployee(3, "Jane Smith", "HR").DisplayInfo();

            new Employee().DisplayInfo();            
        }
    }

    public class Employee1 : Employee
    {
        public string Role { get; set; }
        // Constructor with parameters
        public Employee1(int id, string name, string department, string role) : base(id, name, department)
        {
            Role = role;
        }
        // Method to display employee information        
    }    
}
