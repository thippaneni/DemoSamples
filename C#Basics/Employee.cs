using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
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
            Console.WriteLine($"Id: {Id}, Name: {Name}, Department: {Department}");
        }

        // Static method to create an employee
        public static Employee CreateEmployee(int id, string name, string department)
        {
            return new Employee(id, name, department);
        }
    }
}
